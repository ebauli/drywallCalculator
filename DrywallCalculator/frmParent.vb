Public Class frmParent

    Public Property myDrywallPiecesList As New List(Of DrywallPieces)
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

    Private Sub DrywallPiecesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DrywallPiecesToolStripMenuItem.Click
        Dim frmReport As New frmReport1()
        frmReport.MdiParent = Me
        frmReport.myDrywallPiecesList = myDrywallPiecesList
        frmReport.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click

    End Sub

    Private Sub frmParent_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

    End Sub
End Class