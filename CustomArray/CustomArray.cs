using System;
using System.Collections;
using System.Reflection;

namespace CustomArray
{
    public class CustomArray : IEnumerable
    {
        private object[] list;
        private int count;
        public int Capacity
        {
            get { return list.Length; }
        }
        public int Count
        {
            get { return count; }
        }

        public object this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }

        public CustomArray(int length = 1)
        {
            count = 0;
            list = new object[length];
        }

        public void Add(object item)
        {
            if (count == list.Length)
            {
                Array.Resize(ref list, list.Length * 2);
            }
            list[count++] = item;

        }

        public object GetItem(int index)
        {
            if (index < 0 || index >= list.Length)
            {
                Console.WriteLine("index out of range");
                return -1;
            }
            else
            {
                return list[index];
            }
        }

        public void Trim()
        {
            object[] temp = new object[count];
            Array.Copy(list, temp, count);
            list = temp;
        }

        public void Clear()
        {
            list = new object[1];
            count = 0;
        }

        public void InsertAt(int index, object item)
        {
            Array.Resize(ref list, list.Length * 2);
            object[] temp = new object[count + 1];

            for (int i = 0; i < count; i++)
            {
                temp[i] = list[i];
            }

            list[index] = item;
            for (int i = index + 1; i < temp.Length; i++)
            {
                list[i] = temp[i - 1];
            }

            count++;
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= list.Length)
            {
                Console.WriteLine("index out of range");
                return;
            }

            object[] temp = new object[list.Length + 1];

            for (int i = 0; i < list.Length; i++)
            {
                temp[i] = list[i];
            }


            for (int i = index; i < list.Length; i++)
            {
                list[i] = temp[i + 1];
            }
            count--;

        }


        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < list.Length; i++)
            {
                yield return list[i];
            }
        }

    }
}