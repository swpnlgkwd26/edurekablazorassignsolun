using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace blazor_app.Data
{
    public class Account
    {
        public int CustomerId { get; set; }
        [Key]
        [Required]
        public int AccountNumber { get; set; }
        [Required]
        public string AccountHolderName { get; set; }
        [Required]
        public string Address { get; set; }
        [Phone]
        public string MobileNumber { get; set; }
        [Required]
        public double Balance { get; set; }
        [Required]        
        public string TypeOfAccount { get; set; }

    }
}
