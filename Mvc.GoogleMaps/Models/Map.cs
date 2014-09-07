using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Reflection;
using System.Web.Script;
using System.Web.Script.Serialization;

namespace Mvc.GoogleMaps.Models
{
    public class Map
    {
        #region Constructors
        public Map()
        {
            this.center = new Models.Center() { latitude = 25.0417, longitude = 55.2194 }; 
            this.locations = new List<Location>();
            this.style = new List<Style>();
            this.markerPinFiles = new List<string>() { "flag-azure.png", "flag-green.png", "needle-pink.png", "niddle-green.png", "pin-azure.png", "pin-green.png", "pin-pink.png" };
            this.drawingTools = new List<string>() { "marker", "polyline", "polygon", "circle", "rectangle" };
            this.editTemplatesPath = "/Scripts/html/";
            this.markerPinsPath = "/Scripts/img/pin/";
            this.drawingBorderColor = "#ff0000";
            this.drawingBorderWidth = 2;
            this.drawingFillColor ="#ffff00";
            this.zoom = 13;
            this.language = "en";
            this.stylesPath = "/Scripts/styles.json";
            this.zoomControl = true;
            this.panControl = true;
            this.scaleControl = true;
            this.streetViewControl = true;
            this.scrollWheel = true;
            this.richtextEditor = true;
            this.searchBox = true;
            this.width = 1000;
            this.height = 400;
         
        }
        #endregion

        #region Properties
        public bool editMode { get; set; }
        public string editTemplatesPath { get; set; }
        public string markerPinsPath { get; set; }
        public List<string> markerPinFiles { get; set; }
        public string drawingBorderColor { get; set; }
        public int drawingBorderWidth { get; set; }
        public string drawingFillColor { get; set; }
        public int zoom { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public bool singleLocation { get; set; }
        public Center center { get; set; }
        public string language { get; set; }
        public bool searchBox { get; set; }
        public bool richtextEditor { get; set; }
        public List<string> drawingTools { get; set; }
        public bool zoomControl { get; set; }
        public bool panControl { get; set; }
        public bool scaleControl { get; set; }
        public bool streetViewControl { get; set; }
        public bool scrollWheel { get; set; }
        public string stylesPath { get; set; }
        public List<Style> style { get; set; }
        public List<Location> locations { get; set; }
        #endregion

    }
}
