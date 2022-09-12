using System.IO;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Zip;

public class MemoryArchiveStorage : BaseArchiveStorage
{
	private MemoryStream NILMfsSMMnVUpYPfdRHevBwxkEDi;

	private MemoryStream uYjeBJTxcoKdAVrxiAYCfuBeufuu;

	public MemoryStream FinalStream => NILMfsSMMnVUpYPfdRHevBwxkEDi;

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
		if (uYjeBJTxcoKdAVrxiAYCfuBeufuu == null)
		{
			throw new ZipException("No temporary stream has been created");
		}
		NILMfsSMMnVUpYPfdRHevBwxkEDi = new MemoryStream(uYjeBJTxcoKdAVrxiAYCfuBeufuu.ToArray());
		return NILMfsSMMnVUpYPfdRHevBwxkEDi;
	}

	public override void Dispose()
	{
		if (uYjeBJTxcoKdAVrxiAYCfuBeufuu != null)
		{
			uYjeBJTxcoKdAVrxiAYCfuBeufuu.Close();
		}
	}

	public override Stream GetTemporaryOutput()
	{
		uYjeBJTxcoKdAVrxiAYCfuBeufuu = new MemoryStream();
		return uYjeBJTxcoKdAVrxiAYCfuBeufuu;
	}

	public override Stream MakeTemporaryCopy(Stream stream)
	{
		uYjeBJTxcoKdAVrxiAYCfuBeufuu = new MemoryStream();
		stream.Position = 0L;
		StreamUtils.Copy(stream, uYjeBJTxcoKdAVrxiAYCfuBeufuu, new byte[4096]);
		return uYjeBJTxcoKdAVrxiAYCfuBeufuu;
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
