using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class ItemList
    {
        public List<Item> list = new List<Item>();
        public ItemList() 
        { 
            Item item = new Item();
            Item item1 = new Item();
            Item item2 = new Item();
            item.Init("독이빨", "맹독", 1, 2, 0, 0, 0, 0);
            list.Add(item);
            item1.Init("강철판", "철갑", 1, 0, 0, 2, 0, 0);
            list.Add(item1);
            item2.Init("드링크", "회피", 1, 0, 0, 0, 1, 0);
            list.Add(item2);
        }
    }
}
