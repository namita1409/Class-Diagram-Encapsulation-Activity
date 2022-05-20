
using EncapsulationActivity.Models;

Console.WriteLine("Welcome to the school!");

Student student = new Student("Namita", GRADE.B, 3);
Console.WriteLine(student.Grade);
if (student.Grade == GRADE.B)
    student.Grade = GRADE.A;
if (student.Grade == GRADE.C)
    student.Grade = GRADE.A;

Console.WriteLine(student.Group);
Console.WriteLine(student.Grade);
