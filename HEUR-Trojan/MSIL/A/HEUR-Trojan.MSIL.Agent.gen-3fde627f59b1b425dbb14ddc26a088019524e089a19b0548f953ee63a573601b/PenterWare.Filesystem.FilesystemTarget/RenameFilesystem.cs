using System;
using System.Collections.Generic;
using System.IO;
using PenterWare.Utils;

namespace PenterWare.Filesystem.FilesystemTarget;

internal class RenameFilesystem : BaseFilesystem
{
	public RenameFilesystem(List<string> targetPaths, double MaxEnumSizeMB)
		: base(targetPaths, MaxEnumSizeMB)
	{
	}

	protected override KeyValuePair<string, string> BackupFileToEnumerate(string filePath)
	{
		string newFilePath = FileUtils.GetNewFilePath(filePath, Path.GetDirectoryName(filePath));
		File.Move(filePath, newFilePath);
		try
		{
			File.Copy(newFilePath, filePath);
			File.SetAttributes(newFilePath, File.GetAttributes(newFilePath) | FileAttributes.Hidden);
		}
		catch (Exception ex)
		{
			File.Move(newFilePath, filePath);
			throw ex;
		}
		return new KeyValuePair<string, string>(newFilePath, filePath);
	}

	public override void Rollback(string enumeratedFilePath, string backupFilePath)
	{
		File.Delete(backupFilePath);
		File.Move(enumeratedFilePath, backupFilePath);
		FileAttributes attributes = File.GetAttributes(backupFilePath);
		if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
		{
			attributes &= ~FileAttributes.Hidden;
			File.SetAttributes(backupFilePath, attributes);
		}
	}
}
