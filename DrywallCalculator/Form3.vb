Public Class Form3
    Private sql As New SQLControl
    Public Property projectId As Integer
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtRoomDescription.TextChanged

    End Sub


    Private Sub btnCreateRoom_Click(sender As Object, e As EventArgs) Handles btnCreateRoom.Click

        createRoom()



    End Sub

    Private Sub createRoom()
        sql.addParam("@roomName", txtRoomName.Text)
        sql.addParam("@roomDescription", txtRoomDescription.Text)
        sql.addParam("@project_id", projectId)
        sql.ExecQuery("INSERT INTO ROOMS (room_name , room_description , project_id) values (@projectName,@projectDescription,@projectName )")


    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load

        Label3.Text = projectId


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class