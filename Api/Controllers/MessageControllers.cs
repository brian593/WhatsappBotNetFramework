using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Net;
using System.Xml.Linq;
using Api.Services;
using Schemas.WhatsApp;
using System.Net.Http.Headers;

namespace Api.Controllers
{
    public class MessageControllers : Controller
    {
        private readonly IBotService _botService;
        private readonly Settings _settings;

        public MessageControllers(IOptions<Settings> settings, IBotService botService)
        {
            _botService = botService;
            _settings = settings.Value;
        }
        [HttpGet]
        [Route("webhook")]
        public string Webhook([FromQuery(Name = "hub.mode")] string mode, [FromQuery(Name = "hub.challenge")] string challenge, [FromQuery(Name = "hub.verify_token")] string verifyToken)
        {
            return verifyToken.Equals(_settings.VerifyToken) ? challenge : String.Empty;
        }


        [HttpPost]
        [Route("webhook")]
        public async Task<HttpResponseMessage> OnReceive([FromBody] WhatsAppHookSchema hookSchema)
        {
            await _botService.OnReceive(hookSchema);
            var response = new HttpResponseMessage(HttpStatusCode.OK);
            response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
            return response;
        }
    }

}

