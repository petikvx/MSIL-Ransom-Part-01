using System;
using System.Diagnostics;
using MySql.Data.MySqlClient;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns11;
using ns21;
using ns4;

namespace ns26;

internal sealed class Class147 : Class146
{
	private static PerformanceCounter performanceCounter_0;

	private static PerformanceCounter performanceCounter_1;

	[NonSerialized]
	internal static GetString getString_1;

	public Class147(Class139 class139_1)
		: base(class139_1)
	{
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		string perfMonCategoryName = Class121.PerfMonCategoryName;
		if (class139_1.Settings.UsePerformanceMonitor && performanceCounter_0 == null)
		{
			try
			{
				performanceCounter_0 = new PerformanceCounter(perfMonCategoryName, getString_1(107352078), false);
				performanceCounter_1 = new PerformanceCounter(perfMonCategoryName, getString_1(107352049), false);
			}
			catch (Exception ex)
			{
				MySqlTrace.smethod_4(class139_1.ServerThread, ex.Message);
			}
		}
	}

	private void method_0()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Expected O, but got Unknown
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		CounterCreationDataCollection val = new CounterCreationDataCollection();
		CounterCreationData val2 = new CounterCreationData();
		val2.set_CounterType((PerformanceCounterType)65536);
		val2.set_CounterName(getString_1(107352078));
		val.Add(val2);
		val2 = new CounterCreationData();
		val2.set_CounterType((PerformanceCounterType)65536);
		val2.set_CounterName(getString_1(107352049));
		val.Add(val2);
		if (!PerformanceCounterCategory.Exists(Class121.PerfMonCategoryName))
		{
			PerformanceCounterCategory.Create(Class121.PerfMonCategoryName, getString_1(107398197), (PerformanceCounterCategoryType)0, val);
		}
	}

	public override void vmethod_0()
	{
		if (base.Connection.Settings.UsePerformanceMonitor && performanceCounter_0 != null)
		{
			performanceCounter_0.Increment();
		}
	}

	public override void vmethod_1()
	{
		if (base.Connection.Settings.UsePerformanceMonitor && performanceCounter_1 != null)
		{
			performanceCounter_1.Increment();
		}
	}

	static Class147()
	{
		Strings.CreateGetStringDelegate(typeof(Class147));
	}
}
