using System;

namespace GPACalculator
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Wildcat GPA Calculator!\n");
            string[] courseLoad = getCourseLoad();
            string[] grades = getCourseGrades(courseLoad);
            int[] courseWeight = getCourseWeight(courseLoad);
            Console.WriteLine("\nGPA: " + calculateGPA(courseLoad, grades, courseWeight));

        }

        static string[] getCourseLoad()
        {
            Console.WriteLine("Please enter the number of courses you're in: ");
            int numCourses = Convert.ToInt32(Console.ReadLine());
            string[] courseLoad = new string[numCourses];

            for (int i = 0; i < numCourses; i++)
            {
                Console.WriteLine("Enter the names of course " + (i + 1) + ":");
                courseLoad[i] = Console.ReadLine();
            }

            return courseLoad;
        }

        static int[] getCourseWeight(string [] courseLoad)
        {
            Console.WriteLine("\nPlease enter the number of credits for each course. \n Example: \"STA 318: 3\" or \"STA318: 3\", where 3 is the digit you eneter:\n");
            int[] courseWeight = new int[courseLoad.Length];
            for (int i = 0; i < courseWeight.Length; i++)
            {
                Console.Write(courseLoad[i]+": ");
                courseWeight[i] = Convert.ToInt16(Console.ReadLine());
            }

            return courseWeight;
        }

        static string[] getCourseGrades(string [] courseLoad)
        {
            Console.WriteLine("\nPlease enter the grade for each course. \n Example: \"STA 318: A\" or \"STA318: A\", where A is the grade you eneter:\n");
            string[] courseGrades = new string[courseLoad.Length];
            for (int i = 0; i < courseGrades.Length; i++)
            {
                Console.Write(courseLoad[i] + ": ");
                courseGrades[i] = Console.ReadLine();
            }

            return courseGrades;
        }

        static double calculateGPA(string[] courseLoad, string[] courseGrades, int[] courseWeight)
        {
            double gpa = 0;
            int credits = 0;

            for (int i = 0; i < courseWeight.Length; i++)
                credits += courseWeight[i];

            for (int i = 0; i < courseLoad.Length; i++)
            {
                if (courseGrades[i] == "A" || courseGrades[i] == "a")
                    gpa += (4 * courseWeight[i]);
                else if (courseGrades[i] == "B" || courseGrades[i] == "b")
                    gpa += (3 * courseWeight[i]);
                else if (courseGrades[i] == "C" || courseGrades[i] == "c")
                    gpa += (2 * courseWeight[i]);
                else if (courseGrades[i] == "D" || courseGrades[i] == "d")
                    gpa += (1 * courseWeight[i]);
                else
                    gpa += (0 * courseWeight[i]);
            }

            gpa /= credits;

            return (gpa);
        }


        static void printWeight(int[] array)
        {
            Console.WriteLine("\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }

        static void printCourses(string [] array)
        {
            Console.WriteLine("\n");
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
