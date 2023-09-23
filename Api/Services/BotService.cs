using System;
using Schemas.WhatsApp;

namespace Api.Services
{
	public class BotService:IBotService
	{
		public BotService()
		{
		}

        public Task OnReceive(WhatsAppHookSchema hookSchema)
        {
            throw new NotImplementedException();
        }
    }
}

