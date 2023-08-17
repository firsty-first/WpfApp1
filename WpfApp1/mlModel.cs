using System;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;

class Program
{
    static void Main(string[] args)
    {
        // Load the ONNX model
        using (var session = new InferenceSession("\"C:\\Users\\GAURAV\\Downloads\\Final_work (1)\\Finalmodel.onnx\""))
        {   
            // Prepare input data
            var inputMeta = session.InputMetadata["input_name"]; // Replace with actual input name
            var inputValues = new float[1, inputMeta.Dimensions[1], inputMeta.Dimensions[2], inputMeta.Dimensions[3]]; // Adjust dimensions

            // Create tensor from input data
            var tensor = new DenseTensor<float>(inputValues);

            // Run inference
            var outputs = session.Run(new[] { "output_name" }, new[] { tensor }); // Replace with actual output name

            // Process outputs
            var output = outputs.First();
            // Process the output data as needed
        }
    }
}
