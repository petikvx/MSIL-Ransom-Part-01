using System.Collections.Generic;
using System.Windows.Automation;

namespace White.Core.AutomationElementSearch;

public class MultiLevelAutomationElementFinder
{
	private readonly AutomationSearchCondition[] searchConditions;

	public MultiLevelAutomationElementFinder(params AutomationSearchCondition[] searchConditions)
	{
		this.searchConditions = searchConditions;
	}

	public virtual AutomationElement Find(int returnLevel, AutomationElement startElement)
	{
		AutomationElement automationElement = startElement;
		AutomationElement result = null;
		int num = 0;
		while (true)
		{
			if (num < searchConditions.Length)
			{
				AutomationElementFinder automationElementFinder = new AutomationElementFinder(automationElement);
				AutomationElement val = automationElementFinder.Child(searchConditions[num]);
				if (val == (AutomationElement)null)
				{
					break;
				}
				automationElement = val;
				if (num == returnLevel)
				{
					result = val;
				}
				num++;
				continue;
			}
			return result;
		}
		return null;
	}

	public virtual AutomationElement Find(AutomationElement startElement)
	{
		return Find(searchConditions.Length - 1, startElement);
	}

	public virtual List<AutomationElement> FindAll(AutomationElement startElement)
	{
		AutomationElement automationElement = startElement;
		int num = 0;
		while (true)
		{
			if (num < searchConditions.Length)
			{
				AutomationElementFinder automationElementFinder = new AutomationElementFinder(automationElement);
				if (num != searchConditions.Length - 1)
				{
					AutomationElement val = automationElementFinder.Child(searchConditions[num]);
					automationElement = val;
					if (val == (AutomationElement)null)
					{
						break;
					}
					num++;
					continue;
				}
				return automationElementFinder.Children(searchConditions[num]);
			}
			throw new WhiteAssertionException("Something wrong in logic here");
		}
		return null;
	}
}
