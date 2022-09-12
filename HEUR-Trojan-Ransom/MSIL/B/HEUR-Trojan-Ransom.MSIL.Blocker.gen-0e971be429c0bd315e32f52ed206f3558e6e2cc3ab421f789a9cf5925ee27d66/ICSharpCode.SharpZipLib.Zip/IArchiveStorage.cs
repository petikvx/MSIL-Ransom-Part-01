using System.IO;

namespace ICSharpCode.SharpZipLib.Zip;

public interface IArchiveStorage
{
	FileUpdateMode UpdateMode { get; }

	Stream ConvertTemporaryToFinal();

	void Dispose();

	Stream GetTemporaryOutput();

	Stream MakeTemporaryCopy(Stream stream);

	Stream OpenForDirectUpdate(Stream stream);
}
