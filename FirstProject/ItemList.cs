using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProject
{
    public class ItemList
    {
        // 존재하는 모든 아이템 리스트
        public List<Item> list = new List<Item>();
        public ItemList()
        {
            Item item = new Item();
            Item item1 = new Item();
            Item item2 = new Item();
            Item item3 = new Item();
            Item item4 = new Item();

            Item item5 = new Item();
            Item item6 = new Item();
            Item item7 = new Item();
            Item item8 = new Item();
            Item item9 = new Item();
            item.Init("독  니", "맹독", 1, 2, 0, 0, 0, 0);
            item1.Init("방탄복", "철갑", 1, 0, 0, 2, 0, 0);
            item2.Init("운동화", "회피", 1, 0, 0, 0, 2, 0);
            item3.Init("프로틴", "분노", 1, 0, 30, 0, 0, 0);
            item4.Init("초록병", "광기", 1, 0, 0, 0, 0, 2);

            item5.Init("누더기", null, 0, 0, 0, 1, 0, 0);
            item6.Init("슬리퍼", null, 0, 0, 0, 0, 1, 0);
            item7.Init("송곳니", null, 0, 0, 0, 0, 0, 1);
            item8.Init("부엌칼", null, 0, 1, 0, 0, 0, 0);
            item9.Init("비타민", null, 0, 0, 15, 0, 0, 0);
            list.Add(item);
            list.Add(item1);
            list.Add(item2);
            list.Add(item3);
            list.Add(item4);

            list.Add(item5);
            list.Add(item6);
            list.Add(item7);
            list.Add(item8);
            list.Add(item9);
        }
    }
}
