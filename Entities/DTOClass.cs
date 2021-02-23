using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Cart
    {
        private List<CartItem> cartItems;
        private SortedSet<long> validateList;
        public decimal total { get; set; }
        public Cart()
        {
            this.cartItems = new List<CartItem>();
            this.validateList = new SortedSet<long>();
            total = 0m;
        }
        public int getCount() { return this.cartItems.Count; }
        public List<CartItem> getList() { return this.cartItems; }
        public void AddCartItem(CartItem cartItem)
        {
            if (this.validateList.Add(cartItem.idDetailProduct))
            {
                this.cartItems.Add(cartItem);
                total += cartItem.subTotal;
            }
            else throw new Exception("El producto ya se encuentra en el carrito");
        }
        public void UpdateSaleCountByIndex(int index, decimal saleCount)
        {
            this.cartItems[index].saleCount = saleCount;
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
        public CartItem GetByIndex(int index)
        {
            return this.cartItems[index];
        }
        public List<DetailSale> ToDetailSaleList()
        {
            total = 0;
            List<DetailSale> detailSales = new List<DetailSale>();
            foreach(CartItem value in this.cartItems)
            {
                detailSales.Add(value.ToDetailSale());
                total += value.subTotal;
            }
            return detailSales;
        }
        public void GenerateNewList()
        {
            this.cartItems = new List<CartItem>();
            this.validateList = new SortedSet<long>();
        }
    }
    public class CartItem
    {
        public string idProduct { get; set; }
        public string description { get; set; }
        public decimal priceUnit { get; set; }
        public decimal saleCount { get; set; }
        public decimal subTotal { get; set; }
        public long idDetailProduct { get; set; }
        public decimal Stock { get; }
        public CartItem() { }
        public CartItem(Product product, DetailProduct detailProduct,
            decimal saleCount = 0m)
        {
            this.idProduct = product.idProduct;
            this.idDetailProduct = detailProduct.idDetailProduct;
            this.description = string.Concat(
                product.nameProduct, " / ", product.idBrand,
                " / ", product.idProductType, ".");
            this.priceUnit = detailProduct.salePrice;
            this.saleCount = saleCount;
            this.Stock = detailProduct.stock;
            this.UpdateSubTotal();
        }
        public DetailSale ToDetailSale()
        {
            DetailSale detailSale = new DetailSale()
            {
                saleCount = this.saleCount,
                subTotal = this.subTotal,
                idDetailProduct = this.idDetailProduct
            };
            return detailSale;
        }
        public void UpdateSubTotal()
        {
            this.subTotal = this.priceUnit * this.saleCount;
        }
    }
}
