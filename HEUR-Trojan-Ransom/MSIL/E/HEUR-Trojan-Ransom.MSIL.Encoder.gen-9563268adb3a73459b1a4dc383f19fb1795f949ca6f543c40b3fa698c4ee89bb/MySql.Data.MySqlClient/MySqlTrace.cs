#define TRACE
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace MySql.Data.MySqlClient;

public class MySqlTrace
{
	private static TraceSource source;

	public static TraceListenerCollection Listeners { get; }

	public static SourceSwitch Switch
	{
		get
		{
			return source.Switch;
		}
		set
		{
			source.Switch = value;
		}
	}

	public static bool QueryAnalysisEnabled { get; set; }

	internal static TraceSource Source => source;

	static MySqlTrace()
	{
		source = new TraceSource("mysql");
		Listeners = source.Listeners;
		using IEnumerator<TraceListener> enumerator = (from TraceListener listener in source.Listeners
			where listener.GetType().ToString().Contains("MySql.EMTrace.EMTraceListener")
			select listener).GetEnumerator();
		if (enumerator.MoveNext())
		{
			_ = enumerator.Current;
			QueryAnalysisEnabled = true;
		}
	}

	public static void EnableQueryAnalyzer(string host, int postInterval)
	{
		if (!QueryAnalysisEnabled)
		{
			TraceListener traceListener = (TraceListener)Activator.CreateInstance(Type.GetType("MySql.EMTrace.EMTraceListener"), host, postInterval);
			if (traceListener == null)
			{
				throw new MySqlException(Resources.UnableToEnableQueryAnalysis);
			}
			source.Listeners.Add(traceListener);
			Switch.Level = SourceLevels.All;
		}
	}

	public static void DisableQueryAnalyzer()
	{
		QueryAnalysisEnabled = false;
		using IEnumerator<TraceListener> enumerator = (from TraceListener l in Source.Listeners
			where l.GetType().ToString().Contains("EMTraceListener")
			select l).GetEnumerator();
		if (enumerator.MoveNext())
		{
			TraceListener current = enumerator.Current;
			source.Listeners.Remove(current);
		}
	}

	internal static void LogInformation(int id, string msg)
	{
		Source.TraceEvent(TraceEventType.Information, id, msg, MySqlTraceEventType.NonQuery, -1);
		Trace.TraceInformation(msg);
	}

	internal static void LogWarning(int id, string msg)
	{
		Source.TraceEvent(TraceEventType.Warning, id, msg, MySqlTraceEventType.NonQuery, -1);
		Trace.TraceWarning(msg);
	}

	internal static void LogError(int id, string msg)
	{
		Source.TraceEvent(TraceEventType.Error, id, msg, MySqlTraceEventType.NonQuery, -1);
		Trace.TraceError(msg);
	}

	internal static void TraceEvent(TraceEventType eventType, MySqlTraceEventType mysqlEventType, string msgFormat, params object[] args)
	{
		Source.TraceEvent(eventType, (int)mysqlEventType, msgFormat, args);
	}
}
