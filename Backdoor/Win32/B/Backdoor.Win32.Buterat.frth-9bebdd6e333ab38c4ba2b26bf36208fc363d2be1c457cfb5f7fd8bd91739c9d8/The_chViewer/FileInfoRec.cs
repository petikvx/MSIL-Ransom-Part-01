using System;
using System.IO;

namespace The_chViewer;

public class FileInfoRec
{
	private int timeZ;

	private int date;

	private int idx;

	public FileInfoRec(BinaryReader buf)
	{
		timeZ = GetInt(buf);
		date = GetInt(buf);
		idx = GetInt(buf);
	}

	private int GetInt(BinaryReader buf)
	{
		try
		{
			return buf.ReadByte() * 256 * 256 * 256 + buf.ReadByte() * 256 * 256 + buf.ReadByte() * 256 + buf.ReadByte();
		}
		catch (Exception)
		{
			return 0;
		}
	}

	public override string ToString()
	{
		return "[FileInfoRec: timeZ = " + timeZ + ", date = " + ParseDate(date) + ", idx = " + idx + "]";
	}

	private static string ParseTime(int rawTime)
	{
		int num = rawTime / 10000 + 3;
		int num2 = (rawTime - num * 10000) / 100;
		int num3 = rawTime - num * 10000 - num2 * 100;
		return $"{num}:{num2}:{num3}";
	}

	private static string ParseDate(int rawDate)
	{
		int num = rawDate / 10000;
		int num2 = (rawDate - num * 10000) / 100;
		int num3 = rawDate - num * 10000 - num2 * 100;
		DateTime.FromBinary(rawDate);
		return $"{num}.{num2}.{num3}";
	}

	public int getIdx()
	{
		return idx;
	}
}
