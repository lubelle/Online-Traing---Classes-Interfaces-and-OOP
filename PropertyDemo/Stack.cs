using System;
using System.Collections.Generic;

namespace PropertyDemo
{
    public class Stack
    {
        private readonly List<object> _stack = new List<object>();

        public void Push(object obj)
        {
            if(obj is null)
                throw new InvalidOperationException();

            _stack.Add(obj);
        }

        public object Pop()
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException();

            var index = _stack.Count - 1;
            var last = _stack[index];
            _stack.RemoveAt(index);
            return last;
        }

        public void Clear()
        {
            _stack.Clear();
        }
    }
}
