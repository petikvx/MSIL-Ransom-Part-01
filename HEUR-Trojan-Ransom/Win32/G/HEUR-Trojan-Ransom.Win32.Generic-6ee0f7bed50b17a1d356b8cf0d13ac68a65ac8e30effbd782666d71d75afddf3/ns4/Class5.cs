using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using ns0;
using ns1;
using ns3;
using ns7;

namespace ns4;

internal class Class5<T> : Class0 where T : Class3, new()
{
	private Class38.Struct5 struct5_0 = default(Class38.Struct5);

	private List<T> list_0 = new List<T>();

	internal Class5(IntPtr intptr_2, IntPtr intptr_3, Class40 class40_2, Class40 class40_3, ushort ushort_1, int int_1)
		: base(intptr_2, intptr_3, class40_2, class40_3, ushort_1, int_1)
	{
	}

	public Class5(Class38.Enum6 enum6_0)
		: base(IntPtr.Zero, IntPtr.Zero, new Class40(enum6_0), new Class40(1u), Class15.smethod_7(), Marshal.SizeOf(typeof(Class38.Struct5)))
	{
		switch (enum6_0)
		{
		case Class38.Enum6.const_11:
			struct5_0.ushort_1 = 2;
			break;
		default:
			throw new NotSupportedException();
		case Class38.Enum6.const_12:
			struct5_0.ushort_1 = 1;
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
		struct5_0 = (Class38.Struct5)Marshal.PtrToStructure(intptr_3, typeof(Class38.Struct5));
		IntPtr intPtr = new IntPtr(intptr_3.ToInt32() + Marshal.SizeOf((object)struct5_0));
		for (ushort num = 0; num < struct5_0.ushort_2; num = (ushort)(num + 1))
		{
			T item = new T();
			intPtr = item.vmethod_0(intptr_2, intPtr);
			list_0.Add(item);
		}
		return intPtr;
	}

	internal override void vmethod_1(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(struct5_0.ushort_0);
		binaryWriter_0.Write(struct5_0.ushort_1);
		binaryWriter_0.Write((ushort)list_0.Count);
		Class15.smethod_1(binaryWriter_0);
		foreach (T item in list_0)
		{
			T current = item;
			current.vmethod_1(binaryWriter_0);
		}
	}
}
