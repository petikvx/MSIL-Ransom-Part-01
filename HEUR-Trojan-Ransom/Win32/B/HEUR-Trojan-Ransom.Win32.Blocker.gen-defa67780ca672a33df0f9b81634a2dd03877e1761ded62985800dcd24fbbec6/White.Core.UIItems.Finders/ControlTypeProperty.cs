using System.Windows.Automation;

namespace White.Core.UIItems.Finders;

public class ControlTypeProperty : AutomationElementProperty
{
	public override string DisplayValue => ((ControlType)value).get_LocalizedControlType();

	protected ControlTypeProperty()
	{
	}

	public ControlTypeProperty(ControlType controlType, string displayName)
		: base(controlType, displayName, AutomationElement.ControlTypeProperty)
	{
	}
}
