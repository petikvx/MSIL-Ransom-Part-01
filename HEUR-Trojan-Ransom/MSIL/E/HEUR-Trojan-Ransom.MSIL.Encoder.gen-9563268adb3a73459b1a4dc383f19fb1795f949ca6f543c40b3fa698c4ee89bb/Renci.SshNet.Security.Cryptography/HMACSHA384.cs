using System.Security.Cryptography;
using Renci.SshNet.Common;

namespace Renci.SshNet.Security.Cryptography;

public class HMACSHA384 : System.Security.Cryptography.HMACSHA384
{
	private readonly int _hashSize;

	public override int HashSize => _hashSize;

	public HMACSHA384(byte[] key)
		: base(key)
	{
		_hashSize = base.HashSize;
	}

	public HMACSHA384(byte[] key, int hashSize)
		: base(key)
	{
		_hashSize = hashSize;
	}

	protected override byte[] HashFinal()
	{
		return ((HMAC)this).HashFinal().Take(HashSize / 8);
	}
}
