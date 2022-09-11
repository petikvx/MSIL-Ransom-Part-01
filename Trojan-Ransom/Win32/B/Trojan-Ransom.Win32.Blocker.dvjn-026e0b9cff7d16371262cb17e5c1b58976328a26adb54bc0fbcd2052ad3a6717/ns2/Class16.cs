using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Microsoft.VisualBasic.CompilerServices;

namespace ns2;

[StandardModule]
internal sealed class Class16
{
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct0
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public uint uint_0;

		private uint uint_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct Struct1
	{
		public uint uint_0;

		private string string_0;

		private string string_1;

		private string string_2;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
		private byte[] byte_0;

		private IntPtr intptr_0;

		private IntPtr intptr_1;

		private IntPtr intptr_2;

		private IntPtr intptr_3;
	}

	public struct Struct2
	{
		public Enum0 enum0_0;

		public int int_0;

		public int int_1;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 86, ArraySubType = UnmanagedType.U1)]
		public byte[] byte_0;

		[SpecialName]
		public Struct3 method_0()
		{
			return method_1<Struct3>();
		}

		private T method_1<T>() where T : struct
		{
			int num = Marshal.SizeOf(typeof(T));
			IntPtr intPtr = Marshal.AllocHGlobal(num);
			Marshal.Copy(byte_0, 0, intPtr, num);
			object objectValue = RuntimeHelpers.GetObjectValue(Marshal.PtrToStructure(intPtr, typeof(T)));
			Marshal.FreeHGlobal(intPtr);
			return (T)objectValue;
		}

		internal static bool Q1OME0VaaP1iRguBow()
		{
			return true;
		}

		internal static bool y0ss7f4Q4Qm62adRZx()
		{
			return false;
		}
	}

	public enum Enum0
	{
		const_0 = 3,
		const_1 = 2,
		const_2 = 1,
		const_3 = 5,
		const_4 = 4,
		const_5 = 6,
		const_6 = 8,
		const_7 = 9,
		const_8 = 7
	}

	public struct Struct3
	{
		public Struct4 struct4_0;

		public uint uint_0;
	}

	public struct Struct4
	{
		public uint uint_0;

		public uint uint_1;

		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public uint uint_2;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 15, ArraySubType = UnmanagedType.U4)]
		public uint[] uint_3;
	}

	public delegate bool Delegate0(IntPtr intptr_0, uint uint_0, int int_0, uint uint_1, ref uint uint_2);

	public delegate bool Delegate1(string string_0, string string_1, IntPtr intptr_0, IntPtr intptr_1, bool bool_0, uint uint_0, IntPtr intptr_2, string string_2, ref Struct1 struct1_0, ref Struct0 struct0_0);

	public delegate bool Delegate2(IntPtr intptr_0, int int_0, ref int int_1, int int_2, ref int int_3);

	public delegate bool Delegate3(IntPtr intptr_0, int int_0, byte[] byte_0, int int_1, ref int int_2);

	public delegate bool Delegate4(IntPtr intptr_0, int[] int_0);

	public delegate uint Delegate5(IntPtr intptr_0, int[] int_0);

	public delegate int Delegate6(IntPtr intptr_0, int int_0);

	public delegate int Delegate7(IntPtr intptr_0, int int_0, int int_1, int int_2, int int_3);

	public delegate int Delegate8(IntPtr handle, out uint SuspendCount);

	public delegate bool Delegate9(int int_0);

	public delegate bool Delegate10(out Struct2 lpDebugEvent, int dwMilliseconds);

	public delegate bool Delegate11([In] bool KillOnExit);

	public delegate bool Delegate12(int int_0, int int_1, int int_2);

	static Class16()
	{
		int num = 5;
		Assembly executingAssembly = default(Assembly);
		if (Ghpl3ds49KOyNuS1cr())
		{
			bool bool_ = default(bool);
			while (true)
			{
				switch (num)
				{
				case 5:
					bool_ = false;
					num = 2;
					if (Ghpl3ds49KOyNuS1cr())
					{
						continue;
					}
					goto case 0;
				default:
					num = 4;
					if (Ghpl3ds49KOyNuS1cr())
					{
						continue;
					}
					return;
				case 1:
				case 2:
					executingAssembly = Assembly.GetExecutingAssembly();
					if (Class17.StrongNameSignatureVerificationEx_2(executingAssembly.Location, bool_0: true, out bool_))
					{
						goto case 0;
					}
					goto IL_007f;
				case 0:
					if (bool_)
					{
						break;
					}
					goto IL_007f;
				case 3:
				case 4:
					break;
				case 6:
					return;
				}
				break;
			}
		}
		if (executingAssembly.FullName!.EndsWith("34256fcd934ca661"))
		{
			return;
		}
		goto IL_007f;
		IL_007f:
		throw new SecurityException("Assembly has been tampered");
	}

	internal static bool Ghpl3ds49KOyNuS1cr()
	{
		return true;
	}

	internal static bool dSu04RkNrH1WGmBdFU()
	{
		return false;
	}
}
