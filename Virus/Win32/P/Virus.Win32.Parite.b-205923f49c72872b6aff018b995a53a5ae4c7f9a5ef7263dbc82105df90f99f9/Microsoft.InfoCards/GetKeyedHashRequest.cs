using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class GetKeyedHashRequest : ClientRequest
{
	private int m_cryptoSession;

	private HashCryptoSession m_hashSession;

	public GetKeyedHashRequest(Process callingProcess, WindowsIdentity callingIdentity, IntPtr rpcHandle, Stream inArgs, Stream outArgs)
		: base(callingProcess, callingIdentity, rpcHandle, inArgs, outArgs)
	{
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_cryptoSession = binaryReader.ReadInt32();
		InfoCardTrace.ThrowInvalidArgumentConditional(0 == m_cryptoSession, "cryptoSession");
	}

	protected override void OnProcess()
	{
		SymmetricCryptoSession symmetricCryptoSession = (SymmetricCryptoSession)CryptoSession.Find(m_cryptoSession, base.CallerPid, RequestorIdentity.User);
		m_hashSession = symmetricCryptoSession.GetKeyedHash();
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter binaryWriter = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		m_hashSession.Write(binaryWriter);
		binaryWriter.Flush();
	}
}
