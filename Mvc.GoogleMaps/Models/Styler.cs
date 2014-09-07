using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc.GoogleMaps.Models
{
    public class Styler
    {
        public string visibility { get; set; }
        public double? weight { get; set; }
        public string hue { get; set; }
        public int? saturation { get; set; }
        public int? lightness { get; set; }
        public string color { get; set; }
        public int? gamma { get; set; }
        public bool invert_lightness { get; set; }
    }
}
