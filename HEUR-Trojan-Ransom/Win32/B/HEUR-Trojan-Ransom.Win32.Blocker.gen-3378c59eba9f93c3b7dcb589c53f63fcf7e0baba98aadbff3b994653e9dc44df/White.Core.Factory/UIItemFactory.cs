using System.Windows.Automation;
using White.Core.UIItems;
using White.Core.UIItems.Actions;

namespace White.Core.Factory;

public interface UIItemFactory
{
	IUIItem Create(AutomationElement automationElement, ActionListener actionListener);
}
