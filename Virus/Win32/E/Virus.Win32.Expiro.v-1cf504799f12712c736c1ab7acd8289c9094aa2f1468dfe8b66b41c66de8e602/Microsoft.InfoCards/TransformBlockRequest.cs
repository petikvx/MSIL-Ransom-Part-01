using System;
using System.Diagnostics;
using System.IO;
using System.Security.Principal;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class TransformBlockRequest : ClientRequest
{
	private int m_cryptoSession;

	private byte[] m_inBlock;

	private byte[] m_outBlock;

	private int m_outBlockSize;

	public TransformBlockRequest(Process callingProcess, WindowsIdentity callingIdentity, IntPtr rpcHandle, Stream inArgs, Stream outArgs)
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
		InfoCardTrace.ThrowInvalidArgumentConditional(m_inBlock == null || 0 == m_inBlock.Length, "inBlock");
	}

	protected override void OnProcess()
	{
		try
		{
			TransformCryptoSession transformCryptoSession = (TransformCryptoSession)CryptoSession.Find(m_cryptoSession, base.CallerPid, RequestorIdentity.User);
			m_outBlockSize = transformCryptoSession.TransformBlock(m_inBlock, out m_outBlock);
		}
		finally
		{
			Array.Clear(m_inBlock, 0, m_inBlock.Length);
		}
	}

	protected override void OnMarshalOutArgs()
	{
		InfoCardTrace.ThrowInvalidArgumentConditional(null == base.OutArgs, "OutArgs");
		InfoCardTrace.ThrowInvalidArgumentConditional(null == m_outBlock, "outBlock");
		BinaryWriter writer = new BinaryWriter(base.OutArgs);
		Utility.SerializeBytes(writer, m_outBlock, 0, m_outBlockSize);
	}
}
