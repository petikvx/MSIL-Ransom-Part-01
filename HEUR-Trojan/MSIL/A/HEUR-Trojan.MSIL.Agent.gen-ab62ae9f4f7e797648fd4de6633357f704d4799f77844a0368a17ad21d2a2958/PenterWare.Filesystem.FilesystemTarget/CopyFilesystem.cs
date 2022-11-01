using System.Collections.Generic;
using System.IO;
using PenterWare.Utils;

namespace PenterWare.Filesystem.FilesystemTarget;

internal class CopyFilesystem : BaseFilesystem
{
	public CopyFilesystem(List<string> targetPaths, double MaxEnumSizeMB = 300.0)
		: base(targetPaths, MaxEnumSizeMB)
	{
	}

	protected override KeyValuePair<string, string> BackupFileToEnumerate(string filePath)
	{
		string value = FileUtils.ForceCopyFile(filePath, Path.GetDirectoryName(filePath));
		return new KeyValuePair<string, string>(filePath, value);
	}

	public override void Rollback(string enumeratedFilePath, string backupFilePath)
	{
		if (File.Exists(backupFilePath))
		{
			File.Delete(backupFilePath);
		}
	}
}
