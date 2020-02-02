Public Class RoomDrywallPieces


    Public room As Room
    Public lst_drywallPieces As List(Of DrywallPieces)


    Public Property get_room() As Room
        Get
            Return room
        End Get
        Set(value As Room)
            room = value
        End Set
    End Property

    Public Property get_lst_drywallPieces() As List(Of DrywallPieces)
        Get
            Return lst_drywallPieces
        End Get
        Set(value As List(Of DrywallPieces))
            lst_drywallPieces = value
        End Set
    End Property

End Class
