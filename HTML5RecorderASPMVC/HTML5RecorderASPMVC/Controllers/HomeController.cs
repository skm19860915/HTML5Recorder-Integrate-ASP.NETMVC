using HTML5RecorderASPMVC.Models;
using System.Web.Mvc;

namespace HTML5RecorderASPMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string data)
        {
            if (Request.Files.Count > 0)
            {
                var file = Request.Files[0];
                var nodes = file.FileName.Split(':');
                var fileName = nodes[0] + "_" + nodes[1] + "_" + nodes[2] + ".wav";
                file.SaveAs(Server.MapPath("~/Resources/" + fileName));
                StoreDataBase(fileName);
            }
            return View();
        }

        private void StoreDataBase(string fileName)
        {
            var repo = new Repository();
            var succes = repo.SaveFileToDb(fileName);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}