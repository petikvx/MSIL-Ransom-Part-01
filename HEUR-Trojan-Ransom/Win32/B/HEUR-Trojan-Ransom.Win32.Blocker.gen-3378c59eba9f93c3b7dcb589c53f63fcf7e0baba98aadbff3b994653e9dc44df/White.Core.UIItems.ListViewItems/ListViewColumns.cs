using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.Factory;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.ListViewItems;

public class ListViewColumns : UIItemList<ListViewColumn>
{
	public virtual ListViewColumn this[string text]
	{
		get
		{
			ListViewColumn listViewColumn = Find((ListViewColumn obj) => obj.Name.Equals(text));
			if (listViewColumn == null)
			{
				throw new UIItemSearchException("Cannot find column with text " + text);
			}
			return listViewColumn;
		}
	}

	public ListViewColumns(List<AutomationElement> automationElementCollection, ActionListener actionListener)
	{
		int num = 0;
		foreach (AutomationElement item in automationElementCollection)
		{
			Add(new ListViewColumn(item, actionListener, num++));
		}
	}
}
