using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

namespace TRIPLE;

internal class wp
{
	private readonly Wipe wipe = new Wipe();

	[DllImport("kernel32.dll")]
	private static extern void Sleep(uint dwMilliseconds);

	[DllImport("kernel32.dll")]
	public static extern uint GetTickCount();

	public static void WipeFile(string filename, int timesToWrite)
	{
		try
		{
			if (!File.Exists(filename))
			{
				return;
			}
			File.SetAttributes(filename, FileAttributes.Normal);
			double num = Math.Ceiling((double)new FileInfo(filename).Length / 512.0);
			byte[] array = new byte[512];
			RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
			FileStream fileStream = new FileStream(filename, FileMode.Open);
			for (int i = 0; i < timesToWrite; i++)
			{
				fileStream.Position = 0L;
				for (int j = 0; (double)j < num; j++)
				{
					rNGCryptoServiceProvider.GetBytes(array);
					fileStream.Write(array, 0, array.Length);
				}
			}
			fileStream.SetLength(0L);
			fileStream.Close();
			DateTime dateTime = new DateTime(2037, 1, 1, 0, 0, 0);
			File.SetCreationTime(filename, dateTime);
			File.SetLastAccessTime(filename, dateTime);
			File.SetLastWriteTime(filename, dateTime);
			File.Delete(filename);
		}
		catch (Exception)
		{
		}
	}
}
