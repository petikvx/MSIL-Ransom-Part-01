using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns2;
using ns3;
using ns4;

namespace ns6;

internal sealed class Class12 : Class5
{
	private Dictionary<ushort, string> dictionary_0 = new Dictionary<ushort, string>();

	public string this[ushort ushort_1]
	{
		get
		{
			return dictionary_0[ushort_1];
		}
		set
		{
			dictionary_0[ushort_1] = value;
		}
	}

	public Class12()
		: base(IntPtr.Zero, IntPtr.Zero, new Class4(Class3.Enum1.const_5), null, Class18.smethod_7(), 0)
	{
	}

	public Class12(IntPtr intptr_2, IntPtr intptr_3, Class4 class4_2, Class4 class4_3, ushort ushort_1, int int_1)
		: base(intptr_2, intptr_3, class4_2, class4_3, ushort_1, int_1)
	{
	}

	[SpecialName]
	public ushort method_4()
	{
		return (ushort)method_0().method_0().ToInt32();
	}

	internal override IntPtr vmethod_0(IntPtr intptr_2, IntPtr intptr_3)
	{
		for (int i = 0; i < 16; i++)
		{
			ushort num = (ushort)Marshal.ReadInt16(intptr_3);
			if (num != 0)
			{
				ushort key = (ushort)((method_4() - 1) * 16 + i);
				IntPtr ptr = new IntPtr(intptr_3.ToInt32() + 2);
				string value = Marshal.PtrToStringUni(ptr, num);
				dictionary_0.Add(key, value);
			}
			intptr_3 = new IntPtr(intptr_3.ToInt32() + 2 + num * Marshal.SystemDefaultCharSize);
		}
		return intptr_3;
	}

	internal override void vmethod_1(BinaryWriter binaryWriter_0)
	{
		for (int i = 0; i < 16; i++)
		{
			ushort key = (ushort)((method_4() - 1) * 16 + i);
			string value = null;
			if (dictionary_0.TryGetValue(key, out value))
			{
				binaryWriter_0.Write((ushort)value.Length);
				binaryWriter_0.Write(Encoding.Unicode.GetBytes(value));
			}
			else
			{
				binaryWriter_0.Write((ushort)0);
			}
		}
	}

	string object.ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("STRINGTABLE");
		stringBuilder.AppendLine("BEGIN");
		Dictionary<ushort, string>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			stringBuilder.AppendLine($" {enumerator.Current.Key} {enumerator.Current.Value}");
		}
		stringBuilder.AppendLine("END");
		return stringBuilder.ToString();
	}
}
