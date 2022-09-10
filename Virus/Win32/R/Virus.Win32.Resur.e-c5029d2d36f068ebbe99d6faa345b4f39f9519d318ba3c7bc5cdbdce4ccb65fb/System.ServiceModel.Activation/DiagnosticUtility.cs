using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Security;
using System.Security.Permissions;
using System.ServiceModel.Diagnostics;
using System.ServiceModel.Dispatcher;

namespace System.ServiceModel.Activation;

internal static class DiagnosticUtility
{
	private class UtilityWithHandler : Utility
	{
		public UtilityWithHandler(ExceptionUtility exceptionUtility)
			: base(exceptionUtility)
		{
		}

		[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
		[SecurityCritical]
		[SecurityPermission(SecurityAction.InheritanceDemand, UnmanagedCode = true)]
		internal override bool CallHandler(Exception exception)
		{
			ExceptionHandler asynchronousThreadExceptionHandler = ExceptionHandler.get_AsynchronousThreadExceptionHandler();
			if (asynchronousThreadExceptionHandler != null)
			{
				return asynchronousThreadExceptionHandler.HandleException(exception);
			}
			return false;
		}
	}

	private const string TraceSourceName = "SMSvcHost";

	internal const string EventSourceName = "SMSvcHost 3.0.0.0";

	internal const string DefaultTraceListenerName = "Default";

	private static SourceLevels level = SourceLevels.Off;

	private static bool tracingEnabled = false;

	private static bool shouldUseActivity = false;

	private static bool shouldTraceVerbose = false;

	private static bool shouldTraceInformation = false;

	private static bool shouldTraceWarning = false;

	private static bool shouldTraceError = false;

	private static bool shouldTraceCritical = false;

	private static DiagnosticTrace diagnosticTrace = InitializeTracing();

	private static object lockObject = new object();

	private static ExceptionUtility exceptionUtility = null;

	private static Utility utility = null;

	internal static DiagnosticTrace DiagnosticTrace => diagnosticTrace;

	internal static ExceptionUtility ExceptionUtility => exceptionUtility ?? GetExceptionUtility();

	internal static Utility Utility => utility ?? GetUtility();

	internal static EventLogger EventLog => new EventLogger("SMSvcHost 3.0.0.0", (object)diagnosticTrace);

	internal static bool TracingEnabled => tracingEnabled;

	internal static bool ShouldTraceCritical => shouldTraceCritical;

	internal static bool ShouldUseActivity => shouldUseActivity;

	internal static bool ShouldTraceError => shouldTraceError;

	internal static bool ShouldTraceWarning => shouldTraceWarning;

	internal static bool ShouldTraceInformation => shouldTraceInformation;

	internal static bool ShouldTraceVerbose => shouldTraceVerbose;

	private static void UpdateLevel()
	{
		level = DiagnosticTrace.get_Level();
		tracingEnabled = DiagnosticTrace.get_TracingEnabled();
		shouldTraceCritical = DiagnosticTrace.ShouldTrace(TraceEventType.Critical);
		shouldTraceError = DiagnosticTrace.ShouldTrace(TraceEventType.Error);
		shouldTraceInformation = DiagnosticTrace.ShouldTrace(TraceEventType.Information);
		shouldTraceWarning = DiagnosticTrace.ShouldTrace(TraceEventType.Warning);
		shouldTraceVerbose = DiagnosticTrace.ShouldTrace(TraceEventType.Verbose);
		shouldUseActivity = DiagnosticTrace.get_ShouldUseActivity();
	}

	private static ExceptionUtility GetExceptionUtility()
	{
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		lock (lockObject)
		{
			if (exceptionUtility == null)
			{
				exceptionUtility = new ExceptionUtility("SMSvcHost", "SMSvcHost 3.0.0.0", (object)diagnosticTrace);
			}
		}
		return exceptionUtility;
	}

	private static Utility GetUtility()
	{
		lock (lockObject)
		{
			if (utility == null)
			{
				utility = (Utility)(object)new UtilityWithHandler(ExceptionUtility);
			}
		}
		return utility;
	}

	private static DiagnosticTrace InitializeTracing()
	{
		InitDiagnosticTraceImpl((TraceSourceKind)1, "SMSvcHost");
		if (!diagnosticTrace.get_HaveListeners())
		{
			diagnosticTrace = null;
		}
		return diagnosticTrace;
	}

	internal static void InitDiagnosticTraceImpl(TraceSourceKind sourceType, string traceSourceName)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		diagnosticTrace = new DiagnosticTrace(sourceType, traceSourceName, "SMSvcHost 3.0.0.0");
		UpdateLevel();
	}

	internal static bool ShouldTrace(TraceEventType type)
	{
		bool result = false;
		if (TracingEnabled)
		{
			switch (type)
			{
			case TraceEventType.Verbose:
				result = ShouldTraceVerbose;
				break;
			case TraceEventType.Information:
				result = ShouldTraceInformation;
				break;
			case TraceEventType.Critical:
				result = ShouldTraceCritical;
				break;
			case TraceEventType.Error:
				result = ShouldTraceError;
				break;
			case TraceEventType.Warning:
				result = ShouldTraceWarning;
				break;
			}
		}
		return result;
	}

	[Conditional("DEBUG")]
	internal static void DebugAssert(bool condition, string message)
	{
	}

	[Conditional("DEBUG")]
	internal static void DebugAssert(string message)
	{
		AssertUtility.DebugAssertCore(message);
	}

	internal static AsyncCallback ThunkAsyncCallback(AsyncCallback callback)
	{
		return Utility.ThunkCallback(callback);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static bool IsFatal(Exception exception)
	{
		return ExceptionUtility.IsFatal(exception);
	}

	internal static Exception FailFast(string message)
	{
		try
		{
			try
			{
				ExceptionUtility.TraceFailFast(message);
			}
			finally
			{
				Environment.FailFast(message);
			}
		}
		catch
		{
		}
		Environment.FailFast(message);
		return null;
	}

	internal static Exception InvokeFinalHandler(Exception exception)
	{
		try
		{
			try
			{
				ExceptionUtility.TraceFailFastException(exception);
			}
			finally
			{
				Environment.FailFast(null);
			}
		}
		catch
		{
		}
		Environment.FailFast(null);
		return null;
	}
}
