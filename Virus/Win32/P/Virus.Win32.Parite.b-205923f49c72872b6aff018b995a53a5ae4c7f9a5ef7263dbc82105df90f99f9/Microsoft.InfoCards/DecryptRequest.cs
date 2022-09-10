using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class DecryptRequest : ClientRequest
{
	private int m_cryptoSession;

	private bool m_useOAEP;

	private byte[] m_encrypted;

	private byte[] m_decrypted;

	public DecryptRequest(Process callingProcess, WindowsIdentity callingIdentity, IntPtr rpcHandle, Stream inArgs, Stream outArgs)
		: base(callingProcess, callingIdentity, rpcHandle, inArgs, outArgs)
	{
		m_cryptoSession = 0;
		m_useOAEP = false;
		m_encrypted = null;
		m_decrypted = null;
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs);
		m_cryptoSession = binaryReader.ReadInt32();
		m_useOAEP = binaryReader.ReadBoolean();
		int count = binaryReader.ReadInt32();
		m_encrypted = binaryReader.ReadBytes(count);
		InfoCardTrace.ThrowInvalidArgumentConditional(0 == m_cryptoSession, "cryptoSession");
		InfoCardTrace.ThrowInvalidArgumentConditional(m_encrypted == null || 0 == m_encrypted.Length, "encrypted");
	}

	protected override void OnProcess()
	{
		AsymmetricCryptoSession asymmetricCryptoSession = (AsymmetricCryptoSession)CryptoSession.Find(m_cryptoSession, base.CallerPid, RequestorIdentity.User);
		m_decrypted = asymmetricCryptoSession.Decrypt(m_useOAEP, m_encrypted);
	}

	protected override void OnMarshalOutArgs()
	{
		try
		{
			BinaryWriter writer = new BinaryWriter(base.OutArgs);
			Utility.SerializeBytes(writer, m_decrypted);
		}
		finally
		{
			Array.Clear(m_decrypted, 0, m_decrypted.Length);
		}
	}
}
