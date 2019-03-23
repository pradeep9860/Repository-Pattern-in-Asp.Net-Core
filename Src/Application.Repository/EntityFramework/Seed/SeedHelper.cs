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
            var allMasterCompany = new List<string>
            {
                "Company A",
                "Company B",
                "Company B",
                "Company C",
                "Company D",
                "Company E",
                "Company F",
                "Company G",
                "Company H",
                "Company I",
                "Company J",
                "Company K",
                "Company L"
            };

            if (context.MasterCompany.Count(x => allMasterCompany.Contains(x.Name)) != allMasterCompany.Count)
            {
                var newCompany = allMasterCompany.Where(p => !context.MasterCompany.Any(x => x.Name == p))
                                        .Select(x => new MasterCompany { Id = Guid.NewGuid(), Name = x });

                if (newCompany.Any())
                {
                    context.MasterCompany.AddRange(newCompany);
                }
            } 

            context.SaveChanges();
        }
    }
}
