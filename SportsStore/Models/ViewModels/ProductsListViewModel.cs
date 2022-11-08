using System.Collections.Generic;
using SportsStore.Models;

namespace SportsStore.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PaggingInfo PagingInfo { get; set; }
        public string CurrentCategory { get; set; }
    }
}
