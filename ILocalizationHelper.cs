using LocalizationService.Models;
using System.Collections.Generic;

namespace LocalizationService.Helpers
{
    public interface ILocalizationHelper
    {
        Culture GetAllLanguageResources();
    }
}