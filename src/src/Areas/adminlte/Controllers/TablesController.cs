﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace src.Areas.adminlte.Controllers
{
    [Area("adminlte")]
    public class TablesController : Controller
    {
        public IActionResult SimpleTables()
        {
            return View();
        }

        public IActionResult DataTables()
        {
            return View();
        }
    }
}