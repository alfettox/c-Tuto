namespace WorkflowEngine
{
    internal class SendEMail : ITask
    {
        public void Exec()
        {
            Console.WriteLine("EMAIL ----> SENT");
        }
    }
}