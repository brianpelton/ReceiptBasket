using System;
using System.Globalization;
using MvvmFx.Windows.Data;

namespace ReceiptBasket.ViewHelper
{
    public class FloatToIntConverter : IValueConverter
    {
        #region [ Static Fields ]

        private static readonly Lazy<FloatToIntConverter> LazyInstance =
            new Lazy<FloatToIntConverter>(() => new FloatToIntConverter());

        #endregion

        #region [ Constructors ]

        private FloatToIntConverter()
        {
        }

        #endregion

        #region [ Properties ]

        public static FloatToIntConverter Instance
        {
            get { return LazyInstance.Value; }
        }

        #endregion

        #region [ Interface IValueConverter Members ]

        public object Convert(object value, Type type, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            return System.Convert.ToInt16(value);
        }

        public object ConvertBack(object value, Type type, object parameter, CultureInfo culture)
        {
            if (value == null)
                return null;

            return System.Convert.ToSingle(value);
        }

        #endregion
    }
}