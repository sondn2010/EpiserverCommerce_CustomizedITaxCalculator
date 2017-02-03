using Mediachase.Commerce.Orders;
using Mediachase.Commerce.WorkflowCompatibility;

namespace Mediachase.Commerce.Workflow.Activities.ReturnForm
{
    public class CalculateReturnFormStatusActivity : ReturnFormBaseActivity
    {
        protected override ActivityExecutionStatus Execute(ActivityExecutionContext executionContext)
        {
            var newStatus = CalculateReturnFormStatus();
            if (newStatus != base.ReturnFormStatus)
            {
                ChangeReturnFormStatus(newStatus);
            }

            // Retun the closed status indicating that this activity is complete.
            return ActivityExecutionStatus.Closed;
        }

        private ReturnFormStatus CalculateReturnFormStatus()
        {
            return base.ReturnFormStatus;
        }
    }
}