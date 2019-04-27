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
            if (_stack is null)
                throw new InvalidOperationException();

            var last = _stack[_stack.Count - 1] as object;
            _stack.Remove(_stack[_stack.Count - 1]);
            return last;
        }
    }
}
