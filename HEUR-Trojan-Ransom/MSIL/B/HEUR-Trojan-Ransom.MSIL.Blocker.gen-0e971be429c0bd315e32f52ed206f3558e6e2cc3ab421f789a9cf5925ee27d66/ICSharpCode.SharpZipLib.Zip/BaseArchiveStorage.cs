using System.IO;

namespace ICSharpCode.SharpZipLib.Zip;

public abstract class BaseArchiveStorage : IArchiveStorage
{
	private FileUpdateMode jsZqSuREZmcaQLhuKMXYcrNDHVqf;

	public FileUpdateMode UpdateMode => jsZqSuREZmcaQLhuKMXYcrNDHVqf;

	protected BaseArchiveStorage(FileUpdateMode updateMode)
	{
		jsZqSuREZmcaQLhuKMXYcrNDHVqf = updateMode;
	}

	public abstract Stream ConvertTemporaryToFinal();

	public abstract void Dispose();

	public abstract Stream GetTemporaryOutput();

	public abstract Stream MakeTemporaryCopy(Stream stream);

	public abstract Stream OpenForDirectUpdate(Stream stream);
}
