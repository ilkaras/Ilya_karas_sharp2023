using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LoginTask.Models;

namespace LoginTask.Controllers;

public class HomeController : Controller
{
    private readonly List<User> Users;
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
        Users = new List<User>
        {
            new User { Id = Guid.NewGuid(), Username = "user1", Password = "qwerty", IsAdmin = false },
            new User { Id = Guid.NewGuid(), Username = "user2", Password = "qwerty123", IsAdmin = false },
            new User { Id = Guid.NewGuid(), Username = "admin", Password = "admin", IsAdmin = true }
        };
    }

    [Route("/")]
    public IActionResult Index(string message)
    {
        ViewBag.Error = message;
        return View();
    }

    [Route("/login")]
    public IActionResult CheckUser(User user)
    {
        var checkedUser = Users.FirstOrDefault(x => x.Username == user.Username && x.Password == user.Password);

        if (checkedUser == null)
            return RedirectToAction("Index", new { message = "Incorrect credentials" });
        
        if (checkedUser.IsAdmin)
            return View("Index", (object)"Hello, Admin!");
        
        return View("Index", (object)"You are not an admin");
    }

    public IActionResult Privacy() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error() => View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
}