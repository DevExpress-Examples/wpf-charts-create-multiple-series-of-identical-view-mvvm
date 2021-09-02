Imports SeriesItemTemplateSample.Model
Imports System.Collections.Generic
Imports System.Collections.ObjectModel

Namespace SeriesItemTemplateSample.ViewModel
	#Region "#ViewModel"
	Public Class ChartViewModel
		Private privateGdpSeries As IEnumerable(Of GdpSeries)
		Public Property GdpSeries() As IEnumerable(Of GdpSeries)
			Get
				Return privateGdpSeries
			End Get
			Private Set(ByVal value As IEnumerable(Of GdpSeries))
				privateGdpSeries = value
			End Set
		End Property

		Public Sub New()
			GdpSeries = New Collection(Of GdpSeries) _
				From {
					New GdpSeries With {
						.CountryName = "USA",
						.Values = New Collection(Of Gdp) From {
							New Gdp With {
								.Year = 2015,
								.Value = 18.037
							},
							New Gdp With {
								.Year = 2014,
								.Value = 17.393
							},
							New Gdp With {
								.Year = 2013,
								.Value = 16.692
							},
							New Gdp With {
								.Year = 2012,
								.Value = 16.155
							},
							New Gdp With {
								.Year = 2011,
								.Value = 15.518
							},
							New Gdp With {
								.Year = 2010,
								.Value = 14.964
							},
							New Gdp With {
								.Year = 2009,
								.Value = 14.419
							},
							New Gdp With {
								.Year = 2008,
								.Value = 14.719
							}
						}
					},
					New GdpSeries With {
						.CountryName = "China",
						.Values = New Collection(Of Gdp) From {
							New Gdp With {
								.Year = 2015,
								.Value = 11.065
							},
							New Gdp With {
								.Year = 2014,
								.Value = 10.482
							},
							New Gdp With {
								.Year = 2013,
								.Value = 9.607
							},
							New Gdp With {
								.Year = 2012,
								.Value = 8.561
							},
							New Gdp With {
								.Year = 2011,
								.Value = 7.573
							},
							New Gdp With {
								.Year = 2010,
								.Value = 6.101
							},
							New Gdp With {
								.Year = 2009,
								.Value = 5.11
							},
							New Gdp With {
								.Year = 2008,
								.Value = 4.598
							}
						}
					},
					New GdpSeries With {
						.CountryName = "Japan",
						.Values = New Collection(Of Gdp) From {
							New Gdp With {
								.Year = 2015,
								.Value = 4.383
							},
							New Gdp With {
								.Year = 2014,
								.Value = 4.849
							},
							New Gdp With {
								.Year = 2013,
								.Value = 5.156
							},
							New Gdp With {
								.Year = 2012,
								.Value = 6.203
							},
							New Gdp With {
								.Year = 2011,
								.Value = 6.157
							},
							New Gdp With {
								.Year = 2010,
								.Value = 5.7
							},
							New Gdp With {
								.Year = 2009,
								.Value = 5.231
							},
							New Gdp With {
								.Year = 2008,
								.Value = 5.038
							}
						}
					}
				}
		End Sub
	End Class
	#End Region ' #ViewModel
End Namespace
