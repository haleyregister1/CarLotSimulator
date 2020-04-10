using System;
namespace CarLotSimulator
{
    public class Car
    {
        public Car(string year, string make, string model)
        {
            Year = year;
            Make = make;
            Model = model;
        }
        public string Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public void EngineNoise(string noise)
        {
            Console.WriteLine(noise);
        }
        public void HonkNoise(string noise)
        {
            Console.WriteLine(noise);
        }
    }
}
//string year, string make, string model
/*Year = year;
  Make = make;
  Model = model;*/
            