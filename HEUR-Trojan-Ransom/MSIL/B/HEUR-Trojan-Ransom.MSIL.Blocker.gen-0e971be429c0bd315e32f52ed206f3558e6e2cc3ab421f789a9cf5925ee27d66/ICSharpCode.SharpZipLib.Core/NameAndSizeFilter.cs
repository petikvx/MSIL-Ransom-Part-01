using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core;

[Obsolete("Use ExtendedPathFilter instead")]
public class NameAndSizeFilter : PathFilter
{
	private long UJAKmvIeidHKcdgGUNvZdcMCTridb;

	private long gnGlSLZCDJjszZPPbDjRNDTziiGH;

	public long MaxSize
	{
		get
		{
			return UJAKmvIeidHKcdgGUNvZdcMCTridb;
		}
		set
		{
			if (value < 0L || gnGlSLZCDJjszZPPbDjRNDTziiGH > value)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			UJAKmvIeidHKcdgGUNvZdcMCTridb = value;
		}
	}

	public long MinSize
	{
		get
		{
			return gnGlSLZCDJjszZPPbDjRNDTziiGH;
		}
		set
		{
			if (value < 0L || UJAKmvIeidHKcdgGUNvZdcMCTridb < value)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			gnGlSLZCDJjszZPPbDjRNDTziiGH = value;
		}
	}

	public NameAndSizeFilter(string filter, long minSize, long maxSize)
		: base(filter)
	{
		UJAKmvIeidHKcdgGUNvZdcMCTridb = long.MaxValue;
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
