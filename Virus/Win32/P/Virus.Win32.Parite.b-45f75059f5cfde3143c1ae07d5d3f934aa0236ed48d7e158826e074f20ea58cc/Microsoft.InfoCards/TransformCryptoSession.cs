using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;

namespace Microsoft.InfoCards;

internal class TransformCryptoSession : CryptoSession
{
	private ICryptoTransform m_icrypto;

	public TransformCryptoSession(Process process, DateTime expiration, WindowsIdentity identity, ICryptoTransform icrypto)
		: base(process, expiration, identity, icrypto, SessionType.Transfrom)
	{
		m_icrypto = icrypto;
	}

	protected override void OnDispose()
	{
		m_icrypto.Dispose();
	}

	protected override void OnWrite(BinaryWriter bwriter)
	{
		bwriter.Write(m_icrypto.InputBlockSize);
		bwriter.Write(m_icrypto.OutputBlockSize);
		bwriter.Write(m_icrypto.CanTransformMultipleBlocks);
		bwriter.Write(m_icrypto.CanReuseTransform);
	}

	public int TransformBlock(byte[] inData, out byte[] outData)
	{
		outData = new byte[m_icrypto.OutputBlockSize];
		return m_icrypto.TransformBlock(inData, 0, inData.Length, outData, 0);
	}

	public byte[] TransformFinalBlock(byte[] inData)
	{
		return m_icrypto.TransformFinalBlock(inData, 0, inData.Length);
	}
}
