using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class CartDetailSale
    {
        private List<CartDetailSaleItem> cartItems;
        private SortedSet<long> validateList;
        public decimal total { get; set; }
        public CartDetailSale()
        {
            this.cartItems = new List<CartDetailSaleItem>();
            this.validateList = new SortedSet<long>();
            total = 0m;
        }
        public int getCount() { return this.cartItems.Count; }
        public List<CartDetailSaleItem> getList() { return this.cartItems; }
        public void AddCartItem(CartDetailSaleItem cartItem)
        {
            if (this.validateList.Add(cartItem.idDetailProduct))
            {
                this.cartItems.Add(cartItem);
                total += cartItem.subTotal;
            }
            else throw new Exception("El producto ya se encuentra en el detalle de VENTA");
        }
        public void UpdateSaleCountByIndex(int index, decimal saleCount)
        {
            this.cartItems[index].count = saleCount;
            total -= this.cartItems[index].subTotal;
            this.cartItems[index].UpdateSubTotal();
            total += this.cartItems[index].subTotal;
        }
        public void DeleteCartItem(int index, long key)
        {
            total -= this.cartItems[index].subTotal;
            this.cartItems.RemoveAt(index);
            this.validateList.Remove(key);
        }
        public CartDetailSaleItem GetByIndex(int index)
        {
            return this.cartItems[index];
        }
        public List<DetailSale> ToDetailSaleList()
        {
            total = 0;
            List<DetailSale> detailSales = new List<DetailSale>();
            foreach(CartDetailSaleItem value in this.cartItems)
            {
                detailSales.Add(value.ToDetailSale());
                total += value.subTotal;
            }
            total = decimal.Round(total, 2, MidpointRounding.AwayFromZero);
            return detailSales;
        }
        public void GenerateNewList()
        {
            this.cartItems = new List<CartDetailSaleItem>();
            this.validateList = new SortedSet<long>();
            this.total = 0.00m;
        }
    }
    public class CartDetailSaleItem
    {
        public string codProduct { get; set; }
        public string description { get; set; }
        public decimal unitPrice { get; set; }
        public string saleUnit { get; set; }
        public decimal count { get; set; }
        public decimal subTotal { get; set; }
        public long idDetailProduct { get; set; }
        public decimal Stock { get; }
        public CartDetailSaleItem() { }
        public CartDetailSaleItem(Product product, DetailProduct detailProduct,
            decimal saleCount = 0m)
        {
            this.codProduct = product.codProduct;
            this.idDetailProduct = detailProduct.idDetailProduct;
            this.description = string.Concat(
                product.nameProduct, " / ", product.nameBrand,
                " / ", product.nameProductType, " / ", detailProduct.netContent);
            this.unitPrice = detailProduct.salePrice;
            this.saleUnit = detailProduct.saleUnit;
            this.count = saleCount;
            this.Stock = detailProduct.stock;
            this.UpdateSubTotal();
        }
        public DetailSale ToDetailSale()
        {
            DetailSale detailSale = new DetailSale()
            {
                saleCount = this.count,
                subTotal = this.subTotal,
                detailProduct = new DetailProduct { idDetailProduct = this.idDetailProduct }
            };
            return detailSale;
        }
        public void UpdateSubTotal()
        {
            this.subTotal = decimal.Round(this.unitPrice * this.count, 2, MidpointRounding.AwayFromZero);
        }
    }

    public class CartDetailPurchase
    {
        private List<CartDetailPurchaseItem> cartDetailPurchaseItems;
        private SortedSet<long> validateCartList;

        public decimal total { get; set; }
        public CartDetailPurchase()
        {
            this.cartDetailPurchaseItems = new List<CartDetailPurchaseItem>();
            this.validateCartList = new SortedSet<long>();
            this.total = 0.00m;
        }

        public int getCount() { return this.cartDetailPurchaseItems.Count; }
        public List<CartDetailPurchaseItem> getList() { return this.cartDetailPurchaseItems; }

        public void AddCartDPItem(CartDetailPurchaseItem cartDetailPurchaseItem)
        {
            if (this.validateCartList.Add(cartDetailPurchaseItem.idDetailProduct))
            {
                this.cartDetailPurchaseItems.Add(cartDetailPurchaseItem);
                total += cartDetailPurchaseItem.subTotal;
            }
            else throw new Exception("El producto ya se encuentra en el detalle de COMPRA");
        }
        public void UpdateQuantityByIndex(int index, decimal quantity)
        {
            if (this.cartDetailPurchaseItems[index].quantity.Equals(quantity)) return;

            this.cartDetailPurchaseItems[index].quantity = quantity;
            total -= this.cartDetailPurchaseItems[index].subTotal;
            this.cartDetailPurchaseItems[index].UpdateSubTotal();
            total += this.cartDetailPurchaseItems[index].subTotal;
        }
        public void UpdateUnitPriceByIndex(int index, decimal unitPrice)
        {
            if (this.cartDetailPurchaseItems[index].unitPrice.Equals(unitPrice)) return;

            this.cartDetailPurchaseItems[index].unitPrice = unitPrice;
            total -= this.cartDetailPurchaseItems[index].subTotal;
            this.cartDetailPurchaseItems[index].UpdateSubTotal();
            total += this.cartDetailPurchaseItems[index].subTotal;
        }
        public void DeleteCartDetailPurchaseItem(int index)
        {
            total -= this.cartDetailPurchaseItems[index].subTotal;
            long key = this.cartDetailPurchaseItems[index].idDetailProduct;

            this.cartDetailPurchaseItems.RemoveAt(index);
            this.validateCartList.Remove(key);
        }
        public CartDetailPurchaseItem GetByIndex(int index)
        {
            return this.cartDetailPurchaseItems[index];
        }
        public List<DetailPurchase> ToDetailPurchaseList()
        {
            total = 0;
            List<DetailPurchase> detailPurchases = new List<DetailPurchase>();
            foreach (CartDetailPurchaseItem value in this.cartDetailPurchaseItems)
            {
                detailPurchases.Add(value.ToDetailPurchase());
                total += value.subTotal;
            }
            total = decimal.Round(total, 2, MidpointRounding.AwayFromZero);
            return detailPurchases;
        }
        public void GenerateNewList()
        {
            this.cartDetailPurchaseItems = new List<CartDetailPurchaseItem>();
            this.validateCartList = new SortedSet<long>();
            this.total = 0.00m;
        }
    }
    public class CartDetailPurchaseItem
    {
        public string codProduct { get; set; }
        public string description { get; set; }
        public decimal quantity { get; set; }
        public decimal subTotal { get; set; }
        public string purchaseUnit { get; set; }
        public decimal unitPrice { get; set; }
        public long idDetailProduct { get; set; }

        public CartDetailPurchaseItem() { }
        public CartDetailPurchaseItem(Product product , DetailProduct detailProduct, 
                                    decimal quantity = 0m, decimal unitPrice = 0m)
        {
            this.codProduct = product.codProduct;
            this.idDetailProduct = detailProduct.idDetailProduct;
            this.description = string.Concat(product.nameProduct, " / ",
                product.nameBrand, " / ", product.nameProductType, " / ", detailProduct.netContent);
            this.purchaseUnit = detailProduct.saleUnit;
            this.quantity = quantity;
            this.unitPrice = unitPrice;
            this.UpdateSubTotal();
        }
        public DetailPurchase ToDetailPurchase()
        {
            DetailPurchase detailPurchase = new DetailPurchase
            {
                quantity = this.quantity,
                subTotal = this.subTotal,
                unitPrice = this.unitPrice,
                detailProduct = new DetailProduct { idDetailProduct = this.idDetailProduct }
            };

            return detailPurchase;
        }
        public void UpdateSubTotal()
        {
            this.subTotal = decimal.Round(this.quantity * this.unitPrice, 2, MidpointRounding.AwayFromZero);
        }
    }
}
