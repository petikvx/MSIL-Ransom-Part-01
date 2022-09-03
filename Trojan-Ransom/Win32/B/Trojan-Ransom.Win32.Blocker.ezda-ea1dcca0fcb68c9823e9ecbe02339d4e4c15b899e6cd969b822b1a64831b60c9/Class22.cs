using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

internal class Class22 : IDisposable
{
	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0000010C-0000-0000-C000-000000000046")]
	private interface Interface0
	{
		[PreserveSig]
		void GetClassID(out Guid guid_0);
	}

	[ComImport]
	[Guid("0000010B-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface Interface1
	{
		[PreserveSig]
		void GetClassID(out Guid guid_0);

		void IsDirty();

		void Load([MarshalAs(UnmanagedType.LPWStr)] string string_0, uint uint_0);

		void Save([MarshalAs(UnmanagedType.LPWStr)] string string_0, [MarshalAs(UnmanagedType.Bool)] bool bool_0);

		void SaveCompleted([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		void GetCurFile([MarshalAs(UnmanagedType.LPWStr)] out string string_0);
	}

	[ComImport]
	[Guid("000214EE-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface Interface2
	{
		void GetPath([Out][MarshalAs(UnmanagedType.LPStr)] StringBuilder stringBuilder_0, int int_0, ref Struct2 struct2_0, uint uint_0);

		void GetIDList(out IntPtr intptr_0);

		void SetIDList(IntPtr intptr_0);

		void GetDescription([Out][MarshalAs(UnmanagedType.LPStr)] StringBuilder stringBuilder_0, int int_0);

		void SetDescription([MarshalAs(UnmanagedType.LPStr)] string string_0);

		void GetWorkingDirectory([Out][MarshalAs(UnmanagedType.LPStr)] StringBuilder stringBuilder_0, int int_0);

		void SetWorkingDirectory([MarshalAs(UnmanagedType.LPStr)] string string_0);

		void GetArguments([Out][MarshalAs(UnmanagedType.LPStr)] StringBuilder stringBuilder_0, int int_0);

		void SetArguments([MarshalAs(UnmanagedType.LPStr)] string string_0);

		void GetHotkey(out short short_0);

		void SetHotkey(short short_0);

		void GetShowCmd(out uint uint_0);

		void SetShowCmd(uint uint_0);

		void GetIconLocation([Out][MarshalAs(UnmanagedType.LPStr)] StringBuilder stringBuilder_0, int int_0, out int int_1);

		void SetIconLocation([MarshalAs(UnmanagedType.LPStr)] string string_0, int int_0);

		void SetRelativePath([MarshalAs(UnmanagedType.LPStr)] string string_0, uint uint_0);

		void Resolve(IntPtr intptr_0, uint uint_0);

		void SetPath([MarshalAs(UnmanagedType.LPStr)] string string_0);
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("000214F9-0000-0000-C000-000000000046")]
	private interface Interface3
	{
		void GetPath([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0, ref Struct1 struct1_0, uint uint_0);

		void GetIDList(out IntPtr intptr_0);

		void SetIDList(IntPtr intptr_0);

		void GetDescription([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

		void SetDescription([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		void GetWorkingDirectory([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

		void SetWorkingDirectory([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		void GetArguments([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0);

		void SetArguments([MarshalAs(UnmanagedType.LPWStr)] string string_0);

		void GetHotkey(out short short_0);

		void SetHotkey(short short_0);

		void GetShowCmd(out uint uint_0);

		void SetShowCmd(uint uint_0);

		void GetIconLocation([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_0, out int int_1);

		void SetIconLocation([MarshalAs(UnmanagedType.LPWStr)] string string_0, int int_0);

		void SetRelativePath([MarshalAs(UnmanagedType.LPWStr)] string string_0, uint uint_0);

		void Resolve(IntPtr intptr_0, uint uint_0);

		void SetPath([MarshalAs(UnmanagedType.LPWStr)] string string_0);
	}

	[ComImport]
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("00021401-0000-0000-C000-000000000046")]
	private class Class23
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Class23();
	}

	private enum Enum2 : uint
	{
		const_0 = 1u,
		const_1
	}

	[Flags]
	private enum Enum3 : uint
	{
		flag_0 = 0u,
		flag_1 = 1u,
		flag_2 = 1u,
		flag_3 = 2u,
		flag_4 = 3u,
		flag_5 = 3u,
		flag_6 = 4u,
		flag_7 = 5u,
		flag_8 = 6u,
		flag_9 = 7u,
		flag_10 = 8u,
		flag_11 = 9u,
		flag_12 = 0xAu,
		flag_13 = 0xAu
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

	private class Class24
	{
		[DllImport("Shell32", CharSet = CharSet.Auto)]
		internal static extern int ExtractIconEx([MarshalAs(UnmanagedType.LPTStr)] string string_0, int int_0, IntPtr[] intptr_0, IntPtr[] intptr_1, int int_1);

		[DllImport("user32")]
		internal static extern int DestroyIcon(IntPtr intptr_0);
	}

	public enum Enum4 : uint
	{
		const_0 = 1u,
		const_1 = 7u,
		const_2 = 3u
	}

	private Interface3 interface3_0;

	private Interface2 interface2_0;

	private string string_0 = "";

	public string String_0
	{
		get
		{
			StringBuilder stringBuilder = Delegate291.smethod_0(260, 260);
			int int_ = 0;
			if (interface2_0 == null)
			{
				interface3_0.GetIconLocation(stringBuilder, Delegate292.smethod_0(stringBuilder), out int_);
			}
			else
			{
				interface2_0.GetIconLocation(stringBuilder, Delegate292.smethod_0(stringBuilder), out int_);
			}
			return Delegate69.smethod_0(stringBuilder);
		}
		set
		{
			StringBuilder stringBuilder = Delegate291.smethod_0(260, 260);
			int int_ = 0;
			if (interface2_0 == null)
			{
				interface3_0.GetIconLocation(stringBuilder, Delegate292.smethod_0(stringBuilder), out int_);
			}
			else
			{
				interface2_0.GetIconLocation(stringBuilder, Delegate292.smethod_0(stringBuilder), out int_);
			}
			if (interface2_0 == null)
			{
				interface3_0.SetIconLocation(value, int_);
			}
			else
			{
				interface2_0.SetIconLocation(value, int_);
			}
		}
	}

	public int Int32_0
	{
		get
		{
			StringBuilder stringBuilder = Delegate291.smethod_0(260, 260);
			int int_ = 0;
			if (interface2_0 == null)
			{
				interface3_0.GetIconLocation(stringBuilder, Delegate292.smethod_0(stringBuilder), out int_);
			}
			else
			{
				interface2_0.GetIconLocation(stringBuilder, Delegate292.smethod_0(stringBuilder), out int_);
			}
			return int_;
		}
		set
		{
			StringBuilder stringBuilder = Delegate291.smethod_0(260, 260);
			int int_ = 0;
			if (interface2_0 == null)
			{
				interface3_0.GetIconLocation(stringBuilder, Delegate292.smethod_0(stringBuilder), out int_);
			}
			else
			{
				interface2_0.GetIconLocation(stringBuilder, Delegate292.smethod_0(stringBuilder), out int_);
			}
			if (interface2_0 == null)
			{
				interface3_0.SetIconLocation(Delegate69.smethod_0(stringBuilder), value);
			}
			else
			{
				interface2_0.SetIconLocation(Delegate69.smethod_0(stringBuilder), value);
			}
		}
	}

	public string String_1
	{
		get
		{
			StringBuilder stringBuilder = Delegate291.smethod_0(260, 260);
			if (interface2_0 == null)
			{
				Struct1 struct1_ = default(Struct1);
				interface3_0.GetPath(stringBuilder, Delegate292.smethod_0(stringBuilder), ref struct1_, 2u);
			}
			else
			{
				Struct2 struct2_ = default(Struct2);
				interface2_0.GetPath(stringBuilder, Delegate292.smethod_0(stringBuilder), ref struct2_, 2u);
			}
			return Delegate69.smethod_0(stringBuilder);
		}
		set
		{
			if (interface2_0 == null)
			{
				interface3_0.SetPath(value);
			}
			else
			{
				interface2_0.SetPath(value);
			}
		}
	}

	public string String_2
	{
		get
		{
			StringBuilder stringBuilder = Delegate291.smethod_0(260, 260);
			if (interface2_0 == null)
			{
				interface3_0.GetWorkingDirectory(stringBuilder, Delegate292.smethod_0(stringBuilder));
			}
			else
			{
				interface2_0.GetWorkingDirectory(stringBuilder, Delegate292.smethod_0(stringBuilder));
			}
			return Delegate69.smethod_0(stringBuilder);
		}
		set
		{
			if (interface2_0 == null)
			{
				interface3_0.SetWorkingDirectory(value);
			}
			else
			{
				interface2_0.SetWorkingDirectory(value);
			}
		}
	}

	public string String_3
	{
		get
		{
			StringBuilder stringBuilder = Delegate291.smethod_0(1024, 1024);
			if (interface2_0 == null)
			{
				interface3_0.GetDescription(stringBuilder, Delegate292.smethod_0(stringBuilder));
			}
			else
			{
				interface2_0.GetDescription(stringBuilder, Delegate292.smethod_0(stringBuilder));
			}
			return Delegate69.smethod_0(stringBuilder);
		}
		set
		{
			if (interface2_0 == null)
			{
				interface3_0.SetDescription(value);
			}
			else
			{
				interface2_0.SetDescription(value);
			}
		}
	}

	public string String_4
	{
		get
		{
			StringBuilder stringBuilder = Delegate291.smethod_0(260, 260);
			if (interface2_0 == null)
			{
				interface3_0.GetArguments(stringBuilder, Delegate292.smethod_0(stringBuilder));
			}
			else
			{
				interface2_0.GetArguments(stringBuilder, Delegate292.smethod_0(stringBuilder));
			}
			return Delegate69.smethod_0(stringBuilder);
		}
		set
		{
			if (interface2_0 == null)
			{
				interface3_0.SetArguments(value);
			}
			else
			{
				interface2_0.SetArguments(value);
			}
		}
	}

	public Enum4 Enum4_0
	{
		get
		{
			uint uint_ = 0u;
			if (interface2_0 == null)
			{
				interface3_0.GetShowCmd(out uint_);
			}
			else
			{
				interface2_0.GetShowCmd(out uint_);
			}
			return (Enum4)uint_;
		}
		set
		{
			if (interface2_0 == null)
			{
				interface3_0.SetShowCmd((uint)value);
			}
			else
			{
				interface2_0.SetShowCmd((uint)value);
			}
		}
	}

	public Class22()
	{
		if (Delegate144.smethod_0(Delegate143.smethod_0()) == PlatformID.Win32NT)
		{
			interface3_0 = (Interface3)Delegate287.smethod_0();
		}
		else
		{
			interface2_0 = (Interface2)Delegate287.smethod_0();
		}
	}

	~Class22()
	{
		try
		{
			Delegate288.smethod_0(this);
		}
		finally
		{
			Delegate289.smethod_0(this);
		}
	}

	void IDisposable.Dispose()
	{
		if (interface3_0 != null)
		{
			Delegate290.smethod_0(interface3_0);
			interface3_0 = null;
		}
		if (interface2_0 != null)
		{
			Delegate290.smethod_0(interface2_0);
			interface2_0 = null;
		}
	}

	public void method_0()
	{
		Delegate293.smethod_0(this, string_0);
	}

	public void method_1(string string_1)
	{
		if (interface2_0 == null)
		{
			((Interface1)interface3_0).Save(string_1, bool_0: true);
			string_0 = string_1;
		}
		else
		{
			((Interface1)interface2_0).Save(string_1, bool_0: true);
			string_0 = string_1;
		}
	}
}
