using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common.SystemProfileInfo;

namespace PreEmptive.Analytics.Common.Tags.SystemProfileTags;

public class PageFileInfoTag : Tag
{
	[CompilerGenerated]
	private PageFileInfo pageFileInfo_0;

	public override string TagName
	{
		get
		{
			int num = 9;
			int num2 = 28365;
			int num3 = num2;
			num2 = 28365;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "횦튳껉닗뚛닔뻗닞뛓";
			}
		}
	}

	public PageFileInfo PageFile
	{
		[CompilerGenerated]
		get
		{
			int num = -1554;
			int num2 = num;
			num = -1554;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return pageFileInfo_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -29828;
			int num2 = num;
			num = -29828;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			pageFileInfo_0 = value;
		}
	}

	public PageFileInfoTag(PageFileInfo pagefile)
	{
		AddOptionalAttribute("횸튳껃닗", pagefile.Name);
		AddOptionalAttribute("횻튳껖", pagefile.MaxSize);
		AddOptionalAttribute("횿튼껇닆뛟닓뻒", pagefile.InitialSize);
		PageFile = pagefile;
	}
}
