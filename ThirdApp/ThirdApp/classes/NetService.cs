using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Linq;


namespace ThirdApp
{
    class NetService
    {
        const string Acc = "http://192.168.1.7:57755/api/account";
        const string Dia = "http://192.168.1.7:57755/api/dialof";
        const string Mes = "http://192.168.1.7:57755/api/message";
        private HttpClient GetClient()
        {
            HttpClient client = new HttpClient();
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            return client;
        }

        public async Task<IEnumerable<Dialog>> GetDialogs (request_objs ReqO)
        {
            string a = "/" + ReqO.login + "=" + ReqO.password;
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Dia+ a);
            return JsonConvert.DeserializeObject<IEnumerable<Dialog>>(result);
        }

        public async Task<IEnumerable<Message>> GetMessages(request_objs ReqO)
        {
            string a = "/" + ReqO.login + "=" + ReqO.password + "=" + ReqO.dialog_id;
            HttpClient client = GetClient();
            string result = await client.GetStringAsync(Mes +a);
            return JsonConvert.DeserializeObject<IEnumerable<Message>>(result);
        }

        public async void AddDialog(request_objs req, string login)
        {
            request_crd ReqO = new request_crd();

            
            ReqO.login = req.login;
            ReqO.password = req.password;
            ReqO.interlocutor = login;

            HttpClient client = GetClient();
            var result = await client.PostAsync(Dia,
                new StringContent(
                    JsonConvert.SerializeObject(ReqO),
                    Encoding.UTF8, "application/json"));
        }

        public async void AddMessage(request_objs req, DateTime time)
        {
            request_mes ReqO = new request_mes();

            ReqO.dialog_id = req.dialog_id;
            ReqO.login = req.login;
            ReqO.password = req.password;
            ReqO.text = req.message;
            ReqO.send_time = time;

            HttpClient client = GetClient();

            var result = await client.PostAsync(Mes,
                new StringContent(
                    JsonConvert.SerializeObject(ReqO),
                    Encoding.UTF8, "application/json"));
        }

        public async void CreateAcc(request_objs req)
        {
            request_cra ReqO = new request_cra();

            
            ReqO.login = req.login;
            ReqO.password = req.password;
            

            HttpClient client = GetClient();
            var response = await client.PostAsync(Acc,
                new StringContent(
                    JsonConvert.SerializeObject(ReqO),
                    Encoding.UTF8, "application/json"));
        }
    }

    
}
