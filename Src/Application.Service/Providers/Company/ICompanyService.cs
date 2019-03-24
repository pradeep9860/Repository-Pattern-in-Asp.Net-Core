using Core.EntityDto;
using System.Collections.Generic;

namespace Application.Service.Providers
{
    public interface ICompanyService
    {
        List<CompanyDto> GetAll(string searchText);
        void Update(CompanyDto entity);
        void Save(CompanyDto entity);
        bool CheckCompany();
    }
}
