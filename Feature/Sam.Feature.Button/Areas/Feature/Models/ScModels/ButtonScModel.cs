using Glass.Mapper.Sc.Configuration;
using Glass.Mapper.Sc.Configuration.Attributes;
using Glass.Mapper.Sc.Fields;
using Sam.Foundation.GlassMapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.Feature.Button.Areas.Feature.Models.ScModels
{
    [SitecoreType(TemplateId = "{4DDAEB41-5696-4911-BE25-19853299BEAD}", AutoMap = true)] // Id Button Data Source Template
    public class ButtonScModel : BaseScModel
    {

        [SitecoreField(FieldType = SitecoreFieldType.GeneralLink)]
        public virtual Link Link { get; set; }
    }
}