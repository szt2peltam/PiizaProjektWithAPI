using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data;

public class UserData : IUserData
{
    private readonly ISqlDataAccess _db;

    public UserData(ISqlDataAccess db)
    {
        _db = db;

    }

    public Task<IEnumerable<UserModel>> GetUsers() =>
        _db.LoadData<UserModel, dynamic>("dbo.spUser_GetAll", new { });


    public async Task<UserModel?> GetUser(int ID)
    {
        var results = await _db.LoadData<UserModel, dynamic>(
            "dbo.spUser_Get",
            new { Id = ID });

        return results.FirstOrDefault();
    }

    public Task InsertUser(UserModel user) =>
        _db.SaveData("dbo.spUser_Insert", new { user.Name, user.Password });


    public Task UpdateUser(UserModel user) =>
        _db.SaveData("dbo.spUser_Update", user);

    public Task DeleteUser(int ID) =>
        _db.SaveData("dbo.spUser_Delete", new { Id = ID });

    public async Task<UserModel?> GetIdByName(string name)
    {
        var results = await _db.LoadData<UserModel, dynamic>(
            "dbo.spUser_GetIndexByName", new { Name = name }
            );

        return results.FirstOrDefault();
    }

    public async Task<UserModel?> GetPasswordByIndex(int index)
    {
        var results = await _db.LoadData<UserModel, dynamic>(
            "dbo.spUser_GetPasswordFromIndex", new { Id = index });

        return results.FirstOrDefault();
    }





}
