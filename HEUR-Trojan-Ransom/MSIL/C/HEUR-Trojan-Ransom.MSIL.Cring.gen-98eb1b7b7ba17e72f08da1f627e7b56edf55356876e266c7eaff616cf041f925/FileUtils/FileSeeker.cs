using System;
using System.Collections.Generic;
using System.Linq;
using Alphaleonis.Win32.Filesystem;

namespace FileUtils;

public static class FileSeeker
{
	public static IEnumerable<string> EnumFiles(string inputPath, List<string> findExtensions)
	{
		string[] skipFolders = new string[15]
		{
			"Windows", "WinSxS", "$Recycle.Bin", "PerfLogs", "ProgramData", "Temp", "AppData", "__pycache__", "Logs", "Log",
			"Lib", "Library", "WindowsApps", "PYTHON_SERVER", "PYTHON_SERVICES"
		};
		DirectoryEnumerationFilters filters = new DirectoryEnumerationFilters
		{
			RecursionFilter = (FileSystemEntryInfo fsei) => !skipFolders.Any((string found) => found.Equals(fsei.FileName, StringComparison.OrdinalIgnoreCase)),
			ErrorFilter = (int errorCode, string errorMessage, string pathProcessed) => true,
			InclusionFilter = (FileSystemEntryInfo fsei) => !findExtensions.Any((string found) => fsei.Extension.ToLower().StartsWith(found))
		};
		return Directory.EnumerateFileSystemEntryInfos<string>(inputPath, DirectoryEnumerationOptions.Files | DirectoryEnumerationOptions.Recursive, filters);
	}

	public static IEnumerable<string> EnumEncFiles(string inputPath, List<string> findExtensions)
	{
		string[] skipFolders = new string[9] { "Windows", "WinSxS", "$Recycle.Bin", "PerfLogs", "ProgramData", "Temp", "AppData", "__pycache__", "Logs" };
		DirectoryEnumerationFilters filters = new DirectoryEnumerationFilters
		{
			RecursionFilter = (FileSystemEntryInfo fsei) => !skipFolders.Any((string found) => found.Equals(fsei.FileName, StringComparison.OrdinalIgnoreCase)),
			ErrorFilter = (int errorCode, string errorMessage, string pathProcessed) => true,
			InclusionFilter = (FileSystemEntryInfo fsei) => findExtensions.Any((string found) => fsei.Extension.ToLower().StartsWith(found))
		};
		return Directory.EnumerateFileSystemEntryInfos<string>(inputPath, DirectoryEnumerationOptions.Files | DirectoryEnumerationOptions.Recursive, filters);
	}
}
