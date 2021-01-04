using Microsoft.AspNetCore.Mvc;
using BCPredictMLML.Model;

namespace BCPredictML.Controllers
{
    public class BCDetectionController : Controller
    {
        [HttpGet]
        public IActionResult Predict()
        {
            return View();
        }

        [HttpPost]
        public ModelOutput Index(ModelInput input)
        {
            var prediction = ConsumeModel.Predict(input);
            return prediction;
        }
    }
}
