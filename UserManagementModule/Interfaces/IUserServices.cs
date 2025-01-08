namespace UserManagementModule.Interfaces
{
    public interface IUserServices
    {
        Task<bool> CreateUser();
        Task<bool> DeleteUser();
        Task<Guid> GetUserId();
    }
}