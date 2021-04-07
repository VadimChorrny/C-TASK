using System;
using System.Collections.Generic;
using System.Text;

namespace Exchange_Rate
{
    class ExchangeOffice
    {
        public string ccy { get; set; } // код валюти
        public string base_ccy { get; set; } // код національної валюти
        public string buy { get; set; } // курс куплі
        public string sell { get; set; } // курс продажі
    }
}
