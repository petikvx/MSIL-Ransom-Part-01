using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Threading;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class SQLiteTransaction2 : SQLiteTransaction
{
	private int _beginLevel;

	private string _savePointName;

	private bool disposed;

	[NonSerialized]
	internal new static GetString _008D;

	internal SQLiteTransaction2(SQLiteConnection connection, bool deferredLock)
		: base(connection, deferredLock)
	{
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteTransaction2).Name);
		}
	}

	protected override void Dispose(bool disposing)
	{
		try
		{
			if (!disposed && disposing && IsValid(throwError: false))
			{
				IssueRollback(throwError: false);
			}
		}
		finally
		{
			base.Dispose(disposing);
			disposed = true;
		}
	}

	public override void Commit()
	{
		CheckDisposed();
		IsValid(throwError: true);
		if (_beginLevel == 0)
		{
			using (SQLiteCommand sQLiteCommand = _cnn.CreateCommand())
			{
				sQLiteCommand.CommandText = _008D(107382113);
				sQLiteCommand.ExecuteNonQuery();
			}
			_cnn._transactionLevel = 0;
			_cnn = null;
			return;
		}
		using (SQLiteCommand sQLiteCommand2 = _cnn.CreateCommand())
		{
			if (string.IsNullOrEmpty(_savePointName))
			{
				throw new SQLiteException(_008D(107382053));
			}
			sQLiteCommand2.CommandText = string.Format(_008D(107382008), _savePointName);
			sQLiteCommand2.ExecuteNonQuery();
		}
		_cnn._transactionLevel--;
		_cnn = null;
	}

	protected override void Begin(bool deferredLock)
	{
		int beginLevel;
		if ((beginLevel = _cnn._transactionLevel++) == 0)
		{
			try
			{
				using SQLiteCommand sQLiteCommand = _cnn.CreateCommand();
				if (!deferredLock)
				{
					sQLiteCommand.CommandText = _008D(107382068);
				}
				else
				{
					sQLiteCommand.CommandText = _008D(107382075);
				}
				sQLiteCommand.ExecuteNonQuery();
				_beginLevel = beginLevel;
				return;
			}
			catch (SQLiteException)
			{
				_cnn._transactionLevel--;
				_cnn = null;
				throw;
			}
		}
		try
		{
			using SQLiteCommand sQLiteCommand2 = _cnn.CreateCommand();
			_savePointName = GetSavePointName();
			sQLiteCommand2.CommandText = string.Format(_008D(107381991), _savePointName);
			sQLiteCommand2.ExecuteNonQuery();
			_beginLevel = beginLevel;
		}
		catch (SQLiteException)
		{
			_cnn._transactionLevel--;
			_cnn = null;
			throw;
		}
	}

	protected override void IssueRollback(bool throwError)
	{
		SQLiteConnection sQLiteConnection = Interlocked.Exchange(ref _cnn, null);
		if (sQLiteConnection == null)
		{
			return;
		}
		if (_beginLevel == 0)
		{
			try
			{
				using (SQLiteCommand sQLiteCommand = sQLiteConnection.CreateCommand())
				{
					sQLiteCommand.CommandText = _008D(107382034);
					sQLiteCommand.ExecuteNonQuery();
				}
				sQLiteConnection._transactionLevel = 0;
				return;
			}
			catch
			{
				if (throwError)
				{
					throw;
				}
				return;
			}
		}
		try
		{
			using (SQLiteCommand sQLiteCommand2 = sQLiteConnection.CreateCommand())
			{
				if (string.IsNullOrEmpty(_savePointName))
				{
					throw new SQLiteException(_008D(107381938));
				}
				sQLiteCommand2.CommandText = string.Format(_008D(107381409), _savePointName);
				sQLiteCommand2.ExecuteNonQuery();
			}
			sQLiteConnection._transactionLevel--;
		}
		catch
		{
			if (throwError)
			{
				throw;
			}
		}
	}

	private string GetSavePointName()
	{
		int num = ++_cnn._transactionSequence;
		return string.Format(_008D(107381352), num);
	}

	static SQLiteTransaction2()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteTransaction2));
		bool flag = false;
		Assembly assembly = global::_0005._001B();
		Uri uri = new Uri(_0007._007E_0087(_0007._007E_0087(_0006._007E_001C(assembly), _008D(107401241), _008D(107401204)), _008D(107401199), _008D(107401194)));
		if (StrongNameSignatureVerificationEx(_0006._007E_001D(uri), true, out flag) && flag && global::_0008._007E_0088(_0006._007E_001E(assembly), _008D(107401221)))
		{
			return;
		}
		throw new SecurityException(_008D(107401164));
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
