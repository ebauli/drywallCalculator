Imports System.ComponentModel

Public Class myBindingList

    Inherits CollectionBase
    Implements IBindingList

    Public Sub AddIndex(ByVal [property] As _
      System.ComponentModel.PropertyDescriptor) _
      Implements System.ComponentModel.IBindingList.AddIndex
    End Sub
    Public Function AddNew() As Object Implements _
      System.ComponentModel.IBindingList.AddNew
        Return Me.AddNew("New Widget", 0, 0)
    End Function
    Public Function AddNew(ByVal name As String,
      ByVal marketValue As Double, ByVal magnitude _
      As Long) As Widget
        Dim w As New Widget(name, marketValue, magnitude)
        Me.List.Add(w)
        Return w
    End Function
    Public Function Find(ByVal [property] As _
      System.ComponentModel.PropertyDescriptor, ByVal key As Object) _
      As Integer Implements System.ComponentModel.IBindingList.Find
        Return 0
    End Function
    Public Sub ApplySort(ByVal [property] As _
      System.ComponentModel.PropertyDescriptor, ByVal direction As _
      System.ComponentModel.ListSortDirection) _
      Implements System.ComponentModel.IBindingList.ApplySort
    End Sub
    Public Sub RemoveSort() _
      Implements System.ComponentModel.IBindingList.RemoveSort
    End Sub
    Public ReadOnly Property SupportsSorting() As Boolean _
      Implements System.ComponentModel.IBindingList.SupportsSorting
        Get
            Return True
        End Get
    End Property
    Public Sub RemoveIndex(ByVal [property] As _
      System.ComponentModel.PropertyDescriptor) _
      Implements System.ComponentModel.IBindingList.RemoveIndex
    End Sub
    Public ReadOnly Property SupportsSearching() As Boolean _
      Implements System.ComponentModel.IBindingList.SupportsSearching
        Get
            Return True
        End Get
    End Property
    Public ReadOnly Property SupportsChangeNotification() As Boolean _
      Implements System.ComponentModel.IBindingList.SupportsChangeNotification
        Get
            Return True
        End Get
    End Property
    Public ReadOnly Property SortDirection() As _
      System.ComponentModel.ListSortDirection _
      Implements System.ComponentModel.IBindingList.SortDirection
        Get
            Return New System.ComponentModel.ListSortDirection()
        End Get
    End Property
    Public ReadOnly Property SortProperty() As _
      System.ComponentModel.PropertyDescriptor _
      Implements System.ComponentModel.IBindingList.SortProperty
        Get
            Return Nothing
        End Get
    End Property
    Public ReadOnly Property IsSorted() As Boolean _
      Implements System.ComponentModel.IBindingList.IsSorted
        Get
            Return True
        End Get
    End Property
    Public ReadOnly Property AllowNew() As Boolean _
      Implements System.ComponentModel.IBindingList.AllowNew
        Get
            Return True
        End Get
    End Property
    Public ReadOnly Property AllowEdit() As Boolean
    Implements IBindingList.AllowNew
    Get
    Return True
    End Get
    End Property
    Public ReadOnly Property AllowRemove() As Boolean _
      Implements System.ComponentModel.IBindingList.AllowRemove
        Get
            Return True
        End Get
    End Property
    Public Event ListChanged(ByVal sender _
      As Object, ByVal e As _
      System.ComponentModel.ListChangedEventArgs) Implements _
      System.ComponentModel.IBindingList.ListChanged
    Default Public ReadOnly Property Item(ByVal _
      index As Integer) As Widget
        Get
            Return CType(Me.List(index), Widget)
        End Get
    End Property

    Private ReadOnly Property IBindingList_AllowEdit As Boolean Implements IBindingList.AllowEdit
        Get
            Throw New NotImplementedException()
        End Get
    End Property
End Class
