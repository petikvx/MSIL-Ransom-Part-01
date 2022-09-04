using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using ns1;
using ns2;
using ns4;
using ns5;
using ns6;

namespace ns3;

internal sealed class Class6 : Class5
{
	private Class13 class13_0 = new Class13("VS_VERSION_INFO");

	private Class19 class19_0 = new Class19();

	private Dictionary<string, Class13> dictionary_0 = new Dictionary<string, Class13>();

	public Class13 this[string string_0]
	{
		get
		{
			return method_4()[string_0];
		}
		set
		{
			method_4()[string_0] = value;
		}
	}

	[SpecialName]
	public Dictionary<string, Class13> method_4()
	{
		return dictionary_0;
	}

	public Class6(IntPtr intptr_2, IntPtr intptr_3, Class4 class4_2, Class4 class4_3, ushort ushort_1, int int_1)
		: base(intptr_2, intptr_3, class4_2, class4_3, ushort_1, int_1)
	{
	}

	public Class6()
		: base(IntPtr.Zero, IntPtr.Zero, new Class4(Class3.Enum1.const_13), new Class4(1u), Class18.smethod_8(), 0)
	{
		class13_0.method_2(new Class3.Struct4(class19_0.method_6()));
	}

	internal override IntPtr vmethod_0(IntPtr intptr_2, IntPtr intptr_3)
	{
		dictionary_0.Clear();
		IntPtr intPtr = class13_0.vmethod_0(intptr_3);
		if (class13_0.method_1().ushort_1 != 0)
		{
			class19_0 = new Class19();
			class19_0.method_1(intPtr);
		}
		IntPtr intPtr2 = Class18.smethod_0(intPtr.ToInt32() + class13_0.method_1().ushort_1);
		while (intPtr2.ToInt32() < intptr_3.ToInt32() + class13_0.method_1().ushort_0)
		{
			Class13 @class = new Class13(intPtr2);
			string text;
			if ((text = @class.method_0()) != null && text == "StringFileInfo")
			{
				Class17 class2 = new Class17(intPtr2);
				@class = class2;
			}
			else
			{
				@class = new Class15(intPtr2);
			}
			dictionary_0.Add(@class.method_0(), @class);
			intPtr2 = Class18.smethod_0(intPtr2.ToInt32() + @class.method_1().ushort_0);
		}
		return new IntPtr(intptr_3.ToInt32() + class13_0.method_1().ushort_0);
	}

	[SpecialName]
	public void method_5(string string_0)
	{
		class19_0.method_2(string_0);
	}

	[SpecialName]
	public string method_6()
	{
		return class19_0.method_3();
	}

	[SpecialName]
	public void method_7(string string_0)
	{
		class19_0.method_4(string_0);
	}

	[SpecialName]
	public Class19 method_8()
	{
		return class19_0;
	}

	internal override void vmethod_1(BinaryWriter binaryWriter_0)
	{
		long position = binaryWriter_0.BaseStream.Position;
		class13_0.vmethod_1(binaryWriter_0);
		if (class19_0 != null)
		{
			class19_0.method_5(binaryWriter_0);
		}
		Dictionary<string, Class13>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.vmethod_1(binaryWriter_0);
		}
		Class18.smethod_5(binaryWriter_0, binaryWriter_0.BaseStream.Position - position, position);
	}

	string object.ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (class19_0 != null)
		{
			stringBuilder.Append(class19_0.ToString());
		}
		stringBuilder.AppendLine("BEGIN");
		Dictionary<string, Class13>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			stringBuilder.Append(enumerator.Current.Value.vmethod_2(1));
		}
		stringBuilder.AppendLine("END");
		return stringBuilder.ToString();
	}
}
