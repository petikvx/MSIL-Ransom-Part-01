using System.IO;

namespace ns0;

internal class Class12 : BinaryWriter
{
	private MemoryStream memoryStream_0;

	public Class12()
	{
		memoryStream_0 = new MemoryStream();
		OutStream = memoryStream_0;
	}

	public byte[] method_0()
	{
		Close();
		byte[] result = memoryStream_0.ToArray();
		memoryStream_0.Dispose();
		memoryStream_0 = null;
		return result;
	}
}
