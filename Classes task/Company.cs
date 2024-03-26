using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Задача_на_класи
{
    internal class Company
    {
        private string name; private int year;
        private string country; private string CEO;
        public int number_of_workers; public Company(string name, int year, string country, string CEO, int number_of_workers)
        {
            this.name = name;
            this.year = year; this.country = country;
            this.CEO = CEO; this.number_of_workers = number_of_workers;
        }
        public void Showinfo()
        {
            Console.WriteLine($"Company name:{name}");
            Console.WriteLine($"Year of foundation:{year}"); Console.WriteLine($"CEO of company:{CEO}");
            Console.WriteLine($"Company country:{country}"); Console.WriteLine($"Number of workers:{number_of_workers}");
        }
        public void Actualinfo(int num_wor)
        {
            int k; k = number_of_workers - num_wor;

            if (k == 0) Console.WriteLine($"the number has not changed"); if (k < 0) { Console.WriteLine($"the number of workers increased by {Math.Abs(k)}"); }
            if (k > 0) { Console.WriteLine($"the number of workers decreased by {Math.Abs(k)}"); }
            Console.WriteLine($"Number of workers {num_wor}\n");
            number_of_workers = num_wor;
        }
    }
}