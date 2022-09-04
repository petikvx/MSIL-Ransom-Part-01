using System;
using System.Drawing;
using System.Runtime.InteropServices;

public class GClass8
{
	private struct Struct4
	{
		public IntPtr intptr_0;

		public int int_0;

		public int int_1;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
		public string string_0;

		[MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
		public string string_1;
	}

	[Flags]
	public enum GEnum2
	{
		SHGFI_ICON = 0x100,
		SHGFI_DISPLAYNAME = 0x200,
		SHGFI_TYPENAME = 0x400,
		SHGFI_ATTRIBUTES = 0x800,
		SHGFI_ICONLOCATION = 0x1000,
		SHGFI_EXETYPE = 0x2000,
		SHGFI_SYSICONINDEX = 0x4000,
		SHGFI_LINKOVERLAY = 0x8000,
		SHGFI_SELECTED = 0x10000,
		SHGFI_ATTR_SPECIFIED = 0x20000,
		SHGFI_LARGEICON = 0,
		SHGFI_SMALLICON = 1,
		SHGFI_OPENICON = 2,
		SHGFI_SHELLICONSIZE = 4,
		SHGFI_USEFILEATTRIBUTES = 0x10,
		SHGFI_ADDOVERLAYS = 0x20,
		SHGFI_OVERLAYINDEX = 0x40
	}

	private const int int_0 = 260;

	private const int int_1 = 256;

	private const int int_2 = 8192;

	private const int int_3 = 2048;

	private const int int_4 = 1024;

	private const int int_5 = 4096;

	private const int int_6 = 512;

	private const int int_7 = 255;

	private string string_0;

	private string string_1;

	private string string_2;

	private GEnum2 genum2_0;

	private Icon icon_0;

	public GEnum2 GEnum2_0
	{
		get
		{
			return genum2_0;
		}
		set
		{
			genum2_0 = value;
		}
	}

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

	public Icon Icon_0 => icon_0;

	public string String_1 => string_1;

	public string String_2 => string_2;

	[DllImport("shell32")]
	private static extern int SHGetFileInfo(string string_3, int int_8, ref Struct4 struct4_0, uint uint_0, uint uint_1);

	[DllImport("user32.dll")]
	private static extern int DestroyIcon(IntPtr intptr_0);

	[DllImport("kernel32")]
	private static extern int FormatMessage(int int_8, IntPtr intptr_0, int int_9, int int_10, string string_3, uint uint_0, int int_11);

	[DllImport("kernel32")]
	private static extern int GetLastError();

	public void method_0()
	{
		icon_0 = null;
		string_2 = "";
		string_1 = "";
		Struct4 struct4_ = default(Struct4);
		uint uint_ = (uint)Marshal.SizeOf(struct4_.GetType());
		if (SHGetFileInfo(string_0, 0, ref struct4_, uint_, (uint)genum2_0) != 0)
		{
			if (struct4_.intptr_0 != IntPtr.Zero)
			{
				icon_0 = Icon.FromHandle(struct4_.intptr_0);
			}
			string_2 = struct4_.string_1;
			string_1 = struct4_.string_0;
		}
		else
		{
			int lastError = GetLastError();
			Console.WriteLine("Error {0}", lastError);
			string text = new string('\0', 256);
			int num = FormatMessage(4608, IntPtr.Zero, lastError, 0, text, 256u, 0);
			Console.WriteLine("Len {0} text {1}", num, text);
		}
	}

	public GClass8()
	{
		genum2_0 = GEnum2.SHGFI_ICON | GEnum2.SHGFI_DISPLAYNAME | GEnum2.SHGFI_TYPENAME | GEnum2.SHGFI_ATTRIBUTES | GEnum2.SHGFI_EXETYPE;
	}

	public GClass8(string fileName)
		: this()
	{
		string_0 = fileName;
		method_0();
	}

	public GClass8(string fileName, GEnum2 flags)
	{
		string_0 = fileName;
		genum2_0 = flags;
		method_0();
	}
}
