using Nification.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Nification.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public string Name { get; set; }    


        public string Location { get; set; }
       
        [DataType(DataType.Date)]

        public DateTime FistDate { get; set; }

        [DataType(DataType.Date)]

        public DateTime LastDate { get; set; }

        

        public DateTime Remaining { get; set; }

        public bool statement { get; set; }

        public string Customer_Id { get; set; }

        [ForeignKey("Customer_Id")]
        public virtual IdenUser? IdenUser { get; set; }
    }
}
