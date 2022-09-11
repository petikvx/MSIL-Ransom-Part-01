using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Recording;
using White.Core.UIItemEvents;
using White.Core.UIItems.Actions;
using White.Core.UIItems.ListViewItems;
using White.Core.UIItems.Scrolling;

namespace White.Core.UIItems;

public class ListView : UIItem, VerticalSpanProvider, SuggestionList
{
	private readonly ListViewFactory listViewFactory;

	private AutomationPropertyChangedEventHandler handler;

	public virtual ListViewRows Rows => listViewFactory.Rows;

	public virtual ListViewHeader Header => listViewFactory.Header;

	public virtual ListViewRows SelectedRows => Rows.SelectedRows;

	List<string> SuggestionList.Items
	{
		get
		{
			List<string> list = new List<string>();
			ListViewRows rows = Rows;
			foreach (ListViewRow item in rows)
			{
				list.Add(item.Cells[0].Text);
			}
			return list;
		}
	}

	public virtual VerticalSpan VerticalSpan => new VerticalSpan(Bounds).Minus(ScrollBars.Horizontal.Bounds);

	protected ListView()
	{
	}

	public ListView(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
		listViewFactory = new ListViewFactory(new AutomationElementFinder(automationElement), this);
	}

	public virtual void Select(int zeroBasedRowIndex)
	{
		Rows[zeroBasedRowIndex].Select();
	}

	public virtual void MultiSelect(int zeroBasedRowIndex)
	{
		Rows[zeroBasedRowIndex].MultiSelect();
	}

	public virtual ListViewCell Cell(string column, int zeroBasedRowIndex)
	{
		return Rows.Get(zeroBasedRowIndex).Cells[Header.Columns[column]];
	}

	public virtual void Select(string column, string value)
	{
		GetItem(column, value).Select();
	}

	private ListViewRow GetItem(string column, string value)
	{
		return Rows.Get(column, value);
	}

	public virtual void MultiSelect(string column, string value)
	{
		GetItem(column, value).MultiSelect();
	}

	public virtual ListViewRow Row(string column, string value)
	{
		return Rows.Get(column, value);
	}

	public virtual void TryUnSelectAll()
	{
		ListViewRows rows = Rows;
		if (rows.Count != 0 && Header.Columns.Count >= 2)
		{
			rows[0].Cells[Header.Columns[1].Text].Click();
			actionListener.ActionPerformed(Action.WindowMessage);
		}
	}

	public override void HookEvents(UIItemEventListener eventListener)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		SafeAutomationEventHandler safeAutomationEventHandler = new SafeAutomationEventHandler(this, eventListener, (object[] objs) => ListViewEvent.Create(this, (AutomationPropertyChangedEventArgs)objs[0]));
		handler = new AutomationPropertyChangedEventHandler(safeAutomationEventHandler.PropertyChange);
		Automation.AddAutomationPropertyChangedEventHandler(automationElement, (TreeScope)4, handler, (AutomationProperty[])(object)new AutomationProperty[1] { SelectionItemPattern.IsSelectedProperty });
	}

	public override void UnHookEvents()
	{
		Automation.RemoveAutomationPropertyChangedEventHandler(automationElement, handler);
	}

	void SuggestionList.Select(string text)
	{
		ListViewRows rows = Rows;
		ListViewRow listViewRow = rows.Find((ListViewRow obj) => obj.Cells[0].Text.Equals(text));
		if (listViewRow == null)
		{
			throw new UIActionException("Could not find suggestion " + text);
		}
		listViewRow.Select();
		SuggestionListView.WaitTillNotPresent();
		actionListener.ActionPerformed(Action.WindowMessage);
	}

	public override void ActionPerforming(UIItem uiItem)
	{
		new ScreenItem(uiItem, ScrollBars).MakeVisible(this);
	}
}
