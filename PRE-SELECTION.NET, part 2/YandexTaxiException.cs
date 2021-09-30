using System;
using System.Collections.Generic;
using System.Text;

namespace PRE_SELECTION.NET__part_2
{
    class YandexTaxiException : Exception
    {
        public YandexTaxiException(string message)
        : base(message)
        { }
    }
}
