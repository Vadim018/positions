using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace CCL1
{
    class Position : IID    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int Salary { get; set; }
       
        public Position(string title, int salary)
        {
            Title = title;
            Salary = salary;
        }
        public override string ToString()
        {
            return String.Format("ID: " + Id + " " + "POSITION: " + Title + " " + "PRICE: " + Salary);
        }
    }
}