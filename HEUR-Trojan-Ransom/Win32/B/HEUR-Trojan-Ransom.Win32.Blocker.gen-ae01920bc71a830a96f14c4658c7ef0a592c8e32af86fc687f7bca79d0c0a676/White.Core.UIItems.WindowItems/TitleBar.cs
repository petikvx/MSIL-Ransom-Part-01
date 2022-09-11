using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.WindowItems;

public class TitleBar : UIItem
{
	private readonly AutomationElementFinder automationElementFinder;

	public virtual Button MinimizeButton => FindButton("Minimize");

	public virtual Button MaximizeButton => FindButton("Maximize");

	public virtual Button RestoreButton => FindButton("Restore");

	public virtual Button CloseButton => FindButton("Close");

	public TitleBar(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
		automationElementFinder = new AutomationElementFinder(automationElement);
	}

	protected TitleBar()
	{
	}

	public virtual void SetDisplayState(DisplayState displayState)
	{
		switch (displayState)
		{
		case DisplayState.Maximized:
			SetDisplayState(MaximizeButton);
			break;
		case DisplayState.Minimized:
			SetDisplayState(MinimizeButton);
			break;
		case DisplayState.Restored:
			SetDisplayState(RestoreButton);
			break;
		}
	}

	private void SetDisplayState(Button button)
	{
		button?.Click();
	}

	private Button FindButton(string automationId)
	{
		AutomationElement val = automationElementFinder.Child(AutomationSearchCondition.ByControlType(ControlType.Button).WithAutomationId(automationId));
		if (val == (AutomationElement)null)
		{
			return null;
		}
		return new Button(val, actionListener);
	}
}
