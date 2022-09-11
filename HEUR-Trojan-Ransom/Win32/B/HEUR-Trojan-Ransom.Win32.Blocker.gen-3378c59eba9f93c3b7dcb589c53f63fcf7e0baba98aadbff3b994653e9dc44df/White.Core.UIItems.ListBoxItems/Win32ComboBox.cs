using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Scrolling;

namespace White.Core.UIItems.ListBoxItems;

[PlatformSpecificItem]
public class Win32ComboBox : ComboBox
{
	public override IScrollBars ScrollBars
	{
		get
		{
			AutomationElement parentElement = new AutomationElementFinder(automationElement).Child(AutomationSearchCondition.ByAutomationId("ListBox"));
			if (scrollBars == null)
			{
				scrollBars = ScrollerFactory.CreateBars(parentElement, actionListener);
			}
			return scrollBars;
		}
	}

	protected Win32ComboBox()
	{
	}

	public Win32ComboBox(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}
}
