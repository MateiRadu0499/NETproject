using BDefenderApp.DataModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.ML;
using System;

namespace BDefenderApp.Controllers
{
    [Route("api/v1/predictions")]
    [ApiController]
    public class BCAnalysisController : ControllerBase
    {
        private const string M = "M";
        private const string B = "B";
        private readonly PredictionEnginePool<BCDetectionData, BCVerdictPrediction> _predictionEnginePool;

        public BCAnalysisController(PredictionEnginePool<BCDetectionData, BCVerdictPrediction> predictionEnginePool)
        {
            this._predictionEnginePool = predictionEnginePool;
        }

        [HttpPost]
        public ActionResult<string> Post([FromBody] BCDetectionData data)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            BCVerdictPrediction predictedValue = _predictionEnginePool.Predict(modelName: "BCAnalysisModel", example: data);

            string prediction = Convert.ToBoolean(predictedValue.Prediction) ? M : B;

            return Ok(prediction);
        }
    }
}
