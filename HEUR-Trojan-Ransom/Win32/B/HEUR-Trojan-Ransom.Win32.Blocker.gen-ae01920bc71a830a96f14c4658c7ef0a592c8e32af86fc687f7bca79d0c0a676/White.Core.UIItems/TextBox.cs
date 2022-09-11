using System;
using System.Windows.Automation;
using White.Core.Recording;
using White.Core.UIA;
using White.Core.UIItemEvents;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems;

public class TextBox : UIItem
{
	private AutomationPropertyChangedEventHandler handler;

	public virtual string Text
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			if (((AutomationElementInformation)(ref current)).get_IsPassword())
			{
				throw new WhiteException("Text cannot be retrieved from textbox which has secret text (e.g. password) stored in it");
			}
			ValuePatternInformation current2 = ((ValuePattern)Pattern(ValuePattern.Pattern)).get_Current();
			return ((ValuePatternInformation)(ref current2)).get_Value();
		}
		set
		{
			Enter(value);
		}
	}

	public virtual string BulkText
	{
		get
		{
			return Text;
		}
		set
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				((ValuePattern)Pattern(ValuePattern.Pattern)).SetValue(value);
			}
			catch (InvalidOperationException)
			{
				logger.Warn((object)("BulkText failed, now trying Text on " + ToString()));
				Text = value;
				actionListener.ActionPerformed(White.Core.UIItems.Actions.Action.WindowMessage);
			}
		}
	}

	public virtual bool IsReadOnly
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			ValuePatternInformation current = ((ValuePattern)Pattern(ValuePattern.Pattern)).get_Current();
			return ((ValuePatternInformation)(ref current)).get_IsReadOnly();
		}
	}

	protected TextBox()
	{
	}

	public TextBox(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	public virtual void ClickAtRightEdge()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		UIItem.mouse.Click(Bounds.ImmediateInteriorEast(), actionListener);
	}

	public virtual void ClickAtCenter()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		UIItem.mouse.Click(Bounds.Center(), actionListener);
	}

	public override void HookEvents(UIItemEventListener eventListener)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		handler = (AutomationPropertyChangedEventHandler)delegate
		{
			eventListener.EventOccured(new TextBoxEvent(this));
		};
		Automation.AddAutomationPropertyChangedEventHandler(automationElement, (TreeScope)1, handler, (AutomationProperty[])(object)new AutomationProperty[1] { ValuePattern.ValueProperty });
	}

	public override void UnHookEvents()
	{
		Automation.RemoveAutomationPropertyChangedEventHandler(automationElement, handler);
	}

	public override void SetValue(object value)
	{
		BulkText = value.ToString();
	}
}
