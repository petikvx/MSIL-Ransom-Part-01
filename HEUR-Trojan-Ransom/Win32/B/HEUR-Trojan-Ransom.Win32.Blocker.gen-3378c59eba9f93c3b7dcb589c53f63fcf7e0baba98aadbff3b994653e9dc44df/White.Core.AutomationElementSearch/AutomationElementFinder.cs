using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Automation;
using White.Core.UIItems.Finders;

namespace White.Core.AutomationElementSearch;

public class AutomationElementFinder
{
	private readonly AutomationElement automationElement;

	public virtual AutomationElement AutomationElement => automationElement;

	public AutomationElementFinder(AutomationElement automationElement)
	{
		this.automationElement = automationElement;
	}

	public virtual List<AutomationElement> Children(params AutomationSearchCondition[] automationSearchConditions)
	{
		return new MultiLevelAutomationElementFinder(automationSearchConditions).FindAll(automationElement).Cast<AutomationElement>().ToList();
	}

	public virtual AutomationElement Child(params AutomationSearchCondition[] automationSearchConditions)
	{
		return new MultiLevelAutomationElementFinder(automationSearchConditions).Find(automationElement);
	}

	protected virtual AutomationElement Child(int returnLevel, AutomationSearchCondition[] automationSearchConditions)
	{
		return new MultiLevelAutomationElementFinder(automationSearchConditions).Find(returnLevel, automationElement);
	}

	public virtual List<AutomationElement> Children(AutomationSearchCondition automationSearchCondition)
	{
		return ((IEnumerable)automationElement.FindAll((TreeScope)2, automationSearchCondition.Condition)).Cast<AutomationElement>().ToList();
	}

	public virtual AutomationElement Child(AutomationSearchCondition automationSearchCondition)
	{
		return automationElement.FindFirst((TreeScope)2, automationSearchCondition.Condition);
	}

	public virtual AutomationElement Descendant(AutomationSearchCondition searchCondition)
	{
		return Descendant(searchCondition.Condition);
	}

	public virtual AutomationElement Descendant(Condition condition)
	{
		return DescendantFinderFactory.Create(automationElement).Descendant(condition);
	}

	public virtual List<AutomationElement> Descendants(AutomationSearchCondition automationSearchCondition)
	{
		return DescendantFinderFactory.Create(automationElement).Descendants(automationSearchCondition);
	}

	public virtual AutomationElement FindWindow(string title, int processId)
	{
		List<AutomationSearchCondition> windowSearchConditions = new AutomationSearchConditionFactory().GetWindowSearchConditions(processId);
		foreach (AutomationSearchCondition item in windowSearchConditions)
		{
			AutomationElement val = Child(item.OfName(title));
			if (val != (AutomationElement)null)
			{
				return val;
			}
		}
		return Child(0, new AutomationSearchCondition[2]
		{
			AutomationSearchCondition.GetWindowWithTitleBarSearchCondition(processId),
			AutomationSearchCondition.ByControlType(ControlType.TitleBar).OfName(title)
		});
	}

	public virtual AutomationElement FindWindow(SearchCriteria searchCriteria, int processId)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		Condition val = searchCriteria.AutomationConditionWith(new PropertyCondition(AutomationElement.ProcessIdProperty, (object)processId));
		return automationElement.FindFirst((TreeScope)2, val);
	}

	public virtual AutomationElement FindWindow(SearchCriteria searchCriteria)
	{
		return automationElement.FindFirst((TreeScope)2, searchCriteria.AutomationCondition);
	}

	public virtual AutomationElement FindChildRaw(AutomationSearchCondition automationSearchCondition)
	{
		return new RawAutomationElementFinder(automationElement).Child(automationSearchCondition);
	}

	public virtual AutomationElement FindDescendantRaw(AutomationSearchCondition automationSearchCondition)
	{
		return new RawAutomationElementFinder(automationElement).Descendant(automationSearchCondition);
	}
}
