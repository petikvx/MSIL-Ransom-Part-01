using System.IO;

namespace C3904355907;

public sealed class C543223747
{
	private C543223747()
	{
	}

	public static void C3554254475(FileInfo fileInfo_0, ref byte[] byte_0)
	{
		using FileStream fileStream = File.OpenRead(fileInfo_0.FullName);
		byte_0 = new byte[fileStream.Length];
		fileStream.Read(byte_0, 0, byte_0.Length);
	}
}
