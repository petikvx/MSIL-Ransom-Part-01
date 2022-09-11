using System.Windows.Automation;

namespace White.Core.UIItems.Finders;

public class NotCondition : SearchCondition
{
	private readonly SearchCondition condition;

	public override Condition AutomationCondition => (Condition)new NotCondition(condition.AutomationCondition);

	protected internal override object SearchValue
	{
		get
		{
			if (condition != null)
			{
				return condition.SearchValue;
			}
			return null;
		}
	}

	protected NotCondition()
	{
	}

	public NotCondition(SearchCondition condition)
	{
		this.condition = condition;
	}

	public override bool Satisfies(AutomationElement element)
	{
		return !condition.Satisfies(element);
	}

	public override string ToString()
	{
		return condition.ToString("!=");
	}

	internal override string ToString(string operation)
	{
		return condition.ToString(operation);
	}

	public override bool AppliesTo(AutomationElement element)
	{
		return !condition.AppliesTo(element);
	}

	public override bool OfSameType(SearchCondition otherCondition)
	{
		if (base.OfSameType(otherCondition))
		{
			return condition.OfSameType(((NotCondition)otherCondition).condition);
		}
		return false;
	}

	private bool Equals(NotCondition other)
	{
		return object.Equals(other.condition, condition);
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
		if (obj.GetType() != typeof(NotCondition))
		{
			return false;
		}
		return Equals((NotCondition)obj);
	}

	public override int GetHashCode()
	{
		if (condition == null)
		{
			return 0;
		}
		return condition.GetHashCode();
	}
}
