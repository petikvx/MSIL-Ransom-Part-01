using System.Runtime.CompilerServices;

namespace PreEmptive.Analytics.Common.Tags.PerformanceProbeTags;

public class MemoryUseTag : Tag
{
	[CompilerGenerated]
	private int? nullable_0;

	[CompilerGenerated]
	private int? nullable_1;

	public int? Available
	{
		[CompilerGenerated]
		get
		{
			int num = 12541;
			int num2 = num;
			num = 12541;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return nullable_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -15759;
			int num2 = num;
			num = -15759;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			nullable_0 = value;
		}
	}

	public int? Used
	{
		[CompilerGenerated]
		get
		{
			int num = -26627;
			int num2 = num;
			num = -26627;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return nullable_1;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = 24076;
			int num2 = num;
			num = 24076;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			nullable_1 = value;
		}
	}

	public override string TagName
	{
		get
		{
			int num = 13;
			int num2 = -22810;
			int num3 = num2;
			num2 = -22810;
			switch (num3 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return "껃닗뛛닝뻌닋";
			}
		}
	}

	public MemoryUseTag(int? available, int? used)
	{
		int num = 10;
		base._002Ector();
		Available = available;
		Used = used;
		if (available.HasValue)
		{
			AddOptionalAttribute("횳틘껓닟뛞닟뻐닚뛗", available);
		}
		if (used.HasValue)
		{
			AddOptionalAttribute("횧틝껗닒", used);
		}
	}
}
