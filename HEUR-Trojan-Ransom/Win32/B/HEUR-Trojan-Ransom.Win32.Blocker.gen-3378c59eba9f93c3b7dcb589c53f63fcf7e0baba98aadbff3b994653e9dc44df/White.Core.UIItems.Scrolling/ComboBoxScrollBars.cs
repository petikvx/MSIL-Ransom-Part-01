using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.Scrolling;

public class ComboBoxScrollBars : ScrollBars
{
	public override IHScrollBar Horizontal => FindHorizontalBar(finder.Descendant);

	public override IVScrollBar Vertical => FindVerticalBar(finder.Descendant);

	public ComboBoxScrollBars(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener, new DefaultScrollBarButtonAutomationIds(), new DefaultScrollBarButtonAutomationIds())
	{
	}
}
