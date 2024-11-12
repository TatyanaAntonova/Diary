using Microsoft.AspNetCore.Mvc;

namespace Diary.Controllers;

public class CameraController : Controller
{
    public IActionResult Capture()
    {
        return View();
    }
}