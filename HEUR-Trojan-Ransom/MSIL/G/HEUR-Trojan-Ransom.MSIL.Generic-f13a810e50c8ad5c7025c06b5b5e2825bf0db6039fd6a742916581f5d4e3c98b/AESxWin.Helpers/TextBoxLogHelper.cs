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

	public static void SetLogViewer(this Form form, TextBox textbox)
	{
		if (textbox == null)
		{
			throw new NullReferenceException("SetLogViewer cannot accept null, where the log will be displayed then!, please provide a TextBox Control object.");
		}
		LogViewer = textbox;
	}

	public static void Log(string message)
	{
		AppendMessage(FormatMessage(string.Empty, message, null));
	}

	public static void Log(string level, string message)
	{
		AppendMessage(FormatMessage(level, message, null));
	}

	public static void Log(string level, string message, Exception exception)
	{
		AppendMessage(FormatMessage(level, message, exception));
	}

	public static void Log(this Form form, string message)
	{
		AppendMessage(FormatMessage(string.Empty, message, null));
	}

	public static void Log(this Form form, string level, string message)
	{
		AppendMessage(FormatMessage(level, message, null));
	}

	public static void Log(this Form form, string level, string message, Exception exception)
	{
		AppendMessage(FormatMessage(level, message, exception));
	}

	private static void AppendMessage(string message)
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
				((Control)logViewer).set_Text(((Control)logViewer).get_Text() + message);
			});
		}
		else
		{
			TextBox obj = textBox_0;
			((Control)obj).set_Text(((Control)obj).get_Text() + message);
			((TextBoxBase)textBox_0).set_SelectionStart(((Control)textBox_0).get_Text().Length);
			((TextBoxBase)textBox_0).ScrollToCaret();
		}
	}

	private static string FormatMessage(string level, string message, Exception exception)
	{
		if (!string.IsNullOrEmpty(level))
		{
			level = " | " + level + " |";
		}
		return $"\r\n{DateTime.Now} :{level.ToUpper()} {message} {exception}";
	}
}
