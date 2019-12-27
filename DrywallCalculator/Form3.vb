Public Class Form3
    Private sql As New SQLControl
    Public Property projectId As Integer
    Public Property projectName As String

    Private tableId As Integer


    Private Sub btnCreateRoom_Click(sender As Object, e As EventArgs) Handles btnCreateRoom.Click

        createRoom()



    End Sub

    Private Sub createRoom()
        updateRoom()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load

        Label3.Text = projectId
        Label5.Text = projectName
        loadGrid()

    End Sub

    Private Sub updateRoom()
        sql.addParam("@roomName", txtRoomName.Text)
        sql.addParam("@roomDescription", txtRoomDescription.Text)
        sql.addParam("@project_id", projectId)
        sql.addParam("@drywallThickness", cbxDrywallThickness.Text)
        sql.ExecQuery("INSERT INTO ROOMS (room_name , room_description , project_id, room_Drywall_Thickness) values (@roomName,@roomDescription,@project_id, @drywallThickness )")
        tableId = sql.tableID
        loadGrid()


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub loadGrid()
        sql.addParam("@project_id", Label3.Text)
        sql.ExecQuery("select PROJECT_NAME from PROJECT where project_ID = @project_id ")
        sql.addParam("@project_id", Label3.Text)
        sql.ExecQuery("select * from rooms where project_ID = @project_id ")
        If sql.recordcount > 0 Then
            DataGridView1.DataSource = sql.sqlDS.Tables(0)
            DataGridView1.Rows(0).Selected = True
        End If
        DataGridView1.DataSource = sql.sqlDS.Tables(0)


    End Sub

    Private Sub BtnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        sql.sqlDA.UpdateCommand = New MySql.Data.MySqlClient.MySqlCommandBuilder(sql.sqlDA).GetUpdateCommand
        sql.sqlDA.Update(sql.sqlDS)
        loadGrid()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim frmRoomsN As New frmRooms()
        frmRoomsN.projectID = projectId
        frmRoomsN.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbxDrywallThickness.SelectedIndexChanged

    End Sub
End Class