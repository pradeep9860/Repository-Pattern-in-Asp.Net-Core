using System;
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
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        [Route("GetAll")]
        [EnableQuery()]
        public List<CompanyDto> GetAll(string searchText)
        {
            return _companyService.GetAll(searchText);
        }

        [HttpGet]
        [Route("CheckCompany")]
        public ResutlDto CheckCompany()
        {
            return  new ResutlDto
            {
                Result = _companyService.CheckCompany()
            }; 
        }

        [HttpPost]
        [Route("Save")]
        public CompanyDto Save(CompanyDto model)
         {
            _companyService.Save(model);
            return model;
        }
    }

    public class ResutlDto
    {
        public object Result { get; set; }
    }
}