using System;
using System.ComponentModel;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns0;
using ns1;
using ns5;
using ns7;

namespace ns3;

internal class Class3 : Class0
{
	protected Class38.Struct6 struct6_0;

	protected Class10 class10_0 = new Class10();

	public Class3(Class40 class40_2)
		: base(IntPtr.Zero, IntPtr.Zero, class40_2, new Class40(IntPtr.Zero), Class15.smethod_7(), Marshal.SizeOf(typeof(Class38.Struct6)))
	{
	}

	[SpecialName]
	public byte method_4()
	{
		return struct6_0.byte_0;
	}

	[SpecialName]
	public byte method_5()
	{
		return struct6_0.byte_1;
	}

	internal override IntPtr vmethod_0(IntPtr intptr_2, IntPtr intptr_3)
	{
		struct6_0 = (Class38.Struct6)Marshal.PtrToStructure(intptr_3, typeof(Class38.Struct6));
		IntPtr intPtr = Class38.FindResourceExW(intptr_2, class40_0.method_0(), (IntPtr)struct6_0.ushort_2, ushort_0);
		if (intPtr == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		IntPtr intPtr2 = Class38.LoadResource(intptr_2, intPtr);
		if (intPtr2 == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		IntPtr intPtr3 = Class38.LockResource(intPtr2);
		if (intPtr3 == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		vmethod_4(intPtr3, (uint)Class38.SizeofResource(intptr_2, intPtr));
		return new IntPtr(intptr_3.ToInt32() + Marshal.SizeOf((object)struct6_0));
	}

	internal virtual void vmethod_4(IntPtr intptr_2, uint uint_0)
	{
		class10_0.method_1(intptr_2, uint_0);
	}

	[SpecialName]
	public PixelFormat method_6()
	{
		return (PixelFormat)(struct6_0.ushort_1 switch
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
		binaryWriter_0.Write(struct6_0.byte_0);
		binaryWriter_0.Write(struct6_0.byte_1);
		binaryWriter_0.Write(struct6_0.byte_2);
		binaryWriter_0.Write(struct6_0.byte_3);
		binaryWriter_0.Write(struct6_0.ushort_0);
		binaryWriter_0.Write(struct6_0.ushort_1);
		binaryWriter_0.Write(struct6_0.uint_0);
		binaryWriter_0.Write(struct6_0.ushort_2);
		Class15.smethod_1(binaryWriter_0);
	}

	public virtual void vmethod_5(string string_0)
	{
		Class0.smethod_1(string_0, class40_0, new Class40(struct6_0.ushort_2), ushort_0, class10_0.method_0());
	}
}
