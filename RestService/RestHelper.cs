using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Entities;
using System.Collections.Generic;

namespace APIRestService
{
    public static class RestService
    {
        private const string urlBase = "http://localhost:8080/api";
        public async static Task<T> MakeGet<T>(string url)
        {
            T obj = default;
            
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var httpResponse = await client.GetAsync(urlBase + url);
                    if (httpResponse.IsSuccessStatusCode)
                    {
                        var content = await httpResponse.Content.ReadAsStringAsync();

                        obj = JsonSerializer.Deserialize<T>(content);
                    }
                    else throw new ApplicationException("Hubo un error.");
                }
            }
            catch(Exception e)
            {
                throw new ApplicationException(e.Message);
            }

            return obj;
        }
        public async static Task<R> MakePost<T, R>(string url, T obj)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var data = JsonSerializer.Serialize<T>(obj);
                    string mediaType = "application/json";
                    HttpContent content = new StringContent(data,
                                                            System.Text.Encoding.UTF8,
                                                            mediaType);
                    var httpResponse = await client.PostAsync(urlBase + url, content);

                    if (httpResponse.IsSuccessStatusCode)
                    {
                        var result = await httpResponse.Content.ReadAsStringAsync();

                        R resultJson = JsonSerializer.Deserialize<R>(result);
                        return resultJson;
                    }
                    else throw new Exception("Error de servidor: " + httpResponse.StatusCode.ToString());
                }
            }
            catch (Exception e)
            {
                throw new ApplicationException(e.Message);
            }
        }
        public async static Task MakePut(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var httpResponse = await client.PutAsync(urlBase + url, null);
                    if (!httpResponse.IsSuccessStatusCode)
                        throw new ApplicationException("Hubo un error.");
                }
            }
            catch (Exception e)
            {
                throw new ApplicationException(e.Message);
            }
        }
        public static void OpenLinkPDF(string url) => System.Diagnostics.Process.Start(urlBase + url);
    }
    public static class BrandService
    {
        private const string urlGetBrands = "/brands";
        public async static Task<List<Brand>> ListAllBrands()
        {
            return await RestService.MakeGet<List<Brand>>(urlGetBrands);
        }
    }
    public static class ProductTypeService
    {
        private const string urlGetProductTypes = "/productTypes";
        public async static Task<List<ProductType>> ListAllProductTypes()
        {
            return await RestService.MakeGet<List<ProductType>>(urlGetProductTypes);
        }
    }
    public static class ProductService
    {
        private const string urlCreateProduct = "/product";
        private const string urlSearchProducts = "/product/search";
        public async static Task<Product> RegisterProduct(Product product)
        {
            Product responseProduct = await RestService.MakePost<Product, Product>(urlCreateProduct, product);
            if (responseProduct == null) throw new ApplicationException("Hubo un error al registrar el producto.");
            return responseProduct;
        }
        public async static Task<Product> FindByIdProduct(string idProduct)
        {
            return await RestService.MakeGet<Product>(urlSearchProducts + "/" + idProduct);
        }
        public async static Task<List<Product>> SearchProducts(string parametros)
        {
            return await RestService.MakeGet<List<Product>>(urlSearchProducts + parametros);
        }
    }
    public static class DetailProductService
    {
        private const string urlDetailProduct = "/detailProduct";
        private const string urlListDPByIdProduct = urlDetailProduct + "/listDP";
        public async static Task<List<DetailProduct>> ListDetailProductByIdProduct(long idProduct)
        {
            return await RestService.MakeGet<List<DetailProduct>>(urlListDPByIdProduct + "/" + idProduct.ToString());
        }
    }
    public static class SaleService
    {
        private const string urlSale = "/sale";
        private const string urlRegisterSale = urlSale;
        private const string urlListSaleByDate = urlSale + "/list";
        private const string urlExportUniqueSaleInPDF = urlSale + "/export";
        private const string urlExportPDFListSalesByDate = urlListSaleByDate + "/export";
        private const string urlCancelSaleByIdSale = urlSale + "/cancel";
        public async static Task<Sale> RegisterSale(Sale sale)
        {
            return await RestService.MakePost<Sale, Sale>(urlRegisterSale, sale);
        }
        public async static Task<List<Sale>> ListSalesByDate(string day = default)
        {
            string url = urlListSaleByDate;
            if (day != default)
                url += ("?day=" + day);
            return await RestService.MakeGet<List<Sale>>(url);
        }
        public static void ExportInPDFDetailSaleLikeCartItemByIdSale(long idSale)
        {
            string url = urlExportUniqueSaleInPDF;
            if (idSale != default)
            {
                url += ("?idSale=" + idSale);
            }
            RestService.OpenLinkPDF(url);
        }
        public static void ExportInPDFListSalesByDate(string day)
        {
            string url = urlExportPDFListSalesByDate;
            if (day != default) url += ("?day=" + day);

            RestService.OpenLinkPDF(url);
        }
        public async static Task<bool> CancelSaleByIdSale(long idSale)
        {
            await RestService.MakePut(urlCancelSaleByIdSale + '/' + idSale.ToString());
            return true;
        }
    }
    public static class DetailSaleService
    {
        private const string urlDetailSale = "/detailSale";
        private const string urlListDetailSaleByIdSale = urlDetailSale + "/listDS";
        public async static Task<List<CartDetailSaleItem>> ListDetailSaleLikeCartItemByIdSale(long idSale)
        {
            return await RestService.MakeGet<List<CartDetailSaleItem>>(urlListDetailSaleByIdSale + "/" + idSale.ToString());
        }
    }

    public static class PurchaseService
    {
        private const string urlPurchase = "/purchase";
        private const string urlRegisterPurchase = urlPurchase;
        private const string urlListPurchases = urlPurchase + "/list";
        public async static Task<Purchase> RegisterPurchase(Purchase purchase)
        {
            return await RestService.MakePost<Purchase, Purchase>(urlRegisterPurchase, purchase);
        }
        public async static Task<List<Purchase>> ListPurchasesByDate(string day = default)
        {
            string url = urlListPurchases;
            if (day != default)
                url += ("?day=" + day);
            return await RestService.MakeGet<List<Purchase>>(url);
        }
    }

    public static class DetailPurchaseService
    {
        private const string urlDetailPurchase = "/detailPurchase";
        private const string urlListDetailPurchaseByIdPurchase = urlDetailPurchase + "/listDPu";
        public async static Task<List<CartDetailPurchaseItem>> ListDetailSaleLikeCartItemByIdSale(long idPurchase)
        {
            return await RestService.MakeGet<List<CartDetailPurchaseItem>>(urlListDetailPurchaseByIdPurchase + "/" + idPurchase.ToString());
        }
    }
}
