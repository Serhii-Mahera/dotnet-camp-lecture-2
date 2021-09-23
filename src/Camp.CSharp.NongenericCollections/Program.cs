using System;
using System.Collections;

namespace Camp.CSharp.NongenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            IssueOfTypeSafety();

            // Have a look at Camp.CSharp.BoxingBenchmark
            // To see performance issue with allocating memory during boxing
            IssueOfPerformance();
        }

        public static void IssueOfTypeSafety()
        {
            var list = new ArrayList();
            // Add number
            list.Add(1);
            // Add string
            list.Add("2");
            // Add array
            list.Add(new int[] { 1, 2, 3 });
            Console.WriteLine($"Elements into array: {list.Count}");

            foreach(var item in list)
            {
                try
                {
                    var number = (int)item;
                    Console.WriteLine($"The number is: {item}");
                }
                catch(InvalidCastException ex)
                {
                    Console.WriteLine($"An exception was thrown: \n{ex}");
                }
            }
        }

        public static void IssueOfPerformance()
        {
            // Regardless of which type you might choose to hold the integers,
            // you cannot escape the boxing dilemma using nongeneric containers.
            var people = new PeopleCollection();
            people.Add(new User("Andrii", 22));

            foreach(var userObject in people)
            {
                // Perform unboxing
                var user = (User)userObject;
                Console.WriteLine($"- {user.Name} - {user.Age}");
            }
        }
    }

    public struct User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
        
    public class PeopleCollection : IEnumerable
    {
        // Regardless of which type you might choose to hold the integers,
        // you cannot escape the boxing dilemma using nongeneric containers.
        private readonly ArrayList _people = new ArrayList();
        public int Count => _people.Count;

        public IEnumerator GetEnumerator() => _people.GetEnumerator();
        
        // Get a User (performs unboxing!).
        public User GetPerson(int position) => (User)_people[position];
        
        // Insert a User (performs boxing)!
        public void Add(User person) => _people.Add(person);
        public void Clear() => _people.Clear();
    }
}
