using System.IO;

namespace Org.BouncyCastle.Utilities.IO;

public class MemoryOutputStream : MemoryStream
{
	public sealed override bool CanRead => false;
}
