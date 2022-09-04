using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using ns4;

namespace ns3;

internal sealed class Class3 : Class2
{
	internal Dictionary<string, Class5> dictionary_0 = new Dictionary<string, Class5>();

	public string this[string string_1]
	{
		get
		{
			return method_0()[string_1];
		}
		set
		{
			method_0()[string_1] = value;
		}
	}

	public Class3()
		: base("StringFileInfo")
	{
		struct0_0.ushort_2 = 1;
	}

	internal Class3(IntPtr intptr_0)
	{
		vmethod_0(intptr_0);
	}

	internal override IntPtr vmethod_0(IntPtr intptr_0)
	{
		dictionary_0.Clear();
		IntPtr intptr_ = base.vmethod_0(intptr_0);
		while (intptr_.ToInt32() < intptr_0.ToInt32() + struct0_0.ushort_0)
		{
			Class5 @class = new Class5(intptr_);
			dictionary_0.Add(@class.string_0, @class);
			intptr_ = new IntPtr((intptr_.ToInt32() + @class.struct0_0.ushort_0 + 3) & -4);
		}
		return new IntPtr(intptr_0.ToInt32() + struct0_0.ushort_0);
	}

	internal override void vmethod_1(BinaryWriter binaryWriter_0)
	{
		long position = binaryWriter_0.BaseStream.Position;
		base.vmethod_1(binaryWriter_0);
		Dictionary<string, Class5>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.vmethod_1(binaryWriter_0);
		}
		Class23.smethod_98(binaryWriter_0, binaryWriter_0.BaseStream.Position - position, position);
		Class23.smethod_87(binaryWriter_0);
	}

	[SpecialName]
	public Class5 method_0()
	{
		Dictionary<string, Class5>.Enumerator enumerator = dictionary_0.GetEnumerator();
		if (enumerator.MoveNext())
		{
			return enumerator.Current.Value;
		}
		return null;
	}

	public override string vmethod_2(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"{new string(' ', int_0)}BEGIN");
		stringBuilder.AppendLine($"{new string(' ', int_0 + 1)}BLOCK \"{string_0}\"");
		foreach (Class5 value in dictionary_0.Values)
		{
			stringBuilder.Append(value.vmethod_2(int_0 + 1));
		}
		stringBuilder.AppendLine($"{new string(' ', int_0)}END");
		return stringBuilder.ToString();
	}
}
