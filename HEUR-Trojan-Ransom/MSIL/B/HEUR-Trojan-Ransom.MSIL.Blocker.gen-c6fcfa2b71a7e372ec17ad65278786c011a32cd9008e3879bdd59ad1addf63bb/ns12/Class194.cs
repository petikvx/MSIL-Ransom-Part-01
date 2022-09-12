using System;
using ns19;
using ns2;

namespace ns12;

internal class Class194
{
	internal Enum31 enum31_0;

	internal Enum32 enum32_0;

	internal StringComparison stringComparison_0;

	public Enum31 MergeArrayHandling
	{
		get
		{
			return enum31_0;
		}
		set
		{
			if (value < Enum31.const_0 || value > Enum31.const_3)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum31_0 = value;
		}
	}

	public Enum32 MergeNullValueHandling
	{
		get
		{
			return enum32_0;
		}
		set
		{
			if (value < Enum32.flag_0 || value > Enum32.flag_1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum32_0 = value;
		}
	}

	public StringComparison PropertyNameComparison
	{
		get
		{
			return stringComparison_0;
		}
		set
		{
			if (value < StringComparison.CurrentCulture || value > StringComparison.OrdinalIgnoreCase)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			stringComparison_0 = value;
		}
	}

	public Class194()
	{
		stringComparison_0 = StringComparison.Ordinal;
	}
}
