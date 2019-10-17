using Glass.Mapper.Sc.Fields;
using Sam.Feature.Button.Areas.Feature.Models.Rendering_Parameters;
using Sam.Feature.Button.Areas.Feature.Models.ScModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sam.Feature.Button.Areas.Feature.Models.ViewModels
{
    public class ButtonViewModel
    {
        public Guid Id { get; set; }
        public Link Link { get; set; }
        public string Class { get; set; }

    }
}