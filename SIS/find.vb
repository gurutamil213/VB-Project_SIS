Imports System.IO
Imports System.Data.OleDb
Public Class find
    Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\VB-Project_SIS\sis.accdb")

    Private Sub find_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.MdiParent = Dashboard

        cn.Open()
        Dim cmd1 As New OleDbCommand("select distinct department from student", cn)
        cmd1.ExecuteNonQuery()
        Dim da1 As New OleDbDataAdapter(cmd1)
        Dim ds1 As New DataTable
        da1.Fill(ds1)
        cbdep.DataSource = ds1
        cbdep.DisplayMember = "department"
        cn.Close()

        cn.Open()
        Dim cmd2 As New OleDbCommand("select distinct ayfrom from student", cn)
        cmd2.ExecuteNonQuery()
        Dim da2 As New OleDbDataAdapter(cmd2)
        Dim ds2 As New DataTable
        da2.Fill(ds2)
        cbay.DataSource = ds2
        cbay.DisplayMember = "ayfrom"
        cn.Close()

        cn.Open()
        Dim cmd3 As New OleDbCommand("select distinct community from student", cn)
        cmd3.ExecuteNonQuery()
        Dim da3 As New OleDbDataAdapter(cmd3)
        Dim ds3 As New DataTable
        da3.Fill(ds3)
        cbcom.DataSource = ds3
        cbcom.DisplayMember = "community"
        cn.Close()

        cn.Open()
        Dim cmd4 As New OleDbCommand("select distinct gender from student", cn)
        cmd4.ExecuteNonQuery()
        Dim da4 As New OleDbDataAdapter(cmd4)
        Dim ds4 As New DataTable
        da4.Fill(ds4)
        cbgen.DataSource = ds4
        cbgen.DisplayMember = "gender"
        cn.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CheckBox1.Checked = True Then
            cn.Open()
            Dim cmd As New OleDbCommand("select sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum from student where department='" & cbdep.Text & "'", cn)
            cmd.ExecuteNonQuery()
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        ElseIf CheckBox2.Checked = True Then
            cn.Open()
            Dim cmd As New OleDbCommand("select sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum from student where ayfrom='" & cbay.Text & "'", cn)
            cmd.ExecuteNonQuery()
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        ElseIf CheckBox3.Checked = True Then
            cn.Open()
            Dim cmd As New OleDbCommand("select sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum from student where community='" & cbcom.Text & "'", cn)
            cmd.ExecuteNonQuery()
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        ElseIf CheckBox4.Checked = True Then
            cn.Open()
            Dim cmd As New OleDbCommand("select sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum from student where gender='" & cbgen.Text & "'", cn)
            cmd.ExecuteNonQuery()
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True Then
            cn.Open()
            Dim cmd As New OleDbCommand("select sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum from student where department='" & cbdep.Text & "' and ayfrom='" & cbay.Text & "' ", cn)
            cmd.ExecuteNonQuery()
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        ElseIf CheckBox1.Checked = True And CheckBox3.Checked = True Then
            cn.Open()
            Dim cmd As New OleDbCommand("select sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum from student where department='" & cbdep.Text & "' and community='" & cbcom.Text & "' ", cn)
            cmd.ExecuteNonQuery()
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        ElseIf CheckBox1.Checked = True And CheckBox4.Checked = True Then
            cn.Open()
            Dim cmd As New OleDbCommand("select sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum from student where department='" & cbdep.Text & "' and gender='" & cbgen.Text & "' ", cn)
            cmd.ExecuteNonQuery()
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        ElseIf CheckBox2.Checked = True And CheckBox3.Checked = True Then
            cn.Open()
            Dim cmd As New OleDbCommand("select sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum from student where ayfrom='" & cbay.Text & "' and community='" & cbcom.Text & "' ", cn)
            cmd.ExecuteNonQuery()
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        ElseIf CheckBox2.Checked = True And CheckBox4.Checked = True Then
            cn.Open()
            Dim cmd As New OleDbCommand("select sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum from student where ayfrom='" & cbay.Text & "' and gender='" & cbgen.Text & "' ", cn)
            cmd.ExecuteNonQuery()
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        ElseIf CheckBox3.Checked = True And CheckBox4.Checked = True Then
            cn.Open()
            Dim cmd As New OleDbCommand("select sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum from student where  community='" & cbcom.Text & "' and gender='" & cbgen.Text & "' ", cn)
            cmd.ExecuteNonQuery()
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True Then
            cn.Open()
            Dim cmd As New OleDbCommand("select sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum from student where department='" & cbdep.Text & "'and ayfrom='" & cbay.Text & "' and community='" & cbcom.Text & "' ", cn)
            cmd.ExecuteNonQuery()
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox4.Checked = True Then
            cn.Open()
            Dim cmd As New OleDbCommand("select sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum from student where department='" & cbdep.Text & "'and ayfrom='" & cbay.Text & "' and gender='" & cbgen.Text & "' ", cn)
            cmd.ExecuteNonQuery()
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        ElseIf CheckBox1.Checked = True And CheckBox4.Checked = True And CheckBox3.Checked = True Then
            cn.Open()
            Dim cmd As New OleDbCommand("select sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum from student where department='" & cbdep.Text & "'and gender='" & cbgen.Text & "' and community='" & cbcom.Text & "' ", cn)
            cmd.ExecuteNonQuery()
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        ElseIf CheckBox4.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True Then
            cn.Open()
            Dim cmd As New OleDbCommand("select sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum from student where gender='" & cbgen.Text & "'and ayfrom='" & cbay.Text & "' and community='" & cbcom.Text & "' ", cn)
            cmd.ExecuteNonQuery()
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = True And CheckBox3.Checked = True And CheckBox4.Checked = True Then
            cn.Open()
            Dim cmd As New OleDbCommand("select sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum from student where department='" & cbdep.Text & "'and ayfrom='" & cbay.Text & "' and community='" & cbcom.Text & "' and gender='" & cbgen.Text & "' ", cn)
            cmd.ExecuteNonQuery()
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        Else
            cn.Open()
            Dim cmd As New OleDbCommand("select sid,sname,fname,gender,dob,religion,community,address,phone,email,department,ayfrom,ayto,jd,rollnum,regnum from student ", cn)
            cmd.ExecuteNonQuery()
            Dim da As New OleDbDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            DataGridView1.DataSource = dt
            cn.Close()
        End If
    End Sub
End Class