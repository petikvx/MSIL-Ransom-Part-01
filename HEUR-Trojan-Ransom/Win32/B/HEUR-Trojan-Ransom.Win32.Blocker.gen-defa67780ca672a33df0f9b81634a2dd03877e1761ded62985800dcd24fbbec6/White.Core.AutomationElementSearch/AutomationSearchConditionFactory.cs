using System.Collections.Generic;
using System.Windows.Automation;

namespace White.Core.AutomationElementSearch;

public class AutomationSearchConditionFactory
{
	public virtual List<AutomationSearchCondition> GetWindowSearchConditions(int processId)
	{
		List<AutomationSearchCondition> list = new List<AutomationSearchCondition>();
		list.Add(AutomationSearchCondition.GetWindowSearchCondition(processId, ControlType.Window));
		list.Add(AutomationSearchCondition.GetWindowSearchCondition(processId, ControlType.Pane));
		return list;
	}
}
