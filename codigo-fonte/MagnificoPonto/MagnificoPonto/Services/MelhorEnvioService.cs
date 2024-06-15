
using MagnificoPonto.Models;
using System.Text.RegularExpressions;
using RestSharp;
using Newtonsoft.Json;

namespace MagnificoPonto.Services
{
    public static class MelhorEnvioService
    {
        public static async Task<RestResponse> teste(ProdutoModel produto, string cepDestino)
        {
            var token = "eyJ0eXAiOiJKV1QiLCJhbGciOiJSUzI1NiJ9.eyJhdWQiOiIxIiwianRpIjoiZjBlMjdkMmMzZGQ5OTA3OTI0NjhhMTJhM2FiZDhkOWU3NTFhNDhjNmJkMDgyNDMzYjI5Zjk2OGNhYzRmY2JhYWE0MzE0ZWIzYmU5Mzc0YmEiLCJpYXQiOjE3MTc5Nzk1ODUuNDE5NzUxLCJuYmYiOjE3MTc5Nzk1ODUuNDE5NzUzLCJleHAiOjE3NDk1MTU1ODUuNDA4NDQsInN1YiI6Ijk5NTU1YTU0LTMyZWItNGFiMy04ZDNlLTFjZjg3NDZhMjdiYyIsInNjb3BlcyI6WyJzaGlwcGluZy1jYWxjdWxhdGUiXX0.n1AUHR-0SzDau-aZbEuncYlZkTdz_Z_XOAJa29m5n-1T3sAJHARPn-XZiOFY2FgWAuZJRKmRBM-mlsoz2Kzvy9Mia77BjbbbiaHX2DbnLHXuPPrOmIwrlbCbkJR4jJF3yLufdECNO6Hoku5a92IPJlxaCgo1sfHLmDI5l2yZusVWv61fwrzKb-sTFk2HHz6x7MbQpbEnz5-2rUD5AjqblLgBc6fwJ6XAwleydt4kkvBVsFdUddWBtX0YtT-29GCjdtFq8RAA1NO9ACvh5TRm2AYvMpauOjLtldhBInx4LaCebhDJeQG8WHeqE2XW6ZzDvpymUGQR8Jp7hy7A3rP2OghwBDgR3YJmVBophYaoKBZVUI_zkj_40S-cWLqio4cJ9goBvS1v_v6NSKlrhJxTeQlbeXHDtkqQOSLsE71mQIVMUSRnn0obN1CgmvtAD5A67lyQMyTtDdVRsUr7S5sbfCYICRzwuLUyuHG7Y1EVCs47llaszkzH3pgHETbMKfkc7t2R-ka5wxLrrw2VkQX9GX9KWAq6SxPddLqpZ25-ltM9Iu0iZ3DsSAGHBvqLUDLuO6WWySe3TcdJWA-9kos4EujBQ8_ETHgLVMG_tOynGgCs9QK4iV5sEaMROrwo1JqtGPup2mwc5P3Li1vxh2mQyc5_QLO78cQNocFbT5o9bh0";

            var options = new RestClientOptions("https://melhorenvio.com.br/api/v2/me/shipment/calculate");
            var client = new RestClient(options);
            var request = new RestRequest("");
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {token}");
            request.AddHeader("User-Agent", "Aplicação (email para contato técnico)");
            request.AddJsonBody($"{{\"from\":{{\"postal_code\":\"30120080\"}},\"to\":{{\"postal_code\":\"{cepDestino}\"}},\"package\":{{\"height\":{produto.Tamanho},\"width\":3,\"length\":3,\"weight\":{produto.Peso}}}}}", false);
            var response = await client.PostAsync(request);

            return response;

        }

    }
}
