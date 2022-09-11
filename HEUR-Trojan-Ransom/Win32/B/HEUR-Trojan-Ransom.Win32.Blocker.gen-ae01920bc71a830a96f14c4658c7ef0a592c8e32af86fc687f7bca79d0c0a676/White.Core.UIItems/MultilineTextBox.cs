using System.Windows.Automation;
using White.Core.Recording;
using White.Core.UIItemEvents;
using White.Core.UIItems.Actions;
using White.Core.WindowsAPI;

namespace White.Core.UIItems;

public class MultilineTextBox : TextBox, Scrollable
{
	private AutomationEventHandler handler;

	public override string Text
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			TextPattern val = (TextPattern)Pattern(TextPattern.Pattern);
			return val.get_DocumentRange().GetText(int.MaxValue);
		}
		set
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Expected O, but got Unknown
			TextPattern val = (TextPattern)Pattern(TextPattern.Pattern);
			val.get_DocumentRange().Select();
			actionListener.ActionPerformed(Action.WindowMessage);
			keyboard.PressSpecialKey(KeyboardInput.SpecialKeys.DELETE, actionListener);
			actionListener.ActionPerformed(Action.WindowMessage);
			EnterData(value);
		}
	}

	protected MultilineTextBox()
	{
	}

	public MultilineTextBox(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	public override void HookEvents(UIItemEventListener eventListener)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		handler = (AutomationEventHandler)delegate
		{
			eventListener.EventOccured(new MultilineTextBoxEvent(this));
		};
		Automation.AddAutomationEventHandler(TextPattern.TextSelectionChangedEvent, automationElement, (TreeScope)1, handler);
	}

	public override void UnHookEvents()
	{
		Automation.RemoveAutomationEventHandler(TextPattern.TextSelectionChangedEvent, automationElement, handler);
	}
}
