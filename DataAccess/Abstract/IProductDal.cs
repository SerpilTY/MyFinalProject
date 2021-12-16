using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    
    //interface metodları default publictir
    //interface'in kendisi default public değildir.
    //Alternatif bir teknoloji olan ortamı
    //kodluyorsak hemen orada klasörleme tekniğine gitmemiz gerekiyor.
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetAllByCategory(int categoryId); 
    }
}
