using Application.Core.Entity;
using Core.DI.Base;
using Core.EntityDto;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Application.Service.Providers
{
    public class MasterCompanyService : ITransientService, IMasterCompanyService
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
                result = result.Where(x => x.NAME.ToLower().Trim().Contains(searchText));
            }

            return result.Select(x => new MasterCompanyDto {
                Id = x.Id,
                NAME = x.NAME,
                ACID = x.ACID,
                ADDRESS = x.ADDRESS,
                EMAIL = x.EMAIL,
                FAX = x.FAX,
                FBDATE = x.FBDATE,
                FBDATE_BS = x.FBDATE_BS,
                FEDATE = x.FEDATE,
                FEDATE_BS = x.FEDATE_BS, 
                WEBSITE = x.WEBSITE,
                ISBRANCH = x.ISBRANCH,
                PhiscalID = x.PhiscalID,
                TELA = x.TELA,
                VAT = x.VAT
            }).ToList();
        }

        public void Update(MasterCompanyDto entity)
        {
            //use automapper 
            var saveModel = new MasterCompany
            {
                Id = entity.Id,
                NAME = entity.NAME,
                ACID = entity.ACID,
                ADDRESS = entity.ADDRESS,
                EMAIL = entity.EMAIL,
                FAX = entity.FAX,
                FBDATE = entity.FBDATE,
                FBDATE_BS = entity.FBDATE_BS,
                FEDATE = entity.FEDATE,
                FEDATE_BS = entity.FEDATE_BS, 
                WEBSITE = entity.WEBSITE,
                ISBRANCH = entity.ISBRANCH,
                PhiscalID = entity.PhiscalID,
                TELA = entity.TELA,
                VAT = entity.VAT
            };

            _repository.Update(saveModel);
            _uow.Commit(); 
        }

        public void Save(MasterCompanyDto entity)
        {
            var saveModel = new MasterCompany
            {
                Id = entity.Id,
                NAME = entity.NAME,
                ACID = entity.ACID,
                ADDRESS = entity.ADDRESS,
                EMAIL = entity.EMAIL,
                FAX = entity.FAX,
                FBDATE = entity.FBDATE,
                FBDATE_BS = entity.FBDATE_BS,
                FEDATE = entity.FEDATE,
                FEDATE_BS = entity.FEDATE_BS, 
                WEBSITE = entity.WEBSITE,
                ISBRANCH = entity.ISBRANCH,
                PhiscalID = entity.PhiscalID,
                TELA = entity.TELA,
                VAT = entity.VAT
            };

            _repository.Add(saveModel);
            _uow.Commit();

        }
    }
}
