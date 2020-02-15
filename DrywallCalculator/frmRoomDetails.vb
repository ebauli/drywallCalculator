
Public Class frmRoomDetails
    Private sql As New SQLControl

    Public Property projectID As Integer
    Private Sub frmRoomDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox(projectID)


        sql.addParam("@project_id", projectID)
        sql.ExecQuery("SELECT        rooms.room_name,(select corner_name from corners where walls.lc_id = corner_id) AS lc_name, (select corner_name from corners where walls.rc_id = corner_id) AS rc_name,  walls.wall_id, walls.project_id, walls.room_id, walls.wall_name, walls.wall_description, walls.lc_id, walls.rc_id, walls.width, walls.has_reveal, walls.bb_height, walls.reveal_height, walls.strip_size
FROM            rooms INNER JOIN
                         walls ON rooms.room_id = walls.room_id
WHERE        (walls.project_id = @project_id) ")

        'Me.DataGridView1.DataSource = sql.sqlDS.Tables(0)
        'sql.ExecQuery("select * from rooms where project_ID = @project_id ")
        'If sql.recordcount > 0 Then
        '    ' DataGridView1.DataSource = sql.sqlDS.Tables(0)

        '    'DataGridView1.Rows(0).Selected = True
        'End If
        '' DataGridView1.DataSource = sql.sqlDS.Tables(0)





        Me.DrywallDataSet1.EnforceConstraints = False
        Me.DataTable1TableAdapter.Fill(DrywallDataSet1.DataTable1, projectID)
        'Me.DataTable1TableAdapter.Fill(sql.sqlDS.Tables(0), projectID)
        DataTable2BindingSource.DataSource = sql.sqlDS.Tables(0)
        Me.DataTable2TableAdapter.Fill(DrywallDataSet1.DataTable2, projectID)

        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class