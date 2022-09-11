#define TRACE
using System.Diagnostics;
using System.Globalization;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public static class SQLiteLog
{
	private static object syncRoot;

	private static EventHandler _domainUnload;

	private static SQLiteLogEventHandler _defaultHandler;

	private static SQLiteLogCallback _callback;

	private static SQLiteBase _sql;

	private static bool _enabled;

	[NonSerialized]
	internal static GetString _008A;

	public static bool Enabled
	{
		get
		{
			lock (syncRoot)
			{
				return _enabled;
			}
		}
		set
		{
			lock (syncRoot)
			{
				_enabled = value;
			}
		}
	}

	private static event SQLiteLogEventHandler _handlers;

	public static event SQLiteLogEventHandler Log
	{
		add
		{
			lock (syncRoot)
			{
				SQLiteLog._handlers = (SQLiteLogEventHandler)Delegate.Remove(SQLiteLog._handlers, value);
				SQLiteLog._handlers = (SQLiteLogEventHandler)Delegate.Combine(SQLiteLog._handlers, value);
			}
		}
		remove
		{
			lock (syncRoot)
			{
				SQLiteLog._handlers = (SQLiteLogEventHandler)Delegate.Remove(SQLiteLog._handlers, value);
			}
		}
	}

	public static void Initialize()
	{
		if (SQLite3.StaticIsInitialized() || (!AppDomain.CurrentDomain.IsDefaultAppDomain() && UnsafeNativeMethods.GetSettingValue(_008A(107382281), null) == null))
		{
			return;
		}
		lock (syncRoot)
		{
			if (_domainUnload == null)
			{
				_domainUnload = DomainUnload;
				AppDomain.CurrentDomain.DomainUnload += _domainUnload;
			}
			if (_sql == null)
			{
				_sql = new SQLite3(SQLiteDateFormats.ISO8601, DateTimeKind.Unspecified, null, IntPtr.Zero, null, ownHandle: false);
			}
			if (_callback == null)
			{
				_callback = LogCallback;
				SQLiteErrorCode sQLiteErrorCode = _sql.SetLogCallback(_callback);
				if (sQLiteErrorCode != 0)
				{
					throw new SQLiteException(sQLiteErrorCode, _008A(107382260));
				}
			}
			_enabled = true;
			AddDefaultHandler();
		}
	}

	private static void DomainUnload(object sender, EventArgs e)
	{
		lock (syncRoot)
		{
			RemoveDefaultHandler();
			_enabled = false;
			if (_sql != null)
			{
				SQLiteErrorCode sQLiteErrorCode = _sql.Shutdown();
				if (sQLiteErrorCode != 0)
				{
					throw new SQLiteException(sQLiteErrorCode, _008A(107382219));
				}
				sQLiteErrorCode = _sql.SetLogCallback(null);
				if (sQLiteErrorCode != 0)
				{
					throw new SQLiteException(sQLiteErrorCode, _008A(107382146));
				}
			}
			if (_callback != null)
			{
				_callback = null;
			}
			if (_domainUnload != null)
			{
				AppDomain.CurrentDomain.DomainUnload -= _domainUnload;
				_domainUnload = null;
			}
		}
	}

	public static void LogMessage(string message)
	{
		LogMessage(null, message);
	}

	public static void LogMessage(SQLiteErrorCode errorCode, string message)
	{
		LogMessage((object)errorCode, message);
	}

	public static void LogMessage(int errorCode, string message)
	{
		LogMessage((object)errorCode, message);
	}

	private static void LogMessage(object errorCode, string message)
	{
		bool enabled;
		SQLiteLogEventHandler sQLiteLogEventHandler;
		lock (syncRoot)
		{
			enabled = _enabled;
			sQLiteLogEventHandler = ((SQLiteLog._handlers == null) ? null : (SQLiteLog._handlers.Clone() as SQLiteLogEventHandler));
		}
		if (enabled)
		{
			sQLiteLogEventHandler?.Invoke(null, new LogEventArgs(IntPtr.Zero, errorCode, message, null));
		}
	}

	private static void InitializeDefaultHandler()
	{
		lock (syncRoot)
		{
			if (_defaultHandler == null)
			{
				_defaultHandler = LogEventHandler;
			}
		}
	}

	public static void AddDefaultHandler()
	{
		InitializeDefaultHandler();
		Log += _defaultHandler;
	}

	public static void RemoveDefaultHandler()
	{
		InitializeDefaultHandler();
		Log -= _defaultHandler;
	}

	private static void LogCallback(IntPtr pUserData, int errorCode, IntPtr pMessage)
	{
		bool enabled;
		SQLiteLogEventHandler sQLiteLogEventHandler;
		lock (syncRoot)
		{
			enabled = _enabled;
			sQLiteLogEventHandler = ((SQLiteLog._handlers == null) ? null : (SQLiteLog._handlers.Clone() as SQLiteLogEventHandler));
		}
		if (enabled)
		{
			sQLiteLogEventHandler?.Invoke(null, new LogEventArgs(pUserData, errorCode, SQLiteConvert.UTF8ToString(pMessage, -1), null));
		}
	}

	private static void LogEventHandler(object sender, LogEventArgs e)
	{
		if (e == null)
		{
			return;
		}
		string message = e.Message;
		if (message == null)
		{
			message = _008A(107364281);
		}
		else
		{
			message = message.Trim();
			if (message.Length == 0)
			{
				message = _008A(107382621);
			}
		}
		object errorCode = e.ErrorCode;
		string text = _008A(107382640);
		if (errorCode is SQLiteErrorCode || errorCode is int)
		{
			SQLiteErrorCode sQLiteErrorCode = (SQLiteErrorCode)(int)errorCode;
			switch (sQLiteErrorCode & SQLiteErrorCode.NonExtendedMask)
			{
			case SQLiteErrorCode.Ok:
				text = _008A(107382599);
				break;
			case SQLiteErrorCode.Notice:
				text = _008A(107382586);
				break;
			case SQLiteErrorCode.Warning:
				text = _008A(107382609);
				break;
			case SQLiteErrorCode.Row:
			case SQLiteErrorCode.Done:
				text = _008A(107391303);
				break;
			}
		}
		else if (errorCode == null)
		{
			text = _008A(107382564);
		}
		if (errorCode != null && !object.ReferenceEquals(errorCode, string.Empty))
		{
			Trace.WriteLine(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _008A(107382555), text, errorCode, message));
		}
		else
		{
			Trace.WriteLine(HelperMethods.StringFormat(CultureInfo.CurrentCulture, _008A(107382526), text, message));
		}
	}

	static SQLiteLog()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteLog));
		syncRoot = new object();
	}
}
