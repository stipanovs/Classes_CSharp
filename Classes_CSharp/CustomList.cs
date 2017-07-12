﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_CSharp
{
    public class CustomsList<T> : IEnumerable<T>
    {
        private const int maxSize = 100;
        private int _index = 0;
        private T[] _arr;
        
        public CustomsList()
        {
            _arr = new T[maxSize];
        }

        
        public void Add(T item)
        {
            if (_index >= maxSize)
            {
                DoubleAraySize();
            }

            _arr[_index] = item;
            _index++;
        }

        private void DoubleAraySize()
        {
            int doubleSize = maxSize * 2;
            T[] newArr = new T[doubleSize];

            for(int i=0; i< _index; i++)
            {
                newArr[i] = _arr[i];
            }
            _arr = newArr;

        }

        public void SetItemAtIndex(T item, int index)
        {
            _index++;
            for (int i = _index; i >= index; i--)
            {
                _arr[i + 1] = _arr[i];
                
            }
            _arr[index] = item;
        }

        public void SwapItemByIndex(int ind1, int ind2)
        {
            T temp = _arr[ind1];
            _arr[ind1] = _arr[ind2];
            _arr[ind2] = temp;
        }

        public void SwapItemByItem<T>(T item1, T item2)
        {
            int index1 = -1, index2 = -1;
           
            for (int i = 0; i < _index; i++)
            {
                if (_arr[i].Equals(item1)) index1 = i;
                if (_arr[i].Equals(item2)) index2 = i;
            }
            if(index1 != -1 & index2 != -1) SwapItemByIndex(index1, index2);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for(int i=0; i < _index;i++)
            {
                yield return _arr[i];
            }
        }
        public T GetItemByIndex(int index)
        {
            return _arr[index];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}