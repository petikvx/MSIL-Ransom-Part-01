using System;
using System.Diagnostics;
using System.Globalization;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using Microsoft.Win32;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class WsatConfiguration
{
	private const string TransactionBridgeRegistryValue = "{EEC5DCCA-05DC-4B46-8AF7-2881C1635AEA}";

	internal const bool DefaultNetworkSupport = false;

	internal const uint DefaultHttpsPort = 443u;

	internal const SourceLevels DefaultTraceLevel = SourceLevels.Warning;

	internal const bool DefaultActivityPropagation = false;

	internal const bool DefaultActivityTracing = false;

	internal const uint DefaultDefaultTimeout = 60u;

	internal const uint DefaultMaxTimeout = 3600u;

	internal const bool DefaultTracingPii = false;

	private const X509Certificate2 DefaultX509CertificateIdentity = null;

	internal string[] DefaultX509GlobalAcl = new string[1] { string.Empty };

	internal string[] DefaultKerberosGlobalAcl = new string[1] { "NT AUTHORITY\\Authenticated Users" };

	private WsatConfiguration previousConfig;

	private FirewallWrapper firewallWrapper;

	private string machineName;

	private string virtualServer;

	private ConfigurationProvider wsatConfigProvider;

	private ConfigurationProvider msdtcConfigProvider;

	private bool isClusterRemoteNode;

	private uint httpsPort = 443u;

	private uint defaultTimeout = 60u;

	private uint maxTimeout = 3600u;

	private SourceLevels diagnosticTraceLevel = SourceLevels.Warning;

	private bool activityPropagation;

	private bool activityTracing;

	private bool tracePii;

	private bool transactionBridgeEnabled;

	private X509Certificate2 certificate;

	private string[] allowedCertificates;

	private string[] kerberosGlobalAcl;

	private bool minimalWrite;

	private string[] clusterNodes;

	private SafeHResource hClusterDtcResource;

	internal bool IsClusterRemoteNode
	{
		get
		{
			return isClusterRemoteNode;
		}
		set
		{
			isClusterRemoteNode = value;
		}
	}

	internal bool IsClustered
	{
		get
		{
			if (hClusterDtcResource != null)
			{
				return !hClusterDtcResource.IsInvalid;
			}
			return false;
		}
	}

	internal string MachineName
	{
		get
		{
			if (!string.IsNullOrEmpty(machineName))
			{
				return machineName;
			}
			return string.Empty;
		}
		set
		{
			machineName = value;
		}
	}

	internal string VirtualServer
	{
		get
		{
			return virtualServer;
		}
		set
		{
			virtualServer = value;
		}
	}

	internal bool TransactionBridgeEnabled
	{
		get
		{
			return transactionBridgeEnabled;
		}
		set
		{
			transactionBridgeEnabled = value;
		}
	}

	internal uint HttpsPort
	{
		get
		{
			return httpsPort;
		}
		set
		{
			httpsPort = value;
		}
	}

	internal SourceLevels TraceLevel
	{
		get
		{
			return diagnosticTraceLevel;
		}
		set
		{
			diagnosticTraceLevel = value;
		}
	}

	internal uint DefaultTimeout
	{
		get
		{
			return defaultTimeout;
		}
		set
		{
			defaultTimeout = value;
		}
	}

	internal uint MaxTimeout
	{
		get
		{
			return maxTimeout;
		}
		set
		{
			maxTimeout = value;
		}
	}

	internal bool ActivityTracing
	{
		get
		{
			return activityTracing;
		}
		set
		{
			activityTracing = value;
		}
	}

	internal bool ActivityPropagation
	{
		get
		{
			return activityPropagation;
		}
		set
		{
			activityPropagation = value;
		}
	}

	internal bool TracePii
	{
		get
		{
			return tracePii;
		}
		set
		{
			tracePii = value;
		}
	}

	internal string[] X509GlobalAcl
	{
		get
		{
			return allowedCertificates;
		}
		set
		{
			if (value == null)
			{
				allowedCertificates = new string[0];
			}
			else
			{
				allowedCertificates = value;
			}
		}
	}

	internal string[] KerberosGlobalAcl
	{
		get
		{
			return kerberosGlobalAcl;
		}
		set
		{
			if (value == null)
			{
				kerberosGlobalAcl = new string[0];
			}
			else
			{
				kerberosGlobalAcl = value;
			}
		}
	}

	internal X509Certificate2 X509Certificate
	{
		get
		{
			return certificate;
		}
		set
		{
			certificate = value;
		}
	}

	internal bool IsLocalMachine
	{
		get
		{
			if (!IsClustered)
			{
				return Utilities.IsLocalMachineName(MachineName);
			}
			return false;
		}
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal WsatConfiguration(string machineName, string virtualServer, WsatConfiguration previousConfig, bool minimalWrite)
	{
		MachineName = machineName;
		this.minimalWrite = minimalWrite;
		firewallWrapper = new FirewallWrapper();
		this.previousConfig = previousConfig;
		this.virtualServer = virtualServer;
		if (previousConfig == null)
		{
			allowedCertificates = DefaultX509GlobalAcl;
			kerberosGlobalAcl = DefaultKerberosGlobalAcl;
		}
		else
		{
			CopyConfigurationData(previousConfig, this);
		}
		if (MsdtcClusterUtils.IsClusterServer(MachineName))
		{
			hClusterDtcResource = MsdtcClusterUtils.GetTransactionManagerClusterResource(VirtualServer, out clusterNodes);
			if ((hClusterDtcResource == null || hClusterDtcResource.IsInvalid) && !string.IsNullOrEmpty(VirtualServer))
			{
				throw new WsatAdminException(WsatAdminErrorCode.CANNOT_FIND_CLUSTER_VIRTUAL_SERVER, SR.GetString("ErrorCanNotFindVirtualServer"));
			}
		}
		InitializeConfigurationProvider();
	}

	private void CopyConfigurationData(WsatConfiguration src, WsatConfiguration dest)
	{
		dest.TransactionBridgeEnabled = src.TransactionBridgeEnabled;
		dest.HttpsPort = src.HttpsPort;
		dest.X509Certificate = src.X509Certificate;
		dest.KerberosGlobalAcl = src.KerberosGlobalAcl;
		dest.X509GlobalAcl = src.X509GlobalAcl;
		dest.DefaultTimeout = src.DefaultTimeout;
		dest.MaxTimeout = src.MaxTimeout;
		dest.TraceLevel = src.TraceLevel;
		dest.ActivityPropagation = src.ActivityPropagation;
		dest.ActivityTracing = src.ActivityTracing;
		dest.TracePii = src.TracePii;
		dest.MachineName = src.MachineName;
		dest.IsClusterRemoteNode = src.IsClusterRemoteNode;
		dest.VirtualServer = src.VirtualServer;
	}

	internal MsdtcWrapper GetMsdtcWrapper()
	{
		return MsdtcWrapper.GetWrapper(MachineName, VirtualServer, msdtcConfigProvider);
	}

	internal void ValidateThrow()
	{
		if (!TransactionBridgeEnabled)
		{
			return;
		}
		if (!IsClusterRemoteNode)
		{
			MsdtcWrapper msdtcWrapper = GetMsdtcWrapper();
			if (!msdtcWrapper.GetNetworkTransactionAccess())
			{
				throw new WsatAdminException(WsatAdminErrorCode.MSDTC_NETWORK_ACCESS_DISABLED, SR.GetString("ErrorMsdtcNetworkAccessDisabled"));
			}
		}
		if (HttpsPort < 1)
		{
			throw new WsatAdminException(WsatAdminErrorCode.INVALID_HTTPS_PORT, SR.GetString("ErrorHttpsPortRange"));
		}
		ValidateIdentityCertificateThrow(X509Certificate, !Utilities.IsLocalMachineName(MachineName));
		if (DefaultTimeout >= 1 && DefaultTimeout <= 3600)
		{
			if (MaxTimeout > 3600)
			{
				throw new WsatAdminException(WsatAdminErrorCode.INVALID_MAXTIMEOUT_ARGUMENT, SR.GetString("ErrorMaximumTimeoutRange"));
			}
			return;
		}
		throw new WsatAdminException(WsatAdminErrorCode.INVALID_DEFTIMEOUT_ARGUMENT, SR.GetString("ErrorDefaultTimeoutRange"));
	}

	private void InitializeConfigurationProvider()
	{
		WcfVersionChecker wcfVersionChecker = new WcfVersionChecker(MachineName);
		wcfVersionChecker.EnsureWcfVersionIsExpected();
		if (IsClustered)
		{
			msdtcConfigProvider = new ClusterRegistryConfigurationProvider(hClusterDtcResource, GetClusterMstdcRegistryKey());
			wsatConfigProvider = new ClusterRegistryConfigurationProvider(hClusterDtcResource, "WSATPrivate\\3.0");
		}
		else
		{
			msdtcConfigProvider = new RegistryConfigurationProvider(RegistryHive.LocalMachine, "Software\\Microsoft\\MSDTC\\", MachineName);
			wsatConfigProvider = new RegistryConfigurationProvider(RegistryHive.LocalMachine, "Software\\Microsoft\\WSAT\\3.0\\", MachineName);
		}
	}

	private string GetClusterMstdcRegistryKey()
	{
		if (Utilities.OSMajor > 5)
		{
			return "MSDTCPrivate\\MSDTC";
		}
		ClusterRegistryConfigurationProvider clusterRegistryConfigurationProvider = new ClusterRegistryConfigurationProvider(hClusterDtcResource, "DataPointer");
		using (clusterRegistryConfigurationProvider)
		{
			string text = clusterRegistryConfigurationProvider.ReadString(string.Empty, string.Empty);
			if (!string.IsNullOrEmpty(text))
			{
				return text;
			}
		}
		RegistryExceptionHelper registryExceptionHelper = new RegistryExceptionHelper("DataPointer");
		throw registryExceptionHelper.CreateRegistryAccessException(null);
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal void LoadFromRegistry()
	{
		string s = msdtcConfigProvider.ReadString("TransactionBridge", null);
		TransactionBridgeEnabled = Utilities.SafeCompare(s, "{EEC5DCCA-05DC-4B46-8AF7-2881C1635AEA}");
		HttpsPort = wsatConfigProvider.ReadUInt32("HttpsPort", 443u);
		X509Certificate = CertificateManager.GetCertificateFromThumbprint(wsatConfigProvider.ReadString("X509CertificateIdentity", string.Empty), MachineName);
		KerberosGlobalAcl = wsatConfigProvider.ReadMultiString("KerberosGlobalAcl", DefaultKerberosGlobalAcl);
		X509GlobalAcl = wsatConfigProvider.ReadMultiString("X509GlobalAcl", DefaultX509GlobalAcl);
		TraceLevel = (SourceLevels)wsatConfigProvider.ReadUInt32("DiagnosticTracing", 7u);
		ActivityTracing = wsatConfigProvider.ReadUInt32("DiagnosticTracingActivityTracing", 0u) != 0;
		ActivityPropagation = wsatConfigProvider.ReadUInt32("DiagnosticTracingPropagateActivity", 0u) != 0;
		TracePii = wsatConfigProvider.ReadUInt32("DiagnosticTracingTracePII", 0u) != 0;
		DefaultTimeout = wsatConfigProvider.ReadUInt32("DefaultTimeout", 60u);
		MaxTimeout = wsatConfigProvider.ReadUInt32("MaxTimeout", 3600u);
	}

	internal static void ValidateIdentityCertificateThrow(X509Certificate2 cert, bool remoteCert)
	{
		if (cert == null)
		{
			throw new WsatAdminException(WsatAdminErrorCode.INVALID_OR_MISSING_SSL_CERTIFICATE, SR.GetString("ErrorMissingSSLCert"));
		}
		if (remoteCert)
		{
			return;
		}
		if (!cert.HasPrivateKey)
		{
			throw new WsatAdminException(WsatAdminErrorCode.INVALID_OR_MISSING_SSL_CERTIFICATE, SR.GetString("ErrorSSLCertHasNoPrivateKey"));
		}
		try
		{
			_ = cert.PrivateKey;
		}
		catch (CryptographicException innerException)
		{
			throw new WsatAdminException(WsatAdminErrorCode.INVALID_OR_MISSING_SSL_CERTIFICATE, SR.GetString("ErrorSSLCertCanNotAccessPrivateKey"), innerException);
		}
		X509KeyUsageExtension x509KeyUsageExtension = (X509KeyUsageExtension)cert.Extensions["2.5.29.15"];
		if (x509KeyUsageExtension != null && (x509KeyUsageExtension.KeyUsages & (X509KeyUsageFlags.KeyEncipherment | X509KeyUsageFlags.DigitalSignature)) != (X509KeyUsageFlags.KeyEncipherment | X509KeyUsageFlags.DigitalSignature))
		{
			throw new WsatAdminException(WsatAdminErrorCode.INVALID_OR_MISSING_SSL_CERTIFICATE, SR.GetString("ErrorSSLCertDoesNotSupportKeyEnciphermentOrDsig"));
		}
		X509EnhancedKeyUsageExtension x509EnhancedKeyUsageExtension = (X509EnhancedKeyUsageExtension)cert.Extensions["2.5.29.37"];
		if (x509EnhancedKeyUsageExtension != null)
		{
			if (x509EnhancedKeyUsageExtension.EnhancedKeyUsages["1.3.6.1.5.5.7.3.2"] == null)
			{
				throw new WsatAdminException(WsatAdminErrorCode.INVALID_OR_MISSING_SSL_CERTIFICATE, SR.GetString("ErrorSSLCertDoesNotSupportClientAuthentication"));
			}
			if (x509EnhancedKeyUsageExtension.EnhancedKeyUsages["1.3.6.1.5.5.7.3.1"] == null)
			{
				throw new WsatAdminException(WsatAdminErrorCode.INVALID_OR_MISSING_SSL_CERTIFICATE, SR.GetString("ErrorSSLCertDoesNotSupportServerAuthentication"));
			}
		}
	}

	private void UpdateClusterNodesPorts(bool restart)
	{
		if (clusterNodes == null)
		{
			return;
		}
		string[] array = clusterNodes;
		foreach (string s in array)
		{
			if (Utilities.SafeCompare(s, Utilities.LocalHostName))
			{
				UpdatePorts();
				UpdateCertificatePrivateKeyAccess();
			}
			else
			{
				SaveRemote(s, restart: false, clusterRemoteNode: true);
			}
		}
	}

	private void RestartHelper(bool restart)
	{
		if (!restart)
		{
			return;
		}
		try
		{
			MsdtcWrapper msdtcWrapper = GetMsdtcWrapper();
			msdtcWrapper.RestartDtcService();
		}
		catch (WsatAdminException)
		{
			throw;
		}
		catch (Exception ex2)
		{
			if (Utilities.IsCriticalException(ex2))
			{
				throw;
			}
			throw new WsatAdminException(WsatAdminErrorCode.DTC_RESTART_ERROR, SR.GetString("ErrorRestartMSDTC"), ex2);
		}
	}

	internal void Save(bool restart)
	{
		if (IsLocalMachine)
		{
			Utilities.Log("Save - LocalMachine");
			UpdatePorts();
			UpdateCertificatePrivateKeyAccess();
			SaveToRegistry();
			RestartHelper(restart);
		}
		else if (IsClusterRemoteNode)
		{
			Utilities.Log("Save - Cluster Remote Node");
			UpdatePorts();
			UpdateCertificatePrivateKeyAccess();
		}
		else if (IsClustered)
		{
			Utilities.Log("Save - Cluster");
			UpdateClusterNodesPorts(restart);
			SaveToRegistry();
			RestartHelper(restart);
		}
		else
		{
			Utilities.Log("Save - Remote");
			SaveRemote(restart, clusterRemoteNode: false);
		}
		CopyConfigurationData(this, previousConfig);
	}

	private void SaveRemote(bool restart, bool clusterRemoteNode)
	{
		SaveRemote(MachineName, restart, clusterRemoteNode);
	}

	private void SaveRemote(string machineName, bool restart, bool clusterRemoteNode)
	{
		WcfVersionChecker wcfVersionChecker = new WcfVersionChecker(machineName);
		wcfVersionChecker.EnsureWcfVersionIsExpected();
		string text = null;
		string text2 = null;
		string text3 = null;
		string text4 = null;
		string text5 = null;
		string text6 = null;
		string text7 = null;
		string text8 = null;
		string text9 = null;
		string text10 = null;
		string text11 = " -network:" + (TransactionBridgeEnabled ? "enable" : "disable");
		string text12 = null;
		if (!string.IsNullOrEmpty(VirtualServer))
		{
			text12 = " -virtualServer:\"" + VirtualServer + "\"";
		}
		if (TransactionBridgeEnabled)
		{
			text = " -port:" + HttpsPort;
			text2 = ((X509Certificate == null) ? "" : (" -endpointCert:" + X509Certificate.Thumbprint));
			text3 = " -accounts:" + BuildAccountsArgument();
			text4 = " -accountsCerts:" + BuildAccountsCertsArgument();
			text5 = " -timeout:" + DefaultTimeout.ToString(CultureInfo.InvariantCulture);
			text7 = " -traceLevel:" + ((uint)TraceLevel).ToString(CultureInfo.InvariantCulture);
			text8 = " -traceActivity:" + (ActivityTracing ? "enable" : "disable");
			text9 = " -traceProp:" + (ActivityPropagation ? "enable" : "disable");
			text10 = " -tracePII:" + (TracePii ? "enable" : "disable");
			text6 = " -maxTimeout:" + MaxTimeout.ToString(CultureInfo.InvariantCulture);
		}
		string text13 = text11 + text12 + text + text2 + text3 + text4 + text5 + text6 + text7 + text8 + text9 + text10;
		if (clusterRemoteNode)
		{
			text13 += " -clusterRemoteNode:enable";
		}
		if (restart)
		{
			text13 += " -restart";
		}
		Utilities.Log("Remote command arguments: " + text13);
		RemoteHelper remoteHelper = new RemoteHelper(machineName);
		remoteHelper.ExecuteWsatProcess(text13);
	}

	private string BuildAccountsCertsArgument()
	{
		string text = string.Empty;
		if (X509GlobalAcl != null && X509GlobalAcl.Length > 0)
		{
			text = text + "\"" + X509GlobalAcl[0] + "\"";
			for (int i = 1; i < X509GlobalAcl.Length; i++)
			{
				text = text + ",\"" + X509GlobalAcl[i] + "\"";
			}
		}
		return text;
	}

	private string BuildAccountsArgument()
	{
		string text = string.Empty;
		if (KerberosGlobalAcl != null && KerberosGlobalAcl.Length > 0)
		{
			text = text + "\"" + KerberosGlobalAcl[0] + "\"";
			for (int i = 1; i < KerberosGlobalAcl.Length; i++)
			{
				text = text + ",\"" + KerberosGlobalAcl[i] + "\"";
			}
		}
		return text;
	}

	private void UpdateCertificatePrivateKeyAccess()
	{
		if (previousConfig == null)
		{
			AddCertificatePrivateKeyAccess(X509Certificate);
		}
		else if (X509Certificate != previousConfig.X509Certificate)
		{
			RemoveCertificatePrivateKeyAccess(previousConfig.X509Certificate);
			AddCertificatePrivateKeyAccess(X509Certificate);
		}
	}

	private void CommitCryptoKeySecurity(CspKeyContainerInfo info, CryptoKeySecurity keySec)
	{
		CspParameters cspParameters = new CspParameters(info.ProviderType, info.ProviderName, info.KeyContainerName);
		cspParameters.set_CryptoKeySecurity(keySec);
		cspParameters.Flags = CspProviderFlags.UseMachineKeyStore;
		new RSACryptoServiceProvider(cspParameters);
	}

	private void RemoveCertificatePrivateKeyAccess(X509Certificate2 cert)
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		if (cert == null || !cert.HasPrivateKey)
		{
			return;
		}
		try
		{
			AsymmetricAlgorithm privateKey = cert.PrivateKey;
			if (!(privateKey is RSACryptoServiceProvider))
			{
				return;
			}
			RSACryptoServiceProvider rSACryptoServiceProvider = privateKey as RSACryptoServiceProvider;
			CspKeyContainerInfo cspKeyContainerInfo = rSACryptoServiceProvider.CspKeyContainerInfo;
			CryptoKeySecurity cryptoKeySecurity = cspKeyContainerInfo.get_CryptoKeySecurity();
			SecurityIdentifier securityIdentifier = new SecurityIdentifier(WellKnownSidType.NetworkServiceSid, null);
			AuthorizationRuleCollection accessRules = ((CommonObjectSecurity)(object)cryptoKeySecurity).GetAccessRules(includeExplicit: true, includeInherited: false, typeof(SecurityIdentifier));
			foreach (AuthorizationRule item in accessRules)
			{
				CryptoKeyAccessRule val = (CryptoKeyAccessRule)item;
				if (((AccessRule)(object)val).AccessControlType == AccessControlType.Allow && (val.get_CryptoKeyRights() & int.MinValue) != 0)
				{
					SecurityIdentifier sid = ((AuthorizationRule)(object)val).IdentityReference as SecurityIdentifier;
					if (securityIdentifier.Equals(sid))
					{
						CryptoKeyAccessRule val2 = new CryptoKeyAccessRule((IdentityReference)securityIdentifier, (CryptoKeyRights)int.MinValue, AccessControlType.Allow);
						cryptoKeySecurity.RemoveAccessRule(val2);
						CommitCryptoKeySecurity(cspKeyContainerInfo, cryptoKeySecurity);
						break;
					}
				}
			}
		}
		catch (Exception ex)
		{
			if (Utilities.IsCriticalException(ex))
			{
				throw;
			}
			throw new WsatAdminException(WsatAdminErrorCode.CANNOT_UPDATE_PRIVATE_KEY_PERM, SR.GetString("ErrorUpdateCertPrivateKeyPerm"), ex);
		}
	}

	private void AddCertificatePrivateKeyAccess(X509Certificate2 cert)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		if (cert == null || !cert.HasPrivateKey)
		{
			return;
		}
		try
		{
			AsymmetricAlgorithm privateKey = cert.PrivateKey;
			if (privateKey is RSACryptoServiceProvider)
			{
				RSACryptoServiceProvider rSACryptoServiceProvider = privateKey as RSACryptoServiceProvider;
				CspKeyContainerInfo cspKeyContainerInfo = rSACryptoServiceProvider.CspKeyContainerInfo;
				CryptoKeySecurity cryptoKeySecurity = cspKeyContainerInfo.get_CryptoKeySecurity();
				SecurityIdentifier securityIdentifier = new SecurityIdentifier(WellKnownSidType.NetworkServiceSid, null);
				CryptoKeyAccessRule val = new CryptoKeyAccessRule((IdentityReference)securityIdentifier, (CryptoKeyRights)int.MinValue, AccessControlType.Allow);
				cryptoKeySecurity.AddAccessRule(val);
				CommitCryptoKeySecurity(cspKeyContainerInfo, cryptoKeySecurity);
			}
		}
		catch (Exception ex)
		{
			if (Utilities.IsCriticalException(ex))
			{
				throw;
			}
			throw new WsatAdminException(WsatAdminErrorCode.CANNOT_UPDATE_PRIVATE_KEY_PERM, SR.GetString("ErrorUpdateCertPrivateKeyPerm"), ex);
		}
	}

	private void SaveToRegistry()
	{
		if (!minimalWrite || previousConfig == null || TransactionBridgeEnabled != previousConfig.TransactionBridgeEnabled)
		{
			msdtcConfigProvider.WriteString("TransactionBridge", TransactionBridgeEnabled ? "{EEC5DCCA-05DC-4B46-8AF7-2881C1635AEA}" : string.Empty);
		}
		if (!minimalWrite || previousConfig == null || TraceLevel != previousConfig.TraceLevel)
		{
			wsatConfigProvider.WriteUInt32("DiagnosticTracing", (uint)TraceLevel);
		}
		if (!minimalWrite || previousConfig == null || ActivityTracing != previousConfig.ActivityTracing)
		{
			wsatConfigProvider.WriteUInt32("DiagnosticTracingActivityTracing", ActivityTracing ? 1u : 0u);
		}
		if (!minimalWrite || previousConfig == null || ActivityPropagation != previousConfig.ActivityPropagation)
		{
			wsatConfigProvider.WriteUInt32("DiagnosticTracingPropagateActivity", ActivityPropagation ? 1u : 0u);
		}
		if (!minimalWrite || previousConfig == null || TracePii != previousConfig.TracePii)
		{
			wsatConfigProvider.WriteUInt32("DiagnosticTracingTracePII", TracePii ? 1u : 0u);
		}
		if (!minimalWrite || previousConfig == null || DefaultTimeout != previousConfig.DefaultTimeout)
		{
			wsatConfigProvider.WriteUInt32("DefaultTimeout", DefaultTimeout);
		}
		if (!minimalWrite || previousConfig == null || MaxTimeout != previousConfig.MaxTimeout)
		{
			wsatConfigProvider.WriteUInt32("MaxTimeout", MaxTimeout);
		}
		if (!minimalWrite || previousConfig == null || X509GlobalAcl != previousConfig.X509GlobalAcl)
		{
			wsatConfigProvider.WriteMultiString("X509GlobalAcl", X509GlobalAcl);
		}
		if (!minimalWrite || previousConfig == null || X509Certificate != previousConfig.X509Certificate)
		{
			wsatConfigProvider.WriteString("X509CertificateIdentity", (X509Certificate == null) ? string.Empty : X509Certificate.Thumbprint);
		}
		if (!minimalWrite || previousConfig == null || HttpsPort != previousConfig.HttpsPort)
		{
			wsatConfigProvider.WriteUInt32("HttpsPort", HttpsPort);
		}
		if (!minimalWrite || previousConfig == null || KerberosGlobalAcl != previousConfig.KerberosGlobalAcl)
		{
			wsatConfigProvider.WriteMultiString("KerberosGlobalAcl", KerberosGlobalAcl);
		}
		if (IsClustered || IsLocalMachine)
		{
			wsatConfigProvider.AdjustRegKeyPermission();
		}
	}

	private void UpdateUrlAclReservation()
	{
		if (previousConfig != null)
		{
			WsatServiceAddress wsatServiceAddress = new WsatServiceAddress(previousConfig.HttpsPort);
			wsatServiceAddress.FreeWsatServiceAddress();
		}
		if (TransactionBridgeEnabled)
		{
			WsatServiceAddress wsatServiceAddress = new WsatServiceAddress(HttpsPort);
			wsatServiceAddress.ReserveWsatServiceAddress();
		}
	}

	private void UpdateSSLBinding()
	{
		if (previousConfig != null && previousConfig.X509Certificate != null)
		{
			WsatServiceCertificate wsatServiceCertificate = new WsatServiceCertificate(previousConfig.X509Certificate, previousConfig.HttpsPort);
			wsatServiceCertificate.UnbindSSLCertificate();
		}
		if (TransactionBridgeEnabled && X509Certificate != null)
		{
			WsatServiceCertificate wsatServiceCertificate = new WsatServiceCertificate(X509Certificate, HttpsPort);
			wsatServiceCertificate.BindSSLCertificate();
		}
	}

	private void UpdateFirewallPort()
	{
		FirewallWrapper firewallWrapper = new FirewallWrapper();
		firewallWrapper.RemoveHttpsPort((int)previousConfig.HttpsPort);
		if (TransactionBridgeEnabled)
		{
			firewallWrapper.AddHttpsPort((int)HttpsPort);
		}
	}

	private void UpdatePorts()
	{
		UpdateFirewallPort();
		UpdateUrlAclReservation();
		UpdateSSLBinding();
	}

	public override string ToString()
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(SR.GetString("ConfigNetworkSupport", Utilities.GetEnabledStatusString(TransactionBridgeEnabled)));
		if (TransactionBridgeEnabled)
		{
			stringBuilder.Append(SR.GetString("ConfigHTTPSPort", HttpsPort));
			stringBuilder.Append(SR.GetString("ConfigIdentityCertificate", (X509Certificate == null) ? SR.GetString("ConfigNone") : X509Certificate.Thumbprint));
			stringBuilder.Append(SR.GetString("ConfigKerberosGACL"));
			if (KerberosGlobalAcl != null && KerberosGlobalAcl.Length >= 1)
			{
				int num = 0;
				string[] array = KerberosGlobalAcl;
				foreach (string value in array)
				{
					if (num++ > 0)
					{
						stringBuilder.Append(SR.GetString("ConfigACEPrefix"));
					}
					stringBuilder.AppendLine(value);
				}
			}
			else
			{
				stringBuilder.AppendLine(SR.GetString("ConfigNone"));
			}
			stringBuilder.Append(SR.GetString("ConfigAcceptedCertificates"));
			if (X509GlobalAcl != null && X509GlobalAcl.Length >= 1)
			{
				int num2 = 0;
				string[] x509GlobalAcl = X509GlobalAcl;
				foreach (string value2 in x509GlobalAcl)
				{
					if (num2++ > 0)
					{
						stringBuilder.Append(SR.GetString("ConfigAcceptedCertPrefix"));
					}
					stringBuilder.AppendLine(value2);
				}
			}
			else
			{
				stringBuilder.AppendLine(SR.GetString("ConfigNone"));
			}
			stringBuilder.Append(SR.GetString("ConfigDefaultTimeout", DefaultTimeout));
			stringBuilder.Append(SR.GetString("ConfigMaximumTimeout", MaxTimeout));
			SourceLevels sourceLevels = TraceLevel;
			if (sourceLevels != SourceLevels.All)
			{
				sourceLevels &= ~SourceLevels.ActivityTracing;
			}
			stringBuilder.Append(SR.GetString("ConfigTraceLevel", sourceLevels));
			stringBuilder.Append(SR.GetString("ConfigActivityTracing", Utilities.GetEnabledStatusString(ActivityTracing)));
			stringBuilder.Append(SR.GetString("ConfigActivityProp", Utilities.GetEnabledStatusString(ActivityPropagation)));
			stringBuilder.Append(SR.GetString("ConfigPiiTracing", Utilities.GetEnabledStatusString(TracePii)));
			MsdtcWrapper msdtcWrapper = GetMsdtcWrapper();
			if (!msdtcWrapper.GetNetworkTransactionAccess())
			{
				stringBuilder.Append(Environment.NewLine);
				stringBuilder.Append(SR.GetString("ConfigWarningNetworkDTCAccessIsDisabled"));
			}
		}
		else
		{
			stringBuilder.Append(SR.GetString("ConfigMaximumTimeoutWhenNetworkDisabled", MaxTimeout));
		}
		return stringBuilder.ToString();
	}
}
