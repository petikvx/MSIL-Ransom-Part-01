using System;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

public class GClass7 : IDisposable
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0000010C-0000-0000-C000-000000000046")]
	private interface Interface0
	{
		[PreserveSig]
		void imethod_0(out Guid guid_0);
	}

	[ComImport]
	[Guid("0000010B-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface Interface1
	{
		[PreserveSig]
		void imethod_0(out Guid guid_0);

		void imethod_1();

		void imethod_2([MarshalAs(UnmanagedType.LPWStr)] string string_0, uint uint_0);

		void imethod_3([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0);

		void imethod_4([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		void imethod_5([MarshalAs(UnmanagedType.LPWStr)] out string string_0);
	}

	[ComImport]
	[Guid("000214EE-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface Interface2
	{
		void imethod_0([Out][MarshalAs(UnmanagedType.LPStr)] StringBuilder stringBuilder_0, int int_0, ref Struct2 struct2_0, uint uint_0);

		void imethod_1(out IntPtr intptr_0);

		void imethod_2(IntPtr intptr_0);

		void imethod_3([Out][MarshalAs(UnmanagedType.LPStr)] StringBuilder stringBuilder_0, int int_0);

		void imethod_4([MarshalAs(UnmanagedType.LPStr)] string string_0);

		void imethod_5([Out][MarshalAs(UnmanagedType.LPStr)] StringBuilder stringBuilder_0, int int_0);

		void imethod_6([MarshalAs(UnmanagedType.LPStr)] string string_0);

		void imethod_7([Out][MarshalAs(UnmanagedType.LPStr)] StringBuilder stringBuilder_0, int int_0);

		void imethod_8([MarshalAs(UnmanagedType.LPStr)] string string_0);

		void imethod_9(out short short_0);

		void imethod_10(short short_0);

		void imethod_11(out uint uint_0);

		void imethod_12(uint uint_0);

		void imethod_13([Out][MarshalAs(UnmanagedType.LPStr)] StringBuilder stringBuilder_0, int int_0, out int int_1);

		void imethod_14([MarshalAs(UnmanagedType.LPStr)] string string_0, int int_0);

		void imethod_15([MarshalAs(UnmanagedType.LPStr)] string string_0, uint uint_0);

		void imethod_16(IntPtr intptr_0, uint uint_0);

		void imethod_17([MarshalAs(UnmanagedType.LPStr)] string string_0);
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("000214F9-0000-0000-C000-000000000046")]
	private interface Interface3
	{
		void imethod_0([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0, ref Struct1 struct1_0, uint uint_0);

		void imethod_1(out IntPtr intptr_0);

		void imethod_2(IntPtr intptr_0);

		void imethod_3([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

		void imethod_4([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		void imethod_5([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

		void imethod_6([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		void imethod_7([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

		void imethod_8([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		void imethod_9(out short short_0);

		void imethod_10(short short_0);

		void imethod_11(out uint uint_0);

		void imethod_12(uint uint_0);

		void imethod_13([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0, out int int_1);

		void imethod_14([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

		void imethod_15([MarshalAs(UnmanagedType.LPWStr)] string string_0, uint uint_0);

		void imethod_16(IntPtr intptr_0, uint uint_0);

		void imethod_17([MarshalAs(UnmanagedType.LPWStr)] string string_0);
	}

	[ComImport]
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("00021401-0000-0000-C000-000000000046")]
	private class Class6
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Class6();
	}

	private enum Enum0 : uint
	{
		SLGP_SHORTPATH = 1u,
		SLGP_UNCPRIORITY
	}

	[Flags]
	private enum Enum1 : uint
	{
		SW_HIDE = 0u,
		SW_SHOWNORMAL = 1u,
		SW_NORMAL = 1u,
		SW_SHOWMINIMIZED = 2u,
		SW_SHOWMAXIMIZED = 3u,
		SW_MAXIMIZE = 3u,
		SW_SHOWNOACTIVATE = 4u,
		SW_SHOW = 5u,
		SW_MINIMIZE = 6u,
		SW_SHOWMINNOACTIVE = 7u,
		SW_SHOWNA = 8u,
		SW_RESTORE = 9u,
		SW_SHOWDEFAULT = 0xAu,
		SW_MAX = 0xAu
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
	private struct Struct1
	{
		public uint uint_0;

		public Struct3 struct3_0;

		public Struct3 struct3_1;

		public Struct3 struct3_2;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
		public string string_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	private struct Struct2
	{
		public uint uint_0;

		public Struct3 struct3_0;

		public Struct3 struct3_1;

		public Struct3 struct3_2;

		public uint uint_1;

		public uint uint_2;

		public uint uint_3;

		public uint uint_4;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
		public string string_1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	private struct Struct3
	{
		public uint uint_0;

		public uint uint_1;
	}

	private class Class7
	{
		[DllImport("Shell32", CharSet = CharSet.Auto)]
		internal static extern int ExtractIconEx([MarshalAs(UnmanagedType.LPTStr)] string string_0, int int_0, IntPtr[] intptr_0, IntPtr[] intptr_1, int int_1);

		[DllImport("user32")]
		internal static extern int DestroyIcon(IntPtr intptr_0);
	}

	[Flags]
	public enum GEnum0 : uint
	{
		SLR_ANY_MATCH = 2u,
		SLR_INVOKE_MSI = 0x80u,
		SLR_NOLINKINFO = 0x40u,
		SLR_NO_UI = 1u,
		SLR_NO_UI_WITH_MSG_PUMP = 0x101u,
		SLR_NOUPDATE = 8u,
		SLR_NOSEARCH = 0x10u,
		SLR_NOTRACK = 0x20u,
		SLR_UPDATE = 4u
	}

	public enum GEnum1 : uint
	{
		edmNormal = 1u,
		edmMinimized = 7u,
		edmMaximized = 3u
	}

	private Interface3 interface3_0;

	private Interface2 interface2_0;

	private string string_0 = "";

	public string String_0
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
		}
	}

	public Icon Icon_0 => method_0(bool_0: true);

	public Icon Icon_1 => method_0(bool_0: false);

	public string String_1
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			int int_ = 0;
			if (interface2_0 == null)
			{
				interface3_0.imethod_13(stringBuilder, stringBuilder.Capacity, out int_);
			}
			else
			{
				interface2_0.imethod_13(stringBuilder, stringBuilder.Capacity, out int_);
			}
			return stringBuilder.ToString();
		}
		set
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			int int_ = 0;
			if (interface2_0 == null)
			{
				interface3_0.imethod_13(stringBuilder, stringBuilder.Capacity, out int_);
			}
			else
			{
				interface2_0.imethod_13(stringBuilder, stringBuilder.Capacity, out int_);
			}
			if (interface2_0 == null)
			{
				interface3_0.imethod_14(value, int_);
			}
			else
			{
				interface2_0.imethod_14(value, int_);
			}
		}
	}

	public int Int32_0
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			int int_ = 0;
			if (interface2_0 == null)
			{
				interface3_0.imethod_13(stringBuilder, stringBuilder.Capacity, out int_);
			}
			else
			{
				interface2_0.imethod_13(stringBuilder, stringBuilder.Capacity, out int_);
			}
			return int_;
		}
		set
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			int int_ = 0;
			if (interface2_0 == null)
			{
				interface3_0.imethod_13(stringBuilder, stringBuilder.Capacity, out int_);
			}
			else
			{
				interface2_0.imethod_13(stringBuilder, stringBuilder.Capacity, out int_);
			}
			if (interface2_0 == null)
			{
				interface3_0.imethod_14(stringBuilder.ToString(), value);
			}
			else
			{
				interface2_0.imethod_14(stringBuilder.ToString(), value);
			}
		}
	}

	public string String_2
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			if (interface2_0 == null)
			{
				Struct1 struct1_ = default(Struct1);
				interface3_0.imethod_0(stringBuilder, stringBuilder.Capacity, ref struct1_, 2u);
			}
			else
			{
				Struct2 struct2_ = default(Struct2);
				interface2_0.imethod_0(stringBuilder, stringBuilder.Capacity, ref struct2_, 2u);
			}
			return stringBuilder.ToString();
		}
		set
		{
			if (interface2_0 == null)
			{
				interface3_0.imethod_17(value);
			}
			else
			{
				interface2_0.imethod_17(value);
			}
		}
	}

	public string String_3
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			if (interface2_0 == null)
			{
				interface3_0.imethod_5(stringBuilder, stringBuilder.Capacity);
			}
			else
			{
				interface2_0.imethod_5(stringBuilder, stringBuilder.Capacity);
			}
			return stringBuilder.ToString();
		}
		set
		{
			if (interface2_0 == null)
			{
				interface3_0.imethod_6(value);
			}
			else
			{
				interface2_0.imethod_6(value);
			}
		}
	}

	public string String_4
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(1024, 1024);
			if (interface2_0 == null)
			{
				interface3_0.imethod_3(stringBuilder, stringBuilder.Capacity);
			}
			else
			{
				interface2_0.imethod_3(stringBuilder, stringBuilder.Capacity);
			}
			return stringBuilder.ToString();
		}
		set
		{
			if (interface2_0 == null)
			{
				interface3_0.imethod_4(value);
			}
			else
			{
				interface2_0.imethod_4(value);
			}
		}
	}

	public string String_5
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			if (interface2_0 == null)
			{
				interface3_0.imethod_7(stringBuilder, stringBuilder.Capacity);
			}
			else
			{
				interface2_0.imethod_7(stringBuilder, stringBuilder.Capacity);
			}
			return stringBuilder.ToString();
		}
		set
		{
			if (interface2_0 == null)
			{
				interface3_0.imethod_8(value);
			}
			else
			{
				interface2_0.imethod_8(value);
			}
		}
	}

	public GEnum1 GEnum1_0
	{
		get
		{
			uint uint_ = 0u;
			if (interface2_0 == null)
			{
				interface3_0.imethod_11(out uint_);
			}
			else
			{
				interface2_0.imethod_11(out uint_);
			}
			return (GEnum1)uint_;
		}
		set
		{
			if (interface2_0 == null)
			{
				interface3_0.imethod_12((uint)value);
			}
			else
			{
				interface2_0.imethod_12((uint)value);
			}
		}
	}

	public Keys Keys_0
	{
		get
		{
			short short_ = 0;
			if (interface2_0 == null)
			{
				interface3_0.imethod_9(out short_);
			}
			else
			{
				interface2_0.imethod_9(out short_);
			}
			return (Keys)short_;
		}
		set
		{
			//IL_000e: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			if (interface2_0 == null)
			{
				interface3_0.imethod_10((short)value);
			}
			else
			{
				interface2_0.imethod_10((short)value);
			}
		}
	}

	public GClass7()
	{
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			interface3_0 = (Interface3)new Class6();
		}
		else
		{
			interface2_0 = (Interface2)new Class6();
		}
	}

	public GClass7(string linkFile)
		: this()
	{
		method_3(linkFile);
	}

	~GClass7()
	{
		Dispose();
	}

	public void Dispose()
	{
		if (interface3_0 != null)
		{
			Marshal.ReleaseComObject(interface3_0);
			interface3_0 = null;
		}
		if (interface2_0 != null)
		{
			Marshal.ReleaseComObject(interface2_0);
			interface2_0 = null;
		}
	}

	private Icon method_0(bool bool_0)
	{
		int int_ = 0;
		StringBuilder stringBuilder = new StringBuilder(260, 260);
		if (interface2_0 == null)
		{
			interface3_0.imethod_13(stringBuilder, stringBuilder.Capacity, out int_);
		}
		else
		{
			interface2_0.imethod_13(stringBuilder, stringBuilder.Capacity, out int_);
		}
		string text = stringBuilder.ToString();
		if (text.Length == 0)
		{
			GClass8.GEnum2 gEnum = GClass8.GEnum2.SHGFI_ICON | GClass8.GEnum2.SHGFI_ATTRIBUTES;
			gEnum = ((!bool_0) ? (gEnum | GClass8.GEnum2.SHGFI_SMALLICON) : gEnum);
			GClass8 gClass = new GClass8(String_2, gEnum);
			return gClass.Icon_0;
		}
		IntPtr[] array = new IntPtr[1] { IntPtr.Zero };
		if (bool_0)
		{
			Class7.ExtractIconEx(text, int_, array, null, 1);
		}
		else
		{
			Class7.ExtractIconEx(text, int_, null, array, 1);
		}
		Icon result = null;
		if (array[0] != IntPtr.Zero)
		{
			result = Icon.FromHandle(array[0]);
		}
		return result;
	}

	public void method_1()
	{
		method_2(string_0);
	}

	public void method_2(string string_1)
	{
		if (interface2_0 == null)
		{
			((Interface1)interface3_0).imethod_3(string_1, bool_0: true);
			string_0 = string_1;
		}
		else
		{
			((Interface1)interface2_0).imethod_3(string_1, bool_0: true);
			string_0 = string_1;
		}
	}

	public void method_3(string string_1)
	{
		method_5(string_1, IntPtr.Zero, GEnum0.SLR_ANY_MATCH | GEnum0.SLR_NO_UI, 1);
	}

	public void method_4(string string_1, IntPtr intptr_0, GEnum0 genum0_0)
	{
		method_5(string_1, intptr_0, genum0_0, 1);
	}

	public void method_5(string string_1, IntPtr intptr_0, GEnum0 genum0_0, ushort ushort_0)
	{
		uint uint_ = (((genum0_0 & GEnum0.SLR_NO_UI) != GEnum0.SLR_NO_UI) ? ((uint)genum0_0) : ((uint)genum0_0 | (uint)(ushort_0 << 16)));
		if (interface2_0 == null)
		{
			((Interface1)interface3_0).imethod_2(string_1, 0u);
			interface3_0.imethod_16(intptr_0, uint_);
			string_0 = string_1;
		}
		else
		{
			((Interface1)interface2_0).imethod_2(string_1, 0u);
			interface2_0.imethod_16(intptr_0, uint_);
			string_0 = string_1;
		}
	}
}
