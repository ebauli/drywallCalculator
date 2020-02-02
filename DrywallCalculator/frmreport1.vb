Imports System.Windows.Forms
Public Class frmReport1

    Public Property MyWallList As New List(Of Wall)
    Public Property MyCornerList As New List(Of Corner)
    Public Property myRoomList As New List(Of Room)
    Public Property myDrywallPiecesList As New List(Of DrywallPieces)
    Public Property roomdrywallPieces As New List(Of RoomDrywallPieces)
    Public Property myDataAccessClass As New DataAccessClass
    Public ds As New Microsoft.Reporting.WinForms.ReportDataSource

    ' Dim rs As New ReportDataSource

    Private Sub frmReport1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MsgBox(myDrywallPiecesList.Count)
        '  Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource
        '  ds.Name = "DataSet1"
        '   ds.Value = myDrywallPiecesList
        '  Dim frmRepoert As New frmReport1
        '   frmRepoert.ReportViewer1.LocalReport.DataSources.Clear()
        '  frmRepoert.ReportViewer1.LocalReport.DataSources.Add(ds)
        ' frm.ReportViewer1.LocalReport.ReportEmbeddedResource = "ChiroRecallList.RptFutureVisits.rdlc";
        '  frmRepoert.ReportViewer1.LocalReport.DisplayName = "Your File Name Goes Here" + "_" + DateTime.Now.ToString("yyyyMMdd HH:mm");


        'myDataAccessClass.myDrywallPiecesList = myDrywallPiecesList
        'MsgBox(myDrywallPiecesList.Count)
        'MsgBox(myDataAccessClass.myDrywallPiecesList.Count)
        'myDataAccessClass.myRoomList = myRoomList
        'MsgBox(myRoomList.Count)
        'MsgBox(myDataAccessClass.myRoomList.Count)

        '  Dim piecesInRoom As New List(Of DrywallPieces)
        ' Dim myDrywallPiecesList As New List(Of DrywallPieces)

        '  Dim result1 = From ee In myDrywallPiecesList Order By ee.get_RoomID

        DrywallPiecesBindingSource.DataSource = myDrywallPiecesList
        MsgBox(roomdrywallPieces.Count)
        ReportViewer1.AutoSize = True
        ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DrywallPiecesBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles DrywallPiecesBindingSource.CurrentChanged

    End Sub
End Class