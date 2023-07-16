using SignalRApi.Models;
using System.Threading.Tasks;

namespace SignalRApi.Hubs
{
    public interface IProductHub
    {
        Task ReceiveProduct(Product product);
    }
}
