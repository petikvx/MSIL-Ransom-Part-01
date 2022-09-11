using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common.SystemProfileInfo;

namespace PreEmptive.Analytics.Common.Tags.SystemProfileTags;

public class MemoryInfoTag : Tag
{
	[CompilerGenerated]
	private MemoryInfo memoryInfo_0;

	public override string TagName
	{
		get
		{
			int num = 8;
			int num2 = -5621;
			int num3 = num2;
			num2 = -5621;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "튻횷틃껝닄뛋";
			}
		}
	}

	public MemoryInfo Memory
	{
		[CompilerGenerated]
		get
		{
			int num = -28815;
			int num2 = num;
			num = -28815;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return memoryInfo_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			if (1 == 0)
			{
			}
			int num = 23094;
			int num2 = num;
			num = 23094;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			memoryInfo_0 = value;
		}
	}

	public MemoryInfoTag(MemoryInfo memory)
	{
		AddOptionalAttribute("튱껏닂뛗닑뻗닆뛏", memory.Capacity);
		AddOptionalAttribute("튡껞닗뛓닖", memory.Speed);
		AddOptionalAttribute("튦껁닆뛗닞", memory.Total);
		Memory = memory;
	}
}
