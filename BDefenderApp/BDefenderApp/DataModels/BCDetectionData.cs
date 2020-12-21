using Microsoft.ML.Data;

namespace BDefenderApp.DataModels
{
    public class BCDetectionData
    {
        [LoadColumn(0)]
        [LoadColumnName("Label")]
        public bool Verdict { get; set; }
        [LoadColumn(1)]
        public float Radius { get; set; }
        [LoadColumn(2)]
        public float Texture { get; set; }
        [LoadColumn(3)]
        public float Perimeter { get; set; }
        [LoadColumn(4)]
        public float Area { get; set; }
        [LoadColumn(5)]
        public float Smoothness { get; set; }
        [LoadColumn(6)]
        public float Compactness { get; set; }
        [LoadColumn(7)]
        public float Concavity { get; set; }
        [LoadColumn(8)]
        public float ConcavePoints { get; set; }
        [LoadColumn(9)]
        public float Symmetry { get; set; }
        [LoadColumn(10)]
        public float FractalDimenstion { get; set; }
    }
}
