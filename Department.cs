using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CCL1
{
    class Department
    {
        DBItem<Position> pos;
        public Department(DBItem<Position> pos)
        {
            this.pos = pos;
        }
        public void CreatePosition()
        {
            Console.Write("NAME: ");
            string title = Console.ReadLine();

            Console.Write("PRICE: ");
            int salary = Convert.ToInt32(Console.ReadLine());

            Position position = new Position(title, salary);
            pos.AddItem(position);
        }
        public void DeletePosition()
        {
            Console.WriteLine("TO DELETE THE POSITION, ENTER ID: ");
            int d = int.Parse(Console.ReadLine());

            Position position = pos.FindById(d);
            bool deletedposition = pos.Delete(position);

            Console.WriteLine("THIS POSITION IS DELETED!");
        }
        public void FindPosition()
        {
            Console.WriteLine("ENTER ID: ");
            int f = int.Parse(Console.ReadLine());

            Position foundPosition = pos.FindById(f);
            Console.WriteLine(foundPosition);
        }
    }
}