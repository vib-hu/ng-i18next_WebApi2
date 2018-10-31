using LocalizationService.Helpers;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;

namespace LocalizationService.Controllers
{
    public class LocalizationController : ApiController
    {
        ILocalizationHelper _localizationHelper;
        public LocalizationController()
        {
            _localizationHelper = new LocalizationHelper();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok();
        }

        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [Route("api/GetAllLanguageResources")]
        [HttpGet]
        public IHttpActionResult GetAllLanguageResources()
        {
            var res = _localizationHelper.GetAllLanguageResources();
            return Ok(JsonConvert.SerializeObject(res));
        }
    }
}
