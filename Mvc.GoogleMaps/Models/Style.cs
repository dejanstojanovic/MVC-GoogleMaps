using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc.GoogleMaps.Models
{
    public class Style
    {
        public List<Styler> stylers { get; set; }
        public string featureType { get; set; }
        public string elementType { get; set; }
    }
}
