using System;
using System.Diagnostics;

namespace MySql.Data.MySqlClient;

internal class SystemPerformanceMonitor : PerformanceMonitor
{
	private static PerformanceCounter procedureHardQueries;

	private static PerformanceCounter procedureSoftQueries;

	public SystemPerformanceMonitor(MySqlConnection connection)
		: base(connection)
	{
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		string perfMonCategoryName = Resources.PerfMonCategoryName;
		if (connection.Settings.UsePerformanceMonitor && procedureHardQueries == null)
		{
			try
			{
				procedureHardQueries = new PerformanceCounter(perfMonCategoryName, "HardProcedureQueries", false);
				procedureSoftQueries = new PerformanceCounter(perfMonCategoryName, "SoftProcedureQueries", false);
			}
			catch (Exception ex)
			{
				MySqlTrace.LogError(connection.ServerThread, ex.Message);
			}
		}
	}

	private void EnsurePerfCategoryExist()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		CounterCreationDataCollection val = new CounterCreationDataCollection();
		CounterCreationData val2 = new CounterCreationData();
		val2.set_CounterType((PerformanceCounterType)65536);
		val2.set_CounterName("HardProcedureQueries");
		val.Add(val2);
		val2 = new CounterCreationData();
		val2.set_CounterType((PerformanceCounterType)65536);
		val2.set_CounterName("SoftProcedureQueries");
		val.Add(val2);
		if (!PerformanceCounterCategory.Exists(Resources.PerfMonCategoryName))
		{
			PerformanceCounterCategory.Create(Resources.PerfMonCategoryName, "", (PerformanceCounterCategoryType)0, val);
		}
	}

	public override void AddHardProcedureQuery()
	{
		if (base.Connection.Settings.UsePerformanceMonitor && procedureHardQueries != null)
		{
			procedureHardQueries.Increment();
		}
	}

	public override void AddSoftProcedureQuery()
	{
		if (base.Connection.Settings.UsePerformanceMonitor && procedureSoftQueries != null)
		{
			procedureSoftQueries.Increment();
		}
	}
}
