// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//
//int nuum1 = 5;
//int num2 = 10;
//
//double num3 = 9.7;
//
//Console.WriteLine(Math.Round(num3));


//Console.WriteLine("-----student 1 ------");
//  
//Console.Write("Name : ");
//
//int Weight = Console.ReadLine();
//
//Console.WriteLine(" :{0}", Weight);



/*double x = 7;
Console.WriteLine(x = 3);
x = 7;
Console.WriteLine(x += 3);
x = 7;
Console.WriteLine(x -= 3);
x = 7;
Console.WriteLine(x *= 3);
x = 7;
Console.WriteLine(x /= 3);
x = 7;
Console.WriteLine(x %= 3);
x = 7; */



//string Role = "Admin";

//if (Role == "Admin")
//{

//    Console.WriteLine("Admin");  
//}
//else if (Role == "Admin1")
//{

//}


//else
//{
//    Console.WriteLine("Not Admin");
//}


/*string Role = "Admin";

switch (Role)
{
    case "Admin":
        Console.WriteLine("Admin");
        break;
    case "User":
        Console.WriteLine("Welcome User you can use some feature");
        break;
    default:
        Console.WriteLine("not admin");
        break;
}*/







/*float salary = Console.ReadLine();


switch (salary)
{
    case "Assistant Developer":
        Console.WriteLine()

}*/



/*Console.WriteLine("Your Position :");
string Position = Console.ReadLine();


Console.WriteLine("Your Salary :");
float Salary = float.Parse(Console.ReadLine());

switch (Position)
{
    case "Assistant Developer":
        Salary *= 1.05f;
        break;
    case "IT Support":
        Salary *= 1.07f;
        break;
    case "Senior Developer":
        Salary *= 1.1f;
        break;
    case "Administrator":
        Salary *= 1.08f;
        break;
    default:
        Salary *= 1.03f;
        break;
}
Console.WriteLine($"Your Salary = {Math.Round(Salary)} "); */



/*string[] cars = new string[] {"ford","toyota","hoda"};

Array.Resize(ref cars, 4);

cars[3] = "BMW";

foreach (string car in cars)
{
    Console.WriteLine(cars.Length);
}


 Console.WriteLine("-----------------------");
Array.Sort(cars);

foreach (string car in cars)
{ 
    Console.WriteLine(cars.Length);
}

Console.WriteLine("-----------------------");
Array.Reverse(cars);


foreach (string car in cars)
{
    Console.WriteLine(cars.Length);
}

string[] cars2 = new string[4];
Console.WriteLine("-----------------------");
Array.Copy(cars, cars2, 3);
foreach (string car in cars2)
{
    Console.WriteLine(cars.Length);
}

Console.WriteLine("---------------");
Console.WriteLine(Array.IndexOf(cars2,"ford"));

Console.WriteLine("---------------");
Console.WriteLine(Array.IndexOf(cars2, "ford"));  */

/*List<int> ListNumber = new List<int>(); 

foreach(int n in ListNumber)
{
    Console.WriteLine(n);
}
Console.WriteLine("---------------");
ListNumber.Add(0);
ListNumber.Add(1);

foreach(int n in ListNumber)
{
    Console.WriteLine(n);
}

if (ListNumber.Contains(1))

ListNumber.Add */



















/*using System;

class Program
{
    static void Main(string[] args)
    {
        int numStudents;
        do
        {
            Console.Write("Enter number of students: ");
        } while (!int.TryParse(Console.ReadLine(), out numStudents) || numStudents <= 0);

        string[] studentIDs = new string[numStudents];
        double[] studentScores = new double[numStudents];

        for (int i = 0; i < numStudents; i++)
        {
            Console.Write($"Enter student ID for student {i + 1}: ");
            string id = Console.ReadLine();
            studentIDs[i] = id;

            double score;
            do
            {
                Console.Write($"Enter score for student {i + 1}: ");
            } while (!double.TryParse(Console.ReadLine(), out score) || score < 0 || score > 100);
            studentScores[i] = score;
        }

        char input;
        do
        {
            Console.Write("Exit? (Y/N): ");
            input = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();
        } while (input != 'Y' && input != 'N');

        if (input == 'Y')
        {
            Console.WriteLine("Student Data:");
            for (int i = 0; i < numStudents; i++)
            {
                Console.WriteLine($"Student ID: {studentIDs[i]}, Score: {studentScores[i]}");
            }
        }
        else
        {
            Main(args);
        }
    }
}*/



public class Student
{
    private string sex;
    private int age;
    public string Sex { get { return sex; } set { sex = value; } }
    public int Age { get { return age; } set { age = value; } }
    public virtual int Run()
    {
        return Age * 2;
    }
}


public class Jarb : Student
{
    public Jarb(string sex, int age)
    {
        Sex = sex;
        Age = age;
    }

    public override int Run()
    {
        return Age + 3;
    }
}

public class Karn : Student
{
    public Karn(string sex, int age)
    {
        Sex = sex;
        Age = age;
    }

}

public class Program
{
    public static void Main()
    {
        Jarb jarb = new Jarb("Male", 20);
        Karn karn = new Karn("Male", 22);

        int jarbRun = jarb.Run();
        int karnRun = karn.Run();

        Console.WriteLine($"Jarb age : {jarbRun}");
        Console.WriteLine($"Karn age : {karnRun}");
    }
}










