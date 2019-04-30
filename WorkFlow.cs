using System;
using System.Collections.Generic;

namespace PropertyDemo
{
    public class WorkFlow : IWorkFlow
    {
        private readonly List<ITask> _tasks;

        public WorkFlow()
        {
            _tasks = new List<ITask>();
        }

        public void Add(ITask task)
        {
            if (task == null)
                throw new InvalidOperationException("Invalid Task!");

            _tasks.Add(task);
        }

        public void Remove(ITask task)
        {
            if (task == null || !_tasks.Contains(task))
                throw new InvalidOperationException();

            _tasks.Remove(task);
        }

        // using IEnumerable to return a read only list 
        // so consumer of this class can NOT access the private field _task
        // can only access the list via public Add() and Remove()
        public IEnumerable<ITask> GetTasks()    
        {
            return _tasks;
        }
    }
}
