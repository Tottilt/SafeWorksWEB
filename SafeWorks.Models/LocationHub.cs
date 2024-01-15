using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace SafeWorks.Models
{
    public class LocationHub : Hub
    {
        public async Task SendLocation(double latitude, double longitude, string workerName)
        {
            await Clients.All.SendAsync("ReceiveLocation", latitude, longitude, workerName);
        }
    }
}
