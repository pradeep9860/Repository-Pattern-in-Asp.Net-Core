using Application.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Repository.EntityFramework.Seed
{
    public static class SeedHelper
    {
        public static void DbSeedDBInitializer(ApplicationDbContext context)
        {
            var allMasterCompany = new List<MasterCompany>
            {
                 new MasterCompany {
                            Id = Guid.NewGuid(),
                            NAME = "Company A",
                            ACID = "ACIDA",
                            ADDRESS = "Address A",
                            EMAIL = "emailA@gmail.com",
                            FAX = "4534534534",
                            FBDATE = DateTime.Now,
                            FBDATE_BS = "544",
                            FEDATE = DateTime.Now,
                            FEDATE_BS = "454",
                           // ID = "1", 
                            ISBRANCH = 1,
                            PhiscalID = "075/76",
                            TELA = "4563535",
                            VAT = "34534534",
                            WEBSITE = "www.abc.com"
                        },
                 new MasterCompany {
                            Id = Guid.NewGuid(),
                            NAME = "Company B",
                            ACID = "ACIDB",
                            ADDRESS = "Address B",
                            EMAIL = "emailB@gmail.com",
                            FAX = "4565464",
                            FBDATE = DateTime.Now,
                            FBDATE_BS = "56",
                            FEDATE = DateTime.Now,
                            FEDATE_BS = "56",
                         //   ID = "2",  
                            ISBRANCH = 0,
                            PhiscalID = "075/76",
                            TELA = "345353",
                            VAT = "353",
                            WEBSITE = "www.xyz.com"
                        },

            };

            if (context.MasterCompany.Count(x => allMasterCompany.Select(p => p.NAME).Contains(x.NAME)) != allMasterCompany.Count)
            {
                var newCompany = allMasterCompany.Where(p => !context.MasterCompany.Any(x => x.NAME == p.NAME))
                                        .Select(x =>
                                        x);

                if (newCompany.Any())
                {
                    context.MasterCompany.AddRange(newCompany);
                }
            }
            else
            {
                return;
            }

            context.SaveChanges();
        }
    }
}
