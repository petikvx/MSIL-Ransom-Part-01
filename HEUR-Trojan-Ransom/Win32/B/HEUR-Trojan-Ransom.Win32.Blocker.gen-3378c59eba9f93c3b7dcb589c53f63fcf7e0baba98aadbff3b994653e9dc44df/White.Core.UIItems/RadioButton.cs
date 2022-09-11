using System.Windows.Automation;
using White.Core.Recording;
using White.Core.UIItemEvents;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems;

public class RadioButton : SelectionItem
{
	private AutomationEventHandler handler;

	protected RadioButton()
	{
	}

	public RadioButton(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	public override void HookEvents(UIItemEventListener eventListener)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		handler = (AutomationEventHandler)delegate
		{
			eventListener.EventOccured(new RadioButtonEvent(this));
		};
		Automation.AddAutomationEventHandler(SelectionItemPattern.ElementSelectedEvent, automationElement, (TreeScope)1, handler);
	}

	public override void UnHookEvents()
	{
		Automation.RemoveAutomationEventHandler(SelectionItemPattern.ElementSelectedEvent, automationElement, handler);
	}

	public override void SetValue(object value)
	{
		if (!(value is bool))
		{
			throw new UIActionException("Cannot set non bool value to a RadioButton. Trying to set: " + value);
		}
		IsSelected = (bool)value;
	}
}
