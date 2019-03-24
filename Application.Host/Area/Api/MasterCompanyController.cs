using System.Collections.Generic;
using Application.Service.Providers;
using Core.EntityDto;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace Application.Host.Area.Api
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class MasterCompanyController : ControllerBase
    {
        private readonly IMasterCompanyService _masterCompanyService;
        public MasterCompanyController(IMasterCompanyService masterCompanyService)
        {
            _masterCompanyService = masterCompanyService;
        }

        [HttpGet]
        [Route("GetAll")]
        [EnableQuery()]
        public List<MasterCompanyDto> GetAll(string searchText)
        {
            return _masterCompanyService.GetAll(searchText);
        }

        [HttpPost]
        [Route("save")] 
        public MasterCompanyDto Save([FromBody]MasterCompanyDto model)
        {
            _masterCompanyService.Save(model);
            return model;
        }
    }
}