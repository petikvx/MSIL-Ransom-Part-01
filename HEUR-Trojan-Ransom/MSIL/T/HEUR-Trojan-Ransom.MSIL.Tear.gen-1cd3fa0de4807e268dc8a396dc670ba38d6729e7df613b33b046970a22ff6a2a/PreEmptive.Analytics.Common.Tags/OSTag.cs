using System.Runtime.CompilerServices;

namespace PreEmptive.Analytics.Common.Tags;

public class OSTag : Tag
{
	[CompilerGenerated]
	private OSInfo osinfo_0;

	public override string TagName
	{
		get
		{
			int num = 18;
			int num2 = -9478;
			int num3 = num2;
			num2 = -9478;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "뛝닍";
			}
		}
	}

	public OSInfo OSInfo
	{
		[CompilerGenerated]
		get
		{
			int num = -29396;
			int num2 = num;
			num = -29396;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return osinfo_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = 2302;
			int num2 = num;
			num = 2302;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			osinfo_0 = value;
		}
	}

	public OSTag(OSInfo osInfo, bool omitPII)
	{
		int num = 17;
		base._002Ector();
		if (omitPII)
		{
			osInfo.ProductCode = null;
		}
		OSInfo = osInfo;
		AddAttribute("뛘닓뻓닗", osInfo.Name);
		AddAttribute("뛅닂뺓닟뛗님껁删", osInfo.ServicePackVersionMajor.ToString());
		AddAttribute("뛅닂뺓닟뛟닜껁删", osInfo.ServicePackVersionMinor.ToString());
		AddOptionalAttribute("뛆닀뻑닖뛃닑껚剿嘵刽帺刷", osInfo.ProductCode);
		AddOptionalAttribute("뛟닜뻍닆뛗닞껂刷嘲剿帺刳嘢刷", osInfo.InstallDate);
		AddOptionalAttribute("뛚닓뻐닕뛃닓껉刷", osInfo.Language);
	}
}
