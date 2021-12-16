using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    //data access ürünü ekleyecek
    //business ürünü kontrol edecek
    //console ürünü gösterecek
    //o yüzden public
    //bir classın defaultu internaldır
    public class Product:IEntity

    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public short UnitsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductName { get; set; }

    }
}
