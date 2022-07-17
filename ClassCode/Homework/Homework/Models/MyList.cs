﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Models
{
    public class MyList<T>
    {
        private T[] _arr;

        public int Count { get; set; }

        public MyList()
        {
            _arr = new T[0];
        }

        public void Add(T data)
        {
            if (Count % 10 == 0)
            {
                Array.Resize(ref _arr, _arr.Length + 10);
            }
            _arr[Count] = data;
            Count++;
        }

        public void GetAll()
        {
            foreach (var item in _arr)
            {
                Console.WriteLine();
            }
           
        }

        public void Clear()
        {
            _arr = new T[10];
        }

        public void AddRange(List<T> datas)
        {
            foreach (var item in datas)
            {
                Add(item);
            }
        }

        public T Find(Predicate<T> predicate)
        {
            foreach (var item in _arr)
            {
                if (predicate(item))
                {
                    return item;
                }
            }
            return default;
        }
    }
}
