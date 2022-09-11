using System.Windows.Automation;
using White.Core.Configuration;
using White.Core.UIItems.Actions;
using White.Core.WindowsAPI;

namespace White.Core.UIItems.TableItems;

public class TableCell : UIItem
{
	public virtual object Value
	{
		get
		{
			object obj = Property(ValuePattern.ValueProperty);
			if (!UIItemIdAppXmlConfiguration.Instance.TableCellNullValue.Equals(obj))
			{
				return obj;
			}
			return string.Empty;
		}
		set
		{
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Expected O, but got Unknown
			actionListener.ActionPerforming(this);
			ValuePattern val = (ValuePattern)Pattern(ValuePattern.Pattern);
			if (value is string)
			{
				Click();
				val.SetValue(string.Empty);
				keyboard.Send((string)value, actionListener);
				keyboard.PressSpecialKey(KeyboardInput.SpecialKeys.TAB, actionListener);
			}
			else if (!Value.Equals(value.ToString()))
			{
				Click();
				val.SetValue(value.ToString());
			}
		}
	}

	protected TableCell()
	{
	}

	public TableCell(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	public override void Click()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		((InvokePattern)Pattern(InvokePattern.Pattern)).Invoke();
	}

	public override void RightClick()
	{
		new TooltipSafeMouse(UIItem.mouse).RightClickOutsideToolTip(this, actionListener);
	}

	public override void DoubleClick()
	{
		new TooltipSafeMouse(UIItem.mouse).DoubleClickOutsideToolTip(this, actionListener);
	}
}
