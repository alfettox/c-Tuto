namespace WorkflowEngine
{
    class Program
    {
        public static void Main(string[] args) {
            Workflow wf = new Workflow();
            wf.addTask(new VideoUploader());
            wf.addTask(new SendSMS());
            wf.addTask(new SendEMail());

            SpeedyWorkflow speedyWf = new SpeedyWorkflow();
            speedyWf.addTask(new SendSMS());
            speedyWf.addTask(new SendSMS());

            var wfEngine = new WorkflowEngine();
            wfEngine.RunAll(wf);
            wfEngine.RunAll(speedyWf);

            Console.ReadKey();
        }
    }
}