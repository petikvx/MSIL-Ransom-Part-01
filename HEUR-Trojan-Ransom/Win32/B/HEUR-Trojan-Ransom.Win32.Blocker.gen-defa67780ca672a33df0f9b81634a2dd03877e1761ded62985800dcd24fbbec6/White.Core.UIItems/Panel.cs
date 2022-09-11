using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems;

public class Panel : UIItemContainer
{
	public virtual string Text => Name;

	protected Panel()
	{
	}

	public Panel(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}
}
