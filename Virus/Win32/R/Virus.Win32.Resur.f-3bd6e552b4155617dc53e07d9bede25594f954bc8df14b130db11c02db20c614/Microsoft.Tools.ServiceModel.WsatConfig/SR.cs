using System.Globalization;
using System.Resources;
using System.Threading;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal sealed class SR
{
	internal const string InfoRestartingMSDTC = "InfoRestartingMSDTC";

	internal const string InfoRestartedMSDTC = "InfoRestartedMSDTC";

	internal const string ConsoleUsageLine01 = "ConsoleUsageLine01";

	internal const string ConsoleUsageLine02 = "ConsoleUsageLine02";

	internal const string ConsoleUsageLineOptions = "ConsoleUsageLineOptions";

	internal const string ConsoleUsageLineNetworkUse = "ConsoleUsageLineNetworkUse";

	internal const string ConsoleUsageLineNetworkHelp = "ConsoleUsageLineNetworkHelp";

	internal const string ConsoleUsageLinePortUse = "ConsoleUsageLinePortUse";

	internal const string ConsoleUsageLinePortHelp = "ConsoleUsageLinePortHelp";

	internal const string ConsoleUsageLineEndpointCertsUse1 = "ConsoleUsageLineEndpointCertsUse1";

	internal const string ConsoleUsageLineEndpointCertsUse2 = "ConsoleUsageLineEndpointCertsUse2";

	internal const string ConsoleUsageLineEndpointCertsHelp = "ConsoleUsageLineEndpointCertsHelp";

	internal const string ConsoleUsageLineAccountsUse = "ConsoleUsageLineAccountsUse";

	internal const string ConsoleUsageLineAccountsHelp = "ConsoleUsageLineAccountsHelp";

	internal const string ConsoleUsageLineAccountsCertsUse1 = "ConsoleUsageLineAccountsCertsUse1";

	internal const string ConsoleUsageLineAccountsCertsUse2 = "ConsoleUsageLineAccountsCertsUse2";

	internal const string ConsoleUsageLineAccountsCertsHelp = "ConsoleUsageLineAccountsCertsHelp";

	internal const string ConsoleUsageLineClusterVirtualServerUse = "ConsoleUsageLineClusterVirtualServerUse";

	internal const string ConsoleUsageLineClusterVirtualServerHelp = "ConsoleUsageLineClusterVirtualServerHelp";

	internal const string ConsoleUsageLineTimeoutUse = "ConsoleUsageLineTimeoutUse";

	internal const string ConsoleUsageLineTimeoutHelp = "ConsoleUsageLineTimeoutHelp";

	internal const string ConsoleUsageLineMaxTimeoutUse = "ConsoleUsageLineMaxTimeoutUse";

	internal const string ConsoleUsageLineMaxTimeoutHelp = "ConsoleUsageLineMaxTimeoutHelp";

	internal const string ConsoleUsageLineTraceLevelUse1 = "ConsoleUsageLineTraceLevelUse1";

	internal const string ConsoleUsageLineTraceLevelUse2 = "ConsoleUsageLineTraceLevelUse2";

	internal const string ConsoleUsageLineTraceLevelUse3 = "ConsoleUsageLineTraceLevelUse3";

	internal const string ConsoleUsageLineTraceLevelHelp = "ConsoleUsageLineTraceLevelHelp";

	internal const string ConsoleUsageLineTraceActivityUse = "ConsoleUsageLineTraceActivityUse";

	internal const string ConsoleUsageLineTraceActivityHelp = "ConsoleUsageLineTraceActivityHelp";

	internal const string ConsoleUsageLineTracePropUse = "ConsoleUsageLineTracePropUse";

	internal const string ConsoleUsageLineTracePropHelp = "ConsoleUsageLineTracePropHelp";

	internal const string ConsoleUsageLineTracePIIUse = "ConsoleUsageLineTracePIIUse";

	internal const string ConsoleUsageLineTracePIIHelp = "ConsoleUsageLineTracePIIHelp";

	internal const string ConsoleUsageLineShowHelp = "ConsoleUsageLineShowHelp";

	internal const string ConsoleUsageLineRestartHelp = "ConsoleUsageLineRestartHelp";

	internal const string ConsoleBannerLine01 = "ConsoleBannerLine01";

	internal const string ConsoleBannerLine02 = "ConsoleBannerLine02";

	internal const string ConsoleBannerLine03 = "ConsoleBannerLine03";

	internal const string ConsoleShowInformation = "ConsoleShowInformation";

	internal const string ClusterConfigUpdatedSuccessfully = "ClusterConfigUpdatedSuccessfully";

	internal const string ConfigUpdatedSuccessfully = "ConfigUpdatedSuccessfully";

	internal const string ErrorDuplicateOption = "ErrorDuplicateOption";

	internal const string ErrorUpdateSettingsWhenNetworkIsDisabled = "ErrorUpdateSettingsWhenNetworkIsDisabled";

	internal const string ErrorAccountArgument = "ErrorAccountArgument";

	internal const string UnexpectedError = "UnexpectedError";

	internal const string ErrorMsdtcNetworkAccessDisabled = "ErrorMsdtcNetworkAccessDisabled";

	internal const string ErrorMsdtcNetworkAccessDenied = "ErrorMsdtcNetworkAccessDenied";

	internal const string ErrorCannotGetMsdtcNetworkAccessSetting = "ErrorCannotGetMsdtcNetworkAccessSetting";

	internal const string ErrorCannotGetMsdtcNetworkAccessSettingWithDiagnostics = "ErrorCannotGetMsdtcNetworkAccessSettingWithDiagnostics";

	internal const string ErrorDefaultTimeoutRange = "ErrorDefaultTimeoutRange";

	internal const string ErrorMaximumTimeoutRange = "ErrorMaximumTimeoutRange";

	internal const string ErrorHttpsPortRange = "ErrorHttpsPortRange";

	internal const string ErrorRegistryAccess = "ErrorRegistryAccess";

	internal const string ErrorRegistryAccessNoErrorCode = "ErrorRegistryAccessNoErrorCode";

	internal const string ErrorRegistryWrite = "ErrorRegistryWrite";

	internal const string ErrorAccessCertStore = "ErrorAccessCertStore";

	internal const string ErrorRegisterHttpsPort = "ErrorRegisterHttpsPort";

	internal const string ErrorRegisterHttpsPortAlreadyExists = "ErrorRegisterHttpsPortAlreadyExists";

	internal const string ErrorUnregisterHttpsPort = "ErrorUnregisterHttpsPort";

	internal const string ErrorHttpsPortSSLBinding = "ErrorHttpsPortSSLBinding";

	internal const string ErrorHttpsPortSSLBindingAlreadyExists = "ErrorHttpsPortSSLBindingAlreadyExists";

	internal const string ErrorHttpsPortSSLUnbinding = "ErrorHttpsPortSSLUnbinding";

	internal const string ErrorMissingSSLCert = "ErrorMissingSSLCert";

	internal const string ErrorSSLCertHasNoPrivateKey = "ErrorSSLCertHasNoPrivateKey";

	internal const string ErrorSSLCertCanNotAccessPrivateKey = "ErrorSSLCertCanNotAccessPrivateKey";

	internal const string ErrorSSLCertDoesNotSupportKeyEnciphermentOrDsig = "ErrorSSLCertDoesNotSupportKeyEnciphermentOrDsig";

	internal const string ErrorSSLCertDoesNotSupportClientAuthentication = "ErrorSSLCertDoesNotSupportClientAuthentication";

	internal const string ErrorSSLCertDoesNotSupportServerAuthentication = "ErrorSSLCertDoesNotSupportServerAuthentication";

	internal const string ErrorInvalidOrMissingClientCert = "ErrorInvalidOrMissingClientCert";

	internal const string ErrorRestartMSDTC = "ErrorRestartMSDTC";

	internal const string ErrorRestartMSDTCWithErrorCode = "ErrorRestartMSDTCWithErrorCode";

	internal const string ErrorRemoteTimeout = "ErrorRemoteTimeout";

	internal const string ErrorRemoteWSATMissing = "ErrorRemoteWSATMissing";

	internal const string ErrorWMIBlockedByFirewall = "ErrorWMIBlockedByFirewall";

	internal const string ErrorAttemptRemoteExecution = "ErrorAttemptRemoteExecution";

	internal const string ErrorRemoteExecution = "ErrorRemoteExecution";

	internal const string ErrorArgument = "ErrorArgument";

	internal const string ErrorNetworkArgument = "ErrorNetworkArgument";

	internal const string ErrorTraceLevelArgument = "ErrorTraceLevelArgument";

	internal const string ErrorTraceActivityArgument = "ErrorTraceActivityArgument";

	internal const string ErrorTracePropArgument = "ErrorTracePropArgument";

	internal const string ErrorTracePiiArgument = "ErrorTracePiiArgument";

	internal const string ErrorCannotFindMachineCertificate = "ErrorCannotFindMachineCertificate";

	internal const string ErrorClusterRemoteNodeArgument = "ErrorClusterRemoteNodeArgument";

	internal const string ErrorDefaultWSATConfig = "ErrorDefaultWSATConfig";

	internal const string CannotOpenClusterRegistry = "CannotOpenClusterRegistry";

	internal const string FirewallAccessDenied = "FirewallAccessDenied";

	internal const string UnexpectedFirewallError = "UnexpectedFirewallError";

	internal const string ErrorCannotGetRemoteInstallPath = "ErrorCannotGetRemoteInstallPath";

	internal const string ErrorCluterVirtualServerArgument = "ErrorCluterVirtualServerArgument";

	internal const string ErrorCanNotFindVirtualServer = "ErrorCanNotFindVirtualServer";

	internal const string ErrorUpdateCertPrivateKeyPerm = "ErrorUpdateCertPrivateKeyPerm";

	internal const string ErrorCanNotFindWcfInstalled = "ErrorCanNotFindWcfInstalled";

	internal const string ErrorCanNotFindWcfInstalledOnRemoteMachine = "ErrorCanNotFindWcfInstalledOnRemoteMachine";

	internal const string ErrorWcfVersionMismatch = "ErrorWcfVersionMismatch";

	internal const string ErrorWcfVersionMismatchOnRemoteMachine = "ErrorWcfVersionMismatchOnRemoteMachine";

	internal const string ErrorNoQFE = "ErrorNoQFE";

	internal const string FriendlyNameNone = "FriendlyNameNone";

	internal const string HTTPSPortName = "HTTPSPortName";

	internal const string ConfigStatusEnabled = "ConfigStatusEnabled";

	internal const string ConfigStatusDiabled = "ConfigStatusDiabled";

	internal const string ConfigNetworkSupport = "ConfigNetworkSupport";

	internal const string ConfigHTTPSPort = "ConfigHTTPSPort";

	internal const string ConfigIdentityCertificate = "ConfigIdentityCertificate";

	internal const string ConfigKerberosGACL = "ConfigKerberosGACL";

	internal const string ConfigACEPrefix = "ConfigACEPrefix";

	internal const string ConfigAcceptedCertificates = "ConfigAcceptedCertificates";

	internal const string ConfigAcceptedCertPrefix = "ConfigAcceptedCertPrefix";

	internal const string ConfigDefaultTimeout = "ConfigDefaultTimeout";

	internal const string ConfigMaximumTimeout = "ConfigMaximumTimeout";

	internal const string ConfigMaximumTimeoutWhenNetworkDisabled = "ConfigMaximumTimeoutWhenNetworkDisabled";

	internal const string ConfigTraceLevel = "ConfigTraceLevel";

	internal const string ConfigActivityTracing = "ConfigActivityTracing";

	internal const string ConfigActivityProp = "ConfigActivityProp";

	internal const string ConfigPiiTracing = "ConfigPiiTracing";

	internal const string ConfigWarningNetworkDTCAccessIsDisabled = "ConfigWarningNetworkDTCAccessIsDisabled";

	internal const string ConfigNone = "ConfigNone";

	internal const string WSATApplicationFriendlyName = "WSATApplicationFriendlyName";

	internal const string ErrorSessionLogFileSize = "ErrorSessionLogFileSize";

	internal const string ErrorSessionFlushData = "ErrorSessionFlushData";

	internal const string ErrorSessionFlushDataAccessDenied = "ErrorSessionFlushDataAccessDenied";

	internal const string ErrorSessionStop = "ErrorSessionStop";

	internal const string ErrorSessionStopAccessDenied = "ErrorSessionStopAccessDenied";

	internal const string ErrorSessionStart = "ErrorSessionStart";

	internal const string ErrorSessionStartBadPathname = "ErrorSessionStartBadPathname";

	internal const string ErrorSessionStartDiskFull = "ErrorSessionStartDiskFull";

	internal const string ErrorSessionStartFileNotFound = "ErrorSessionStartFileNotFound";

	internal const string ErrorSessionStartPathNotFound = "ErrorSessionStartPathNotFound";

	internal const string ErrorSessionBackupFileAttempt = "ErrorSessionBackupFileAttempt";

	internal const string ErrorSessionBackupFileRename = "ErrorSessionBackupFileRename";

	internal const string ErrorSessionEnableProviderError = "ErrorSessionEnableProviderError";

	internal const string ErrorSessionEnableProviderAccessDenied = "ErrorSessionEnableProviderAccessDenied";

	internal const string ErrorSessionTooLongLogFileName = "ErrorSessionTooLongLogFileName";

	internal const string ErrorSessionInvalidLogFileName = "ErrorSessionInvalidLogFileName";

	internal const string RemoteRegistryFormat = "RemoteRegistryFormat";

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
		resources = new ResourceManager("WsatConfig", GetType().Assembly);
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
