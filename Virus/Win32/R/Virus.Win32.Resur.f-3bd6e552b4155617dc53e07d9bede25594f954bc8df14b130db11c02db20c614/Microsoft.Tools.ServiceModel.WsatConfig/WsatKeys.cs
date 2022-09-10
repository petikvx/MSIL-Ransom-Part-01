namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal static class WsatKeys
{
	internal const string RootRegKey = "Software\\Microsoft\\";

	internal const string WsatRegKey = "Software\\Microsoft\\WSAT\\3.0\\";

	internal const string WsatClusterRegKey = "WSATPrivate\\3.0";

	internal const string MsdtcClusterRegKey_OS6 = "MSDTCPrivate\\MSDTC";

	internal const string MsdtcClusterDataPointerRegKey_OS5 = "DataPointer";

	internal const string MsdtcRegKey = "Software\\Microsoft\\MSDTC\\";

	internal const string MsdtcSecurityKey = "Security\\";

	internal const string TransactionBridgeRegKey = "TransactionBridge";

	internal const string RegistryEntryX509CertificateIdentity = "X509CertificateIdentity";

	internal const string RegistryEntryHttpsPort = "HttpsPort";

	internal const string RegistryEntryTraceLevel = "DiagnosticTracing";

	internal const string RegistryEntryPropagateActivity = "DiagnosticTracingPropagateActivity";

	internal const string RegistryEntryActivityTracing = "DiagnosticTracingActivityTracing";

	internal const string RegistryEntryTracingPii = "DiagnosticTracingTracePII";

	internal const string RegistryEntryDefTimeout = "DefaultTimeout";

	internal const string RegistryEntryMaxTimeout = "MaxTimeout";

	internal const string RegistryEntryX509GlobalAcl = "X509GlobalAcl";

	internal const string RegistryEntryKerberosGlobalAcl = "KerberosGlobalAcl";

	internal const string DtcSecurityRegKey = "Software\\Microsoft\\Security\\";

	internal const string WSATAssemblyPathEntry = "Path";

	internal const string WsatPropertySheetGUID = "32739F38-BDB5-4807-BD0A-3CF038A8A804";

	internal const string WsatSnapinAboutGUID = "32739F38-BDB6-4807-BD0A-3CF038A8A804";

	internal const string ComponentServicesComputerNodeGUID = "0442836D-C770-11d1-87F4-00C04FC2C17B";

	internal const string ComponentServicesDtcNodeGUID = "49e8d37b-e86e-464d-9790-f0947e9d514f";

	internal const string WSATRegisterSnapinKey = "Software\\Microsoft\\MMC\\Snapins\\";

	internal const string WSATRegisterSnapinWsatPropertySheetKey = "Software\\Microsoft\\MMC\\Snapins\\{32739F38-BDB5-4807-BD0A-3CF038A8A804}\\";

	internal const string WSATRegisterSnapinWsatPropertySheetAboutEntry = "About";

	internal const string WSATRegisterSnapinWsatPropertySheetAboutValue = "{32739F38-BDB6-4807-BD0A-3CF038A8A804}";

	internal const string WSATRegisterSnapinWsatPropertySheetNameEntry = "NameString";

	internal const string WSATRegisterSnapinWsatPropertySheetNameValue = "Wsat Configuration Utility";

	internal const string WSATRegisterNodeTypesWsatPropertySheetGUIDEntry = "{32739F38-BDB5-4807-BD0A-3CF038A8A804}";

	internal const string WSATRegisterNodeTypesWsatPropertySheetGUIDValue = "Wsat Configuration Utility";

	internal const string WinFXKey = "Software\\Microsoft\\NET Framework Setup\\NDP\\";

	internal const string WcfSetupKey = "Software\\Microsoft\\NET Framework Setup\\NDP\\v3.0\\Setup\\Windows Communication Foundation\\";

	internal const string RuntimeInstallPath = "RuntimeInstallPath";

	internal const string MaxTraceSizeKey = "MaxTraceSize";

	internal const string TraceFileDiectoryKey = "TraceFileDirectory";

	internal const string MaxTraceBuffersKey = "MaxTraceBuffers";
}
