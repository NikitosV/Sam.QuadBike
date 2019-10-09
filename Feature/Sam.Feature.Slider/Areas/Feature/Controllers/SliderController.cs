﻿using System;
using System.Web.Mvc;
using Sitecore;
using Sitecore.Data.Items;
using Sitecore.Mvc.Controllers;
using Sitecore.Mvc.Presentation;

namespace Sam.Feature.Slider.Areas.Feature.Controllers
{
    public class SliderController : SitecoreController
    {
        public ViewResult HeroSlider()
        {
            Item contentItem = null;

            var database = Context.Database;

            if (database != null)
            {
                if (!String.IsNullOrEmpty(
                         RenderingContext.Current.Rendering.DataSource))
                {
                    contentItem = database.GetItem(new Sitecore.Data.ID(
                            RenderingContext.Current.Rendering.DataSource));
                }
            }
            return View(contentItem);
        }
    }
}