using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using ns1;

namespace ns0;

internal sealed class Class1
{
	private delegate void Delegate0();

	private delegate void Delegate1(object sender, EventArgs e);

	private readonly bool bool_0;

	public static object object_0 = new object();

	public static IntPtr intptr_0;

	private static IntPtr intptr_1;

	private string string_0;

	internal IntPtr intptr_2;

	internal object object_1;

	internal IntPtr intptr_3;

	internal string string_1;

	public string String_0 => string_0;

	public string String_1 => string_0;

	internal EventHandler EventHandler_0 => method_0;

	internal Class1(object object_2, IntPtr intptr_4, bool bool_1)
	{
		bool_0 = bool_1;
		object obj = (object_1 = object_2);
		IntPtr intPtr = (intptr_2 = intptr_4);
	}

	internal void method_0(object sender, EventArgs e)
	{
	}

	[DllImport(" ", CharSet = CharSet.Unicode)]
	internal static extern IntPtr CreateDesignerContext([MarshalAs(UnmanagedType.LPArray, ArraySubType = UnmanagedType.LPWStr, SizeParamIndex = 1)] string[] string_2, int int_0, bool bool_1);

	internal static IntPtr smethod_0(IEnumerable<string> ienumerable_0, [MarshalAs(UnmanagedType.Bool)] bool bool_1)
	{
		string[] array = new List<string>(ienumerable_0).ToArray();
		string[] array2 = array;
		for (int i = 0; i < array2.Length; i++)
		{
		}
		return CreateDesignerContext(array, array.Length, bool_1);
	}

	[DllImport(" ", CharSet = CharSet.Unicode)]
	internal static extern void SetCurrentContext([MarshalAs(UnmanagedType.Bool)] bool bool_1, IntPtr intptr_4);

	public static byte[] smethod_1(byte[] byte_0)
	{
		Class8.smethod_0(byte_0);
		return Class0.byte_0;
	}

	public static void smethod_2(IEnumerable<string> ienumerable_0)
	{
		if (!AppDomain.CurrentDomain.IsDefaultAppDomain())
		{
			throw new NotSupportedException();
		}
		if (ienumerable_0 == null)
		{
			throw new ArgumentNullException("paths");
		}
		lock (object_0)
		{
			if (intptr_0 != IntPtr.Zero)
			{
				throw new NotSupportedException();
			}
			IntPtr intptr_ = smethod_0(ienumerable_0, bool_1: true);
			SetCurrentContext(bool_1: false, intptr_);
			intptr_0 = intptr_;
		}
	}

	public static void smethod_3(GClass2 gclass2_0)
	{
		if (!AppDomain.CurrentDomain.IsDefaultAppDomain())
		{
			throw new NotSupportedException();
		}
		if (gclass2_0 == null)
		{
			throw new ArgumentNullException("context");
		}
		lock (object_0)
		{
			SetCurrentContext(bool_1: true, intptr_1);
		}
	}
}
