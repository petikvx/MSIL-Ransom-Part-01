using System.Data.Common;
using System.Globalization;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;

namespace System.Data.SQLite;

public sealed class SQLiteFactory : DbProviderFactory, IDisposable, IServiceProvider
{
	private bool disposed;

	public static readonly SQLiteFactory Instance;

	private static readonly string DefaultTypeName;

	private static readonly BindingFlags DefaultBindingFlags;

	private static Type _dbProviderServicesType;

	private static object _sqliteServices;

	[NonSerialized]
	internal static GetString _009A;

	public event SQLiteLogEventHandler Log
	{
		add
		{
			CheckDisposed();
			SQLiteLog.Log += value;
		}
		remove
		{
			CheckDisposed();
			SQLiteLog.Log -= value;
		}
	}

	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	private void CheckDisposed()
	{
		if (disposed)
		{
			throw new ObjectDisposedException(typeof(SQLiteFactory).Name);
		}
	}

	private void Dispose(bool disposing)
	{
		if (!disposed)
		{
			disposed = true;
		}
	}

	~SQLiteFactory()
	{
		Dispose(disposing: false);
	}

	public override DbCommand CreateCommand()
	{
		CheckDisposed();
		return new SQLiteCommand();
	}

	public override DbCommandBuilder CreateCommandBuilder()
	{
		CheckDisposed();
		return new SQLiteCommandBuilder();
	}

	public override DbConnection CreateConnection()
	{
		CheckDisposed();
		return new SQLiteConnection();
	}

	public override DbConnectionStringBuilder CreateConnectionStringBuilder()
	{
		CheckDisposed();
		return new SQLiteConnectionStringBuilder();
	}

	public override DbDataAdapter CreateDataAdapter()
	{
		CheckDisposed();
		return new SQLiteDataAdapter();
	}

	public override DbParameter CreateParameter()
	{
		CheckDisposed();
		return new SQLiteParameter();
	}

	static SQLiteFactory()
	{
		Strings.CreateGetStringDelegate(typeof(SQLiteFactory));
		bool flag = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Uri uri = new Uri(executingAssembly.CodeBase!.Replace(_009A(107401116), _009A(107401079)).Replace(_009A(107401074), _009A(107401069)));
		if (!StrongNameSignatureVerificationEx(uri.LocalPath, true, out flag) || !flag || !executingAssembly.FullName!.EndsWith(_009A(107401096)))
		{
			throw new SecurityException(_009A(107401039));
		}
		Instance = new SQLiteFactory();
		DefaultTypeName = _009A(107383130);
		DefaultBindingFlags = BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic;
		UnsafeNativeMethods.Initialize();
		SQLiteLog.Initialize();
		string text = _009A(107383492);
		_dbProviderServicesType = Type.GetType(HelperMethods.StringFormat(CultureInfo.InvariantCulture, _009A(107383447), text), throwOnError: false);
	}

	object IServiceProvider.GetService(Type serviceType)
	{
		if ((object)serviceType == typeof(ISQLiteSchemaExtensions) || ((object)_dbProviderServicesType != null && (object)serviceType == _dbProviderServicesType))
		{
			return GetSQLiteProviderServicesInstance();
		}
		return null;
	}

	[ReflectionPermission(SecurityAction.Assert, MemberAccess = true)]
	private object GetSQLiteProviderServicesInstance()
	{
		if (_sqliteServices == null)
		{
			string settingValue = UnsafeNativeMethods.GetSettingValue(_009A(107382773), null);
			Version version = GetType().Assembly.GetName().Version;
			settingValue = ((settingValue == null) ? HelperMethods.StringFormat(CultureInfo.InvariantCulture, DefaultTypeName, version) : HelperMethods.StringFormat(CultureInfo.InvariantCulture, settingValue, version));
			Type type = Type.GetType(settingValue, throwOnError: false);
			if ((object)type != null)
			{
				FieldInfo field = type.GetField(_009A(107382760), DefaultBindingFlags);
				if ((object)field != null)
				{
					_sqliteServices = field.GetValue(null);
				}
			}
		}
		return _sqliteServices;
	}

	[DllImport("mscorwks.dll", CharSet = CharSet.Unicode)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool StrongNameSignatureVerificationEx([MarshalAs(UnmanagedType.LPWStr)] string P_0, [MarshalAs(UnmanagedType.Bool)] bool P_1, [MarshalAs(UnmanagedType.Bool)] out bool P_2);
}
