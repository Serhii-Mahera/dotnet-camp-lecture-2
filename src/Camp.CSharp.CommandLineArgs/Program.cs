using System;

namespace Camp.CSharp.CommandLineArgs
{
    class Program
    {
        /*
            1. Build your project
            2. Open PowerShell window
            3. Go to Camp.CSharp\Camp.CSharp.CommandLineArgs\bin\Debug\net5.0 folder
            4. Run ".\Camp.CSharp.CommandLineArgs.exe -arg1 -godmode /arg2 arg3" command

          OR
           
            1. Go to project properties
            2. Go to Debug view
            3. Put into 'Application arguments' value -arg1 -godmode /arg2 arg3
            4. Run application by pressing F5 into Visual Studio

        Output:
            Arg № 0: -arg1
            Arg № 1: -godmode
            Arg № 2: /arg2
            Arg № 3: arg3

         */
        static void Main(string[] args)
        {
            // 1. Access with 'args' argument
            for(int i = 0; i < args.Length; i++)
            {
                Console.WriteLine("Arg № {0}: {1}", i, args[i]);
            }

            // 2. Access with Environment.GetCommandLineArgs()
            Console.WriteLine("************* Environment.GetCommandLineArgs() *************");
            /* 
             * The first index identifies the name of the application itself, 
             * while the remaining elements in the array contain the individual command-line arguments 
             */
            var commandLineArgs = Environment.GetCommandLineArgs();
            for(int i = 0; i < commandLineArgs.Length; i++)
            {
                Console.WriteLine("Arg № {0}: {1}", i, commandLineArgs[i]);
            }

            // 3. Additional members of the System.Environment class
            ShowEnvironmentDetails();

            Console.ReadLine();
        }

        static void ShowEnvironmentDetails()
        {
            Console.WriteLine("***** Show Environment Details *****");
            // Print out the drives on this machine,
            // and other interesting details.
            foreach(string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of processors: {0}",
            Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}", Environment.Version);
        }
    }
}
