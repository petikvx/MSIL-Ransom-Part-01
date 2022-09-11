using System;
using System.Windows.Automation;
using White.Core.Configuration;
using White.Core.UIItems;
using White.Core.UIItems.Actions;
using White.Core.Utility;

namespace White.Core.Factory;

public static class ToolTipFinder
{
	public static ToolTip FindToolTip(Func<AutomationElement> perform)
	{
		AutomationElement automationElement = Retry.For(perform, (AutomationElement element) => element == (AutomationElement)null, CoreAppXmlConfiguration.Instance.TooltipWaitTimeSpan());
		return new ToolTip(automationElement, new NullActionListener());
	}
}
