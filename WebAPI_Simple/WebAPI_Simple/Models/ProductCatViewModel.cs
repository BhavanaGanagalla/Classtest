using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI_DB_Crud.Models
{
    public class ProductCatViewModel
    {
        [Key]
        public int ProductId{get; set;}
        //public int CategoryId { get; set; }
        public int CatId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public string CatName { get; set; }

        //public string CategoryName { get; set; }
        //public int Price { get; set; }
    }
}
