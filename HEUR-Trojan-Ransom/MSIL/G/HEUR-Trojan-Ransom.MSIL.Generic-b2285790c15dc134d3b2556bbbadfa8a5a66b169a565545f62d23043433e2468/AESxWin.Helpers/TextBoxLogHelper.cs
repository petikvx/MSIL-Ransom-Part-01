using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace AESxWin.Helpers;

public static class TextBoxLogHelper
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private static TextBox textBox_0;

	private static TextBox LogViewer
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

	public static void SetLogViewer(this Form form_0, TextBox textBox_1)
	{
		if (textBox_1 == null)
		{
			throw new NullReferenceException("SetLogViewer cannot accept null, where the log will be displayed then!, please provide a TextBox Control object.");
		}
		LogViewer = textBox_1;
	}

	public static void Log(string string_0)
	{
		AppendMessage(FormatMessage(string.Empty, string_0, null));
	}

	public static void Log(string string_0, string string_1)
	{
		AppendMessage(FormatMessage(string_0, string_1, null));
	}

	public static void Log(string string_0, string string_1, Exception exception_0)
	{
		AppendMessage(FormatMessage(string_0, string_1, exception_0));
	}

	public static void Log(this Form form_0, string string_0)
	{
		AppendMessage(FormatMessage(string.Empty, string_0, null));
	}

	public static void Log(this Form form_0, string string_0, string string_1)
	{
		AppendMessage(FormatMessage(string_0, string_1, null));
	}

	public static void Log(this Form form_0, string string_0, string string_1, Exception exception_0)
	{
		AppendMessage(FormatMessage(string_0, string_1, exception_0));
	}

	private static void AppendMessage(string string_0)
	{
		if (textBox_0 == null)
		{
			throw new NullReferenceException("Please call the SetLogViewer method first with a valid TextBox Control.");
		}
		if (((Control)textBox_0).get_InvokeRequired())
		{
			((Control)textBox_0).Invoke((Delegate)(Action)delegate
			{
				TextBox logViewer = LogViewer;
				((Control)logViewer).set_Text(((Control)logViewer).get_Text() + string_0);
			});
		}
		else
		{
			TextBox obj = textBox_0;
			((Control)obj).set_Text(((Control)obj).get_Text() + string_0);
			((TextBoxBase)textBox_0).set_SelectionStart(((Control)textBox_0).get_Text().Length);
			((TextBoxBase)textBox_0).ScrollToCaret();
		}
	}

	private static string FormatMessage(string string_0, string string_1, Exception exception_0)
	{
		if (!string.IsNullOrEmpty(string_0))
		{
			string_0 = " | " + string_0 + " |";
		}
		return $"\r\n{DateTime.Now} :{string_0.ToUpper()} {string_1} {exception_0}";
	}
}
