Imports System.IO
Imports System.Data.OleDb
Public Class proofs
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB-Project_SIS\sis.accdb")

    
    Private Sub btnprint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnprint.Click
        If RadioButton7.Checked = True Then
            PictureBox1.Image = Image.FromFile(tbphoto.Text)
        ElseIf RadioButton1.Checked = True Then
            PictureBox1.Image = Image.FromFile(tb10m.Text)
        ElseIf RadioButton2.Checked = True Then
            PictureBox1.Image = Image.FromFile(tb12m.Text)
        ElseIf RadioButton3.Checked = True Then
            PictureBox1.Image = Image.FromFile(tbtc.Text)
        ElseIf RadioButton4.Checked = True Then
            PictureBox1.Image = Image.FromFile(tbaadhar.Text)
        ElseIf RadioButton5.Checked = True Then
            PictureBox1.Image = Image.FromFile(tbpb.Text)
        ElseIf RadioButton6.Checked = True Then
            PictureBox1.Image = Image.FromFile(tbcom.Text)
        End If

    End Sub

   
    Private Sub proofs_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Dashboard
        cn.Open()
        Dim cmd As New OleDbCommand("select * from student", cn)
        cmd.ExecuteNonQuery()
        Dim da As New OleDbDataAdapter(cmd)
        Dim ds As New DataTable
        da.Fill(ds)
        ComboBox1.DataSource = ds
        ComboBox1.DisplayMember = "sid"
        cn.Close()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn.Open()
        Dim cmd1 As New OleDbCommand("select * from student where sid=" & ComboBox1.Text & "", cn)
        cmd1.ExecuteNonQuery()
        Dim dr As OleDbDataReader
        dr = cmd1.ExecuteReader
        If dr.Read() Then
            tbphoto.Text = dr("photop")
            tb10m.Text = dr("10mp")
            tb12m.Text = dr("12mp")
            tbtc.Text = dr("12tcp")
            tbaadhar.Text = dr("aadharp")
            tbpb.Text = dr("passbookp")
            tbcom.Text = dr("communityp")
        Else
            MsgBox("enter correct data")
        End If
        cn.Close()
    End Sub

  
End Class