using CSharp.Interfaces;

namespace CSharp.Exec
{
    public class WorkflowEngineExec : IExecutable
    {
        public void Execute()
        {
            var engine = new WorkflowEngine();
            var workflow = new Workflow();
            workflow.AddActivity(new VideoUploader());
            workflow.AddActivity(new WebServiceConnection());
            workflow.AddActivity(new SendMail());
            workflow.AddActivity(new VideoProcessor());
            engine.Run(workflow);
        }
        
    }
}