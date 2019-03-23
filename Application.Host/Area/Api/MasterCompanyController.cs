using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Core.EntityDto;
using Application.Service.Providers;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.Host.Area.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MasterCompanyController : ControllerBase
    {
        private readonly IMasterCompanyService _masterCompanyService;
        public MasterCompanyController(IMasterCompanyService masterCompanyService)
        {
            _masterCompanyService = masterCompanyService;
        }

        [HttpGet(Name = "GetAll")] 
        [Route("GetAll")]
        [EnableQuery()]
        public List<MasterCompanyDto> GetAll(string searchText)
        {
            return _masterCompanyService.GetAll(searchText);
        }
    }
}