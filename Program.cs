using System;
using System.IO;

namespace FileIODemo
{
    class Student
    {
        internal void StudentDetails(string StudentID, string Studentname, int StudentMarks)
        {
            FileStream Fs = new(@"C:\Users\acer\Desktop\\myfile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(Fs);
            Console.WriteLine(Studentname);
            Console.WriteLine(StudentID);
            Console.WriteLine(StudentMarks);
            sw.Write(StudentID);
            sw.Write(Studentname);
            sw.Write(StudentMarks);


            //sw.BaseStream.Seek(0, SeekOrigin.Begin);
            //sw.Flush();
            sw.Close();
        }

        class Program
        {


            static void Main(string[] args)
            {
                int i = 0, StudentMarks;
                string StudentID;
                string Studentname;
                char res;


                do
                {
                    i++;


                    Console.WriteLine("Enter The studentID {0} :", i);
                    StudentID = Console.ReadLine();
                    Console.WriteLine("Enter The Name {0}:", i);
                    Studentname = Console.ReadLine();
                    Console.WriteLine("Enter The Marks {0}:", i);
                    StudentMarks = Convert.ToInt32(Console.ReadLine());
                    

                    Student s = new Student();
                    s.StudentDetails(StudentID, Studentname, StudentMarks);
                    Console.WriteLine("Do you want to Continue:y/n");
                    res = Convert.ToChar(Console.ReadLine());


                }
                while (res =='y' );



            }


        }
    }
}
