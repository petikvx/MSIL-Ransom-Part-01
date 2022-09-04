using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns2;
using ns3;
using ns8;

namespace ns6;

internal sealed class Class19
{
	private Class3.Struct2 struct2_0 = Class3.Struct2.smethod_0();

	[SpecialName]
	public Class3.Struct2 method_0()
	{
		return struct2_0;
	}

	internal void method_1(IntPtr intptr_0)
	{
		struct2_0 = (Class3.Struct2)Marshal.PtrToStructure(intptr_0, typeof(Class3.Struct2));
	}

	[SpecialName]
	public void method_2(string string_0)
	{
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		string[] array = string_0.Split(".".ToCharArray(), 4);
		if (array.Length >= 1)
		{
			num = uint.Parse(array[0]);
		}
		if (array.Length >= 2)
		{
			num2 = uint.Parse(array[1]);
		}
		if (array.Length >= 3)
		{
			num3 = uint.Parse(array[2]);
		}
		if (array.Length >= 4)
		{
			num4 = uint.Parse(array[3]);
		}
		struct2_0.uint_2 = (num << 16) + num2;
		struct2_0.uint_3 = (num3 << 16) + num4;
	}

	[SpecialName]
	public string method_3()
	{
		return $"{Class18.smethod_3(struct2_0.uint_4)}.{Class18.smethod_4(struct2_0.uint_4)}.{Class18.smethod_3(struct2_0.uint_5)}.{Class18.smethod_4(struct2_0.uint_5)}";
	}

	[SpecialName]
	public void method_4(string string_0)
	{
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		string[] array = string_0.Split(".".ToCharArray(), 4);
		if (array.Length >= 1)
		{
			num = uint.Parse(array[0]);
		}
		if (array.Length >= 2)
		{
			num2 = uint.Parse(array[1]);
		}
		if (array.Length >= 3)
		{
			num3 = uint.Parse(array[2]);
		}
		if (array.Length >= 4)
		{
			num4 = uint.Parse(array[3]);
		}
		struct2_0.uint_4 = (num << 16) + num2;
		struct2_0.uint_5 = (num3 << 16) + num4;
	}

	public void method_5(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(Class18.smethod_10(struct2_0));
		Class18.smethod_2(binaryWriter_0);
	}

	[SpecialName]
	public ushort method_6()
	{
		return (ushort)Marshal.SizeOf((object)struct2_0);
	}

	string object.ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"FILEVERSION {Class18.smethod_3(struct2_0.uint_2)},{Class18.smethod_4(struct2_0.uint_2)},{Class18.smethod_3(struct2_0.uint_3)},{Class18.smethod_4(struct2_0.uint_3)}");
		stringBuilder.AppendLine($"PRODUCTVERSION {Class18.smethod_3(struct2_0.uint_4)},{Class18.smethod_4(struct2_0.uint_4)},{Class18.smethod_3(struct2_0.uint_5)},{Class18.smethod_4(struct2_0.uint_5)}");
		if (struct2_0.uint_6 == 63)
		{
			stringBuilder.AppendLine("FILEFLAGSMASK VS_FFI_FILEFLAGSMASK");
		}
		else
		{
			stringBuilder.AppendLine($"FILEFLAGSMASK 0x{struct2_0.uint_6.ToString():x}");
		}
		stringBuilder.AppendLine(string.Format("FILEFLAGS {0}", (struct2_0.uint_7 == 0) ? "0" : Class18.smethod_12<Class20.Enum5>(struct2_0.uint_7)));
		stringBuilder.AppendLine($"FILEOS {Class18.smethod_12<Class20.Enum4>(struct2_0.uint_7)}");
		stringBuilder.AppendLine($"FILETYPE {Class18.smethod_12<Class20.Enum3>(struct2_0.uint_9)}");
		stringBuilder.AppendLine($"FILESUBTYPE {Class18.smethod_12<Class20.Enum2>(struct2_0.uint_10)}");
		return stringBuilder.ToString();
	}
}
