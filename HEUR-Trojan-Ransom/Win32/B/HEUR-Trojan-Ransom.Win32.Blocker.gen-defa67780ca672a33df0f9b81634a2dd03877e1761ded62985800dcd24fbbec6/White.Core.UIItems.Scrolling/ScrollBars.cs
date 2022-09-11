using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Configuration;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.Scrolling;

public class ScrollBars : AbstractScrollBars
{
	protected delegate AutomationElement FindElement(AutomationSearchCondition condition);

	private readonly ActionListener actionListener;

	private readonly ScrollBarButtonAutomationIds hScrollBarButtonAutomationIds;

	private readonly ScrollBarButtonAutomationIds vScrollBarButtonAutomationIds;

	protected readonly AutomationElementFinder finder;

	public override IHScrollBar Horizontal => FindHorizontalBar(finder.Child);

	public override IVScrollBar Vertical => FindVerticalBar(finder.Child);

	public ScrollBars(AutomationElement automationElement, ActionListener actionListener, ScrollBarButtonAutomationIds hScrollBarButtonAutomationIds, ScrollBarButtonAutomationIds vScrollBarButtonAutomationIds)
	{
		this.actionListener = actionListener;
		this.hScrollBarButtonAutomationIds = hScrollBarButtonAutomationIds;
		this.vScrollBarButtonAutomationIds = vScrollBarButtonAutomationIds;
		finder = new AutomationElementFinder(automationElement);
	}

	protected virtual IHScrollBar FindHorizontalBar(FindElement findElement)
	{
		AutomationElement val = findElement(AutomationSearchCondition.ByAutomationId(UIItemIdAppXmlConfiguration.Instance.HorizontalScrollBar).OfControlType(ControlType.ScrollBar));
		if (val == (AutomationElement)null)
		{
			return new NullHScrollBar();
		}
		return new HScrollBar(val, actionListener, hScrollBarButtonAutomationIds);
	}

	protected virtual IVScrollBar FindVerticalBar(FindElement findElement)
	{
		AutomationElement val = findElement(AutomationSearchCondition.ByAutomationId(UIItemIdAppXmlConfiguration.Instance.VerticalScrollBar).OfControlType(ControlType.ScrollBar));
		if (val == (AutomationElement)null)
		{
			return new NullVScrollBar();
		}
		return new VScrollBar(val, actionListener, vScrollBarButtonAutomationIds);
	}
}
