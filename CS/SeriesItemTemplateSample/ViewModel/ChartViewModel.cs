using SeriesItemTemplateSample.Model;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SeriesItemTemplateSample.ViewModel {
    #region #ViewModel
    public class ChartViewModel {
        public IEnumerable<GdpSeries> GdpSeries { get; private set; }

        public ChartViewModel() {
            GdpSeries = new Collection<GdpSeries> {
                new GdpSeries {
                    CountryName = "USA",
                    Values = new Collection<Gdp> {
                        new Gdp { Year = 2015, Value = 18.037},
                        new Gdp { Year = 2014, Value = 17.393},
                        new Gdp { Year = 2013, Value = 16.692},
                        new Gdp { Year = 2012, Value = 16.155},
                        new Gdp { Year = 2011, Value = 15.518},
                        new Gdp { Year = 2010, Value = 14.964},
                        new Gdp { Year = 2009, Value = 14.419},
                        new Gdp { Year = 2008, Value = 14.719}
                    }
                },
                new GdpSeries {
                    CountryName = "China",
                    Values = new Collection<Gdp> {
                        new Gdp { Year = 2015, Value = 11.065},
                        new Gdp { Year = 2014, Value = 10.482},
                        new Gdp { Year = 2013, Value = 9.607},
                        new Gdp { Year = 2012, Value = 8.561},
                        new Gdp { Year = 2011, Value = 7.573},
                        new Gdp { Year = 2010, Value = 6.101},
                        new Gdp { Year = 2009, Value = 5.11},
                        new Gdp { Year = 2008, Value = 4.598}
                    }
                },
                new GdpSeries {
                    CountryName = "Japan",
                    Values = new Collection<Gdp> {
                        new Gdp { Year = 2015, Value = 4.383},
                        new Gdp { Year = 2014, Value = 4.849},
                        new Gdp { Year = 2013, Value = 5.156},
                        new Gdp { Year = 2012, Value = 6.203},
                        new Gdp { Year = 2011, Value = 6.157},
                        new Gdp { Year = 2010, Value = 5.7},
                        new Gdp { Year = 2009, Value = 5.231},
                        new Gdp { Year = 2008, Value = 5.038}
                    }
                }
            };
        }
    }
    #endregion #ViewModel
}
