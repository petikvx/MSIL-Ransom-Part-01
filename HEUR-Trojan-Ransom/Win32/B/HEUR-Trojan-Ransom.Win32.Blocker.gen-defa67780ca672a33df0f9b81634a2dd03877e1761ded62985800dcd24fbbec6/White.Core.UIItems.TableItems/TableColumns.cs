using System.Collections.Generic;
using System.Linq;
using System.Windows.Automation;
using White.Core.Configuration;
using White.Core.Factory;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.TableItems;

public class TableColumns : UIItemList<TableColumn>
{
	public virtual TableColumn this[string text]
	{
		get
		{
			TableColumn tableColumn = Find((TableColumn obj) => obj.Name.Equals(text));
			if (tableColumn == null)
			{
				throw new UIItemSearchException(string.Format("Cannot find column with text {0}. Found columns: {1}", text, string.Join(",", this.Select((TableColumn i) => i.ToString()).ToArray())));
			}
			return tableColumn;
		}
	}

	public TableColumns(IEnumerable<AutomationElement> automationElements, ActionListener actionListener)
	{
		int num = 0;
		foreach (AutomationElement automationElement in automationElements)
		{
			if (!HeaderColumn(automationElement))
			{
				Add(new TableColumn(automationElement, actionListener, num++));
			}
		}
	}

	private static bool HeaderColumn(AutomationElement automationElement)
	{
		return automationElement.GetCurrentPropertyValue(AutomationElement.NameProperty).Equals(UIItemIdAppXmlConfiguration.Instance.TableTopLeftHeaderCell);
	}
}
