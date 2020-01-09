Public Class Form3
    Private sql As New SQLControl
    Public Property projectId As Integer
    Public Property projectName As String
    Private Property roomIDSelected As Integer

    Private tableId As Integer


    Private Sub btnCreateRoom_Click(sender As Object, e As EventArgs) Handles btnCreateRoom.Click

        createRoom()


    End Sub

    Private Sub createRoom()
        updateRoom()

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MdiParent = frmParent
        Label3.Text = projectId
        Label5.Text = projectName
        loadGrid()

    End Sub

    Private Sub updateRoom()
        sql.addParam("@roomName", txtRoomName.Text)
        sql.addParam("@roomDescription", txtRoomDescription.Text)
        sql.addParam("@project_id", projectId)
        sql.addParam("@drywallThickness", cbxDrywallThickness.Text)


        If cbxCeilingLeveled.CheckState = 1 Then
            sql.addParam("@ceilingLeveled", "TRUE")
        Else
            sql.addParam("@ceilingLeveled", "FALSE")
        End If

        

        If CheckBox1.CheckState = 1 Then
            sql.addParam("@hasReveal", "TRUE")
            sql.addParam("@bbHeight", txtBB_height.Text)
            sql.addParam("@revealHeight", txtRevealHeight.Text)
            sql.addParam("@SE_stripHeight", txtSE_height.Text)

        Else
            sql.addParam("@hasReveal", "FALSE")
            sql.addParam("@bbHeight", "0")
            sql.addParam("@revealHeight", "0")
            sql.addParam("@SE_stripHeight", "0")

        End If






        sql.ExecQuery("INSERT INTO ROOMS (room_name , room_description , project_id, room_Drywall_Thickness, room_has_reveal, room_bb_height, room_reveal_height, room_strip_size, room_ceiling_leveled) values (@roomName,@roomDescription,@project_id, @drywallThickness, @hasReveal, @bbHeight, @revealHeight, @SE_stripHeight, @ceilingLeveled  )")
        tableId = sql.tableID
        loadGrid()


    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

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
        frmRoomsN.projectName = projectName
        frmRoomsN.Show()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cbxDrywallThickness.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.CheckState = 1 Then
            txtSE_height.Enabled = True
            txtRevealHeight.Enabled = True
            txtBB_height.Enabled = True
            Label9.Enabled = True
            Label10.Enabled = True
            Label11.Enabled = True
        Else
            txtSE_height.Enabled = False
            txtRevealHeight.Enabled = False
            txtBB_height.Enabled = False
            Label9.Enabled = False
            Label10.Enabled = False
            Label11.Enabled = False
        End If



    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try

            Dim index As Integer
            index = e.RowIndex
            Dim selectedRow As DataGridViewRow
            selectedRow = DataGridView1.Rows(index)
            roomIDSelected = selectedRow.Cells(0).Value
            selectedRow = DataGridView1.Rows(index)


            txtRoomName.Text = selectedRow.Cells(2).Value.ToString
            txtRoomDescription.Text = selectedRow.Cells(3).Value.ToString
            cbxDrywallThickness.Text = selectedRow.Cells(4).Value.ToString
            If selectedRow.Cells(5).Value.ToString = True Then
                CheckBox1.CheckState = 1
            Else
                CheckBox1.CheckState = 0
            End If


            If selectedRow.Cells(9).Value.ToString = "TRUE" Then
                cbxCeilingLeveled.CheckState = 1
            Else
                cbxCeilingLeveled.CheckState = 0
            End If

            txtBB_height.Text = selectedRow.Cells(6).Value.ToString
            txtRevealHeight.Text = selectedRow.Cells(7).Value.ToString
            txtSE_height.Text = selectedRow.Cells(8).Value.ToString




        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnUpdate1_Click(sender As Object, e As EventArgs) Handles btnUpdate1.Click
        modifyRoom()
    End Sub
    Private Sub modifyRoom()
        sql.addParam("@roomName", txtRoomName.Text)
        sql.addParam("@roomDescription", txtRoomDescription.Text)
        sql.addParam("@drywallThickness", cbxDrywallThickness.Text)

        If cbxCeilingLeveled.CheckState = 1 Then
            sql.addParam("@ceilingLeveled", "TRUE")

        Else
            sql.addParam("@ceilingLeveled", "FALSE")
        End If


        If CheckBox1.CheckState = 1 Then
            sql.addParam("@hasReveal", "TRUE")

        Else
            sql.addParam("@hasReveal", "FALSE")
            txtBB_height.Text = 0
            txtRevealHeight.Text = 0
            txtSE_height.Text = 0


        End If
        sql.addParam("@bbHeight", txtBB_height.Text)
        sql.addParam("@revealHeight", txtRevealHeight.Text)
        sql.addParam("@SE_Height", txtSE_height.Text)
        sql.addParam("@roomID", roomIDSelected)

        ' If Not (txtCornerName.Text = String.Empty And txtCornerDesc.Text = String.Empty And txtLsDistance.Text = String.Empty And txtRsDistance.Text = String.Empty) Then

        sql.ExecQuery("UPDATE ROOMS SET room_name = @roomName, room_description = @roomDescription, room_Drywall_thickness = @drywallThickness, room_has_reveal = @hasReveal , room_bb_height = @bbHeight , room_reveal_height = @revealHeight , room_strip_size = @SE_Height , room_ceiling_leveled = @ceilingLeveled  where room_id= @roomID")
        loadGrid(projectId, roomIDSelected)
        ' End If

    End Sub

    Private Sub loadGrid(pID As Integer, rId As Integer)

        sql.clearParams()
        sql.addParam("@projectID", pID)
        sql.addParam("@roomID", rId)
        sql.ExecQuery("select * from rooms where project_ID = @projectID")
        If sql.recordcount > 0 Then
            DataGridView1.DataSource = sql.sqlDS.Tables(0)
            '   DataGridView1.Rows(0).Selected = True

        Else
            DataGridView1.DataSource = ""

        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class