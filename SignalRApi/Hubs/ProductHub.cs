using Microsoft.AspNetCore.SignalR;
using SignalRApi.Models;
using System.Threading.Tasks;

namespace SignalRApi.Hubs
{
    public class ProductHub:Hub<IProductHub>
    {
        public async Task SendProduct(Product product)
        {
            await Clients.All.ReceiveProduct(product);
        }
    }
}
