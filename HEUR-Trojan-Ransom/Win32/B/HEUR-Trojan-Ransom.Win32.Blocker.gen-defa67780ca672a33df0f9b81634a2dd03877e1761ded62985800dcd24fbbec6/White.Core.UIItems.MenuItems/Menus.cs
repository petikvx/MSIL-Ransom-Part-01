using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Factory;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;

namespace White.Core.UIItems.MenuItems;

public class Menus : UIItemList<Menu>
{
	private static readonly DictionaryMappedItemFactory Factory = new DictionaryMappedItemFactory();

	public Menus(AutomationElement parent, ActionListener actionListener)
	{
		AutomationSearchCondition automationSearchCondition = AutomationSearchCondition.ByControlType(ControlType.MenuItem);
		AutomationElementFinder finder = new AutomationElementFinder(parent);
		finder = PerformanceHackAsPopupMenuForWin32AppComesOnDesktop(finder, parent);
		List<AutomationElement> list = finder.Descendants(automationSearchCondition);
		foreach (AutomationElement item in list)
		{
			Add((Menu)Factory.Create(item, actionListener));
		}
	}

	private static AutomationElementFinder PerformanceHackAsPopupMenuForWin32AppComesOnDesktop(AutomationElementFinder finder, AutomationElement parent)
	{
		if (((object)parent).Equals((object?)AutomationElement.get_RootElement()))
		{
			AutomationElement val = finder.Child(AutomationSearchCondition.ByControlType(ControlType.Menu));
			if (val == (AutomationElement)null)
			{
				AutomationElement automationElement = finder.Child(AutomationSearchCondition.ByControlType(ControlType.Window));
				val = new AutomationElementFinder(automationElement).Child(AutomationSearchCondition.ByControlType(ControlType.Menu));
			}
			finder = new AutomationElementFinder(val);
		}
		return finder;
	}

	public virtual Menu Find(params string[] path)
	{
		return Find(path.Select(SearchCriteria.ByText).ToArray());
	}

	public virtual Menu Find(string text)
	{
		return Find(SearchCriteria.ByText(text));
	}

	public virtual Menu Find(SearchCriteria searchCriteria)
	{
		Menu result = Find((Menu menuItem) => searchCriteria.AppliesTo(menuItem.AutomationElement));
		Thread.Sleep(200);
		return result;
	}

	public virtual Menu Find(params SearchCriteria[] path)
	{
		if (path.Length == 0)
		{
			throw new ArgumentException("Menu path not specified");
		}
		Menu menu = Find(path[0]);
		if (menu == null)
		{
			throw new UIItemSearchException("Could not find Menu " + path[0]);
		}
		for (int i = 1; i < path.Length; i++)
		{
			menu.Click();
			menu = menu.SubMenu(path[i]);
			if (menu == null)
			{
				throw new UIItemSearchException("Could not find Menu " + path[i]);
			}
		}
		return menu;
	}
}
