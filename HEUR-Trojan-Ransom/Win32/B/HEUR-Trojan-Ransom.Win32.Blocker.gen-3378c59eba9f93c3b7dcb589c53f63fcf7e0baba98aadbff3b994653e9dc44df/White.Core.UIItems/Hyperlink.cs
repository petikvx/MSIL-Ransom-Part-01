using System.Windows;
using System.Windows.Automation;
using White.Core.Recording;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems;

public class Hyperlink : UIItem
{
	protected Hyperlink()
	{
	}

	public Hyperlink(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	public virtual void Click(int xOffset, int yOffset)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		AutomationElementInformation current = automationElement.get_Current();
		Rect boundingRectangle = ((AutomationElementInformation)(ref current)).get_BoundingRectangle();
		double num = ((Rect)(ref boundingRectangle)).get_X() + (double)xOffset;
		AutomationElementInformation current2 = automationElement.get_Current();
		Rect boundingRectangle2 = ((AutomationElementInformation)(ref current2)).get_BoundingRectangle();
		double num2 = ((Rect)(ref boundingRectangle2)).get_Y() + (double)yOffset;
		UIItem.mouse.Click(new Point((double)(int)num, (double)(int)num2), actionListener);
	}

	public override void HookEvents(UIItemEventListener eventListener)
	{
		HookClickEvent(eventListener);
	}

	public override void UnHookEvents()
	{
		UnHookClickEvent();
	}
}
