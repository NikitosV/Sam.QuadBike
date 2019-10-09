using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sam.Feature.Button.Areas.Feature.Models.ScModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.Feature.Button.Areas.Feature.Models.Rendering_Parameters
{
    [SitecoreType(TemplateId = "{4A509DBE-A0A6-4BCC-ABDC-34E6C84B46F6}", AutoMap = true)] // Id Button Rendering Parameter Style
    public class ButtonRP
    {
        [SitecoreField(FieldType = SitecoreFieldType.Droplink)]
        public virtual Option Style { get; set; }
    }
}