using System.Collections.Generic;
using System.Windows.Automation;

namespace White.Core.UIItems.Finders;

public abstract class SearchCondition
{
	public abstract Condition AutomationCondition { get; }

	protected internal abstract object SearchValue { get; }

	public virtual List<AutomationElement> Filter(List<AutomationElement> automationElements)
	{
		return automationElements.FindAll(Satisfies);
	}

	public abstract bool Satisfies(AutomationElement element);

	internal abstract string ToString(string operation);

	public abstract bool AppliesTo(AutomationElement element);

	public virtual bool OfSameType(SearchCondition otherCondition)
	{
		return otherCondition is IndexCondition;
	}
}
