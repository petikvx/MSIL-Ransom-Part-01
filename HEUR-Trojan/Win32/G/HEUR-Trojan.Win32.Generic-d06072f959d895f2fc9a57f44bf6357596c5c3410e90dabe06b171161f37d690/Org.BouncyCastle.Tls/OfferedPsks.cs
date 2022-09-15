using System;
using System.Collections;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls;

public sealed class OfferedPsks
{
	internal class BindersConfig
	{
		internal readonly TlsPsk[] m_psks;

		internal readonly short[] m_pskKeyExchangeModes;

		internal readonly TlsSecret[] m_earlySecrets;

		internal int m_bindersSize;

		internal BindersConfig(TlsPsk[] psks, short[] pskKeyExchangeModes, TlsSecret[] earlySecrets, int bindersSize)
		{
			m_psks = psks;
			m_pskKeyExchangeModes = pskKeyExchangeModes;
			m_earlySecrets = earlySecrets;
			m_bindersSize = bindersSize;
		}
	}

	private readonly IList m_identities;

	private readonly IList m_binders;

	public IList Binders => m_binders;

	public IList Identities => m_identities;

	public OfferedPsks(IList identities)
		: this(identities, null)
	{
	}

	private OfferedPsks(IList identities, IList binders)
	{
		if (identities != null && identities.Count >= 1)
		{
			if (binders != null && identities.Count != binders.Count)
			{
				throw new ArgumentException("must be the same length as 'identities' (or null)", "binders");
			}
			m_identities = identities;
			m_binders = binders;
			return;
		}
		throw new ArgumentException("cannot be null or empty", "identities");
	}

	public void Encode(Stream output)
	{
		int num = 0;
		foreach (PskIdentity identity in m_identities)
		{
			num += identity.GetEncodedLength();
		}
		TlsUtilities.CheckUint16(num);
		TlsUtilities.WriteUint16(num, output);
		foreach (PskIdentity identity2 in m_identities)
		{
			identity2.Encode(output);
		}
		if (m_binders == null)
		{
			return;
		}
		int num2 = 0;
		foreach (byte[] binder in m_binders)
		{
			num2 += 1 + binder.Length;
		}
		TlsUtilities.CheckUint16(num2);
		TlsUtilities.WriteUint16(num2, output);
		foreach (byte[] binder2 in m_binders)
		{
			TlsUtilities.WriteOpaque8(binder2, output);
		}
	}

	internal static void EncodeBinders(Stream output, TlsCrypto crypto, TlsHandshakeHash handshakeHash, BindersConfig bindersConfig)
	{
		TlsPsk[] psks = bindersConfig.m_psks;
		TlsSecret[] earlySecrets = bindersConfig.m_earlySecrets;
		int num = bindersConfig.m_bindersSize - 2;
		TlsUtilities.CheckUint16(num);
		TlsUtilities.WriteUint16(num, output);
		int num2 = 0;
		for (int i = 0; i < psks.Length; i++)
		{
			TlsPsk obj = psks[i];
			TlsSecret earlySecret = earlySecrets[i];
			int hashForPrf = TlsCryptoUtilities.GetHashForPrf(obj.PrfAlgorithm);
			TlsHash tlsHash = crypto.CreateHash(hashForPrf);
			handshakeHash.CopyBufferTo(new TlsHashSink(tlsHash));
			byte[] transcriptHash = tlsHash.CalculateHash();
			byte[] array = TlsUtilities.CalculatePskBinder(crypto, isExternalPsk: true, hashForPrf, earlySecret, transcriptHash);
			num2 += 1 + array.Length;
			TlsUtilities.WriteOpaque8(array, output);
		}
		if (num != num2)
		{
			throw new TlsFatalAlert(80);
		}
	}

	internal static int GetBindersSize(TlsPsk[] psks)
	{
		int num = 0;
		for (int i = 0; i < psks.Length; i++)
		{
			int hashForPrf = TlsCryptoUtilities.GetHashForPrf(psks[i].PrfAlgorithm);
			num += 1 + TlsCryptoUtilities.GetHashOutputSize(hashForPrf);
		}
		TlsUtilities.CheckUint16(num);
		return 2 + num;
	}

	public static OfferedPsks Parse(Stream input)
	{
		IList list = Platform.CreateArrayList();
		int num = TlsUtilities.ReadUint16(input);
		if (num < 7)
		{
			throw new TlsFatalAlert(50);
		}
		MemoryStream memoryStream = new MemoryStream(TlsUtilities.ReadFully(num, input), writable: false);
		do
		{
			PskIdentity value = PskIdentity.Parse(memoryStream);
			list.Add(value);
		}
		while (memoryStream.Position < memoryStream.Length);
		IList list2 = Platform.CreateArrayList();
		int num2 = TlsUtilities.ReadUint16(input);
		if (num2 < 33)
		{
			throw new TlsFatalAlert(50);
		}
		MemoryStream memoryStream2 = new MemoryStream(TlsUtilities.ReadFully(num2, input), writable: false);
		do
		{
			byte[] value2 = TlsUtilities.ReadOpaque8(input, 32);
			list2.Add(value2);
		}
		while (memoryStream2.Position < memoryStream2.Length);
		return new OfferedPsks(list, list2);
	}
}
