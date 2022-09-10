using System.Collections.Generic;
using System.Diagnostics;
using System.ServiceModel.Diagnostics;

namespace System.ServiceModel.Activation.Diagnostics;

internal static class ListenerPerfCounters
{
	private static readonly string CategoryName;

	private static PerformanceCounter perfCounterConnectionsAcceptedNamedPipe;

	private static PerformanceCounter perfCounterConnectionsAcceptedTcp;

	private static PerformanceCounter perfCounterDispatchFailuresNamedPipe;

	private static PerformanceCounter perfCounterDispatchFailuresTcp;

	private static PerformanceCounter perfCounterProtocolFailuresNamedPipe;

	private static PerformanceCounter perfCounterProtocolFailuresTcp;

	private static PerformanceCounter perfCounterUrisRegisteredNamedPipe;

	private static PerformanceCounter perfCounterUrisRegisteredTcp;

	private static PerformanceCounter perfCounterRegistrationsActiveNamedPipe;

	private static PerformanceCounter perfCounterRegistrationsActiveTcp;

	private static PerformanceCounter perfCounterConnectionsDispatchedNamedPipe;

	private static PerformanceCounter perfCounterConnectionsDispatchedTcp;

	private static PerformanceCounter perfCounterUrisUnregisteredNamedPipe;

	private static PerformanceCounter perfCounterUrisUnregisteredTcp;

	private static List<PerformanceCounter> perfList;

	private static object syncObject;

	private static List<PerformanceCounter> PerformanceList
	{
		get
		{
			if (perfList == null)
			{
				lock (syncObject)
				{
					if (perfList == null)
					{
						perfList = new List<PerformanceCounter>();
					}
				}
			}
			return perfList;
		}
	}

	static ListenerPerfCounters()
	{
		CategoryName = "SMSvcHost 3.0.0.0";
		syncObject = new object();
		if (ListenerConfig.PerformanceCountersEnabled)
		{
			AddCounterToList(perfCounterConnectionsDispatchedTcp = GetListenerPerformanceCounter(CategoryName, "Connections Dispatched over net.tcp", string.Empty, (PerformanceCounterInstanceLifetime)0));
			AddCounterToList(perfCounterConnectionsDispatchedNamedPipe = GetListenerPerformanceCounter(CategoryName, "Connections Dispatched over net.pipe", string.Empty, (PerformanceCounterInstanceLifetime)0));
			AddCounterToList(perfCounterDispatchFailuresTcp = GetListenerPerformanceCounter(CategoryName, "Dispatch Failures over net.tcp", string.Empty, (PerformanceCounterInstanceLifetime)0));
			AddCounterToList(perfCounterDispatchFailuresNamedPipe = GetListenerPerformanceCounter(CategoryName, "Dispatch Failures over net.pipe", string.Empty, (PerformanceCounterInstanceLifetime)0));
			AddCounterToList(perfCounterUrisRegisteredTcp = GetListenerPerformanceCounter(CategoryName, "Uris Registered for net.tcp", string.Empty, (PerformanceCounterInstanceLifetime)0));
			AddCounterToList(perfCounterUrisRegisteredNamedPipe = GetListenerPerformanceCounter(CategoryName, "Uris Registered for net.pipe", string.Empty, (PerformanceCounterInstanceLifetime)0));
			AddCounterToList(perfCounterUrisUnregisteredTcp = GetListenerPerformanceCounter(CategoryName, "Uris Unregistered for net.tcp", string.Empty, (PerformanceCounterInstanceLifetime)0));
			AddCounterToList(perfCounterUrisUnregisteredNamedPipe = GetListenerPerformanceCounter(CategoryName, "Uris Unregistered for net.pipe", string.Empty, (PerformanceCounterInstanceLifetime)0));
			AddCounterToList(perfCounterRegistrationsActiveTcp = GetListenerPerformanceCounter(CategoryName, "Registrations Active for net.tcp", string.Empty, (PerformanceCounterInstanceLifetime)0));
			AddCounterToList(perfCounterRegistrationsActiveNamedPipe = GetListenerPerformanceCounter(CategoryName, "Registrations Active for net.pipe", string.Empty, (PerformanceCounterInstanceLifetime)0));
			AddCounterToList(perfCounterConnectionsAcceptedTcp = GetListenerPerformanceCounter(CategoryName, "Connections Accepted over net.tcp", string.Empty, (PerformanceCounterInstanceLifetime)0));
			AddCounterToList(perfCounterConnectionsAcceptedNamedPipe = GetListenerPerformanceCounter(CategoryName, "Connections Accepted over net.pipe", string.Empty, (PerformanceCounterInstanceLifetime)0));
			AddCounterToList(perfCounterProtocolFailuresTcp = GetListenerPerformanceCounter(CategoryName, "Protocol Failures over net.tcp", string.Empty, (PerformanceCounterInstanceLifetime)0));
			AddCounterToList(perfCounterProtocolFailuresNamedPipe = GetListenerPerformanceCounter(CategoryName, "Protocol Failures over net.pipe", string.Empty, (PerformanceCounterInstanceLifetime)0));
			AppDomain.CurrentDomain.UnhandledException += ExitOrUnloadEventHandler;
			AppDomain.CurrentDomain.DomainUnload += ExitOrUnloadEventHandler;
			AppDomain.CurrentDomain.ProcessExit += ExitOrUnloadEventHandler;
		}
	}

	private static PerformanceCounter GetListenerPerformanceCounter(string categoryName, string perfCounterName, string instanceName, PerformanceCounterInstanceLifetime instanceLifetime)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		return PerformanceCounters.GetPerformanceCounterInternal(categoryName, perfCounterName, instanceName, instanceLifetime);
	}

	private static void AddCounterToList(PerformanceCounter counter)
	{
		if (counter != null)
		{
			PerformanceList.Add(counter);
		}
	}

	internal static void DecrementRegistrationsActiveNamedPipe()
	{
		DecrementCounter(ref perfCounterRegistrationsActiveNamedPipe);
	}

	internal static void DecrementRegistrationsActiveTcp()
	{
		DecrementCounter(ref perfCounterRegistrationsActiveTcp);
	}

	internal static void IncrementConnectionsAcceptedNamedPipe()
	{
		IncrementCounter(ref perfCounterConnectionsAcceptedNamedPipe);
	}

	internal static void IncrementConnectionsAcceptedTcp()
	{
		IncrementCounter(ref perfCounterConnectionsAcceptedTcp);
	}

	internal static void IncrementDispatchFailuresNamedPipe()
	{
		IncrementCounter(ref perfCounterDispatchFailuresNamedPipe);
	}

	internal static void IncrementDispatchFailuresTcp()
	{
		IncrementCounter(ref perfCounterDispatchFailuresTcp);
	}

	internal static void IncrementProtocolFailuresNamedPipe()
	{
		IncrementCounter(ref perfCounterProtocolFailuresNamedPipe);
	}

	internal static void IncrementProtocolFailuresTcp()
	{
		IncrementCounter(ref perfCounterProtocolFailuresTcp);
	}

	internal static void IncrementUrisRegisteredNamedPipe()
	{
		IncrementCounter(ref perfCounterUrisRegisteredNamedPipe);
	}

	internal static void IncrementUrisRegisteredTcp()
	{
		IncrementCounter(ref perfCounterUrisRegisteredTcp);
	}

	internal static void IncrementRegistrationsActiveNamedPipe()
	{
		IncrementCounter(ref perfCounterRegistrationsActiveNamedPipe);
	}

	internal static void IncrementRegistrationsActiveTcp()
	{
		IncrementCounter(ref perfCounterRegistrationsActiveTcp);
	}

	internal static void IncrementConnectionsDispatchedNamedPipe()
	{
		IncrementCounter(ref perfCounterConnectionsDispatchedNamedPipe);
	}

	internal static void IncrementConnectionsDispatchedTcp()
	{
		IncrementCounter(ref perfCounterConnectionsDispatchedTcp);
	}

	internal static void IncrementUrisUnregisteredNamedPipe()
	{
		IncrementCounter(ref perfCounterUrisUnregisteredNamedPipe);
	}

	internal static void IncrementUrisUnregisteredTcp()
	{
		IncrementCounter(ref perfCounterUrisUnregisteredTcp);
	}

	private static void IncrementCounter(ref PerformanceCounter counter)
	{
		if (counter == null)
		{
			return;
		}
		try
		{
			counter.Increment();
		}
		catch (Exception exception)
		{
			if (DiagnosticUtility.IsFatal(exception))
			{
				throw;
			}
			TracePerformanceCounterUpdateFailure(counter.get_InstanceName(), counter.get_CounterName());
			counter = null;
		}
	}

	private static void DecrementCounter(ref PerformanceCounter counter)
	{
		if (counter == null)
		{
			return;
		}
		try
		{
			counter.Decrement();
		}
		catch (Exception exception)
		{
			if (DiagnosticUtility.IsFatal(exception))
			{
				throw;
			}
			TracePerformanceCounterUpdateFailure(counter.get_InstanceName(), counter.get_CounterName());
			counter = null;
		}
	}

	internal static void TracePerformanceCounterUpdateFailure(string instanceName, string perfCounterName)
	{
		if (DiagnosticUtility.ShouldTraceError)
		{
			DiagnosticUtility.DiagnosticTrace.TraceEvent(TraceEventType.Error, (TraceCode)524346, SR.GetString("TraceCodePerformanceCountersFailedDuringUpdate", perfCounterName + "::" + instanceName));
		}
	}

	private static void ExitOrUnloadEventHandler(object sender, EventArgs e)
	{
		List<PerformanceCounter> list = null;
		if (perfList != null)
		{
			lock (syncObject)
			{
				if (perfList != null)
				{
					list = perfList;
					perfList = null;
				}
			}
		}
		if (list == null)
		{
			return;
		}
		foreach (PerformanceCounter item in list)
		{
			string counterName = item.get_CounterName();
			string categoryName = item.get_CategoryName();
			string instanceName = item.get_InstanceName();
			try
			{
				item.RemoveInstance();
			}
			catch (Exception ex)
			{
				if (DiagnosticUtility.IsFatal(ex))
				{
					throw;
				}
				ListenerTraceUtility.EventLog.LogEvent(TraceEventType.Error, (EventLogCategory)8, (EventLogEventId)(-1073610741), false, new string[4]
				{
					categoryName,
					counterName,
					instanceName,
					ex.ToString()
				});
			}
		}
	}
}
