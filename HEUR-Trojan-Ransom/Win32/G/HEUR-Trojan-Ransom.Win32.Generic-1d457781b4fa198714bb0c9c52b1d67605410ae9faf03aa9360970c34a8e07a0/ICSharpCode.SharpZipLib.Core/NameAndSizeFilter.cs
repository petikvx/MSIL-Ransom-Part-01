using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core;

[Obsolete("Use ExtendedPathFilter instead")]
public class NameAndSizeFilter : PathFilter
{
	private long minSize_;

	private long maxSize_ = long.MaxValue;

	public long MinSize
	{
		get
		{
			return minSize_;
		}
		set
		{
			if (value < 0L || maxSize_ < value)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			minSize_ = value;
		}
	}

	public long MaxSize
	{
		get
		{
			return maxSize_;
		}
		set
		{
			if (value < 0L || minSize_ > value)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			maxSize_ = value;
		}
	}

	public NameAndSizeFilter(string filter, long minSize, long maxSize)
		: base(filter)
	{
		MinSize = minSize;
		MaxSize = maxSize;
	}

	public override bool IsMatch(string name)
	{
		bool result;
		if (result = base.IsMatch(name))
		{
			FileInfo fileInfo = new FileInfo(name);
			long length = fileInfo.Length;
			result = MinSize <= length && MaxSize >= length;
		}
		return result;
	}
}
