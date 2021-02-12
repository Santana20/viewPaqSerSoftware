using System.Collections.Generic;

namespace Entities
{
    public class Brand
    {
        public long idBrand { get; set; }
        public string nameBrand { get; set; }

        public Brand()
        {
            //empty for framework
        }
        
    }

    public class ProductType
    {
        public long idProductType { get; set; }
        public string nameProductType { get; set; }

        public ProductType()
        {
            //empty for framework
        }

    }

    public class Product
    {
        public string idProduct { get; set; }
        public string nameProduct { get; set; }
        public long idBrand { get; set; }
        public long idProductType { get; set; }
        public List<DetailProduct> detailProductsList { get; set; }

        public Product()
        {
            //empty for framework
        }

        public override string ToString()
        {
            
            return "Product{" +
                    "idProduct='" + idProduct + '\'' +
                    ", nameProduct='" + nameProduct + '\'' +
                    ", idBrand=" + idBrand +
                    ", detailProductsList=" + detailProductsList +
                    '}';
        }
    }

    public class DetailProduct
    {
        public long idDetailProduct { get; set; }
        public string netContent { get; set; }
        public long stock { get; set; }
        public decimal salePrice { get; set; }
        public string saleUnit { get; set; }
        public string idProduct { get; set; }
        public DetailProduct()
        {
            //empty for framework
        }
        public override string ToString()
        {
            return "DetailProduct{" +
                    "idDetailProduct=" + idDetailProduct +
                    ", netContent='" + netContent + '\'' +
                    ", stock=" + stock +
                    ", saleUnit='" + saleUnit + '\'' +
                    ", salePrice=" + salePrice +
                    ", idProduct='" + idProduct + '\'' +
                    '}';
        }
    }
}
