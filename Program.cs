using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CCL1
{
    class Program
    {
        static void Main(string[] args)
        {
            DBItem<Position> pos = new DBItem<Position>();

            Position pos1 = new Position("DEVELOPER", 7000);
            pos.AddItem(pos1);

            Position pos2 = new Position("MANAGER", 3500);
            pos.AddItem(pos2);

            Position pos3 = new Position("COOKER", 4000);
            pos.AddItem(pos3);

            Department dep = new Department(pos);

            Console.WriteLine("******************************");
            Console.Write("CREATE POSITION \n");
            Console.WriteLine("******************************");
            dep.CreatePosition();

            Console.WriteLine("******************************");
            Console.WriteLine("LIST OF POSITIONS: ");

            foreach (Position p in pos.Items)
            {
                Console.WriteLine(p);
            }
            dep.FindPosition();
            dep.DeletePosition();

            Console.WriteLine("LIST OF POSITIONS: ");
            Console.WriteLine("******************************");
            foreach (Position p in pos.Items)
            {
                Console.WriteLine(p);
            }
            Console.ReadLine();
        }
    }
}