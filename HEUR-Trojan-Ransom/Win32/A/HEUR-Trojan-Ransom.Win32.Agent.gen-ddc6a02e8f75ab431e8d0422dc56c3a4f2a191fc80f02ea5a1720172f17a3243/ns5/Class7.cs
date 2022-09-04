using System;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns1;
using ns2;
using ns3;
using ns4;

namespace ns5;

internal class Class7 : Class5
{
	protected Class3.Struct0 struct0_0;

	protected Class22 class22_0 = new Class22();

	public Class7(Class4 class4_2)
		: base(IntPtr.Zero, IntPtr.Zero, class4_2, new Class4(IntPtr.Zero), Class18.smethod_7(), Marshal.SizeOf(typeof(Class3.Struct0)))
	{
	}

	[SpecialName]
	public byte method_4()
	{
		return struct0_0.byte_0;
	}

	[SpecialName]
	public byte method_5()
	{
		return struct0_0.byte_1;
	}

	internal override IntPtr vmethod_0(IntPtr intptr_2, IntPtr intptr_3)
	{
		struct0_0 = (Class3.Struct0)Marshal.PtrToStructure(intptr_3, typeof(Class3.Struct0));
		IntPtr intPtr = Class3.FindResourceExW(intptr_2, class4_0.method_0(), (IntPtr)struct0_0.ushort_2, ushort_0);
		if (intPtr == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		IntPtr intPtr2 = Class3.LoadResource(intptr_2, intPtr);
		if (intPtr2 == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		IntPtr intPtr3 = Class3.LockResource(intPtr2);
		if (intPtr3 == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		vmethod_4(intPtr3, (uint)Class3.SizeofResource(intptr_2, intPtr));
		return new IntPtr(intptr_3.ToInt32() + Marshal.SizeOf((object)struct0_0));
	}

	internal virtual void vmethod_4(IntPtr intptr_2, uint uint_0)
	{
		class22_0.method_1(intptr_2, uint_0);
	}

	[SpecialName]
	public PixelFormat method_6()
	{
		return (PixelFormat)(struct0_0.ushort_1 switch
		{
			8 => 198659, 
			4 => 197634, 
			1 => 196865, 
			32 => 2498570, 
			24 => 137224, 
			16 => 135174, 
			_ => 0, 
		});
	}

	[SpecialName]
	public string method_7()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Invalid comparison between Unknown and I4
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0015: Invalid comparison between Unknown and I4
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Invalid comparison between Unknown and I4
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Invalid comparison between Unknown and I4
		//IL_0035: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Invalid comparison between Unknown and I4
		PixelFormat val = method_6();
		if ((int)val <= 196865)
		{
			if ((int)val == 137224)
			{
				return "24-bit True Colors";
			}
			if ((int)val != 139273)
			{
				if ((int)val != 196865)
				{
					goto IL_004d;
				}
				return "1-bit B/W";
			}
		}
		else
		{
			if ((int)val == 197634)
			{
				return "4-bit 16 Colors";
			}
			if ((int)val == 198659)
			{
				return "8-bit 256 Colors";
			}
			if ((int)val != 2498570)
			{
				goto IL_004d;
			}
		}
		return "32-bit Alpha Channel";
		IL_004d:
		return "Unknown";
	}

	public override string ToString()
	{
		return $"{method_4()}x{method_5()} {method_7()}";
	}

	internal override void vmethod_1(BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(struct0_0.byte_0);
		binaryWriter_0.Write(struct0_0.byte_1);
		binaryWriter_0.Write(struct0_0.byte_2);
		binaryWriter_0.Write(struct0_0.byte_3);
		binaryWriter_0.Write(struct0_0.ushort_0);
		binaryWriter_0.Write(struct0_0.ushort_1);
		binaryWriter_0.Write(struct0_0.uint_0);
		binaryWriter_0.Write(struct0_0.ushort_2);
		Class18.smethod_1(binaryWriter_0);
	}

	public virtual void vmethod_5(string string_0)
	{
		Class5.smethod_1(string_0, class4_0, new Class4(struct0_0.ushort_2), ushort_0, class22_0.method_0());
	}
}
