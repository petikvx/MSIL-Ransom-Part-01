using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Utilities.Zlib;

namespace Org.BouncyCastle.Cms;

public class CmsCompressedDataParser : CmsContentInfoParser
{
	public CmsCompressedDataParser(byte[] compressedData)
		: this(new MemoryStream(compressedData, writable: false))
	{
	}

	public CmsCompressedDataParser(Stream compressedData)
		: base(compressedData)
	{
	}

	public CmsTypedStream GetContent()
	{
		try
		{
			ContentInfoParser encapContentInfo = new CompressedDataParser((Asn1SequenceParser)contentInfo.GetContent(16)).GetEncapContentInfo();
			return new CmsTypedStream(inStream: new ZInputStream(((Asn1OctetStringParser)encapContentInfo.GetContent(4)).GetOctetStream()), oid: encapContentInfo.ContentType.ToString());
		}
		catch (IOException e)
		{
			throw new CmsException("IOException reading compressed content.", e);
		}
	}
}
