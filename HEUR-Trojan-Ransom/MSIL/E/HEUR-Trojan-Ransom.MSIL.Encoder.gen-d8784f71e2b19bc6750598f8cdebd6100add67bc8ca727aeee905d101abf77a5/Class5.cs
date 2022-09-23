using System.IO;
using System.Text;

internal class Class5
{
	private readonly BinaryReader binaryReader_0;

	public Class5(Stream stream_0)
	{
		binaryReader_0 = new BinaryReader(stream_0, Encoding.Unicode);
	}

	public Class5(byte[] byte_0)
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

	public float a()
	{
		return binaryReader_0.ReadSingle();
	}

	public double b()
	{
		return binaryReader_0.ReadDouble();
	}
}
