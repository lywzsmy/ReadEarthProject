/*******************************************************************************
 * Copyright © 2016 Readearth.Framework 版权所有
 * Author: Readearth
 * Description: 地听快速开发平台
 * Website：http://www.readearth.com
*********************************************************************************/
using System.Configuration;
using System.Web;

namespace Readearth.Code
{
    public sealed class Licence
    {
        public static bool IsLicence(string key)
        {
            //string host = HttpContext.Current.Request.Url.Host.ToLower();
            //if (host.Equals("localhost"))
            //    return true;
            //string licence = ConfigurationManager.AppSettings["LicenceKey"];
            //if (licence != null && licence == Md5.md5(key, 32))
            //    return true;

            return true;
        }
        public static string GetLicence()
        {
            var licence = Configs.GetValue("LicenceKey");
            if (string.IsNullOrEmpty(licence))
            {
                licence = Common.GuId();
                Configs.SetValue("LicenceKey", licence);
            }
            return Md5.md5(licence, 32);
        }
    }
}
