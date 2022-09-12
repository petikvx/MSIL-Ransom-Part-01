using System.Security.Cryptography;
using Renci.SshNet.Common;

namespace Renci.SshNet.Security.Cryptography;

public class HMACSHA1 : System.Security.Cryptography.HMACSHA1
{
	private readonly int _hashSize;

	public override int HashSize => _hashSize;

	public HMACSHA1(byte[] key)
		: base(key)
	{
		_hashSize = base.HashSize;
	}

	public HMACSHA1(byte[] key, int hashSize)
		: base(key)
	{
		_hashSize = hashSize;
	}

	protected override byte[] HashFinal()
	{
		return ((HMAC)this).HashFinal().Take(HashSize / 8);
	}
}
