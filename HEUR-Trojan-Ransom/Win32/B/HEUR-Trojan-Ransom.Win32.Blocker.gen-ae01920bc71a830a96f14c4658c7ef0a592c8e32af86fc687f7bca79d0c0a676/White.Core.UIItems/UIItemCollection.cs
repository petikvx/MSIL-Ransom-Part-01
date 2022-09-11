using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Automation;
using White.Core.Factory;
using White.Core.Mappings;
using White.Core.UIA;
using White.Core.UIItems.Actions;
using log4net;

namespace White.Core.UIItems;

public class UIItemCollection : List<IUIItem>
{
	private static readonly DictionaryMappedItemFactory DictionaryMappedItemFactory = new DictionaryMappedItemFactory();

	private readonly ILog logger = LogManager.GetLogger(typeof(UIItemCollection));

	public UIItemCollection(params UIItem[] uiItems)
	{
		AddRange(uiItems);
	}

	public UIItemCollection(IEnumerable entities)
		: base(entities.OfType<IUIItem>())
	{
	}

	public UIItemCollection(IEnumerable<AutomationElement> automationElements, ActionListener actionListener)
		: this(automationElements, DictionaryMappedItemFactory, actionListener)
	{
	}

	public UIItemCollection(IEnumerable automationElements, ActionListener actionListener)
		: this(automationElements, DictionaryMappedItemFactory, actionListener)
	{
	}

	public UIItemCollection(IEnumerable automationElements, UIItemFactory uiItemFactory, ActionListener actionListener)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		foreach (AutomationElement automationElement2 in automationElements)
		{
			AutomationElement automationElement = automationElement2;
			IUIItem iUIItem = uiItemFactory.Create(automationElement, actionListener);
			if (iUIItem != null)
			{
				Add(iUIItem);
			}
		}
	}

	public UIItemCollection(IEnumerable automationElements, ActionListener actionListener, Type customItemType)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		foreach (AutomationElement automationElement2 in automationElements)
		{
			AutomationElement automationElement = automationElement2;
			try
			{
				if (automationElement.IsPrimaryControl())
				{
					IUIItem iUIItem = DictionaryMappedItemFactory.Create(automationElement, actionListener, customItemType);
					if (iUIItem != null)
					{
						Add(iUIItem);
					}
				}
			}
			catch (ControlDictionaryException)
			{
				logger.WarnFormat("Couldn't create UIItem for AutomationElement, {0}", (object)automationElement.Display());
			}
		}
	}
}
