using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns0;
using ns1;
using ns6;

namespace ns2;

internal sealed class Class41
{
	private Class38.Struct4 struct4_0 = Class38.Struct4.smethod_0();

	[SpecialName]
	public Class38.Struct4 method_0()
	{
		return struct4_0;
	}

	internal void method_1(IntPtr intptr_0)
	{
		struct4_0 = (Class38.Struct4)Marshal.PtrToStructure(intptr_0, typeof(Class38.Struct4));
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
		struct4_0.uint_2 = (num << 16) + num2;
		struct4_0.uint_3 = (num3 << 16) + num4;
	}

	[SpecialName]
	public string method_3()
	{
		return $"{Class15.smethod_3(struct4_0.uint_4)}.{Class15.smethod_4(struct4_0.uint_4)}.{Class15.smethod_3(struct4_0.uint_5)}.{Class15.smethod_4(struct4_0.uint_5)}";
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
		struct4_0.uint_4 = (num << 16) + num2;
		struct4_0.uint_5 = (num3 << 16) + num4;
	}

	public void method_5(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(Class15.smethod_10(struct4_0));
		Class15.smethod_2(binaryWriter_0);
	}

	[SpecialName]
	public ushort method_6()
	{
		return (ushort)Marshal.SizeOf((object)struct4_0);
	}

	string object.ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine($"FILEVERSION {Class15.smethod_3(struct4_0.uint_2)},{Class15.smethod_4(struct4_0.uint_2)},{Class15.smethod_3(struct4_0.uint_3)},{Class15.smethod_4(struct4_0.uint_3)}");
		stringBuilder.AppendLine($"PRODUCTVERSION {Class15.smethod_3(struct4_0.uint_4)},{Class15.smethod_4(struct4_0.uint_4)},{Class15.smethod_3(struct4_0.uint_5)},{Class15.smethod_4(struct4_0.uint_5)}");
		if (struct4_0.uint_6 == 63)
		{
			stringBuilder.AppendLine("FILEFLAGSMASK VS_FFI_FILEFLAGSMASK");
		}
		else
		{
			stringBuilder.AppendLine($"FILEFLAGSMASK 0x{struct4_0.uint_6.ToString():x}");
		}
		stringBuilder.AppendLine(string.Format("FILEFLAGS {0}", (struct4_0.uint_7 == 0) ? "0" : Class15.smethod_12<Class31.Enum2>(struct4_0.uint_7)));
		stringBuilder.AppendLine($"FILEOS {Class15.smethod_12<Class31.Enum3>(struct4_0.uint_7)}");
		stringBuilder.AppendLine($"FILETYPE {Class15.smethod_12<Class31.Enum4>(struct4_0.uint_9)}");
		stringBuilder.AppendLine($"FILESUBTYPE {Class15.smethod_12<Class31.Enum5>(struct4_0.uint_10)}");
		return stringBuilder.ToString();
	}
}
