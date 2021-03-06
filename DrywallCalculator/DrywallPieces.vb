﻿Public Class DrywallPieces
    Implements IComparable(Of DrywallPieces)
    Private ProjectID As Integer
    Private RoomName As String
    Private WallName As String
    Private InCorner As String
    Private PieceType As String
    Private DrywallThickness As Double
    Private W1 As Double
    Private W2 As Double
    Private H1 As Double
    Private H2 As Double


    Public Sub New(newProjectID As Integer, newRoomName As String, newWallName As String, newInCorner As String, newPieceType As String, newDrywallThickness As Double, newW1 As Double, newW2 As Double, newH1 As Double, newH2 As Double)

        ProjectID = newProjectID
        WallName = newWallName
        RoomName = newRoomName
        InCorner = newInCorner
        PieceType = newPieceType
        DrywallThickness = newDrywallThickness
        W1 = newW1
        W2 = newW2
        H1 = newH1
        H2 = newH2


    End Sub

    Public Property get_ProjectID() As Integer
        Get
            Return ProjectID
        End Get
        Set(value As Integer)
            ProjectID = value
        End Set
    End Property

    Public Property get_WallName() As String
        Get
            Return WallName
        End Get
        Set(value As String)
            WallName = value
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
    Public Property get_InCorner() As String
        Get
            Return InCorner
        End Get
        Set(value As String)
            InCorner = value
        End Set
    End Property

    Public Property get_PieceType() As String
        Get
            Return PieceType
        End Get
        Set(value As String)
            PieceType = value
        End Set
    End Property

    Public Property get_DrywallThickness() As Double
        Get
            Return DrywallThickness
        End Get
        Set(value As Double)
            DrywallThickness = value
        End Set
    End Property


    Public Property get_W1() As Double
        Get
            Return W1
        End Get
        Set(value As Double)
            W1 = value
        End Set
    End Property

    Public Property get_W2() As Double
        Get
            Return W2
        End Get
        Set(value As Double)
            W2 = value
        End Set
    End Property

    Public Property get_H1() As Double
        Get
            Return H1
        End Get
        Set(value As Double)
            H1 = value
        End Set
    End Property

    Public Property get_H2() As Double
        Get
            Return H2
        End Get
        Set(value As Double)
            H2 = value
        End Set
    End Property

    Public Function CompareTo(other As DrywallPieces) As Integer _
        Implements IComparable(Of DrywallPieces).CompareTo
        ' Compare sizes.
        Return Me.get_PieceType.CompareTo(other.get_PieceType())
    End Function


End Class
