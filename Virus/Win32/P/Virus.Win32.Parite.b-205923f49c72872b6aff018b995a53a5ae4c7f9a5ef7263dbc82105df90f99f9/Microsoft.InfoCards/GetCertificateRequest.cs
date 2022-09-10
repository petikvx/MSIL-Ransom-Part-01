using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class GetCertificateRequest : UIAgentRequest
{
	private string m_recipientIdentifier;

	private X509Certificate2 m_certificate;

	public GetCertificateRequest(IntPtr rpcHandle, Stream inArgs, Stream outArgs, ClientUIRequest parent)
		: base(rpcHandle, inArgs, outArgs, parent)
	{
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader reader = new BinaryReader(base.InArgs, Encoding.Unicode);
		m_recipientIdentifier = Utility.DeserializeString(reader);
	}

	protected override void OnProcess()
	{
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_0033: Expected O, but got Unknown
		m_certificate = base.ParentRequest.CertCacheFind(m_recipientIdentifier);
		if (m_certificate == null)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)new InfoCardArgumentException(SR.GetString("NoCachedCertificateForRecipient")));
		}
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter writer = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		Utility.SerializeBytes(writer, m_certificate.GetRawCertData());
	}
}
