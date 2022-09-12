using System;
using Renci.SshNet.Common;
using Renci.SshNet.Security.Cryptography;

namespace Renci.SshNet;

public class CipherInfo
{
	public int KeySize { get; private set; }

	public Func<byte[], byte[], Cipher> Cipher { get; private set; }

	public CipherInfo(int keySize, Func<byte[], byte[], Cipher> cipher)
	{
		CipherInfo cipherInfo = this;
		KeySize = keySize;
		Cipher = (byte[] key, byte[] iv) => cipher(key.Take(cipherInfo.KeySize / 8), iv);
	}
}
