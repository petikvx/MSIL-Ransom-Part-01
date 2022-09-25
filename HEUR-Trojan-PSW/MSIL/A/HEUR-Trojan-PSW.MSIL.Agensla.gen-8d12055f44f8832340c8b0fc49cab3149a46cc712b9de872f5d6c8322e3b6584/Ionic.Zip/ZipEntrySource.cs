namespace Ionic.Zip;

public enum ZipEntrySource
{
	None,
	FileSystem,
	Stream,
	ZipFile,
	WriteDelegate,
	JitStream,
	ZipOutputStream
}
