using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Sam.Foundation.GlassMapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.Feature.Button.Areas.Feature.Models.ScModels
{
    [SitecoreType(TemplateId = "{C5970CBC-F717-4757-92BF-FC90B89C2FF7}")] // Id Template: Option
    public class Option : BaseScModel
    {

        [SitecoreField(FieldType = SitecoreFieldType.SingleLineText)]
        public virtual string Class { get; set; }
    }
}