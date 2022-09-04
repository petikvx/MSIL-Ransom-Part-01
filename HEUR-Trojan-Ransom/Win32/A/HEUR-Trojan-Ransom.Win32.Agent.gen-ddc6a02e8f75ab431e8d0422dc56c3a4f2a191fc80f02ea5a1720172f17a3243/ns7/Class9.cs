using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using ns2;
using ns3;
using ns4;
using ns5;

namespace ns7;

internal class Class9<T> : Class5 where T : Class7, new()
{
	private Class3.Struct1 struct1_0 = default(Class3.Struct1);

	private List<T> list_0 = new List<T>();

	internal Class9(IntPtr intptr_2, IntPtr intptr_3, Class4 class4_2, Class4 class4_3, ushort ushort_1, int int_1)
		: base(intptr_2, intptr_3, class4_2, class4_3, ushort_1, int_1)
	{
	}

	public Class9(Class3.Enum1 enum1_0)
		: base(IntPtr.Zero, IntPtr.Zero, new Class4(enum1_0), new Class4(1u), Class18.smethod_7(), Marshal.SizeOf(typeof(Class3.Struct1)))
	{
		switch (enum1_0)
		{
		case Class3.Enum1.const_11:
			struct1_0.ushort_1 = 2;
			break;
		default:
			throw new NotSupportedException();
		case Class3.Enum1.const_12:
			struct1_0.ushort_1 = 1;
			break;
		}
	}

	public override void vmethod_2(string string_0)
	{
		base.vmethod_2(string_0);
		foreach (T item in list_0)
		{
			T current = item;
			current.vmethod_5(string_0);
		}
	}

	internal override IntPtr vmethod_0(IntPtr intptr_2, IntPtr intptr_3)
	{
		list_0.Clear();
		struct1_0 = (Class3.Struct1)Marshal.PtrToStructure(intptr_3, typeof(Class3.Struct1));
		IntPtr intPtr = new IntPtr(intptr_3.ToInt32() + Marshal.SizeOf((object)struct1_0));
		for (ushort num = 0; num < struct1_0.ushort_2; num = (ushort)(num + 1))
		{
			T item = new T();
			intPtr = item.vmethod_0(intptr_2, intPtr);
			list_0.Add(item);
		}
		return intPtr;
	}

	internal override void vmethod_1(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(struct1_0.ushort_0);
		binaryWriter_0.Write(struct1_0.ushort_1);
		binaryWriter_0.Write((ushort)list_0.Count);
		Class18.smethod_1(binaryWriter_0);
		foreach (T item in list_0)
		{
			T current = item;
			current.vmethod_1(binaryWriter_0);
		}
	}
}
