using Application.Core.Entity;
using Application.Core.EntityDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Service.Providers
{
    public class MasterCompanyService : IMasterCompanyService
    {
        private readonly IUnitOfWork _uow;
        private readonly IRepository<MasterCompany> _repository;

        public MasterCompanyService(IUnitOfWork unit, IRepository<MasterCompany> repository)
        {
            _uow = unit;
            _repository = repository;
        }

        public List<MasterCompanyDto> GetAll(string searchText)
        {
            var result = _repository.AsQueryable();
            if (!string.IsNullOrEmpty(searchText))
            {
                result = result.Where(x => x.Name.ToLower().Trim().Contains(searchText));
            }

            return result.Select(x => new MasterCompanyDto {
                Id = x.Id,
                Name = x.Name
            }).ToList();
        }

        public void Update(MasterCompanyDto entity)
        {
            //use automapper 
            var saveModel = new MasterCompany
            {
                Id = entity.Id,
                Name = entity.Name
            };

            _repository.Update(saveModel);
            _uow.Commit(); 
        }

        public void Save(MasterCompanyDto entity)
        {
            var saveModel = new MasterCompany
            { 
                Name = entity.Name
            };

            _repository.Add(saveModel);
            _uow.Commit();

        }
    }
}
