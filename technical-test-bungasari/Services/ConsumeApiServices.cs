using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using Microsoft.AspNetCore.Http;
using System.Text;
using System.Text.Json.Serialization;

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
            //_httpClient.DefaultRequestHeaders.Accept.Clear();
            ////_httpClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            //_httpClient.DefaultRequestHeaders.Add("Content-Type", "application/json");

            //var response = await _httpClient.GetAsync(_serviceName);

            var requests = new RestRequest("GET");
            requests.AddHeader("Content-Type", "application/json");
            var client = new RestClient(_serviceName);
            var response = client.Execute(requests);

            //if (response.IsSuccessStatusCode)
            //{
            //    //var content = await response.Content.ReadAsStringAsync();
            //    var data = JsonConvert.DeserializeObject<Root>(content);
            //    return data;
            //}
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
