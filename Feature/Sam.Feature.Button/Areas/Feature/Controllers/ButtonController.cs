using Glass.Mapper.Sc.Web.Mvc;
using Sam.Feature.Button.Areas.Feature.Models.Rendering_Parameters;
using Sam.Feature.Button.Areas.Feature.Models.ScModels;
using Sam.Feature.Button.Areas.Feature.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sam.Feature.Button.Areas.Feature.Controllers
{
    public class ButtonController : GlassController
    {
        public ActionResult Button()
        {
            var model = new ButtonViewModel(GetDataSourceItem<ButtonScModel>(), GetRenderingParameters<ButtonRP>());
            return View("~/Areas/Feature/Views/Button/Button.cshtml", model);
        }
    }
}