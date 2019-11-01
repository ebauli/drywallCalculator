Public Class frmRooms

    Public Property roomID As Integer
    Public Property projectID As Integer
    Public Property projectName As String
    Public Property roomName As String
    Public Property cornerIDSelected As Integer
    Private sql As New SQLControl
    Private tableId As Integer

    Private Sub FrmRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'just testing
        Label3.Text = projectID
        Button1.Enabled = False

        sql.addParam("@projectID", projectID)
        sql.ExecQuery("select * from rooms where project_Id = @projectID")

        For Each r As DataRow In sql.sqlDS.Tables(0).Rows
            cbxRooms.Items.Add(r("room_name"))
            Label9.Text = r("room_id")
            Label10.Text = r("room_name")


        Next

        '  sql.addParam("@cornerName", txtCornerName.Text)
        '  sql.addParam("@cornerDescription", txtCornerDesc.Text)
        '   sql.addParam("@ls_distance", txtLsDistance.Text)
        '   sql.addParam("@rs_distance", txtRsDistance.Text)
        '  sql.addParam("@height_ff", txtHeightFF.Text)
        '  sql.addParam("@projectID", projectID)
        '  sql.addParam("@roomID", roomID)

        ' sql.ExecQuery("INSERT INTO CORNERS (corner_name , corner_description , ls_distance , rs_distance , height_ff , project_id , room_id) values (@cornerName,@cornerDescription,@ls_distance,@rs_distance,@projectID,@roomID )")

        '  MsgBox(roomID)

        'loadGrid()
    End Sub


    Private Sub loadGrid(pID As Integer, rId As Integer)

        sql.addParam("@projectID", pID)
        sql.addParam("@roomID", rId)
        sql.ExecQuery("select * from corners where (project_ID = @projectID and room_id = @roomID) ")
        If sql.recordcount > 0 Then
            DataGridView1.DataSource = sql.sqlDS.Tables(0)
            DataGridView1.Rows(0).Selected = True

        Else
            DataGridView1.DataSource = ""

            MsgBox("Need to build corner")

        End If



    End Sub

    Private Sub Modifycorner()

        sql.addParam("@cornerName", txtCornerName.Text)
        sql.addParam("@cornerDescription", txtCornerDesc.Text)
        sql.addParam("@ls_distance", txtLsDistance.Text)
        sql.addParam("@rs_distance", txtRsDistance.Text)
        sql.addParam("@height_ff", txtHeightFF.Text)
        sql.addParam("@cornerID", cornerIDSelected)
        MsgBox(cornerIDSelected)

        ' If Not (txtCornerName.Text = String.Empty And txtCornerDesc.Text = String.Empty And txtLsDistance.Text = String.Empty And txtRsDistance.Text = String.Empty) Then

        sql.ExecQuery("UPDATE CORNERS SET corner_name = @cornerName, corner_description = @cornerDescription, ls_distance = @ls_distance , rs_distance = @rs_distance , height_ff = @height_ff  where corner_id=  @cornerID")

        ' End If



    End Sub







    Private Sub CreateCorner()

        sql.addParam("@cornerName", txtCornerName.Text)
        sql.addParam("@cornerDescription", txtCornerDesc.Text)
        sql.addParam("@ls_distance", txtLsDistance.Text)
        sql.addParam("@rs_distance", txtRsDistance.Text)
        sql.addParam("@height_ff", txtHeightFF.Text)
        sql.addParam("@projectID", projectID)
        sql.addParam("@roomID", roomID)

        If Not (txtCornerName.Text = String.Empty And txtCornerDesc.Text = String.Empty And txtLsDistance.Text = String.Empty And txtRsDistance.Text = String.Empty) Then


            sql.ExecQuery("INSERT INTO CORNERS (corner_name , corner_description , ls_distance , rs_distance , height_ff , project_id , room_id) values (@cornerName,@cornerDescription,@ls_distance,@rs_distance,@height_ff,@projectID,@roomID )")
        End If

        MsgBox(roomID)
        loadGrid(projectID, roomID)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        CreateCorner()

    End Sub

    Private Sub getRoomName(roomName As String)


        MsgBox(roomName)
        MsgBox(projectID)
        sql.addParam("@roomName", roomName)
        sql.addParam("@projectID", projectID)
        MsgBox("here 1111111")
        Dim queque As String
        queque = "Select * FROM rooms WHERE project_id = @projectID and room_name like '@roomName'"
        MsgBox(queque)
        sql.ExecQuery("SELECT * FROM rooms WHERE project_id = @projectID and room_name = @roomName")
        If sql.recordcount > 0 Then

            Label9.Text = sql.sqlDS.Tables(0).Rows(0).Item("room_id")
            roomID = sql.sqlDS.Tables(0).Rows(0).Item("room_id")
            Label10.Text = sql.sqlDS.Tables(0).Rows(0).Item("room_name")


        End If

        loadGrid(projectID, roomID)
        MsgBox("not here")
    End Sub
    Private Sub DeleteCorner()


    End Sub




    Private Sub cbxRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRooms.SelectedIndexChanged
        getRoomName(cbxRooms.Text)


        If (txtCornerName.Text = String.Empty And txtCornerDesc.Text = String.Empty And txtLsDistance.Text = String.Empty And txtRsDistance.Text = String.Empty) Then

            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If

        MsgBox(projectID)
        MsgBox(Label9.Text)
        loadGrid(projectID, Label9.Text)






    End Sub

    Private Sub validateTextboxes()
        If (txtCornerName.Text = String.Empty Or txtCornerDesc.Text = String.Empty Or txtLsDistance.Text = String.Empty Or txtRsDistance.Text = String.Empty Or txtHeightFF.Text = String.Empty) Then

            Button1.Enabled = False
        Else
            Button1.Enabled = True
        End If



    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView1.Rows(index)
        txtCornerName.Text = selectedRow.Cells(3).Value.ToString
        txtCornerDesc.Text = selectedRow.Cells(4).Value.ToString
        txtLsDistance.Text = selectedRow.Cells(5).Value.ToString
        txtRsDistance.Text = selectedRow.Cells(6).Value.ToString
        txtHeightFF.Text = selectedRow.Cells(7).Value.ToString
        Label12.Text = selectedRow.Cells(3).Value.ToString
        cornerIDSelected = selectedRow.Cells(0).Value

    End Sub


    Private Sub txtCornerName_LostFocus(sender As Object, e As EventArgs) Handles txtCornerName.LostFocus
        validateTextboxes()

    End Sub

    Private Sub txtCornerDesc_LostFocus(sender As Object, e As EventArgs) Handles txtCornerDesc.LostFocus
        validateTextboxes()
    End Sub

    Private Sub txtLsDistance_LostFocus(sender As Object, e As EventArgs) Handles txtLsDistance.LostFocus
        validateTextboxes()
    End Sub

    Private Sub txtRsDistance_LostFocus(sender As Object, e As EventArgs) Handles txtRsDistance.LostFocus
        validateTextboxes()
    End Sub

    Private Sub txtHeightFF_LostFocus(sender As Object, e As EventArgs) Handles txtHeightFF.LostFocus
        validateTextboxes()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Modifycorner()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DeleteCorner()
    End Sub
End Class