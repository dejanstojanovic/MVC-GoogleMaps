using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using Mvc.GoogleMaps.Models;

namespace Mvc.GoogleMaps
{
    public static class HtmlHelpers
    {
        private static MvcHtmlString GoogleMap(HtmlHelper helper, string id, Models.Map map, bool editor)
        {
            StringBuilder sbControlHtml = new StringBuilder();
            using (StringWriter stringWriter = new StringWriter())
            {
                using (HtmlTextWriter htmlWriter = new HtmlTextWriter(stringWriter))
                {
                    //Generate container div control
                    HtmlGenericControl divWrapperControl = new HtmlGenericControl("div");
                    HtmlGenericControl divMapControl = new HtmlGenericControl("div");
                    divMapControl.Attributes.Add("class", "map-container");
                    divMapControl.Attributes.Add("id", string.Format("map-{0}", id));
                    if (map.height > 0 || map.width > 0)
                    {
                        string widthStyle = "width:{0}px;";
                        if (map.width > 0)
                        {
                            widthStyle = string.Format(widthStyle, map.width);
                        }
                        else
                        {
                            widthStyle = string.Empty;
                        }

                        string heightStyle = "height:{0}px;";
                        if (map.height > 0)
                        {
                            heightStyle = string.Format(heightStyle, map.height);
                        }
                        else
                        {
                            heightStyle = string.Empty;
                        }

                        divMapControl.Attributes.Add("style", string.Concat(widthStyle, heightStyle));
                    }

                    divWrapperControl.Controls.Add(divMapControl);

                    //value input control
                    HtmlInputHidden hidden = new HtmlInputHidden();
                    HtmlInputHidden hiddenValueControl = new HtmlInputHidden();
                    hiddenValueControl.ID = id;
                    divWrapperControl.Controls.Add(hiddenValueControl);

                    HtmlGenericControl scriptControl = new HtmlGenericControl("script");
                    scriptControl.Attributes.Add("type", "text/javascript");
                    scriptControl.InnerHtml = string.Format(@"$(document).ready(function(){{
                                                    $('#map-{0}').GoogleMapEditor($.extend({{}},{1},{{dataChange:function(sender, data){{ $(sender.container).next().next().val(data); }}}}));}});", id, map.ToJsonString());
                    divWrapperControl.Controls.Add(scriptControl);
                    divWrapperControl.RenderControl(htmlWriter);
                    sbControlHtml.Append(stringWriter.ToString());
                    divWrapperControl.Dispose();
                }
            }
            return new MvcHtmlString(sbControlHtml.ToString());
        }

        public static MvcHtmlString GoogleMapEditor(this HtmlHelper helper, string id, Models.Map map)
        {
            return GoogleMap(helper, id, map, true);
        }
        public static MvcHtmlString GoogleMapViewer(this HtmlHelper helper, string id, Models.Map map)
        {
            return GoogleMap(helper, id, map, false);
        }
    }
}
