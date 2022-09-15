using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls;

internal abstract class Ssl3Utilities
{
	private static readonly byte[] SSL_CLIENT = new byte[4] { 67, 76, 78, 84 };

	private static readonly byte[] SSL_SERVER = new byte[4] { 83, 82, 86, 82 };

	private const byte IPAD_BYTE = 54;

	private const byte OPAD_BYTE = 92;

	private static readonly byte[] IPAD = GenPad(54, 48);

	private static readonly byte[] OPAD = GenPad(92, 48);

	internal static byte[] CalculateVerifyData(TlsHandshakeHash handshakeHash, bool isServer)
	{
		TlsHash tlsHash = handshakeHash.ForkPrfHash();
		byte[] array = (isServer ? SSL_SERVER : SSL_CLIENT);
		tlsHash.Update(array, 0, array.Length);
		return tlsHash.CalculateHash();
	}

	internal static void CompleteCombinedHash(TlsContext context, TlsHash md5, TlsHash sha1)
	{
		TlsSecret masterSecret = context.SecurityParameters.MasterSecret;
		byte[] master_secret = context.Crypto.AdoptSecret(masterSecret).Extract();
		CompleteHash(master_secret, md5, 48);
		CompleteHash(master_secret, sha1, 40);
	}

	private static void CompleteHash(byte[] master_secret, TlsHash hash, int padLength)
	{
		hash.Update(master_secret, 0, master_secret.Length);
		hash.Update(IPAD, 0, padLength);
		byte[] array = hash.CalculateHash();
		hash.Update(master_secret, 0, master_secret.Length);
		hash.Update(OPAD, 0, padLength);
		hash.Update(array, 0, array.Length);
	}

	private static byte[] GenPad(byte b, int count)
	{
		byte[] array = new byte[count];
		Arrays.Fill(array, b);
		return array;
	}

	internal static byte[] ReadEncryptedPms(Stream input)
	{
		return Streams.ReadAll(input);
	}

	internal static void WriteEncryptedPms(byte[] encryptedPms, Stream output)
	{
		output.Write(encryptedPms, 0, encryptedPms.Length);
	}
}
