using System;
using System.Text;

namespace Alphaleonis.Win32.Filesystem;

public struct AlternateDataStreamInfo
{
	private readonly string _fullPath;

	public string StreamName { get; private set; }

	public long Size { get; private set; }

	public string FullPath => _fullPath + Path.StreamSeparator + StreamName + Path.StreamDataLabel;

	internal AlternateDataStreamInfo(string fullPath, NativeMethods.WIN32_FIND_STREAM_DATA findData)
	{
		this = default(AlternateDataStreamInfo);
		StreamName = ParseStreamName(findData.cStreamName);
		Size = findData.StreamSize;
		_fullPath = fullPath;
	}

	public override int GetHashCode()
	{
		return StreamName.GetHashCode();
	}

	public override bool Equals(object obj)
	{
		if (obj is AlternateDataStreamInfo alternateDataStreamInfo)
		{
			if (StreamName.Equals(alternateDataStreamInfo.StreamName, StringComparison.OrdinalIgnoreCase))
			{
				return Size.Equals(alternateDataStreamInfo.Size);
			}
			return false;
		}
		return false;
	}

	public static bool operator ==(AlternateDataStreamInfo first, AlternateDataStreamInfo second)
	{
		return first.Equals(second);
	}

	public static bool operator !=(AlternateDataStreamInfo first, AlternateDataStreamInfo second)
	{
		return !first.Equals(second);
	}

	private static string ParseStreamName(string streamName)
	{
		if (streamName != null && streamName.Length >= 2)
		{
			if (streamName[0] != Path.StreamSeparatorChar)
			{
				throw new ArgumentException(Resources.Invalid_Stream_Name, "streamName");
			}
			StringBuilder stringBuilder = new StringBuilder(streamName.Length);
			int i = 1;
			for (int length = streamName.Length; i < length && streamName[i] != Path.StreamSeparatorChar; i++)
			{
				stringBuilder.Append(streamName[i]);
			}
			return stringBuilder.ToString();
		}
		return string.Empty;
	}
}
