using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Teams.Webhook.Webhooks
{
    public interface IWebhook
    {
        Task PostAsync(MessageCard card);
    }
}