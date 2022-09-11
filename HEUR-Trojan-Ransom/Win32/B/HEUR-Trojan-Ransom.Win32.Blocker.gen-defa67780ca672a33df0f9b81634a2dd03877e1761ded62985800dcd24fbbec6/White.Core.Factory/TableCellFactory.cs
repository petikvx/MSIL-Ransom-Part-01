using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Configuration;
using White.Core.UIItems.Actions;
using White.Core.UIItems.TableItems;

namespace White.Core.Factory;

public class TableCellFactory
{
	private readonly AutomationElement tableElement;

	private readonly ActionListener actionListener;

	private List<AutomationElement> customControlTypes;

	public TableCellFactory(AutomationElement tableElement, ActionListener actionListener)
	{
		this.tableElement = tableElement;
		this.actionListener = actionListener;
	}

	public virtual TableCells CreateCells(TableHeader tableHeader, AutomationElement rowElement)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		if (customControlTypes == null)
		{
			customControlTypes = new AutomationElementFinder(tableElement).Descendants(AutomationSearchCondition.ByControlType(ControlType.Custom));
		}
		AutomationElementInformation current = rowElement.get_Current();
		int zeroBasedRowNumber = int.Parse(((AutomationElementInformation)(ref current)).get_Name().Split(new char[1] { ' ' }).Last());
		Predicate<AutomationElement> match = delegate(AutomationElement element)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			AutomationElementInformation current2 = element.get_Current();
			string name = ((AutomationElementInformation)(ref current2)).get_Name();
			return name.Contains(UIItemIdAppXmlConfiguration.Instance.TableCellPrefix) && zeroBasedRowNumber == int.Parse(name.Split(new char[1] { ' ' }).Last());
		};
		List<AutomationElement> tableCellElements = customControlTypes.FindAll(match);
		return new TableCells(tableCellElements, tableHeader, actionListener);
	}
}
