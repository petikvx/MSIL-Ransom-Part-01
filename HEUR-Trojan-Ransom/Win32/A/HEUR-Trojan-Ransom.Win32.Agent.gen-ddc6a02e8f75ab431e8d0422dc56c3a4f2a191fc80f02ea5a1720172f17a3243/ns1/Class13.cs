using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using ns2;
using ns3;

namespace ns1;

internal class Class13
{
	protected Class3.Struct4 struct4_0;

	protected string string_0;

	[SpecialName]
	public string method_0()
	{
		return string_0;
	}

	[SpecialName]
	public Class3.Struct4 method_1()
	{
		return struct4_0;
	}

	[SpecialName]
	public void method_2(Class3.Struct4 struct4_1)
	{
		struct4_0 = struct4_1;
	}

	public Class13()
	{
	}

	public Class13(string string_1)
	{
		string_0 = string_1;
	}

	internal Class13(IntPtr intptr_0)
	{
		vmethod_0(intptr_0);
	}

	internal virtual IntPtr vmethod_0(IntPtr intptr_0)
	{
		struct4_0 = (Class3.Struct4)Marshal.PtrToStructure(intptr_0, typeof(Class3.Struct4));
		IntPtr ptr = new IntPtr(intptr_0.ToInt32() + Marshal.SizeOf((object)struct4_0));
		string_0 = Marshal.PtrToStringUni(ptr);
		return Class18.smethod_0(ptr.ToInt32() + (string_0.Length + 1) * Marshal.SystemDefaultCharSize);
	}

	internal virtual void vmethod_1(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(struct4_0.ushort_0);
		binaryWriter_0.Write(struct4_0.ushort_1);
		binaryWriter_0.Write(struct4_0.ushort_2);
		binaryWriter_0.Write(Encoding.Unicode.GetBytes(string_0));
		binaryWriter_0.Write((ushort)0);
		Class18.smethod_2(binaryWriter_0);
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
