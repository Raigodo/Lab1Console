
using Lab1Library;

const string ViewStudents = "all";
const string SetPath = "path";
const string AddStudent = "add";
const string Exit = "x";

var cmd = string.Empty;
var path = string.Empty;
while(true)
{
    Console.Write("command: ");
    cmd = Console.ReadLine();

    if (cmd == SetPath)
    {
        Console.Write("input path: ");
        path = Console.ReadLine() ?? StudentsData.DefaultFilename;
    }

    else if (cmd == ViewStudents) 
        PrintAll(path);

    else if (cmd == AddStudent)
        AddOne(path);

    else if (cmd == Exit)
        break;
}


void PrintAll(string fileName)
{
    try
    {
        var studData = new StudentsData();
        studData.Load(fileName);
        foreach (var stud in studData.Students)
            System.Console.WriteLine(stud);
    }
    catch (Exception ex)
    {
        System.Console.WriteLine(ex.Message);
    }
}

void AddOne(string fileName)
{
    Console.Write("Id: ");
    var id = Console.ReadLine() ?? string.Empty;

    Console.Write("Name: ");
    var name = Console.ReadLine() ?? string.Empty;

    Console.Write("Surname: ");
    var surname = Console.ReadLine() ?? string.Empty;

    Console.Write("Email: ");
    var email = Console.ReadLine() ?? string.Empty;

    var student = new Student(name, surname, email, id);

    try
    {
        var studData = new StudentsData();
        studData.Load(fileName);
        studData.Students.Add(student);
        studData.Save(fileName);
    }
    catch (Exception ex)
    {
        System.Console.WriteLine(ex.Message);
    }
}

