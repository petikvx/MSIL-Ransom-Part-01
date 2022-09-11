using System.Diagnostics;
using System.Windows.Automation;
using White.Core.Factory;
using White.Core.Sessions;
using White.Core.UIItems.Finders;
using White.Core.UIItems.MenuItems;

namespace White.Core.UIItems.WindowItems;

[PlatformSpecificItem]
internal class WPFWindow : Window
{
	private readonly WindowFactory windowFactory;

	public override PopUpMenu Popup => factory.WPFPopupMenu(this) ?? windowFactory.PopUp(this);

	protected WPFWindow()
	{
	}

	public WPFWindow(AutomationElement automationElement, WindowFactory windowFactory, InitializeOption initializeOption, WindowSession windowSession)
		: base(automationElement, initializeOption, windowSession)
	{
		this.windowFactory = windowFactory;
	}

	public override Window ModalWindow(string title, InitializeOption option)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		WindowFactory desktop = WindowFactory.Desktop;
		AutomationElementInformation current = automationElement.get_Current();
		return desktop.FindModalWindow(title, Process.GetProcessById(((AutomationElementInformation)(ref current)).get_ProcessId()), option, automationElement, WindowSession.ModalWindowSession(option));
	}

	public override Window ModalWindow(SearchCriteria searchCriteria, InitializeOption option)
	{
		WindowFactory desktop = WindowFactory.Desktop;
		return desktop.FindModalWindow(searchCriteria, option, automationElement, WindowSession.ModalWindowSession(option));
	}
}
