<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128649812/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3594)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/WpfApplication/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication/MainWindow.xaml))**
* [MainWindow.xaml.cs](./CS/WpfApplication/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication/MainWindow.xaml.vb))
* [ViewModel.cs](./CS/WpfApplication/ViewModel.cs) (VB: [ViewModel.vb](./VB/WpfApplication/ViewModel.vb))
* [DisableRowBehavior.cs](./CS/WpfApplication/DisableRowBehavior.cs) (VB: [DisableRowBehavior.vb](./VB/WpfApplication/DisableRowBehavior.vb))
<!-- default file list end -->

# How to disable rows in GridControl based on their values

To disable a row, use either of the following ways:

1. In **v20.2** and newer, use [BaseColumn.IsReadOnlyBinding](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.BaseColumn.IsReadOnlyBinding) or [BaseColumn.IsEnabledBinding](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.BaseColumn.IsEnabledBinding) as we illustrated in this example: [Read-Only and Enabled State Binding](https://github.com/DevExpress-Examples/wpf-grid-read-only-and-enabled-binding).
2. Handle the [ShowingEditor](http://documentation.devexpress.com/#WPF/DevExpressXpfGridGridViewBase_ShowingEditortopic) event and set the **e.Cancel** property to `True` in the event handler.
3. Bind the editor's **IsReadOnly** property inside **CellTemplate** (supported starting with version **15.2**).

The solutions from points 2 and 3 are demonstrated in this sample project.
