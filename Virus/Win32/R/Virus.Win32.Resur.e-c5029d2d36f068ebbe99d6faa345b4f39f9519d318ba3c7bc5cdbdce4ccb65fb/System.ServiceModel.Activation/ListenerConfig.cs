using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Principal;
using System.ServiceModel.Activation.Configuration;
using System.ServiceModel.Diagnostics;

namespace System.ServiceModel.Activation;

internal static class ListenerConfig
{
	private static object syncRoot = new object();

	private static NetTcpSectionData tcpData = null;

	private static NetPipeSectionData pipeData = null;

	private static bool diagnosticsSectionInited = false;

	private static bool perfCountersEnabled = false;

	private static object SyncRoot => syncRoot;

	public static NetTcpSectionData NetTcp
	{
		get
		{
			EnsureInitializedForNetTcp();
			return tcpData;
		}
	}

	public static NetPipeSectionData NetPipe
	{
		get
		{
			EnsureInitializedForNetPipe();
			return pipeData;
		}
	}

	public static bool PerformanceCountersEnabled
	{
		get
		{
			EnsureInitializedForDiagnostics();
			return perfCountersEnabled;
		}
	}

	private static void EnsureInitializedForDiagnostics()
	{
		if (diagnosticsSectionInited)
		{
			return;
		}
		lock (SyncRoot)
		{
			if (!diagnosticsSectionInited)
			{
				DiagnosticSection section = DiagnosticSection.GetSection();
				perfCountersEnabled = section.get_PerformanceCountersEnabled();
				diagnosticsSectionInited = true;
			}
		}
	}

	public static void EnsureInitializedForNetTcp()
	{
		EnsureInitializedForDiagnostics();
		if (tcpData == null)
		{
			lock (SyncRoot)
			{
				if (tcpData == null)
				{
					tcpData = new NetTcpSectionData();
				}
			}
		}
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			DiagnosticUtility.DiagnosticTrace.TraceEvent(TraceEventType.Information, (TraceCode)655366, SR.GetString("TraceCodeReadNetTcpConfig", tcpData.ListenBacklog, tcpData.MaxPendingConnections, tcpData.MaxPendingAccepts, tcpData.ReceiveTimeout, tcpData.TeredoEnabled));
		}
	}

	public static void EnsureInitializedForNetPipe()
	{
		EnsureInitializedForDiagnostics();
		if (pipeData == null)
		{
			lock (SyncRoot)
			{
				if (pipeData == null)
				{
					pipeData = new NetPipeSectionData();
				}
			}
		}
		if (DiagnosticUtility.ShouldTraceInformation)
		{
			DiagnosticUtility.DiagnosticTrace.TraceEvent(TraceEventType.Information, (TraceCode)655367, SR.GetString("TraceCodeReadNetPipeConfig", pipeData.MaxPendingConnections, pipeData.MaxPendingAccepts, pipeData.ReceiveTimeout));
		}
	}

	public static List<SecurityIdentifier> GetAllowAccounts(TransportType transportType)
	{
		switch (transportType)
		{
		case TransportType.Tcp:
			if (NetTcp.AllowAccounts.Count == 0)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("ConfigSectionHasZeroAllowAccounts", "NetTcpSection")));
			}
			return NetTcp.AllowAccounts;
		case TransportType.NamedPipe:
			if (NetPipe.AllowAccounts.Count == 0)
			{
				throw DiagnosticUtility.ExceptionUtility.ThrowHelperError((Exception)new InvalidOperationException(SR.GetString("ConfigSectionHasZeroAllowAccounts", "NetPipeSection")));
			}
			return NetPipe.AllowAccounts;
		default:
			return null;
		}
	}
}
