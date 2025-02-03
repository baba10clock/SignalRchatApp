using Microsoft.AspNetCore.SignalR;

namespace SignalRchatApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task sendMessage(string message, string user)
        {
            Clients.All.SendAsync("Reecive Message", user, message);
            
        }
    }
}
