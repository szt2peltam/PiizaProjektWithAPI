﻿
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
        app.MapGet("/Users/{id}", GetUser);
        app.MapPost("/Users", InsertUser);
        app.MapGet("/Password/{id}", GetPasswordFromId);
        app.MapGet("/Name/{name}", GetIdFromName);
        app.MapPut("/Users", UpdateUser);
        app.MapDelete("/Users", DeleteUser);


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
    private static async Task<IResult> InsertUser(UserModel user, IUserData data)
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
