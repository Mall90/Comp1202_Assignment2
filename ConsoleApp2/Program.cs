using System;
using System.IO;


namespace TESTTESTSTSTST
{
    class Program
    {
        public static int StudentSize = 15;
        public static Student[] students1 = new Student[StudentSize];

        static void Main(string[] args)
        {
            string menuChoice;

            do
            {
                ShowMenu();
                Console.Write(">>> ");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        AddStudent();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "2":
                        ListStudents();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                    case "3":
                        FindStudent();
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;

                }
            } while (menuChoice != "4");

        }

        public static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("***************************************************");
            Console.WriteLine("**          STUDENT INFORMATION          **");
            Console.WriteLine("***************************************************");
            Console.WriteLine();
            Console.WriteLine("Enter one of the options below...");
            Console.WriteLine();
            Console.WriteLine("1.\tAdd Student");
            Console.WriteLine("2.\tView Student List");
            Console.WriteLine("3.\tFind A Specific Student");
            Console.WriteLine("4.\tExit");
        }
        public static void AddStudent()
        {
            try
            {
                for (int i = 0; i < students1.Length; i++)
                {
                    if (students1[i] == null)
                    {
                        Console.Clear();
                        Console.WriteLine(">>>>>>>> Add Student <<<<<<<<");

                        Console.Write($">>> Student ID: ");
                        int stuID = int.Parse(Console.ReadLine());

                        Console.Write($">>> Student's first name: ");
                        string fName = Console.ReadLine();

                        Console.Write($">>> Student's last name: ");
                        string lName = Console.ReadLine();

                        Console.Write($">>> Student's Major: ");
                        string stuMajor = Console.ReadLine();

                        Console.Write($">>> Student's Phone Number: ");
                        string phone = Console.ReadLine();

                        Console.Write($">>> Student's GPA: ");
                        double stuGPA = double.Parse(Console.ReadLine());

                        Console.Write($">>> Student's Day of Birth: ");
                        int dob = int.Parse(Console.ReadLine());

                        Console.Write($">>> Student's Month of Birth: ");
                        int mob = int.Parse(Console.ReadLine());

                        Console.Write($">>> Student's Year of Birth: ");
                        int yob = int.Parse(Console.ReadLine());

                        Student student = new Student(
                            studentID: stuID,
                            firstName: fName,
                            lastName: lName,
                            major: stuMajor,
                            phone: phone,
                            gpa: stuGPA,
                            dayOfBirth: dob,
                            monthOfBirth: mob,
                            yearOfBirth: yob
                            );

                        Console.WriteLine();
                        Console.WriteLine(student.ToInfo());

                        students1[i] = student;
                        Console.WriteLine(">>> Student Information saved successfully!");
                        return;
                    }
                }

                Console.WriteLine("Sorry... Student List is already full!");
            }
            catch (Exception error)
            {
                Console.WriteLine(error.Message);
                Console.WriteLine(">>> Student information wasn't saved! Please try agian!");
            }
        }

        public static void ListStudents()
        {
            Console.Clear();
            Console.WriteLine(">>>>>>>> View Student List <<<<<<<<");
            Console.WriteLine($"Student Name \t\t\t GPA");
            Console.WriteLine();

            int nullCount = 0;

            for (int i = 0; i < students1.Length; i++)
            {
                if (students1[i] == null)
                {
                    nullCount += 1;
                }
                else
                {
                    Console.WriteLine($"{i + 1}. {students1[i].GetFullName()} \t\t {students1[i].GetGPA()}");
                }
            }

            Console.WriteLine();

            if (nullCount == students1.Length)
            {
                InformEmptyBook();
            }
        }

        public static void FindStudent()
        {
            Console.Clear();
            Console.WriteLine(">>>>>>>> Find A Student <<<<<<<<");
            Console.WriteLine();

            string[] studentToFind = GrabStudent(action: "view");
            int nullCount = 0;
            int nameNotMatch = 0;

            for (int i = 0; i < students1.Length; i++)
            {
                if (students1[i] == null)
                {
                    nullCount += 1;
                    nameNotMatch += 1;
                }
                else
                {
                    if (students1[i].FirstName.ToLower() == studentToFind[0] &&
                        students1[i].LastName.ToLower() == studentToFind[1])
                    {
                        Console.WriteLine();
                        Console.WriteLine(">>>>>>>> Student Found <<<<<<<<\n");
                        Console.WriteLine(students1[i].ToInfo());
                        break;
                    }
                    else
                    {
                        nameNotMatch += 1;
                    }
                }
            }
        }

        public static string[] GrabStudent(string action)
        {
            var fullName = new string[2];

            Console.WriteLine($"To {action} the student, please enter:");
            Console.Write($"> First name: ");
            string fName = Console.ReadLine().ToLower();
            fullName[0] = fName;

            Console.Write($"> Last name: ");
            string lName = Console.ReadLine().ToLower();
            fullName[1] = lName;

            return fullName;
        }

        public static void InformEmptyBook()
        {
            Console.WriteLine();
            Console.WriteLine(">>>>>>>> The student list is empty <<<<<<<<");
            Console.WriteLine();
        }

    }
}
