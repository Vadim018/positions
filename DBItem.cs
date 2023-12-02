using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace CCL1
{
    class DBItem<P> where P : IID
    {
        private int count = 1;
        public List<P> Items { get; set; }
        public DBItem()
        {
            this.Items = new List<P>();
        }
        public void AddItem(P item)
        {
            item.Id = count++;
            Items.Add(item);
        }
        public P FindById(int id)
        {
            P result = default(P);
            foreach (P item in Items)
            {
                if (item.Id == id)
                {
                    result = item;
                    break;
                }
            }
            return result;
        }
        public bool Delete(P item)
        {
            bool result = false;
            result = Items.Remove(item);
            return result;
        }
    }
}