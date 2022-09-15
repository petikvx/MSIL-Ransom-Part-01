using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip;

public interface IEntryFactory
{
	INameTransform NameTransform { get; set; }

	ZipEntry MakeDirectoryEntry(string directoryName);

	ZipEntry MakeDirectoryEntry(string directoryName, bool useFileSystem);

	ZipEntry MakeFileEntry(string fileName);

	ZipEntry MakeFileEntry(string fileName, bool useFileSystem);
}