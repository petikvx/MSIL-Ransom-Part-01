using System.Data.Common;
using System.Reflection;
using System.Security.Permissions;

namespace System.Data.SQLite;

public sealed class SQLiteFactory : DbProviderFactory, IServiceProvider
{
	public static readonly SQLiteFactory Instance;

	private static Type _dbProviderServicesType;

	private static object _sqliteServices;

	public override DbCommand CreateCommand()
	{
		return new SQLiteCommand();
	}

	public override DbCommandBuilder CreateCommandBuilder()
	{
		return new SQLiteCommandBuilder();
	}

	public override DbConnection CreateConnection()
	{
		return new SQLiteConnection();
	}

	public override DbConnectionStringBuilder CreateConnectionStringBuilder()
	{
		return new SQLiteConnectionStringBuilder();
	}

	public override DbDataAdapter CreateDataAdapter()
	{
		return new SQLiteDataAdapter();
	}

	public override DbParameter CreateParameter()
	{
		return new SQLiteParameter();
	}

	static SQLiteFactory()
	{
		Instance = new SQLiteFactory();
		_dbProviderServicesType = Type.GetType("System.Data.Common.DbProviderServices, System.Data.Entity, Version=3.5.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", throwOnError: false);
	}

	object IServiceProvider.GetService(Type serviceType)
	{
		if ((object)serviceType != typeof(ISQLiteSchemaExtensions) && ((object)_dbProviderServicesType == null || (object)serviceType != _dbProviderServicesType))
		{
			return null;
		}
		return GetSQLiteProviderServicesInstance();
	}

	[ReflectionPermission(SecurityAction.Assert, MemberAccess = true)]
	private object GetSQLiteProviderServicesInstance()
	{
		if (_sqliteServices == null)
		{
			Type type = Type.GetType("System.Data.SQLite.SQLiteProviderServices, System.Data.SQLite.Linq, Version=2.0.38.0, Culture=neutral, PublicKeyToken=db937bc2d44ff139", throwOnError: false);
			if ((object)type != null)
			{
				FieldInfo field = type.GetField("Instance", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);
				_sqliteServices = field.GetValue(null);
			}
		}
		return _sqliteServices;
	}
}
