using System.Diagnostics;
using System.Net.Http;
using FrameData_WebApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FrameData_WebApp.Controllers
{
    public class MvCIFrameDataController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            CharacterListModel.Characters = APICalls.GetCharacterListAsync().Result;
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
