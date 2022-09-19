using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using Microsoft.Win32.TaskScheduler.Properties;

namespace Microsoft.Win32.TaskScheduler;

[ComVisible(false)]
public static class TaskEnumGlobalizer
{
	public static string GetString(object enumValue)
	{
		return enumValue.GetType().Name switch
		{
			"DaysOfTheWeek" => GetCultureEquivalentString((DaysOfTheWeek)enumValue), 
			"MonthsOfTheYear" => GetCultureEquivalentString((MonthsOfTheYear)enumValue), 
			"TaskTriggerType" => BuildEnumString("TriggerType", enumValue), 
			"WhichWeek" => BuildEnumString("WW", enumValue), 
			"TaskActionType" => BuildEnumString("ActionType", enumValue), 
			"TaskState" => BuildEnumString("TaskState", enumValue), 
			_ => enumValue.ToString(), 
		};
	}

	private static string GetCultureEquivalentString(DaysOfTheWeek val)
	{
		if (val == DaysOfTheWeek.AllDays)
		{
			return Resources.DOWAllDays;
		}
		List<string> list = new List<string>(7);
		Array values = Enum.GetValues(val.GetType());
		for (int i = 0; i < values.Length - 1; i++)
		{
			if ((val & (DaysOfTheWeek)values.GetValue(i)) > (DaysOfTheWeek)0)
			{
				list.Add(DateTimeFormatInfo.CurrentInfo.GetDayName((DayOfWeek)i));
			}
		}
		return string.Join(Resources.ListSeparator, list.ToArray());
	}

	private static string GetCultureEquivalentString(MonthsOfTheYear val)
	{
		if (val == MonthsOfTheYear.AllMonths)
		{
			return Resources.MOYAllMonths;
		}
		List<string> list = new List<string>(12);
		Array values = Enum.GetValues(val.GetType());
		for (int i = 0; i < values.Length - 1; i++)
		{
			if ((val & (MonthsOfTheYear)values.GetValue(i)) > (MonthsOfTheYear)0)
			{
				list.Add(DateTimeFormatInfo.CurrentInfo.GetMonthName(i + 1));
			}
		}
		return string.Join(Resources.ListSeparator, list.ToArray());
	}

	private static string BuildEnumString(string preface, object enumValue)
	{
		string[] array = enumValue.ToString()!.Split(new string[1] { ", " }, StringSplitOptions.None);
		if (array.Length == 0)
		{
			return string.Empty;
		}
		for (int i = 0; i < array.Length; i++)
		{
			array[i] = Resources.ResourceManager.GetString(preface + array[i]);
		}
		return string.Join(Resources.ListSeparator, array);
	}
}
