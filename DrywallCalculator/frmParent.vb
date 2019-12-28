Public Class frmParent


    Private Sub frmParent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AddNewProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewProjectToolStripMenuItem.Click
        Dim f2 As New Form2
        Form2.MdiParent = Me
        Form2.Show()

    End Sub

    Private Sub OpenExistingProjectToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenExistingProjectToolStripMenuItem.Click
        Dim f4 As New Form4
        Form4.MdiParent = Me
        Form4.Show()
    End Sub
End Class