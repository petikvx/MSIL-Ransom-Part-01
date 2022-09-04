using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using ns3;
using ns4;
using ns7;

namespace ns1;

internal sealed class Class6 : Class2
{
	private Dictionary<ushort, ushort> dictionary_0 = new Dictionary<ushort, ushort>();

	public ushort this[ushort ushort_0]
	{
		get
		{
			return dictionary_0[ushort_0];
		}
		set
		{
			dictionary_0[ushort_0] = value;
		}
	}

	public Class6()
	{
	}

	public Class6(string string_1)
		: base(string_1)
	{
	}

	internal Class6(IntPtr intptr_0)
	{
		vmethod_0(intptr_0);
	}

	internal override IntPtr vmethod_0(IntPtr intptr_0)
	{
		dictionary_0.Clear();
		IntPtr ptr = base.vmethod_0(intptr_0);
		while (ptr.ToInt32() < intptr_0.ToInt32() + struct0_0.ushort_0)
		{
			Class21.Struct1 @struct = (Class21.Struct1)Marshal.PtrToStructure(ptr, typeof(Class21.Struct1));
			dictionary_0.Add(@struct.ushort_0, @struct.ushort_1);
			ptr = new IntPtr(ptr.ToInt32() + Marshal.SizeOf((object)@struct));
		}
		return new IntPtr(intptr_0.ToInt32() + struct0_0.ushort_0);
	}

	internal override void vmethod_1(BinaryWriter binaryWriter_0)
	{
		long position = binaryWriter_0.BaseStream.Position;
		base.vmethod_1(binaryWriter_0);
		Dictionary<ushort, ushort>.Enumerator enumerator = dictionary_0.GetEnumerator();
		long position2 = binaryWriter_0.BaseStream.Position;
		while (enumerator.MoveNext())
		{
			binaryWriter_0.Write(enumerator.Current.Key);
			binaryWriter_0.Write(enumerator.Current.Value);
		}
		Class23.smethod_98(binaryWriter_0, binaryWriter_0.BaseStream.Position - position2, position + 2L);
		Class23.smethod_87(binaryWriter_0);
		Class23.smethod_98(binaryWriter_0, binaryWriter_0.BaseStream.Position - position, position);
	}

	public override string vmethod_2(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"{new string(' ', int_0)}BEGIN");
		Dictionary<ushort, ushort>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			stringBuilder.AppendLine($"{new string(' ', int_0 + 1)}VALUE \"Translation\", 0x{enumerator.Current.Key:x}, 0x{enumerator.Current.Value:x}");
		}
		stringBuilder.AppendLine($"{new string(' ', int_0)}END");
		return stringBuilder.ToString();
	}
}
