using System;
using System.Collections;

namespace CSharp.Inheritance
{
    public class Stack
    {
        private ArrayList _list;
        private int index;
        public Stack()
        {
            _list = new ArrayList();
            index = -1;
        }
        public void Push(object obj)
        {
            if (obj == null)
                throw new InvalidOperationException();

            _list.Add(obj);
            index++;
        }

        public object Pop()
        {
            var item = _list[index];
            _list.RemoveAt(index);
            index--;
            return item;
        }

        public void Clear()
        {
            index = -1;
            _list.Clear();
        }
    }
}