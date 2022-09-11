using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.Configuration;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.TableItems;

public class TableHeader : UIItem
{
	public virtual TableColumns Columns
	{
		get
		{
			List<AutomationElement> collection = new AutomationElementFinder(automationElement).Descendants(AutomationSearchCondition.ByControlType(ControlType.Header));
			List<AutomationElement> automationElements = new List<AutomationElement>(collection).FindAll(delegate(AutomationElement obj)
			{
				//IL_0001: Unknown result type (might be due to invalid IL or missing references)
				//IL_0006: Unknown result type (might be due to invalid IL or missing references)
				AutomationElementInformation current = obj.get_Current();
				return !((AutomationElementInformation)(ref current)).get_Name().StartsWith(UIItemIdAppXmlConfiguration.Instance.TableColumn);
			});
			return new TableColumns(automationElements, actionListener);
		}
	}

	protected TableHeader()
	{
	}

	public TableHeader(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}
}
