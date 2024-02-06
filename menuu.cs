using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        bool keepRunning = true;

        while (keepRunning)
        {
			Console.WriteLine("-------------------------------");
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Name:RavindraGouda S Patil");
			Console.WriteLine("USN:4MH21CS078");
			Console.WriteLine("Faculty Name:Victore sir");
			Console.WriteLine("-------------------------------");
			Console.WriteLine("-------------------------------");
            Console.WriteLine("Menu of Programs:");
			Console.WriteLine("-------------------------");
            Console.WriteLine("1. Arithmatic Operations");
            Console.WriteLine("-------------------------");
            Console.WriteLine("2. Armstrong numbers");
			Console.WriteLine("-------------------------");
            Console.WriteLine("3. Substring of a string");
			Console.WriteLine("-------------------------");
            Console.WriteLine("4.Divide by zero exception");
			Console.WriteLine("-------------------------");
            Console.WriteLine("5. Pascal's Triangle");
			Console.WriteLine("-------------------------");
            Console.WriteLine("6. Floyd's Triangle");
			Console.WriteLine("-------------------------");
			Console.WriteLine("7. Read and Copy a Text file");
			Console.WriteLine("-------------------------");
			Console.WriteLine("8. Implementation of Stack Operations");
			Console.WriteLine("-------------------------");
			Console.WriteLine("9. Complex Numbers");
			Console.WriteLine("-------------------------");
			Console.WriteLine("10. Polymorphism Concepts");
			Console.WriteLine("-------------------------");
			Console.WriteLine("11. Abstract class for Calculating the Perimeter");
			Console.WriteLine("-------------------------");
			Console.WriteLine("12. Interface for Resizable");
			Console.WriteLine("-------------------------");
            Console.WriteLine("0.	Exit");
			Console.WriteLine("-------------------------");
            Console.Write("Enter your choice: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    RunProgram("first.exe");
                    break;
                case "2":
                    RunProgram("second.exe");
                    break;
                case "3":
                    RunProgram("third.exe");
                    break;
				case "4":
                    RunProgram("fourth.exe");
                    break;
				case "5":
                    RunProgram("fifth.exe");
                    break;
				case "6":
                    RunProgram("sixth.exe");
                    break;
				case "7":
                    RunProgram("seventh.exe");
                    break;
				case "8":
                    RunProgram("eighth.exe");
                    break;
				case "9":
                    RunProgram("ninth.exe");
                    break;
				case "10":
                    RunProgram("tenth.exe");
                    break;
				case "11":
                    RunProgram("eleventh.exe");
                    break;
				case "12":
                    RunProgram("twelfth.exe");
                    break;
					
                case "0":
                    keepRunning = false;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void RunProgram(string programName)
    {
        ProcessStartInfo startInfo = new ProcessStartInfo
        {
            FileName = programName,
            UseShellExecute = false
        };

        Process.Start(startInfo).WaitForExit();
    }
}
