using OrderManagementModule.Interfaces;

namespace OrderManagementModule.Servies
{
    public class OrderServices : IOrderServices
    {
        public async Task<Guid> GetOrderId()
        {
            return await Task.FromResult(Guid.NewGuid());
        }
    }
}
