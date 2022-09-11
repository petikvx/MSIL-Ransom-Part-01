using System;
using System.Windows.Automation;

namespace White.Core.UIItems;

public class ToggleableItem : UIItem
{
	public virtual ToggleState State
	{
		get
		{
			//IL_000b: Unknown result type (might be due to invalid IL or missing references)
			return (ToggleState)Property(TogglePattern.ToggleStateProperty);
		}
		set
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			//IL_000a: Unknown result type (might be due to invalid IL or missing references)
			for (int i = 0; i < Enum.GetNames(typeof(ToggleState)).Length; i++)
			{
				if (State == value)
				{
					break;
				}
				Toggle();
				ActionPerformed();
			}
		}
	}

	public ToggleableItem(UIItem uiItem)
		: base(uiItem.AutomationElement, uiItem.ActionListener)
	{
	}

	public virtual void Toggle()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		TogglePattern val = (TogglePattern)Pattern(TogglePattern.Pattern);
		val.Toggle();
	}
}
