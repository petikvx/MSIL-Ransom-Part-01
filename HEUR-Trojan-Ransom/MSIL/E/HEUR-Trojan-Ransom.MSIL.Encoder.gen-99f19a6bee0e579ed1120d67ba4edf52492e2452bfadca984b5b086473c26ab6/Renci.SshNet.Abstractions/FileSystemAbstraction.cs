using System;
using System.Collections.Generic;
using System.IO;

namespace Renci.SshNet.Abstractions;

internal class FileSystemAbstraction
{
	public static IEnumerable<FileInfo> EnumerateFiles(DirectoryInfo directoryInfo, string searchPattern)
	{
		if (directoryInfo == null)
		{
			throw new ArgumentNullException("directoryInfo");
		}
		return directoryInfo.GetFiles(searchPattern);
	}
}
