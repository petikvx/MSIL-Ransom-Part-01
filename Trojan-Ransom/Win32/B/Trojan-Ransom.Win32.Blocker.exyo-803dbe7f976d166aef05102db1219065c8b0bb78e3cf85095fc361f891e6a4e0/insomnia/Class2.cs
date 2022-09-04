using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace insomnia;

public class Class2 : IDisposable
{
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	private struct Struct1
	{
		public uint Field2;

		public uint Field1;
	}

	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	private struct Struct2
	{
		public uint Field10;

		public Struct1 Field9;

		public Struct1 Field8;

		public Struct1 Field7;

		public uint Field6;

		public uint Field5;

		public uint Field4;

		public uint Field3;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string Field2;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
		public string Field1;
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode, Pack = 4)]
	private struct Struct3
	{
		public uint Field10;

		public Struct1 Field9;

		public Struct1 Field8;

		public Struct1 Field7;

		public uint Field6;

		public uint Field5;

		public uint Field4;

		public uint Field3;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string Field2;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 14)]
		public string Field1;
	}

	[ComImport]
	[ClassInterface(ClassInterfaceType.None)]
	[Guid("00021401-0000-0000-C000-000000000046")]
	private class Class3
	{
		[MethodImpl(MethodImplOptions.InternalCall)]
		public extern Class3();
	}

	private enum Enum2 : uint
	{
		Field2 = 1u,
		Field1
	}

	[Flags]
	public enum Enum3 : uint
	{
		Field9 = 2u,
		Field8 = 0x80u,
		Field7 = 0x40u,
		Field6 = 1u,
		Field5 = 0x101u,
		Field4 = 8u,
		Field3 = 0x10u,
		Field2 = 0x20u,
		Field1 = 4u
	}

	[Flags]
	private enum Enum4 : uint
	{
		Field14 = 0u,
		Field13 = 1u,
		Field12 = 1u,
		Field11 = 2u,
		Field10 = 3u,
		Field9 = 3u,
		Field8 = 4u,
		Field7 = 5u,
		Field6 = 6u,
		Field5 = 7u,
		Field4 = 8u,
		Field3 = 9u,
		Field2 = 0xAu,
		Field1 = 0xAu
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0000010C-0000-0000-C000-000000000046")]
	private interface Interface1
	{
		[PreserveSig]
		void Method1(out Guid A_1);
	}

	[ComImport]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("0000010B-0000-0000-C000-000000000046")]
	private interface Interface2
	{
		[PreserveSig]
		void Method6(out Guid A_1);

		void Method5();

		void Method4([MarshalAs(UnmanagedType.LPWStr)] string A_1, uint A_2);

		void Method3([MarshalAs(UnmanagedType.LPWStr)] string A_1, [MarshalAs(UnmanagedType.Bool)] bool A_2);

		void Method2([MarshalAs(UnmanagedType.LPWStr)] string A_1);

		void Method1([MarshalAs(UnmanagedType.LPWStr)] out string A_1);
	}

	[ComImport]
	[Guid("000214EE-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface Interface3
	{
		void Method18([Out][MarshalAs(UnmanagedType.LPStr)] StringBuilder A_1, int A_2, ref Struct2 A_3, uint A_4);

		void Method17(out IntPtr A_1);

		void Method16(IntPtr A_1);

		void Method15([Out][MarshalAs(UnmanagedType.LPStr)] StringBuilder A_1, int A_2);

		void Method14([MarshalAs(UnmanagedType.LPStr)] string A_1);

		void Method13([Out][MarshalAs(UnmanagedType.LPStr)] StringBuilder A_1, int A_2);

		void Method12([MarshalAs(UnmanagedType.LPStr)] string A_1);

		void Method11([Out][MarshalAs(UnmanagedType.LPStr)] StringBuilder A_1, int A_2);

		void Method10([MarshalAs(UnmanagedType.LPStr)] string A_1);

		void Method9(out short A_1);

		void Method8(short A_1);

		void Method7(out uint A_1);

		void Method6(uint A_1);

		void Method5([Out][MarshalAs(UnmanagedType.LPStr)] StringBuilder A_1, int A_2, out int A_3);

		void Method4([MarshalAs(UnmanagedType.LPStr)] string A_1, int A_2);

		void Method3([MarshalAs(UnmanagedType.LPStr)] string A_1, uint A_2);

		void Method2(IntPtr A_1, uint A_2);

		void Method1([MarshalAs(UnmanagedType.LPStr)] string A_1);
	}

	[ComImport]
	[Guid("000214F9-0000-0000-C000-000000000046")]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	private interface Interface4
	{
		void Method18([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder A_1, int A_2, ref Struct3 A_3, uint A_4);

		void Method17(out IntPtr A_1);

		void Method16(IntPtr A_1);

		void Method15([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder A_1, int A_2);

		void Method14([MarshalAs(UnmanagedType.LPWStr)] string A_1);

		void Method13([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder A_1, int A_2);

		void Method12([MarshalAs(UnmanagedType.LPWStr)] string A_1);

		void Method11([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder A_1, int A_2);

		void Method10([MarshalAs(UnmanagedType.LPWStr)] string A_1);

		void Method9(out short A_1);

		void Method8(short A_1);

		void Method7(out uint A_1);

		void Method6(uint A_1);

		void Method5([Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder A_1, int A_2, out int A_3);

		void Method4([MarshalAs(UnmanagedType.LPWStr)] string A_1, int A_2);

		void Method3([MarshalAs(UnmanagedType.LPWStr)] string A_1, uint A_2);

		void Method2(IntPtr A_1, uint A_2);

		void Method1([MarshalAs(UnmanagedType.LPWStr)] string A_1);
	}

	public enum Enum5 : uint
	{
		Field3 = 1u,
		Field2 = 7u,
		Field1 = 3u
	}

	private class Class4
	{
		[DllImport("Shell32", CharSet = CharSet.Auto)]
		internal static extern int ExtractIconEx([MarshalAs(UnmanagedType.LPTStr)] string A_0, int A_1, IntPtr[] A_2, IntPtr[] A_3, int A_4);

		[DllImport("user32")]
		internal static extern int DestroyIcon(IntPtr A_0);
	}

	private Interface4 Field3;

	private Interface3 Field2;

	private string Field1 = "";

	public string Property67
	{
		get
		{
			return Field1;
		}
		set
		{
			Field1 = value;
		}
	}

	public string Property66
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			int A_ = 0;
			if (Field2 == null)
			{
				Field3.Method5(stringBuilder, stringBuilder.Capacity, out A_);
			}
			else
			{
				Field2.Method5(stringBuilder, stringBuilder.Capacity, out A_);
			}
			return stringBuilder.ToString();
		}
		set
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			int A_ = 0;
			if (Field2 == null)
			{
				Field3.Method5(stringBuilder, stringBuilder.Capacity, out A_);
			}
			else
			{
				Field2.Method5(stringBuilder, stringBuilder.Capacity, out A_);
			}
			if (Field2 == null)
			{
				Field3.Method4(value, A_);
			}
			else
			{
				Field2.Method4(value, A_);
			}
		}
	}

	public int Property65
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			int A_ = 0;
			if (Field2 == null)
			{
				Field3.Method5(stringBuilder, stringBuilder.Capacity, out A_);
			}
			else
			{
				Field2.Method5(stringBuilder, stringBuilder.Capacity, out A_);
			}
			return A_;
		}
		set
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			int A_ = 0;
			if (Field2 == null)
			{
				Field3.Method5(stringBuilder, stringBuilder.Capacity, out A_);
			}
			else
			{
				Field2.Method5(stringBuilder, stringBuilder.Capacity, out A_);
			}
			if (Field2 == null)
			{
				Field3.Method4(stringBuilder.ToString(), value);
			}
			else
			{
				Field2.Method4(stringBuilder.ToString(), value);
			}
		}
	}

	public string Property64
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			if (Field2 == null)
			{
				Struct3 A_ = default(Struct3);
				Field3.Method18(stringBuilder, stringBuilder.Capacity, ref A_, 2u);
			}
			else
			{
				Struct2 A_2 = default(Struct2);
				Field2.Method18(stringBuilder, stringBuilder.Capacity, ref A_2, 2u);
			}
			return stringBuilder.ToString();
		}
		set
		{
			if (Field2 == null)
			{
				Field3.Method1(value);
			}
			else
			{
				Field2.Method1(value);
			}
		}
	}

	public string Property63
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			if (Field2 == null)
			{
				Field3.Method13(stringBuilder, stringBuilder.Capacity);
			}
			else
			{
				Field2.Method13(stringBuilder, stringBuilder.Capacity);
			}
			return stringBuilder.ToString();
		}
		set
		{
			if (Field2 == null)
			{
				Field3.Method12(value);
			}
			else
			{
				Field2.Method12(value);
			}
		}
	}

	public string Property62
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(1024, 1024);
			if (Field2 == null)
			{
				Field3.Method15(stringBuilder, stringBuilder.Capacity);
			}
			else
			{
				Field2.Method15(stringBuilder, stringBuilder.Capacity);
			}
			return stringBuilder.ToString();
		}
		set
		{
			if (Field2 == null)
			{
				Field3.Method14(value);
			}
			else
			{
				Field2.Method14(value);
			}
		}
	}

	public string Property61
	{
		get
		{
			StringBuilder stringBuilder = new StringBuilder(260, 260);
			if (Field2 == null)
			{
				Field3.Method11(stringBuilder, stringBuilder.Capacity);
			}
			else
			{
				Field2.Method11(stringBuilder, stringBuilder.Capacity);
			}
			return stringBuilder.ToString();
		}
		set
		{
			if (Field2 == null)
			{
				Field3.Method10(value);
			}
			else
			{
				Field2.Method10(value);
			}
		}
	}

	public Enum5 Property60
	{
		get
		{
			uint A_ = 0u;
			if (Field2 == null)
			{
				Field3.Method7(out A_);
			}
			else
			{
				Field2.Method7(out A_);
			}
			return (Enum5)A_;
		}
		set
		{
			if (Field2 == null)
			{
				Field3.Method6((uint)value);
			}
			else
			{
				Field2.Method6((uint)value);
			}
		}
	}

	public Class2()
	{
		if (Environment.OSVersion.Platform == PlatformID.Win32NT)
		{
			Field3 = (Interface4)new Class3();
		}
		else
		{
			Field2 = (Interface3)new Class3();
		}
	}

	public Class2(string linkFile)
		: this()
	{
		Method3(linkFile);
	}

	~Class2()
	{
		Dispose();
	}

	public void Dispose()
	{
		if (Field3 != null)
		{
			Marshal.ReleaseComObject(Field3);
			Field3 = null;
		}
		if (Field2 != null)
		{
			Marshal.ReleaseComObject(Field2);
			Field2 = null;
		}
	}

	public void Method5()
	{
		Method4(Field1);
	}

	public void Method4(string A_1)
	{
		if (Field2 == null)
		{
			((Interface2)Field3).Method3(A_1, A_2: true);
			Field1 = A_1;
		}
		else
		{
			((Interface2)Field2).Method3(A_1, A_2: true);
			Field1 = A_1;
		}
	}

	public void Method3(string A_1)
	{
		Method1(A_1, IntPtr.Zero, Enum3.Field9 | Enum3.Field6, 1);
	}

	public void Method2(string A_1, IntPtr A_2, Enum3 A_3)
	{
		Method1(A_1, A_2, A_3, 1);
	}

	public void Method1(string A_1, IntPtr A_2, Enum3 A_3, ushort A_4)
	{
		uint a_ = (((A_3 & Enum3.Field6) != Enum3.Field6) ? ((uint)A_3) : ((uint)A_3 | (uint)(A_4 << 16)));
		if (Field2 == null)
		{
			((Interface2)Field3).Method4(A_1, 0u);
			Field3.Method2(A_2, a_);
			Field1 = A_1;
		}
		else
		{
			((Interface2)Field2).Method4(A_1, 0u);
			Field2.Method2(A_2, a_);
			Field1 = A_1;
		}
	}
}
