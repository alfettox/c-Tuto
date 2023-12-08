namespace WorkflowEngine
{
    internal class VideoUploader : ITask
    {
        void ITask.Exec()
        {
            Console.WriteLine("VIDEO ---> UPLOADED");
        }
    }
}