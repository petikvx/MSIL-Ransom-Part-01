using System.Windows.Automation;
using White.Core.Sessions;
using White.Core.UIItems.WindowItems;

namespace White.Core.Factory;

public interface SpecializedWindowFactory
{
	bool DoesSpecializeInThis(AutomationElement windowElement);

	Window Create(AutomationElement automationElement, InitializeOption initializeOption, WindowSession session);
}
