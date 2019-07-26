using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace _3_Dynamic_Array
{
    public class DynamicArray<T> : IEnumerable<T>
    {
        private T[] dynamicArray;
        public int Capacity { get; set; }
        public int length = 0;

        public int Length
        {
            get
            {
                var ArrayEnumerator = dynamicArray.GetEnumerator();
                while (ArrayEnumerator.MoveNext() && ArrayEnumerator.Current != default)
                    length += 1;
                return length;
            }
            set { }
        }

        public DynamicArray()
        {
            Capacity = 8;
            dynamicArray = new T[Capacity];
        }

        public DynamicArray(int capacity)
        {
            Capacity = capacity;
            dynamicArray = new T[Capacity];
        }

        public void Add(T elem)
        {
            if (Length > Capacity)
                DoubleCapacity();

            dynamicArray[Length + 1] = elem;
        }

        private void DoubleCapacity()
        {
            var temp = new T[Capacity * 2];
            dynamicArray.CopyTo(temp, 0);
            dynamicArray = temp;
        }

        public bool Remove(int index)
        {
            if (!IndexCheck(index))
                return false;

            for (var i = index; i < Length - 1; i++)
                dynamicArray[i] = dynamicArray[i + 1];

            Length--;
            return true;
        }

        private bool IndexCheck(int index) => index < Length && index >= 0;

        public bool Insert(T element, int index)
        {
            if (!IndexCheck(index))
                throw new ArgumentOutOfRangeException();

            var tmp = dynamicArray[Length - 1];

            for (var i = Length - 1; i > index; i--)
                dynamicArray[i] = dynamicArray[i - 1];

            dynamicArray[index] = element;
            Add(tmp);
            return true;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (var i = 0; i < Length; i++)
            {
                yield return dynamicArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        private static int SomeCollectionLength(IEnumerable<T> someCollection)
        {
            var someCollectionEnumerator = someCollection.GetEnumerator();
            int CollLength = 0;

            while (someCollectionEnumerator.MoveNext())
                CollLength++;

            return CollLength;
        }

        public DynamicArray(IEnumerable<T> someCollection)
        : this(SomeCollectionLength(someCollection))
        {
            var someCollectionEnumerator = someCollection.GetEnumerator();

            for (int i = 0; i < SomeCollectionLength(someCollection); i++)
            {
                someCollectionEnumerator.MoveNext();
                dynamicArray[i] = someCollectionEnumerator.Current;
            }

        }

        public void AddRange(IEnumerable<T> elems)
        {

            var elemsLength = SomeCollectionLength(elems);

            while (elemsLength + this.Length > this.Capacity)
                DoubleCapacity();

            var elemsEnumerator = elems.GetEnumerator();
            elemsEnumerator.Reset();

            for (int i = 0; i < elemsLength; i++)
            {
                elemsEnumerator.MoveNext();
                dynamicArray[Length + i] = elemsEnumerator.Current;
            }

            Length += elemsLength;
        }

        public T this[int index]
        {
            get
            {
                if (!IndexCheck(index))
                {
                    throw new ArgumentOutOfRangeException();
                }

                return dynamicArray[index];
            }

            set
            {
                if (!IndexCheck(index))
                {
                    throw new ArgumentOutOfRangeException();
                }

                dynamicArray[index] = value;
            }
        }
    }
}

