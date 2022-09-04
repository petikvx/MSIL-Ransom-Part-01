using System.IO;

namespace ns0;

internal class Class13 : BinaryReader
{
	public Class13(byte[] data)
		: base(new MemoryStream(data))
	{
	}
}
