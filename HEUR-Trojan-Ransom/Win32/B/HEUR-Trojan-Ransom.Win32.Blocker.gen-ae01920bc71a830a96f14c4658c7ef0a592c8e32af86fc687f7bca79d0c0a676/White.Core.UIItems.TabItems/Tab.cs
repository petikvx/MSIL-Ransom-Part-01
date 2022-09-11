using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Factory;
using White.Core.Recording;
using White.Core.UIItemEvents;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.TabItems;

public class Tab : UIItem
{
	private TabPages pages;

	private AutomationPropertyChangedEventHandler handler;

	public virtual ITabPage SelectedTab => Pages.Find((ITabPage tabPage) => tabPage.IsSelected);

	public virtual int TabCount => Pages.Count;

	public virtual TabPages Pages
	{
		get
		{
			if (pages == null)
			{
				pages = new TabPages();
				AutomationElementFinder automationElementFinder = new AutomationElementFinder(automationElement);
				List<AutomationElement> list = automationElementFinder.Children(AutomationSearchCondition.ByControlType(ControlType.TabItem));
				foreach (AutomationElement item in list)
				{
					pages.Add(new TabPage(item, actionListener));
				}
			}
			return pages;
		}
	}

	protected Tab()
	{
	}

	public Tab(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	public virtual void SelectTabPage(int index)
	{
		ITabPage tabPage = Pages[index];
		tabPage.Select();
	}

	public virtual void SelectTabPage(string tabTitle)
	{
		ITabPage selectedTab = SelectedTab;
		ITabPage tabPage = Pages.Find((ITabPage tabItem) => tabItem.NameMatches(tabTitle));
		if (tabPage == null)
		{
			throw new UIItemSearchException($"No tab found with title{tabTitle}");
		}
		tabPage.Select();
		if (!selectedTab.Equals(SelectedTab))
		{
			actionListener.ActionPerformed(new Action(ActionType.NewControls));
		}
	}

	public override void HookEvents(UIItemEventListener eventListener)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		handler = (AutomationPropertyChangedEventHandler)delegate
		{
			eventListener.EventOccured(new TabEvent(this));
		};
		Automation.AddAutomationPropertyChangedEventHandler(automationElement, (TreeScope)4, handler, (AutomationProperty[])(object)new AutomationProperty[1] { SelectionItemPattern.IsSelectedProperty });
	}

	public override void UnHookEvents()
	{
		Automation.RemoveAutomationPropertyChangedEventHandler(automationElement, handler);
	}
}
