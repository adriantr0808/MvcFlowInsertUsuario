using MvcFlowInsertUsuario.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace MvcFlowInsertUsuario.Service
{
    public class ServiceLogicApp
    {
        private MediaTypeWithQualityHeaderValue Header;
        public ServiceLogicApp()
        {
            this.Header = new MediaTypeWithQualityHeaderValue("application/json");
        }
        public async Task InsertUsuarioAsync(Usuario user)
        {
            string urlFlowInsert =
             "https://prod-178.westeurope.logic.azure.com:443/workflows/b362092ea9624e54b36dc5216d29d94c/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=t5R1VJJ9s3NJfGnOPjJJ_zJw-Nqd7TFvp9_k2ha4ySk";

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(this.Header);
                string json = JsonConvert.SerializeObject(user);
                StringContent content =
                    new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response =
                    await client.PostAsync(urlFlowInsert, content);
            }

        }


    }
}
