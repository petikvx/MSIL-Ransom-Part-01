using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common.SystemProfileInfo;

namespace PreEmptive.Analytics.Common.Tags.SystemProfileTags;

public class TerminalServicesInfoTag : Tag
{
	[CompilerGenerated]
	private TerminalServicesInfo terminalServicesInfo_0;

	public override string TagName
	{
		get
		{
			int num = 16;
			int num2 = -1887;
			int num3 = num2;
			num2 = -1887;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "닂뛗닌뻟닟뛜닏긾剻嘡刻帠删嘻刍渗爅";
			}
		}
	}

	public TerminalServicesInfo TerminalServices
	{
		[CompilerGenerated]
		get
		{
			if (1 == 0)
			{
			}
			int num = -8206;
			int num2 = num;
			num = -8206;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				return terminalServicesInfo_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -26711;
			int num2 = num;
			num = -26711;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			terminalServicesInfo_0 = value;
		}
	}

	public TerminalServicesInfoTag(TerminalServicesInfo info)
	{
		int num = 4;
		base._002Ector();
		if (info.Mode.HasValue)
		{
			AddOptionalAttribute("튳\udebd튲횷", ((int)info.Mode.Value).ToString());
		}
		AddOptionalAttribute("튽\udebd트횼틋껑닂뛛닑뻜닅뚟닏긾刺嘽利帷刲", info.ConnectionsAllowed);
		AddOptionalAttribute("튲\udebb튵횷틀껁닟뛜닙뺟님뛓닃긷", info.Licensing);
		TerminalServices = info;
	}
}
