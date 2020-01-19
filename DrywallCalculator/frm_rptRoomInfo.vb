Public Class frm_rptRoomInfo

    Private sql As New SQLControl
    Dim projectID As Integer
    Public Property myRoomList As List(Of Room)

    Private Sub frm_rptRoomInfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim myMDI As frmParent 'change to whatever class your MDI uses
        myMDI = DirectCast(Me.MdiParent, frmParent)
        projectID = myMDI.projectID

        'sql.addParam("@project_id", projectID)
        'sql.ExecQuery("select PROJECT_NAME from PROJECT where project_ID = @project_id ")
        'sql.addParam("@project_id", projectID)
        'sql.ExecQuery("select * from rooms where project_ID = @project_id ")
        ' If sql.recordcount > 0 Then
        ' RoomBindingSource.DataSource = sql.sqlDS.Tables(0)
        RoomBindingSource.DataSource = myRoomList
        ReportViewer1.AutoSize = True
        ReportViewer1.RefreshReport()
            Me.ReportViewer1.RefreshReport()

        'End If


        Me.ReportViewer1.RefreshReport()
    End Sub
End Class