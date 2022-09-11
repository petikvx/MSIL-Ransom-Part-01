using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Configuration;
using White.Core.Factory;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;
using White.Core.UIItems.Scrolling;

namespace White.Core.UIItems.TableItems;

public class Table : UIItem, VerticalSpanProvider, TableVerticalScrollOffset
{
	private TableRows rows;

	private TableHeader header;

	private readonly AutomationElementFinder finder;

	private readonly TableRowFactory tableRowFactory;

	public virtual TableRows Rows
	{
		get
		{
			if (rows == null)
			{
				rows = tableRowFactory.CreateRows(this, Header ?? new NullTableHeader());
			}
			return rows;
		}
	}

	public virtual TableHeader Header
	{
		get
		{
			if (header == null)
			{
				AutomationElement val = finder.Descendant(SearchCriteria.ByText(UIItemIdAppXmlConfiguration.Instance.TableHeader).AutomationCondition);
				if (val == (AutomationElement)null)
				{
					return null;
				}
				header = (TableHeader)new TableHeaderFactory().Create(val, actionListener);
			}
			return header;
		}
	}

	public override IScrollBars ScrollBars
	{
		get
		{
			if (scrollBars == null)
			{
				scrollBars = new TableScrollBars(finder, actionListener, this);
			}
			return scrollBars;
		}
	}

	public virtual VerticalSpan VerticalSpan => new VerticalSpan(Bounds);

	bool TableVerticalScrollOffset.IsOnTop
	{
		get
		{
			if (Rows.Count == 0)
			{
				return true;
			}
			return !Rows[0].IsOffScreen;
		}
	}

	protected Table()
	{
	}

	public Table(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
		finder = new AutomationElementFinder(automationElement);
		tableRowFactory = new TableRowFactory(finder);
	}

	public virtual TableRow Row(string column, string value)
	{
		return Rows.Get(column, value);
	}

	public virtual TableRows FindAll(string column, string value)
	{
		return Rows.GetMultipleRows(column, value);
	}

	public virtual void Refresh()
	{
		rows = null;
	}

	public override void ActionPerforming(UIItem uiItem)
	{
		if (!(uiItem is Table))
		{
			new ScreenItem(uiItem, ScrollBars).MakeVisible(this);
		}
	}

	public override void RightClick()
	{
		new TooltipSafeMouse(UIItem.mouse).RightClickOutsideToolTip(this, actionListener);
	}
}
