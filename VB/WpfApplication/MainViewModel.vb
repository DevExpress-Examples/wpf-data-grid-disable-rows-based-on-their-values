Imports DevExpress.Mvvm
Imports System.Collections.ObjectModel
Imports System.Linq

Namespace WpfApplication

    Public Class MainViewModel
        Inherits ViewModelBase

        Public Property Items As ObservableCollection(Of Item)
            Get
                Return GetValue(Of ObservableCollection(Of Item))()
            End Get

            Set(ByVal value As ObservableCollection(Of Item))
                SetValue(value)
            End Set
        End Property

        Public Property CurrentItem As Item
            Get
                Return GetValue(Of Item)()
            End Get

            Set(ByVal value As Item)
                SetValue(value)
            End Set
        End Property

        Public Sub New()
            Items = GetData()
            CurrentItem = Items.FirstOrDefault()
        End Sub

        Private Shared Function GetData() As ObservableCollection(Of Item)
            Dim collection = Enumerable.Range(0, 15).[Select](Function(x) New Item With {.AllowEdit = x Mod 3 <> 0, .Name = $"Name{x}", .ID = x})
            Return New ObservableCollection(Of Item)(collection)
        End Function
    End Class

    Public Class Item
        Inherits BindableBase

        Public Property Name As String
            Get
                Return GetValue(Of String)()
            End Get

            Set(ByVal value As String)
                SetValue(value)
            End Set
        End Property

        Public Property ID As Integer
            Get
                Return GetValue(Of Integer)()
            End Get

            Set(ByVal value As Integer)
                SetValue(value)
            End Set
        End Property

        Public Property AllowEdit As Boolean
            Get
                Return GetValue(Of Boolean)()
            End Get

            Set(ByVal value As Boolean)
                SetValue(value)
            End Set
        End Property
    End Class
End Namespace
