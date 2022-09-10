using System;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class InfoCardOfflineChainTrustValidator : X509CertificateValidator
{
	private bool m_useMachineContext;

	public InfoCardOfflineChainTrustValidator(bool useMachineContext)
	{
		m_useMachineContext = useMachineContext;
	}

	public override void Validate(X509Certificate2 certificate)
	{
		Validate(certificate, null, out var chain);
		chain = null;
	}

	public void Validate(X509Certificate2 certificate, X509Certificate2Collection supportingCerts, out X509Chain chain)
	{
		//IL_008f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		if (certificate == null)
		{
			throw InfoCardTrace.ThrowHelperArgumentNull("certificate");
		}
		chain = new X509Chain(m_useMachineContext);
		if (supportingCerts != null)
		{
			chain.ChainPolicy.ExtraStore.AddRange(supportingCerts);
		}
		chain.ChainPolicy.RevocationFlag = X509RevocationFlag.ExcludeRoot;
		chain.ChainPolicy.RevocationMode = X509RevocationMode.Offline;
		chain.ChainPolicy.VerificationFlags = X509VerificationFlags.IgnoreEndRevocationUnknown | X509VerificationFlags.IgnoreCtlSignerRevocationUnknown | X509VerificationFlags.IgnoreCertificateAuthorityRevocationUnknown | X509VerificationFlags.IgnoreRootRevocationUnknown;
		if (!chain.Build(certificate))
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new SecurityTokenValidationException(SR.GetString("X509ChainBuildFail", new object[2]
			{
				GetCertificateId(certificate),
				GetChainStatusInformation(chain.ChainStatus)
			})));
		}
	}

	internal static string GetCertificateId(X509Certificate2 certificate)
	{
		StringBuilder stringBuilder = new StringBuilder(256);
		AppendCertificateIdentityName(stringBuilder, certificate);
		return stringBuilder.ToString();
	}

	private static string GetChainStatusInformation(X509ChainStatus[] chainStatus)
	{
		if (chainStatus != null)
		{
			StringBuilder stringBuilder = new StringBuilder(256);
			for (int i = 0; i < chainStatus.Length; i++)
			{
				if (X509ChainStatusFlags.RevocationStatusUnknown != chainStatus[i].Status && X509ChainStatusFlags.OfflineRevocation != chainStatus[i].Status)
				{
					stringBuilder.Append(chainStatus[i].StatusInformation);
					stringBuilder.Append(" ");
				}
			}
			return stringBuilder.ToString();
		}
		return string.Empty;
	}

	private static void AppendCertificateIdentityName(StringBuilder str, X509Certificate2 certificate)
	{
		string text = certificate.SubjectName.Name;
		if (string.IsNullOrEmpty(text))
		{
			text = certificate.GetNameInfo(X509NameType.DnsName, forIssuer: false);
			if (string.IsNullOrEmpty(text))
			{
				text = certificate.GetNameInfo(X509NameType.SimpleName, forIssuer: false);
				if (string.IsNullOrEmpty(text))
				{
					text = certificate.GetNameInfo(X509NameType.EmailName, forIssuer: false);
					if (string.IsNullOrEmpty(text))
					{
						text = certificate.GetNameInfo(X509NameType.UpnName, forIssuer: false);
					}
				}
			}
		}
		str.Append(string.IsNullOrEmpty(text) ? "<x509>" : text);
		str.Append("; ");
		str.Append(certificate.Thumbprint);
	}
}
