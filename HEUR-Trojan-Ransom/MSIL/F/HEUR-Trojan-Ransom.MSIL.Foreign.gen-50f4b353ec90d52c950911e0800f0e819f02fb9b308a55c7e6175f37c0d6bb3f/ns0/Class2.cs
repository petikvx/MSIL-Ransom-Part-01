using System.IO;

namespace ns0;

internal class Class2 : BinaryReader
{
	public Class2(byte[] data)
		: base(new MemoryStream(data))
	{
	}
}
