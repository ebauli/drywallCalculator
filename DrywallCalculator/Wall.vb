Public Class Wall

    Private WallName As String
    Private WallDescription As String
    Private LeftCorner As String
    Private RightCorner As String
    Private WallWidth As Double
    Private ProjectID As Integer
    Private RoomID As Integer
    Private RoomName As String
    Private fillWidth As Double
    Private lcrs_distance As Double
    Private rcls_distance As Double




    Public Sub New(newWallName As String, newWalldescription As String, newLeftCorner As String, newRightCorner As String, newWallWidth As Double, newRoomID As Integer, newProjectID As Integer)
        WallName = newWallName
        WallDescription = newWalldescription
        WallWidth = newWallWidth
        LeftCorner = newLeftCorner
        RightCorner = newRightCorner
        WallWidth = newWallWidth
        RoomID = newRoomID
        ProjectID = newProjectID

    End Sub

    Public Property get_name() As String
        Get
            Return WallName
        End Get
        Set(value As String)
            WallName = value
        End Set
    End Property


    Public Property get_description() As String
        Get
            Return WallDescription
        End Get
        Set(value As String)
            WallDescription = value
        End Set
    End Property

    Public Property get_LeftCorner() As String
        Get
            Return LeftCorner
        End Get
        Set(value As String)
            LeftCorner = value
        End Set
    End Property


    Public Property get_RightCorner() As String
        Get
            Return RightCorner
        End Get
        Set(value As String)
            RightCorner = value
        End Set
    End Property

    Public Property get_WallWidth() As Double
        Get
            Return WallWidth
        End Get
        Set(value As Double)
            WallWidth = value
        End Set
    End Property


    Public Property get_projectID() As Integer
        Get
            Return ProjectID
        End Get
        Set(value As Integer)
            ProjectID = value
        End Set
    End Property

    Public Property get_roomID() As Integer
        Get
            Return RoomID
        End Get
        Set(value As Integer)
            RoomID = value
        End Set
    End Property

    Public Property get_RoomName() As String
        Get
            Return RoomName
        End Get
        Set(value As String)
            RoomName = value
        End Set
    End Property

    Public Property get_leftDistance() As Double

        Get
            Return lcrs_distance
        End Get
        Set(value As Double)
            lcrs_distance = value
        End Set
    End Property

    Public Property get_righttDistance() As Double

        Get
            Return rcls_distance
        End Get
        Set(value As Double)
            rcls_distance = value
        End Set
    End Property


    Public Property get_fillWidth() As Double
        Get
            Return fillWidth
        End Get

        Set(value As Double)
            fillWidth = value
        End Set
    End Property



End Class
