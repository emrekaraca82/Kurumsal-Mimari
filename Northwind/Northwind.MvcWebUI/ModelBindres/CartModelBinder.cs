﻿using Northwind.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Northwind.MvcWebUI.ModelBindres
{
    public class CartModelBinder : System.Web.Mvc.IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var cart = (Cart)controllerContext.HttpContext.Session["cart"];
            if (cart == null)
            {
                cart = new Cart();
                controllerContext.HttpContext.Session["cart"] = cart;
            }
            return cart;
        }
    }
}