using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab05
{
    public class MyDictionary<TKey, TValue> : IDictionary<TKey, TValue>
    {
        private Dictionary<TKey, TValue> dictionary;
        // Конструктор 
        public MyDictionary()
        {
            dictionary = new Dictionary<TKey, TValue>();
        }
        // Индексатор
        public TValue this[TKey key]
        {
            get { return dictionary[key]; }
            set { dictionary[key] = value; }
        }
        // Свойство Count возвращает общее число элементов
        public int Count
        {
            get { return dictionary.Count; }
        }
        // Проверка на "доступ для чтения"
        public bool IsReadOnly
        {
            get { return false; }
        }
        // Возвращает Ключ
        public ICollection<TKey> Keys
        {
            get { return dictionary.Keys; }
        }
        // Возвращает значение
        public ICollection<TValue> Values
        {
            get { return dictionary.Values; }
        }
        // Метод Add добавляет элемент
        public void Add(TKey key, TValue value)
        {
            dictionary.Add(key, value);
        }
        // Добавление объекта
        public void Add(KeyValuePair<TKey, TValue> item)
        {
            ((ICollection<KeyValuePair<TKey, TValue>>)dictionary).Add(item);
        }
        // Удаляет все элементы
        public void Clear()
        {
            dictionary.Clear();
        }
        // Проверка на включение элемента
        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            return ((ICollection<KeyValuePair<TKey, TValue>>)dictionary).Contains(item);
        }
        // Проверка на включение ключа
        public bool ContainsKey(TKey key)
        {
            return dictionary.ContainsKey(key);
        }
        // Копирует элементы в массив
        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
        {
            ((ICollection<KeyValuePair<TKey, TValue>>)dictionary).CopyTo(array, arrayIndex);
        }
        // Перебирает элементы
        public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
        {
            return dictionary.GetEnumerator();
        }
        // Удаляет ключ (успех - true)
        public bool Remove(TKey key)
        {
            return dictionary.Remove(key);
        }
        // Удаляет первое вхождение (успех - true)
        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            return ((ICollection<KeyValuePair<TKey, TValue>>)dictionary).Remove(item);
        }
        // Возвращает значение по ключу
        public bool TryGetValue(TKey key, out TValue value)
        {
            return dictionary.TryGetValue(key, out value);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)dictionary).GetEnumerator();
        }
    }
}
