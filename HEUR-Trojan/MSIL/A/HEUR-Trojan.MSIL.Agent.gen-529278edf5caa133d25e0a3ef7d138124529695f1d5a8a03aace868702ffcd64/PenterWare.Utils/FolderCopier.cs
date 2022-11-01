using System.Collections.Generic;
using System.IO;

namespace PenterWare.Utils;

internal class FolderCopier
{
	public double MaxCopySizeMB { get; set; }

	public double CurrentCopySizeMB { get; set; }

	public List<string> SrcPaths { get; set; }

	public string DstFolder { get; set; }

	public FolderCopier(List<string> srcPaths, string dstFolder, int maxCopySizeMB = 150)
	{
		SrcPaths = srcPaths;
		DstFolder = dstFolder;
		CurrentCopySizeMB = 0.0;
		DecideCopySize(maxCopySizeMB);
	}

	protected void DecideCopySize(double wantedCopySize)
	{
		double freeSpaceMB = FileUtils.GetFreeSpaceMB(DstFolder);
		if (wantedCopySize < freeSpaceMB / 2.0)
		{
			MaxCopySizeMB = wantedCopySize;
		}
		else
		{
			MaxCopySizeMB = freeSpaceMB / 2.0;
		}
	}

	public void Copy()
	{
		foreach (string srcPath in SrcPaths)
		{
			if (Directory.Exists(srcPath))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(srcPath);
				string folderpath = Path.Combine(DstFolder, directoryInfo.Name);
				FileUtils.GetNoneExistingFolderAndCreate(ref folderpath);
				CopyFolders(srcPath, folderpath);
			}
			else if (File.Exists(srcPath))
			{
				CopyFile(srcPath, DstFolder);
			}
		}
	}

	protected void CopyFile(string srcFile, string dstDirectory)
	{
		if (Policy.IsFileExtensionInPolicy(srcFile) && CurrentCopySizeMB <= MaxCopySizeMB)
		{
			FileInfo fileInfo = new FileInfo(srcFile);
			CurrentCopySizeMB += GeneralUtils.ConvertBytesToMegabytes(fileInfo.Length);
			try
			{
				File.Copy(srcFile, Path.Combine(dstDirectory, fileInfo.Name));
			}
			catch (IOException ex)
			{
				GeneralUtils.Log("skipping " + srcFile + ", caught " + ex.Message);
			}
		}
	}

	protected void CopyFolders(string srcDirectory, string dstDirectory)
	{
		if (CurrentCopySizeMB >= MaxCopySizeMB)
		{
			return;
		}
		string[] topFiles = FileUtils.GetTopFiles(srcDirectory);
		string empty = string.Empty;
		int num = 0;
		while (num < topFiles.Length && !(CurrentCopySizeMB > MaxCopySizeMB))
		{
			empty = topFiles[num++];
			CopyFile(empty, dstDirectory);
		}
		string[] topFolders = FileUtils.GetTopFolders(srcDirectory);
		foreach (string text in topFolders)
		{
			if (!(CurrentCopySizeMB >= MaxCopySizeMB))
			{
				DirectoryInfo directoryInfo = new DirectoryInfo(text);
				string text2 = Path.Combine(dstDirectory, directoryInfo.Name);
				Directory.CreateDirectory(text2);
				CopyFolders(text, text2);
				continue;
			}
			break;
		}
	}
}
