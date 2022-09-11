using System.Collections.Generic;
using System.Linq;
using System.Windows.Automation;

namespace White.Core.UIItems.Finders;

public class SearchConditions : List<SearchCondition>
{
	public virtual Condition AutomationCondition
	{
		get
		{
			//IL_004a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Expected O, but got Unknown
			if (base.Count == 0)
			{
				return Condition.TrueCondition;
			}
			List<Condition> automationConditions = new List<Condition>();
			ForEach(delegate(SearchCondition condition)
			{
				Condition automationCondition = condition.AutomationCondition;
				if (automationCondition != null)
				{
					automationConditions.Add(automationCondition);
				}
			});
			if (automationConditions.Count != 1)
			{
				return (Condition)new AndCondition(automationConditions.ToArray());
			}
			return automationConditions[0];
		}
	}

	public virtual List<AutomationElement> Filter(List<AutomationElement> elements)
	{
		List<AutomationElement> list = new List<AutomationElement>(elements);
		ForEach(delegate(SearchCondition condition)
		{
			list = condition.Filter(list);
		});
		return list;
	}

	public override string ToString()
	{
		return string.Join(",", this.Select((SearchCondition i) => i.ToString()).ToArray());
	}
}
