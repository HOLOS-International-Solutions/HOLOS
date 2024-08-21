﻿#region Imports

using System;
using System.Globalization;
using Avalonia.Data.Converters;
using System.Windows;
#endregion

namespace H.Infrastructure.Controls.ValueConverters
{
    /// <summary>
    /// </summary>
    public class BooleanToVisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var param = bool.Parse(value.ToString());
            if (param)
            {
                //return Visibility.Visible;
                return true;
            }

            //return Visibility.Collapsed;
            return false;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}