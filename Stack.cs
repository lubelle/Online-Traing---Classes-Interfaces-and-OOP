using System;
using System.Collections.Generic;

namespace PropertyDemo
{
    public class Stack
    {
        private List<object> _stack = new List<object>();

        public void Push(object obj)
        {
            if(obj is null)
                throw new InvalidOperationException();

            _stack.Add(obj);
        }

        public object Pop()
        {
            if (_stack.Count <= 0)
                throw new InvalidOperationException();

            var last = _stack[_stack.Count - 1] as object;
            _stack.Remove(_stack[_stack.Count - 1]);
            return last;
        }

        public void Clear()
        {
            if (_stack.Count <= 0)
                throw new InvalidOperationException();

            for (var i = 0; i < _stack.Count; i++)
            {
                _stack.Remove(_stack[i]);
            }
        }
    }
}
