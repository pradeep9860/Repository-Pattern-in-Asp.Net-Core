using System;
using System.ComponentModel.DataAnnotations;

namespace Core.EntityDto
{
    public class MasterCompanyDto
    { 
        public Guid Id { get; set; }
        public string INITIAL { get; set; }
        public string NAME { get; set; }
        public string ADDRESS { get; set; }
        public string TELA { get; set; }
        public string FAX { get; set; }
        public string VAT { get; set; }
        public string EMAIL { get; set; }
        public string WEBSITE { get; set; }
        public DateTime FBDATE { get; set; }
        public DateTime FEDATE { get; set; }
        public string FBDATE_BS { get; set; }
        public string FEDATE_BS { get; set; }
        public int ISBRANCH { get; set; }
        //public string ID { get; set; }
        public string ACID { get; set; }
        public string PhiscalID { get; set; }
    }
}
