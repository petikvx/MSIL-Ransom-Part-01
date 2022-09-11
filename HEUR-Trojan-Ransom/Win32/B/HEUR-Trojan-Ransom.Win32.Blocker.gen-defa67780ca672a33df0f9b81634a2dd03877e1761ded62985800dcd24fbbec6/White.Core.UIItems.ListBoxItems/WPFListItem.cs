using System.Windows.Automation;
using White.Core.AutomationElementSearch;
using White.Core.UIItems.Actions;
using White.Core.UIItems.Finders;

namespace White.Core.UIItems.ListBoxItems;

[PlatformSpecificItem]
public class WPFListItem : ListItem
{
	private readonly AutomationElementFinder finder;

	private CheckBox CheckBox => (CheckBox)factory.Create(SearchCriteria.ByControlType(ControlType.CheckBox), actionListener);

	public override bool Checked => CheckBox.Checked;

	public override string Text
	{
		get
		{
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			AutomationElement val = finder.FindChildRaw(AutomationSearchCondition.ByControlType(ControlType.Text));
			if (val == (AutomationElement)null)
			{
				return base.Text;
			}
			AutomationElementInformation current = val.get_Current();
			return ((AutomationElementInformation)(ref current)).get_Name();
		}
	}

	protected WPFListItem()
	{
	}

	public WPFListItem(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
		finder = new AutomationElementFinder(automationElement);
	}

	public override void Check()
	{
		if (!Checked)
		{
			CheckBox.Click();
		}
	}

	public override void UnCheck()
	{
		if (Checked)
		{
			CheckBox.Click();
		}
	}
}
