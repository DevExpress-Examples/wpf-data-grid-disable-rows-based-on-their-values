Imports System.Windows
Imports DevExpress.Xpf.Grid

Namespace WpfApplication

    Public Module RowStateHelper

        Public ReadOnly IsHelperEnabledProperty As DependencyProperty = DependencyProperty.RegisterAttached("IsHelperEnabled", GetType(Boolean), GetType(RowStateHelper), New UIPropertyMetadata(False, New PropertyChangedCallback(AddressOf OnIsHelperEnabledChanged)))

        Public Function GetIsHelperEnabled(ByVal target As DependencyObject) As Boolean
            Return CBool(target.GetValue(IsHelperEnabledProperty))
        End Function

        Public Sub SetIsHelperEnabled(ByVal target As DependencyObject, ByVal value As Boolean)
            target.SetValue(IsHelperEnabledProperty, value)
        End Sub

        Private Sub OnIsHelperEnabledChanged(ByVal o As DependencyObject, ByVal e As DependencyPropertyChangedEventArgs)
            Call OnIsHelperEnabledChanged(o, CBool(e.OldValue), CBool(e.NewValue))
        End Sub

        Private Sub OnIsHelperEnabledChanged(ByVal o As DependencyObject, ByVal oldValue As Boolean, ByVal newValue As Boolean)
            Dim view As GridViewBase = TryCast(o, GridViewBase)
            RemoveHandler view.ShowingEditor, AddressOf RowStateHelper_ShowingEditor
            If newValue Then AddHandler view.ShowingEditor, AddressOf RowStateHelper_ShowingEditor
        End Sub

        Private Sub RowStateHelper_ShowingEditor(ByVal sender As Object, ByVal e As ShowingEditorEventArgs)
            e.Cancel = Not IsRowEnabled(e.Row)
        End Sub

        Public Function IsRowEnabled(ByVal row As Object) As Boolean
            Dim datarow As GridItem = TryCast(row, GridItem)
            If datarow Is Nothing Then Return True
            Return datarow.AllowEdit
        End Function
    End Module
End Namespace
