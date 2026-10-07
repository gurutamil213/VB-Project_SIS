Public Class Dashboard

    Private Sub Form2_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub


    Private Sub entrymenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles entrymenu.Click
        entry.Show()
        find.Close()
        proofs.Close()
        Info_form.Close()
    End Sub

    Private Sub findmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles findmenu.Click
        entry.Close()
        find.Show()
        proofs.Close()
        Info_form.Close()
    End Sub

    Private Sub certificatemenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles certificatemenu.Click
        entry.Close()
        find.Close()
        proofs.Show()
        Info_form.Close()
    End Sub

    Private Sub infomenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles infomenu.Click
        entry.Close()
        find.Close()
        proofs.Close()
        Info_form.Show()
    End Sub

    Private Sub exitmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exitmenu.Click
        Application.Exit()
    End Sub
End Class