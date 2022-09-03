using System.IO;

namespace ns0;

internal class Class6 : BinaryReader
{
	public Class6(byte[] data)
		: base(new MemoryStream(data))
	{
	}
}
