using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Automation;

namespace White.Core.AutomationElementSearch;

public class DescendantFinder : IDescendantFinder
{
	private readonly AutomationElement automationElement;

	public DescendantFinder(AutomationElement automationElement)
	{
		this.automationElement = automationElement;
	}

	public virtual AutomationElement Descendant(AutomationSearchCondition automationSearchCondition)
	{
		return Descendant(automationSearchCondition.Condition);
	}

	public virtual AutomationElement Descendant(Condition condition)
	{
		return automationElement.FindFirst((TreeScope)4, condition);
	}

	public virtual List<AutomationElement> Descendants(AutomationSearchCondition automationSearchCondition)
	{
		AutomationElementCollection source = automationElement.FindAll((TreeScope)4, automationSearchCondition.Condition);
		IEnumerable<AutomationElement> collection = ((IEnumerable)source).Cast<AutomationElement>();
		return new List<AutomationElement>(collection);
	}
}
