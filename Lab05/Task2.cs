using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab05;

namespace Lab05
{
    class MyList<T> :IEnumerable<T>
    {
        private T[] array; 
        private int count; 

        // Конструктор по умолчанию
        public MyList()
        {
            array = new T[0]; 
            count = 0; 
        }
        // Метод Add добавляет элемент в список
        public void Add(T item)
        {
            Array.Resize(ref array, count + 1); 
            array[count] = item; 
            count++; 
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)array.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return array.GetEnumerator();
        }

        // Индексатор элементов в списке
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                    throw new IndexOutOfRangeException("Индекс вне диапазона");

                return array[index]; 
            }
        }
        // Свойство Count возвращает число элементов в списке
        public int Count
        {
            get { return count; } 
        }
    }
}
