using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns0;
using ns1;

namespace ns2;

internal sealed class Class19
{
	private Class38.Struct2 struct2_0;

	private string string_0;

	private string string_1;

	[SpecialName]
	public Class38.Struct2 method_0()
	{
		return struct2_0;
	}

	[SpecialName]
	public string method_1()
	{
		return string_0;
	}

	[SpecialName]
	public string method_2()
	{
		if (string_1 == null)
		{
			return string_1;
		}
		return string_1.Substring(0, string_1.Length - 1);
	}

	[SpecialName]
	public string method_3()
	{
		return string_1;
	}

	[SpecialName]
	public void method_4(string string_2)
	{
		if (string_2 == null)
		{
			string_1 = null;
			struct2_0.ushort_1 = 0;
			return;
		}
		if (string_2.Length != 0 && string_2[string_2.Length - 1] == '\0')
		{
			string_1 = string_2;
		}
		else
		{
			string_1 = string_2 + '\0';
		}
		struct2_0.ushort_1 = (ushort)string_1.Length;
	}

	public Class19(string string_2)
	{
		string_0 = string_2;
		struct2_0.ushort_2 = 1;
		struct2_0.ushort_0 = 0;
		struct2_0.ushort_1 = 0;
	}

	internal Class19(IntPtr intptr_0)
	{
		method_5(intptr_0);
	}

	internal void method_5(IntPtr intptr_0)
	{
		struct2_0 = (Class38.Struct2)Marshal.PtrToStructure(intptr_0, typeof(Class38.Struct2));
		IntPtr ptr = new IntPtr(intptr_0.ToInt32() + Marshal.SizeOf((object)struct2_0));
		string_0 = Marshal.PtrToStringUni(ptr);
		IntPtr ptr2 = Class15.smethod_0(ptr.ToInt32() + (string_0.Length + 1) * Marshal.SystemDefaultCharSize);
		string_1 = ((struct2_0.ushort_1 > 0) ? Marshal.PtrToStringUni(ptr2, struct2_0.ushort_1) : null);
	}

	internal void method_6(BinaryWriter binaryWriter_0)
	{
		long position = binaryWriter_0.BaseStream.Position;
		binaryWriter_0.Write(struct2_0.ushort_0);
		binaryWriter_0.Write(struct2_0.ushort_1);
		binaryWriter_0.Write(struct2_0.ushort_2);
		binaryWriter_0.Write(Encoding.Unicode.GetBytes(string_0));
		binaryWriter_0.Write((ushort)0);
		Class15.smethod_2(binaryWriter_0);
		long position2 = binaryWriter_0.BaseStream.Position;
		if (string_1 != null)
		{
			binaryWriter_0.Write(Encoding.Unicode.GetBytes(string_1));
		}
		Class15.smethod_5(binaryWriter_0, (binaryWriter_0.BaseStream.Position - position2) / Marshal.SystemDefaultCharSize, position + 2L);
		Class15.smethod_5(binaryWriter_0, binaryWriter_0.BaseStream.Position - position, position);
	}
}
