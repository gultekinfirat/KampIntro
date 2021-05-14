using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        public MyList()// Constructor. Bir yerde snıf yenilenirse bu blok otomatik çalışır.
        {
            items = new T[0];
        }

        public void Add(T item)// string türünde bir eleman ver demiş olduk.
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];// Dizinin eleman sayısı 1 arttırıldı.
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;  

        }
    }
}
