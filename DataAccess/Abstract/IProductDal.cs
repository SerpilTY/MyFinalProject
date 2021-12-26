using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    
    //interface metodları default publictir
    //interface'in kendisi default public değildir.
    //Alternatif bir teknoloji olan ortamı
    //kodluyorsak hemen orada klasörleme tekniğine gitmemiz gerekiyor.
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetails();
    }
}
