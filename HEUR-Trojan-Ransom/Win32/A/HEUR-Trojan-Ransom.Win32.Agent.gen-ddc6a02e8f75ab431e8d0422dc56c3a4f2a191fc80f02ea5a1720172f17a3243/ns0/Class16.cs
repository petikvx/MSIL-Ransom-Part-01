using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using ns1;
using ns2;
using ns6;

namespace ns0;

internal sealed class Class16 : Class13
{
	private Dictionary<string, Class21> dictionary_0 = new Dictionary<string, Class21>();

	public string this[string string_1]
	{
		get
		{
			return dictionary_0[string_1].method_3();
		}
		set
		{
			Class21 value2 = null;
			if (!dictionary_0.TryGetValue(string_1, out value2))
			{
				value2 = new Class21(string_1);
				dictionary_0.Add(string_1, value2);
			}
			value2.method_4(value);
		}
	}

	public Class16()
	{
	}

	internal Class16(IntPtr intptr_0)
	{
		vmethod_0(intptr_0);
	}

	internal override IntPtr vmethod_0(IntPtr intptr_0)
	{
		dictionary_0.Clear();
		IntPtr intptr_ = base.vmethod_0(intptr_0);
		while (intptr_.ToInt32() < intptr_0.ToInt32() + struct4_0.ushort_0)
		{
			Class21 @class = new Class21(intptr_);
			dictionary_0.Add(@class.method_1(), @class);
			intptr_ = Class18.smethod_0(intptr_.ToInt32() + @class.method_0().ushort_0);
		}
		return new IntPtr(intptr_0.ToInt32() + struct4_0.ushort_0);
	}

	internal override void vmethod_1(BinaryWriter binaryWriter_0)
	{
		long position = binaryWriter_0.BaseStream.Position;
		base.vmethod_1(binaryWriter_0);
		int num = dictionary_0.Count;
		Dictionary<string, Class21>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.method_6(binaryWriter_0);
			Class18.smethod_5(binaryWriter_0, binaryWriter_0.BaseStream.Position - position, position);
			if (--num != 0)
			{
				Class18.smethod_2(binaryWriter_0);
			}
		}
	}

	[SpecialName]
	public ushort method_3()
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return 0;
		}
		return Convert.ToUInt16(string_0.Substring(0, 4), 16);
	}

	[SpecialName]
	public void method_4(ushort ushort_0)
	{
		string_0 = $"{ushort_0:x4}{method_5():x4}";
	}

	[SpecialName]
	public ushort method_5()
	{
		if (string.IsNullOrEmpty(string_0))
		{
			return 0;
		}
		return Convert.ToUInt16(string_0.Substring(4, 4), 16);
	}

	[SpecialName]
	public void method_6(ushort ushort_0)
	{
		string_0 = $"{method_3():x4}{ushort_0:x4}";
	}

	public override string vmethod_2(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"{new string(' ', int_0)}BEGIN");
		stringBuilder.AppendLine($"{new string(' ', int_0 + 1)}BLOCK \"{string_0}\"");
		stringBuilder.AppendLine($"{new string(' ', int_0 + 1)}BEGIN");
		foreach (Class21 value in dictionary_0.Values)
		{
			stringBuilder.AppendLine($"{new string(' ', int_0 + 2)}VALUE \"{value.method_1()}\", \"{value.method_2()}\"");
		}
		stringBuilder.AppendLine($"{new string(' ', int_0 + 1)}END");
		stringBuilder.AppendLine($"{new string(' ', int_0)}END");
		return stringBuilder.ToString();
	}
}
