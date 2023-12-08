
namespace WorkflowEngine
{
    public interface IWorkflow
    {
        void addTask(ITask task);
        IEnumerable<ITask> GetTasks();
        void removeTask(ITask task);
    }
}