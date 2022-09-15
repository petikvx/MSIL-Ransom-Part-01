using System.IO;

namespace Org.BouncyCastle.Bcpg;

public abstract class BcpgObject
{
	public virtual byte[] GetEncoded()
	{
		MemoryStream memoryStream = new MemoryStream();
		new BcpgOutputStream(memoryStream).WriteObject(this);
		return memoryStream.ToArray();
	}

	public abstract void Encode(BcpgOutputStream bcpgOut);
}
