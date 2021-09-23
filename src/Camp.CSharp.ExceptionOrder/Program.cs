using System;

namespace Camp.CSharp.ExceptionOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Right order of error catching ****");

            try
            {
                var carWithHandledException = new CarWithException();
                carWithHandledException.Accelarate(20);
                carWithHandledException.Accelarate(-20);
                carWithHandledException.Accelarate(20);
                carWithHandledException.Accelarate(20);
                carWithHandledException.Accelarate(20);
                carWithHandledException.Accelarate(20);
                carWithHandledException.Accelarate(20);
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Out of range exception has occured. Message {0}", ex.Message);
            }
            catch(CarIsOverheatedException ex)
            {
                Console.WriteLine("***** Exception Handling *****");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Source: {ex.Source}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
                Console.WriteLine($"Reason: {ex.Reason}");
                Console.WriteLine("***** Finish Exception Handling *****");
            }
            // This will catch any other exeptions
            // except CarIsDeadException or
            // ArgumentOutOfRangeException.
            catch(Exception ex)
            {
                Console.WriteLine($"Other exeption was thrown: {ex.Message}");
            }

            Console.WriteLine("**** Wrong order of error catching ****");

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
            // This will catch all exceptions
            catch(Exception ex)
            {
                Console.WriteLine($"Other exeption was thrown: {ex.Message}");
            }
            // this statement has no meaning as first catch will handle this exception
            // Uncomment code below to see compiler error
            //catch(ArgumentOutOfRangeException ex)
            //{
            //    Console.WriteLine("Out of range exception has occured. Message {0}", ex.Message);
            //}
            //catch(CarIsOverheatedException ex)
            //{
            //    Console.WriteLine("***** Exception Handling *****");
            //    Console.WriteLine($"Method: {ex.TargetSite}");
            //    Console.WriteLine($"Message: {ex.Message}");
            //    Console.WriteLine($"Source: {ex.Source}");
            //    Console.WriteLine($"StackTrace: {ex.StackTrace}");
            //    Console.WriteLine($"Reason: {ex.Reason}");
            //    Console.WriteLine("***** Finish Exception Handling *****");
            //}

            Console.ReadLine();
        }
    }

    class CarWithException
    {
        private int _maxSpeed = 100;
        private int _currentSpeed = 0;
        private bool _isDead = false;

        public void Accelarate(int step)
        {
            if(step < 0)
            {
                throw new ArgumentOutOfRangeException("Step must be greater than zero");
            }

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
                    // Take into account that we change this from Exception to derived class
                    throw new CarIsOverheatedException("Car has been overheated!", $"You exceeded the speed limit of {_maxSpeed} Km/h");
                }
                else
                {
                    Console.WriteLine($"Current speed: {_currentSpeed}");
                }
            }
        }
    }

    // Type Exception and press TAB twice
    // This will automatically generate exception
    [Serializable]
    public class CarIsOverheatedException : System.Exception
    {
        public string Reason { get; set; }

        public CarIsOverheatedException() { }
        public CarIsOverheatedException(string message) : base(message) { }
        public CarIsOverheatedException(string message, System.Exception inner) : base(message, inner) { }
        public CarIsOverheatedException(string message, string reason) : base(message)
        {
            Data.Add("Reason", reason);
            // You could decide which approach you want to use
            Reason = reason;
        }
        protected CarIsOverheatedException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
