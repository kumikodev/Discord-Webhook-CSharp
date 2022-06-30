using System;
using Discord.Tools.Api.Web;

namespace Discord
{
    class Program
    {
        static void Main(string[] args)
        {

            string WebhookUrl = args[0];
            string Message = args[1];

            /*
            To send mentions, use this:
            <@!UserID>
            */

           WebhookManager.SendWebhook(WebhookUrl, Message);
        }
    }
}
