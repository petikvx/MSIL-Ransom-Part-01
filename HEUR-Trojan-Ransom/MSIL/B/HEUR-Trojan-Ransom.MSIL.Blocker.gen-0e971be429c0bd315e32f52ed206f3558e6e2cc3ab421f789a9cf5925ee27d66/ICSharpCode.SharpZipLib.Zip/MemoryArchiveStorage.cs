using System.IO;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip;

public class MemoryArchiveStorage : BaseArchiveStorage
{
	private MemoryStream MXPfcRjqUIXnjqvaslARMTlqnBYgA;

	private MemoryStream dittwazhgNePIuLUjJFnRKMjeSheA;

	public MemoryStream FinalStream => MXPfcRjqUIXnjqvaslARMTlqnBYgA;

	public MemoryArchiveStorage()
		: base(FileUpdateMode.Direct)
	{
	}

	public MemoryArchiveStorage(FileUpdateMode updateMode)
		: base(updateMode)
	{
	}

	public override Stream ConvertTemporaryToFinal()
	{
		if (dittwazhgNePIuLUjJFnRKMjeSheA == null)
		{
			throw new ZipException("No temporary stream has been created");
		}
		MXPfcRjqUIXnjqvaslARMTlqnBYgA = new MemoryStream(dittwazhgNePIuLUjJFnRKMjeSheA.ToArray());
		return MXPfcRjqUIXnjqvaslARMTlqnBYgA;
	}

	public override void Dispose()
	{
		if (dittwazhgNePIuLUjJFnRKMjeSheA != null)
		{
			dittwazhgNePIuLUjJFnRKMjeSheA.Close();
		}
	}

	public override Stream GetTemporaryOutput()
	{
		dittwazhgNePIuLUjJFnRKMjeSheA = new MemoryStream();
		return dittwazhgNePIuLUjJFnRKMjeSheA;
	}

	public override Stream MakeTemporaryCopy(Stream stream)
	{
		dittwazhgNePIuLUjJFnRKMjeSheA = new MemoryStream();
		stream.Position = 0L;
		StreamUtils.Copy(stream, dittwazhgNePIuLUjJFnRKMjeSheA, new byte[4096]);
		return dittwazhgNePIuLUjJFnRKMjeSheA;
	}

	public override Stream OpenForDirectUpdate(Stream stream)
	{
		if (stream != null && stream.CanWrite)
		{
			return stream;
		}
		Stream stream2 = new MemoryStream();
		if (stream != null)
		{
			stream.Position = 0L;
			StreamUtils.Copy(stream, stream2, new byte[4096]);
			stream.Close();
		}
		return stream2;
	}
}
