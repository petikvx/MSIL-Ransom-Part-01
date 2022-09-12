using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core;

[Obsolete("Use ExtendedPathFilter instead")]
public class NameAndSizeFilter : PathFilter
{
	private long LzQISOuXmEoCiNLhXgWyCJHFKmjH;

	private long nAUAZyhdTmoVbKgoybMaqzUgbZZLA;

	public long MaxSize
	{
		get
		{
			return LzQISOuXmEoCiNLhXgWyCJHFKmjH;
		}
		set
		{
			if (value < 0L || nAUAZyhdTmoVbKgoybMaqzUgbZZLA > value)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			LzQISOuXmEoCiNLhXgWyCJHFKmjH = value;
		}
	}

	public long MinSize
	{
		get
		{
			return nAUAZyhdTmoVbKgoybMaqzUgbZZLA;
		}
		set
		{
			if (value < 0L || LzQISOuXmEoCiNLhXgWyCJHFKmjH < value)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			nAUAZyhdTmoVbKgoybMaqzUgbZZLA = value;
		}
	}

	public NameAndSizeFilter(string filter, long minSize, long maxSize)
		: base(filter)
	{
		LzQISOuXmEoCiNLhXgWyCJHFKmjH = long.MaxValue;
		MinSize = minSize;
		MaxSize = maxSize;
	}

	public override bool IsMatch(string name)
	{
		bool result;
		if (result = base.IsMatch(name))
		{
			long length = new FileInfo(name).Length;
			result = MinSize <= length && MaxSize >= length;
		}
		return result;
	}
}
