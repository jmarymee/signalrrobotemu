using Microsoft.AspNetCore.SignalR;
using System.Runtime.CompilerServices;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {

            for (var loop = 0; loop < 20; loop++)
            {
                await Clients.All.SendAsync("ReceiveMessage", user, message);
                await Task.Delay(1000);
            }            
        }

        public void CancelMessage()
        {
            return;
        }
    }
}