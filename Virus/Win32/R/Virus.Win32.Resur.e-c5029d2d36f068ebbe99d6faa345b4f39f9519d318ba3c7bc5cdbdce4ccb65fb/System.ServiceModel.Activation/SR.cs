using System.Globalization;
using System.Resources;
using System.Threading;

namespace System.ServiceModel.Activation;

internal sealed class SR
{
	internal const string FramingModeNotSupported = "FramingModeNotSupported";

	internal const string ConfigSectionHasZeroAllowAccounts = "ConfigSectionHasZeroAllowAccounts";

	internal const string LAProtocolMismatch = "LAProtocolMismatch";

	internal const string MessageQueueNotSet = "MessageQueueNotSet";

	internal const string PipeAddressAlreadyUsed = "PipeAddressAlreadyUsed";

	internal const string ServiceRequiresWas = "ServiceRequiresWas";

	internal const string ServiceStartErrorEndpoint = "ServiceStartErrorEndpoint";

	internal const string ServiceStartErrorPublish = "ServiceStartErrorPublish";

	internal const string SharingRegistrationFailed = "SharingRegistrationFailed";

	internal const string SharingRegistrationFailedAndAbort = "SharingRegistrationFailedAndAbort";

	internal const string WebHostProcNotFound = "WebHostProcNotFound";

	internal const string WebHostVersionMismatch = "WebHostVersionMismatch";

	internal const string TraceCodeMessageQueueClosed = "TraceCodeMessageQueueClosed";

	internal const string TraceCodeMessageQueueDuplicatedPipe = "TraceCodeMessageQueueDuplicatedPipe";

	internal const string TraceCodeMessageQueueDuplicatedPipeError = "TraceCodeMessageQueueDuplicatedPipeError";

	internal const string TraceCodeMessageQueueDuplicatedSocket = "TraceCodeMessageQueueDuplicatedSocket";

	internal const string TraceCodeMessageQueueDuplicatedSocketError = "TraceCodeMessageQueueDuplicatedSocketError";

	internal const string TraceCodeMessageQueueRegisterCalled = "TraceCodeMessageQueueRegisterCalled";

	internal const string TraceCodeMessageQueueRegisterSucceeded = "TraceCodeMessageQueueRegisterSucceeded";

	internal const string TraceCodeMessageQueueUnregisterSucceeded = "TraceCodeMessageQueueUnregisterSucceeded";

	internal const string TraceCodeMessageQueueMultiplexDispatchFailed = "TraceCodeMessageQueueMultiplexDispatchFailed";

	internal const string TraceCodeReadNetTcpConfig = "TraceCodeReadNetTcpConfig";

	internal const string TraceCodeReadNetPipeConfig = "TraceCodeReadNetPipeConfig";

	internal const string TraceCodeRoutingTableFailedToListen = "TraceCodeRoutingTableFailedToListen";

	internal const string TraceCodeRoutingTableLookup = "TraceCodeRoutingTableLookup";

	internal const string TraceCodeRoutingTableNamespaceConflict = "TraceCodeRoutingTableNamespaceConflict";

	internal const string TraceCodeRoutingTableCannotListen = "TraceCodeRoutingTableCannotListen";

	internal const string TraceCodeRoutingTablePathTooLong = "TraceCodeRoutingTablePathTooLong";

	internal const string TraceCodeRoutingTableRegisterSuccess = "TraceCodeRoutingTableRegisterSuccess";

	internal const string TraceCodeRoutingTableUnsupportedProtocol = "TraceCodeRoutingTableUnsupportedProtocol";

	internal const string TraceCodeServiceContinue = "TraceCodeServiceContinue";

	internal const string TraceCodeServicePause = "TraceCodeServicePause";

	internal const string TraceCodeServiceShutdown = "TraceCodeServiceShutdown";

	internal const string TraceCodeServiceShutdownError = "TraceCodeServiceShutdownError";

	internal const string TraceCodeServiceStart = "TraceCodeServiceStart";

	internal const string TraceCodeServiceStartPipeError = "TraceCodeServiceStartPipeError";

	internal const string TraceCodeServiceStop = "TraceCodeServiceStop";

	internal const string TraceCodeTransportListenerListenRequest = "TraceCodeTransportListenerListenRequest";

	internal const string TraceCodeTransportListenerListening = "TraceCodeTransportListenerListening";

	internal const string TraceCodeTransportListenerSessionsReceived = "TraceCodeTransportListenerSessionsReceived";

	internal const string TraceCodeTransportListenerStop = "TraceCodeTransportListenerStop";

	internal const string TraceCodeWasCloseAllListenerChannelInstances = "TraceCodeWasCloseAllListenerChannelInstances";

	internal const string TraceCodeWasConnected = "TraceCodeWasConnected";

	internal const string TraceCodeWasDelPoolWithApps = "TraceCodeWasDelPoolWithApps";

	internal const string TraceCodeMessageQueueRegisterFailed = "TraceCodeMessageQueueRegisterFailed";

	internal const string TraceCodeWasWebHostAPIFailed = "TraceCodeWasWebHostAPIFailed";

	private static SR loader;

	private ResourceManager resources;

	private static object s_InternalSyncObject;

	private static object InternalSyncObject
	{
		get
		{
			if (s_InternalSyncObject == null)
			{
				object value = new object();
				Interlocked.CompareExchange(ref s_InternalSyncObject, value, null);
			}
			return s_InternalSyncObject;
		}
	}

	private static CultureInfo Culture => null;

	public static ResourceManager Resources => GetLoader().resources;

	internal SR()
	{
		resources = new ResourceManager("SMSvcHost", GetType().Assembly);
	}

	private static SR GetLoader()
	{
		if (loader == null)
		{
			lock (InternalSyncObject)
			{
				if (loader == null)
				{
					loader = new SR();
				}
			}
		}
		return loader;
	}

	public static string GetString(string name, params object[] args)
	{
		SR sR = GetLoader();
		if (sR == null)
		{
			return null;
		}
		string @string = sR.resources.GetString(name, Culture);
		if (args != null && args.Length > 0)
		{
			for (int i = 0; i < args.Length; i++)
			{
				if (args[i] is string text && text.Length > 1024)
				{
					args[i] = text.Substring(0, 1021) + "...";
				}
			}
			return string.Format(CultureInfo.CurrentCulture, @string, args);
		}
		return @string;
	}

	public static string GetString(string name)
	{
		return GetLoader()?.resources.GetString(name, Culture);
	}

	public static object GetObject(string name)
	{
		return GetLoader()?.resources.GetObject(name, Culture);
	}
}
