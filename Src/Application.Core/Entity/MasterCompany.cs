using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Core.Entity
{
    public class MasterCompany
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
