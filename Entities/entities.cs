using System;
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
        public decimal stock { get; set; }
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
    public class Sale
    {
        public long idSale { get; set; }
        public string nameClient { get; set; }
        public DateTime dateSale { get; set; }
        public decimal total { get; set; }
        public List<DetailSale> detailSaleList { get; set; }
        public Sale()
        {
            // empty for framework
        }

        public override string ToString()
        {
            return "Sale{" +
                "idSale=" + idSale +
                ", nameClient='" + nameClient + '\'' +
                ", dateSale=" + dateSale +
                ", detailSaleList=" + detailSaleList +
                ", total=" + total +
                '}';
        }
    }
    public class DetailSale
    {
        public long idDetailSale { get; set; }
        public decimal saleCount { get; set; }
        public decimal subTotal { get; set; }
        public long idDetailProduct { get; set; }
        public long idSale { get; set; }
        public DetailSale()
        {
            // empty for framework
        }
        public override string ToString()
        {
            return "detailSale{" +
                    "idDetailSale=" + idDetailSale +
                    ", saleCount=" + saleCount +
                    ", subTotal=" + subTotal +
                    ", idDetailProduct=" + idDetailProduct +
                    ", idSale=" + idSale +
                    '}';
        }
    }
}
