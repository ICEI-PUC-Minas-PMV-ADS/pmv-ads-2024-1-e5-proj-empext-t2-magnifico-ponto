namespace MagnificoPonto.Services.Models
{
    public class DeliveryRange
    {
        public int min { get; set; }
        public int max { get; set; }
    }

    public class Product
    {
        public string id { get; set; }
        public int quantity { get; set; }
    }

    public class Dimensions
    {
        public int height { get; set; }
        public int width { get; set; }
        public int length { get; set; }
    }

    public class Package
    {
        public string price { get; set; }
        public string discount { get; set; }
        public string format { get; set; }
        public string weight { get; set; }
        public string insurance_value { get; set; }
        public List<Product> products { get; set; }
        public Dimensions dimensions { get; set; }
    }

    public class AdditionalServices
    {
        public bool receipt { get; set; }
        public bool own_hand { get; set; }
        public bool collect { get; set; }
    }

    public class Company
    {
        public int id { get; set; }
        public string name { get; set; }
        public string picture { get; set; }
    }

    public class MelhorEnvioResponse
    {
        public int id { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string custom_price { get; set; }
        public string discount { get; set; }
        public string currency { get; set; }
        public int delivery_time { get; set; }
        public DeliveryRange delivery_range { get; set; }
        public int custom_delivery_time { get; set; }
        public DeliveryRange custom_delivery_range { get; set; }
        public List<Package> packages { get; set; }
        public AdditionalServices additional_services { get; set; }
        public Company company { get; set; }
        public string error { get; set; }
    }
}
