using System.Windows.Automation;
using White.Core.UIItems.Actions;

namespace White.Core.UIItems.ListBoxItems;

[PlatformSpecificItem]
public class Win32ListItem : ListItem
{
	private bool DoCheck
	{
		set
		{
			if (Checked != value)
			{
				Select();
				if (Checked != value)
				{
					Select();
				}
			}
		}
	}

	public override bool Checked
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0010: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			ToggleState val = (ToggleState)Property(TogglePattern.ToggleStateProperty);
			return ((object)val).Equals((object)(ToggleState)1);
		}
	}

	protected Win32ListItem()
	{
	}

	public Win32ListItem(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	public override void Check()
	{
		DoCheck = true;
	}

	public override void UnCheck()
	{
		DoCheck = false;
	}
}
