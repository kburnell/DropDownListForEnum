using System.Web.Mvc;
using DropDownListForEnumDemo.Extensions;
using DropDownListForEnumDemo.Models;

namespace DropDownListForEnumDemo.Controllers {

    public class HomeController : Controller {

        public ActionResult Index() {
            return View("Index", new CarsModel());
        }

        [HttpPost]
        public ActionResult Index(CarsModel model) {
            ViewBag.Message = model.SelectedCar.ToString().FromCamelToProperCase();
            return View("Index", model);
        }

        public ActionResult About() {
            return View();
        }
    }
}