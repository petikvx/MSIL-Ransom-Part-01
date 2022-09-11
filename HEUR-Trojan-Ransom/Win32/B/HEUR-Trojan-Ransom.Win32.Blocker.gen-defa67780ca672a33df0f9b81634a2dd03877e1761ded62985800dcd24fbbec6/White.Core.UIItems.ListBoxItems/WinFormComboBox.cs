using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.ListBoxItems;

[PlatformSpecificItem]
public class WinFormComboBox : ComboBox
{
	public virtual string Text
	{
		get
		{
			return GetTextBox().Text;
		}
		set
		{
			GetTextBox().Text = value;
		}
	}

	protected WinFormComboBox()
	{
	}

	public WinFormComboBox(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	private TextBox GetTextBox()
	{
		return new TextBox(finder.Child(AutomationSearchCondition.ByControlType(ControlType.Edit)), actionListener);
	}
}
