using System.IO;
using System.Text;

internal class Class0
{
	private readonly BinaryReader binaryReader_0;

	public Class0(Stream stream_0)
	{
		binaryReader_0 = new BinaryReader(stream_0, Encoding.Unicode);
	}

	public Class0(byte[] byte_0)
		: this(new MemoryStream(byte_0))
	{
	}

	public string method_0()
	{
		return binaryReader_0.ReadString();
	}

	public sbyte method_1()
	{
		return binaryReader_0.ReadSByte();
	}

	public int method_2()
	{
		return binaryReader_0.ReadInt32();
	}

	public long method_3()
	{
		return binaryReader_0.ReadInt64();
	}

	public float method_4()
	{
		return binaryReader_0.ReadSingle();
	}

	public double method_5()
	{
		return binaryReader_0.ReadDouble();
	}
}
