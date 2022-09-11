using System.Windows.Automation;

namespace White.Core.UIItems.Finders;

public class SimpleSearchCondition : SearchCondition
{
	public delegate object PropertyValue(AutomationElement automationElement);

	private readonly PropertyValue propertyValueDelegate;

	private readonly AutomationElementProperty automationElementProperty;

	public override Condition AutomationCondition => automationElementProperty.PropertyCondition;

	protected internal override object SearchValue => automationElementProperty.Value;

	private SimpleSearchCondition()
	{
	}

	public SimpleSearchCondition(PropertyValue propertyValueDelegate, AutomationElementProperty automationElementProperty)
	{
		this.propertyValueDelegate = propertyValueDelegate;
		this.automationElementProperty = automationElementProperty;
	}

	public override bool Satisfies(AutomationElement element)
	{
		return ElementValue(element).Equals(automationElementProperty.Value);
	}

	private object ElementValue(AutomationElement element)
	{
		return propertyValueDelegate(element);
	}

	internal override string ToString(string operation)
	{
		return $"{automationElementProperty.DisplayName}{operation}{automationElementProperty.DisplayValue}";
	}

	public override bool AppliesTo(AutomationElement element)
	{
		return automationElementProperty.Value.Equals(ElementValue(element));
	}

	public override bool OfSameType(SearchCondition otherCondition)
	{
		if (base.OfSameType(otherCondition))
		{
			return automationElementProperty.Equals(((SimpleSearchCondition)otherCondition).automationElementProperty);
		}
		return false;
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
		if (obj.GetType() != typeof(SimpleSearchCondition))
		{
			return false;
		}
		return Equals((SimpleSearchCondition)obj);
	}

	private bool Equals(SimpleSearchCondition other)
	{
		return object.Equals(other.automationElementProperty, automationElementProperty);
	}

	public override int GetHashCode()
	{
		if (automationElementProperty == null)
		{
			return 0;
		}
		return automationElementProperty.GetHashCode();
	}
}
