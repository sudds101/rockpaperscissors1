using Microsoft.AspNetCore.Mvc;
using rockpaperscissorscontoller.Models;

namespace rockpaperscissorscontoller.Controllers
{
    public class ImageController : Controller
    {
        static List<ImageModel> images = new List<ImageModel>();
        public IActionResult Index()
        {
            images.Add(new ImageModel { Id = 0, ImageState = 0 });
            images.Add(new ImageModel { Id = 1, ImageState = 1 });
            images.Add(new ImageModel { Id = 2, ImageState = 2 });
            return View("ComputerVComputer", images );
        }
    }
}
