using Gecko.IO;
using Gecko.Interop;

namespace Gecko.Cryptography;

public sealed class CryptoHash
{
	private ComPtr<nsICryptoHash> _cryptoHash;

	public CryptoHash(HashAlgorithm algorithm)
	{
		_cryptoHash = Xpcom.CreateInstance2<nsICryptoHash>("@mozilla.org/security/hash;1");
		_cryptoHash.Instance.Init((uint)algorithm);
	}

	public void Update(byte[] array)
	{
		_cryptoHash.Instance.Update(array, (uint)array.Length);
	}

	public void UpdateFromStream(InputStream stream, int count)
	{
		_cryptoHash.Instance.UpdateFromStream(stream._inputStream, (uint)count);
	}

	public void UpdateFromStream(InputStream stream)
	{
		_cryptoHash.Instance.UpdateFromStream(stream._inputStream, uint.MaxValue);
	}

	public string FinishBase64()
	{
		return nsString.Get(_cryptoHash.Instance.Finish, value: true);
	}

	public byte[] Finish()
	{
		using nsACString nsACString = new nsACString();
		_cryptoHash.Instance.Finish(aASCII: false, nsACString);
		return nsACString.GetRawData();
	}
}
