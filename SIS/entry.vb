Imports System.IO
Imports System.Data.OleDb
Imports System.DateTime
Public Class entry
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB-Project_SIS\sis.accdb")

    Private Sub entry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Dashboard
        DateTimePicker1.Value = Date.Now.Date
        DateTimePicker2.Value = Date.Now.Date
        DateTimePicker3.Value = Date.Now.Date
        DateTimePicker4.Value = Date.Now.Date

        cn.Open()
        Dim cmd2 As New OleDbCommand("select * from student", cn)
        cmd2.ExecuteNonQuery()
        Dim da2 As New OleDbDataAdapter(cmd2)
        Dim ds2 As New DataTable
        da2.Fill(ds2)
        cbsid2.DataSource = ds2
        cbsid2.DisplayMember = "sid"
        cn.Close()

        generateid()

    End Sub



    Private Sub btnphoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnphoto.Click
        Using img1 As OpenFileDialog = New OpenFileDialog

            img1.Filter = "choose image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

            If img1.ShowDialog() = DialogResult.OK Then
                tbpp.Text = Path.GetFullPath(img1.FileName)

                pbphoto.Image = Image.FromFile(img1.FileName)
            End If

        End Using
    End Sub

    Private Sub btn10m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn10m.Click
        Using img1 As OpenFileDialog = New OpenFileDialog

            img1.Filter = "choose image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

            If img1.ShowDialog() = DialogResult.OK Then
                tb10mp.Text = Path.GetFullPath(img1.FileName)

                pb10m.Image = Image.FromFile(img1.FileName)
            End If

        End Using
    End Sub

    Private Sub btn12m_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn12m.Click
        Using img1 As OpenFileDialog = New OpenFileDialog

            img1.Filter = "choose image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

            If img1.ShowDialog() = DialogResult.OK Then
                tb12mp.Text = Path.GetFullPath(img1.FileName)

                pb12m.Image = Image.FromFile(img1.FileName)
            End If

        End Using
    End Sub

    Private Sub btntc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btntc.Click
        Using img1 As OpenFileDialog = New OpenFileDialog

            img1.Filter = "choose image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

            If img1.ShowDialog() = DialogResult.OK Then
                tb12tcp.Text = Path.GetFullPath(img1.FileName)

                pbtc.Image = Image.FromFile(img1.FileName)
            End If

        End Using
    End Sub

    Private Sub btna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btna.Click
        Using img1 As OpenFileDialog = New OpenFileDialog

            img1.Filter = "choose image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

            If img1.ShowDialog() = DialogResult.OK Then
                tbap.Text = Path.GetFullPath(img1.FileName)

                pba.Image = Image.FromFile(img1.FileName)
            End If

        End Using
    End Sub

    Private Sub btnp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnp.Click
        Using img1 As OpenFileDialog = New OpenFileDialog

            img1.Filter = "choose image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

            If img1.ShowDialog() = DialogResult.OK Then
                tbpbp.Text = Path.GetFullPath(img1.FileName)

                pbp.Image = Image.FromFile(img1.FileName)
            End If

        End Using
    End Sub

    Private Sub btnc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnc.Click
        Using img1 As OpenFileDialog = New OpenFileDialog

            img1.Filter = "choose image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

            If img1.ShowDialog() = DialogResult.OK Then
                tbcomp.Text = Path.GetFullPath(img1.FileName)

                pbc.Image = Image.FromFile(img1.FileName)
            End If

        End Using
    End Sub

    
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        tb10mp.Text = ""
        tb12mp.Text = ""
        tb12tcp.Text = ""
        tbadd.Text = ""
        tbap.Text = ""
        tbcomp.Text = ""
        tbfname.Text = ""
        tbmail.Text = ""
        tbname.Text = ""
        tbpbp.Text = ""
        tbphone.Text = ""
        tbpp.Text = ""
        tbreg.Text = ""
        tbroll.Text = ""
        tbsid1.Text = ""
        cbsid2.Text = Nothing
        cbcom.Text = Nothing
        cbgen.Text = Nothing
        cbreligion.Text = Nothing
        pb10m.Image = Nothing
        pb12m.Image = Nothing
        pba.Image = Nothing
        pbc.Image = Nothing
        pbp.Image = Nothing
        pbphoto.Image = Nothing
        pbtc.Image = Nothing

        generateid()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cn.Open()
        Dim cmd As New OleDbCommand("insert into student(sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum,photop,10mp,12mp,12tcp,aadharp,passbookp,communityp) values ('" & tbsid1.Text & "','" & tbname.Text & "','" & tbfname.Text & "','" & cbgen.Text & "','" & DateTimePicker1.Text & "','" & cbreligion.Text & "','" & cbcom.Text & "','" & tbadd.Text & "','" & tbphone.Text & "','" & tbmail.Text & "','" & cbdept.Text & "','" & DateTimePicker3.Text & "','" & DateTimePicker4.Text & "','" & DateTimePicker2.Text & "','" & tbroll.Text & "','" & tbreg.Text & "','" & tbpp.Text & "','" & tb10mp.Text & "','" & tb12mp.Text & "','" & tb12tcp.Text & "','" & tbap.Text & "','" & tbpbp.Text & "','" & tbcomp.Text & "')", cn)
        cmd.ExecuteNonQuery()
        MsgBox("Record Added")
        cn.Close()
    End Sub

   
    Private Sub tbphone_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbphone.KeyPress
        Dim ch As Char = e.KeyChar
        If Not Char.IsDigit(ch) And Not Char.IsControl(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub tbname_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbname.KeyPress, tbfname.KeyPress
        Dim ch As Char = e.KeyChar
        If Char.IsDigit(ch) And Not Char.IsControl(ch) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnss_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnss.Click
        cn.Open()
        Dim cmd1 As New OleDbCommand("select * from student where sid=" & cbsid2.Text & "", cn)
        cmd1.ExecuteNonQuery()
        Dim dr As OleDbDataReader
        dr = cmd1.ExecuteReader
        If dr.Read() Then
            tbname.Text = dr("sname")
            tbsid1.Text = dr("sid")
            tbfname.Text = dr("fname")
            cbgen.Text = dr("gender")
            DateTimePicker1.Text = dr("dob")
            cbreligion.Text = dr("religion")
            cbcom.Text = dr("community")
            tbadd.Text = dr("address")
            tbphone.Text = dr("phone")
            tbmail.Text = dr("email")
            cbdept.Text = dr("department")
            DateTimePicker3.Text = dr("ayfrom")
            DateTimePicker4.Text = dr("ayto")
            DateTimePicker2.Text = dr("jd")
            tbroll.Text = dr("rollnum")
            tbreg.Text = dr("regnum")
            tbpp.Text = dr("photop")
            tb10mp.Text = dr("10mp")
            tb12mp.Text = dr("12mp")
            tb12tcp.Text = dr("12tcp")
            tbap.Text = dr("aadharp")
            tbpbp.Text = dr("passbookp")
            tbcomp.Text = dr("communityp")
            pbphoto.Image = Image.FromFile(tbpp.Text)
            pb10m.Image = Image.FromFile(tb10mp.Text)
            pb12m.Image = Image.FromFile(tb12mp.Text)
            pbtc.Image = Image.FromFile(tb12tcp.Text)
            pba.Image = Image.FromFile(tbap.Text)
            pbp.Image = Image.FromFile(tbpbp.Text)
            pbc.Image = Image.FromFile(tbcomp.Text)
        Else
            MsgBox("enter correct data")
        End If
        cn.Close()

       

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        cn.Open()
        Dim cmd3 As New OleDbCommand("delete from student where sid =" & tbsid1.Text & "", cn)
        cmd3.ExecuteNonQuery()
        MsgBox("Record Deleted")
        cn.Close()



    End Sub
    Private Function generateid() As Double

        cn.Open()
        Dim cmd6 As New OleDbCommand("select max(sid) from student", cn)
        cmd6.ExecuteNonQuery()

        Dim dr6 As OleDbDataReader
        dr6 = cmd6.ExecuteReader
        If dr6.Read Then
            If Val(dr6(0)) > 0 Then
                Dim b_no As Double
                b_no = Val(dr6(0))
                tbsid1.Text = (b_no + 1)

            ElseIf (Convert.IsDBNull(Val(dr6(0)))) Then
                tbsid1.Text = "1"

            Else
                tbsid1.Text = "1"
            End If
        End If


        cn.Close()
        Return (tbsid1.Text)
    End Function

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        cn.Open()
        Dim cmd4 As New OleDbCommand("update student set sname='" & tbname.Text & "',fname='" & tbfname.Text & "',gender='" & cbgen.Text & "',dob='" & DateTimePicker1.Text & "',religion='" & cbreligion.Text & "',community='" & cbcom.Text & "',address='" & tbadd.Text & "',phone=" & tbphone.Text & ",email='" & tbmail.Text & "',department='" & cbdept.Text & "',ayfrom='" & DateTimePicker3.Text & "',ayto='" & DateTimePicker4.Text & "',jd='" & DateTimePicker2.Text & "',rollnum='" & tbroll.Text & "',regnum='" & tbreg.Text & "',photop='" & tbpp.Text & "',10mp='" & tb10mp.Text & "',12mp='" & tb12mp.Text & "',12tcp='" & tb12tcp.Text & "',aadharp='" & tbap.Text & "',passbookp='" & tbpbp.Text & "',communityp='" & tbcomp.Text & "' where sid=" & tbsid1.Text & " ", cn)
        cmd4.ExecuteNonQuery()
        MsgBox("Record Updated")
        cn.Close()


    End Sub

    Private Sub pbphoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbphoto.Click

    End Sub
End Class