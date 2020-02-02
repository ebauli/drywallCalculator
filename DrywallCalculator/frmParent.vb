Public Class frmParent

    Public Property myDrywallPiecesList As New List(Of DrywallPieces)
    Public Property myRoomList As New List(Of Room)
    Public Property MyCornerList As New List(Of Corner)
    Public Property MyWallList As New List(Of Wall)
    Public Property myDataAccessClass As New DataAccessClass


    Public Property projectID As Integer
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
        frmReport.myRoomList = myRoomList
        frmReport.myDrywallPiecesList = myDrywallPiecesList
        frmReport.myDataAccessClass = myDataAccessClass
        frmReport.Show()
    End Sub

    Private Sub ReportsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportsToolStripMenuItem.Click

    End Sub

    Private Sub frmParent_GotFocus(sender As Object, e As EventArgs) Handles Me.GotFocus

    End Sub

    Private Sub RoomInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RoomInformationToolStripMenuItem.Click
        Dim frm_rptRoomInfo As New frm_rptRoomInfo()
        frm_rptRoomInfo.MdiParent = Me
        frm_rptRoomInfo.myRoomList = myRoomList
        frm_rptRoomInfo.Show()
    End Sub
End Class