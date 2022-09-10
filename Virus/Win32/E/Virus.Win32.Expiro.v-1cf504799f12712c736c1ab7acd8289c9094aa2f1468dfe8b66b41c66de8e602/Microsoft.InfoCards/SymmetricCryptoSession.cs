using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.Security.Principal;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class SymmetricCryptoSession : CryptoSession
{
	public enum Direction
	{
		Encrypt = 1,
		Decrypt
	}

	private SymmetricAlgorithm m_alg;

	public SymmetricCryptoSession(Process process, DateTime expiration, WindowsIdentity identity, byte[] key)
		: base(process, expiration, identity, key, SessionType.Symmetric)
	{
		m_alg = new RijndaelManaged();
		m_alg.Key = key;
	}

	protected override void OnDispose()
	{
		m_alg.Clear();
		((IDisposable)m_alg).Dispose();
		m_alg = null;
	}

	protected override void OnWrite(BinaryWriter bwriter)
	{
		bwriter.Write(m_alg.KeySize);
		bwriter.Write(m_alg.BlockSize);
		bwriter.Write(m_alg.FeedbackSize);
	}

	public byte[] GenerateDerivedKey(string algorithmUri, byte[] label, byte[] nonce, int derivedKeyLength, int offset)
	{
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		if (!(algorithmUri == "http://schemas.xmlsoap.org/ws/2005/02/sc/dk/p_sha1") && !(algorithmUri == "http://docs.oasis-open.org/ws-sx/ws-secureconversation/200512/dk/p_sha1"))
		{
			throw InfoCardTrace.ThrowHelperWarning((Exception)new InfoCardArgumentException(SR.GetString("ServiceUnsupportedKeyDerivationAlgorithm", new object[1] { algorithmUri })));
		}
		return new Psha1DerivedKeyGenerator(m_alg.Key).GenerateDerivedKey(label, nonce, derivedKeyLength, offset);
	}

	public TransformCryptoSession GetCryptoTransform(CipherMode mode, PaddingMode padding, int feedbackSize, Direction direction, byte[] iv)
	{
		m_alg.Mode = mode;
		m_alg.Padding = padding;
		m_alg.IV = iv;
		return new TransformCryptoSession(icrypto: (Direction.Encrypt != direction) ? m_alg.CreateDecryptor() : m_alg.CreateEncryptor(), process: base.ProcessObj, expiration: base.Expiration, identity: base.Identity);
	}

	public HashCryptoSession GetKeyedHash()
	{
		KeyedHashAlgorithm keyedHashAlgorithm = new HMACSHA1(m_alg.Key);
		keyedHashAlgorithm.Initialize();
		return new HashCryptoSession(base.ProcessObj, base.Expiration, base.Identity, keyedHashAlgorithm);
	}
}
