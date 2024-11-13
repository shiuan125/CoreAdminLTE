using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAdminLTE.Helpers
{
    public static class NavigationIndicatorHelper
    {
        public static string MakeActiveClass(this IUrlHelper urlHelper, string controller, string action)
        {
            try
            {
                string result = "active";
                string controllerName = urlHelper.ActionContext.RouteData.Values["controller"].ToString();
                string methodName = urlHelper.ActionContext.RouteData.Values["action"].ToString();
                if (string.IsNullOrEmpty(controllerName)) return null;
                if (controllerName.Equals(controller, StringComparison.OrdinalIgnoreCase))
                {
                    if (methodName.Equals(action, StringComparison.OrdinalIgnoreCase))
                    {
                        return result;
                    }
                }
                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static string MakeMenuOpenClass(this IUrlHelper urlHelper, string controller)
        {
            try
            {
                if (urlHelper.ActionContext.RouteData.Values["controller"] == null)
                    return null;

                string result = "menu-is-opening menu-open";
                string controllerName = urlHelper.ActionContext.RouteData.Values["controller"].ToString();
                if (string.IsNullOrEmpty(controllerName)) return null;
                if (controllerName.Equals(controller, StringComparison.OrdinalIgnoreCase))
                    return result;

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static string MakeMenuActiveClass(this IUrlHelper urlHelper, string controller)
        {
            try
            {
                if (urlHelper.ActionContext.RouteData.Values["controller"] == null)
                    return null;

                string result = "active";
                string controllerName = urlHelper.ActionContext.RouteData.Values["controller"].ToString();
                if (string.IsNullOrEmpty(controllerName)) return null;
                if (controllerName.Equals(controller, StringComparison.OrdinalIgnoreCase))
                    return result;

                return null;
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static string MakeMenuDisplayClass(this IUrlHelper urlHelper, string controller)
        {
            try
            {
                if (urlHelper.ActionContext.RouteData.Values["controller"] == null)
                    return "none";

                string result = "block";
                string controllerName = urlHelper.ActionContext.RouteData.Values["controller"].ToString();
                if (string.IsNullOrEmpty(controllerName)) return null;
                if (controllerName.Equals(controller, StringComparison.OrdinalIgnoreCase))
                    return result;

                return "none";
            }
            catch (Exception)
            {
                return "none";
            }
        }
        
    }
}
