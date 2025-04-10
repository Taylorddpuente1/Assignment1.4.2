
using System;
using System.Security.Cryptography.X509Certificates;

class Student
{
    //Private data members
    private int studentID;
    private string studentFname;
    private string studentLname;
    private char studentGrade;

    //Public Propeties
    public int StudentID
    {
        get { return studentID; }
        set { studentID = value; }
    }
    public string StudentFname
    {
        get { return studentFname; }
        set { studentFname = value; }

    }

    public string StudentLname
    {
        get { return studentLname; }
        set { studentLname = value; }
    }

    public char StudentGrade
    {
        get { return studentGrade; }
        set { studentGrade = value; }
    }
}
class Program
{
    static void Main()
    {
        Student myStudent = new Student();

        // Ask user for data
        Console.WriteLine("Enter student ID: ");
        myStudent.StudentID = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter student First Name: ");
        myStudent.StudentFname = Console.ReadLine();

        Console.WriteLine("Enter student Last Name: ");
        myStudent.StudentLname = Console.ReadLine();


        Console.WriteLine("Enter student Grade: ");
        myStudent.StudentGrade = Convert.ToChar(Console.ReadLine());

        //Display Information
        Console.WriteLine("~~Student Information~~");
        Console.WriteLine("ID: " + myStudent.StudentID);
        Console.WriteLine("First Name: " + myStudent.StudentFname);
        Console.WriteLine("Last Name: " + myStudent.StudentLname);
        Console.WriteLine("Grade: " + myStudent.StudentGrade);
    }
}