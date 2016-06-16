﻿using System;
using System.IO.Compression;
using System.Linq;

namespace CompressR.MVC
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public sealed class DeflateAttribute : System.Web.Mvc.ActionFilterAttribute
    {
        /// <summary>
        /// Override to compress the content that is generated by
        /// an action method.
        /// </summary>
        /// <param name="filterContext"></param>
        public override void OnActionExecuting(System.Web.Mvc.ActionExecutingContext filterContext)
        {
            CompressFactory.Compress(Constants.Deflate, filterContext);
        }
    }
}