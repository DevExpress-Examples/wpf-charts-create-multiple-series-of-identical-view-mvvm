<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128569962/17.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T513360)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* **[MainWindow.xaml](./CS/SeriesItemTemplateSample/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/SeriesItemTemplateSample/MainWindow.xaml))**
* [GdpSeries.cs](./CS/SeriesItemTemplateSample/Model/GdpSeries.cs) (VB: [GdpSeries.vb](./VB/SeriesItemTemplateSample/Model/GdpSeries.vb))
* [ChartViewModel.cs](./CS/SeriesItemTemplateSample/ViewModel/ChartViewModel.cs) (VB: [ChartViewModel.vb](./VB/SeriesItemTemplateSample/ViewModel/ChartViewModel.vb))
<!-- default file list end -->
# How to generate Series of identical view types using the MVVM binding style


This example demonstrates how to create series using their view-models. The XYDiagram2D.<strong>SeriesItemsSource </strong>property defines a collection of objects used to generate Series. To configure how the series view model is converted to a series on a chart, use the XYDiagram2D.<strong>SeriesItemTemplate </strong>property. In this example, the Template is used to generate identical series.<br><br>See also: <a href="https://www.devexpress.com/Support/Center/p/T500832">How to generate Series of different view types using the MVVM binding style</a>.


<h3>Description</h3>

To bind series view models to a chart, use the SeriesItemsSource property of a diagram. To configure how the series view model converts to a series on a chart, use SeriesItemTemplate or SeriesItemTemplateSelector. In this example, the Template is used to generate identical series.

<br/>


<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-charts-create-multiple-series-of-identical-view-mvvm&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=wpf-charts-create-multiple-series-of-identical-view-mvvm&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
