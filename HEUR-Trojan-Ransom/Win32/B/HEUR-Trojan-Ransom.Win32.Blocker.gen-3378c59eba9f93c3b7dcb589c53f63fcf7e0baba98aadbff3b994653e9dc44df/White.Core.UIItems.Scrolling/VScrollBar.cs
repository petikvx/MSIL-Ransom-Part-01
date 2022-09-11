using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.Scrolling;

internal class VScrollBar : ScrollBar, IScrollBar, IVScrollBar
{
	public virtual bool IsScrollable => BackLargeChangeButton != null;

	public virtual bool IsNotMinimum => Value > 0.0;

	protected VScrollBar()
	{
	}

	public VScrollBar(AutomationElement automationElement, ActionListener actionListener, ScrollBarButtonAutomationIds automationIds)
		: base(automationElement, actionListener, automationIds)
	{
	}

	public virtual void ScrollUp()
	{
		BackSmallChangeButton.PerformClick();
	}

	public virtual void ScrollDown()
	{
		ForwardSmallChangeButton.PerformClick();
	}

	public virtual void ScrollUpLarge()
	{
		BackLargeChangeButton.PerformClick();
	}

	public virtual void ScrollDownLarge()
	{
		ForwardLargeChangeButton.PerformClick();
	}
}
