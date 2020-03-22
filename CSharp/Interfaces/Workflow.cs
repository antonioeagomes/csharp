using System.Collections.Generic;

namespace CSharp.Interfaces
{
    public class Workflow
    {
        private readonly List<IActivity> _activities;

        public Workflow()
        {
            _activities = new List<IActivity>();
        }

        public void AddActivity(IActivity activity){
            _activities.Add(activity);
        }

        public List<IActivity> GetActivities() {
            return _activities;
        }
    }

    public class WorkflowEngine
    {
        public void Run(Workflow workflow) {
            
            foreach (var activity in workflow.GetActivities())
            {
                activity.Execute();
            }
        }
    }
}