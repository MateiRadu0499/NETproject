using Microsoft.ML.Data;

namespace BDefenderApp.DataModels
{
    public class BCVerdictPrediction
    {
        [ColumnName("PredictedLabel")]
        public string Prediction { get; set; }

        public float Probabilty { get; set; }

        public float Score { get; set; }
    }
}
