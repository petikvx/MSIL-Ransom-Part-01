using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using ns0;
using ns1;
using ns2;

namespace ns5;

internal sealed class Class17 : Class13
{
	private Dictionary<string, Class16> dictionary_0 = new Dictionary<string, Class16>();

	public string this[string string_1]
	{
		get
		{
			return method_4()[string_1];
		}
		set
		{
			method_4()[string_1] = value;
		}
	}

	[SpecialName]
	public Dictionary<string, Class16> method_3()
	{
		return dictionary_0;
	}

	public Class17()
		: base("StringFileInfo")
	{
		struct4_0.ushort_2 = 1;
	}

	internal Class17(IntPtr intptr_0)
	{
		vmethod_0(intptr_0);
	}

	internal override IntPtr vmethod_0(IntPtr intptr_0)
	{
		dictionary_0.Clear();
		IntPtr intptr_ = base.vmethod_0(intptr_0);
		while (intptr_.ToInt32() < intptr_0.ToInt32() + struct4_0.ushort_0)
		{
			Class16 @class = new Class16(intptr_);
			dictionary_0.Add(@class.method_0(), @class);
			intptr_ = Class18.smethod_0(intptr_.ToInt32() + @class.method_1().ushort_0);
		}
		return new IntPtr(intptr_0.ToInt32() + struct4_0.ushort_0);
	}

	internal override void vmethod_1(BinaryWriter binaryWriter_0)
	{
		long position = binaryWriter_0.BaseStream.Position;
		base.vmethod_1(binaryWriter_0);
		Dictionary<string, Class16>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.vmethod_1(binaryWriter_0);
		}
		Class18.smethod_5(binaryWriter_0, binaryWriter_0.BaseStream.Position - position, position);
		Class18.smethod_2(binaryWriter_0);
	}

	[SpecialName]
	public Class16 method_4()
	{
		Dictionary<string, Class16>.Enumerator enumerator = dictionary_0.GetEnumerator();
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
		foreach (Class16 value in dictionary_0.Values)
		{
			stringBuilder.Append(value.vmethod_2(int_0 + 1));
		}
		stringBuilder.AppendLine($"{new string(' ', int_0)}END");
		return stringBuilder.ToString();
	}
}
