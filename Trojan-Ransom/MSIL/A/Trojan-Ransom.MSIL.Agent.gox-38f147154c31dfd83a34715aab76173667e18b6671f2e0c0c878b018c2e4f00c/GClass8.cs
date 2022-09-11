using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

public static class GClass8
{
	[CompilerGenerated]
	private sealed class Class22
	{
		public string string_0;

		internal void method_0()
		{
			TextBox textBox_ = TextBox_0;
			((Control)textBox_).set_Text(((Control)textBox_).get_Text() + string_0);
		}
	}

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private static TextBox textBox_0;

	private static TextBox TextBox_0
	{
		[CompilerGenerated]
		get
		{
			return textBox_0;
		}
		[CompilerGenerated]
		set
		{
			textBox_0 = value;
		}
	}

	public static void smethod_0(this Form form_0, TextBox textBox_1)
	{
		if (textBox_1 == null)
		{
			throw new NullReferenceException("SetLogViewer cannot accept null, where the log will be displayed then!, please provide a TextBox Control object.");
		}
		TextBox_0 = textBox_1;
	}

	public static void smethod_1(string string_0)
	{
		smethod_7(smethod_8(string.Empty, string_0, null));
	}

	public static void smethod_2(string string_0, string string_1)
	{
		smethod_7(smethod_8(string_0, string_1, null));
	}

	public static void smethod_3(string string_0, string string_1, Exception exception_0)
	{
		smethod_7(smethod_8(string_0, string_1, exception_0));
	}

	public static void smethod_4(this Form form_0, string string_0)
	{
		smethod_7(smethod_8(string.Empty, string_0, null));
	}

	public static void smethod_5(this Form form_0, string string_0, string string_1)
	{
		smethod_7(smethod_8(string_0, string_1, null));
	}

	public static void smethod_6(this Form form_0, string string_0, string string_1, Exception exception_0)
	{
		smethod_7(smethod_8(string_0, string_1, exception_0));
	}

	private static void smethod_7(string string_0)
	{
		if (TextBox_0 == null)
		{
			throw new NullReferenceException("Please call the SetLogViewer method first with a valid TextBox Control.");
		}
		if (((Control)TextBox_0).get_InvokeRequired())
		{
			((Control)TextBox_0).Invoke((Delegate)(Action)delegate
			{
				TextBox obj2 = TextBox_0;
				((Control)obj2).set_Text(((Control)obj2).get_Text() + string_0);
			});
		}
		else
		{
			TextBox obj = TextBox_0;
			((Control)obj).set_Text(((Control)obj).get_Text() + string_0);
			((TextBoxBase)TextBox_0).set_SelectionStart(((Control)TextBox_0).get_Text().Length);
			((TextBoxBase)TextBox_0).ScrollToCaret();
		}
	}

	private static string smethod_8(string string_0, string string_1, Exception exception_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			string_0 = " | " + string_0 + " |";
		}
		return $"\r\n{DateTime.Now} :{string_0.ToUpper()} {string_1} {exception_0}";
	}
}
