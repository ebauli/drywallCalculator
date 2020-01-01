Public Class frmRooms

    Public Property roomID As Integer
    Public Property projectID As Integer
    Public Property projectName As String
    Public Property roomName As String
    Public Property cornerIDSelected As Integer
    Public Property wallIDSelected As Integer
    Private senderCorner As String
    Private sql As New SQLControl
    Private tableId As Integer
    Dim comboSource As New Dictionary(Of String, String)()


    Private Sub FrmRooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'just testing
        Me.MdiParent = frmParent
        comboSource.Add("0", "NO")
        comboSource.Add("1", "YES")
        ' cmbHasReveal.Items.Add(comboSource)
        Label3.Text = projectID
        Label12.Text = projectName
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



        End If

    End Sub


    Private Sub DeleteWall()

        sql.addParam("@wallID", wallIDSelected)

        Try

            sql.ExecQuery("DELETE FROM Walls WHERE wall_id = @wallID")
        Catch ex As Exception

        End Try
        loadGrid2(projectID, Label9.Text)
    End Sub

    Private Sub loadGrid2(pID As Integer, rId As Integer)

        sql.addParam("@projectID", pID)
        sql.addParam("@roomID", rId)
        sql.ExecQuery("select * from walls where (project_ID = @projectID and room_id = @roomID) ")
        If sql.recordcount > 0 Then
            DataGridView2.DataSource = sql.sqlDS.Tables(0)
            DataGridView2.Rows(0).Selected = True

        Else
            DataGridView2.DataSource = ""



        End If

    End Sub

    Private Sub ModifyWall()


        sql.addParam("@wallName", txtWallName.Text)
        sql.addParam("@wallDescription", txtWallDesc.Text)
        sql.addParam("@left_corner", txtLeftCorner.Text)
        sql.addParam("@right_corner", txtRightCorner.Text)
        sql.addParam("@wall_width", txtWallWidth.Text)
        ' sql.addParam("@hasReveal", cmbHasReveal.Text)
        ' sql.addParam("@bbHeight", txtBaseboardHeight.Text)
        ' sql.addParam("@reveal_height", txtRevealHeight.Text)
        ' sql.addParam("@stripHeight", txtSE_StripHeight.Text)
        sql.addParam("@wallID", wallIDSelected)


        ' If Not (txtCornerName.Text = String.Empty And txtCornerDesc.Text = String.Empty And txtLsDistance.Text = String.Empty And txtRsDistance.Text = String.Empty) Then
        ' sql.ExecQuery("UPDATE WALLS SET wall_name = @wallName, wall_description = @wallDescription, lc_id = @left_corner , rc_id = @right_corner , width = @wall_width, has_reveal = @hasReveal , bb_height = @bbHeight , reveal_height = @reveal_height , strip_size = @stripHeight where wall_id=  @wallID")

        sql.ExecQuery("UPDATE WALLS SET wall_name = @wallName, wall_description = @wallDescription, lc_id = @left_corner , rc_id = @right_corner , width = @wall_width where wall_id=  @wallID")


        loadGrid2(projectID, roomID)
        ' End If

    End Sub





    Private Sub Modifycorner()

        sql.addParam("@cornerName", txtCornerName.Text)
        sql.addParam("@cornerDescription", txtCornerDesc.Text)
        sql.addParam("@ls_distance", txtLsDistance.Text)
        sql.addParam("@rs_distance", txtRsDistance.Text)
        sql.addParam("@height_ff", txtHeightFF.Text)
        sql.addParam("@cornerID", cornerIDSelected)
        sql.addParam("@cornerType", cbxCornerType.Text)


        ' If Not (txtCornerName.Text = String.Empty And txtCornerDesc.Text = String.Empty And txtLsDistance.Text = String.Empty And txtRsDistance.Text = String.Empty) Then

        sql.ExecQuery("UPDATE CORNERS SET corner_name = @cornerName, corner_description = @cornerDescription, corner_type = @cornerType, ls_distance = @ls_distance , rs_distance = @rs_distance , height_ff = @height_ff  where corner_id=  @cornerID")
        loadGrid(projectID, roomID)
        ' End If

    End Sub


    Private Sub CreateCorner()

        sql.addParam("@cornerName", txtCornerName.Text)
        sql.addParam("@cornerDescription", txtCornerDesc.Text)
        sql.addParam("@cornerType", cbxCornerType.Text)
        sql.addParam("@ls_distance", txtLsDistance.Text)
        sql.addParam("@rs_distance", txtRsDistance.Text)
        sql.addParam("@height_ff", txtHeightFF.Text)
        sql.addParam("@projectID", projectID)
        sql.addParam("@roomID", roomID)

        If (txtCornerName.Text = String.Empty Or txtCornerDesc.Text = String.Empty Or txtLsDistance.Text = String.Empty Or txtRsDistance.Text = String.Empty) Then
            MsgBox("All Fields should be filled")
            sql.clearParams()

        Else


            Try

                sql.ExecQuery("INSERT INTO CORNERS (corner_name , corner_description , corner_type , ls_distance , rs_distance , height_ff , project_id , room_id) values (@cornerName,@cornerDescription,@cornerType,@ls_distance,@rs_distance,@height_ff,@projectID,@roomID )")


            Catch ex As Exception

            End Try

        End If

        loadGrid(projectID, roomID)

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        CreateCorner()

    End Sub

    Private Sub getRoomName(roomName As String)

        sql.addParam("@roomName", roomName)
        sql.addParam("@projectID", projectID)

        Try
            sql.ExecQuery("SELECT * FROM rooms WHERE project_id = @projectID and room_name = @roomName")
        Catch ex As Exception

        End Try


        If sql.recordcount > 0 Then

            Label9.Text = sql.sqlDS.Tables(0).Rows(0).Item("room_id")
            roomID = sql.sqlDS.Tables(0).Rows(0).Item("room_id")
            Label10.Text = sql.sqlDS.Tables(0).Rows(0).Item("room_name")


        End If

        loadGrid(projectID, roomID)

    End Sub
    Private Sub DeleteCorner()

        sql.addParam("@cornerID", cornerIDSelected)

        Try

            sql.ExecQuery("DELETE FROM corners WHERE corner_id = @cornerID")
        Catch ex As Exception

        End Try
        loadGrid(projectID, Label9.Text)
    End Sub


    Private Sub cbxRooms_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxRooms.SelectedIndexChanged
        getRoomName(cbxRooms.Text)

        loadGrid(projectID, Label9.Text)
        loadGrid2(projectID, Label9.Text)


    End Sub

    Private Sub validateTextboxes()
        '    If (txtCornerName.Text = String.Empty Or txtCornerDesc.Text = String.Empty Or txtLsDistance.Text = String.Empty Or txtRsDistance.Text = String.Empty Or txtHeightFF.Text = String.Empty) Then

        '  Button1.Enabled = False
        '   Else
        '  Button1.Enabled = True
        '   End If

    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try




            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)


            txtCornerName.Text = selectedRow.Cells(3).Value.ToString
            txtCornerDesc.Text = selectedRow.Cells(4).Value.ToString
            cbxCornerType.Text = selectedRow.Cells(5).Value.ToString

            txtLsDistance.Text = selectedRow.Cells(6).Value.ToString
            txtRsDistance.Text = selectedRow.Cells(7).Value.ToString
            txtHeightFF.Text = selectedRow.Cells(8).Value.ToString
            Label12.Text = selectedRow.Cells(3).Value.ToString
            cornerIDSelected = selectedRow.Cells(0).Value
            If senderCorner = "left" Then
                txtLeftCorner.Text = cornerIDSelected
            End If
            If senderCorner = "right" Then
                txtRightCorner.Text = cornerIDSelected
            End If
        Catch ex As Exception
        End Try

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

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click


        sql.clearParams()
        sql.addParam("@projectID", projectID)
        sql.addParam("@roomID", roomID)
        sql.addParam("@wallName", txtWallName.Text)
        sql.addParam("@wallDescription", txtWallDesc.Text)
        sql.addParam("@lc_id", txtLeftCorner.Text)
        sql.addParam("@rc_id", txtRightCorner.Text)
        sql.addParam("@wallWidth", txtWallWidth.Text)
        'sql.addParam("@hasReveal", cmbHasReveal.Text)
        'sql.addParam("@baseboardHeight", txtBaseboardHeight.Text)
        'sql.addParam("@revealHeight", txtRevealHeight.Text)
        'sql.addParam("@stripHeight", txtSE_StripHeight.Text)

        If (txtWallName.Text = "" Or txtWallDesc.Text = "" Or txtLeftCorner.Text = "" Or txtRightCorner.Text = "" Or txtWallWidth.Text = "") Then

            sql.clearParams()

        Else


            Try
                'sql.ExecQuery("INSERT INTO WALLS ( project_id, room_id ,wall_name , wall_description , lc_id , rc_id , width ,has_reveal, bb_height , reveal_height,strip_size ) values (@projectID,@roomID,@wallName,@wallDescription,@lc_id,@rc_id,@wallWidth,@hasReveal,@baseboardHeight,@revealHeight,@stripHeight )")

                sql.ExecQuery("INSERT INTO WALLS ( project_id, room_id ,wall_name , wall_description , lc_id , rc_id , width  ) values (@projectID,@roomID,@wallName,@wallDescription,@lc_id,@rc_id,@wallWidth )")


            Catch ex As Exception
                MsgBox("what happend here")
                MsgBox(e.ToString)
            End Try
        End If

        loadGrid2(projectID, roomID)



    End Sub


    Private Sub txtLeftCorner_MouseDown(sender As Object, e As MouseEventArgs) Handles txtLeftCorner.MouseDown
        senderCorner = "left"
        ' MsgBox("Click on the corner from Top gridview")


    End Sub


    Private Sub DataGridView1_LostFocus(sender As Object, e As EventArgs) Handles DataGridView1.LostFocus
        senderCorner = ""
    End Sub


    Private Sub txtRightCorner_MouseDown(sender As Object, e As MouseEventArgs) Handles txtRightCorner.MouseDown
        senderCorner = "right"
        '  MsgBox("Click on the corner from Top gridview")
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim frm5N As New Form5()
        frm5N.projectID = projectID
        frm5N.Show()
    End Sub


    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Try


            'Just to push

            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView2.Rows(index)


            txtWallName.Text = selectedRow.Cells(3).Value.ToString
            txtWallDesc.Text = selectedRow.Cells(4).Value.ToString
            txtLeftCorner.Text = selectedRow.Cells(5).Value.ToString

            txtRightCorner.Text = selectedRow.Cells(6).Value.ToString
            txtWallWidth.Text = selectedRow.Cells(7).Value.ToString

            wallIDSelected = selectedRow.Cells(0).Value
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ModifyWall()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        DeleteWall()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub
End Class