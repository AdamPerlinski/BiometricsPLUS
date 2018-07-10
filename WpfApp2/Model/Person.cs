using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;


namespace WpfApp2.Model
{
    public class Person : DbContext
    {
        [Key]
        public int id { get; set; }


        public String image { get; set; }

        [Required]
        public String name { get; set; }

        [Required]
        public String surname { get; set; }

        [Required]
        public String street { get; set; }

        [Required]
        public String house { get; set; }

        [Required]
        public String number { get; set; }

        [Required]
        public String city { get; set; }

        [Required]
     
        public String zip { get; set; }

        [Required]
     
        public double height { get; set; }

        [Required]
        
        public double weight { get; set; }

        [Required]
        public String sex { get; set; }

        public String additional { get; set; }

    }
}
