using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platform.Converters;

namespace MvxApp.Core.Converters
{
    public class DatetimeToStringValueConverter : MvxValueConverter<DateTime, string>
    {
        protected override string Convert(DateTime value, Type targetType, object parameter, CultureInfo culture)
        {
            var format = parameter as string;
            if (string.IsNullOrWhiteSpace(format)) { format = "yyyy/MM/dd"; }
            return value.ToString(format);
        }

        protected override DateTime ConvertBack(string value, Type targetType, object parameter, CultureInfo culture)
        {
            var format = parameter as string;
            if (string.IsNullOrWhiteSpace(format)) { format = "yyyy/MM/dd"; }
            if (DateTime.TryParseExact(value, format, null, DateTimeStyles.None, out DateTime dt))
            {
                return dt;
            }
            throw new InvalidCastException();
        }
    }
}
