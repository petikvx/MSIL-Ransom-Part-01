using System;
using System.Windows.Automation;
using White.Core.Configuration;
using White.Core.UIItems.Actions;
using White.Core.WindowsAPI;

namespace White.Core.UIItems;

public class DateTimePicker : UIItem
{
	public virtual DateTime Date
	{
		get
		{
			return DateTime.Parse((string)Property(ValuePattern.ValueProperty));
		}
		set
		{
			SetDate(value, CoreAppXmlConfiguration.Instance.DefaultDateFormat);
		}
	}

	protected DateTimePicker()
	{
	}

	public DateTimePicker(AutomationElement automationElement, ActionListener actionListener)
		: base(automationElement, actionListener)
	{
	}

	public virtual void SetDate(DateTime dateTime, DateFormat dateFormat)
	{
		keyboard.Send(dateFormat.DisplayValue(dateTime, 0).ToString(), actionListener);
		keyboard.PressSpecialKey(KeyboardInput.SpecialKeys.RIGHT, actionListener);
		keyboard.Send(dateFormat.DisplayValue(dateTime, 1).ToString(), actionListener);
		keyboard.PressSpecialKey(KeyboardInput.SpecialKeys.RIGHT, actionListener);
		keyboard.Send(dateFormat.DisplayValue(dateTime, 2).ToString(), actionListener);
		keyboard.PressSpecialKey(KeyboardInput.SpecialKeys.RIGHT, actionListener);
	}
}
