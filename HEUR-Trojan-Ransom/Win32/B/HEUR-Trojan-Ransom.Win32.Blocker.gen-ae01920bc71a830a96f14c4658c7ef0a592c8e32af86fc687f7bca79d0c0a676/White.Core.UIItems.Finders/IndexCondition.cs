using System;
using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Finder;

namespace White.Core.UIItems.Finders;

public class IndexCondition : SearchCondition
{
	private readonly int index;

	public static readonly IndexCondition NotSpecified = new IndexCondition(-1);

	public override Condition AutomationCondition => null;

	protected internal override object SearchValue => index;

	protected IndexCondition()
	{
	}

	public IndexCondition(int index)
	{
		this.index = index;
	}

	public override List<AutomationElement> Filter(List<AutomationElement> automationElements)
	{
		if (automationElements.Count <= index)
		{
			throw new AutomationElementSearchException($"No item with index {index}. Number of items available {automationElements.Count}");
		}
		AutomationElementPositionComparer comparer = new AutomationElementPositionComparer();
		automationElements.Sort(comparer);
		List<AutomationElement> list = new List<AutomationElement>();
		list.Add(automationElements[index]);
		return list;
	}

	public override bool Satisfies(AutomationElement element)
	{
		throw new NotImplementedException();
	}

	public virtual IUIItem Filter(UIItemCollection collection)
	{
		List<IUIItem> list = new List<IUIItem>(collection);
		list.Sort(new UIItemPositionComparer());
		if (list.Count >= index + 1)
		{
			return list[index];
		}
		return null;
	}

	internal override string ToString(string operation)
	{
		return "Index" + operation + index;
	}

	public override bool AppliesTo(AutomationElement element)
	{
		return true;
	}

	public override string ToString()
	{
		return ToString("=");
	}

	public override bool Equals(object obj)
	{
		if (object.ReferenceEquals(null, obj))
		{
			return false;
		}
		if (object.ReferenceEquals(this, obj))
		{
			return true;
		}
		if (obj.GetType() != typeof(IndexCondition))
		{
			return false;
		}
		return ((IndexCondition)obj).index == index;
	}

	public override int GetHashCode()
	{
		return index;
	}
}
