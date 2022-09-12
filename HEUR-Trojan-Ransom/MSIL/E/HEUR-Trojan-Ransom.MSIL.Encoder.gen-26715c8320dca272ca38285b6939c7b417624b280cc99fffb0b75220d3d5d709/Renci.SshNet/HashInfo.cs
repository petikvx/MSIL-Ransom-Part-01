using System;
using System.Security.Cryptography;
using Renci.SshNet.Common;

namespace Renci.SshNet;

public class HashInfo
{
	public int KeySize { get; private set; }

	public Func<byte[], HashAlgorithm> HashAlgorithm { get; private set; }

	public HashInfo(int keySize, Func<byte[], HashAlgorithm> hash)
	{
		HashInfo hashInfo = this;
		KeySize = keySize;
		HashAlgorithm = (byte[] key) => hash(key.Take(hashInfo.KeySize / 8));
	}
}
