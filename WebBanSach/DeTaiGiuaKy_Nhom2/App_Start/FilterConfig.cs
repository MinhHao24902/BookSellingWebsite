﻿using System.Web.Mvc;

namespace DeTaiGiuaKy_Nhom2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
