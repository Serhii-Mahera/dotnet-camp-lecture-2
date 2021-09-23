using System;
using System.Collections.Generic;

namespace Camp.CSharp.GenericCollections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            UseGenericListWithDifferentTypes();
            GetDefaultValues();
            GenericCollections();

            // Generic constrains
            // Can't do that, customer needs a reference type
            // new Customer<User>();
            
            Console.WriteLine("Bye!");
        }

        public static void UseGenericMethods()
        {
            Console.WriteLine("***** Generic Methods *****");
            DisplayBaseClass<int>();
            DisplayBaseClass<double>();
            DisplayBaseClass<string>();
            DisplayBaseClass<User>();
        }

        public static void GenericCollections()
        {
            UseGenericDictionary();
            UseGenericLinkedList();
            UseGenericList();
            UseGenericQueue();
            UseGenericSortedDictionary();
            UseGenericSortedDictionaryWithComparer();
            UseGenericSortedSet();
            UseGenericStack();
        }

        public static void DisplayBaseClass<T>()
        {
            Console.WriteLine("Base type of {0}: {1}", typeof(T).Name, typeof(T).BaseType.Name);
        }

        public static void UseGenericDictionary()
        {
            Console.WriteLine("**** Dictionary<T, V> ****");
            var numbers = new Dictionary<int, string>()
            {
                // Key is unique, value isn't
                {1, "One" },
                {5, "Five" },
                {2, "Two" },
                {3, "Three" },
                {6, "Six" },
                {0, "Zero" },
                {4, "Four" },
                {7, "Seven" },
            };
            numbers.Add(8, "Eight");
            numbers.Add(9, "Nine");

            // If dictionary do not contain key 9,
            // than it will be added and true is returned
            // If dictionary contains key it will return false
            if(numbers.TryAdd(9, "Nine"))
            {
                Console.WriteLine("Value was added");
            }
            else
            {
                Console.WriteLine("Value wasn't added");
            }

            // Check if the dictionary contains this key
            if(numbers.ContainsKey(0))
            {
                Console.WriteLine("0 key is existed");
            }

            // Output all pairs
            foreach(KeyValuePair<int, string> pair in numbers)
            {
                Console.WriteLine($"{pair.Key}:{pair.Value}");
            }

            // Clear the dictionary
            numbers.Clear();
        }

        public static void UseGenericLinkedList()
        {
            Console.WriteLine("**** Dictionary<T, V> ****");
            var list = new LinkedList<int>();

            // Add elements to the end of collection
            list.AddLast(2);
            list.AddLast(4);
            list.AddLast(8);

            // Add element to the start of collection
            list.AddFirst(10);
            var elWithValue4 = list.Find(4);

            // Add value before node with value 4
            list.AddBefore(elWithValue4, 3);

            // Add value after node with value 4
            list.AddAfter(elWithValue4, 5);

            // Remove last element of the collection
            list.RemoveLast();

            Console.WriteLine("Linked list after manipulating:");
            foreach(var el in list)
            {
                Console.WriteLine($"{el}");
            }
        }

        public static void UseGenericList()
        {
            Console.WriteLine("***** List<T> *****\n");
            // This List<> can hold only User objects.
            List<User> morePeople = new List<User>();
            // Add user to the list
            var tolik = new User("Tolik", 50);
            morePeople.Add(tolik);

            // Add multiple users from another collection
            morePeople.AddRange(new[] { new User("Petro", 50), new User("Oksana", 18) });

            // Find index of tolik object
            var tolikPlace = morePeople.IndexOf(tolik);
            Console.WriteLine($"Tolik index is: {tolikPlace}");

            Console.WriteLine("Users collection after manipulating:");
            foreach(var user in morePeople)
            {
                Console.WriteLine(user);
            }
        }

        public static void UseGenericQueue()
        {
            Console.WriteLine("***** Queue<T> *****");
            // FIFO
            var shopQueue = new Queue<User>();

            var tolik = new User("Tolik", 50);
            var oksana = new User("Oksana", 18);
            // Add object to the end of the queue
            shopQueue.Enqueue(oksana);
            shopQueue.Enqueue(tolik);

            // Get the object at the beggining of the queue
            // without removing it
            var firstBuyer = shopQueue.Peek();
            Console.WriteLine("First buyer: {0}", firstBuyer);

            Console.WriteLine("Checkout is open!!!");
            while(shopQueue.TryDequeue(out var currentBuyer))
            {
                Console.WriteLine($"Processing {currentBuyer}");
            }

            Console.WriteLine("Checkout is closed. No more buyers");
        }

        public static void UseGenericStack()
        {
            Console.WriteLine("***** Stack<T> *****");
            // LIFO
            var stack = new Stack<int>();

            // Add objects to the top of stack
            stack.Push(20);
            stack.Push(18);
            stack.Push(40);
            stack.Push(16);
            stack.Push(12);

            // Get the object at the top of the stack
            // without removing it
            var topItem = stack.Peek();
            Console.WriteLine("Top item: {0}", topItem);

            Console.WriteLine("Processing stack!!!");
            while(stack.TryPop(out var currentElement))
            {
                Console.WriteLine($"Processing {currentElement}");
            }

            // Clear the stack
            stack.Clear();

            Console.WriteLine("Checkout is closed. No more buyers");
        }

        public static void UseGenericSortedDictionary()
        {
            Console.WriteLine("**** SortedDictionary<T, V> ****");
            // Contains same behaviour as Dictionary<T>
            // But values is always ordered
            var numbers = new SortedDictionary<int, string>()
            {
                // Key is unique, value isn't
                {1, "One" },
                {5, "Five" },
                {2, "Two" },
                {3, "Three" },
                {6, "Six" },
                {0, "Zero" },
                {4, "Four" },
                {7, "Seven" },
            };
            numbers.Add(8, "Eight");

            // If dictionary do not contain key 9,
            // than it will be added and true is returned
            // If dictionary contains key it will return false
            if(numbers.TryAdd(9, "Nine"))
            {
                Console.WriteLine("Value 9 was added");
            }
            else
            {
                Console.WriteLine("Value wasn't added");
            }

            // Output all pairs
            foreach(KeyValuePair<int, string> pair in numbers)
            {
                Console.WriteLine($"{pair.Key}:{pair.Value}");
            }

            // Clear the dictionary
            numbers.Clear();
        }

        public static void UseGenericSortedDictionaryWithComparer()
        {
            Console.WriteLine("**** SortedDictionary<T, V> ****");
            // Contains same behaviour as Dictionary<T>
            // But pairs is always ordered
            var numbers = new SortedDictionary<int, string>(new IntDescendingComparer())
            {
                // Key is unique, value isn't
                {1, "One" },
                {5, "Five" },
                {2, "Two" },
                {3, "Three" },
                {6, "Six" },
                {0, "Zero" },
                {4, "Four" },
                {7, "Seven" },
            };

            // Output all pairs
            foreach(KeyValuePair<int, string> pair in numbers)
            {
                Console.WriteLine($"{pair.Key}:{pair.Value}");
            }

            // Clear the dictionary
            numbers.Clear();
        }

        public static void UseGenericSortedSet()
        {
            Console.WriteLine("***** SortedSet<T> *****");
            var setOfUsers = new SortedSet<User>(new UserAgeDescendingComparer());
            setOfUsers.Add(new User("Oksana", 18));
            setOfUsers.Add(new User("Andrew", 50));
            setOfUsers.Add(new User("Tolik", 35));

            Console.WriteLine("Current set of data:");
            PrintSortedSet(setOfUsers);
            // Add new value with the age that already exists
            // This item will be skipped
            setOfUsers.Add(new User("Ihor", 50));
            // This item will be added
            setOfUsers.Add(new User("Pavlo", 40));
            // Set is still sorted
            PrintSortedSet(setOfUsers);
            Console.WriteLine();
        }

        public static void UseGenericListWithDifferentTypes()
        {
            Console.WriteLine("***** List<T> *****\n");
            // This List<> can hold only User objects.
            List<User> morePeople = new List<User>();
            morePeople.Add(new User("Tolik", 50));

            Console.WriteLine(morePeople[0]);
            // This List<> can hold only integers.
            List<int> moreInts = new List<int>();
            moreInts.Add(10);
            moreInts.Add(2);
            int sum = moreInts[0] + moreInts[1];
            moreInts.Add(sum);

            // Compile-time error
            // You can't add another type variable to list of users
            //morePeople.Add(sum);
        }

        public static void GetDefaultValues()
        {
            Console.WriteLine("**** default(T) ****");
            var defaultOfInt = GetDefault<int>();
            var defaultOfString = GetDefault<string>();
            var defaultOfDecimal = GetDefault<decimal>();
            var defaultOfUser = GetDefault<User>();

            Console.WriteLine("Default of int: {0}", defaultOfInt); // 0
            Console.WriteLine("Default of string: {0}", defaultOfString ?? "null"); // null
            Console.WriteLine("Default of Decimal: {0}", defaultOfDecimal); // 0.0
            Console.WriteLine("Default of user: {0}", defaultOfUser); // { Name: 'null'; Age: '0'}
            Console.WriteLine();
        }

        // The "default" keyword is overloaded in C#.
        // When used with generics, it represents the default
        // value of a type parameter.
        public static T GetDefault<T>()
        {
            return default(T);
        }

        private static void PrintSortedSet(SortedSet<User> users)
        {
            Console.WriteLine("Current set:");
            foreach(var user in users)
            {
                Console.WriteLine(user);
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

        public override string ToString() => $"Name: '{Name ?? "null"}'; Age: '{Age}'";
    }

    // You can create custom comparer to change order 
    // or apply ordiring logic to your custom class
    // using generic type
    public class IntDescendingComparer : IComparer<int>
    {
        public int Compare(int first, int second)
        {
            if(first > second)
                return -1;
            else if(first < second)
                return 1;

            return 0;
        }
    }

    public class UserAgeDescendingComparer : IComparer<User>
    {
        public int Compare(User first, User second)
        {
            if(first.Age > second.Age)
                return -1;
            else if(first.Age < second.Age)
                return 1;

            return 0;
        }
    }

    public interface IId<T> 
    {
        T Id { get; }
    }

    public class Item : IId<int>
    {
        public int Id { get; }
    }

    // Than you can useit as:
    // new Customer<int>();
    // new Customer<string>();
    public class Customer<T> : IId<T>
            where T: class, new()
    {
        public T Id { get; }
    }

    // when you fill List with type of User (List<User>), 
    // you can assume that User is placed instead of T parameter
    // And collection like this is created:
    // !!! It's just to explain generic parameter, it is not how compiler really work with generics !!!
    //public class List<User> : IList<User>, ICollection<User>, IEnumerable<User>, IReadOnlyList<User>, IList, ICollection, IEnumerable
    //{
    //    public void Add(User item);
    //    public ReadOnlyCollection<User> AsReadOnly();
    //    public int BinarySearch(User item);
    //    public bool Contains(User item);
    //    public void CopyTo(User[] array);
    //    public int FindIndex(System.Predicate<User> match);
    //    public User FindLast(System.Predicate<User> match);
    //    public bool Remove(User item);
    //    public int RemoveAll(System.Predicate<User> match);
    //    public User[] ToArray();
    //    public bool TrueForAll(System.Predicate<User> match);
    //    ...
    //}
}