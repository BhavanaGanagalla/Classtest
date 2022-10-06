using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_DB_Crud.Models
{
    public class Category
    {
        [Key]
        //public int CategoryId { get; set; }
        //public string CategoryName { get; set; }
        public int CatId { get; set; }
        public string CatName { get; set; }
    }
}
