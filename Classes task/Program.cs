using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using Задача_на_класи;
var Company = new Company(name: "Feel Good inc.", year: 1999, country: "USA", CEO: "Waldemar Von Braun", number_of_workers: 25);//оголошення класу "Company"
Company.Showinfo();//використання методу "Showinfo" для показу інформації
int num_wor=0;
int k;
    Company.Actualinfo(num_wor);//використання методу для оновлення інформації про кількість працівників
Company.Showinfo();
k = Convert.ToInt32(Console.ReadLine());

