using System.IO;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.Zlib;

namespace Org.BouncyCastle.Cms;

public class CmsCompressedData
{
	internal ContentInfo contentInfo;

	public ContentInfo ContentInfo => contentInfo;

	public CmsCompressedData(byte[] compressedData)
		: this(CmsUtilities.ReadContentInfo(compressedData))
	{
	}

	public CmsCompressedData(Stream compressedDataStream)
		: this(CmsUtilities.ReadContentInfo(compressedDataStream))
	{
	}

	public CmsCompressedData(ContentInfo contentInfo)
	{
		this.contentInfo = contentInfo;
	}

	public byte[] GetContent()
	{
		ZInputStream zInputStream = new ZInputStream(((Asn1OctetString)CompressedData.GetInstance(contentInfo.Content).EncapContentInfo.Content).GetOctetStream());
		try
		{
			return CmsUtilities.StreamToByteArray(zInputStream);
		}
		catch (IOException e)
		{
			throw new CmsException("exception reading compressed stream.", e);
		}
		finally
		{
			Platform.Dispose(zInputStream);
		}
	}

	public byte[] GetContent(int limit)
	{
		ZInputStream inStream = new ZInputStream(new MemoryStream(((Asn1OctetString)CompressedData.GetInstance(contentInfo.Content).EncapContentInfo.Content).GetOctets(), writable: false));
		try
		{
			return CmsUtilities.StreamToByteArray(inStream, limit);
		}
		catch (IOException e)
		{
			throw new CmsException("exception reading compressed stream.", e);
		}
	}

	public byte[] GetEncoded()
	{
		return contentInfo.GetEncoded();
	}
}
