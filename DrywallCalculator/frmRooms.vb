Public Class frmRooms

    Dim projectId As Integer
    Private sql As New SQLControl
    Private tableId As Integer

    Private Sub FrmRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        sql.addParam("@roomName", txtRoomName.Text)
        sql.addParam("@roomDescription", txtRoomDescription.Text)
        sql.addParam("@project_id", projectId)
        sql.ExecQuery("INSERT INTO ROOMS (room_name , room_description , project_id) values (@roomName,@roomDescription,@project_id )")
        tableId = sql.tableID
        MsgBox(tableId)
        loadGrid()
    End Sub
End Class