using System;

namespace CSharp.Generics
{
    public class GenericList<T>
    {
        public void Add(T value)
        {

        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }

    public class GenericDictionary<TKey, TValue>
    {
        public void Add(TKey key, TValue value)
        {

        }
    }

    /*
        Types of constraints
        where T : IComparable (interface)
        where T : Product (especific class and its children)
        where T : struct (value type)
        where T : class (reference type)
        where T : new() (object that has constructor)
    */
    public class Utilities<T> where T : IComparable, new()
    {
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }
    }

    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            return product.Price;
        }
    }

    public class Product
    {
        public string Title { get; set; }
        public float Price { get; set; }
    }

    public class Book : Product
    {
        public string ISBN { get; set; }
    }

    public class Nullable<T> where T : struct
    {
        private readonly object _value;
        public Nullable() { }
        public Nullable(T value)
        {
            _value = value; // Boxing

        }
        public bool HasValue
        {
            get { return (_value != null); }
        }

        public T GetValueOrDefault()
        {

            if (HasValue)
                return (T)_value; // Unboxing

            return default(T);
        }
    }
}