using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using ns4;
using ns7;

namespace ns3;

internal class Class2
{
	protected internal Class21.Struct0 struct0_0;

	protected internal string string_0;

	public Class2()
	{
	}

	public Class2(string string_1)
	{
		string_0 = string_1;
	}

	internal Class2(IntPtr intptr_0)
	{
		vmethod_0(intptr_0);
	}

	internal virtual IntPtr vmethod_0(IntPtr intptr_0)
	{
		struct0_0 = (Class21.Struct0)Marshal.PtrToStructure(intptr_0, typeof(Class21.Struct0));
		IntPtr ptr = new IntPtr(intptr_0.ToInt32() + Marshal.SizeOf((object)struct0_0));
		string_0 = Marshal.PtrToStringUni(ptr);
		return new IntPtr((ptr.ToInt32() + (string_0.Length + 1) * Marshal.SystemDefaultCharSize + 3) & -4);
	}

	internal virtual void vmethod_1(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(struct0_0.ushort_0);
		binaryWriter_0.Write(struct0_0.ushort_1);
		binaryWriter_0.Write(struct0_0.ushort_2);
		binaryWriter_0.Write(Encoding.Unicode.GetBytes(string_0));
		binaryWriter_0.Write((ushort)0);
		Class23.smethod_87(binaryWriter_0);
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
