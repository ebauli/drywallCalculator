Public Class Form3
    Private sql As New SQLControl
    Public Property projectId As Integer
    Private tableId As Integer
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtRoomDescription.TextChanged

    End Sub


    Private Sub btnCreateRoom_Click(sender As Object, e As EventArgs) Handles btnCreateRoom.Click

        createRoom()



    End Sub

    Private Sub createRoom()
        updateRoom()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load

        Label3.Text = projectId


    End Sub

    Private Sub updateRoom()
        sql.addParam("@roomName", txtRoomName.Text)
        sql.addParam("@roomDescription", txtRoomDescription.Text)
        sql.addParam("@project_id", projectId)
        sql.ExecQuery("INSERT INTO ROOMS (room_name , room_description , project_id) values (@roomName,@roomDescription,@project_id )")
        tableId = sql.tableID
        MsgBox(tableId)
        loadGrid()


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub loadGrid()

        sql.ExecQuery("select * from rooms")
        DataGridView1.DataSource = sql.sqlDS.Tables(0)
        DataGridView1.Rows(0).Selected = True


    End Sub
End Class