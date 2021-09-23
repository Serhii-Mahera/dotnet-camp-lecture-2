using System;

namespace Camp.CSharp.Attributes
{
    class Program
    {
        public static void Main(string[] args)
        {
            User tom = new User(35);
            User bob = new User(16);
            bool tomIsValid = ValidateUser(tom);    // true
            bool bobIsValid = ValidateUser(bob);    // false

            Console.WriteLine($"Результат валідації Тома: {tomIsValid}");
            Console.WriteLine($"Результат валідації Боба: {bobIsValid}");
            Console.ReadLine();
        }

        static bool ValidateUser(User user)
        {
            Type t = typeof(User);
            object[] attrs = t.GetCustomAttributes(false);
            foreach(AgeValidationAttribute attr in attrs)
            {
                if(user.Age <= attr.Age)
                    return false;
            }

            return true;
        }

        // https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/attributes/
        [System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct)]
        public sealed class AgeValidationAttribute : System.Attribute
        {
            public int Age { get; }

            public AgeValidationAttribute(int age)
            {
                this.Age = age;
            }
        }

        [AgeValidation(18)]
        public class User
        {
            public int Age { get; set; }

            public User(int age)
            {
                this.Age = age;
            }
        }
    }
}
