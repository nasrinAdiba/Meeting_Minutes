using System;
using System.Collections.Generic;

namespace Meeting_Minutes.Data
{
    public partial class ProductsServiceTbl
    {
        public int Id { get; set; }
        public string ProductService { get; set; } = null!;
        public int Quantity { get; set; }
    }
}
