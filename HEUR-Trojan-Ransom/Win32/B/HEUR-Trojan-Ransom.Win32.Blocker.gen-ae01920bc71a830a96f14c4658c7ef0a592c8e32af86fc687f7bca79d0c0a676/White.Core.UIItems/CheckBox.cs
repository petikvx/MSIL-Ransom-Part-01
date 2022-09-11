using System.Windows.Automation;
using White.Core.Recording;
using White.Core.UIItemEvents;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems;

public class CheckBox : Button
{
	private AutomationPropertyChangedEventHandler handler;

	public virtual bool IsSelected => Checked;

	public virtual bool Checked
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return ((object)State).Equals((object)(ToggleState)1);
		}
		set
		{
			if (Checked != value)
			{
				Click();
			}
		}
	}

	protected CheckBox()
	{
	}

	public CheckBox(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	public virtual void Select()
	{
		Checked = true;
	}

	public virtual void UnSelect()
	{
		Checked = false;
	}

	public override void HookEvents(UIItemEventListener eventListener)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		handler = (AutomationPropertyChangedEventHandler)delegate
		{
			ActionPerformed();
			eventListener.EventOccured(new CheckBoxEvent(this));
		};
		Automation.AddAutomationPropertyChangedEventHandler(automationElement, (TreeScope)1, handler, (AutomationProperty[])(object)new AutomationProperty[1] { TogglePattern.ToggleStateProperty });
	}

	public override void UnHookEvents()
	{
		Automation.RemoveAutomationPropertyChangedEventHandler(automationElement, handler);
	}

	public override void SetValue(object value)
	{
		if (!(value is bool))
		{
			throw new UIActionException("Cannot set non bool value to a checkbox. Trying to set: " + value);
		}
		Checked = (bool)value;
	}
}
