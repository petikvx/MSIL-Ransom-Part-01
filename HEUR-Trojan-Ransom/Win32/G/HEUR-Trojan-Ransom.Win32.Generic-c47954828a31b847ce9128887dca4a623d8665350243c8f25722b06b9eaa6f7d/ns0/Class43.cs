using System;
using System.Collections;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using ns3;
using ns5;

namespace ns0;

internal sealed class Class43 : ReadOnlyCollectionBase
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	protected struct Struct7
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		public Enum7 enum7_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_1;

		public int int_0;

		public int int_1;

		public int int_2;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_2;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_3;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	protected struct Struct8
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		public Enum7 enum7_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	protected struct Struct9
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public string string_0;

		public byte byte_0;

		public ushort ushort_0;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_1;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_2;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public string string_3;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 9)]
		public string string_4;

		[SpecialName]
		public Enum7 method_0()
		{
			return (Enum7)(byte_0 & 0x7F);
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	protected struct Struct10
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public string string_0;

		public byte byte_0;

		public ushort ushort_0;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_1;

		[SpecialName]
		public Enum7 method_0()
		{
			return (Enum7)(ushort_0 & 0x7FFF);
		}
	}

	private string string_0;

	public Class42 this[int int_0] => (Class42)base.InnerList[int_0];

	public Class42 this[string string_1]
	{
		get
		{
			if (string_1 != null && string_1.Length != 0)
			{
				string_1 = Path.GetFullPath(string_1);
				if (!smethod_5(string_1))
				{
					return null;
				}
				Class42 @class = null;
				for (int i = 0; i < base.InnerList.Count; i++)
				{
					Class42 class2 = (Class42)base.InnerList[i];
					if (class2.method_2() && class2.method_3(string_1))
					{
						if (@class == null)
						{
							@class = class2;
						}
						else if (@class.method_0().Length < class2.method_0().Length && (class2.method_1() == Enum7.const_0 || @class.method_1() != 0))
						{
							@class = class2;
						}
					}
				}
				return @class;
			}
			return null;
		}
	}

	[SpecialName]
	protected static bool smethod_0()
	{
		return PlatformID.Win32NT == Environment.OSVersion.Platform;
	}

	[SpecialName]
	protected static bool smethod_1()
	{
		OperatingSystem oSVersion = Environment.OSVersion;
		if (PlatformID.Win32NT == oSVersion.Platform && oSVersion.Version.Major >= 5)
		{
			return true;
		}
		return false;
	}

	[DllImport("netapi32", CharSet = CharSet.Unicode)]
	protected static extern int NetShareEnum(string lpServerName, int dwLevel, out IntPtr lpBuffer, int dwPrefMaxLen, out int entriesRead, out int totalEntries, ref int hResume);

	[DllImport("svrapi", CharSet = CharSet.Ansi, EntryPoint = "NetShareEnum")]
	protected static extern int NetShareEnum_1([MarshalAs(UnmanagedType.LPTStr)] string lpServerName, int dwLevel, IntPtr lpBuffer, ushort cbBuffer, out ushort entriesRead, out ushort totalEntries);

	[DllImport("netapi32")]
	protected static extern int NetApiBufferFree(IntPtr intptr_0);

	protected static void smethod_2(string string_1, Class43 class43_0)
	{
		int num = 2;
		int hResume = 0;
		IntPtr lpBuffer = IntPtr.Zero;
		try
		{
			int entriesRead;
			int totalEntries;
			int num2 = NetShareEnum(string_1, num, out lpBuffer, -1, out entriesRead, out totalEntries, ref hResume);
			if (5 == num2)
			{
				num = 1;
				num2 = NetShareEnum(string_1, 1, out lpBuffer, -1, out entriesRead, out totalEntries, ref hResume);
			}
			if (num2 != 0 || entriesRead <= 0)
			{
				return;
			}
			Type type = ((2 == num) ? typeof(Struct7) : typeof(Struct8));
			int num3 = Marshal.SizeOf(type);
			int num4 = 0;
			int num5 = lpBuffer.ToInt32();
			while (num4 < entriesRead)
			{
				IntPtr ptr = new IntPtr(num5);
				if (1 == num)
				{
					Struct8 @struct = (Struct8)Marshal.PtrToStructure(ptr, type);
					class43_0.method_0(@struct.string_0, string.Empty, @struct.enum7_0, @struct.string_1);
				}
				else
				{
					Struct7 struct2 = (Struct7)Marshal.PtrToStructure(ptr, type);
					class43_0.method_0(struct2.string_0, struct2.string_2, struct2.enum7_0, struct2.string_1);
				}
				num4++;
				num5 += num3;
			}
		}
		finally
		{
			if (IntPtr.Zero != lpBuffer)
			{
				NetApiBufferFree(lpBuffer);
			}
		}
	}

	protected static void smethod_3(string string_1, Class43 class43_0)
	{
		int num = 50;
		int num2 = 0;
		Type typeFromHandle = typeof(Struct9);
		int num3 = Marshal.SizeOf(typeFromHandle);
		ushort num4 = (ushort)(20 * num3);
		IntPtr intPtr = Marshal.AllocHGlobal(num4);
		try
		{
			num2 = NetShareEnum_1(string_1, num, intPtr, num4, out var entriesRead, out var totalEntries);
			if (124 == num2)
			{
				num = 1;
				typeFromHandle = typeof(Struct10);
				num3 = Marshal.SizeOf(typeFromHandle);
				num2 = NetShareEnum_1(string_1, 1, intPtr, num4, out entriesRead, out totalEntries);
			}
			if (num2 != 0 && 234 != num2)
			{
				Console.WriteLine(num2);
				return;
			}
			int num5 = 0;
			int num6 = intPtr.ToInt32();
			while (num5 < entriesRead)
			{
				IntPtr ptr = new IntPtr(num6);
				if (1 == num)
				{
					Struct10 @struct = (Struct10)Marshal.PtrToStructure(ptr, typeFromHandle);
					class43_0.method_0(@struct.string_0, string.Empty, @struct.method_0(), @struct.string_1);
				}
				else
				{
					Struct9 struct2 = (Struct9)Marshal.PtrToStructure(ptr, typeFromHandle);
					class43_0.method_0(struct2.string_0, struct2.string_2, struct2.method_0(), struct2.string_1);
				}
				num5++;
				num6 += num3;
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	protected static void smethod_4(string string_1, Class43 class43_0)
	{
		if (string_1 != null && string_1.Length != 0 && !smethod_1())
		{
			string_1 = string_1.ToUpper();
			if ('\\' != string_1[0] || '\\' != string_1[1])
			{
				string_1 = "\\\\" + string_1;
			}
		}
		if (smethod_0())
		{
			smethod_2(string_1, class43_0);
		}
		else
		{
			smethod_3(string_1, class43_0);
		}
	}

	public static bool smethod_5(string string_1)
	{
		if (string_1 != null && string_1.Length != 0)
		{
			char c = char.ToUpper(string_1[0]);
			if ('A' <= c && c <= 'Z')
			{
				if (Path.VolumeSeparatorChar != string_1[1])
				{
					return false;
				}
				if (Path.DirectorySeparatorChar != string_1[2])
				{
					return false;
				}
				return true;
			}
			return false;
		}
		return false;
	}

	public static Class43 smethod_6(string string_1)
	{
		return new Class43(string_1);
	}

	public Class43()
	{
		string_0 = string.Empty;
		smethod_4(string_0, this);
	}

	public Class43(string string_1)
	{
		string_0 = string_1;
		smethod_4(string_0, this);
	}

	protected void Add(Class42 class42_0)
	{
		base.InnerList.Add(class42_0);
	}

	protected void method_0(string string_1, string string_2, Enum7 enum7_0, string string_3)
	{
		base.InnerList.Add(new Class42(string_0, string_1, string_2, enum7_0, string_3));
	}
}
