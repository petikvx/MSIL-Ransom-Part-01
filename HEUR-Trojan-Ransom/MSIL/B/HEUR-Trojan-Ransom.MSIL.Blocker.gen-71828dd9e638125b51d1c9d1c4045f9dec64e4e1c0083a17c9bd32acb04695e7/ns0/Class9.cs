using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using Microsoft.Win32;

namespace ns0;

internal static class Class9
{
	private static SecurityPermission securityPermission_0;

	private static UIPermission uipermission_0;

	private static UIPermission uipermission_1;

	[SecuritySafeCritical]
	internal static bool smethod_0()
	{
		try
		{
			smethod_1();
		}
		catch (SecurityException)
		{
			return false;
		}
		return true;
	}

	[SecurityCritical]
	internal static void smethod_1()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (securityPermission_0 == null)
		{
			securityPermission_0 = new SecurityPermission(SecurityPermissionFlag.UnmanagedCode);
		}
		((CodeAccessPermission)securityPermission_0).Demand();
	}

	public static Assembly smethod_2(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		if (!resolveEventArgs_0.Name.Contains("ar" + Class2.smethod_0()))
		{
			return null;
		}
		return Class11.appDomain_0.Load(Class10.smethod_0(Class4.smethod_0(), new byte[24]
		{
			5, 15, 24, 3, 69, 2, 7, 80, 2, 39,
			9, 13, 53, 56, 55, 21, 12, 10, 27, 48,
			4, 42, 37, 17
		}));
	}

	[SecurityCritical]
	internal static void smethod_3()
	{
	}

	[SecurityCritical]
	internal static void smethod_4()
	{
	}

	[SecurityCritical]
	internal static void smethod_5(string string_0)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		FileIOPermission val = new FileIOPermission(PermissionState.None);
		val.AddPathList((FileIOPermissionAccess)8, string_0);
		((CodeAccessPermission)val).Demand();
	}

	[SecuritySafeCritical]
	internal static void smethod_6(Type type_0)
	{
		RuntimeHelpers.RunClassConstructor(type_0.TypeHandle);
	}

	[SecuritySafeCritical]
	internal static Exception smethod_7(int int_0)
	{
		return Marshal.GetExceptionForHR(int_0, new IntPtr(-1));
	}

	[SecuritySafeCritical]
	internal static void smethod_8(int int_0)
	{
		Marshal.ThrowExceptionForHR(int_0, new IntPtr(-1));
	}

	[SecuritySafeCritical]
	internal static int smethod_9(Exception exception_0)
	{
		if (exception_0 == null)
		{
			throw new ArgumentNullException("exception");
		}
		int hRForException = Marshal.GetHRForException(exception_0);
		Marshal.GetHRForException(new Exception());
		return hRForException;
	}

	[SecurityCritical]
	internal static void smethod_10()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (uipermission_0 == null)
		{
			uipermission_0 = new UIPermission((UIPermissionWindow)3);
		}
		((CodeAccessPermission)uipermission_0).Demand();
	}

	[SecurityCritical]
	internal static void smethod_11()
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		if (uipermission_1 == null)
		{
			uipermission_1 = new UIPermission(PermissionState.Unrestricted);
		}
		((CodeAccessPermission)uipermission_1).Demand();
	}

	internal static bool smethod_12(string string_0, string string_1)
	{
		return string.Compare(string_0, string_1, StringComparison.OrdinalIgnoreCase) == 0;
	}

	[SecurityCritical]
	internal static object smethod_13(RegistryKey registryKey_0, string string_0, string string_1)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		object result = null;
		((CodeAccessPermission)new RegistryPermission((RegistryPermissionAccess)1, registryKey_0.Name + "\\" + string_0)).Assert();
		try
		{
			RegistryKey registryKey = registryKey_0.OpenSubKey(string_0);
			if (registryKey != null)
			{
				using (registryKey)
				{
					return registryKey.GetValue(string_1);
				}
			}
			return result;
		}
		finally
		{
			CodeAccessPermission.RevertAssert();
		}
	}
}
