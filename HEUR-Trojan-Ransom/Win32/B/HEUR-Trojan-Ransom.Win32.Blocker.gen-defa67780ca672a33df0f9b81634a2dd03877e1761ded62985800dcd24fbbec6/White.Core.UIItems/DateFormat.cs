using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace White.Core.UIItems;

public class DateFormat
{
	public static DateFormat dayMonthYear = new DateFormat(DateUnit.Day, DateUnit.Month, DateUnit.Year);

	public static DateFormat dayYearMonth = new DateFormat(DateUnit.Day, DateUnit.Year, DateUnit.Month);

	public static DateFormat monthDayYear = new DateFormat(DateUnit.Month, DateUnit.Day, DateUnit.Year);

	public static DateFormat monthYearDay = new DateFormat(DateUnit.Month, DateUnit.Year, DateUnit.Day);

	public static DateFormat yearMonthDay = new DateFormat(DateUnit.Year, DateUnit.Month, DateUnit.Day);

	public static DateFormat yearDayMonth = new DateFormat(DateUnit.Year, DateUnit.Day, DateUnit.Month);

	private readonly List<DateUnit> dateUnits = new List<DateUnit>();

	public static DateFormat CultureDefault
	{
		get
		{
			DateTimeFormatInfo dateTimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
			string shortDatePattern = dateTimeFormat.ShortDatePattern;
			return Create(dateTimeFormat.DateSeparator, shortDatePattern);
		}
	}

	protected DateFormat()
	{
	}

	private DateFormat(params DateUnit[] unitsInOrder)
	{
		dateUnits.AddRange(unitsInOrder);
	}

	public static DateFormat Create(string dateSeparator, string pattern)
	{
		string[] array = pattern.Split(dateSeparator.ToCharArray());
		DateFormat dateFormat = new DateFormat();
		string[] array2 = array;
		foreach (string text in array2)
		{
			if (text.ToLower().Contains("d"))
			{
				dateFormat.dateUnits.Add(DateUnit.Day);
			}
			else if (text.ToLower().Contains("m"))
			{
				dateFormat.dateUnits.Add(DateUnit.Month);
			}
			else if (text.ToLower().Contains("yy"))
			{
				dateFormat.dateUnits.Add(DateUnit.Year);
			}
		}
		return dateFormat;
	}

	public static DateFormat Parse(string @string)
	{
		string[] array = @string.Split(new char[1] { ',' });
		DateFormat dateFormat = new DateFormat();
		string[] array2 = array;
		foreach (string value in array2)
		{
			DateUnit item = (DateUnit)Enum.Parse(typeof(DateUnit), value);
			dateFormat.dateUnits.Add(item);
		}
		return dateFormat;
	}

	public virtual int DisplayValue(DateTime dateTime, int index)
	{
		return dateUnits[index] switch
		{
			DateUnit.Day => dateTime.Day, 
			DateUnit.Month => dateTime.Month, 
			DateUnit.Year => dateTime.Year, 
			_ => throw new WhiteAssertionException(), 
		};
	}

	public override string ToString()
	{
		return dateUnits.ToString();
	}

	public override bool Equals(object other)
	{
		if (!(other is DateFormat dateFormat))
		{
			return false;
		}
		return ItemwiseEquals(dateUnits, dateFormat.dateUnits);
	}

	private bool ItemwiseEquals<T>(List<T> list, List<T> other)
	{
		if (other != null && other.Count == list.Count)
		{
			return !list.Where((T t, int i) => !other[i].Equals(t)).Any();
		}
		return false;
	}

	public override int GetHashCode()
	{
		return dateUnits[0].GetHashCode() + 3 * dateUnits[1].GetHashCode() + 5 * dateUnits[2].GetHashCode();
	}
}
