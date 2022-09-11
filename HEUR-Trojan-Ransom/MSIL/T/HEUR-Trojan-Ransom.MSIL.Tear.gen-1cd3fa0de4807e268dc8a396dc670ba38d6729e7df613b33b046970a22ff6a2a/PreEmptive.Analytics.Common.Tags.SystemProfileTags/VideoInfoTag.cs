using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common.SystemProfileInfo;

namespace PreEmptive.Analytics.Common.Tags.SystemProfileTags;

public class VideoInfoTag : Tag
{
	[CompilerGenerated]
	private VideoInfo videoInfo_0;

	public override string TagName
	{
		get
		{
			int num = 10;
			int num2 = -24113;
			int num3 = num2;
			num2 = -24113;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "횤틇껖닓뛝";
			}
		}
	}

	public VideoInfo Video
	{
		[CompilerGenerated]
		get
		{
			int num = -11933;
			int num2 = num;
			num = -11933;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return videoInfo_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = 16277;
			int num2 = num;
			num = 16277;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			videoInfo_0 = value;
		}
	}

	public VideoInfoTag(VideoInfo video)
	{
		AddOptionalAttribute("틀껓닛뛗", video.Name);
		AddOptionalAttribute("틊껀닟뛄닛뻀", video.Driver);
		AddOptionalAttribute("틃껗닛뛝닌뻋", video.Memory);
		AddOptionalAttribute("틍껝닚뛝닌뻁", video.Colors);
		Video = video;
	}
}
