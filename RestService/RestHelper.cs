using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Entities;
using System.Collections.Generic;

namespace RestService
{
    /*
    public class RestHelper
    {
        private const string baseUrl = "http://localhost:8080/api";
        private const string createProductUrl = "/product";
        public Product createProduct(Product product)
        {
            string productRequest = serializeObject(product);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(baseUrl + createProductUrl);

            request.Method = "POST";

            if (productRequest != string.Empty)
            {
                request.ContentType = "application/json";
                using (StreamWriter swJsonPayload = new StreamWriter(request.GetRequestStream()))
                {
                    swJsonPayload.Write(productRequest);
                    swJsonPayload.Close();
                }
            }

            Product productResponse = null;
            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            productResponse = JsonConvert.DeserializeObject<Product>(reader.ReadToEnd());
                        }
                    }
                }
            }
            catch (Exception e)
            {
                throw new ApplicationException(e.Message);
            }
            return productResponse;
        }


        private string serializeObject(Object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

    }
    */
    public static class Rest
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
                }
            }
            catch (Exception e)
            {
                throw new ApplicationException(e.Message);
            }


            return default;
        }
    }
    public static class BrandService
    {
        private const string urlGetBrands = "/brands";
        public async static Task<List<Brand>> ListAllBrands()
        {
            return await Rest.MakeGet<List<Brand>>(urlGetBrands);
        }
    }
    public static class ProductTypeService
    {
        private const string urlGetProductTypes = "/productTypes";
        public async static Task<List<ProductType>> ListAllProductTypes()
        {
            return await Rest.MakeGet<List<ProductType>>(urlGetProductTypes);
        }
    }
    public static class ProductService
    {
        private const string urlCreateProduct = "/product";
        private const string urlSearchProducts = "/product/search";
        public async static Task<Product> RegisterProduct(Product product)
        {
            Product responseProduct = await Rest.MakePost<Product, Product>(urlCreateProduct, product);
            if (responseProduct == null) throw new ApplicationException("Hubo un error al registrar el producto.");
            return responseProduct;
        }
        public async static Task<Product> FindByIdProduct(string idProduct)
        {
            return await Rest.MakeGet<Product>(urlSearchProducts + "/" + idProduct);
        }
        public async static Task<List<Product>> SearchProducts(string parametros)
        {
            return await Rest.MakeGet<List<Product>>(urlSearchProducts + parametros);
        }
    }

    public static class SaleService
    {
        private const string urlRegisterSale = "/sale";
        public async static Task<Sale> RegisterSale(Sale sale)
        {
            return await Rest.MakePost<Sale, Sale>(urlRegisterSale, sale);
        }
    }
}
