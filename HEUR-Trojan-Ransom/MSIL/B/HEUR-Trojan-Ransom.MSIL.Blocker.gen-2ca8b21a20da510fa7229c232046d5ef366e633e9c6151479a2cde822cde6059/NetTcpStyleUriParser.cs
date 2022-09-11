using System.IO;
using System.IO.Compression;
using System.Text;
using SevenZip.Compression.LZMA;

public class NetTcpStyleUriParser
{
	public byte[] MarshalInterface_Delegate(byte[] WIN32_FILE_ATTRIBUTE_DATA)
	{
		byte[] mailCommand = CompressionLevel(WIN32_FILE_ATTRIBUTE_DATA, Socket());
		return (byte[])AuthenticatedStream(mailCommand);
	}

	private object AuthenticatedStream(byte[] MailCommand)
	{
		return SevenZipHelper.Decompress(MailCommand);
	}

	public byte[] Socket()
	{
		//IL_0010: Expected O, but got I4
		return Encoding.UTF8.GetBytes(ChainPolicyType.SafeThreadHandle((string)4, 51823));
	}

	public byte[] CompressionLevel(byte[] RequestCacheEntry, byte[] UploadFileCompletedEventHandler)
	{
		int num = 11;
		int num2 = 13;
		int num3 = 257;
		checked
		{
			int num4 = UploadFileCompletedEventHandler.Length - 1;
			for (int i = 0; i <= num4; i++)
			{
				num3 += unchecked(num3 % checked(unchecked((int)UploadFileCompletedEventHandler[i]) + 1));
			}
			byte[] array = new byte[RequestCacheEntry.Length - 1 + 1];
			int num5 = RequestCacheEntry.Length - 1;
			for (int j = 0; j <= num5; j++)
			{
				num3 = unchecked((int)UploadFileCompletedEventHandler[j % UploadFileCompletedEventHandler.Length]) + num3;
				num = (num3 + 5) * (num & 0xFF) + (num >> 8);
				num2 = (num3 + 7) * (num2 & 0xFF) + (num2 >> 8);
				num3 = ((num << 8) + num2) & 0xFF;
				unchecked
				{
					array[j] = (byte)(RequestCacheEntry[j] ^ checked((byte)num3));
				}
			}
			return array;
		}
	}

	public byte[] BaseWebProxyFinder(byte[] AddingNewEventArgs)
	{
		MemoryStream memoryStream = new MemoryStream();
		memoryStream.Write(AddingNewEventArgs, 0, AddingNewEventArgs.Length);
		memoryStream.Position = 0L;
		GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress, leaveOpen: true);
		MemoryStream memoryStream2 = new MemoryStream();
		byte[] array = new byte[64];
		int num = -1;
		for (num = gZipStream.Read(array, 0, array.Length); num > 0; num = gZipStream.Read(array, 0, array.Length))
		{
			memoryStream2.Write(array, 0, num);
		}
		gZipStream.Close();
		return memoryStream2.ToArray();
	}
}
