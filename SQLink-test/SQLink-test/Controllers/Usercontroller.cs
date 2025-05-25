using SQLink_test.Entity;
using SQLink_test.service;
using SQLink_test.service.Cservice;

namespace SQLink_test.Controllers
{
    public class Usercontroller
    {
        public static void MapUserEndpoints(WebApplication app)
        {
            app.MapGet("/users", async (IUserService userService) => userService.GetAllUsers());
            // .RequireAuthorization(); ;

            app.MapGet("/users/{id}", async (int id, IUserService userService) => userService.GetUserById(id));
            //.RequireAuthorization(); ;

            app.MapPost("/users", async (User user, IUserService userService) => userService.AddUser(user));
            // .RequireAuthorization("Editor", "Admin"); ;

            app.MapPut("/users/{id}", async (int id, User user, IUserService userService) =>
            {
                user.Id = id;
                return userService.UpdataData(user);
            });
            //.RequireAuthorization( "Editor", "Admin" ); ;

            app.MapDelete("/users/{id}", async (int id, IUserService userService) => userService.DeleteUser(id));//.RequireAuthorization( "Editor", "Admin"); ;
        }
    }
}
