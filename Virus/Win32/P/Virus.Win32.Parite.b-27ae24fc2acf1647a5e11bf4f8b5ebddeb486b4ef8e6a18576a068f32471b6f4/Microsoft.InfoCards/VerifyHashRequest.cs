using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using System.Text;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class VerifyHashRequest : ClientRequest
{
	private int m_cryptoSession;

	private byte[] m_hash;

	private string m_hashAlgorithmOid;

	private byte[] m_signature;

	private bool m_verified;

	public VerifyHashRequest(Process callingProcess, WindowsIdentity callingIdentity, IntPtr rpcHandle, Stream inArgs, Stream outArgs)
		: base(callingProcess, callingIdentity, rpcHandle, inArgs, outArgs)
	{
		m_cryptoSession = 0;
		m_hash = null;
		m_hashAlgorithmOid = null;
		m_signature = null;
		m_verified = false;
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs, Encoding.Unicode);
		m_cryptoSession = binaryReader.ReadInt32();
		int count = binaryReader.ReadInt32();
		m_hash = binaryReader.ReadBytes(count);
		count = binaryReader.ReadInt32();
		m_signature = binaryReader.ReadBytes(count);
		m_hashAlgorithmOid = Utility.DeserializeString(binaryReader);
		InfoCardTrace.ThrowInvalidArgumentConditional(0 == m_cryptoSession, "cryptoSession");
		InfoCardTrace.ThrowInvalidArgumentConditional(m_hash == null || 0 == m_hash.Length, "hash");
		InfoCardTrace.ThrowInvalidArgumentConditional(m_signature == null || 0 == m_signature.Length, "signature");
		InfoCardTrace.ThrowInvalidArgumentConditional(null == m_hashAlgorithmOid, "hashAlgorithmOid");
	}

	protected override void OnProcess()
	{
		AsymmetricCryptoSession asymmetricCryptoSession = (AsymmetricCryptoSession)CryptoSession.Find(m_cryptoSession, base.CallerPid, RequestorIdentity.User);
		m_verified = asymmetricCryptoSession.VerifyHash(m_hash, m_hashAlgorithmOid, m_signature);
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter binaryWriter = new BinaryWriter(base.OutArgs, Encoding.Unicode);
		binaryWriter.Write(m_verified);
		binaryWriter.Flush();
	}
}
