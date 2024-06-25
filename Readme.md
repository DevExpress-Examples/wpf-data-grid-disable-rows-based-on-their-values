<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128649812/14.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3594)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/WpfApplication/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/WpfApplication/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/WpfApplication/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/WpfApplication/MainWindow.xaml.vb))
* [DataHelper.cs](./CS/WpfApplication/Model/DataHelper.cs) (VB: [DataHelper.vb](./VB/WpfApplication/Model/DataHelper.vb))
* [RowStateConverter.cs](./CS/WpfApplication/RowStateHelper/RowStateConverter.cs) (VB: [RowStateConverter.vb](./VB/WpfApplication/RowStateHelper/RowStateConverter.vb))
* [RowStateHelper.cs](./CS/WpfApplication/RowStateHelper/RowStateHelper.cs) (VB: [RowStateHelper.vb](./VB/WpfApplication/RowStateHelper/RowStateHelper.vb))
* [ViewModel.cs](./CS/WpfApplication/ViewModel/ViewModel.cs) (VB: [ViewModel.vb](./VB/WpfApplication/ViewModel/ViewModel.vb))
<!-- default file list end -->
# How to disable rows in GridControl based on their values


<p>To disable a row, use either of the following approaches: <br>1. Handle the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfGridGridViewBase_ShowingEditortopic">ShowingEditor </a> event and set the <strong>e.Cancel</strong> property to true in the event handler.<br>2. Bind the editor's <strong>IsReadOnly</strong> property inside <strong>CellTemplate</strong> (supported starting with version <strong>15.2</strong>).<br><br>Both these approaches are demonstrated in the underlying sample project. </p>

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-disable-rows-based-on-their-values&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-data-grid-disable-rows-based-on-their-values&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
