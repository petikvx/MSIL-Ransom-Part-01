using System;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class InfoCardX509Validator : X509CertificateValidator
{
	private static InfoCardOfflineChainTrustValidator s_identityMachineChainTrustValidator;

	private static InfoCardOfflineChainTrustValidator s_identityUserChainTrustValidator;

	private static X509CertificateValidator s_identityPeerTrustValidator;

	private static X509Certificate2Collection m_supportingCertificates;

	static InfoCardX509Validator()
	{
		s_identityMachineChainTrustValidator = new InfoCardOfflineChainTrustValidator(useMachineContext: true);
		s_identityUserChainTrustValidator = new InfoCardOfflineChainTrustValidator(useMachineContext: false);
		s_identityPeerTrustValidator = X509CertificateValidator.get_PeerTrust();
	}

	private InfoCardX509Validator(X509Certificate2Collection supportingCerts)
	{
		m_supportingCertificates = supportingCerts;
	}

	public static X509CertificateValidator Create(X509Certificate2Collection supportingCerts)
	{
		return (X509CertificateValidator)(object)new InfoCardX509Validator(supportingCerts);
	}

	public static void ValidateChainOrPeer(X509Certificate2 certificate, X509Certificate2Collection supportingRecipientCerts, out bool chainTrustPassed)
	{
		Validate(certificate, supportingRecipientCerts, out chainTrustPassed);
	}

	public override void Validate(X509Certificate2 certificate)
	{
		Validate(certificate, m_supportingCertificates, out var _);
	}

	public static bool ValidateChainOrPeerCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
	{
		//IL_0044: Expected O, but got Unknown
		bool chainTrustPassed = false;
		if ((sslPolicyErrors & SslPolicyErrors.RemoteCertificateNameMismatch) == 0 && (sslPolicyErrors & SslPolicyErrors.RemoteCertificateNotAvailable) == 0)
		{
			InfoCardTrace.Assert(certificate != null && null != chain, "We should have returned false for SslPolicyErrors.RemoteCertificateNotAvailable", new object[0]);
			try
			{
				ValidateChainOrPeer(new X509Certificate2(certificate), chain.ChainPolicy.ExtraStore, out chainTrustPassed);
			}
			catch (SecurityTokenValidationException val)
			{
				SecurityTokenValidationException inner = val;
				InfoCardTrace.TraceAndLogException((Exception)(object)new IdentityValidationException(SR.GetString("RecipientCertificateNotValid"), (Exception)(object)inner));
				return false;
			}
			return true;
		}
		return false;
	}

	private static void Validate(X509Certificate2 certificate, X509Certificate2Collection supportingRecipientCerts, out bool chainTrustPassed)
	{
		//IL_0018: Expected O, but got Unknown
		//IL_002e: Expected O, but got Unknown
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Expected O, but got Unknown
		chainTrustPassed = false;
		string text = string.Empty;
		try
		{
			ValidateChain(certificate, supportingRecipientCerts, out var _);
			chainTrustPassed = true;
		}
		catch (SecurityTokenValidationException val)
		{
			SecurityTokenValidationException val2 = val;
			text = ((Exception)(object)val2).Message;
		}
		if (!chainTrustPassed)
		{
			try
			{
				ValidatePeer(certificate);
			}
			catch (SecurityTokenValidationException val3)
			{
				SecurityTokenValidationException val4 = val3;
				throw InfoCardTrace.ThrowHelperError((Exception)new SecurityTokenValidationException(SR.GetString("X509ChainFailAndPeerTrustFail", new object[2]
				{
					text,
					((Exception)(object)val4).Message
				})));
			}
		}
	}

	public static void ValidateChain(X509Certificate2 certificate, X509Certificate2Collection supportingCerts, out X509Chain chain)
	{
		try
		{
			s_identityMachineChainTrustValidator.Validate(certificate, supportingCerts, out chain);
		}
		catch (SecurityTokenValidationException)
		{
			s_identityUserChainTrustValidator.Validate(certificate, supportingCerts, out chain);
		}
	}

	public static bool TryValidateChain(X509Certificate2 certificate, X509Certificate2Collection supportingCerts)
	{
		bool result = true;
		try
		{
			ValidateChain(certificate, supportingCerts, out var _);
			return result;
		}
		catch (SecurityTokenValidationException)
		{
			return false;
		}
	}

	public static void ValidatePeer(X509Certificate2 certificate)
	{
		s_identityPeerTrustValidator.Validate(certificate);
	}
}
