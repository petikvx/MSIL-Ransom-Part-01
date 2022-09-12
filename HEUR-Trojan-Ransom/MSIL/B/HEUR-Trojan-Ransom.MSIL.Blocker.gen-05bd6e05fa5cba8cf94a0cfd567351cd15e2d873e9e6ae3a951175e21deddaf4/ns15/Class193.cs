using System;
using ns12;
using ns14;
using ns18;

namespace ns15;

internal class Class193
{
	internal Enum28 enum28_0;

	internal Enum30 enum30_0;

	internal Enum29 enum29_0;

	public Enum28 CommentHandling
	{
		get
		{
			return enum28_0;
		}
		set
		{
			if (value < Enum28.const_0 || value > Enum28.const_1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum28_0 = value;
		}
	}

	public Enum30 LineInfoHandling
	{
		get
		{
			return enum30_0;
		}
		set
		{
			if (value < Enum30.const_0 || value > Enum30.const_1)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum30_0 = value;
		}
	}

	public Enum29 DuplicatePropertyNameHandling
	{
		get
		{
			return enum29_0;
		}
		set
		{
			if (value < Enum29.const_0 || value > Enum29.const_2)
			{
				throw new ArgumentOutOfRangeException("value");
			}
			enum29_0 = value;
		}
	}

	public Class193()
	{
		enum30_0 = Enum30.const_1;
		enum28_0 = Enum28.const_0;
		enum29_0 = Enum29.const_0;
	}
}
