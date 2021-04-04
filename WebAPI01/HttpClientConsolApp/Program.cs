using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HttpClientConsolApp
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static async Task GetProductById()
        {
            using (var Client = new HttpClient())
            {
                Client.BaseAddress = new Uri("https://localhost:44308/");
                Client.DefaultRequestHeaders.Accept.Clear();
                Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //GET Method Using Id
                HttpResponseMessage response = await Client.GetAsync("api/Product/1");

                if (response.IsSuccessStatusCode)
                {
                    Product product = await response.Content.ReadAsAsync<Product>();
                    Console.WriteLine("ID: {0}", product.ID);
                    Console.WriteLine("Name: {0}", product.Name);
                    Console.WriteLine("Quantity: {0}", product.QtyInStock);
                    Console.WriteLine("Description: {0}", product.Description);
                    Console.WriteLine("Supplier: {0}", product.Supplier);
                }
                else
                {
                    Console.WriteLine("Internal server error !");
                }
            }
        }

        static async Task GetProducts()
        {
            using (var client = new HttpClient())
            {
                //Send HTTP requests from here. 
                client.BaseAddress = new Uri("https://localhost:44308/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                //GET Method  
                HttpResponseMessage response = await client.GetAsync("api/Product/");
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = response.Content.ReadAsStringAsync();
                    jsonString.Wait();
                    var products = JsonConvert.DeserializeObject<List<Product>>(jsonString.Result);

                    foreach (var product in products)
                    {
                        Console.WriteLine("ID: {0}", product.ID);
                        Console.WriteLine("Name: {0}", product.Name);
                        Console.WriteLine("Quantity: {0}", product.QtyInStock);
                        Console.WriteLine("Description: {0}", product.Description);
                        Console.WriteLine("Supplier: {0}", product.Supplier);
                    }
                }
                else
                {
                    Console.WriteLine(response.ReasonPhrase);
                    Console.WriteLine("Internal server Error");
                }

            }

        }

        static async Task Post()
        {
            using (var client = new HttpClient())
            {
                //Send HTTP requests from here. 
                client.BaseAddress = new Uri("https://localhost:44308/");

                var product = new Product() { ID = 1, Name = "Test Product", QtyInStock = 10, Description = "Testing", Supplier = "Manoj Kumar" };
                HttpResponseMessage response = await client.PostAsJsonAsync("api/Product", product);

                if (response.IsSuccessStatusCode)
                {
                    // Get the URI of the created resource.  
                    Uri returnUrl = response.Headers.Location;
                    Console.WriteLine(returnUrl);
                }
            }
        }

        static async Task Put()
        {

            using (var client = new HttpClient())
            {
                //Send HTTP requests from here. 
                client.BaseAddress = new Uri("https://localhost:44308/");

                //PUT Method  
                var product = new Product() { ID = 9, Name = "Updated Product", QtyInStock = 100, Description = "Updated testing", Supplier = "Manju" };
                int id = 1;
                HttpResponseMessage response = await client.PutAsJsonAsync("api/Product/" + id, product);
                if (response.IsSuccessStatusCode)

                {
                    Console.WriteLine("Success");
                }
            }
        }

        static async Task Delete()
        {
            using (var client = new HttpClient())
            {
                //Send HTTP requests from here.
                client.BaseAddress = new Uri("https://localhost:44308/");

                int id = 1;
                HttpResponseMessage response = await client.DeleteAsync("api/Product/" + id);
                if (response.IsSuccessStatusCode)
                {
                    Console.WriteLine("Success");
                }
            }
        }
    }
}
