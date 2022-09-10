using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class EncryptRequest : ClientRequest
{
	private int m_cryptoSession;

	private bool m_useOAEP;

	private byte[] m_cleartext;

	private byte[] m_encrypted;

	public EncryptRequest(Process callingProcess, WindowsIdentity callingIdentity, IntPtr rpcHandle, Stream inArgs, Stream outArgs)
		: base(callingProcess, callingIdentity, rpcHandle, inArgs, outArgs)
	{
		m_cryptoSession = 0;
		m_useOAEP = false;
		m_cleartext = null;
		m_encrypted = null;
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs);
		m_cryptoSession = binaryReader.ReadInt32();
		m_useOAEP = binaryReader.ReadBoolean();
		int count = binaryReader.ReadInt32();
		m_cleartext = binaryReader.ReadBytes(count);
		InfoCardTrace.ThrowInvalidArgumentConditional(0 == m_cryptoSession, "cryptoSession");
		InfoCardTrace.ThrowInvalidArgumentConditional(m_cleartext == null || 0 == m_cleartext.Length, "clearText");
	}

	protected override void OnProcess()
	{
		try
		{
			AsymmetricCryptoSession asymmetricCryptoSession = (AsymmetricCryptoSession)CryptoSession.Find(m_cryptoSession, base.CallerPid, RequestorIdentity.User);
			m_encrypted = asymmetricCryptoSession.Encrypt(m_useOAEP, m_cleartext);
		}
		finally
		{
			Array.Clear(m_cleartext, 0, m_cleartext.Length);
		}
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter writer = new BinaryWriter(base.OutArgs);
		Utility.SerializeBytes(writer, m_encrypted);
	}
}
