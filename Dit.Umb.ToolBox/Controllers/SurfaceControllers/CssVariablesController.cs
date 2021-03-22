﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Dit.Umb.ToolBox.Models.PoCo;
using Umbraco.Web.Mvc;

namespace Dit.Umb.ToolBox.Controllers.SurfaceControllers
{
    public class CssVariablesController : SurfaceController
    {
        // GET: CssVariables
        public ActionResult Index(Theme theme)
        {
            return View("~/Views/Partials/CssVariables.cshtml", theme);
        }
    }
}