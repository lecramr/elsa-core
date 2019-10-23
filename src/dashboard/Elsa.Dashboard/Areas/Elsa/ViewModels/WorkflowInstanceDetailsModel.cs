using System.Collections.Generic;
using System.Linq;
using Elsa.Models;
using Elsa.WorkflowDesigner.Models;

namespace Elsa.Dashboard.Areas.Elsa.ViewModels
{
    public class WorkflowInstanceDetailsModel
    {
        public WorkflowInstanceDetailsModel(
            WorkflowInstance workflowInstance,
            WorkflowDefinitionVersion workflowDefinition,
            WorkflowModel workflowModel,
            IEnumerable<ActivityDefinitionModel> activityDefinitions,
            string returnUrl)
        {
            WorkflowInstance = workflowInstance;
            WorkflowDefinition = workflowDefinition;
            WorkflowModel = workflowModel;
            ActivityDefinitions = activityDefinitions.ToArray();
            ReturnUrl = returnUrl;
        }

        public WorkflowInstance WorkflowInstance { get; }
        public WorkflowDefinitionVersion WorkflowDefinition { get; }
        public WorkflowModel WorkflowModel { get; }
        public ActivityDefinitionModel[] ActivityDefinitions { get; }
        public string ReturnUrl { get; }
    }
}