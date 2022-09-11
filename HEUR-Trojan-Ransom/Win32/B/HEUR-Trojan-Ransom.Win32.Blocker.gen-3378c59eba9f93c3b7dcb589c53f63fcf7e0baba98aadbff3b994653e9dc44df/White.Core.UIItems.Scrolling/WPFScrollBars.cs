using System.Collections.ObjectModel;
using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.Scrolling;

public class WPFScrollBars : AbstractScrollBars
{
	private readonly AutomationElement parentElement;

	private readonly ActionListener actionListener;

	public override IHScrollBar Horizontal
	{
		get
		{
			Collection<AutomationPattern> collection = new Collection<AutomationPattern>(parentElement.GetSupportedPatterns());
			if (!collection.Contains(ScrollPattern.Pattern))
			{
				return new NullHScrollBar();
			}
			return new WPFHScrollBar(parentElement, actionListener);
		}
	}

	public override IVScrollBar Vertical
	{
		get
		{
			Collection<AutomationPattern> collection = new Collection<AutomationPattern>(parentElement.GetSupportedPatterns());
			if (!collection.Contains(ScrollPattern.Pattern))
			{
				return new NullVScrollBar();
			}
			return new WPFVScrollBar(parentElement, actionListener);
		}
	}

	public override bool CanScroll
	{
		get
		{
			if (!Horizontal.IsScrollable)
			{
				return Vertical.IsScrollable;
			}
			return true;
		}
	}

	public WPFScrollBars(AutomationElement parentElement, ActionListener actionListener)
	{
		this.parentElement = parentElement;
		this.actionListener = actionListener;
	}
}
