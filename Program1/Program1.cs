using System;

namespace StudentAdmissionManagement
{
    // Class representing a Student Candidate
    class Candidate
    {
        // Private Data Members (Encapsulation)
        private int rollNo;
        private string studentName;
        private int studentAge;
        private string selectedCourse;

        // Constructor to initialize candidate data
        public Candidate(int rNo, string sName, int sAge, string sCourse)
        {
            rollNo = rNo;
            studentName = sName;
            studentAge = sAge;
            selectedCourse = sCourse;
        }

        // Method to print candidate record
        public void PrintRecord()
        {
            Console.WriteLine("\n--- Admission Info ---");
            Console.WriteLine("Roll No : " + rollNo);
            Console.WriteLine("Name    : " + studentName);
            Console.WriteLine("Age     : " + studentAge);
            Console.WriteLine("Course  : " + selectedCourse);
        }

        // Method to modify course
        public void ModifyCourse(string updatedCourse)
        {
            selectedCourse = updatedCourse;
            Console.WriteLine("\nCourse details updated!");
        }
    }

    class AdmissionSystem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Student Admission Portal ===");

            // Prompting user input
            Console.Write("Enter Roll No: ");
            int rNo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Name: ");
            string sName = Console.ReadLine();

            Console.Write("Enter Age: ");
            int sAge = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Course: ");
            string sCourse = Console.ReadLine();

            // Creating Candidate Object
            Candidate applicant = new Candidate(rNo, sName, sAge, sCourse);

            // Display details
            applicant.PrintRecord();

            // Update course
            Console.Write("\nEnter New Course: ");
            string updatedCourse = Console.ReadLine();
            applicant.ModifyCourse(updatedCourse);

            // Display updated details
            applicant.PrintRecord();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}



