using Microsoft.ML.Data;

namespace BDefenderApp.DataModels
{
    public class BCDetectionData
    {
        [LoadColumn(0)]
        [LoadColumnName("Label")]
        public bool Verdict { get; set; }
        [LoadColumn(1)]
        public int Radius { get; set; }
        [LoadColumn(2)]
        public int Texture { get; set; }
        [LoadColumn(3)]
        public int Perimeter { get; set; }
        [LoadColumn(4)]
        public int Area { get; set; }
        [LoadColumn(5)]
        public int Smoothness { get; set; }
        [LoadColumn(6)]
        public int Compactness { get; set; }
        [LoadColumn(7)]
        public int Concavity { get; set; }
        [LoadColumn(8)]
        public int ConcavePoints { get; set; }
        [LoadColumn(9)]
        public int Symmetry { get; set; }
        [LoadColumn(10)]
        public int FractalDimenstion { get; set; }
    }
}
