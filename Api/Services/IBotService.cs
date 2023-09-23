using System;
using Schemas.WhatsApp;

namespace Api.Services
{
    public interface IBotService
    {
        Task OnReceive(WhatsAppHookSchema hookSchema);
    }
}

