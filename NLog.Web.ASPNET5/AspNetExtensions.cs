﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNet.Builder;
using NLog.Web.Internal;

namespace NLog.Web
{
    /// <summary>
    /// Helpers for ASP.NET
    /// </summary>
    public static class AspNetExtensions
    {
        /// <summary>
        /// Enable NLog Web for ASP.NET 5.
        /// </summary>
        /// <param name="app"></param>

        public static void AddNLogWeb(this IApplicationBuilder app)
        {
            ServiceLocator.ServiceProvider = app.ApplicationServices;
        }

    }
}
