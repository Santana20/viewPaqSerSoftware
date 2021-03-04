﻿using System;
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
        public Brand brand { get; set; }
        public ProductType productType { get; set; }
        public List<DetailProduct> detailProductsList { get; set; }
        public string nameBrand { get => getNameBrand(); }
        public string nameProductType { get => getNameProductType(); }
        public Product()
        {
            //empty for framework
        }
        public override string ToString()
        {
            
            return "Product{" +
                    "idProduct='" + idProduct + '\'' +
                    ", nameProduct='" + nameProduct + '\'' +
                    '}';
        }
        private string getNameBrand()
        {
            if (this.brand == null) return null;
            return this.brand.nameBrand;
        }
        private string getNameProductType()
        {
            if (this.productType == null) return null;
            return this.productType.nameProductType;
        }
    }
    public class DetailProduct
    {
        public long idDetailProduct { get; set; }
        public string netContent { get; set; }
        public decimal stock { get; set; }
        public decimal salePrice { get; set; }
        public string saleUnit { get; set; }
        public Product product { get; set; }
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
                    '}';
        }
        private string getidProduct()
        {
            if (this.product == null) return null;
            return this.product.idProduct;
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
        public DetailProduct detailProduct { get; set; }
        public Sale sale { get; set; }
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
                    '}';
        }
    }
}
