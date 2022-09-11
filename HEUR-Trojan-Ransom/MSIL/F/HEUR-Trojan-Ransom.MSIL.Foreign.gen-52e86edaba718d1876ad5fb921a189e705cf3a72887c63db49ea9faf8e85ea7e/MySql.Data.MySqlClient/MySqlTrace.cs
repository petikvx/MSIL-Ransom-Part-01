#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns1;
using ns21;

namespace MySql.Data.MySqlClient;

public sealed class MySqlTrace
{
	private static TraceSource traceSource_0;

	[CompilerGenerated]
	private static readonly TraceListenerCollection traceListenerCollection_0;

	[CompilerGenerated]
	private static bool bool_0;

	[NonSerialized]
	internal static GetString getString_0;

	public static TraceListenerCollection Listeners
	{
		[CompilerGenerated]
		get
		{
			return traceListenerCollection_0;
		}
	}

	public static SourceSwitch Switch
	{
		get
		{
			return traceSource_0.Switch;
		}
		set
		{
			traceSource_0.Switch = value;
		}
	}

	public static bool QueryAnalysisEnabled
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		set
		{
			bool_0 = value;
		}
	}

	internal static TraceSource Source => traceSource_0;

	static MySqlTrace()
	{
		Strings.CreateGetStringDelegate(typeof(MySqlTrace));
		traceSource_0 = new TraceSource(getString_0(107376407));
		traceListenerCollection_0 = traceSource_0.Listeners;
		using IEnumerator<TraceListener> enumerator = (from TraceListener traceListener_0 in traceSource_0.Listeners
			where traceListener_0.GetType().ToString().Contains(_003C_003Ec.getString_0(107376433))
			select traceListener_0).GetEnumerator();
		if (enumerator.MoveNext())
		{
			_ = enumerator.Current;
			QueryAnalysisEnabled = true;
		}
	}

	public static void smethod_0(string string_0, int int_0)
	{
		if (!QueryAnalysisEnabled)
		{
			TraceListener traceListener = (TraceListener)Activator.CreateInstance(Type.GetType(getString_0(107376430)), string_0, int_0);
			if (traceListener == null)
			{
				throw new MySqlException(Class121.UnableToEnableQueryAnalysis);
			}
			traceSource_0.Listeners.Add(traceListener);
			Switch.Level = SourceLevels.All;
		}
	}

	public static void smethod_1()
	{
		QueryAnalysisEnabled = false;
		using IEnumerator<TraceListener> enumerator = (from TraceListener traceListener_0 in Source.Listeners
			where traceListener_0.GetType().ToString().Contains(_003C_003Ec.getString_0(107376392))
			select traceListener_0).GetEnumerator();
		if (enumerator.MoveNext())
		{
			TraceListener current = enumerator.Current;
			traceSource_0.Listeners.Remove(current);
		}
	}

	internal static void smethod_2(int int_0, string string_0)
	{
		Source.TraceEvent(TraceEventType.Information, int_0, string_0, Enum47.const_9, -1);
		Trace.TraceInformation(string_0);
	}

	internal static void smethod_3(int int_0, string string_0)
	{
		Source.TraceEvent(TraceEventType.Warning, int_0, string_0, Enum47.const_9, -1);
		Trace.TraceWarning(string_0);
	}

	internal static void smethod_4(int int_0, string string_0)
	{
		Source.TraceEvent(TraceEventType.Error, int_0, string_0, Enum47.const_9, -1);
		Trace.TraceError(string_0);
	}

	internal static void smethod_5(TraceEventType traceEventType_0, Enum47 enum47_0, string string_0, params object[] object_0)
	{
		Source.TraceEvent(traceEventType_0, (int)enum47_0, string_0, object_0);
	}
}
