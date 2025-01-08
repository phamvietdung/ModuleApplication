using UserManagementModule.Interfaces;

namespace UserManagementModule.Services
{
    public class UserServices : IUserServices
    {
        public async Task<Guid> GetUserId()
        {
            return Guid.NewGuid();
        }

        public async Task<bool> CreateUser()
        {
            return true;
        }

        public async Task<bool> DeleteUser()
        {
            return true;
        }
    }
}
