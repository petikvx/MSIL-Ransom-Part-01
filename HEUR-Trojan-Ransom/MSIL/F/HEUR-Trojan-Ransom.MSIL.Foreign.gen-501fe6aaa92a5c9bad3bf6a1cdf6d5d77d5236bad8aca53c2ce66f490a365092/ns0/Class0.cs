using System.IO;

namespace ns0;

internal class Class0 : BinaryReader
{
	public Class0(byte[] data)
		: base(new MemoryStream(data))
	{
	}
}
