using DataAccess.Models;

namespace DataAccess.Data
{
    public interface IUserData
    {
        Task DeleteUser(int ID);
        Task<UserModel?> GetIdByName(UserModel user);
        Task<UserModel?> GetPasswordByIndex(int index);
        Task<UserModel?> GetUser(int ID);
        Task<IEnumerable<UserModel>> GetUsers();
        Task InsertUser(UserModel user);
        Task UpdateUser(UserModel user);
    }
}