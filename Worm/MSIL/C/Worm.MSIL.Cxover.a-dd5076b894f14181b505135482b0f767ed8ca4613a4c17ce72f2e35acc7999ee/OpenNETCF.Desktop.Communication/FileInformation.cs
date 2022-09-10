using System;
using System.Text;

namespace OpenNETCF.Desktop.Communication;

public class FileInformation
{
	private byte[] data = new byte[512];

	public int FileAttributes => BitConverter.ToInt32(data, 0);

	public DateTime CreateTime
	{
		get
		{
			long fileTime = BitConverter.ToInt64(data, 4);
			return DateTime.FromFileTime(fileTime);
		}
	}

	public DateTime LastAccessTime
	{
		get
		{
			long fileTime = BitConverter.ToInt64(data, 12);
			return DateTime.FromFileTime(fileTime);
		}
	}

	public DateTime LastWriteTime
	{
		get
		{
			long fileTime = BitConverter.ToInt64(data, 20);
			return DateTime.FromFileTime(fileTime);
		}
	}

	public long FileSize => BitConverter.ToInt32(data, 28) + BitConverter.ToInt32(data, 32);

	public string FileName
	{
		get
		{
			string @string = Encoding.Unicode.GetString(data, 40, 256);
			char[] trimChars = new char[1];
			return @string.TrimEnd(trimChars);
		}
	}

	public static implicit operator byte[](FileInformation fi)
	{
		return fi.data;
	}
}
