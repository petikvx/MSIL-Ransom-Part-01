using System;
using System.Collections;
using System.Configuration;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace sReLFYF2;

internal class m8meAX3U
{
	internal static void mrCiea1d(WindowsFormsApplicationBase windowsFormsApplicationBase_0, string[] string_0, int int_0)
	{
		switch (int_0 ^ 0x73F)
		{
		}
		windowsFormsApplicationBase_0.Run(string_0);
	}

	internal static void AIOqRRCE(bool bool_0, int int_0)
	{
		switch (int_0 ^ 0xA79F)
		{
		}
		Application.SetCompatibleTextRenderingDefault(bool_0);
	}

	internal static Type NXTa0utH(RuntimeTypeHandle runtimeTypeHandle_0, int int_0)
	{
		return (int_0 ^ 0x238B) switch
		{
			_ => Type.GetTypeFromHandle(runtimeTypeHandle_0), 
		};
	}

	internal static bool smethod_0(Hashtable hashtable_0, object object_0, int int_0)
	{
		return (int_0 ^ 0x2949) switch
		{
			_ => hashtable_0.ContainsKey(object_0), 
		};
	}

	internal static string NPSqfVK7(string string_0, string[] string_1, int int_0)
	{
		return (int_0 ^ 0x3BA5) switch
		{
			_ => Utils.GetResourceString(string_0, string_1), 
		};
	}

	internal static void hU1pH7xp(Hashtable hashtable_0, object object_0, object object_1, int int_0)
	{
		switch (int_0 ^ 0xE6A3)
		{
		}
		hashtable_0.Add(object_0, object_1);
	}

	internal static void L6HgMKrR(Exception exception_0, int int_0)
	{
		switch (int_0 ^ 0x520B)
		{
		}
		ProjectData.SetProjectError(exception_0);
	}

	internal static Exception XUdv6OGi(Exception exception_0, int int_0)
	{
		return (int_0 ^ 0xD9DC) switch
		{
			_ => exception_0.InnerException, 
		};
	}

	internal static string gGC2YcoR(Exception exception_0, int int_0)
	{
		return (int_0 ^ 0xBE41) switch
		{
			1 => exception_0.StackTrace, 
			2 => exception_0.ToString(), 
			_ => exception_0.Message, 
		};
	}

	internal static void dLT6t40X(Hashtable hashtable_0, object object_0, int int_0)
	{
		switch (int_0 ^ 0xF7EC)
		{
		}
		hashtable_0.Remove(object_0);
	}

	internal static object bErpAbl3(object object_0, int int_0)
	{
		return (int_0 ^ 0x19C6) switch
		{
			_ => RuntimeHelpers.GetObjectValue(object_0), 
		};
	}

	internal static bool o0skIe1t(object object_0, object object_1, int int_0)
	{
		return (int_0 ^ 0x34D8) switch
		{
			_ => object.ReferenceEquals(object_0, object_1), 
		};
	}

	internal static Assembly dI81vvrz(Type type_0, int int_0)
	{
		return (int_0 ^ 0xDF8B) switch
		{
			_ => type_0.Assembly, 
		};
	}

	internal static object IP31RkoT(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0, int int_0)
	{
		return (int_0 ^ 0x1902) switch
		{
			_ => resourceManager_0.GetObject(string_0, cultureInfo_0), 
		};
	}

	internal static string UgjrnhI4(ResourceManager resourceManager_0, string string_0, CultureInfo cultureInfo_0, int int_0)
	{
		return (int_0 ^ 0xD400) switch
		{
			_ => resourceManager_0.GetString(string_0, cultureInfo_0), 
		};
	}

	internal static SettingsBase kzDXJ49Y(SettingsBase settingsBase_0, int int_0)
	{
		return (SettingsBase)((int_0 ^ 0xE598) switch
		{
			_ => SettingsBase.Synchronized(settingsBase_0), 
		});
	}

	internal static bool JqSKVYsG(WindowsFormsApplicationBase windowsFormsApplicationBase_0, int int_0)
	{
		return (int_0 ^ 0x95C8) switch
		{
			_ => windowsFormsApplicationBase_0.get_SaveMySettingsOnExit(), 
		};
	}

	internal static void cRHK8kb3(ApplicationSettingsBase applicationSettingsBase_0, int int_0)
	{
		switch (int_0 ^ 0x5A1C)
		{
		}
		applicationSettingsBase_0.Save();
	}

	internal static void CypsVz5W(object object_0, int int_0)
	{
		switch (int_0 ^ 0x8D21)
		{
		}
		ObjectFlowControl.CheckForSyncLockOnValueType(object_0);
	}

	internal static void smethod_1(object object_0, int int_0)
	{
		switch (int_0 ^ 0xEEA6)
		{
		default:
			Monitor.Enter(object_0);
			break;
		case 1:
			Monitor.Exit(object_0);
			break;
		}
	}
}
