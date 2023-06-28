// See https://aka.ms/new-console-template for more information



using Linq.Core;

// Using Method Syntax
List<string> MethodSyntax = Student.GetStudents()
    .SelectMany(std => std.Programming)
    .Distinct()
    .ToList();

// Using Query Syntax
IEnumerable<string> QuerySyntax = from std in Student.GetStudents()
    from program in std.Programming
    select program;

foreach (string program in MethodSyntax)
{
    Console.WriteLine(program);
}    

// Advance Select 
var MethodSyntax1 = Student.GetStudents()
        .SelectMany(std => std.Programming,
        (student, program) => new
        {
            StudentName = student.Name,
            ProgramName = program 
        }).ToList();

foreach (var item in MethodSyntax1)
{
    Console.WriteLine(item.StudentName + " => " + item.ProgramName);
}        