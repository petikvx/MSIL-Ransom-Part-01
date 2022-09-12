using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns0;
using ns1;

namespace ns5;

internal class Class20
{
	protected Class38.Struct2 struct2_0;

	protected string string_0;

	[SpecialName]
	public string method_0()
	{
		return string_0;
	}

	[SpecialName]
	public Class38.Struct2 method_1()
	{
		return struct2_0;
	}

	[SpecialName]
	public void method_2(Class38.Struct2 struct2_1)
	{
		struct2_0 = struct2_1;
	}

	public Class20()
	{
	}

	public Class20(string string_1)
	{
		string_0 = string_1;
	}

	internal Class20(IntPtr intptr_0)
	{
		vmethod_0(intptr_0);
	}

	internal virtual IntPtr vmethod_0(IntPtr intptr_0)
	{
		struct2_0 = (Class38.Struct2)Marshal.PtrToStructure(intptr_0, typeof(Class38.Struct2));
		IntPtr ptr = new IntPtr(intptr_0.ToInt32() + Marshal.SizeOf((object)struct2_0));
		string_0 = Marshal.PtrToStringUni(ptr);
		return Class15.smethod_0(ptr.ToInt32() + (string_0.Length + 1) * Marshal.SystemDefaultCharSize);
	}

	internal virtual void vmethod_1(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(struct2_0.ushort_0);
		binaryWriter_0.Write(struct2_0.ushort_1);
		binaryWriter_0.Write(struct2_0.ushort_2);
		binaryWriter_0.Write(Encoding.Unicode.GetBytes(string_0));
		binaryWriter_0.Write((ushort)0);
		Class15.smethod_2(binaryWriter_0);
	}

	public override string ToString()
	{
		return vmethod_2(0);
	}

	public virtual string vmethod_2(int int_0)
	{
		return base.ToString();
	}
}
