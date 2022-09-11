using System.Windows;
using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems;

public class ToolTip : UIItem
{
	public virtual string Text
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = automationElement.get_Current();
			return ((AutomationElementInformation)(ref current)).get_Name();
		}
	}

	protected ToolTip()
	{
	}

	public ToolTip(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	public static ToolTip GetFrom(Point point)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		AutomationElement val = AutomationElement.FromPoint(point);
		AutomationElementInformation current = val.get_Current();
		if (!((object)((AutomationElementInformation)(ref current)).get_ControlType()).Equals((object?)ControlType.ToolTip))
		{
			return null;
		}
		return new ToolTip(val, new NullActionListener());
	}

	public virtual Point LeftOutside(Rect rect)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		Rect bounds = Bounds;
		return new Point((double)((int)((Rect)(ref bounds)).get_Left() - 1), (double)(int)((Rect)(ref rect)).get_Y());
	}
}
