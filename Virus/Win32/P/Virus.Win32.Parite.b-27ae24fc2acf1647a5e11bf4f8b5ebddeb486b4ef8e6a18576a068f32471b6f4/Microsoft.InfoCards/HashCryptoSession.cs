using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;

namespace Microsoft.InfoCards;

internal class HashCryptoSession : CryptoSession
{
	private KeyedHashAlgorithm m_hash;

	public HashCryptoSession(Process process, DateTime expiration, WindowsIdentity identity, KeyedHashAlgorithm hash)
		: base(process, expiration, identity, hash, SessionType.Hash)
	{
		m_hash = hash;
	}

	protected override void OnDispose()
	{
		m_hash.Clear();
		((IDisposable)m_hash).Dispose();
		m_hash = null;
	}

	protected override void OnWrite(BinaryWriter bwriter)
	{
		bwriter.Write(m_hash.HashSize);
		bwriter.Write(m_hash.InputBlockSize);
		bwriter.Write(m_hash.OutputBlockSize);
		bwriter.Write(m_hash.CanTransformMultipleBlocks);
		bwriter.Write(m_hash.CanReuseTransform);
	}

	public void HashCore(byte[] inData)
	{
		m_hash.TransformBlock(inData, 0, inData.Length, null, 0);
	}

	public byte[] HashFinal(byte[] inData)
	{
		try
		{
			m_hash.TransformFinalBlock(inData, 0, inData.Length);
		}
		finally
		{
			m_hash.Initialize();
		}
		return m_hash.Hash;
	}
}
