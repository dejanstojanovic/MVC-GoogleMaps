using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using Mvc.GoogleMaps.Models;

namespace Mvc.GoogleMaps
{
    public static class ExtensionMethods
    {
        public static string ToJsonString(this Map map){
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Serialize(map);
    }
        public static Map ToMapObject(this string mapjson)
        {
            JavaScriptSerializer serializer = new JavaScriptSerializer();
            return serializer.Deserialize<Map>(mapjson);
        }
    }
}
