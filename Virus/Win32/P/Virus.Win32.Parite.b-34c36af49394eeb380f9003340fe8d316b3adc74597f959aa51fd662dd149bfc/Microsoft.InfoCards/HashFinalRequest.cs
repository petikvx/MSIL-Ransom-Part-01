using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class HashFinalRequest : ClientRequest
{
	private int m_cryptoSession;

	private byte[] m_inBlock;

	private byte[] m_outBlock;

	public HashFinalRequest(Process callingProcess, WindowsIdentity callingIdentity, IntPtr rpcHandle, Stream inArgs, Stream outArgs)
		: base(callingProcess, callingIdentity, rpcHandle, inArgs, outArgs)
	{
	}

	protected override void OnMarshalInArgs()
	{
		BinaryReader binaryReader = new InfoCardBinaryReader(base.InArgs);
		m_cryptoSession = binaryReader.ReadInt32();
		int count = binaryReader.ReadInt32();
		m_inBlock = binaryReader.ReadBytes(count);
		InfoCardTrace.ThrowInvalidArgumentConditional(0 == m_cryptoSession, "cryptoSession");
	}

	protected override void OnProcess()
	{
		try
		{
			HashCryptoSession hashCryptoSession = (HashCryptoSession)CryptoSession.Find(m_cryptoSession, base.CallerPid, RequestorIdentity.User);
			m_outBlock = hashCryptoSession.HashFinal(m_inBlock);
		}
		finally
		{
			Array.Clear(m_inBlock, 0, m_inBlock.Length);
		}
	}

	protected override void OnMarshalOutArgs()
	{
		BinaryWriter writer = new BinaryWriter(base.OutArgs);
		Utility.SerializeBytes(writer, m_outBlock);
	}
}
