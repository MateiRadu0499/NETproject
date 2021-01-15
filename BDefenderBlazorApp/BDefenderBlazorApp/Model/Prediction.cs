using System.ComponentModel.DataAnnotations;

namespace BDefenderBlazorApp.Model
{
    public class Prediction
    {
        public int Id { get; set; }
        [Required]
        public float Col0 { get; set; }//Radius
        [Required]
        public float Col1 { get; set; }//Texture
        [Required]
        public float Col2 { get; set; }//Perimeter
        [Required]
        public float Col3 { get; set; }//Area
        [Required]
        public float Col4 { get; set; }//Smoothness
        [Required]
        public float Col5 { get; set; }//Compactness
        [Required]
        public float Col6 { get; set; }//Concavity
        [Required]
        public float Col7 { get; set; }//ConcavePoints
        [Required]
        public float Col8 { get; set; }//Symmetry
        [Required]
        public float Col9 { get; set; }//FractalDimension
    }
}
