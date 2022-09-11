using System.Runtime.CompilerServices;

namespace PreEmptive.Analytics.Common.Tags.PerformanceProbeTags;

public class CpuUseTag : Tag
{
	[CompilerGenerated]
	private int? nullable_0;

	public int? Utilization
	{
		[CompilerGenerated]
		get
		{
			int num = 1588;
			int num2 = num;
			num = 1588;
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
			int num = 26113;
			int num2 = num;
			num = 26113;
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

	public override string TagName
	{
		get
		{
			int num = 8;
			if (1 == 0)
			{
			}
			int num2 = 32121;
			int num3 = num2;
			num2 = 32121;
			switch (num3 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				return "튵횢틛";
			}
		}
	}

	public CpuUseTag(int? utilization)
	{
		Utilization = utilization;
		AddOptionalAttribute("튣횦튷\udebe튿효틏껆닟뛝닐", utilization);
	}
}
