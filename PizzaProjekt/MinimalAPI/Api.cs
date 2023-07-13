
using DataAccess.Data;
using DataAccess.Models;
namespace MinimalAPI;

public static class Api
{
    /// <summary>
    /// Creates the API endpoints
    /// </summary>
    /// <param name="app"></param>
     public static void ConfigureApi(this WebApplication app)
    {
        // Mapping endpoints

        app.MapGet("/Users", GetUsers);
        app.MapGet("/Order", GetPizzas);
        app.MapGet("/Users/{id}", GetUser);
        app.MapGet("/Order/{id}", GetPizza);
        app.MapPost("/Users", InsertUser);
        app.MapPost("/Order", InsertOrder);
        app.MapGet("/Password/{id}", GetPasswordFromId);
        app.MapGet("/Name/{name}", GetIdFromName);
        app.MapPut("/Users", UpdateUser);
        app.MapDelete("/Users", DeleteUser);
        app.MapDelete("/Order", DeletePizza);


    }

    private static async Task<IResult> GetUsers(IUserData data)
    {
        try
        {
            return Results.Ok(await data.GetUsers());
        }
        catch (Exception ec)
        {

            return Results.Problem(ec.Message);
        }
    }
    private static async Task<IResult> GetPizzas(IPizzaData data)
    {
        try
        {
            return Results.Ok(await data.GetPizzas());
        }
        catch (Exception ec)
        {

            return Results.Problem(ec.Message);
        }
    }

    private static async Task<IResult> GetUser(int id, IUserData data)
    {
        try
        {

            var results = await data.GetUser(id);
            if(results == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(results);
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message); ;
        }
    }
    private static async Task<IResult> GetPizza(int id, IPizzaData data)
    {
        try
        {

            var results = await data.GetPizza(id);
            if(results == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(results);
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message); ;
        }
    }
    private static async Task<IResult> InsertUser(LoginModel user, IUserData data)
    {
        try
        {

            await data.InsertUser(user);
            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message); ;
        }
    }

    private static async Task<IResult> InsertOrder(OrderPizzaModel Order, IPizzaData data)
    {
        try
        {

            await data.InsertOrder(Order);
            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message); ;
        }
    }

    private static async Task<IResult> UpdateUser(UserModel user, IUserData data)
    {

        try
        {
            await data.UpdateUser(user);
            return Results.Ok();

        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);

        }
    }

    private static async Task<IResult> DeleteUser(int id, IUserData data)
    {
        try
        {
            await data.DeleteUser(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> DeletePizza(int id, IPizzaData data)
    {
        try
        {
            await data.DeleteOrder(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetPasswordFromId(int id, IUserData data)
    {
        try
        {
            var results = await data.GetPasswordByIndex(id);
            if(results == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(results);
        }
        catch(Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> GetIdFromName(string name, IUserData data)
    {
        try
        {
            var results = await data.GetIdByName(name);

            if(results == null)
            {
                return Results.NotFound();
            }
            return Results.Ok(results);
        }
        catch (Exception ex)
        {

            return Results.Problem(ex.Message);
        }
    }
}
