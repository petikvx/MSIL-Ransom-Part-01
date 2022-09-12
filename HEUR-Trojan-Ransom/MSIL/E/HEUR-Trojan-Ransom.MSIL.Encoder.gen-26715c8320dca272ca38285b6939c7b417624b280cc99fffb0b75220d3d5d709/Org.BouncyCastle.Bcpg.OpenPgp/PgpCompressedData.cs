using System.IO;
using Org.BouncyCastle.Apache.Bzip2;
using Org.BouncyCastle.Utilities.Zlib;

namespace Org.BouncyCastle.Bcpg.OpenPgp;

public class PgpCompressedData : PgpObject
{
	private readonly CompressedDataPacket data;

	public CompressionAlgorithmTag Algorithm => data.Algorithm;

	public PgpCompressedData(BcpgInputStream bcpgInput)
	{
		data = (CompressedDataPacket)bcpgInput.ReadPacket();
	}

	public Stream GetInputStream()
	{
		return data.GetInputStream();
	}

	public Stream GetDataStream()
	{
		return Algorithm switch
		{
			CompressionAlgorithmTag.Uncompressed => GetInputStream(), 
			CompressionAlgorithmTag.Zip => new ZInputStream(GetInputStream(), nowrap: true), 
			CompressionAlgorithmTag.ZLib => new ZInputStream(GetInputStream()), 
			CompressionAlgorithmTag.BZip2 => new CBZip2InputStream(GetInputStream()), 
			_ => throw new PgpException("can't recognise compression algorithm: " + Algorithm), 
		};
	}
}
