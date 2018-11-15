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


