﻿using Glass.Mapper.Sc.Fields;
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
        public ButtonViewModel(ButtonScModel datasource, ButtonRP renderingParameteres)
        {
            if(datasource != null)
            {
                Id = datasource.Id;
                Link = datasource.Link;
            }

            if(renderingParameteres != null)
            {
                Class = $"btn {renderingParameteres.Style?.Class}";
            }
        }

        public Guid Id { get; set; }
        public Link Link { get; set; }
        public string Class { get; set; }

    }
}