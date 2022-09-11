using System;
using System.Collections;
using System.IO;
using System.Runtime.InteropServices;

public class GClass5 : ReadOnlyCollectionBase
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
	protected struct GStruct0
	{
		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_0;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	protected struct GStruct1
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		public GEnum0 genum0_0;

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
	protected struct GStruct2
	{
		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_0;

		public GEnum0 genum0_0;

		[MarshalAs(UnmanagedType.LPWStr)]
		public string string_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	protected struct GStruct3
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

		public GEnum0 GEnum0_0 => (GEnum0)(byte_0 & 0x7F);
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	protected struct GStruct4
	{
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 13)]
		public string string_0;

		public byte byte_0;

		public ushort ushort_0;

		[MarshalAs(UnmanagedType.LPTStr)]
		public string string_1;

		public GEnum0 GEnum0_0 => (GEnum0)(ushort_0 & 0x7FFF);
	}

	private readonly string string_0;

	protected const int int_0 = 260;

	protected const int int_1 = 0;

	protected const int int_2 = 5;

	protected const int int_3 = 124;

	protected const int int_4 = 234;

	protected const int int_5 = 2250;

	protected const int int_6 = 1;

	protected const int int_7 = 20;

	private static GClass5 gclass5_0;

	protected static bool Boolean_0 => PlatformID.Win32NT == Environment.OSVersion.Platform;

	protected static bool Boolean_1
	{
		get
		{
			OperatingSystem oSVersion = Environment.OSVersion;
			if (PlatformID.Win32NT == oSVersion.Platform && oSVersion.Version.Major >= 5)
			{
				return true;
			}
			return false;
		}
	}

	public static GClass5 GClass5_0 => gclass5_0 ?? (gclass5_0 = new GClass5());

	public string String_0 => string_0;

	public GClass4 this[int int_8] => (GClass4)base.InnerList[int_8];

	public GClass4 this[string string_1]
	{
		get
		{
			if (string.IsNullOrEmpty(string_1))
			{
				return null;
			}
			string_1 = Path.GetFullPath(string_1);
			if (!smethod_3(string_1))
			{
				return null;
			}
			GClass4 gClass = null;
			foreach (GClass4 inner in base.InnerList)
			{
				if (inner.Boolean_0 && inner.method_0(string_1))
				{
					if (gClass == null)
					{
						gClass = inner;
					}
					else if (gClass.String_2.Length < inner.String_2.Length && (inner.GEnum0_0 == GEnum0.Disk || gClass.GEnum0_0 != 0))
					{
						gClass = inner;
					}
				}
			}
			return gClass;
		}
	}

	public void method_0(GClass4[] gclass4_0, int int_8)
	{
		base.InnerList.CopyTo(gclass4_0, int_8);
	}

	[DllImport("mpr", CharSet = CharSet.Auto)]
	protected static extern int WNetGetUniversalName(string string_1, int int_8, ref GStruct0 gstruct0_0, ref int int_9);

	[DllImport("mpr", CharSet = CharSet.Auto, EntryPoint = "WNetGetUniversalName")]
	protected static extern int WNetGetUniversalName_1(string string_1, int int_8, IntPtr intptr_0, ref int int_9);

	[DllImport("netapi32", CharSet = CharSet.Unicode)]
	protected static extern int NetShareEnum(string string_1, int int_8, out IntPtr intptr_0, int int_9, out int int_10, out int int_11, ref int int_12);

	[DllImport("svrapi", CharSet = CharSet.Ansi, EntryPoint = "NetShareEnum")]
	protected static extern int NetShareEnum_1([MarshalAs(UnmanagedType.LPTStr)] string string_1, int int_8, IntPtr intptr_0, ushort ushort_0, out ushort ushort_1, out ushort ushort_2);

	[DllImport("netapi32")]
	protected static extern int NetApiBufferFree(IntPtr intptr_0);

	protected static void smethod_0(string string_1, GClass5 gclass5_1)
	{
		int num = 2;
		int int_ = 0;
		IntPtr intptr_ = IntPtr.Zero;
		try
		{
			int int_2;
			int int_3;
			int num2 = NetShareEnum(string_1, num, out intptr_, -1, out int_2, out int_3, ref int_);
			if (5 == num2)
			{
				num = 1;
				num2 = NetShareEnum(string_1, 1, out intptr_, -1, out int_2, out int_3, ref int_);
			}
			if (num2 != 0 || int_2 <= 0)
			{
				return;
			}
			Type type = ((2 == num) ? typeof(GStruct1) : typeof(GStruct2));
			int num3 = Marshal.SizeOf(type);
			int num4 = 0;
			int num5 = intptr_.ToInt32();
			while (num4 < int_2)
			{
				IntPtr ptr = new IntPtr(num5);
				if (1 != num)
				{
					GStruct1 gStruct = (GStruct1)Marshal.PtrToStructure(ptr, type);
					gclass5_1.method_2(gStruct.string_0, gStruct.string_2, gStruct.genum0_0, gStruct.string_1);
				}
				else
				{
					GStruct2 gStruct2 = (GStruct2)Marshal.PtrToStructure(ptr, type);
					gclass5_1.method_2(gStruct2.string_0, string.Empty, gStruct2.genum0_0, gStruct2.string_1);
				}
				num4++;
				num5 += num3;
			}
		}
		finally
		{
			if (IntPtr.Zero != intptr_)
			{
				NetApiBufferFree(intptr_);
			}
		}
	}

	protected static void smethod_1(string string_1, GClass5 gclass5_1)
	{
		int num = 50;
		Type typeFromHandle = typeof(GStruct3);
		int num2 = Marshal.SizeOf(typeFromHandle);
		ushort num3 = (ushort)(20 * num2);
		IntPtr intPtr = Marshal.AllocHGlobal(num3);
		try
		{
			ushort ushort_;
			ushort ushort_2;
			int num4 = NetShareEnum_1(string_1, num, intPtr, num3, out ushort_, out ushort_2);
			if (124 == num4)
			{
				num = 1;
				typeFromHandle = typeof(GStruct4);
				num2 = Marshal.SizeOf(typeFromHandle);
				num4 = NetShareEnum_1(string_1, 1, intPtr, num3, out ushort_, out ushort_2);
			}
			if (num4 != 0 && 234 != num4)
			{
				Console.WriteLine(num4);
				return;
			}
			int num5 = 0;
			int num6 = intPtr.ToInt32();
			while (num5 < ushort_)
			{
				IntPtr ptr = new IntPtr(num6);
				if (1 != num)
				{
					GStruct3 gStruct = (GStruct3)Marshal.PtrToStructure(ptr, typeFromHandle);
					gclass5_1.method_2(gStruct.string_0, gStruct.string_2, gStruct.GEnum0_0, gStruct.string_1);
				}
				else
				{
					GStruct4 gStruct2 = (GStruct4)Marshal.PtrToStructure(ptr, typeFromHandle);
					gclass5_1.method_2(gStruct2.string_0, string.Empty, gStruct2.GEnum0_0, gStruct2.string_1);
				}
				num5++;
				num6 += num2;
			}
		}
		finally
		{
			Marshal.FreeHGlobal(intPtr);
		}
	}

	protected static void smethod_2(string string_1, GClass5 gclass5_1)
	{
		if (!string.IsNullOrEmpty(string_1) && !Boolean_1)
		{
			string_1 = string_1.ToUpper();
			if ('\\' != string_1[0] || '\\' != string_1[1])
			{
				string_1 = "\\\\" + string_1;
			}
		}
		if (!Boolean_0)
		{
			smethod_1(string_1, gclass5_1);
		}
		else
		{
			smethod_0(string_1, gclass5_1);
		}
	}

	public static bool smethod_3(string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return false;
		}
		char c = char.ToUpper(string_1[0]);
		if ('A' <= c && c <= 'Z')
		{
			if (Path.VolumeSeparatorChar == string_1[1])
			{
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

	public static string smethod_4(string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return string.Empty;
		}
		string_1 = Path.GetFullPath(string_1);
		if (smethod_3(string_1))
		{
			GStruct0 gstruct0_ = default(GStruct0);
			int int_ = Marshal.SizeOf((object)gstruct0_);
			int num = WNetGetUniversalName(string_1, 1, ref gstruct0_, ref int_);
			if (234 == num)
			{
				IntPtr intPtr = Marshal.AllocHGlobal(int_);
				try
				{
					num = WNetGetUniversalName_1(string_1, 1, intPtr, ref int_);
					if (num == 0)
					{
						gstruct0_ = (GStruct0)Marshal.PtrToStructure(intPtr, typeof(GStruct0));
					}
				}
				finally
				{
					Marshal.FreeHGlobal(intPtr);
				}
			}
			switch (num)
			{
			case 2250:
			{
				GClass4 gClass = GClass5_0?[string_1];
				if (gClass != null)
				{
					string string_2 = gClass.String_2;
					if (!string.IsNullOrEmpty(string_2))
					{
						int num2 = string_2.Length;
						if (Path.DirectorySeparatorChar != string_2[string_2.Length - 1])
						{
							num2++;
						}
						string_1 = ((num2 < string_1.Length) ? string_1.Substring(num2) : string.Empty);
						string_1 = Path.Combine(gClass.ToString(), string_1);
						return string_1;
					}
					return string_1;
				}
				return string_1;
			}
			default:
				Console.WriteLine("Unknown return value: {0}", num);
				return string.Empty;
			case 0:
				return gstruct0_.string_0;
			}
		}
		return string_1;
	}

	public static GClass4 smethod_5(string string_1)
	{
		if (string.IsNullOrEmpty(string_1))
		{
			return null;
		}
		string_1 = Path.GetFullPath(string_1);
		if (smethod_3(string_1))
		{
			return GClass5_0?[string_1];
		}
		return null;
	}

	public static GClass5 smethod_6(string string_1)
	{
		return new GClass5(string_1);
	}

	public GClass5()
	{
		string_0 = string.Empty;
		smethod_2(string_0, this);
	}

	public GClass5(string string_1)
	{
		string_0 = string_1;
		smethod_2(string_0, this);
	}

	protected void method_1(GClass4 gclass4_0)
	{
		base.InnerList.Add(gclass4_0);
	}

	protected void method_2(string string_1, string string_2, GEnum0 genum0_0, string string_3)
	{
		base.InnerList.Add(new GClass4(string_0, string_1, string_2, genum0_0, string_3));
	}
}
