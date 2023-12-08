namespace WorkflowEngine
{
    public class WorkflowEngine
    {

        public void RunAll(IWorkflow wf)
        {
            if (wf == null)
            {
                throw new Exception("EMPTY");
            }
            foreach (var task in wf.GetTasks())
            {
                try
                {
                    task.Exec();
                }
                catch (Exception)
                {
                    throw new Exception("ERROR");
                }
            }
        }

    }
}