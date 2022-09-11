using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common.SystemProfileInfo;

namespace PreEmptive.Analytics.Common.Tags.SystemProfileTags;

public class TimeInfoTag : Tag
{
	[CompilerGenerated]
	private TimeInfo timeInfo_0;

	public override string TagName
	{
		get
		{
			int num = 11;
			int num2 = 13598;
			int num3 = num2;
			num2 = 13598;
			switch (num3 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return "튦껇닟뛓늟뻄닝뛘닗";
			}
		}
	}

	public TimeInfo TimeZone
	{
		[CompilerGenerated]
		get
		{
			int num = -11619;
			int num2 = num;
			num = -11619;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return timeInfo_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = 4356;
			int num2 = num;
			num = 4356;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			timeInfo_0 = value;
		}
	}

	public TimeInfoTag(TimeInfo timezone)
	{
		AddOptionalAttribute("튨\udeb1튼횳", timezone.Zone);
		AddOptionalAttribute("튶\udead튦", timezone.DaylightSavingsInEffect);
		TimeZone = timezone;
	}
}
