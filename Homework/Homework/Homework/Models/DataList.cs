using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    public class DataList<T>
    {
        private T[] _arr;

        public DataList()
        {
            _arr = new T[0];
        }

        public void Add(T data)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = data;
        }

        public List<T> FindAll(Predicate<T> predicate)
        {
            List<T> list = new List<T>();

            foreach (var item in _arr)
            {
                if (predicate(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
    }
}
