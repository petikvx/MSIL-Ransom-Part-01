using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common.SystemProfileInfo;

namespace PreEmptive.Analytics.Common.Tags.SystemProfileTags;

public class DomainInfoTag : Tag
{
	[CompilerGenerated]
	private DomainInfo domainInfo_0;

	public override string TagName
	{
		get
		{
			int num = 9;
			int num2 = -2810;
			int num3 = num2;
			num2 = -2810;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "횲튽껃닓뛟닜";
			}
		}
	}

	public DomainInfo Domain
	{
		[CompilerGenerated]
		get
		{
			int num = -26432;
			int num2 = num;
			num = -26432;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return domainInfo_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = 99;
			int num2 = num;
			num = 99;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			domainInfo_0 = value;
		}
	}

	public DomainInfoTag(DomainInfo domain, bool omitpii)
	{
		int num = 16;
		base._002Ector();
		if (omitpii)
		{
			domain.Name = null;
			domain.Role = null;
		}
		AddOptionalAttribute("님뛓닓뻗", domain.Name);
		AddOptionalAttribute("닄뛝닒뻗", domain.Role);
		AddAttribute("닛뛗닓뻐닓뛀", domain.MemberOf.ToString().ToLowerInvariant());
		Domain = domain;
	}
}
