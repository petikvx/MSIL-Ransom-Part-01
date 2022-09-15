using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

internal sealed class DeferredHash : TlsHandshakeHash, TlsHash
{
	private const int BufferingHashLimit = 4;

	private readonly TlsContext m_context;

	private DigestInputBuffer m_buf;

	private readonly IDictionary m_hashes;

	private bool m_forceBuffering;

	private bool m_sealed;

	internal DeferredHash(TlsContext context)
	{
		m_context = context;
		m_buf = new DigestInputBuffer();
		m_hashes = Platform.CreateHashtable();
		m_forceBuffering = false;
		m_sealed = false;
	}

	private DeferredHash(TlsContext context, IDictionary hashes)
	{
		m_context = context;
		m_buf = null;
		m_hashes = hashes;
		m_forceBuffering = false;
		m_sealed = true;
	}

	public void CopyBufferTo(Stream output)
	{
		if (m_buf == null)
		{
			throw new InvalidOperationException("Not buffering");
		}
		m_buf.CopyTo(output);
	}

	public void ForceBuffering()
	{
		if (m_sealed)
		{
			throw new InvalidOperationException("Too late to force buffering");
		}
		m_forceBuffering = true;
	}

	public void NotifyPrfDetermined()
	{
		SecurityParameters securityParameters = m_context.SecurityParameters;
		int prfAlgorithm = securityParameters.PrfAlgorithm;
		if ((uint)prfAlgorithm <= 1u)
		{
			CheckTrackingHash(1);
			CheckTrackingHash(2);
		}
		else
		{
			CheckTrackingHash(securityParameters.PrfCryptoHashAlgorithm);
		}
	}

	public void TrackHashAlgorithm(int cryptoHashAlgorithm)
	{
		if (m_sealed)
		{
			throw new InvalidOperationException("Too late to track more hash algorithms");
		}
		CheckTrackingHash(cryptoHashAlgorithm);
	}

	public void SealHashAlgorithms()
	{
		if (m_sealed)
		{
			throw new InvalidOperationException("Already sealed");
		}
		m_sealed = true;
		CheckStopBuffering();
	}

	public TlsHandshakeHash StopTracking()
	{
		SecurityParameters securityParameters = m_context.SecurityParameters;
		IDictionary dictionary = Platform.CreateHashtable();
		int prfAlgorithm = securityParameters.PrfAlgorithm;
		if ((uint)prfAlgorithm <= 1u)
		{
			CloneHash(dictionary, 1);
			CloneHash(dictionary, 2);
		}
		else
		{
			CloneHash(dictionary, securityParameters.PrfCryptoHashAlgorithm);
		}
		return new DeferredHash(m_context, dictionary);
	}

	public TlsHash ForkPrfHash()
	{
		CheckStopBuffering();
		SecurityParameters securityParameters = m_context.SecurityParameters;
		int prfAlgorithm = securityParameters.PrfAlgorithm;
		TlsHash tlsHash = (((uint)prfAlgorithm > 1u) ? CloneHash(securityParameters.PrfCryptoHashAlgorithm) : new CombinedHash(m_context, CloneHash(1), CloneHash(2)));
		if (m_buf != null)
		{
			m_buf.UpdateDigest(tlsHash);
		}
		return tlsHash;
	}

	public byte[] GetFinalHash(int cryptoHashAlgorithm)
	{
		TlsHash tlsHash = (TlsHash)m_hashes[cryptoHashAlgorithm];
		if (tlsHash == null)
		{
			throw new InvalidOperationException("CryptoHashAlgorithm." + cryptoHashAlgorithm + " is not being tracked");
		}
		CheckStopBuffering();
		tlsHash = tlsHash.CloneHash();
		if (m_buf != null)
		{
			m_buf.UpdateDigest(tlsHash);
		}
		return tlsHash.CalculateHash();
	}

	public void Update(byte[] input, int inOff, int len)
	{
		if (m_buf != null)
		{
			m_buf.Write(input, inOff, len);
			return;
		}
		foreach (TlsHash value in m_hashes.Values)
		{
			value.Update(input, inOff, len);
		}
	}

	public byte[] CalculateHash()
	{
		throw new InvalidOperationException("Use 'ForkPrfHash' to get a definite hash");
	}

	public TlsHash CloneHash()
	{
		throw new InvalidOperationException("attempt to clone a DeferredHash");
	}

	public void Reset()
	{
		if (m_buf != null)
		{
			m_buf.SetLength(0L);
			return;
		}
		foreach (TlsHash value in m_hashes.Values)
		{
			value.Reset();
		}
	}

	private void CheckStopBuffering()
	{
		if (m_forceBuffering || !m_sealed || m_buf == null || m_hashes.Count > 4)
		{
			return;
		}
		foreach (TlsHash value in m_hashes.Values)
		{
			m_buf.UpdateDigest(value);
		}
		m_buf = null;
	}

	private void CheckTrackingHash(int cryptoHashAlgorithm)
	{
		if (!m_hashes.Contains(cryptoHashAlgorithm))
		{
			TlsHash value = m_context.Crypto.CreateHash(cryptoHashAlgorithm);
			m_hashes[cryptoHashAlgorithm] = value;
		}
	}

	private TlsHash CloneHash(int cryptoHashAlgorithm)
	{
		return ((TlsHash)m_hashes[cryptoHashAlgorithm]).CloneHash();
	}

	private void CloneHash(IDictionary newHashes, int cryptoHashAlgorithm)
	{
		TlsHash tlsHash = CloneHash(cryptoHashAlgorithm);
		if (m_buf != null)
		{
			m_buf.UpdateDigest(tlsHash);
		}
		newHashes[cryptoHashAlgorithm] = tlsHash;
	}
}
