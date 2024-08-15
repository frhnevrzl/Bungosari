using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Net.Http.Headers;

namespace technical_test_bungasari.Services
{
    public class ConsumeApiServices
    {
        private readonly HttpClient _httpClient;
        private readonly string _serviceName;
        public ConsumeApiServices(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _serviceName = configuration["ApiSettings:ServicesUrl"];
        }

        public async Task<Root> GetApiData()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage(HttpMethod.Get, _serviceName);
            var content = new StringContent("{}");
            content.Headers.ContentType = new MediaTypeWithQualityHeaderValue("application/json");

            request.Content = content;

            var response = await client.SendAsync(request);

            if (response.IsSuccessStatusCode)
            {
                var contentBody = await response.Content.ReadAsStringAsync();
                var data = JsonConvert.DeserializeObject<Root>(contentBody);
                return data;
            }
            return new Root();
        }
    }

    public class D
    {
        public List<Result> results { get; set; }
    }

    public class Metadata
    {
        public string id { get; set; }
        public string uri { get; set; }
        public string type { get; set; }
    }

    public class NAVDOHDR
    {
        public List<Result> results { get; set; }
    }

    public class NAVDOITM
    {
        public List<Result> results { get; set; }
    }

    public class NAVSHHDR
    {
        public List<Result> results { get; set; }
    }

    public class Result
    {
        public Metadata __metadata { get; set; }
        public string DatFr { get; set; }
        public string DatTo { get; set; }
        public string TimFr { get; set; }
        public string TimTo { get; set; }
        public string Vstel { get; set; }
        public NAVSHHDR NAVSHHDR { get; set; }
        public NAVDOHDR NAVDOHDR { get; set; }
        public NAVDOITM NAVDOITM { get; set; }
        public string Mandt { get; set; }
        public string Tknum { get; set; }
        public string Tpnum { get; set; }
        public string Vbeln { get; set; }
        public string Exti1 { get; set; }
        public string Exti2 { get; set; }
        public DateTime Udate { get; set; }
        public string Utime { get; set; }
        public string ShType { get; set; }
        public string FwAgen { get; set; }
        public string ShRout { get; set; }
        public string ContNo { get; set; }
        public string CreateBy { get; set; }
        public DateTime CreateOn { get; set; }
        public string CreateAt { get; set; }
        public string ChangeBy { get; set; }
        public DateTime ChangeOn { get; set; }
        public string ChangeAt { get; set; }
        public string Kunag { get; set; }
        public string Name1 { get; set; }
        public string Name2 { get; set; }
        public string Name3 { get; set; }
        public string Name4 { get; set; }
        public string Avgzk { get; set; }
        public string Avgps { get; set; }
        public DateTime Lddat { get; set; }
        public DateTime WadatIst { get; set; }
        public string Wbstk { get; set; }
        public string Vhilm { get; set; }
        public string Lfart { get; set; }
        public string Cmgst { get; set; }
        public string Donote { get; set; }
        public string Posnr { get; set; }
        public string Matnr { get; set; }
        public string Arktx { get; set; }
        public string Pfimg { get; set; }
        public string Lfimg { get; set; }
        public string Vrkme { get; set; }
        public string Werks { get; set; }
    }

    public class Root
    {
        public D d { get; set; }
    }
}
