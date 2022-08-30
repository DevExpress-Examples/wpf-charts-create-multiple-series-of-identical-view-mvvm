Imports System.Collections.Generic

Namespace SeriesItemTemplateSample.Model

#Region "#Model"
    Public Class GdpSeries

        Public Property CountryName As String

        Public Property Values As IEnumerable(Of Gdp)
    End Class

    Public Class Gdp

        Public Property Year As Integer

        Public Property Value As Double
    End Class
#End Region  ' #Model
End Namespace
