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
            Item item3 = new Item();
            Item item4 = new Item();
            item.Init("독  니", "맹독", 1, 2, 0, 0, 0, 0);
            list.Add(item);
            item1.Init("방탄복", "철갑", 1, 0, 0, 2, 0, 0);
            list.Add(item1);
            item2.Init("운동화", "회피", 1, 0, 0, 0, 1, 0);
            list.Add(item2);
            item3.Init("프로틴", "분노", 1, 2, 0, 0, 0, 0);
            list.Add(item3);
            item4.Init("초록병", "광기", 1, 0, 0, 0, 0, 1);
            list.Add(item4);

        }
    }
}
