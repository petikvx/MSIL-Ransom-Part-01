using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns20;
using ns21;
using ns8;

namespace ns23;

internal sealed class Class53 : Class49<Class43>
{
	private Encoding encoding_0 = Encoding.UTF8;

	[NonSerialized]
	internal static GetString getString_1;

	internal Class53(Class79 class79_1)
		: base(class79_1)
	{
	}

	protected override Class43 vmethod_1(bool bool_3)
	{
		List<byte[]> list = base.Protocol.vmethod_0(this);
		if (list == null)
		{
			return null;
		}
		return new Class43(encoding_0.GetString(list[0]).TrimEnd(new char[1]));
	}

	static Class53()
	{
		Strings.CreateGetStringDelegate(typeof(Class53));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_1(107397739), getString_1(107397734)).Replace(getString_1(107397697), getString_1(107397692)));
		if (!StrongNameSignatureVerificationEx_1(uri.LocalPath, bool_3: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_1(107397687)))
		{
			throw new SecurityException(getString_1(107397662));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode, EntryPoint = "StrongNameSignatureVerificationEx")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx_1([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_3, [MarshalAs(UnmanagedType.Bool)] out bool bool_4);
}
