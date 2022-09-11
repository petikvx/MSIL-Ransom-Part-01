using System.Windows.Automation;
using White.Core.UIItems.Actions;
using White.Core.UIItems.ListViewItems;

namespace White.Core.UIItems;

[PlatformSpecificItem]
public class WinFormTextBox : TextBox
{
	public virtual SuggestionList SuggestionList => SuggestionListView.WaitAndFind(actionListener);

	public WinFormTextBox(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	public WinFormTextBox()
	{
	}
}
