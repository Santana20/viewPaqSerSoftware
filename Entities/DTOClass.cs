using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Cart
    {
        //private List<CartItem> cartItems;

        private Dictionary<long, CartItem> CartItems;
        public decimal total { get; set; }

        public Cart()
        {
            //this.cartItems = new List<CartItem>();
            this.CartItems = new Dictionary<long, CartItem>();
            total = 0m;
        }

        public List<CartItem> getCartList()
        {
            return new List<CartItem>(this.CartItems.Values);
        }
        public void AddCartItem(CartItem cartItem)
        {
            //this.cartItems.Add(cartItem);
            this.CartItems.Add(cartItem.idDetailProduct, cartItem);
            total += cartItem.subTotal;
        }
        public void UpdateSaleCountByIndex(long key, decimal saleCount)
        {
            // this.cartItems[index].saleCount = saleCount;
            CartItem value;
            if (this.CartItems.TryGetValue(key, out value))
            {
                value.saleCount = saleCount;

                total -= value.subTotal;
                value.UpdateSubTotal();
                total += value.subTotal;
            }

            // total -= this.cartItems[index].subTotal;
            // this.cartItems[index].UpdateSubTotal();
            // total += this.cartItems[index].subTotal;
        }
        public void DeleteCartItem(long key)
        {
            CartItem value;
            if (this.CartItems.TryGetValue(key, out value))
            {
                total -= value.subTotal;
                this.CartItems.Remove(key);
            }
            // total -= this.cartItems[index].subTotal;
            // this.cartItems.RemoveAt(index);
        }
        public List<DetailSale> ToDetailSaleList()
        {
            decimal lastTotal = total;
            List<DetailSale> detailSales = new List<DetailSale>();
            foreach (KeyValuePair<long, CartItem> pair in this.CartItems)
            {
                detailSales.Add(pair.Value.ToDetailSale());
                total += pair.Value.subTotal;
            }
            return detailSales;
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
