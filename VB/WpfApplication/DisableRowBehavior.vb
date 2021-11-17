Imports DevExpress.Mvvm.UI.Interactivity
Imports DevExpress.Xpf.Grid

Namespace WpfApplication

    Public Class DisableRowBehavior
        Inherits Behavior(Of TableView)

        Protected Overrides Sub OnAttached()
            MyBase.OnAttached()
            AddHandler AssociatedObject.ShowingEditor, AddressOf OnEditorShowing
        End Sub

        Protected Overrides Sub OnDetaching()
            RemoveHandler AssociatedObject.ShowingEditor, AddressOf OnEditorShowing
            MyBase.OnDetaching()
        End Sub

        Private Sub OnEditorShowing(ByVal sender As Object, ByVal e As ShowingEditorEventArgs)
            If Not Equals(e.Column.FieldName, NameOf(Item.AllowEdit)) Then e.Cancel = Not TryCast(AssociatedObject.DataControl.CurrentItem, Item).AllowEdit
        End Sub
    End Class
End Namespace
