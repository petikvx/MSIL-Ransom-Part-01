using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core;

public class ExtendedPathFilter : PathFilter
{
	private DateTime tYkFgghBjGZpoGVJdoIFISAGGrygB;

	private long LzQISOuXmEoCiNLhXgWyCJHFKmjH;

	private DateTime fCozpvrmfbnaTpototoMhdXLZysI;

	private long nAUAZyhdTmoVbKgoybMaqzUgbZZLA;

	public DateTime MaxDate
	{
		get
		{
			return tYkFgghBjGZpoGVJdoIFISAGGrygB;
		}
		set
		{
			if (fCozpvrmfbnaTpototoMhdXLZysI > value)
			{
				throw new ArgumentOutOfRangeException("value", "Exceeds MinDate");
			}
			tYkFgghBjGZpoGVJdoIFISAGGrygB = value;
		}
	}

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

	public DateTime MinDate
	{
		get
		{
			return fCozpvrmfbnaTpototoMhdXLZysI;
		}
		set
		{
			if (value > tYkFgghBjGZpoGVJdoIFISAGGrygB)
			{
				throw new ArgumentOutOfRangeException("value", "Exceeds MaxDate");
			}
			fCozpvrmfbnaTpototoMhdXLZysI = value;
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

	public ExtendedPathFilter(string filter, DateTime minDate, DateTime maxDate)
		: base(filter)
	{
		LzQISOuXmEoCiNLhXgWyCJHFKmjH = long.MaxValue;
		fCozpvrmfbnaTpototoMhdXLZysI = DateTime.MinValue;
		tYkFgghBjGZpoGVJdoIFISAGGrygB = DateTime.MaxValue;
		MinDate = minDate;
		MaxDate = maxDate;
	}

	public ExtendedPathFilter(string filter, long minSize, long maxSize)
		: base(filter)
	{
		LzQISOuXmEoCiNLhXgWyCJHFKmjH = long.MaxValue;
		fCozpvrmfbnaTpototoMhdXLZysI = DateTime.MinValue;
		tYkFgghBjGZpoGVJdoIFISAGGrygB = DateTime.MaxValue;
		MinSize = minSize;
		MaxSize = maxSize;
	}

	public ExtendedPathFilter(string filter, long minSize, long maxSize, DateTime minDate, DateTime maxDate)
		: base(filter)
	{
		LzQISOuXmEoCiNLhXgWyCJHFKmjH = long.MaxValue;
		fCozpvrmfbnaTpototoMhdXLZysI = DateTime.MinValue;
		tYkFgghBjGZpoGVJdoIFISAGGrygB = DateTime.MaxValue;
		MinSize = minSize;
		MaxSize = maxSize;
		MinDate = minDate;
		MaxDate = maxDate;
	}

	public override bool IsMatch(string name)
	{
		bool result;
		if (result = base.IsMatch(name))
		{
			FileInfo fileInfo = new FileInfo(name);
			result = MinSize <= fileInfo.Length && MaxSize >= fileInfo.Length && MinDate <= fileInfo.LastWriteTime && MaxDate >= fileInfo.LastWriteTime;
		}
		return result;
	}
}
