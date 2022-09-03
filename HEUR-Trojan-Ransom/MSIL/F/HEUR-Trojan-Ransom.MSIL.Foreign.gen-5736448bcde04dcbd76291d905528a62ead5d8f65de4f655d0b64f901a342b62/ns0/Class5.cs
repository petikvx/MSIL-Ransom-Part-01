using System.IO;

namespace ns0;

internal class Class5 : BinaryReader
{
	public Class5(byte[] data)
		: base(new MemoryStream(data))
	{
	}
}
