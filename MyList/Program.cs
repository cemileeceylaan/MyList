using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> odevDosyalari = new MyDictionary<int, string>();
            odevDosyalari.Add(100, "Cemile Ceylan");
            odevDosyalari.Add(101, "Aslı Kurt");
            odevDosyalari.Add(102, "Bahadır Aydın");
            odevDosyalari.Add(103, "Metin Kıyar");

        }
    }
    class MyDictionary<TKey, TValue>
    {
        TKey[] array_keys;
        TValue[] array_values;
      
        public MyDictionary()
        {
            array_keys = new TKey[0];
            array_values = new TValue[0];
        }
        public void Add(TKey key, TValue value)
        {
            TKey[] tempKey = array_keys;
            TValue[] tempValue = array_values;
            array_keys = new TKey[array_keys.Length + 1];
            array_values = new TValue[array_values.Length + 1];

            for (int i = 0; i < tempKey.Length; i++)
            {
                array_keys[i] = tempKey[i];
                array_values[i] = tempValue[i];
            }
            array_keys[array_keys.Length - 1] = key;
            array_values[array_values.Length - 1] = value;
            Console.WriteLine("Eklendi");
        }
    }
}