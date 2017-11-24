using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmCross.Platform.Converters;

namespace MvxApp.Core.Converters
{
    public class DatetimeToStringValueConverter : IMvxValueConverter
    {
        #region IMvxValueConverterの実装
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is DateTime)
            {
                return ((DateTime)value).ToString("yyyy/MM/dd");
            }

            return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value is string)
            {
                DateTime dt;
                if (DateTime.TryParseExact(value.ToString(), "yyyy/MM/dd", null, DateTimeStyles.None, out dt))
                {
                    return dt;
                }
            }

            return value;
        }
        #endregion
    }
}
