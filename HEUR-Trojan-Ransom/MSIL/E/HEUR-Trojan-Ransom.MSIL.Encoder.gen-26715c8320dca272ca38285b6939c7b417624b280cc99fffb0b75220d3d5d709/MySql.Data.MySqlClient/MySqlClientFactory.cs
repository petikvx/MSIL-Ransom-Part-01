using System;
using System.Data.Common;
using System.Reflection;
using System.Security.Permissions;

namespace MySql.Data.MySqlClient;

[ReflectionPermission(SecurityAction.Assert, MemberAccess = true)]
public sealed class MySqlClientFactory : DbProviderFactory, IServiceProvider
{
	public static MySqlClientFactory Instance = new MySqlClientFactory();

	private Type _dbServicesType;

	private FieldInfo _mySqlDbProviderServicesInstance;

	private Type DbServicesType => _dbServicesType ?? (_dbServicesType = Type.GetType("System.Data.Common.DbProviderServices, System.Data.Entity, \n\t\t\t\t\t\t\t\t\t\t\t\tVersion=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089", throwOnError: false));

	private FieldInfo MySqlDbProviderServicesInstance
	{
		get
		{
			if (_mySqlDbProviderServicesInstance == null)
			{
				string fullName = Assembly.GetExecutingAssembly().FullName;
				string text = fullName.Replace("MySql.Data", "MySql.Data.EntityFramework");
				string text2 = fullName.Replace("MySql.Data", "MySql.Data.Entity.EF5");
				fullName = "MySql.Data.MySqlClient.MySqlProviderServices, " + text2;
				Type type = Type.GetType(fullName, throwOnError: false);
				if (type == null)
				{
					fullName = "MySql.Data.MySqlClient.MySqlProviderServices, " + text;
					type = Type.GetType(fullName, throwOnError: false);
					if (type == null)
					{
						throw new DllNotFoundException(fullName);
					}
				}
				_mySqlDbProviderServicesInstance = type.GetField("Instance", BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic);
			}
			return _mySqlDbProviderServicesInstance;
		}
	}

	public override DbCommand CreateCommand()
	{
		return new MySqlCommand();
	}

	public override DbConnection CreateConnection()
	{
		return new MySqlConnection();
	}

	public override DbParameter CreateParameter()
	{
		return new MySqlParameter();
	}

	public override DbConnectionStringBuilder CreateConnectionStringBuilder()
	{
		return new MySqlConnectionStringBuilder();
	}

	public override DbCommandBuilder CreateCommandBuilder()
	{
		return new MySqlCommandBuilder();
	}

	public override DbDataAdapter CreateDataAdapter()
	{
		return new MySqlDataAdapter();
	}

	object IServiceProvider.GetService(Type serviceType)
	{
		if (!(serviceType != DbServicesType))
		{
			return MySqlDbProviderServicesInstance?.GetValue(null);
		}
		return null;
	}
}
