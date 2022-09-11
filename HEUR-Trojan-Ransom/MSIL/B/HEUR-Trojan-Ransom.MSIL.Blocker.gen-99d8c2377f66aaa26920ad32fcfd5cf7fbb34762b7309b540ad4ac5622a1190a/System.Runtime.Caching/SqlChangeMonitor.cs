using System.Data.SqlClient;
using System.Globalization;

namespace System.Runtime.Caching;

public sealed class SqlChangeMonitor : ChangeMonitor
{
	private string _uniqueId;

	private SqlDependency _sqlDependency;

	public override string UniqueId => _uniqueId;

	private SqlChangeMonitor()
	{
	}

	public SqlChangeMonitor(SqlDependency dependency)
	{
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Expected O, but got Unknown
		if (dependency == null)
		{
			throw new ArgumentNullException("dependency");
		}
		bool flag = true;
		try
		{
			_sqlDependency = dependency;
			_sqlDependency.add_OnChange(new OnChangeEventHandler(OnDependencyChanged));
			_uniqueId = Guid.NewGuid().ToString("N", CultureInfo.InvariantCulture);
			flag = false;
		}
		finally
		{
			InitializationComplete();
			if (flag)
			{
				Dispose();
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
	}

	private void OnDependencyChanged(object sender, SqlNotificationEventArgs e)
	{
		OnChanged(null);
	}
}
