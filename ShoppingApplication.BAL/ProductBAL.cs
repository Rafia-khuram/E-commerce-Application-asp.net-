using ShoppingApplication.BOL;
using ShoppingApplication.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApplication.BAL
{
    public class ProductBAL
    {
        public List<Product> GetProducts()
        {
            return new ProductDAL().GetProducts();
        }

        public List<Product> GetSellerProducts(int sellerId)
        {
            return new ProductDAL().GetSellerProducts(sellerId);
        }


        public void AddProudctStatus(ProductStatus productStatus)
        {
            new ProductDAL().AddProudctStatus(productStatus);
        }
        public ProductStatus GetProductStatus(int Id)
        {
            return new ProductDAL().GetProductStatus(Id);
        }
        public void EditProductStatus(ProductStatus productStatus)
        {
            new ProductDAL().EditProductStatus(productStatus);
        }
        public void DeleteProductStatus(int Id)
        {
            new ProductDAL().DeleteProductStatus(Id);
        }
        public List<ProductStatus> GetProductStatuses()
        {
            return new ProductDAL().GetProductStatuses();
        }
        public void AddProduct(Product product)
        {
            product.Image = "/Images/3.jpg";
            product.UploadedOn = DateTime.UtcNow.AddHours(5);
            new ProductDAL().AddProduct(product);
        }
        public Product GetProduct(int Id)
        {
            return new ProductDAL().GetProduct(Id);
        }
        public void EditProduct(Product product)
        {
            new ProductDAL().EditProduct(product);
        }
        public void DeleteProduct(int Id)
        {
            new ProductDAL().DeleteProduct(Id);
        }
    }
}
