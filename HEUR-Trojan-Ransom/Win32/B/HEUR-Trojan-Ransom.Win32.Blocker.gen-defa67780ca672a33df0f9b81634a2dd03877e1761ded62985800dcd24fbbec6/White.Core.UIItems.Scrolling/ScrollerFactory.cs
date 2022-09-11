using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.Scrolling;

internal class ScrollerFactory
{
	internal static IScrollBars CreateBars(AutomationElement parentElement, ActionListener listener)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		AutomationElementInformation current = parentElement.get_Current();
		string frameworkId = ((AutomationElementInformation)(ref current)).get_FrameworkId();
		if (frameworkId == "WPF")
		{
			return new WPFScrollBars(parentElement, listener);
		}
		if (frameworkId == "Silverlight")
		{
			return new ScrollBars(parentElement, listener, new SilverlightHScrollBarButtonAutomationIds(), new SilverlightVScrollBarButtonAutomationIds());
		}
		return new ScrollBars(parentElement, listener, new DefaultScrollBarButtonAutomationIds(), new DefaultScrollBarButtonAutomationIds());
	}
}
