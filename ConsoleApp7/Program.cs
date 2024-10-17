using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Employee
    {
        private string fio;
        private string birth_date;
        private int phone;
        private string email;
        private string post;
        private string official_duties;

        public string Fio
        {
            get { return fio; }
            set { fio = value; }
        }

        public string Birth_date
        {
            get { return birth_date; }
            set { birth_date = value; }
        }

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Post
        {
            get { return post; }
            set { post = value; }
        }

        public string Official_duties
        {
            get { return official_duties;}
            set { official_duties = value;}
        }

        public Employee()
        {
            Console.WriteLine("New employee is add! Please, add some information!");
        }
        public Employee(string fio, string birth_date, int phone, string email, string post, string official_duties)
        {
            this.fio = fio;
            this.birth_date = birth_date;
            this.phone = phone;
            this.email = email;
            this.post = post;
            this.official_duties = official_duties;
        }

        public void AddInf()
        {
            Console.Write("Enter employee`s fio: ");
            this.Fio = Console.ReadLine();

            Console.Write("Enter employee`s birth date: ");
            //int day, month, year = 0;
            Console.Write("Enter day: ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Enter month: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());

            this.Birth_date = $"{day}/{month}/{year}";

            Console.Write("Enter employee`s phone number: ");
            this.Phone = int.Parse(Console.ReadLine());

            Console.Write("Enter employee`s email: ");
            this.Email = Console.ReadLine();

            Console.Write("Enter employee`s post: ");
            this.Post = Console.ReadLine();

            Console.Write("Enter employee`s official duties: ");
            this.Official_duties = Console.ReadLine();
        }

        public void ShowInf()
        {
            Console.WriteLine($"FIO: {this.Fio}");
            Console.WriteLine($"Birth date: {this.Birth_date}");
            Console.WriteLine($"Phone number: {this.Phone}");
            Console.WriteLine($"Email: {this.Email}");
            Console.WriteLine($"Post: {this.Post}");
            Console.WriteLine("---------------------");
            Console.WriteLine($"Official duties: {this.Official_duties}");
        }
    }
}
