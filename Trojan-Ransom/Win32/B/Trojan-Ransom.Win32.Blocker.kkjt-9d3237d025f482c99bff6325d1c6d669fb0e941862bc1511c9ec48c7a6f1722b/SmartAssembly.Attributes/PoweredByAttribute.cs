using System;
using System.Security;
using System.Windows.Forms;
using SmartAssembly.Shared;
using ns0;

namespace SmartAssembly.Attributes;

public sealed class PoweredByAttribute : Attribute
{
	public PoweredByAttribute(string string_0)
	{
	}

	[SecuritySafeCritical]
	static PoweredByAttribute()
	{
		AppPathFinder.smethod_3();
	}

	[SecuritySafeCritical]
	internal static void smethod_0(Control control_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 86:
				Class0.smethod_9(control_0, 686, 651);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_1(ButtonBase buttonBase_0, FlatStyle flatStyle_0, int int_0, int int_1)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 6:
				Class4.smethod_4(buttonBase_0, flatStyle_0, 961, 982);
				return;
			}
		}
	}

	[SecuritySafeCritical]
	internal static ControlCollection smethod_2(Control control_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 65:
				return Class4.Class5.smethod_0(control_0, 396, 389);
			}
		}
	}

	[SecuritySafeCritical]
	internal static void smethod_3(AppDomain appDomain_0, ResolveEventHandler resolveEventHandler_0, int int_0, int int_1)
	{
		while (true)
		{
			switch (int_1 ^ int_0)
			{
			case 36:
				Class4.smethod_5(appDomain_0, resolveEventHandler_0, 65, 58);
				return;
			}
		}
	}
}
