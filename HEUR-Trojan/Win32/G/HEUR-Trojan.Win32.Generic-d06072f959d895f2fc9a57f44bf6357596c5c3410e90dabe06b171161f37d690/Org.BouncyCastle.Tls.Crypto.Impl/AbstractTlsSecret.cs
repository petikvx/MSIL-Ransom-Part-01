using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl;

public abstract class AbstractTlsSecret : TlsSecret
{
	protected byte[] m_data;

	protected abstract AbstractTlsCrypto Crypto { get; }

	protected static byte[] CopyData(AbstractTlsSecret other)
	{
		return other.CopyData();
	}

	protected AbstractTlsSecret(byte[] data)
	{
		m_data = data;
	}

	protected virtual void CheckAlive()
	{
		if (m_data == null)
		{
			throw new InvalidOperationException("Secret has already been extracted or destroyed");
		}
	}

	public virtual byte[] CalculateHmac(int cryptoHashAlgorithm, byte[] buf, int off, int len)
	{
		lock (this)
		{
			CheckAlive();
			TlsHmac tlsHmac = Crypto.CreateHmacForHash(cryptoHashAlgorithm);
			tlsHmac.SetKey(m_data, 0, m_data.Length);
			tlsHmac.Update(buf, off, len);
			return tlsHmac.CalculateMac();
		}
	}

	public abstract TlsSecret DeriveUsingPrf(int prfAlgorithm, string label, byte[] seed, int length);

	public virtual void Destroy()
	{
		lock (this)
		{
			if (m_data != null)
			{
				Array.Clear(m_data, 0, m_data.Length);
				m_data = null;
			}
		}
	}

	public virtual byte[] Encrypt(TlsEncryptor encryptor)
	{
		lock (this)
		{
			CheckAlive();
			return encryptor.Encrypt(m_data, 0, m_data.Length);
		}
	}

	public virtual byte[] Extract()
	{
		lock (this)
		{
			CheckAlive();
			byte[] data = m_data;
			m_data = null;
			return data;
		}
	}

	public abstract TlsSecret HkdfExpand(int cryptoHashAlgorithm, byte[] info, int length);

	public abstract TlsSecret HkdfExtract(int cryptoHashAlgorithm, TlsSecret ikm);

	public virtual bool IsAlive()
	{
		lock (this)
		{
			return m_data != null;
		}
	}

	internal virtual byte[] CopyData()
	{
		lock (this)
		{
			return Arrays.Clone(m_data);
		}
	}
}
