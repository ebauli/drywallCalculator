Public Class Form5

    Private sql As New SQLControl
    Public Property projectId As Integer
    Public Property projectName As String
    Public MyWallList As New List(Of Wall)
    Public MyCornerList As New List(Of Corner)
    Public myRoomList As New List(Of Room)
    Public myDrywallPiecesList As New List(Of DrywallPieces)



    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' in the form load we will cretae all the objeects needed to cvlculate the puieces.

        createRoomList(projectId)
        createWallList(projectId)
        createCornerList(projectId)
        calculatePieces(projectId)
        ShowPieces()


    End Sub

    Private Sub createRoomList(projectid)
        ' Need to cretae the object first and then add to the list
        Dim Maxrow As Integer
        Dim inc As Integer
        Maxrow = 0
        inc = 0
        sql.addParam("@projectID", projectid)

        sql.ExecQuery("select * from rooms where (project_ID = @projectID) ")
        Maxrow = sql.sqlDS.Tables(0).Rows.Count

        If sql.recordcount > 0 Then
            Dim RoomID As Integer
            Dim RoomName As String
            Dim RoomDescription As String
            Dim RoomDrywallThickness As Double

            'needs to be inside of loop until the end of recordset and added to corner list object collection
            Dim RoomList As New List(Of Room)()
            For inc = 0 To Maxrow - 1
                RoomID = sql.sqlDS.Tables(0).Rows(inc).Item("room_id")
                RoomName = sql.sqlDS.Tables(0).Rows(inc).Item("room_name")
                RoomDescription = sql.sqlDS.Tables(0).Rows(inc).Item("room_description")
                RoomDrywallThickness = sql.sqlDS.Tables(0).Rows(inc).Item("room_Drywall_Thickness")
                Dim myRoom1 As New Room(projectid, RoomID, RoomName, RoomDescription, RoomDrywallThickness)

                RoomList.Add(myRoom1)


            Next

            For Each room In RoomList

                Console.WriteLine(room.get_RoomID)
                Console.WriteLine(room.get_name)
                Console.WriteLine(room.get_Description)
                
            Next

            'End

            myRoomList = RoomList
        Else

            MsgBox("something wrong")

        End If


    End Sub


    Private Sub createCornerList(projectid)
        ' Need to cretae the object first and then add to the list
        Dim Maxrow As Integer
        Dim inc As Integer
        Maxrow = 0
        inc = 0
        sql.addParam("@projectID", projectid)

        sql.ExecQuery("select * from corners where (project_ID = @projectID) ")
        Maxrow = sql.sqlDS.Tables(0).Rows.Count

        If sql.recordcount > 0 Then
            Dim cornerID As Integer
            Dim roomID As Integer
            Dim CornerName As String
            Dim cornerDescription As String
            Dim cornerType As String
            Dim lsDistance As Double
            Dim rsDistance As Double
            Dim heightFF As Double


            'needs to be inside of loop until the end of recordset and added to corner list object collection
            Dim CornerList As New List(Of Corner)()
            For inc = 0 To Maxrow - 1
                cornerID = sql.sqlDS.Tables(0).Rows(inc).Item("corner_id")
                roomID = sql.sqlDS.Tables(0).Rows(inc).Item("room_id")
                CornerName = sql.sqlDS.Tables(0).Rows(inc).Item("corner_name")
                cornerDescription = sql.sqlDS.Tables(0).Rows(inc).Item("corner_description")
                cornerType = sql.sqlDS.Tables(0).Rows(inc).Item("corner_type")
                lsDistance = sql.sqlDS.Tables(0).Rows(inc).Item("ls_distance")
                rsDistance = sql.sqlDS.Tables(0).Rows(inc).Item("rs_distance")
                heightFF = sql.sqlDS.Tables(0).Rows(inc).Item("height_ff")
                Dim mycorner1 As New Corner(CornerName, cornerDescription, cornerType, lsDistance, rsDistance, heightFF, roomID, projectid, projectName)

                CornerList.Add(mycorner1)


            Next
            MyCornerList = CornerList
            For Each corner In CornerList

                Console.WriteLine(corner.get_RoomID)
                Console.WriteLine(corner.get_Name)
                Console.WriteLine(corner.get_LeftStudDistance)
                Console.WriteLine(corner.get_RightStudDistance)


            Next

            For Each room In myRoomList




                Dim result = From e In CornerList Where e.get_RoomID.Equals(room.get_RoomID) Order By e.get_HeightFF Ascending


                If result.Count > 0 Then
                    Console.WriteLine(result.First.get_HeightFF)

                    Console.WriteLine(room.get_RoomID)
                    Console.WriteLine(room.get_name)
                    Console.WriteLine(room.get_Description)
                    room.get_RoomHeight = result.First.get_HeightFF

                End If


            Next
            '   End
        Else

            MsgBox("something wrong")

        End If


    End Sub

    Private Sub createWallList(projectid)
        ' Need to cretae the object first and then add to the list
        Dim Maxrow As Integer
        Dim inc As Integer
        Maxrow = 0
        inc = 0

        sql.addParam("@projectID", projectid)


        sql.ExecQuery("select * from walls where (project_ID = @projectID) ")
        Maxrow = sql.sqlDS.Tables(0).Rows.Count

        If sql.recordcount > 0 Then


            Dim RevealHeight As Double
            Dim wallID As Integer
            Dim wallName As String
            Dim wallDescription As String
            Dim roomID As Integer
            Dim wallWidth As Double
            Dim leftCorner As Integer
            Dim rightcorner As Integer
            Dim bbHeight As Double
            Dim HasReveal As Boolean
            Dim strip_size As Double


            Dim WallList As New List(Of Wall)()
            For inc = 0 To Maxrow - 1
                wallID = sql.sqlDS.Tables(0).Rows(inc).Item("wall_id")
                roomID = sql.sqlDS.Tables(0).Rows(inc).Item("room_id")
                wallName = sql.sqlDS.Tables(0).Rows(inc).Item("wall_name")
                wallDescription = sql.sqlDS.Tables(0).Rows(inc).Item("wall_description")
                wallWidth = sql.sqlDS.Tables(0).Rows(inc).Item("width")
                leftCorner = sql.sqlDS.Tables(0).Rows(inc).Item("lc_id")
                rightcorner = sql.sqlDS.Tables(0).Rows(inc).Item("rc_id")
                bbHeight = sql.sqlDS.Tables(0).Rows(inc).Item("bb_height")
                HasReveal = sql.sqlDS.Tables(0).Rows(inc).Item("has_reveal")
                RevealHeight = sql.sqlDS.Tables(0).Rows(inc).Item("reveal_height")
                strip_size = sql.sqlDS.Tables(0).Rows(inc).Item("strip_size")
                Dim mywall1 As New Wall(wallName, wallDescription, leftCorner, rightcorner, wallWidth, HasReveal, RevealHeight, bbHeight, strip_size, roomID, projectid)

                WallList.Add(mywall1)

            Next
            MyWallList = WallList

            For Each wall In WallList
                Dim w1, w2 As Double
                Console.WriteLine(wall.get_name)
                Console.WriteLine(wall.get_WallWidth)
                Console.WriteLine(wall.get_LeftCorner)
                Console.WriteLine(wall.get_RightCorner)

                sql.addParam("@corner_id", wall.get_LeftCorner)
                sql.ExecQuery("select rs_distance from corners where corner_id = @corner_id ")

                For Each r As DataRow In sql.sqlDS.Tables(0).Rows
                    Console.WriteLine(r("rs_distance"))
                    w1 = r("rs_distance")
                Next

                sql.addParam("@corner_id", wall.get_RightCorner)
                sql.ExecQuery("select ls_distance from corners where corner_ID = @corner_id ")

                For Each r As DataRow In sql.sqlDS.Tables(0).Rows
                    Console.WriteLine(r("ls_distance"))
                    w2 = r("ls_distance")
                Next
                wall.get_fillWidth = wall.get_WallWidth - w1 - w2

            Next


            ' Dim mywall1 As New Wall()

        Else

            MsgBox("something wrong")

        End If


    End Sub


    Private Sub calculatePieces(projectid)
        ' Need to cretae the object first and then add to the list 
        Dim DrywallPieceList As New List(Of DrywallPieces)()
        Dim w1, w2, h1, h2 As Double

        For Each Room In myRoomList


            Dim result = From e In MyWallList Where e.get_roomID.Equals(Room.get_RoomID)
            Dim numberFullPieces As Integer
            Dim RemainderPieceInches As Double
            Dim numberRevealFullPieces As Integer
            Dim RemainderRevealPieceInches As Double
            For Each wall In result
                w1 = wall.get_fillWidth
                numberFullPieces = w1 \ 48
                RemainderPieceInches = w1 Mod 48
                w2 = 0
                ' if the wall has reveal you will substract the height of the reveal assembly to the height of the wall
                If wall.get_HasReveal = "1" Then
                    h1 = Room.get_RoomHeight - wall.get_SE_stripHeight - wall.get_RevealHeight - wall.get_BaseBoardHeight - Room.get_RoomDrywallThickness
                Else
                    h1 = Room.get_RoomHeight - Room.get_RoomDrywallThickness

                End If

                h2 = 16
                Dim drywallPiece1 As New DrywallPieces(projectid, Room.get_name, wall.get_name, "N/A", "C2_Flap", Room.get_RoomDrywallThickness, 48, w2, h1, h2)
                Dim drywallPieceReveal As New DrywallPieces(projectid, Room.get_name, wall.get_name, "N/A", "SE_Strip", Room.get_RoomDrywallThickness, 96, w2, wall.get_SE_stripHeight, h2)

                For i = 1 To numberFullPieces
                    DrywallPieceList.Add(drywallPiece1)
                Next

                If RemainderPieceInches > 0 Then
                    drywallPiece1 = New DrywallPieces(projectid, Room.get_name, wall.get_name, "N/A", "C2_Flap", Room.get_RoomDrywallThickness, RemainderPieceInches, w2, h1, h2)
                    DrywallPieceList.Add(drywallPiece1)
                End If


                numberRevealFullPieces = w1 \ 96
                RemainderRevealPieceInches = w1 Mod 96

                For i = 1 To numberRevealFullPieces
                    DrywallPieceList.Add(drywallPieceReveal)
                Next
                If RemainderRevealPieceInches > 0 Then
                    drywallPieceReveal = New DrywallPieces(projectid, Room.get_name, wall.get_name, "N/A", "SE_Strip", Room.get_RoomDrywallThickness, RemainderRevealPieceInches, w2, wall.get_SE_stripHeight, h2)
                    DrywallPieceList.Add(drywallPieceReveal)
                End If


            Next

                Dim result1 = From ee In MyCornerList Where ee.get_RoomID.Equals(Room.get_RoomID)

            For Each corner In result1


                If corner.get_cornerType = "Interior Corner" Then
                    w1 = corner.get_LeftStudDistance - Room.get_RoomDrywallThickness
                    w2 = corner.get_RightStudDistance - Room.get_RoomDrywallThickness
                Else
                    w1 = corner.get_LeftStudDistance + Room.get_RoomDrywallThickness
                    w2 = corner.get_RightStudDistance + Room.get_RoomDrywallThickness
                End If


                h1 = Room.get_RoomHeight - 11.625 - Room.get_RoomDrywallThickness
                'h1 = Room.get_RoomHeight - Wall.get_SE_stripHeight - Wall.get_RevealHeight - Wall.get_BaseBoardHeight - Room.get_RoomDrywallThickness
                h2 = 16
                Dim drywallPiece1 As New DrywallPieces(projectid, Room.get_name, corner.get_Name, corner.get_cornerType, "C3", Room.get_RoomDrywallThickness, w1, w2, h1, h2)
                DrywallPieceList.Add(drywallPiece1)
                Dim drywallPiece2 As New DrywallPieces(projectid, Room.get_name, corner.get_Name, corner.get_cornerType, "SE_Corner", Room.get_RoomDrywallThickness, w1, w2, 8, h2)
                DrywallPieceList.Add(drywallPiece2)

            Next

        Next
        myDrywallPiecesList = DrywallPieceList
    End Sub

    Private Sub showPieces()
        ' in the form load we will cretae all the objeects needed to cvlculate the puieces.

        DataGridView1.DataSource = myDrywallPiecesList




        '  For Each e In myDrywallPiecesList
        '  MsgBox("Piece Type: " & e.get_PieceType & " w1 : " & e.get_W1 & " w2: " & e.get_W2 & " h1: " & e.get_H1 & " h2: " & e.get_H2 & " in Room " & e.get_RoomName & " in this location " & e.get_WallName)


        '  Next




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        'create empty string
        Dim thecsvfile As String = String.Empty
        'get the column headers
        For Each column As DataGridViewColumn In DataGridView1.Columns
            thecsvfile = thecsvfile & column.HeaderText & ","
        Next
        'trim the last comma
        thecsvfile = thecsvfile.TrimEnd(",")
        'Add the line to the output
        thecsvfile = thecsvfile & vbCr & vbLf
        'get the rows
        For Each row As DataGridViewRow In DataGridView1.Rows
            'get the cells
            For Each cell As DataGridViewCell In row.Cells
                thecsvfile = thecsvfile & cell.FormattedValue.replace(",", "") & ","
            Next
            'trim the last comma
            thecsvfile = thecsvfile.TrimEnd(",")
            'Add the line to the output
            thecsvfile = thecsvfile & vbCr & vbLf
        Next
        'write the file

        SaveFileDialog1.ShowDialog()
        Dim location As String
        location = SaveFileDialog1.FileName
        My.Computer.FileSystem.WriteAllText(location & ".csv", thecsvfile, False)
        '"export.csv"

    End Sub
End Class