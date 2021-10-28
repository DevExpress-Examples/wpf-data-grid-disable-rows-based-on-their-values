Imports DevExpress.Mvvm.UI.Interactivity
Imports DevExpress.Xpf.Grid

Namespace WpfApplication

    Public Class EditorBehavior
        Inherits Behavior(Of TableView)

        Protected Overrides Sub OnAttached()
            MyBase.OnAttached()
            AssociatedObject.ShowingEditor += AddressOf OnEditorShowing
        End Sub

        Protected Overrides Sub OnDetaching()
            AssociatedObject.ShowingEditor -= AddressOf OnEditorShowing
            MyBase.OnDetaching()
        End Sub

        Private Sub OnEditorShowing(ByVal sender As Object, ByVal e As ShowingEditorEventArgs)
            CSharpImpl.__Assign(e.Cancel, Not TryCast(AssociatedObject.DataControl.CurrentItem, Item).AllowEdit)
        End Sub

        Private Class CSharpImpl

            <System.Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
