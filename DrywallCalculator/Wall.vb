Public Class Wall

    Private WallName As String
    Private WallDescription As String
    Private LeftCorner As String
    Private RightCorner As String
    Private WallWidth As Double
    Private HasReveal As Boolean
    Private BaseBoardHeight As Double
    Private RevealHeight As Double
    Private SE_stripHeight As Double
    Private ProjectID As Integer
    Private RoomID As Integer
    Private RoomName As String
    Private fillWidth As Double



    Public Sub New(newWallName As String, newWalldescription As String, newLeftCorner As String, newRightCorner As String, newWallWidth As Double, newHasReveal As Boolean, newRevealHeight As Double, newBaseBoardHeight As Double, newStripSize As Double, newRoomID As Integer, newProjectID As Integer)
        WallName = newWallName
        WallDescription = newWalldescription
        WallWidth = newWallWidth
        LeftCorner = newLeftCorner
        RightCorner = newRightCorner
        WallWidth = newWallWidth
        HasReveal = newHasReveal
        BaseBoardHeight = newBaseBoardHeight
        RevealHeight = newRevealHeight
        RoomID = newRoomID
        ProjectID = newProjectID
        SE_stripHeight = newStripSize


    End Sub

    Public Property get_stripSize() As Double
        Get
            Return SE_stripHeight
        End Get
        Set(value As Double)
            SE_stripHeight = value
        End Set
    End Property


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

    Public Property get_HasReveal() As Boolean
        Get
            Return HasReveal
        End Get
        Set(value As Boolean)
            HasReveal = value
        End Set
    End Property

    Public Property get_BaseBoardHeight() As Double
        Get
            Return BaseBoardHeight
        End Get
        Set(value As Double)
            BaseBoardHeight = value
        End Set
    End Property

    Public Property get_RevealHeight() As Double
        Get
            Return RevealHeight
        End Get
        Set(value As Double)
            RevealHeight = value
        End Set
    End Property

    Public Property get_SE_stripHeight() As Double
        Get
            Return SE_stripHeight
        End Get
        Set(value As Double)
            SE_stripHeight = value
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

    Public Property get_fillWidth() As Double
        Get
            Return fillWidth
        End Get

        Set(value As Double)
            fillWidth = value
        End Set
    End Property


End Class
