using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvc.GoogleMaps.Models
{
    public class Location
    {
        public List<Coordinate> Coordinates { get; set; }
        public int Radius { get; set; }
        public string LocationType { get; set; }
        public string Icon { get; set; }
        public string HoverIcon { get; set; }
        public string Message { get; set; }
        public object Tag { get; set; }
    }
}
