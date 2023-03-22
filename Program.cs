using System;

namespace Builder_22._03._2023HM
{
    class Program
    {
        public class Car_All
        {
            public string Name_Car { set; get; }
            public string Pourpuc_Car { set; get; }
            public string Engene { set; get; }
            public string Coleso { set; get; }
            public string KPP { set; get; }

            public Car_All() { }
            public Car_All(string N, string P, string E, string C, string K)
            {
                Name_Car = N;
                Pourpuc_Car = P;
                Engene = E;
                Coleso = C;
                KPP = K;
            }

            public void Print()
            {
                Console.WriteLine($"Name_Car{Name_Car}\nPourpuc_Car{Pourpuc_Car}\nEngene{Engene}\nColeso{Coleso}\nKPP{KPP}\n");
            }

            public override string ToString()
            {
                return $"Name_Car{Name_Car}\nPourpuc_Car{Pourpuc_Car}\nEngene{Engene}\nColeso{Coleso}\nKPP{KPP}\n";
            }
        }
        public interface Builder_Car
        {
            public void Name_Car();
            public void Courpus();
            public void Engine();
            public void Coleso();
            public void KPP();
            Car_All GetCar();
            
        }
        public class Builder_Deo: Builder_Car
        {
            private Car_All car_All = new Car_All();

            public void Name_Car()
            {
                car_All.Name_Car = "Deo";
            }
            public void Courpus()
            {
                car_All.Pourpuc_Car = "Седан";
            }
            public void Engine()
            {
                car_All.Engene = "1.5";
            }
            public void Coleso()
            {
                car_All.Coleso = "1.4R";
            }
            public void KPP()
            {
                car_All.KPP = "5 ступенчатая";
            }
            public Car_All GetCar()
            {
                return car_All;
            }

        }
        public class Builder_UAZ: Builder_Car
        {
            private Car_All car_All = new Car_All();

            public void Name_Car()
            {

                car_All.Name_Car = "UAZ";
            }
            public void Courpus()
            {
                car_All.Pourpuc_Car = "Грузовик";
            }
            public void Engine()
            {
                car_All.Engene = "2.5";
            }
            public void Coleso()
            {
                car_All.Coleso = "2R";
            }
            public void KPP()
            {
                car_All.KPP = "5 ступенчатая";
            }
            public Car_All GetCar()
            {
                return car_All;
            }
        }
        public class Builder_Ford: Builder_Car
        {
            private Car_All car_All = new Car_All();

            public void Name_Car()
            {

                car_All.Name_Car = "Ford";
            }
            public void Courpus()
            {
                car_All.Pourpuc_Car = "Седан";
            }
            public void Engine()
            {
                car_All.Engene = "1.9";
            }
            public void Coleso()
            {
                car_All.Coleso = "1.8R";
            }
            public void KPP()
            {
                car_All.KPP = "6 ступенчатая";
            }
            public Car_All GetCar()
            {
                return car_All;
            }
        }
        public class Shop_Director
        {
            private Builder_Car Builder_Car;

            public void Car()
            {
                Builder_Car = new Builder_Deo();
                Builder_Car = new Builder_UAZ();
                Builder_Car = new Builder_Ford();
            }
            public void CarBuild()
            {
                Builder_Car.Name_Car();
                Builder_Car.Courpus();
                Builder_Car.Engine();
                Builder_Car.Coleso();
                Builder_Car.KPP();
            }
            public Builder_Car GetCar()
            {
                return Builder_Car;
            }
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            var director = new Shop_Director();
            director.Car();
            director.CarBuild();
            var build = director.GetCar();
            Car_All car = build.GetCar();
            Console.WriteLine(car);
            




        }
    }
}
