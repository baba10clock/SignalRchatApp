using Microsoft.AspNetCore.SignalR;

namespace SignalRchatApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task sendMessage(string user, string message)
        {
            Clients.All.SendAsync("ReceiveMessage", user, message);
            
        }
    }
}
