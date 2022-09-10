using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ns2;
using ns3;

namespace ns4;

internal sealed class Class5 : Class2
{
	private Dictionary<string, Class11> dictionary_0 = new Dictionary<string, Class11>();

	public string this[string string_1]
	{
		get
		{
			return dictionary_0[string_1].string_1;
		}
		set
		{
			Class11 value2 = null;
			if (!dictionary_0.TryGetValue(string_1, out value2))
			{
				value2 = new Class11(string_1);
				dictionary_0.Add(string_1, value2);
			}
			Class23.smethod_9(value2, value);
		}
	}

	public Class5()
	{
	}

	internal Class5(IntPtr intptr_0)
	{
		vmethod_0(intptr_0);
	}

	internal override IntPtr vmethod_0(IntPtr intptr_0)
	{
		dictionary_0.Clear();
		IntPtr intptr_ = base.vmethod_0(intptr_0);
		while (intptr_.ToInt32() < intptr_0.ToInt32() + struct0_0.ushort_0)
		{
			Class11 @class = new Class11(intptr_);
			dictionary_0.Add(@class.string_0, @class);
			intptr_ = new IntPtr((intptr_.ToInt32() + @class.struct0_0.ushort_0 + 3) & -4);
		}
		return new IntPtr(intptr_0.ToInt32() + struct0_0.ushort_0);
	}

	internal override void vmethod_1(BinaryWriter binaryWriter_0)
	{
		long position = binaryWriter_0.BaseStream.Position;
		base.vmethod_1(binaryWriter_0);
		int num = dictionary_0.Count;
		Dictionary<string, Class11>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			Class23.smethod_47(enumerator.Current.Value, binaryWriter_0);
			Class23.smethod_98(binaryWriter_0, binaryWriter_0.BaseStream.Position - position, position);
			if (--num != 0)
			{
				Class23.smethod_87(binaryWriter_0);
			}
		}
	}

	public override string vmethod_2(int int_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"{new string(' ', int_0)}BEGIN");
		stringBuilder.AppendLine($"{new string(' ', int_0 + 1)}BLOCK \"{string_0}\"");
		stringBuilder.AppendLine($"{new string(' ', int_0 + 1)}BEGIN");
		foreach (Class11 value in dictionary_0.Values)
		{
			stringBuilder.AppendLine($"{new string(' ', int_0 + 2)}VALUE \"{value.string_0}\", \"{Class23.smethod_5(value)}\"");
		}
		stringBuilder.AppendLine($"{new string(' ', int_0 + 1)}END");
		stringBuilder.AppendLine($"{new string(' ', int_0)}END");
		return stringBuilder.ToString();
	}
}
