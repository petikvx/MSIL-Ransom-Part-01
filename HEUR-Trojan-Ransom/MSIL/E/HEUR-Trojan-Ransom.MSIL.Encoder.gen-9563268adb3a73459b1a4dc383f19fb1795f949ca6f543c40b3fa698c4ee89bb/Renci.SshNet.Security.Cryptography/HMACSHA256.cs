using System.Security.Cryptography;
using Renci.SshNet.Common;

namespace Renci.SshNet.Security.Cryptography;

public class HMACSHA256 : System.Security.Cryptography.HMACSHA256
{
	private readonly int _hashSize;

	public override int HashSize => _hashSize;

	public HMACSHA256(byte[] key)
		: base(key)
	{
		_hashSize = base.HashSize;
	}

	public HMACSHA256(byte[] key, int hashSize)
		: base(key)
	{
		_hashSize = hashSize;
	}

	protected override byte[] HashFinal()
	{
		return ((HMAC)this).HashFinal().Take(HashSize / 8);
	}
}
