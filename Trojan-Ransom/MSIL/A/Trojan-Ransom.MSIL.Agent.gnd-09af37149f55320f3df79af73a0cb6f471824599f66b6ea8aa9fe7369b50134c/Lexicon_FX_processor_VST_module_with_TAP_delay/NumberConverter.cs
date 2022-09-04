using System;
using System.Collections;
using ns6;

namespace Lexicon_FX_processor_VST_module_with_TAP_delay;

public sealed class NumberConverter
{
	public enum Currency
	{
		const_0,
		Dollar,
		Sum
	}

	public enum Language
	{
		const_0,
		English,
		Uzbek
	}

	internal static SortedList sortedList_0;

	internal static SortedList sortedList_1;

	internal static SortedList sortedList_2;

	private static ArrayList arrayList_0;

	internal static ArrayList arrayList_1;

	internal static string string_0 = "";

	public unsafe static string smethod_0(string string_1, Language language_0, Currency currency_0)
	{
		void* ptr = stackalloc byte[25];
		try
		{
			Class27.smethod_76(currency_0, language_0);
		}
		catch
		{
		}
		((byte*)ptr)[24] = 0;
		string text = string_1;
		text += ",00";
		arrayList_0 = new ArrayList();
		arrayList_1 = new ArrayList();
		char[] separator = new char[2] { '.', ',' };
		string[] array = text.Split(separator);
		text = array[0];
		if (array[1] == "00")
		{
			((byte*)ptr)[24] = 1;
		}
		while (text != "")
		{
			try
			{
				arrayList_0.Add(text.Substring(text.Length - 3, 3));
				text = text.Remove(text.Length - 3, 3);
			}
			catch
			{
				arrayList_0.Add(text.PadLeft(3, '0'));
				text = "";
			}
		}
		arrayList_0.Insert(0, array[1].PadLeft(3, '0'));
		string text2 = "";
		*(int*)ptr = 0;
		while (*(int*)ptr < arrayList_0.Count)
		{
			string text3 = (string)arrayList_0[*(int*)ptr];
			*(int*)((byte*)ptr + 4) = Convert.ToInt32(text3[0].ToString());
			*(int*)((byte*)ptr + 8) = Convert.ToInt32(text3[1].ToString());
			*(int*)((byte*)ptr + 12) = Convert.ToInt32(text3[2].ToString());
			text2 = "";
			text3.ToString();
			try
			{
				text2 = string.Concat(text2, sortedList_0[*(int*)((byte*)ptr + 4) * 100], " ");
			}
			catch
			{
			}
			if (language_0 == Language.English && text2 != " " && *(int*)ptr != 0 && ((int*)((byte*)ptr + 8))->ToString() + *(int*)((byte*)ptr + 12) != "00")
			{
				text2 += " and ";
			}
			*(int*)((byte*)ptr + 16) = Convert.ToInt32(text3.Substring(1, 2));
			if ((*(int*)((byte*)ptr + 16) <= 9 || *(int*)((byte*)ptr + 16) >= 21) && *(int*)((byte*)ptr + 16) != 30 && *(int*)((byte*)ptr + 16) != 40 && *(int*)((byte*)ptr + 16) != 50 && *(int*)((byte*)ptr + 16) != 60 && *(int*)((byte*)ptr + 16) != 70 && *(int*)((byte*)ptr + 16) != 80 && *(int*)((byte*)ptr + 16) != 90)
			{
				if ((currency_0 == Currency.const_0 && (*(int*)ptr == 2 || *(int*)ptr == 0)) || (currency_0 == Currency.Sum && *(int*)ptr == 2))
				{
					text2 += sortedList_0[*(int*)((byte*)ptr + 8) * 10];
					if (*(int*)((byte*)ptr + 12) > 0 && *(int*)((byte*)ptr + 12) < 3)
					{
						object obj4 = text2;
						text2 = string.Concat(obj4, " ", sortedList_1[*(int*)((byte*)ptr + 12)], ".", ((int*)((byte*)ptr + 12))->ToString());
					}
					else
					{
						object obj5 = text2;
						text2 = string.Concat(obj5, " ", sortedList_0[*(int*)((byte*)ptr + 12)], ".", ((int*)((byte*)ptr + 12))->ToString());
					}
				}
				else
				{
					text2 += sortedList_0[*(int*)((byte*)ptr + 8) * 10];
					object obj6 = text2;
					text2 = string.Concat(obj6, " ", sortedList_0[*(int*)((byte*)ptr + 12)], ".", ((int*)((byte*)ptr + 12))->ToString());
				}
			}
			else
			{
				object obj7 = text2;
				text2 = string.Concat(obj7, sortedList_0[*(int*)((byte*)ptr + 16)], ".", ((int*)((byte*)ptr + 16))->ToString(), " ");
			}
			arrayList_1.Add(text2);
			(*(int*)ptr)++;
		}
		if (language_0 == Language.const_0)
		{
			Class27.smethod_30(((byte*)ptr)[24] != 0, currency_0);
		}
		else
		{
			Class27.smethod_88(currency_0, ((byte*)ptr)[24] != 0);
		}
		string[] array2 = string_0.Split(new char[1] { ' ' });
		string_0 = "";
		string[] array3 = array2;
		*(int*)((byte*)ptr + 20) = 0;
		while (*(int*)((byte*)ptr + 20) < array3.Length)
		{
			string text4 = array3[*(int*)((byte*)ptr + 20)];
			if (text4 != "")
			{
				string_0 = string_0 + text4 + " ";
			}
			(*(int*)((byte*)ptr + 20))++;
		}
		return string_0;
	}
}
