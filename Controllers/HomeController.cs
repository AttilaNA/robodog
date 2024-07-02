using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using robodog.Models;

namespace robodog.Controllers;

public class HomeController : Controller
{
    private readonly DogStorage _dogStorage;

    public HomeController(DogStorage dogStorage)
    {
        _dogStorage = dogStorage;
    }

    public IActionResult Index()
    {
        return View(_dogStorage.Dogs);
    }

    public IActionResult AddDogManually([FromQuery] string name, int age, string breed)
    {
        if (name is not null)
        {
            _dogStorage.AddDogFromUserInput(name, age, breed);
            return RedirectToAction(nameof(Index), "Home");
        }
        ViewData["Breeds"] = DogCreator.Breeds;
        return View(_dogStorage.Dogs);
    }

    public IActionResult EditDog(string action, [FromQuery] string name, int age, string breed)
    {
        ViewData["Breeds"] = DogCreator.Breeds;
        ViewBag.DogEdited = new Dog
        {
            Name = name,
            Age = age,
            Breed = new Breed
            {
                Name = breed
            }
        };
        return View(_dogStorage.Dogs);
    }

    public IActionResult CreateRandomDog()
    {
        _dogStorage.AddRandomDog();
        return RedirectToAction(nameof(Index), "Home");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
