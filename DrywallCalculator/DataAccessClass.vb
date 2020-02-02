Imports linq


Public Class DataAccessClass

    Public Property myDrywallPiecesList As New List(Of DrywallPieces)
    Public Property myRoomList As New List(Of Room)
    Public roomsWithpieces As List(Of RoomDrywallPieces)
    Public piecesInaRoom As List(Of DrywallPieces)
    Private roomWithPieces As RoomDrywallPieces
    Private piecesInRoom As DrywallPieces
    Private roomID As Integer


    Public Function get_roomsWithpieces()

        MsgBox(myRoomList.Count)
        roomsWithpieces = New List(Of RoomDrywallPieces)
        roomWithPieces = New RoomDrywallPieces()
        'get room list
        For Each room In myRoomList

            roomWithPieces.room = room
            'need to get the pieces associated with this room

            roomID = room.get_RoomID
            piecesInaRoom = get_piecesInRoom(roomID)
            roomWithPieces.get_room = room
            roomWithPieces.get_lst_drywallPieces = piecesInaRoom
            roomsWithpieces.Add(roomWithPieces)

        Next
        Return roomsWithpieces
    End Function


    Public Function get_piecesInRoom(roomID As Integer)

        Dim piecesInRoom As New List(Of DrywallPieces)

        Dim result1 = From ee In myDrywallPiecesList Where ee.get_RoomID.Equals(roomID)

        For Each drywallpiece In result1

            piecesInRoom.Add(drywallpiece)


        Next
        End

        Return piecesInRoom

    End Function











End Class
