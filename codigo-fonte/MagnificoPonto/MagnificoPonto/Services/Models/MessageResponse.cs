namespace Correios.Demo.Services.Models
{
    public class MessageResponse
    {
        public string[] msgs { get; set; }

        public string date { get; set; }

        public string method { get; set; }

        public string path { get; set; }

        public string causa { get; set; }

        public string stackTrace { get; set; }
    }
}
