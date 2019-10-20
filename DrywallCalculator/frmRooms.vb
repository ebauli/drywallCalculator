Public Class frmRooms

    Public Property roomID As Integer
    Public Property projectID As Integer
    Private sql As New SQLControl
    Private tableId As Integer

    Private Sub FrmRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = projectID
        sql.addParam("@projectID", projectID)
        sql.ExecQuery("select room_name from rooms where project_Id = @projectID")
        For Each r As DataRow In sql.sqlDS.Tables(0).Rows
            cbxRooms.Items.Add(r("room_name"))
        Next

        sql.addParam("@cornerName", txtCornerName.Text)
        sql.addParam("@cornerDescription", txtCornerDesc.Text)
        sql.addParam("@ls_distance", txtLsDistance.Text)
        sql.addParam("@rs_distance", txtRsDistance.Text)
        sql.addParam("@height_ff", txtHeightFF.Text)
        sql.addParam("@projectID", projectId)
        sql.addParam("@roomID", roomID)

        sql.ExecQuery("INSERT INTO CORNERS (corner_name , corner_description , ls_distance , rs_distance , height_ff , project_id , room_id) values (@cornerName,@cornerDescription,@ls_distance,@rs_distance,@projectID,@roomID )")

        MsgBox(roomID)

        loadGrid()
    End Sub


    Private Sub loadGrid()

        sql.addParam("@projectID", projectID)
        sql.ExecQuery("select * from corners where projectID = @projectID ")
        If sql.recordcount > 0 Then
            DataGridView1.DataSource = sql.sqlDS.Tables(0)
            DataGridView1.Rows(0).Selected = True
        End If



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        sql.addParam("@cornerName", txtCornerName.Text)
        sql.addParam("@cornerDescription", txtCornerDesc.Text)
        sql.addParam("@ls_distance", txtLsDistance.Text)
        sql.addParam("@rs_distance", txtRsDistance.Text)
        sql.addParam("@height_ff", txtHeightFF.Text)
        sql.addParam("@projectID", projectId)
        sql.addParam("@roomID", roomID)

        sql.ExecQuery("INSERT INTO CORNERS (corner_name , corner_description , ls_distance , rs_distance , height_ff , project_id , room_id) values (@cornerName,@cornerDescription,@ls_distance,@rs_distance,@projectID,@roomID )")
        roomID = sql.tableID

        MsgBox(roomID)
        loadGrid()


    End Sub
End Class