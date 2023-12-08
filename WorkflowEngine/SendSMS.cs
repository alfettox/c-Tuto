namespace WorkflowEngine
{
    internal class SendSMS : ITask
    {
        public void Exec()
        {
            Console.WriteLine("SMS ---> SENT");
        }
    }
}