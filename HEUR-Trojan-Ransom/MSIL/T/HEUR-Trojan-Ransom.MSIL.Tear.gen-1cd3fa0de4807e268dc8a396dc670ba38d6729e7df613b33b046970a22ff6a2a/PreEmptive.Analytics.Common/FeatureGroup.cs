using System;
using System.Runtime.CompilerServices;

namespace PreEmptive.Analytics.Common;

public class FeatureGroup
{
	[CompilerGenerated]
	private Guid guid_0;

	[CompilerGenerated]
	private string string_0;

	public Guid UniqueId
	{
		[CompilerGenerated]
		get
		{
			int num = 30706;
			int num2 = num;
			num = 30706;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return guid_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -5527;
			int num2 = num;
			num = -5527;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			guid_0 = value;
		}
	}

	public string PartitionId
	{
		[CompilerGenerated]
		get
		{
			int num = -16224;
			int num2 = num;
			num = -16224;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return string_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -17702;
			int num2 = num;
			num = -17702;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			string_0 = value;
		}
	}

	public FeatureGroup(Guid guid, string partition)
	{
		UniqueId = guid;
		PartitionId = partition;
	}
}
