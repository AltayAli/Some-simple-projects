using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Card_App
{
    class BasketItem
    {
        public Phone phone;
        public int count;
    }

    static class Basket
    {
        public static  BasketItem[] basketItem;
        public static  int counter;

         static Basket()
        {
            basketItem = new BasketItem[0];
            
    }
        public static void Add(BasketItem item)
        {
            if (basketItem.Length <= counter)
            {
                Array.Resize(ref basketItem, basketItem.Length + 2);
            }
            int index = HasElementInArray(item, basketItem);
            if(index==-1)
            {
                
                basketItem[counter] = item;
                counter++;
            }
            else
            {
                basketItem[index].count++;
                
            }
        }

        public static int HasElementInArray(BasketItem item, BasketItem[] basketItem)
        {
            int isHere = -1;
           
            for(int i = 0; i<basketItem.Length;i++)
            {
               
                if (basketItem[i]!=null&&basketItem[i].phone.Name == item.phone.Name)
                {
                    isHere = i;
                    break;
                }
            }
            return isHere;
        }
    }
}
