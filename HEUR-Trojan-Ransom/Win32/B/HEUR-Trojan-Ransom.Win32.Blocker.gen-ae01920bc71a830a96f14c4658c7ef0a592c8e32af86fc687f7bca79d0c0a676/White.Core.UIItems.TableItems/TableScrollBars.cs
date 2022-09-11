using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Configuration;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Scrolling;

namespace White.Core.UIItems.TableItems;

public class TableScrollBars : AbstractScrollBars
{
	private readonly IVScrollBar verticalScrollBar;

	private readonly IHScrollBar horizontalScrollBar;

	public override IHScrollBar Horizontal => horizontalScrollBar;

	public override IVScrollBar Vertical => verticalScrollBar;

	public TableScrollBars(AutomationElementFinder finder, ActionListener actionListener, TableVerticalScrollOffset tableVerticalScrollOffset)
	{
		AutomationElement val = finder.Child(AutomationSearchCondition.ByControlType(ControlType.Pane).OfName(UIItemIdAppXmlConfiguration.Instance.TableVerticalScrollBar));
		object obj;
		if (!(val == (AutomationElement)null))
		{
			IVScrollBar iVScrollBar = new TableVerticalScrollBar(val, actionListener, tableVerticalScrollOffset);
			obj = iVScrollBar;
		}
		else
		{
			obj = new NullVScrollBar();
		}
		verticalScrollBar = (IVScrollBar)obj;
		AutomationElement val2 = finder.Child(AutomationSearchCondition.ByControlType(ControlType.Pane).OfName(UIItemIdAppXmlConfiguration.Instance.TableHorizontalScrollBar));
		object obj2;
		if (!(val2 == (AutomationElement)null))
		{
			IHScrollBar iHScrollBar = new TableHorizontalScrollBar(val2, actionListener);
			obj2 = iHScrollBar;
		}
		else
		{
			obj2 = new NullHScrollBar();
		}
		horizontalScrollBar = (IHScrollBar)obj2;
	}
}
