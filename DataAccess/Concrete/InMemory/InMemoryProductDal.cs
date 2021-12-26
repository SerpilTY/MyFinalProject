using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
            new Product{ProductId=1,UnitPrice=15, UnitsInStock=15,CategoryId=1,ProductName="Bardak",},
            new Product{ProductId=2,UnitPrice=500, UnitsInStock=3,CategoryId=1,ProductName="Kamera",},
            new Product{ProductId=3,UnitPrice=1500, UnitsInStock=2,CategoryId=2,ProductName="Telefon",},
            new Product{ProductId=4,UnitPrice=150, UnitsInStock=65,CategoryId=2,ProductName="Klavye",},
            new Product{ProductId=5,UnitPrice=85, UnitsInStock=1,CategoryId=2,ProductName="Fare",}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            //LINQ-Language Integrated Querry
            Product productToDelete;
            /*
             
            foreach (var p in _products)
            {
                if (product.ProductId==p.ProductId )
                {
                    productToDelete = p;
                }
            */
            productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            _products.Remove(productToDelete);


        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p=>p.CategoryId==categoryId).ToList();
            
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün id'sine sahip olan listedeki ürünü bul 
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;

        }

        
    }
}
