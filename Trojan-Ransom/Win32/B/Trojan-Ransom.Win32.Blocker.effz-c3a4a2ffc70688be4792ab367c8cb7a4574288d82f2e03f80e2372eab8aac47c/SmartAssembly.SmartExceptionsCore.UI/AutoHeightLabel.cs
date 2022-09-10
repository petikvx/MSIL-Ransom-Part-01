using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SmartAssembly.SmartExceptionsCore.UI;

[DesignerCategory("Code")]
public class AutoHeightLabel : Label
{
	[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 16)]
	private struct Struct32
	{
	}

	private static readonly char[] char_0;

	private static readonly char[] char_1 = new char[8];

	private static readonly string[] string_0;

	internal static byte byte_0/* Not supported: data(00) */;

	private void method_0()
	{
		try
		{
			Graphics val = ((Control)this).CreateGraphics();
			try
			{
				int num = Win32.smethod_6(val, ((Control)this).get_Text(), ((Control)this).get_Font(), ((Control)this).get_Width());
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

	static AutoHeightLabel()
	{
		char[] array = new char[8];
		array[5] = '\u135b';
		array[3] = 'ߗ';
		array[0] = 'Ḽ';
		array[2] = '\u2e7b';
		array[7] = '⍓';
		array[6] = 'Ꮇ';
		array[4] = '〩';
		array[1] = 'Ἃ';
		string_0 = new string[1];
		char_0 = array;
	}
}
