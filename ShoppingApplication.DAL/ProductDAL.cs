using ShoppingApplication.BOL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.DAL
{
    public class ProductDAL
    {
        private readonly ShoppingContext db = new ShoppingContext();
        public List<Product> GetProducts()
        {
            return db.Products.ToList();
        }
        
        
        public List<Product> GetSellerProducts(int sellerId)
        {
            return db.Products.Where(x=>x.SellerId==sellerId).ToList();
        }
     

        public void AddProudctStatus(ProductStatus productStatus)
        {
            db.ProductStatuses.Add(productStatus);
            db.SaveChanges();
        }
        public ProductStatus GetProductStatus(int Id)
        {
            return db.ProductStatuses.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditProductStatus(ProductStatus productStatus)
        {
            var DbProductStatus = db.ProductStatuses.Where(x => x.Id == productStatus.Id).FirstOrDefault();
            if (DbProductStatus != null)
            {
                if (!String.IsNullOrEmpty(productStatus.Name))
                {
                    DbProductStatus.Name = productStatus.Name;
                }
            }
            db.SaveChanges();
        }
        public void DeleteProductStatus(int Id)
        {
            db.ProductStatuses.Remove(db.ProductStatuses.Find(Id));
            db.SaveChanges();
        }
        public List<ProductStatus> GetProductStatuses()
        {
            return db.ProductStatuses.ToList();
        }
        public void AddProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }
        public Product GetProduct(int Id)
        {
            return db.Products.Where(x => x.Id == Id).FirstOrDefault();
        }
        public void EditProduct(Product product)
        {
            var DbProduct = db.Products.Where(x => x.Id == product.Id).FirstOrDefault();
            if (DbProduct != null)
            {
                if (!String.IsNullOrEmpty(product.Name))
                {
                    DbProduct.Name = product.Name;
                }
                if (!String.IsNullOrEmpty(product.Price))
                {
                    DbProduct.Price = product.Price;
                }
                if (!String.IsNullOrEmpty(product.SellerId.ToString()))
                {
                    DbProduct.SellerId = product.SellerId;
                }
                if (!String.IsNullOrEmpty(product.ProductStatusId.ToString()))
                {
                    DbProduct.ProductStatusId = product.ProductStatusId;
                }
            }
            db.SaveChanges();
        }
        public void DeleteProduct(int Id)
        {
            db.Products.Remove(db.Products.Find(Id));
            db.SaveChanges();
        }
    }
}
