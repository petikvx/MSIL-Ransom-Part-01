using System.Collections.Generic;
using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.TableItems;

public class NullTableHeader : TableHeader
{
	public override TableColumns Columns => new TableColumns(new List<AutomationElement>(), new NullActionListener());
}
