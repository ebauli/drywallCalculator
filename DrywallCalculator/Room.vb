Public Class Room

    Private ProjectId As Integer
    Private RoomID As Integer
    Private RoomName As String
    Private RoomDescription As String
    Private RoomHeight As Double
    Private RoomDrywallThickness As Double
    Private hasReveal As String
    Private baseboard_height As Double
    Private reveal_height As Double
    Private strip_height As Double

    Public Sub New(newProjectID As Integer, newRoomID As Integer, newRoomName As String, newRoomDescription As String, newRoomDrywallThickness As Double, newRoomHasReveal As String, newRoom_bbHeight As Double, newRoomRevealHeight As Double, newRoomStripSize As Double)

        ProjectId = newProjectID
        RoomID = newRoomID
        RoomName = newRoomName
        RoomDescription = newRoomDescription
        RoomDrywallThickness = newRoomDrywallThickness
        hasReveal = newRoomHasReveal
        baseboard_height = newRoom_bbHeight
        reveal_height = newRoomRevealHeight
        strip_height = newRoomStripSize

    End Sub

    Public Property get_ProjectId() As Integer
        Get
            Return ProjectId
        End Get
        Set(value As Integer)
            ProjectId = value
        End Set
    End Property

    Public Property get_RoomID() As Integer
        Get
            Return RoomID
        End Get
        Set(value As Integer)
            RoomID = value
        End Set
    End Property

    Public Property get_name() As String
        Get
            Return RoomName
        End Get
        Set(value As String)
            RoomName = value
        End Set
    End Property

    Public Property get_hasReveal() As String
        Get
            Return hasReveal
        End Get
        Set(value As String)
            hasReveal = value
        End Set
    End Property

    Public Property get_Description() As String
        Get
            Return RoomDescription
        End Get
        Set(value As String)
            RoomDescription = value
        End Set
    End Property

    Public Property get_RoomHeight() As Double
        Get
            Return RoomHeight
        End Get
        Set(value As Double)
            RoomHeight = value
        End Set
    End Property

    Public Property get_RoomDrywallThickness() As Double
        Get
            Return RoomDrywallThickness
        End Get
        Set(value As Double)
            RoomDrywallThickness = value
        End Set
    End Property

    Public Property get_baseboard_height() As Double
        Get
            Return baseboard_height
        End Get
        Set(value As Double)
            baseboard_height = value
        End Set
    End Property

    Public Property get_reveal_height() As Double
        Get
            Return reveal_height
        End Get
        Set(value As Double)
            reveal_height = value
        End Set
    End Property

    Public Property get_strip_height() As Double
        Get
            Return strip_height
        End Get
        Set(value As Double)
            strip_height = value
        End Set
    End Property


End Class
