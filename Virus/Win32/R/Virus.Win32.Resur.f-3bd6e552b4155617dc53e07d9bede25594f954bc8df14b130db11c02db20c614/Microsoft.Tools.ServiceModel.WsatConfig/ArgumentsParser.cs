using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Security.Principal;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal class ArgumentsParser
{
	private abstract class ParserBase
	{
		protected abstract void DoParse(string value, WsatConfiguration config);

		public void Parse(string value, WsatConfiguration config)
		{
			DoParse(value, config);
		}
	}

	private class NetworkParser : ParserBase
	{
		protected override void DoParse(string value, WsatConfiguration config)
		{
			if (!string.IsNullOrEmpty(value))
			{
				if (Utilities.SafeCompare(value, "enable"))
				{
					QfeChecker.CheckQfe();
					config.TransactionBridgeEnabled = true;
					return;
				}
				if (Utilities.SafeCompare(value, "disable"))
				{
					config.TransactionBridgeEnabled = false;
					return;
				}
			}
			throw new WsatAdminException(WsatAdminErrorCode.INVALID_NETWORK_ARGUMENT, SR.GetString("ErrorNetworkArgument"));
		}
	}

	private class PortParser : ParserBase
	{
		protected override void DoParse(string value, WsatConfiguration config)
		{
			if (string.IsNullOrEmpty(value) || !ushort.TryParse(value, out var result))
			{
				throw new WsatAdminException(WsatAdminErrorCode.INVALID_HTTPS_PORT, SR.GetString("ErrorHttpsPortRange"));
			}
			config.HttpsPort = result;
		}
	}

	private class MaxTimeoutParser : ParserBase
	{
		protected override void DoParse(string value, WsatConfiguration config)
		{
			if (string.IsNullOrEmpty(value) || !ushort.TryParse(value, out var result))
			{
				throw new WsatAdminException(WsatAdminErrorCode.INVALID_MAXTIMEOUT_ARGUMENT, SR.GetString("ErrorMaximumTimeoutRange"));
			}
			config.MaxTimeout = result;
		}
	}

	private class DefaultTimeoutParser : ParserBase
	{
		protected override void DoParse(string value, WsatConfiguration config)
		{
			if (string.IsNullOrEmpty(value) || !ushort.TryParse(value, out var result))
			{
				throw new WsatAdminException(WsatAdminErrorCode.INVALID_DEFTIMEOUT_ARGUMENT, SR.GetString("ErrorDefaultTimeoutRange"));
			}
			config.DefaultTimeout = result;
		}
	}

	private class TraceLevelParser : ParserBase
	{
		protected override void DoParse(string value, WsatConfiguration config)
		{
			if (!string.IsNullOrEmpty(value))
			{
				if (Utilities.ParseSourceLevel(value, out var level))
				{
					config.TraceLevel = level;
					return;
				}
				if (uint.TryParse(value, out var result))
				{
					config.TraceLevel = (SourceLevels)result;
					return;
				}
			}
			throw new WsatAdminException(WsatAdminErrorCode.INVALID_TRACELEVEL_ARGUMENT, SR.GetString("ErrorTraceLevelArgument"));
		}
	}

	private class TraceActivityParser : ParserBase
	{
		protected override void DoParse(string value, WsatConfiguration config)
		{
			if (!string.IsNullOrEmpty(value))
			{
				if (Utilities.SafeCompare(value, "enable"))
				{
					config.ActivityTracing = true;
					return;
				}
				if (Utilities.SafeCompare(value, "disable"))
				{
					config.ActivityTracing = false;
					return;
				}
			}
			throw new WsatAdminException(WsatAdminErrorCode.INVALID_TRACE_ACTIVITY_ARGUMENT, SR.GetString("ErrorTraceActivityArgument"));
		}
	}

	private class TracePropagationParser : ParserBase
	{
		protected override void DoParse(string value, WsatConfiguration config)
		{
			if (!string.IsNullOrEmpty(value))
			{
				if (Utilities.SafeCompare(value, "enable"))
				{
					config.ActivityPropagation = true;
					return;
				}
				if (Utilities.SafeCompare(value, "disable"))
				{
					config.ActivityPropagation = false;
					return;
				}
			}
			throw new WsatAdminException(WsatAdminErrorCode.INVALID_TRACE_PROPAGATION_ARGUMENT, SR.GetString("ErrorTracePropArgument"));
		}
	}

	private class TracePiiParser : ParserBase
	{
		protected override void DoParse(string value, WsatConfiguration config)
		{
			if (!string.IsNullOrEmpty(value))
			{
				if (Utilities.SafeCompare(value, "enable"))
				{
					config.TracePii = true;
					return;
				}
				if (Utilities.SafeCompare(value, "disable"))
				{
					config.TracePii = false;
					return;
				}
			}
			throw new WsatAdminException(WsatAdminErrorCode.INVALID_TRACE_PII_ARGUMENT, SR.GetString("ErrorTracePiiArgument"));
		}
	}

	private class EndpointCertificateParser : ParserBase
	{
		protected override void DoParse(string value, WsatConfiguration config)
		{
			if (!string.IsNullOrEmpty(value))
			{
				if (Utilities.SafeCompare(value, "machine"))
				{
					config.X509Certificate = CertificateManager.GetMachineIdentityCertificate();
					if (config.X509Certificate == null)
					{
						throw new WsatAdminException(WsatAdminErrorCode.CANNOT_FIND_MACHINE_CERTIFICATE, SR.GetString("ErrorCannotFindMachineCertificate"));
					}
				}
				else if (value.IndexOf('\\') >= 0)
				{
					config.X509Certificate = CertificateManager.GetCertificateFromIssuerAndSubjectName(value);
				}
				else
				{
					config.X509Certificate = CertificateManager.GetCertificateFromThumbprint(value, string.Empty);
				}
				if (config.X509Certificate != null)
				{
					return;
				}
			}
			throw new WsatAdminException(WsatAdminErrorCode.INVALID_OR_MISSING_SSL_CERTIFICATE, SR.GetString("ErrorMissingSSLCert"));
		}
	}

	private class AccountsParser : ParserBase
	{
		protected override void DoParse(string value, WsatConfiguration config)
		{
			config.KerberosGlobalAcl = value.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			List<string> list = new List<string>(config.KerberosGlobalAcl);
			List<string> list2 = new List<string>();
			foreach (string item in list)
			{
				string text = item.Trim();
				if (!string.IsNullOrEmpty(text))
				{
					if (!IsValidAccount(text))
					{
						throw new WsatAdminException(WsatAdminErrorCode.INVALID_ACCOUNT, SR.GetString("ErrorAccountArgument", text));
					}
					list2.Add(text);
				}
			}
			config.KerberosGlobalAcl = list2.ToArray();
		}

		private bool IsValidAccount(string account)
		{
			bool result = false;
			try
			{
				NTAccount nTAccount = new NTAccount(account);
				IdentityReference identityReference = nTAccount.Translate(typeof(SecurityIdentifier));
				result = identityReference != null;
				return result;
			}
			catch (IdentityNotMappedException)
			{
				return result;
			}
			catch (Exception e)
			{
				if (Utilities.IsCriticalException(e))
				{
					throw;
				}
				return result;
			}
		}
	}

	private class ClusterRemoteNodeParser : ParserBase
	{
		protected override void DoParse(string value, WsatConfiguration config)
		{
			if (!string.IsNullOrEmpty(value))
			{
				if (Utilities.SafeCompare(value, "enable"))
				{
					config.IsClusterRemoteNode = true;
					return;
				}
				if (Utilities.SafeCompare(value, "disable"))
				{
					config.IsClusterRemoteNode = false;
					return;
				}
			}
			throw new WsatAdminException(WsatAdminErrorCode.INVALID_CLUSTER_REMOTE_NODE_ARGUMENT, SR.GetString("ErrorClusterRemoteNodeArgument"));
		}
	}

	private class AccountsCertificatesParser : ParserBase
	{
		protected override void DoParse(string value, WsatConfiguration config)
		{
			config.X509GlobalAcl = value.Split(new char[1] { ',' }, StringSplitOptions.RemoveEmptyEntries);
			int num = 0;
			string[] x509GlobalAcl = config.X509GlobalAcl;
			int num2 = 0;
			while (true)
			{
				if (num2 >= x509GlobalAcl.Length)
				{
					return;
				}
				string text = x509GlobalAcl[num2];
				if (!string.IsNullOrEmpty(text))
				{
					X509Certificate2 x509Certificate = null;
					x509Certificate = ((text.IndexOf('\\') < 0) ? CertificateManager.GetCertificateFromThumbprint(text, string.Empty) : CertificateManager.GetCertificateFromIssuerAndSubjectName(text));
					if (x509Certificate == null)
					{
						break;
					}
					config.X509GlobalAcl[num] = x509Certificate.Thumbprint;
				}
				num++;
				num2++;
			}
			throw new WsatAdminException(WsatAdminErrorCode.INVALID_OR_MISSING_CLIENT_CERTIFICATE, SR.GetString("ErrorInvalidOrMissingClientCert"));
		}
	}

	private Dictionary<string, ParserBase> parsersTable = new Dictionary<string, ParserBase>();

	private Dictionary<string, string> optionsLookupTable = new Dictionary<string, string>();

	private Dictionary<string, int> optionsHitCount = new Dictionary<string, int>();

	private WsatConfiguration config;

	public ArgumentsParser(WsatConfiguration config)
	{
		this.config = config;
		InitializeParsers();
	}

	public bool ParseOptionAndArgument(string optionAndArgument)
	{
		string value;
		string text = ExtractOption(optionAndArgument, out value);
		if (!string.IsNullOrEmpty(text) && optionsLookupTable.ContainsKey(text))
		{
			string text2 = optionsLookupTable[text];
			ParserBase parserBase = parsersTable[text2];
			parserBase.Parse(value, config);
			UpdateOptionHitCount(text2);
			return true;
		}
		return false;
	}

	public void ValidateArgumentsThrow()
	{
		if (optionsHitCount.Count < 1)
		{
			return;
		}
		foreach (string key in optionsHitCount.Keys)
		{
			if (optionsHitCount[key] > 1)
			{
				throw new WsatAdminException(WsatAdminErrorCode.DUPLICATE_OPTION, SR.GetString("ErrorDuplicateOption", key));
			}
		}
		if (!config.TransactionBridgeEnabled)
		{
			int num = 0;
			if (optionsHitCount.ContainsKey("network"))
			{
				num++;
			}
			if (optionsHitCount.ContainsKey("clusterRemoteNode"))
			{
				num++;
			}
			if (optionsHitCount.ContainsKey("restart"))
			{
				num++;
			}
			if (optionsHitCount.Count > num)
			{
				throw new WsatAdminException(WsatAdminErrorCode.CANNOT_UPDATE_SETTINGS_WHEN_NETWORK_IS_DISABLED, SR.GetString("ErrorUpdateSettingsWhenNetworkIsDisabled"));
			}
		}
	}

	private void UpdateOptionHitCount(string option)
	{
		int value = 0;
		if (optionsHitCount.TryGetValue(option, out value))
		{
			optionsHitCount[option] = value + 1;
		}
		else
		{
			optionsHitCount.Add(option, 1);
		}
	}

	public static string ExtractOption(string arg, out string value)
	{
		value = null;
		if (!string.IsNullOrEmpty(arg))
		{
			int num = arg.IndexOf(':');
			if (num != -1)
			{
				value = arg.Substring(num + 1);
				return arg.Substring(0, num).Trim().ToLowerInvariant();
			}
		}
		return string.Empty;
	}

	private void InitializeParsers()
	{
		AddOptionParserPair("network", new NetworkParser());
		AddOptionParserPair("port", new PortParser());
		AddOptionParserPair("maxTimeout", new MaxTimeoutParser());
		AddOptionParserPair("timeout", new DefaultTimeoutParser());
		AddOptionParserPair("traceLevel", new TraceLevelParser());
		AddOptionParserPair("traceActivity", new TraceActivityParser());
		AddOptionParserPair("traceProp", new TracePropagationParser());
		AddOptionParserPair("tracePII", new TracePiiParser());
		AddOptionParserPair("endpointCert", new EndpointCertificateParser());
		AddOptionParserPair("accounts", new AccountsParser());
		AddOptionParserPair("clusterRemoteNode", new ClusterRemoteNodeParser());
		AddOptionParserPair("accountsCerts", new AccountsCertificatesParser());
	}

	private void AddOptionParserPair(string standardOption, ParserBase parser)
	{
		optionsLookupTable.Add(standardOption.ToLowerInvariant(), standardOption);
		parsersTable.Add(standardOption, parser);
	}
}
