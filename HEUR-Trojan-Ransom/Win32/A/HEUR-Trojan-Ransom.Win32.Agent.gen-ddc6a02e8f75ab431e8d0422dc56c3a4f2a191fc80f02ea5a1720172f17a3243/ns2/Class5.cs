using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns3;
using ns4;

namespace ns2;

internal abstract class Class5
{
	protected Class4 class4_0;

	protected Class4 class4_1;

	protected ushort ushort_0;

	protected IntPtr intptr_0 = IntPtr.Zero;

	protected IntPtr intptr_1 = IntPtr.Zero;

	protected int int_0;

	[SpecialName]
	public Class4 method_0()
	{
		return class4_1;
	}

	internal Class5()
	{
	}

	internal Class5(IntPtr intptr_2, IntPtr intptr_3, Class4 class4_2, Class4 class4_3, ushort ushort_1, int int_1)
	{
		intptr_0 = intptr_2;
		class4_0 = class4_2;
		class4_1 = class4_3;
		ushort_0 = ushort_1;
		intptr_1 = intptr_3;
		int_0 = int_1;
		method_1(intptr_2, intptr_3);
	}

	internal void method_1(IntPtr intptr_2, IntPtr intptr_3)
	{
		if (!(intptr_3 == IntPtr.Zero))
		{
			IntPtr intPtr = Class3.LockResource(intptr_3);
			if (intPtr == IntPtr.Zero)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			vmethod_0(intptr_2, intPtr);
		}
	}

	internal abstract IntPtr vmethod_0(IntPtr intptr_2, IntPtr intptr_3);

	internal abstract void vmethod_1(BinaryWriter binaryWriter_0);

	public byte[] method_2()
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream, Encoding.Default);
		vmethod_1(binaryWriter);
		binaryWriter.Close();
		return memoryStream.ToArray();
	}

	public virtual void vmethod_2(string string_0)
	{
		method_3(string_0, class4_0, class4_1, ushort_0);
	}

	internal void method_3(string string_0, Class4 class4_2, Class4 class4_3, ushort ushort_1)
	{
		byte[] byte_ = method_2();
		smethod_1(string_0, class4_2, class4_3, ushort_1, byte_);
	}

	public virtual void vmethod_3(string string_0)
	{
		smethod_0(string_0, class4_0, class4_1, ushort_0);
	}

	internal static void smethod_0(string string_0, Class4 class4_2, Class4 class4_3, ushort ushort_1)
	{
		smethod_1(string_0, class4_2, class4_3, ushort_1, null);
	}

	internal static void smethod_1(string string_0, Class4 class4_2, Class4 class4_3, ushort ushort_1, byte[] byte_0)
	{
		IntPtr intPtr = Class3.BeginUpdateResourceW(string_0, bool_0: false);
		if (intPtr == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		if (!Class3.UpdateResourceW(intPtr, class4_2.method_0(), class4_3.method_0(), ushort_1, byte_0, (byte_0 != null) ? ((uint)byte_0.Length) : 0u))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		if (!Class3.EndUpdateResourceW(intPtr, bool_0: false))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}
}
