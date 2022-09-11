using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems;

public class Spinner : UIItem
{
	private readonly AutomationElementFinder finder;

	public virtual double Value
	{
		get
		{
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			ValuePattern valuePattern = GetValuePattern();
			ValuePatternInformation current = valuePattern.get_Current();
			string value = ((ValuePatternInformation)(ref current)).get_Value();
			return double.Parse(value);
		}
		set
		{
			GetValuePattern().SetValue(value.ToString());
		}
	}

	protected Spinner()
	{
	}

	public Spinner(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
		finder = new AutomationElementFinder(automationElement);
	}

	private ValuePattern GetValuePattern()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		AutomationElementFinder automationElementFinder = finder;
		AutomationElementInformation current = automationElement.get_Current();
		AutomationElement val = automationElementFinder.FindChildRaw(AutomationSearchCondition.ByAutomationId(((AutomationElementInformation)(ref current)).get_AutomationId()).OfControlType(ControlType.Spinner));
		if (val == (AutomationElement)null)
		{
			throw new WhiteAssertionException("Could not find Raw Spinner Element containing the value");
		}
		return (ValuePattern)val.GetCurrentPattern(ValuePattern.Pattern);
	}

	public virtual void Increment()
	{
		Button button = GetButton("SmallIncrement");
		button.PerformClick();
	}

	private Button GetButton(string buttonName)
	{
		return new Button(finder.Child(AutomationSearchCondition.ByControlType(ControlType.Button).WithAutomationId(buttonName)), actionListener);
	}

	public virtual void Decrement()
	{
		GetButton("SmallDecrement").PerformClick();
	}
}
