using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssistedProjects_Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
             
            Subject algebra = new Subject();
            algebra.Name = "Algebra";

            Subject physics = new Subject();
            physics.Name = "Physics";

            SubjectTeacher algebraTeacher = new SubjectTeacher();
            algebraTeacher.Name = "Mr.Algebra";
            algebraTeacher.ContactAddress = "Some Address";
            algebraTeacher.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            algebraTeacher.WhichSubject = algebra;

            SubjectTeacher physicsTeacher = new SubjectTeacher();
            physicsTeacher.Name = "Mr.Physics";
            physicsTeacher.ContactAddress = "Some Address";
            physicsTeacher.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            physicsTeacher.WhichSubject = physics;

            CClass class8 = new CClass();
            class8.Name = "8";

            ClassTeacher teacherOf8 = new ClassTeacher();
            teacherOf8.Name = "Mrs.Class 8 Teachers";
            teacherOf8.ContactAddress = "Some Address";
            teacherOf8.DateOfJoining = Convert.ToDateTime("2009-10-20 00:00:00");
            teacherOf8.WhichClass = class8;

            class8.WhichTeacher = teacherOf8;

            // Print information about subjects
            Console.WriteLine("Subject Name: " + algebra.Name);
            Console.WriteLine("Subject Name: " + physics.Name);

            // Print information about subject teachers
            Console.WriteLine("Subject Teacher: " + algebraTeacher.Name + " - Subject: " + algebraTeacher.WhichSubject.Name);
            Console.WriteLine("Subject Teacher: " + physicsTeacher.Name + " - Subject: " + physicsTeacher.WhichSubject.Name);

            // Print information about the class and its teacher
            Console.WriteLine("Class: " + class8.Name);
            Console.WriteLine("Class Teacher: " + teacherOf8.Name);

            // Print additional information if needed

            // End of the method
            Console.WriteLine("Program execution completed.");

            Console.ReadLine();

        }
    }

}
