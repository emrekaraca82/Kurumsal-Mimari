﻿using Northwind.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category

        private ICategoryService _categoryService;
        public CategoryController(ICategoryService categorytService)
        {
            _categoryService = categorytService;
        }
        public PartialViewResult List(int category=0)
        {
            ViewBag.CurrentCategory = category;
            return PartialView(_categoryService.GetAll());
        }
    }
}