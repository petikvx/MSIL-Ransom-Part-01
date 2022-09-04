using System.IO;

namespace Lexplorer;

internal static class FileEncryptor
{
	private const int BUFFER_SIZE = 1024;

	private const byte KEY = 222;

	public static void Encrypt(string sourceFile, string destFile)
	{
		FileStream fileStream = new FileStream(sourceFile, FileMode.Open, FileAccess.Read);
		FileStream fileStream2 = new FileStream(destFile, FileMode.OpenOrCreate, FileAccess.Write);
		byte[] array = new byte[1024];
		int num = 0;
		do
		{
			num = fileStream.Read(array, 0, 1024);
			if (num <= 0)
			{
				break;
			}
			for (int i = 0; i < num; i++)
			{
				array[i] ^= 222;
			}
			fileStream2.Write(array, 0, num);
		}
		while (num > 0);
		fileStream2.Close();
		fileStream.Close();
	}

	public static void Decrypt(string sourceFile, string destFile)
	{
		Encrypt(sourceFile, destFile);
	}
}
