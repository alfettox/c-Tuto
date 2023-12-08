using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkflowEngine
{
    internal class SpeedyWorkflow : IWorkflow
    {
        private List<ITask> _tasks;

        public SpeedyWorkflow()
        {
            _tasks = new List<ITask>();
        }

        public void addTask(ITask task)
        {
            _tasks.Add(task);
        }

        public void removeTask(ITask task)
        {
            _tasks.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()    //avoid using List enumerable will protect add remove methods
        {
            IEnumerable<ITask> enumTasks = _tasks;
            return _tasks.ToList();
        }
    }
}
  