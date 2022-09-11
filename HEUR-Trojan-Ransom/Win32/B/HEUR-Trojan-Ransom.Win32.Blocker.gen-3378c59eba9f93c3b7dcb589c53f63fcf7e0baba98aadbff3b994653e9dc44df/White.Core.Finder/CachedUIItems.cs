using System;
using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Factory;
using White.Core.Mappings;
using White.Core.UIItems;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;

namespace White.Core.Finder;

public class CachedUIItems
{
	private readonly List<AutomationElement> list = new List<AutomationElement>();

	private readonly DictionaryMappedItemFactory dictionaryMappedItemFactory = new DictionaryMappedItemFactory();

	private UIItemCollection uiItemCollection;

	public virtual int Count => list.Count;

	private CachedUIItems()
	{
	}

	public static CachedUIItems CreateAndCachePrimaryChildControls(AutomationElement parent, InitializeOption option)
	{
		CachedUIItems cachedUIItems = new CachedUIItems();
		cachedUIItems.FindAll(parent, option);
		cachedUIItems.list.Sort(new AutomationElementPositionComparer());
		return cachedUIItems;
	}

	private void FindAll(AutomationElement automationElement, InitializeOption option)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		AutomationElementFinder automationElementFinder = new AutomationElementFinder(automationElement);
		List<AutomationElement> list = automationElementFinder.Children(AutomationSearchCondition.All);
		ControlDictionary instance = ControlDictionary.Instance;
		foreach (AutomationElement item in list)
		{
			AutomationElementInformation current2 = item.get_Current();
			if (!instance.IsControlTypeSupported(((AutomationElementInformation)(ref current2)).get_ControlType()))
			{
				continue;
			}
			AutomationElementInformation current3 = item.get_Current();
			ControlType controlType = ((AutomationElementInformation)(ref current3)).get_ControlType();
			AutomationElementInformation current4 = item.get_Current();
			if (instance.IsPrimaryControl(controlType, ((AutomationElementInformation)(ref current4)).get_ClassName(), null))
			{
				this.list.Add(item);
			}
			AutomationElementInformation current5 = item.get_Current();
			if (instance.HasPrimaryChildren(((AutomationElementInformation)(ref current5)).get_ControlType()))
			{
				AutomationElementInformation current6 = item.get_Current();
				if (!instance.IsExcluded(((AutomationElementInformation)(ref current6)).get_ControlType()))
				{
					FindAll(item, option);
				}
			}
		}
	}

	public virtual UIItemCollection GetAll(Predicate<AutomationElement> predicate, UIItemFactory factory, ActionListener actionListener)
	{
		List<AutomationElement> automationElements = list.FindAll(predicate);
		return new UIItemCollection(automationElements, factory, actionListener);
	}

	public virtual UIItemCollection UIItems(ActionListener actionListener)
	{
		if (uiItemCollection != null)
		{
			return uiItemCollection;
		}
		uiItemCollection = new UIItemCollection();
		foreach (AutomationElement item in list)
		{
			uiItemCollection.Add(dictionaryMappedItemFactory.Create(item, actionListener));
		}
		return uiItemCollection;
	}

	public virtual IUIItem Get(SearchCriteria searchCriteria, ActionListener actionListener)
	{
		return Get(searchCriteria, actionListener, dictionaryMappedItemFactory);
	}

	public virtual UIItemCollection GetAll(SearchCriteria searchCriteria, ActionListener actionListener)
	{
		return GetAll(searchCriteria, actionListener, dictionaryMappedItemFactory);
	}

	public virtual IUIItem Get(SearchCriteria searchCriteria, ActionListener actionListener, UIItemFactory factory)
	{
		List<AutomationElement> list = searchCriteria.Filter(this.list);
		if (list.Count == 0)
		{
			return null;
		}
		return factory.Create(list[0], actionListener);
	}

	public virtual T Get<T>(SearchCriteria searchCriteria, ActionListener actionListener) where T : UIItem
	{
		return Get<T>(searchCriteria, actionListener, dictionaryMappedItemFactory);
	}

	public virtual T Get<T>(SearchCriteria searchCriteria, ActionListener actionListener, UIItemFactory factory) where T : UIItem
	{
		return (T)Get(searchCriteria.AndControlType(typeof(T)), actionListener, factory);
	}

	private UIItemCollection GetAll(SearchCriteria searchCriteria, ActionListener actionListener, UIItemFactory factory)
	{
		List<AutomationElement> list = searchCriteria.Filter(this.list);
		return new UIItemCollection(list.ToArray(), factory, actionListener);
	}
}
