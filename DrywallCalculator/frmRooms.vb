Public Class frmRooms

    Public Property roomID As Integer
    Public Property projectID As Integer
    Public Property roomName As String
    Private sql As New SQLControl
    Private tableId As Integer

    Private Sub FrmRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label3.Text = projectID

        sql.addParam("@projectID", projectID)
        sql.ExecQuery("select * from rooms where project_Id = @projectID")

        For Each r As DataRow In sql.sqlDS.Tables(0).Rows
            cbxRooms.Items.Add(r("room_name"))
            Label9.Text = r("room_id")
            Label10.Text = r("room_name")

        Next

        sql.addParam("@cornerName", txtCornerName.Text)
        sql.addParam("@cornerDescription", txtCornerDesc.Text)
        sql.addParam("@ls_distance", txtLsDistance.Text)
        sql.addParam("@rs_distance", txtRsDistance.Text)
        sql.addParam("@height_ff", txtHeightFF.Text)
        sql.addParam("@projectID", projectID)
        sql.addParam("@roomID", roomID)

        sql.ExecQuery("INSERT INTO CORNERS (corner_name , corner_description , ls_distance , rs_distance , height_ff , project_id , room_id) values (@cornerName,@cornerDescription,@ls_distance,@rs_distance,@projectID,@roomID )")

        MsgBox(roomID)

        loadGrid()
    End Sub


    Private Sub loadGrid()

        sql.addParam("@projectID", projectID)
        sql.addParam("@roomID", roomID)
        sql.ExecQuery("select * from corners where projectID = @projectID and room_id = @roomID ")
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
        sql.addParam("@projectID", projectID)
        sql.addParam("@roomID", roomID)


        sql.ExecQuery("INSERT INTO CORNERS (corner_name , corner_description , ls_distance , rs_distance , height_ff , project_id , room_id) values (@cornerName,@cornerDescription,@ls_distance,@rs_distance,@projectID,@roomID )")
        roomID = sql.tableID

        MsgBox(roomID)
        loadGrid()


    End Sub

    Private Sub cbxRooms_TextChanged(sender As Object, e As EventArgs) Handles cbxRooms.TextChanged





    End Sub

    Private Sub cbxRooms_SelectedValueChanged(sender As Object, e As EventArgs) Handles cbxRooms.SelectedValueChanged


        Dim roomName As String
        roomName = cbxRooms.Text
        sql.addParam("@roomName", roomName)
        sql.addParam("@projectID", projectID)

        sql.ExecQuery("select * from corners where project_Id = @projectID and room_name = @roomName")
        If sql.recordcount > 0 Then
            DataGridView1.DataSource = sql.sqlDS.Tables(0)
            roomID = 68
            MsgBox(roomID)
            Dim r As DataRow
            For Each r In sql.sqlDS.Tables(0).Rows
                MsgBox(r("room_id").ToString())
            Next


        Else
            MsgBox("please poulate corner")
        End If

    End Sub
End Class