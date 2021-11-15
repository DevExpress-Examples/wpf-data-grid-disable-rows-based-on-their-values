<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128649812/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3594)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WPF Data Grid - Disable Rows Based on Their Values

To disable a row, use either of the following ways:

1. In **v20.2** and newer, use [BaseColumn.IsReadOnlyBinding](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.BaseColumn.IsReadOnlyBinding) or [BaseColumn.IsEnabledBinding](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.BaseColumn.IsEnabledBinding) as we illustrated in this example: [Read-Only and Enabled State Binding](https://github.com/DevExpress-Examples/wpf-grid-read-only-and-enabled-binding).
2. Handle the [ShowingEditor](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridViewBase.ShowingEditor) event and set the [e.Cancel](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ShowingEditorEventArgsBase.Cancel) property to **True** in the event handler.
3. Use the [CellTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.CellTemplate) property to bind the editor's [IsReadOnly](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.BaseEdit.IsReadOnly) property to a data source field (supported starting with **v15.2**).

This example demonstrates the difference between the techniques from points 2 and 3. In the left GridControl, users cannot open editors of the disabled cells. In the right GridControl, users can open read-only cell editors to copy their values to the clipboard, not to edit them.

![image](https://user-images.githubusercontent.com/65009440/141788896-6b0ff660-4d4c-4245-acbd-762f55b46ca5.png)

<!-- default file list -->

## Files to Look At

* [MainWindow.xaml](./CS/WpfApplication/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication/MainWindow.xaml))
* [DisableRowBehavior.cs](./CS/WpfApplication/DisableRowBehavior.cs) (VB: [DisableRowBehavior.vb](./VB/WpfApplication/DisableRowBehavior.vb))

<!-- default file list end -->

## Documentation

- [Disable Editing](https://docs.devexpress.com/WPF/401043/controls-and-libraries/data-grid/data-editing-and-validation/modify-cell-values/disable-editing)
- [Data Editing and Validation](https://docs.devexpress.com/WPF/6108/controls-and-libraries/data-grid/data-editing-and-validation)
- [GridViewBase.ShowingEditor](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridViewBase.ShowingEditor)
- [BaseEdit.IsReadOnly](https://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.BaseEdit.IsReadOnly)

## More Examples

- [WPF Data Grid - Read-Only and Enabled State Binding](https://github.com/DevExpress-Examples/wpf-grid-read-only-and-enabled-binding)
- [WPF Data Grid - How to Use Custom Editors to Edit Cell Values](https://github.com/DevExpress-Examples/how-to-use-custom-editors-to-edit-cell-values-e1596)
