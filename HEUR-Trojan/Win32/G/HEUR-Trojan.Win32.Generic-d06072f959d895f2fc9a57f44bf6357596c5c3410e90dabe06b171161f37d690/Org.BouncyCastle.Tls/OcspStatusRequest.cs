using System.Collections;
using System.IO;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

public sealed class OcspStatusRequest
{
	private readonly IList m_responderIDList;

	private readonly X509Extensions m_requestExtensions;

	public IList ResponderIDList => m_responderIDList;

	public X509Extensions RequestExtensions => m_requestExtensions;

	public OcspStatusRequest(IList responderIDList, X509Extensions requestExtensions)
	{
		m_responderIDList = responderIDList;
		m_requestExtensions = requestExtensions;
	}

	public void Encode(Stream output)
	{
		if (m_responderIDList != null && m_responderIDList.Count >= 1)
		{
			MemoryStream memoryStream = new MemoryStream();
			foreach (ResponderID responderID in m_responderIDList)
			{
				TlsUtilities.WriteOpaque16(responderID.GetEncoded("DER"), memoryStream);
			}
			TlsUtilities.CheckUint16(memoryStream.Length);
			TlsUtilities.WriteUint16((int)memoryStream.Length, output);
			Streams.WriteBufTo(memoryStream, output);
		}
		else
		{
			TlsUtilities.WriteUint16(0, output);
		}
		if (m_requestExtensions == null)
		{
			TlsUtilities.WriteUint16(0, output);
			return;
		}
		byte[] encoded = m_requestExtensions.GetEncoded("DER");
		TlsUtilities.CheckUint16(encoded.Length);
		TlsUtilities.WriteUint16(encoded.Length, output);
		output.Write(encoded, 0, encoded.Length);
	}

	public static OcspStatusRequest Parse(Stream input)
	{
		IList list = Platform.CreateArrayList();
		byte[] array = TlsUtilities.ReadOpaque16(input);
		if (array.Length != 0)
		{
			MemoryStream memoryStream = new MemoryStream(array, writable: false);
			do
			{
				ResponderID instance = ResponderID.GetInstance(TlsUtilities.ReadDerObject(TlsUtilities.ReadOpaque16(memoryStream, 1)));
				list.Add(instance);
			}
			while (memoryStream.Position < memoryStream.Length);
		}
		X509Extensions requestExtensions = null;
		byte[] array2 = TlsUtilities.ReadOpaque16(input);
		if (array2.Length != 0)
		{
			requestExtensions = X509Extensions.GetInstance(TlsUtilities.ReadDerObject(array2));
		}
		return new OcspStatusRequest(list, requestExtensions);
	}
}
