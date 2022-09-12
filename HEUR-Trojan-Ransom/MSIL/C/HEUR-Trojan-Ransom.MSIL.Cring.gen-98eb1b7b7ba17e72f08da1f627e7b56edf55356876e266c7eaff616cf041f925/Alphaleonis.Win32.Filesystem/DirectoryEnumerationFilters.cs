using System;

namespace Alphaleonis.Win32.Filesystem;

public class DirectoryEnumerationFilters
{
	public Predicate<FileSystemEntryInfo> InclusionFilter { get; set; }

	public Predicate<FileSystemEntryInfo> RecursionFilter { get; set; }

	public ErrorHandler ErrorFilter { get; set; }
}
