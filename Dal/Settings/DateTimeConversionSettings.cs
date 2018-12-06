using System;
using System.Globalization;
using System.Threading;

namespace Dal.Settings
{
    public static class DateTimeConversionSettings
    {
        public static void Configure()
        {
            CultureInfo culture = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            culture.DateTimeFormat.ShortDatePattern = "yyyy-MM-dd";
            culture.DateTimeFormat.LongTimePattern = "hh:mm:ss";
            Thread.CurrentThread.CurrentCulture = culture;
            Console.WriteLine(DateTime.Now);
        }
    }
}
