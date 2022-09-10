using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Text;

namespace Microsoft.InfoCards;

internal class SignHashRequest : ClientRequest
{
	private int m_sessionId;

	private byte[] m_hash;

	private string m_hashAlgOid;

	private byte[] m_sig;

	public SignHashRequest(Process callingProcess, WindowsIdentity callingIdentity, IntPtr rpcHandle, Stream inArgs, Stream outArgs)
		: base(callingProcess, callingIdentity, rpcHandle, inArgs, outArgs)
	{
		m_sig = null;
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_sessionId = binaryReader.ReadInt32();
		int count = binaryReader.ReadInt32();
		m_hash = binaryReader.ReadBytes(count);
		m_hashAlgOid = Utility.DeserializeString(binaryReader);
	}

	protected override void OnProcess()
	{
		AsymmetricCryptoSession asymmetricCryptoSession = (AsymmetricCryptoSession)CryptoSession.Find(m_sessionId, base.CallerPid, RequestorIdentity.User);
		m_sig = asymmetricCryptoSession.SignHash(m_hash, m_hashAlgOid);
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter binaryWriter = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		binaryWriter.Write(m_sig.Length);
		binaryWriter.Write(m_sig);
	}
}
