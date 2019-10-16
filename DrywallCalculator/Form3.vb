Public Class Form3
    Private sql As New SQLControl
    Private projectId As Integer
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtRoomDescription.TextChanged

    End Sub

    Public Sub New(ByVal projectID As Integer)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        MsgBox(projectID)
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

        Label3.Text = sql.tableId


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class