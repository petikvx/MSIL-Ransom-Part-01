using System.IO;

namespace ICSharpCode.SharpZipLib.Zip;

public abstract class BaseArchiveStorage : IArchiveStorage
{
	private FileUpdateMode oLDXEZxUXDsCUwTRHWJjCJOSeXnK;

	public FileUpdateMode UpdateMode => oLDXEZxUXDsCUwTRHWJjCJOSeXnK;

	protected BaseArchiveStorage(FileUpdateMode updateMode)
	{
		oLDXEZxUXDsCUwTRHWJjCJOSeXnK = updateMode;
	}

	public abstract Stream ConvertTemporaryToFinal();

	public abstract void Dispose();

	public abstract Stream GetTemporaryOutput();

	public abstract Stream MakeTemporaryCopy(Stream stream);

	public abstract Stream OpenForDirectUpdate(Stream stream);
}
