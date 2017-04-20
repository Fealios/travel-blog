using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    [Table("locations")]
    public class Location
    {
        [Key]
        public int id { get; set; }
        public string location_name { get; set; }
    }
}
