Public Class Corner

    Private CornerName As String
    Private CornerDescription As String
    Private CornerType As String
    Private LeftStudDistance As Double
    Private RightStudDistance As Double
    Private HeightFF As Double
    Private RoomID As Integer
    Private RoomName As String
    Private ProjectId As Integer
    Private ProjectName As String

    Public Sub New(newCornerName As String, newCornerdescription As String, newCornerType As String, newLeftStudDistance As Double, newRightStudDistance As Double, newHeightFF As Double, newRoomID As Integer, newProjectID As Integer, newProjectName As String)
        CornerName = newCornerName
        CornerDescription = newCornerdescription
        CornerType = newCornerType
        LeftStudDistance = newLeftStudDistance
        RightStudDistance = newRightStudDistance
        HeightFF = newHeightFF
        RoomID = newRoomID
        ProjectId = newProjectID
        ProjectName = newProjectName

    End Sub

    Public Property get_Name() As String
        Get
            Return CornerName
        End Get
        Set(value As String)
            CornerName = value
        End Set
    End Property

    Public Property get_cornerDescription() As String
        Get
            Return CornerDescription
        End Get
        Set(value As String)
            CornerDescription = value
        End Set
    End Property

    Public Property get_HeightFF() As Double
        Get
            Return HeightFF
        End Get
        Set(value As Double)
            HeightFF = value
        End Set
    End Property


    Public Property get_LeftStudDistance() As Double

        Get
            Return LeftStudDistance
        End Get
        Set(value As Double
            )
            LeftStudDistance = value
        End Set
    End Property

    Public Property get_RightStudDistance() As Double
        Get
            Return RightStudDistance
        End Get
        Set(value As Double)
            RightStudDistance = value
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

    Public Property get_RoomName() As String
        Get
            Return RoomName
        End Get
        Set(value As String)
            RoomName = value
        End Set
    End Property


    Public Property get_ProjectId() As Integer

        Get
            Return ProjectId
        End Get
        Set(value As Integer)
            ProjectId = value
        End Set
    End Property

    Public Property get_ProjectName() As String
        Get
            Return ProjectName
        End Get
        Set(value As String)
            ProjectName = value
        End Set
    End Property

End Class
