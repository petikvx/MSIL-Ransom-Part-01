using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Configuration;
using White.Core.UIItems;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;
using White.Core.UIItems.MenuItems;
using White.Core.UIItems.WindowItems;
using White.Core.Utility;

namespace White.Core.Factory;

public class PrimaryUIItemFactory : ChildWindowFactory
{
	private readonly DictionaryMappedItemFactory dictionaryMappedItemFactory = new DictionaryMappedItemFactory();

	public virtual ToolTip ToolTip => ToolTipFinder.FindToolTip(() => Finder.Child(AutomationSearchCondition.ByControlType(ControlType.ToolTip)));

	public PrimaryUIItemFactory(AutomationElementFinder finder)
		: base(finder)
	{
	}

	public virtual TitleBar GetTitleBar(ActionListener actionListener)
	{
		AutomationElement val = Finder.Child(AutomationSearchCondition.ByControlType(ControlType.TitleBar));
		if (val == (AutomationElement)null)
		{
			return null;
		}
		return new TitleBar(val, actionListener);
	}

	public virtual PopUpMenu WPFPopupMenu(ActionListener actionListener)
	{
		AutomationSearchCondition[] searchConditions = new AutomationSearchCondition[2]
		{
			AutomationSearchCondition.ByControlType(ControlType.Window),
			AutomationSearchCondition.ByControlType(ControlType.Menu)
		};
		TryGetPopupMenu(searchConditions, actionListener, out var popUpMenu);
		return popUpMenu;
	}

	public virtual bool TryGetPopupMenu(ActionListener actionListener, out PopUpMenu popUpMenu)
	{
		AutomationSearchCondition[] searchConditions = new AutomationSearchCondition[1] { AutomationSearchCondition.ByControlType(ControlType.Menu).OfName("DropDown") };
		return TryGetPopupMenu(searchConditions, actionListener, out popUpMenu);
	}

	private bool TryGetPopupMenu(AutomationSearchCondition[] searchConditions, ActionListener actionListener, out PopUpMenu popUpMenu)
	{
		AutomationElement val = Retry.For(() => Finder.Child(searchConditions), CoreAppXmlConfiguration.Instance.PopupTimeout(), TimeSpan.FromMilliseconds(100.0));
		if (val == (AutomationElement)null)
		{
			popUpMenu = null;
			return false;
		}
		popUpMenu = new PopUpMenu(val, actionListener);
		return true;
	}

	public virtual IUIItem Create(SearchCriteria searchCriteria, ActionListener actionListener)
	{
		if (searchCriteria.IsIndexed)
		{
			UIItemCollection collection = CreateAll(searchCriteria, actionListener);
			return searchCriteria.IndexedItem(collection);
		}
		return dictionaryMappedItemFactory.Create(Finder.Descendant(searchCriteria.AutomationCondition), actionListener, searchCriteria.CustomItemType);
	}

	public virtual UIItemCollection CreateAll(SearchCriteria searchCriteria, ActionListener actionListener)
	{
		return new UIItemCollection(Finder.Descendants(searchCriteria.AutomationSearchCondition), actionListener, searchCriteria.CustomItemType);
	}

	public virtual Image WinFormImage(string primaryIdentification, ActionListener actionListener)
	{
		AutomationElement automationElement = Finder.Descendant(SearchCriteria.ByAutomationId(primaryIdentification).AutomationCondition);
		return new Image(automationElement, actionListener);
	}

	public virtual UIItemCollection ItemsWithin(Rect bounds, ActionListener actionListener)
	{
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		UIItemCollection uIItemCollection = new UIItemCollection();
		List<AutomationElement> list = Finder.Descendants(AutomationSearchCondition.All);
		foreach (AutomationElement item in list)
		{
			AutomationElementInformation current2 = item.get_Current();
			if (((Rect)(ref bounds)).Contains(((AutomationElementInformation)(ref current2)).get_BoundingRectangle()))
			{
				DictionaryMappedItemFactory dictionaryMappedItemFactory = new DictionaryMappedItemFactory();
				uIItemCollection.Add(dictionaryMappedItemFactory.Create(item, actionListener));
			}
		}
		return uIItemCollection;
	}
}
