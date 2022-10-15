namespace Ionic.Zip;

public enum ExtractExistingFileAction
{
	Throw,
	OverwriteSilently,
	DoNotOverwrite,
	InvokeExtractProgressEvent
}
