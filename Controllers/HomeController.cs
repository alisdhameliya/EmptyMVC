using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using EmptyMVC.Models;
namespace EmptyMVC.Controllers;

public class HomeController : Controller
{
    // private readonly IUserInterface _userRepo;

    // public HomeController(IUserInterface userRepo)
    // {
    //     _userRepo = userRepo;
    // }
    // public async Task<IActionResult> GetAllUsers()
    // {
    //     var users = await _userRepo.getAllUsers();
    //     if (users == null)
    //     {
    //         return Json(new { success = false, message = "No users found", data = new List<User>() });
    //     }
    //     return Json(new { success = true, message = "all users retrieved successfully", data = users });
    // }

    // [HttpPost]
    // public async Task<IActionResult> AddUser(User user)
    // {
    //     if (user.UserImage != null)
    //     {
    //         System.Console.WriteLine("UserImage is not null");
    //         if (user.UserImage != null && user.UserImage.Length > 0)
    //         {
    //             System.Console.WriteLine("UserImage has a file");
    //             var fileName = user.name + Path.GetExtension(user.UserImage.FileName);
    //             var filePath = Path.Combine("./wwwroot/photos", fileName);
    //             Directory.CreateDirectory(Path.Combine("./wwwroot/photos"));
    //             user.image = fileName;
    //             using (var stream = new FileStream(filePath, FileMode.Create))
    //             {
    //                 user.UserImage.CopyTo(stream);
    //             }
    //             System.Console.WriteLine("UserImage file saved");
    //         }
    //     }
    //     if (user.UserFile != null)
    //     {
    //         System.Console.WriteLine("UserFile is not null");
    //         if (user.UserFile != null && user.UserFile.Length > 0)
    //         {
    //             System.Console.WriteLine("UserFile has a file");
    //             var fileName = user.name + Path.GetExtension(user.UserFile.FileName);
    //             var filePath = Path.Combine("./wwwroot/files", fileName);
    //             Directory.CreateDirectory(Path.Combine("./wwwroot/files"));
    //             user.file = fileName;
    //             using (var stream = new FileStream(filePath, FileMode.Create))
    //             {
    //                 user.UserFile.CopyTo(stream);
    //             }
    //         }
    //     }

    //     if (user.id == 0)
    //     {

    //         System.Console.WriteLine("Model is valid");
    //         int status = await _userRepo.addUser(user);
    //         if (status > 0)
    //         {
    //             return Ok(new { success = true, message = "added sucessfully" });
    //         }
    //         return Ok(new { success = false, message = "failed to add user" });
    //     }
    //     else
    //     {
    //         int status = await _userRepo.updateUser(user);
    //         if (status > 0)
    //         {
    //             return Ok(new { success = true, message = "updated sucessfully" });
    //         }
    //         return Ok(new { success = false, message = "failed to update user" });
    //     }

    // }
    // [HttpDelete]
    // public async Task<IActionResult> DeleteUser(int id)
    // {
    //     if (id <= 0)
    //     {
    //         return Json(new { success = false, message = "Invalid user ID" });
    //     }

    //     int status = await _userRepo.deleteUser(id);
    //     if (status > 0)
    //     {
    //         return Json(new { success = true, message = "User deleted successfully" });
    //     }
    //     return Json(new { success = false, message = "Failed to delete user" });
    // }
    // [HttpGet]
    // public async Task<IActionResult> GetUserById(int id)
    // {
    //     if (id <= 0)
    //     {
    //         return Json(new { success = false, message = "Invalid user ID" });
    //     }

    //     var user = await _userRepo.getUserById(id);
    //     if (user == null)
    //     {
    //         return Json(new { success = false, message = "User not found" });
    //     }
    //     return Json(new { success = true, message = "User retrieved successfully", data = user });
    // }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
