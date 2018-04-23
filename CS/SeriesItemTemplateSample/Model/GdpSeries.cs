using System;
using System.Collections.Generic;

namespace SeriesItemTemplateSample.Model {
    #region #Model
    public class GdpSeries {
        public String CountryName { get; set; }
        public IEnumerable<Gdp> Values { get; set; }
    }

    public class Gdp {
        public int Year { get; set; }
        public double Value { get; set; }
    }
    #endregion #Model
}
