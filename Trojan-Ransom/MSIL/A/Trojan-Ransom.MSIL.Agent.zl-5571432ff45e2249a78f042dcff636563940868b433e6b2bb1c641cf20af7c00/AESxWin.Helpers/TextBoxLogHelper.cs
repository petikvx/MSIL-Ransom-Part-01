using System;
using System.Windows.Forms;

namespace AESxWin.Helpers;

public static class TextBoxLogHelper
{
	private static TextBox LogViewer { get; set; }

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
		if (LogViewer == null)
		{
			throw new NullReferenceException("Please call the SetLogViewer method first with a valid TextBox Control.");
		}
		if (((Control)LogViewer).get_InvokeRequired())
		{
			((Control)LogViewer).Invoke((Delegate)(Action)delegate
			{
				TextBox logViewer2 = LogViewer;
				((Control)logViewer2).set_Text(((Control)logViewer2).get_Text() + message);
			});
		}
		else
		{
			TextBox logViewer = LogViewer;
			((Control)logViewer).set_Text(((Control)logViewer).get_Text() + message);
			((TextBoxBase)LogViewer).set_SelectionStart(((Control)LogViewer).get_Text().Length);
			((TextBoxBase)LogViewer).ScrollToCaret();
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
