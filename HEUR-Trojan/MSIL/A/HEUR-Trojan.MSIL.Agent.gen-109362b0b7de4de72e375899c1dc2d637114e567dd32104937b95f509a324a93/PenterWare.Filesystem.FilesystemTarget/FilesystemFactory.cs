using System;
using System.Collections.Generic;

namespace PenterWare.Filesystem.FilesystemTarget;

internal class FilesystemFactory
{
	public static BaseFilesystem GetFilesystem(List<string> targetPaths, string backupType, double MaxEnumSizeMB = 300.0)
	{
		if (!(backupType == "Copy"))
		{
			if (!(backupType == "Rename"))
			{
				throw new Exception($"No filesystem with backup type {backupType}");
			}
			return new RenameFilesystem(targetPaths, MaxEnumSizeMB);
		}
		return new CopyFilesystem(targetPaths, MaxEnumSizeMB);
	}
}
