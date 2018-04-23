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
            GdpSeries = New Collection(Of GdpSeries) From { _
                New GdpSeries With { _
                    .CountryName = "USA", .Values = New Collection(Of Gdp) From { _
                        New Gdp With {.Year = 2015, .Value = 18.037}, _
                        New Gdp With {.Year = 2014, .Value = 17.393}, _
                        New Gdp With {.Year = 2013, .Value = 16.692}, _
                        New Gdp With {.Year = 2012, .Value = 16.155}, _
                        New Gdp With {.Year = 2011, .Value = 15.518}, _
                        New Gdp With {.Year = 2010, .Value = 14.964}, _
                        New Gdp With {.Year = 2009, .Value = 14.419}, _
                        New Gdp With {.Year = 2008, .Value = 14.719} _
                    } _
                }, _
                New GdpSeries With { _
                    .CountryName = "China", .Values = New Collection(Of Gdp) From { _
                        New Gdp With {.Year = 2015, .Value = 11.065}, _
                        New Gdp With {.Year = 2014, .Value = 10.482}, _
                        New Gdp With {.Year = 2013, .Value = 9.607}, _
                        New Gdp With {.Year = 2012, .Value = 8.561}, _
                        New Gdp With {.Year = 2011, .Value = 7.573}, _
                        New Gdp With {.Year = 2010, .Value = 6.101}, _
                        New Gdp With {.Year = 2009, .Value = 5.11}, _
                        New Gdp With {.Year = 2008, .Value = 4.598} _
                    } _
                }, _
                New GdpSeries With { _
                    .CountryName = "Japan", .Values = New Collection(Of Gdp) From { _
                        New Gdp With {.Year = 2015, .Value = 4.383}, _
                        New Gdp With {.Year = 2014, .Value = 4.849}, _
                        New Gdp With {.Year = 2013, .Value = 5.156}, _
                        New Gdp With {.Year = 2012, .Value = 6.203}, _
                        New Gdp With {.Year = 2011, .Value = 6.157}, _
                        New Gdp With {.Year = 2010, .Value = 5.7}, _
                        New Gdp With {.Year = 2009, .Value = 5.231}, _
                        New Gdp With {.Year = 2008, .Value = 5.038} _
                    } _
                } _
            }
        End Sub
    End Class
    #End Region ' #ViewModel
End Namespace
