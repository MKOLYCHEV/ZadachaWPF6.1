using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ZadachaWPF6._1
{
    class WeatherControl : DependencyObject
    {
        public static readonly DependencyProperty TemperatureProperty
            = DependencyProperty.Register(
                nameof(Temperature),
                typeof(int),
                typeof(WeatherControl),
                new FrameworkPropertyMetadata(
                    0,
                    FrameworkPropertyMetadataOptions.AffectsMeasure,
                    null,
                    new CoerceValueCallback(CoerceTemperature)));

        private static object CoerceTemperature(DependencyObject d, object baseValue)
        {
            int t = (int)baseValue;
            if (t >= -50 && t <= 50)
            {
                return t;
            }
            else
            {
                return 0;
            }

        }

        public int Temperature
        {
            get => (int)GetValue(TemperatureProperty);
            set => SetValue(TemperatureProperty, value);
        }

        private string windDirection;
        public string WindDirection
        {
            get => windDirection;
            set => windDirection = value;

        }

        private int windSpeed;
        public int WindSpeed
        {
            get => windSpeed;
            set => windSpeed = value;

        }

        enum Precipitation
        {
            Солнечно,
            Облачно,
            Дождь,
            Снег
        }
    }
}
