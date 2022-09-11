using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns13;
using ns14;
using ns21;
using ns5;

namespace ns26;

internal sealed class Class89 : Class87
{
	private Encoding encoding_0;

	private bool bool_0;

	[NonSerialized]
	internal static GetString getString_0;

	public Class89(bool bool_1)
	{
		bool_0 = bool_1;
	}

	public override void vmethod_0()
	{
		base.Column.Type = method_0();
		base.Column.ClrType = method_1(base.Column.Type);
		base.Column.IsPadded = (base.Flags & 1) != 0;
		delegate1_0 = method_2();
	}

	private Enum49 method_0()
	{
		if (bool_0)
		{
			return Enum49.const_17;
		}
		if (base.ContentType == 1)
		{
			return Enum49.const_18;
		}
		if (base.ContentType == 2)
		{
			return Enum49.const_9;
		}
		if ((base.Column.CollationName ?? getString_0(107397636)).Equals(getString_0(107406785), StringComparison.OrdinalIgnoreCase))
		{
			return Enum49.const_11;
		}
		return Enum49.const_10;
	}

	private Type method_1(Enum49 enum49_0)
	{
		if (enum49_0 != Enum49.const_10 && enum49_0 != Enum49.const_9 && enum49_0 != Enum49.const_17)
		{
			return typeof(byte[]);
		}
		return typeof(string);
	}

	private Delegate1 method_2()
	{
		if (base.Column.ClrType == typeof(string))
		{
			return method_3;
		}
		return method_4;
	}

	private object method_3(byte[] byte_0)
	{
		if (byte_0.Length == 0)
		{
			return null;
		}
		if (encoding_0 == null)
		{
			string string_ = base.Column.CharacterSetName ?? string.Empty;
			encoding_0 = Class137.smethod_1(default(Struct23), string_);
		}
		return encoding_0.GetString(byte_0, 0, byte_0.Length - 1);
	}

	private object method_4(byte[] byte_0)
	{
		byte[] array = new byte[byte_0.Length - 1];
		Array.Copy(byte_0, array, array.Length);
		return array;
	}

	static Class89()
	{
		Strings.CreateGetStringDelegate(typeof(Class89));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(getString_0(107397814), getString_0(107397809)).Replace(getString_0(107397772), getString_0(107397767)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, bool_1: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(getString_0(107397762)))
		{
			throw new SecurityException(getString_0(107397737));
		}
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_1, [MarshalAs(UnmanagedType.Bool)] out bool bool_2);
}
