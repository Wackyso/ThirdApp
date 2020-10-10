using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace ThirdApp
{
    class NetService
    {
        const string Url = "";
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async Task<IEnumerable<Dialog>> GetDialogs (request_objs ReqO)
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<IEnumerable<Dialog>>(result);
        }

        public async Task<IEnumerable<Message>> GetMessages(request_objs ReqO)
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<IEnumerable<Message>>(result);
        }

        public async Task<IEnumerable<Dialog>> Get423423432s(request_objs ReqO)
        {
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Url);
            return JsonConvert.DeserializeObject<IEnumerable<Dialog>>(result);
        }
    }

    
}
