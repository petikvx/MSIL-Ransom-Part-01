using System;
using System.ComponentModel;
using System.Drawing;
using System.IO.Compression;
using System.Runtime.InteropServices;
using System.Security;
using System.Windows.Forms;
using ns0;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public class AutoHeightLabel : Label
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 273156)]
	private struct Struct11
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1;

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private void method_0()
	{
		try
		{
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				int num = Win32.smethod_6(val, ((Control)this).get_Text(), PoweredBy.smethod_3((Control)(object)this, 7, 22), ((Control)this).get_Width());
				if (num > 0)
				{
					((Control)this).set_Height(num);
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
	}

	protected override void OnFontChanged(EventArgs e)
	{
		((Label)this).OnFontChanged(e);
		method_0();
	}

	protected override void OnResize(EventArgs e)
	{
		((Control)this).OnResize(e);
		method_0();
	}

	protected override void OnTextChanged(EventArgs e)
	{
		((Label)this).OnTextChanged(e);
		method_0();
	}

	public AutoHeightLabel()
	{
		((Label)this).set_FlatStyle((FlatStyle)3);
		((Label)this).set_UseMnemonic(false);
	}

	[SecuritySafeCritical]
	static AutoHeightLabel()
	{
		Class32.smethod_1();
		char_1 = new char[136578];
		char[] array = new char[8];
		array[2] = '᳆';
		array[5] = 'ຍ';
		array[3] = '㨻';
		array[4] = 'ㆫ';
		array[7] = '₃';
		array[6] = '┄';
		array[1] = '㤘';
		array[0] = '㏾';
		string_0 = new string[60];
		char_0 = array;
	}

	[SecuritySafeCritical]
	internal static int smethod_0(GZipStream gzipStream_0, byte[] byte_1, int int_0, int int_1, int int_2, int int_3)
	{
		while (true)
		{
			switch (int_3 ^ int_2)
			{
			case 109:
				return gzipStream_0.Read(byte_1, int_0, int_1);
			}
		}
	}

	[SecuritySafeCritical]
	internal static string smethod_1(ref int int_0, string string_1, int int_1, int int_2)
	{
		while (true)
		{
			switch (int_2 ^ int_1)
			{
			case 17:
				return int_0.ToString(string_1);
			}
		}
	}
}
