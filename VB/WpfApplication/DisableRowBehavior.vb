Imports DevExpress.Mvvm.UI.Interactivity
Imports DevExpress.Xpf.Grid

Namespace WpfApplication

    Public Class DisableRowBehavior
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
            e.Cancel = Not TryCast(AssociatedObject.DataControl.CurrentItem, Item).AllowEdit
        End Sub
    End Class
End Namespace
