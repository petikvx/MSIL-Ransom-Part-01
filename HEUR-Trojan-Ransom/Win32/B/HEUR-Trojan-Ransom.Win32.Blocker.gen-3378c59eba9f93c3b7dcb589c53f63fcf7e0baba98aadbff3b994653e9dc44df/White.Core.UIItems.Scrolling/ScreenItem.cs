using System;
using System.Windows;
using White.Core.Configuration;
using White.Core.Utility;
using log4net;

namespace White.Core.UIItems.Scrolling;

public class ScreenItem
{
	private readonly UIItem uiItem;

	private readonly IVScrollBar verticalScroll;

	private readonly ILog logger = LogManager.GetLogger(typeof(ScreenItem));

	public ScreenItem(UIItem uiItem, IScrollBars scrollBars)
	{
		this.uiItem = uiItem;
		if (scrollBars != null && scrollBars.Vertical != null)
		{
			verticalScroll = scrollBars.Vertical;
		}
	}

	internal virtual void MakeVisible(VerticalSpanProvider verticalSpanProvider)
	{
		//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		if (verticalScroll == null)
		{
			logger.DebugFormat("Vertical scrollbar not present in parent of {0}", (object)uiItem);
			return;
		}
		if (!verticalScroll.IsScrollable)
		{
			logger.DebugFormat("Vertical scrollbar is not scrollable for parent of {0}", (object)uiItem);
			return;
		}
		VerticalSpan verticalSpan = verticalSpanProvider.VerticalSpan;
		if (verticalScroll.IsNotMinimum)
		{
			verticalScroll.SetToMinimum();
			verticalSpan = verticalSpanProvider.VerticalSpan;
			logger.DebugFormat("Scroll Position set to minimum value.", new object[0]);
		}
		if (verticalSpan.Contains(uiItem.Bounds))
		{
			logger.DebugFormat("UIItem ({0}) whose bounds are ({1}) is within bounds of parent whose vertical span is {2}", (object)uiItem, (object)uiItem.Bounds, (object)verticalSpan);
			return;
		}
		logger.DebugFormat("Trying to make visible {0}, item's bounds are {1} and parent's span is {2}", (object)uiItem, (object)uiItem.Bounds, (object)verticalSpan);
		if (Retry.For(delegate
		{
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			verticalScroll.ScrollDownLarge();
			Rect bounds = uiItem.Bounds;
			logger.DebugFormat("Trying to make {0} visible, item's bounds are {1} and parent's span is {2}", (object)uiItem, (object)bounds, (object)verticalSpan);
			return verticalSpan.Contains(bounds);
		}, CoreAppXmlConfiguration.Instance.BusyTimeout(), TimeSpan.FromMilliseconds(0.0)))
		{
			return;
		}
		throw new UIActionException($"Could not make the {uiItem} visible{Constants.BusyMessage}");
	}
}
