using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.Feature.Button.Areas.Feature.Models.ScModels
{
    [SitecoreType(TemplateId = "")]
    public class Option
    {
        [SitecoreId]
        public virtual Guid Id { get; set; }

        [SitecoreField(FieldType = SitecoreFieldType.SingleLineText)]
        public virtual string Class { get; set; }
    }
}