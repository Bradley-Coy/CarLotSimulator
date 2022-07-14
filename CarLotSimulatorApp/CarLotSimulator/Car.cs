using System;
namespace CarLotSimulator
{
    public class Car
    {
        public int Year;
        public string Make;
        public string Model;
        public string EngineNoise;
        public string HonkNoise;
        public string IsDriveable;

        public Car(int year, string make, string model, string enginenoise, string honknoise, string isdriveable)
        {
            Year = year;
            Make = make;
            Model = model;
            EngineNoise = enginenoise;
            HonkNoise = honknoise;
            IsDriveable = isdriveable;

        }
    }
}

