using System;
using System.ComponentModel.DataAnnotations;

namespace Application.Core.EntityDto
{
    public class MasterCompanyDto
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
