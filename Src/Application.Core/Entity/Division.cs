using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Entity
{
    //[Table("DIVISION")]
    public class Division
    {
        [Key]
        public string INITIAL { get; set; }
        public string NAME { get; set; }
        public string REMARKS { get; set; }
        public int MAIN { get; set; }
        public string COMNAME { get; set; }
        public string COMADD { get; set; }
        public string COMID { get; set; }
        public string ACID { get; set; }
        public string ID { get; set; }
        public string MSG1 { get; set; }
        public string MSG2 { get; set; }
        public string MSG3 { get; set; }
        public int RateGroupID { get; set; }
        public string TYPE { get; set; }
    }
}
