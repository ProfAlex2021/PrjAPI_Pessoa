using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PrjAPI_Pessoa
{
    public class API
    {
        static string url = "http://3tdsn2021.atwebpages.com/api/pessoa/";
        static HttpClient rest;
        public async static Task<List<Pessoa>> MetodoGET()
        {
            List<Pessoa> lista = new List<Pessoa>();
            rest = new HttpClient();
            var resposta = await rest.GetAsync(url);
            if (resposta.IsSuccessStatusCode)
            {
                var dados = Encoding.UTF8.GetString(await resposta.Content.ReadAsByteArrayAsync());
                lista = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Pessoa>>(dados);
            }
            return lista;
        }
    }
}
