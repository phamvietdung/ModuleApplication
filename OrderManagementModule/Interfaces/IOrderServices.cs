namespace OrderManagementModule.Interfaces
{
    public interface IOrderServices
    {
        Task<Guid> GetOrderId();
    }
}
