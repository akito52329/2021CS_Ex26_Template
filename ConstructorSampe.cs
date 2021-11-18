using System;
using ConsoleUtility;

namespace ConstructorSampe
{
    class ConstructorSampeMain
    {
        static void Main(string[] args)
        {
            Triangle triangle = new Triangle(
                InteractiveInput.InputFloat("底辺(cm)："),
                InteractiveInput.InputFloat("高さ(cm)："));

            Console.WriteLine($"面積は{triangle.GetSurface()}cm²");
        }
    }
}
