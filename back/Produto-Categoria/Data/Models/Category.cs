using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    [Table("Categories")]
    public class Category:Base
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
