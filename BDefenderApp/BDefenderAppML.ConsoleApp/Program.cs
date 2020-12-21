// This file was auto-generated by ML.NET Model Builder. 

using System;
using BDefenderAppML.Model;

namespace BDefenderAppML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create single instance of sample data from first line of dataset for model input
            ModelInput sampleData = new ModelInput()
            {
                Col1 = 20.57F,
                Col2 = 17.77F,
                Col3 = 132.9F,
                Col4 = 1326F,
                Col5 = 0.08474F,
                Col6 = 0.07864F,
                Col7 = 0.0869F,
                Col8 = 0.07017F,
                Col9 = 0.1812F,
                Col10 = 0.05667F,
            };

            // Make a single prediction on the sample data and print results
            var predictionResult = ConsumeModel.Predict(sampleData);

            Console.WriteLine("Using model to make single prediction -- Comparing actual Col0 with predicted Col0 from sample data...\n\n");
            Console.WriteLine($"Col1: {sampleData.Col1}");
            Console.WriteLine($"Col2: {sampleData.Col2}");
            Console.WriteLine($"Col3: {sampleData.Col3}");
            Console.WriteLine($"Col4: {sampleData.Col4}");
            Console.WriteLine($"Col5: {sampleData.Col5}");
            Console.WriteLine($"Col6: {sampleData.Col6}");
            Console.WriteLine($"Col7: {sampleData.Col7}");
            Console.WriteLine($"Col8: {sampleData.Col8}");
            Console.WriteLine($"Col9: {sampleData.Col9}");
            Console.WriteLine($"Col10: {sampleData.Col10}");
            Console.WriteLine($"\n\nPredicted Col0 value {predictionResult.Prediction} \nPredicted Col0 scores: [{String.Join(",", predictionResult.Score)}]\n\n");
            Console.WriteLine("=============== End of process, hit any key to finish ===============");
            Console.ReadKey();
        }
    }
}