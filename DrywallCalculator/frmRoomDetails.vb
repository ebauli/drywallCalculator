

Public Class frmRoomDetails
    Public Property projectID As Integer
    Private Sub frmRoomDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(projectID)
        Me.DataTable1TableAdapter.Fill(DrywallDataSet1.DataTable1, projectID)
        Me.DataTable2TableAdapter.Fill(DrywallDataSet1.DataTable2, projectID)
        ' DataTable1BindingSource.DataSource = Me.DataTable2TableAdapter.Fill(DrywallDataSet1.DataTable2, projectID)
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class