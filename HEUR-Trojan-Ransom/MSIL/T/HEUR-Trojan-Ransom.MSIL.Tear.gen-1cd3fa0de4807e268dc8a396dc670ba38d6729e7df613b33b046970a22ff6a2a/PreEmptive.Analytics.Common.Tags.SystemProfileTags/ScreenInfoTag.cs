using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common.SystemProfileInfo;

namespace PreEmptive.Analytics.Common.Tags.SystemProfileTags;

public class ScreenInfoTag : Tag
{
	[CompilerGenerated]
	private ScreenInfo screenInfo_0;

	public override string TagName
	{
		get
		{
			int num = 11;
			int num2 = 7371;
			int num3 = num2;
			num2 = 7371;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "튡껍닀뛓닗뻐";
			}
		}
	}

	public ScreenInfo Screen
	{
		[CompilerGenerated]
		get
		{
			int num = -2325;
			int num2 = num;
			num = -2325;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return screenInfo_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -18652;
			int num2 = num;
			num = -18652;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			screenInfo_0 = value;
		}
	}

	public ScreenInfoTag(ScreenInfo screen)
	{
		AddOptionalAttribute("닅뻗닖뛂닚", screen.Width);
		AddOptionalAttribute("닚뻛닛뛑닚껚", screen.Height);
		AddOptionalAttribute("닜뻟닟뛓", screen.Name);
		AddOptionalAttribute("닀뻛닔뛄닗껝刺", screen.RefreshRate);
		Screen = screen;
	}
}
