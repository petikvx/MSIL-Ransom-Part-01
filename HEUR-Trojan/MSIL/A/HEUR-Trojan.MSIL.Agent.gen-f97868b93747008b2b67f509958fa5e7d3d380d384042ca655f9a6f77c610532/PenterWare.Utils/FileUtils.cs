using System;
using System.IO;

namespace PenterWare.Utils;

internal class FileUtils
{
	public static string PATH_SUFFIX = ".PNT-RNSM";

	public static string GetTemporaryDirectory()
	{
		string tempFileName = Path.GetTempFileName();
		File.Delete(tempFileName);
		string text = tempFileName + PATH_SUFFIX;
		Directory.CreateDirectory(text);
		return text;
	}

	public static double GetFreeSpaceMB(string path)
	{
		try
		{
			return GeneralUtils.ConvertBytesToMegabytes(new DriveInfo(Path.GetPathRoot(path)).AvailableFreeSpace);
		}
		catch (Exception arg)
		{
			GeneralUtils.Log($"Exception Caught trying to calculate free space: {arg}");
			return 0.0;
		}
	}

	public static double GetFileSizeMB(string path)
	{
		if (File.Exists(path))
		{
			return GeneralUtils.ConvertBytesToMegabytes(new FileInfo(path).Length);
		}
		return -1.0;
	}

	public static string[] GetTopFiles(string folderpath)
	{
		string[] result = new string[0];
		try
		{
			result = Directory.GetFiles(folderpath, "*.*", SearchOption.TopDirectoryOnly);
			return result;
		}
		catch (Exception ex)
		{
			GeneralUtils.Log("Error enumerating " + folderpath + ". caught " + ex.Message);
			return result;
		}
	}

	public static string[] GetTopFolders(string folderpath)
	{
		string[] result = new string[0];
		try
		{
			result = Directory.GetDirectories(folderpath, "*", SearchOption.TopDirectoryOnly);
			return result;
		}
		catch (Exception ex)
		{
			GeneralUtils.Log("Error enumerating " + folderpath + ". caught " + ex.Message);
			return result;
		}
	}

	public static void GetNoneExistingFolderAndCreate(ref string folderpath)
	{
		string text = folderpath;
		int num = 1;
		while (Directory.Exists(folderpath))
		{
			folderpath = text + $" ({num})";
			num++;
		}
		Directory.CreateDirectory(folderpath);
	}

	public static string GetNewFilePath(string filepath, string folderpath)
	{
		FileInfo fileInfo = new FileInfo(filepath);
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(filepath);
		string text = Path.Combine(folderpath, fileNameWithoutExtension);
		string text2 = filepath + RunRegistry.Filesystem.BackupPathSuffix;
		int num = 1;
		while (File.Exists(text2))
		{
			text2 = text + $" ({num})" + fileInfo.Extension + RunRegistry.Filesystem.BackupPathSuffix;
			num++;
		}
		return text2;
	}

	public static string ForceCopyFile(string filepath, string folderpath)
	{
		string newFilePath = GetNewFilePath(filepath, folderpath);
		File.Copy(filepath, newFilePath);
		if (!File.Exists(newFilePath))
		{
			throw new Exception("Could not create copy of " + filepath);
		}
		File.SetAttributes(newFilePath, File.GetAttributes(newFilePath) | FileAttributes.Hidden);
		return newFilePath;
	}

	public static void ShredFile(string filepath)
	{
		GeneralUtils.Log("Shredding " + filepath);
		byte[] buffer = new byte[8192];
		Random random = new Random();
		double fileSizeMB = GetFileSizeMB(filepath);
		using (FileStream fileStream = new FileStream(filepath, FileMode.Open, FileAccess.Write))
		{
			for (int i = 0; (double)i < fileSizeMB * 128.0; i++)
			{
				random.NextBytes(buffer);
				fileStream.Write(buffer, 0, 8192);
			}
		}
		File.Delete(filepath);
	}
}
