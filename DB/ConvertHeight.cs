﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace DB
{
    public class ConvertHeight : IValueConverter
    {
        
            public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
            {
                if (value is double height)
                {
                    return height - 100;
                }
                return value;
            }

            // Этот метод используется редко, поэтому оставим его пустым
            public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
            {
                throw new NotImplementedException();
            }
        
    }
}
