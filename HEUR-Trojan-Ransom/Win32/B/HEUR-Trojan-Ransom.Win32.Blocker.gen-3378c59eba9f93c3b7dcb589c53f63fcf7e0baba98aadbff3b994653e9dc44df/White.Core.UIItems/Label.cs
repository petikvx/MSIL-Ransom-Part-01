using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems;

public class Label : UIItem
{
	public virtual string Text => (string)Property(AutomationElement.NameProperty);

	protected Label()
	{
	}

	public Label(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}
}
