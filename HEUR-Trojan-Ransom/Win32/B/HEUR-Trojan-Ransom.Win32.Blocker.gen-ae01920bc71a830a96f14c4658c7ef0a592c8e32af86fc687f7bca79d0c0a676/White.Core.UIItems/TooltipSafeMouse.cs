using System.Threading;
using White.Core.Configuration;
using White.Core.InputDevices;
using White.Core.UIA;
using White.Core.UIItems.Actions;
using log4net;

namespace White.Core.UIItems;

internal class TooltipSafeMouse
{
	private readonly Mouse mouse;

	private readonly ILog logger = LogManager.GetLogger(typeof(TooltipSafeMouse));

	public TooltipSafeMouse(Mouse mouse)
	{
		this.mouse = mouse;
	}

	public virtual void RightClickOutsideToolTip(UIItem uiItem, ActionListener actionListener)
	{
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		actionListener.ActionPerforming(uiItem);
		ToolTip toolTip = GetToolTip(uiItem, actionListener);
		if (toolTip == null)
		{
			mouse.RightClickHere(actionListener);
			return;
		}
		logger.Debug((object)"Found tooltip RightClicking outside tooltip bounds");
		mouse.RightClick(toolTip.LeftOutside(uiItem.Bounds), actionListener);
	}

	public virtual void DoubleClickOutsideToolTip(UIItem uiItem, ActionListener actionListener)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		actionListener.ActionPerforming(uiItem);
		ToolTip toolTip = GetToolTip(uiItem, actionListener);
		if (toolTip == null)
		{
			mouse.DoubleClick(uiItem.Bounds.Center(), actionListener);
			return;
		}
		logger.Debug((object)"Found tooltip DoubleClicking outside tooltip bounds");
		mouse.DoubleClick(toolTip.LeftOutside(uiItem.Bounds), actionListener);
	}

	public virtual void ClickOutsideToolTip(UIItem uiItem, ActionListener actionListener)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		actionListener.ActionPerforming(uiItem);
		ToolTip toolTip = GetToolTip(uiItem, actionListener);
		if (toolTip == null)
		{
			mouse.Click(uiItem.Bounds.Center(), actionListener);
			return;
		}
		logger.Debug((object)"Found tooltip Clicking outside tooltip bounds");
		mouse.Click(toolTip.LeftOutside(uiItem.Bounds), actionListener);
	}

	private ToolTip GetToolTip(UIItem uiItem, ActionListener actionListener)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		mouse.Click(uiItem.Bounds.Center());
		actionListener.ActionPerformed(Action.WindowMessage);
		Thread.Sleep(CoreAppXmlConfiguration.Instance.TooltipWaitTime);
		return ToolTip.GetFrom(uiItem.Bounds.Center());
	}
}
