using System.Windows.Automation;
using White.Core.Recording;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems;

public class Button : UIItem
{
	private readonly ToggleableItem toggleableItem;

	public virtual ToggleState State
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			return toggleableItem.State;
		}
		set
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			toggleableItem.State = value;
		}
	}

	protected Button()
	{
	}

	public Button(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
		toggleableItem = new ToggleableItem(this);
	}

	public override void HookEvents(UIItemEventListener eventListener)
	{
		HookClickEvent(eventListener);
	}

	public override void UnHookEvents()
	{
		UnHookClickEvent();
	}

	public virtual void Toggle()
	{
		toggleableItem.Toggle();
	}
}
