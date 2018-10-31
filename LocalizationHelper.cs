using I18Next.Net;
using I18Next.Net.Backends;
using I18Next.Net.Plugins;
using LocalizationService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LocalizationService.Helpers
{
    public class LocalizationHelper : ILocalizationHelper
    {
        public Culture GetAllLanguageResources()
        {
            Culture cultures = new Culture();

            Dictionary<string, string> EnDic = new Dictionary<string, string>();
            EnDic.Add("Key1", "Hello");
            cultures.En = EnDic;

            Dictionary<string, string> ArDic = new Dictionary<string, string>();
            ArDic.Add("Key1", "مرحبا");
            cultures.Ar = ArDic;

            return cultures;
        }

    }
}