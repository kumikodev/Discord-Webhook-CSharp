using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;




namespace Discord.Tools.Api.Web{
    class WebhookManager
    {
       public static void SendWebhook(string webhookUrl, string Message)
       {
            using (var client = new HttpClient())
            {
                var values = new Dictionary<string, string>
                {
                    { "content", Message }
                };

                var content = new FormUrlEncodedContent(values);

                var response = client.PostAsync(webhookUrl, content).Result;


                Console.WriteLine(response);
            }
       } 
    }
}