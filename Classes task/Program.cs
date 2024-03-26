using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using Задача_на_класи;
var Company = new Company(name: "Feel Good inc.", year: 1999, country: "USA", CEO: "Waldemar Von Braun", number_of_workers: 25);//оголошення класу "Company"
Company.Showinfo();//використання методу "Showinfo" для показу інформації
int num_wor;
int k;



    Console.WriteLine("How many people curently work?");//ввід актуальної кількості працівників компанії
    num_wor = Convert.ToInt32(Console.ReadLine());
    if (num_wor < 0)
    {
        do
        {
            Console.WriteLine("Incorrect data, try again" + "\n");
            num_wor = Convert.ToInt32(Console.ReadLine());
        } while (num_wor < 0);
    }
    Company.Actualinfo(num_wor);//використання методу для оновлення інформації про кількість працівників
    Console.WriteLine("press 0 to end program, press 1 to continue");
    k = Convert.ToInt32(Console.ReadLine());

