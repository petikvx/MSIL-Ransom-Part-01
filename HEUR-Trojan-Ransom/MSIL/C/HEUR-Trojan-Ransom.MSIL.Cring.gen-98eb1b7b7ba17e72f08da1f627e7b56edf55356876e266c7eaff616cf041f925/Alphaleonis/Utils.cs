using System;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace Alphaleonis;

internal static class Utils
{
	internal static string ReplaceIgnoreCase(this string str, string oldValue, string newValue)
	{
		if (str == null)
		{
			throw new ArgumentNullException("str");
		}
		if (str.Trim().Length == 0)
		{
			return str;
		}
		if (oldValue == null)
		{
			throw new ArgumentNullException("oldValue");
		}
		if (oldValue.Trim().Length == 0)
		{
			throw new ArgumentException("String cannot be of zero length.");
		}
		StringBuilder stringBuilder = new StringBuilder(str.Length);
		bool flag = IsNullOrWhiteSpace(newValue);
		int num = 0;
		do
		{
			int num2;
			if ((num2 = str.IndexOf(oldValue, num, StringComparison.OrdinalIgnoreCase)) != -1)
			{
				int num3 = num2 - num;
				if (num3 != 0)
				{
					stringBuilder.Append(str, num, num3);
				}
				if (!flag)
				{
					stringBuilder.Append(newValue);
				}
				num = num2 + oldValue.Length;
				continue;
			}
			int count = str.Length - num;
			stringBuilder.Append(str, num, count);
			return stringBuilder.ToString();
		}
		while (num != str.Length);
		return stringBuilder.ToString();
	}

	[SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
	public static string GetEnumDescription(Enum enumValue)
	{
		string text = enumValue.ToString();
		DescriptionAttribute[] array = (DescriptionAttribute[])enumValue.GetType().GetField(text)!.GetCustomAttributes(typeof(DescriptionAttribute), inherit: false);
		if (array.Length == 0)
		{
			return text;
		}
		return array[0].Description;
	}

	public static bool IsNotNull<T>(T obj)
	{
		return !object.Equals(null, obj);
	}

	public static bool IsNullOrWhiteSpace(string value)
	{
		if (value != null)
		{
			int i = 0;
			for (int length = value.Length; i < length; i++)
			{
				if (!char.IsWhiteSpace(value[i]))
				{
					return false;
				}
			}
		}
		return true;
	}

	public static string UnitSizeToText<T>(T numberOfBytes)
	{
		return UnitSizeToText(numberOfBytes, CultureInfo.CurrentCulture);
	}

	public static string UnitSizeToText<T>(T numberOfBytes, CultureInfo cultureInfo)
	{
		string[] array = new string[9] { "B", "KB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
		int num = 0;
		double num2 = Convert.ToDouble(numberOfBytes, CultureInfo.InvariantCulture);
		if (num2 < 0.0)
		{
			num2 = 0.0;
		}
		else
		{
			while (num2 > 1024.0)
			{
				num2 /= 1024.0;
				num++;
			}
		}
		return string.Format(cultureInfo, "{0} {1}", new object[2]
		{
			num2.ToString((num == 0) ? "0" : "0.##", cultureInfo),
			array[num]
		});
	}

	public static int CombineHashCodesOf<T1, T2>(T1 arg1, T2 arg2)
	{
		return (391 + (arg1?.GetHashCode() ?? 0)) * 23 + (arg2?.GetHashCode() ?? 0);
	}

	public static int CombineHashCodesOf<T1, T2, T3>(T1 arg1, T2 arg2, T3 arg3)
	{
		return CombineHashCodesOf(arg1, arg2) * 23 + (arg3?.GetHashCode() ?? 0);
	}

	public static int CombineHashCodesOf<T1, T2, T3, T4>(T1 arg1, T2 arg2, T3 arg3, T4 arg4)
	{
		return CombineHashCodesOf(CombineHashCodesOf(arg1, arg2), CombineHashCodesOf(arg3, arg4));
	}
}
