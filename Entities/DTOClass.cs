using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Cart
    {
        private List<CartItem> cartItems;
        public decimal total { get; set; }

        public Cart()
        {
            this.cartItems = new List<CartItem>();
            total = 0m;
        }
        public void AddCartItem(CartItem cartItem)
        {
            this.cartItems.Add(cartItem);
            total += cartItem.subTotal;
        }
        public void UpdateSaleCountByIndex(int index, decimal saleCount)
        {
            this.cartItems[index].saleCount = saleCount;

            total -= this.cartItems[index].subTotal;
            this.cartItems[index].UpdateSubTotal();
            total += this.cartItems[index].subTotal;
        }
        public void DeleteCartItem(int index)
        {
            total -= this.cartItems[index].subTotal;
            this.cartItems.RemoveAt(index);
        }
        public List<DetailSale> ToDetailSaleList()
        {
            decimal lastTotal = total;
            List<DetailSale> detailSales = new List<DetailSale>();
            foreach (CartItem cartItem in this.cartItems)
            {
                detailSales.Add(cartItem.ToDetailSale());
                total += cartItem.subTotal;
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
        private long idDetailProduct;
        public CartItem() { }
        public CartItem(Product product, DetailProduct detailProduct,
            decimal saleCount)
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
