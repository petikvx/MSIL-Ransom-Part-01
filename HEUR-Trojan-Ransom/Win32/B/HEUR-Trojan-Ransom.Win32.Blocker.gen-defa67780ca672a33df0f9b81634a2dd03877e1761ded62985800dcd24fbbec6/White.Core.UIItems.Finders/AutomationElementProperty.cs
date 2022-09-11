using System.Windows.Automation;

namespace White.Core.UIItems.Finders;

public class AutomationElementProperty
{
	protected readonly object value;

	private readonly string displayName;

	private readonly AutomationProperty propertyType;

	public virtual object Value => value;

	public virtual string DisplayValue => value.ToString();

	public virtual string DisplayName => displayName;

	public virtual Condition PropertyCondition => (Condition)new PropertyCondition(propertyType, value);

	protected AutomationElementProperty()
	{
	}

	public AutomationElementProperty(object value, string displayName, AutomationProperty propertyType)
	{
		this.value = value;
		this.displayName = displayName;
		this.propertyType = propertyType;
	}

	private bool Equals(AutomationElementProperty other)
	{
		if (object.Equals(other.value, value) && object.Equals(((AutomationIdentifier)other.propertyType).get_Id(), ((AutomationIdentifier)propertyType).get_Id()))
		{
			return object.Equals(((AutomationIdentifier)other.propertyType).get_ProgrammaticName(), ((AutomationIdentifier)other.propertyType).get_ProgrammaticName());
		}
		return false;
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
		if (obj.GetType() != GetType())
		{
			return false;
		}
		return Equals((AutomationElementProperty)obj);
	}

	public override int GetHashCode()
	{
		return (((value != null) ? value.GetHashCode() : 0) * 397) ^ ((propertyType != null) ? ((object)propertyType).GetHashCode() : 0);
	}
}
