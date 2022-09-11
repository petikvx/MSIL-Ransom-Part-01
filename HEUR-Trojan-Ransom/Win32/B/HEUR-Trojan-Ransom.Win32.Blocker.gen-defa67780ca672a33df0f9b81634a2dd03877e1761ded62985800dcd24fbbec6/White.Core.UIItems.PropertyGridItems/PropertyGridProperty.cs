using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.PropertyGridItems;

public class PropertyGridProperty : UIItem
{
	private readonly PropertyGridElementFinder gridElementFinder;

	public virtual string Value
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			ValuePatternInformation val = ValuePatternId();
			return ((ValuePatternInformation)(ref val)).get_Value();
		}
		set
		{
			ValuePattern().SetValue(value);
		}
	}

	public virtual bool IsReadOnly
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			ValuePatternInformation val = ValuePatternId();
			return ((ValuePatternInformation)(ref val)).get_IsReadOnly();
		}
	}

	public virtual string Text => Name;

	protected PropertyGridProperty()
	{
	}

	public PropertyGridProperty(AutomationElement automationElement, PropertyGridElementFinder gridElementFinder, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
		this.gridElementFinder = gridElementFinder;
	}

	private ValuePatternInformation ValuePatternId()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		return ValuePattern().get_Current();
	}

	private ValuePattern ValuePattern()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		return (ValuePattern)Pattern(ValuePattern.Pattern);
	}

	public virtual void BrowseForValue()
	{
		Click();
		AutomationElement val = gridElementFinder.FindBrowseButton();
		if (val == (AutomationElement)null)
		{
			throw new WhiteException($"Property {Text} isn't browsable.");
		}
		Button button = new Button(val, actionListener);
		button.Click();
	}
}
