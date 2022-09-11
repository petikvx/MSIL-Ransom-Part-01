using System;
using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Configuration;
using White.Core.UIItems.Actions;
using White.Core.UIItems.TableItems;

namespace White.Core.Factory;

public class TableRowFactory
{
	private readonly AutomationElementFinder automationElementFinder;

	private static readonly Predicate<AutomationElement> RowPredicate;

	public virtual int NumberOfRows => GetRowElements().Count;

	static TableRowFactory()
	{
		RowPredicate = delegate(AutomationElement element)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current = element.get_Current();
			if (((AutomationElementInformation)(ref current)).get_Name().StartsWith(UIItemIdAppXmlConfiguration.Instance.TableColumn))
			{
				AutomationElementInformation current2 = element.get_Current();
				return ((AutomationElementInformation)(ref current2)).get_Name().Split(new char[1] { ' ' }).Length == 2;
			}
			return false;
		};
	}

	public TableRowFactory(AutomationElementFinder automationElementFinder)
	{
		this.automationElementFinder = automationElementFinder;
	}

	public virtual TableRows CreateRows(ActionListener actionListener, TableHeader tableHeader)
	{
		List<AutomationElement> rowElements = GetRowElements();
		return new TableRows(rowElements, actionListener, tableHeader, new TableCellFactory(automationElementFinder.AutomationElement, actionListener));
	}

	private List<AutomationElement> GetRowElements()
	{
		List<AutomationElement> collection = automationElementFinder.Descendants(AutomationSearchCondition.ByControlType(ControlType.Custom));
		List<AutomationElement> list = new List<AutomationElement>(collection);
		return list.FindAll(RowPredicate);
	}
}
