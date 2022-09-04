using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using ns0;
using ns2;
using ns3;
using ns4;
using ns5;
using ns7;

namespace ns1;

internal sealed class Class16 : Class13
{
	private Class2 class2_0 = new Class2("VS_VERSION_INFO");

	internal Class22 class22_0 = new Class22();

	internal Dictionary<string, Class2> dictionary_0 = new Dictionary<string, Class2>();

	public Class2 this[string string_0]
	{
		get
		{
			return dictionary_0[string_0];
		}
		set
		{
			dictionary_0[string_0] = value;
		}
	}

	public Class16()
		: base(IntPtr.Zero, IntPtr.Zero, new Class10(Class21.Enum5.const_13), new Class10(1u), Class23.smethod_26(), 0)
	{
		class2_0.struct0_0 = new Class21.Struct0(Class23.smethod_27(class22_0));
	}

	internal override IntPtr vmethod_1(IntPtr intptr_2, IntPtr intptr_3)
	{
		dictionary_0.Clear();
		IntPtr intPtr = class2_0.vmethod_0(intptr_3);
		if (class2_0.struct0_0.ushort_1 != 0)
		{
			class22_0 = new Class22();
			Class23.smethod_97(class22_0, intPtr);
		}
		IntPtr intPtr2 = new IntPtr((intPtr.ToInt32() + class2_0.struct0_0.ushort_1 + 3) & -4);
		while (intPtr2.ToInt32() < intptr_3.ToInt32() + class2_0.struct0_0.ushort_0)
		{
			Class2 @class = new Class2(intPtr2);
			string string_;
			if ((string_ = @class.string_0) != null && string_ == "StringFileInfo")
			{
				Class3 class2 = new Class3(intPtr2);
				@class = class2;
			}
			else
			{
				@class = new Class4(intPtr2);
			}
			dictionary_0.Add(@class.string_0, @class);
			intPtr2 = new IntPtr((intPtr2.ToInt32() + @class.struct0_0.ushort_0 + 3) & -4);
		}
		return new IntPtr(intptr_3.ToInt32() + class2_0.struct0_0.ushort_0);
	}

	internal override void vmethod_2(BinaryWriter binaryWriter_0)
	{
		long position = binaryWriter_0.BaseStream.Position;
		class2_0.vmethod_1(binaryWriter_0);
		if (class22_0 != null)
		{
			Class23.smethod_35(class22_0, binaryWriter_0);
		}
		Dictionary<string, Class2>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			enumerator.Current.Value.vmethod_1(binaryWriter_0);
		}
		Class23.smethod_98(binaryWriter_0, binaryWriter_0.BaseStream.Position - position, position);
	}

	string object.ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (class22_0 != null)
		{
			stringBuilder.Append(class22_0.ToString());
		}
		stringBuilder.AppendLine("BEGIN");
		Dictionary<string, Class2>.Enumerator enumerator = dictionary_0.GetEnumerator();
		while (enumerator.MoveNext())
		{
			stringBuilder.Append(enumerator.Current.Value.vmethod_2(1));
		}
		stringBuilder.AppendLine("END");
		return stringBuilder.ToString();
	}
}
