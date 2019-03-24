using Core.EntityDto;
using System.Collections.Generic;

namespace Application.Service.Providers
{
    public interface IMasterCompanyService
    {
        List<MasterCompanyDto> GetAll(string searchText);
        void Update(MasterCompanyDto entity);
        void Save(MasterCompanyDto entity);
    }
}
