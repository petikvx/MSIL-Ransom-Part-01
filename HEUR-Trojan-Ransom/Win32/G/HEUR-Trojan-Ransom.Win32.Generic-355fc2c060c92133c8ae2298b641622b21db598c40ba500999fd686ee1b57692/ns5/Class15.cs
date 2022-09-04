using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using ns0;
using ns4;
using ns7;

namespace ns5;

internal sealed class Class15 : Class13
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

	public Class15()
		: base(IntPtr.Zero, IntPtr.Zero, new Class10(Class21.Enum5.const_5), null, Class23.smethod_4(), 0)
	{
	}

	public Class15(Class10 class10_2)
		: base(IntPtr.Zero, IntPtr.Zero, new Class10(Class21.Enum5.const_5), class10_2, Class23.smethod_4(), 0)
	{
	}

	internal override IntPtr vmethod_1(IntPtr intptr_2, IntPtr intptr_3)
	{
		for (int i = 0; i < 16; i++)
		{
			ushort num = (ushort)Marshal.ReadInt16(intptr_3);
			if (num != 0)
			{
				ushort key = (ushort)((Class23.smethod_94(this) - 1) * 16 + i);
				IntPtr ptr = new IntPtr(intptr_3.ToInt32() + 2);
				string value = Marshal.PtrToStringUni(ptr, num);
				dictionary_0.Add(key, value);
			}
			intptr_3 = new IntPtr(intptr_3.ToInt32() + 2 + num * Marshal.SystemDefaultCharSize);
		}
		return intptr_3;
	}

	internal override void vmethod_2(BinaryWriter binaryWriter_0)
	{
		for (int i = 0; i < 16; i++)
		{
			ushort key = (ushort)((Class23.smethod_94(this) - 1) * 16 + i);
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
