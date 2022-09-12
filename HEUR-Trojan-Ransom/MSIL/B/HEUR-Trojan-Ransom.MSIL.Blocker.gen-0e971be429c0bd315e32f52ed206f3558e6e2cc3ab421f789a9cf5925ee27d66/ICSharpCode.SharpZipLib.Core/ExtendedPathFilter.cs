using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Core;

public class ExtendedPathFilter : PathFilter
{
	private DateTime akgGiPdrBrTXkwoJoFpmcDrFGxtc;

	private long UJAKmvIeidHKcdgGUNvZdcMCTridb;

	private DateTime koqoVITsdGxJBYfIvMknZdKEhwrFA;

	private long gnGlSLZCDJjszZPPbDjRNDTziiGH;

	public DateTime MaxDate
	{
		get
		{
			return akgGiPdrBrTXkwoJoFpmcDrFGxtc;
		}
		set
		{
			if (koqoVITsdGxJBYfIvMknZdKEhwrFA > value)
			{
				throw new ArgumentOutOfRangeException("value", "Exceeds MinDate");
			}
			akgGiPdrBrTXkwoJoFpmcDrFGxtc = value;
		}
	}

	public long MaxSize
	{
		get
		{
			return UJAKmvIeidHKcdgGUNvZdcMCTridb;
		}
		set
		{
			if (value < 0L)
			{
				goto IL_0026;
			}
			goto IL_0050;
			IL_0050:
			int num = -1918576284;
			goto IL_0031;
			IL_0031:
			int num2;
			while (true)
			{
				switch ((uint)(num ^ -496713747) % 4u)
				{
				case 1u:
					break;
				case 0u:
					goto end_IL_0031;
				case 3u:
					throw new ArgumentOutOfRangeException("value");
				default:
					UJAKmvIeidHKcdgGUNvZdcMCTridb = value;
					return;
				}
				if (gnGlSLZCDJjszZPPbDjRNDTziiGH <= value)
				{
					num = -509270965;
					num2 = -509270965;
					continue;
				}
				goto IL_0026;
				continue;
				end_IL_0031:
				break;
			}
			goto IL_0050;
			IL_0026:
			num = -797954378;
			num2 = -797954378;
			goto IL_0031;
		}
	}

	public DateTime MinDate
	{
		get
		{
			return koqoVITsdGxJBYfIvMknZdKEhwrFA;
		}
		set
		{
			if (value > akgGiPdrBrTXkwoJoFpmcDrFGxtc)
			{
				throw new ArgumentOutOfRangeException("value", "Exceeds MaxDate");
			}
			koqoVITsdGxJBYfIvMknZdKEhwrFA = value;
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
			if (value < 0L)
			{
				goto IL_0034;
			}
			goto IL_0062;
			IL_0062:
			int num = -1149325351;
			goto IL_003f;
			IL_003f:
			int num2;
			while (true)
			{
				switch ((uint)(num ^ -374182161) % 5u)
				{
				case 4u:
					gnGlSLZCDJjszZPPbDjRNDTziiGH = value;
					num = -1745361455;
					continue;
				case 3u:
					break;
				default:
					return;
				case 0u:
					goto end_IL_003f;
				case 2u:
					throw new ArgumentOutOfRangeException("value");
				case 1u:
					return;
				}
				if (UJAKmvIeidHKcdgGUNvZdcMCTridb >= value)
				{
					num = -235726424;
					num2 = -235726424;
					continue;
				}
				goto IL_0034;
				continue;
				end_IL_003f:
				break;
			}
			goto IL_0062;
			IL_0034:
			num = -109010278;
			num2 = -109010278;
			goto IL_003f;
		}
	}

	public ExtendedPathFilter(string filter, DateTime minDate, DateTime maxDate)
		: base(filter)
	{
		UJAKmvIeidHKcdgGUNvZdcMCTridb = long.MaxValue;
		koqoVITsdGxJBYfIvMknZdKEhwrFA = DateTime.MinValue;
		akgGiPdrBrTXkwoJoFpmcDrFGxtc = DateTime.MaxValue;
		MinDate = minDate;
		MaxDate = maxDate;
	}

	public ExtendedPathFilter(string filter, long minSize, long maxSize)
		: base(filter)
	{
		UJAKmvIeidHKcdgGUNvZdcMCTridb = long.MaxValue;
		koqoVITsdGxJBYfIvMknZdKEhwrFA = DateTime.MinValue;
		akgGiPdrBrTXkwoJoFpmcDrFGxtc = DateTime.MaxValue;
		MinSize = minSize;
		MaxSize = maxSize;
	}

	public ExtendedPathFilter(string filter, long minSize, long maxSize, DateTime minDate, DateTime maxDate)
		: base(filter)
	{
		UJAKmvIeidHKcdgGUNvZdcMCTridb = long.MaxValue;
		koqoVITsdGxJBYfIvMknZdKEhwrFA = DateTime.MinValue;
		akgGiPdrBrTXkwoJoFpmcDrFGxtc = DateTime.MaxValue;
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
