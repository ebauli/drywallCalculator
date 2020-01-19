Imports System.Windows.Forms
Public Class frmReport1

    Public Property MyWallList As New List(Of Wall)
    Public Property MyCornerList As New List(Of Corner)
    Public Property myRoomList As New List(Of Room)
    Public Property myDrywallPiecesList As New List(Of DrywallPieces)
    Public ds As New Microsoft.Reporting.WinForms.ReportDataSource

    ' Dim rs As New ReportDataSource

    Private Sub frmReport1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(myDrywallPiecesList.Count)
        '  Dim ds As New Microsoft.Reporting.WinForms.ReportDataSource
        '  ds.Name = "DataSet1"
        '   ds.Value = myDrywallPiecesList
        '  Dim frmRepoert As New frmReport1
        '   frmRepoert.ReportViewer1.LocalReport.DataSources.Clear()
        '  frmRepoert.ReportViewer1.LocalReport.DataSources.Add(ds)
        ' frm.ReportViewer1.LocalReport.ReportEmbeddedResource = "ChiroRecallList.RptFutureVisits.rdlc";
        '  frmRepoert.ReportViewer1.LocalReport.DisplayName = "Your File Name Goes Here" + "_" + DateTime.Now.ToString("yyyyMMdd HH:mm");




        DrywallPiecesBindingSource.DataSource = myDrywallPiecesList
        ReportViewer1.AutoSize = True
        ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub DrywallPiecesBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles DrywallPiecesBindingSource.CurrentChanged

    End Sub
End Class