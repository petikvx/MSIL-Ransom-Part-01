using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using ns0;
using ns2;
using ns3;
using ns5;
using ns7;

namespace ns1;

internal sealed class Class1 : Class0
{
	private Class20 class20_0 = new Class20("VS_VERSION_INFO");

	private Class41 class41_0 = new Class41();

	private Dictionary<string, Class20> dictionary_0 = new Dictionary<string, Class20>();

	public Class20 this[string string_0]
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
	public Dictionary<string, Class20> method_4()
	{
		return dictionary_0;
	}

	public Class1(IntPtr intptr_2, IntPtr intptr_3, Class40 class40_2, Class40 class40_3, ushort ushort_1, int int_1)
		: base(intptr_2, intptr_3, class40_2, class40_3, ushort_1, int_1)
	{
	}

	public Class1()
		: base(IntPtr.Zero, IntPtr.Zero, new Class40(Class38.Enum6.const_13), new Class40(1u), Class15.smethod_8(), 0)
	{
		class20_0.method_2(new Class38.Struct2(class41_0.method_6()));
	}

	internal override IntPtr vmethod_0(IntPtr intptr_2, IntPtr intptr_3)
	{
		dictionary_0.Clear();
		IntPtr intPtr = class20_0.vmethod_0(intptr_3);
		if (class20_0.method_1().ushort_1 != 0)
		{
			class41_0 = new Class41();
			class41_0.method_1(intPtr);
		}
		IntPtr intPtr2 = Class15.smethod_0(intPtr.ToInt32() + class20_0.method_1().ushort_1);
		while (intPtr2.ToInt32() < intptr_3.ToInt32() + class20_0.method_1().ushort_0)
		{
			Class20 @class = new Class20(intPtr2);
			string text;
			if ((text = @class.method_0()) != null && text == "StringFileInfo")
			{
				Class22 class2 = new Class22(intPtr2);
				@class = class2;
			}
			else
			{
				@class = new Class24(intPtr2);
			}
			dictionary_0.Add(@class.method_0(), @class);
			intPtr2 = Class15.smethod_0(intPtr2.ToInt32() + @class.method_1().ushort_0);
		}
		return new IntPtr(intptr_3.ToInt32() + class20_0.method_1().ushort_0);
	}

	[SpecialName]
	public void method_5(string string_0)
	{
		class41_0.method_2(string_0);
	}

	[SpecialName]
	public string method_6()
	{
		return class41_0.method_3();
	}

	[SpecialName]
	public void method_7(string string_0)
	{
		class41_0.method_4(string_0);
	}

	[SpecialName]
	public Class41 method_8()
	{
		return class41_0;
	}

	internal override void vmethod_1(BinaryWriter binaryWriter_0)
	{
		long position = binaryWriter_0.BaseStream.Position;
		class20_0.vmethod_1(binaryWriter_0);
		if (class41_0 != null)
		{
			class41_0.method_5(binaryWriter_0);
		}
		Dictionary<string, Class20>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.vmethod_1(binaryWriter_0);
		}
		Class15.smethod_5(binaryWriter_0, binaryWriter_0.BaseStream.Position - position, position);
	}

	string object.ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (class41_0 != null)
		{
			stringBuilder.Append(class41_0.ToString());
		}
		stringBuilder.AppendLine("BEGIN");
		Dictionary<string, Class20>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			stringBuilder.Append(enumerator.Current.Value.vmethod_2(1));
		}
		stringBuilder.AppendLine("END");
		return stringBuilder.ToString();
	}
}
