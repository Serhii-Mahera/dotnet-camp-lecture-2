using System;

namespace Camp.CSharp.SimpleExceptionOverview
{
    class Program
    {
        static void Main(string[] args)
        {
            // Just output to console
            var car = new Car();
            car.Accelarate(20);
            car.Accelarate(20);
            car.Accelarate(20);
            car.Accelarate(20);
            car.Accelarate(20);
            car.Accelarate(20);
            car.Accelarate(20);
            
            // Aplication will crash
            //var carWithException = new CarWithException();
            //carWithException.Accelarate(20);
            //carWithException.Accelarate(20);
            //carWithException.Accelarate(20);
            //carWithException.Accelarate(20);
            //carWithException.Accelarate(20);
            //carWithException.Accelarate(20);
            //carWithException.Accelarate(20);

            // Cathing the exception
            // Comment previous steps
            try
            {
                var carWithHandledException = new CarWithException();
                carWithHandledException.Accelarate(20);
                carWithHandledException.Accelarate(20);
                carWithHandledException.Accelarate(20);
                carWithHandledException.Accelarate(20);
                carWithHandledException.Accelarate(20);
                carWithHandledException.Accelarate(20);
                carWithHandledException.Accelarate(20);
            }
            catch(Exception ex)
            {
                Console.WriteLine("***** Exception Handling *****");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Source: {ex.Source}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                Console.WriteLine("***** Finish Exception Handling *****");
            }

            Console.ReadLine();
        }
    }

    class Car
    {
        private int _maxSpeed = 100;
        private int _currentSpeed = 0;
        private bool _isDead = false;

        public void Accelarate(int step)
        {
            if(_isDead)
            {
                Console.WriteLine("Car is out of order...");
            }
            else
            {
                _currentSpeed += step;
                if(_currentSpeed > _maxSpeed)
                {
                    _isDead = true;
                    _currentSpeed = 0;
                    Console.WriteLine("Car has overheated!");
                }
                else
                {
                    Console.WriteLine($"Current speed: {_currentSpeed}");
                }
            }
        }
     }

    class CarWithException
    {
        private int _maxSpeed = 100;
        private int _currentSpeed = 0;
        private bool _isDead = false;

        public void Accelarate(int step)
        {
            if(_isDead)
            {
                Console.WriteLine("Car is out of order...");
            }
            else
            {
                _currentSpeed += step;
                if(_currentSpeed > _maxSpeed)
                {
                    _isDead = true;
                    _currentSpeed = 0;
                    throw new Exception("Car has been overheated!");
                }
                else
                {
                    Console.WriteLine($"Current speed: {_currentSpeed}");
                }
            }
        }
    }
}
