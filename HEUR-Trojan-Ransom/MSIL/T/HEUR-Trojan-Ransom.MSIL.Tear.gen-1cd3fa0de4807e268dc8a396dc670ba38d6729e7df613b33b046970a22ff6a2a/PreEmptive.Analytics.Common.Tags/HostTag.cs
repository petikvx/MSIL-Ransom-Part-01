using System.Runtime.CompilerServices;

namespace PreEmptive.Analytics.Common.Tags;

public class HostTag : Tag
{
	[CompilerGenerated]
	private HostInfo hostInfo_0;

	public override string TagName
	{
		get
		{
			int num = 14;
			int num2 = -24767;
			int num3 = num2;
			num2 = -24767;
			switch (num3 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return "껚닙뛁닊";
			}
		}
	}

	public HostInfo HostInfo
	{
		[CompilerGenerated]
		get
		{
			int num = -30138;
			int num2 = num;
			num = -30138;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return hostInfo_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -14810;
			int num2 = num;
			num = -14810;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			hostInfo_0 = value;
		}
	}

	public HostTag(HostInfo hostInfo, OSInfo osInfo, bool omitPII)
	{
		int num = 6;
		base._002Ector();
		if (omitPII)
		{
			hostInfo.IPAddress = "\udee3틤훥튀꺂늘뚂느뺃";
			hostInfo.Name = "\ude9c틹횓";
		}
		HostInfo = hostInfo;
		AddAttribute("\udebb튦", hostInfo.IPAddress);
		AddAttribute("\udebe특횱틏껞닓", hostInfo.Locale);
		AddOptionalAttribute("\udebc튷횿틋", hostInfo.Name);
		if (hostInfo.Virtualized.HasValue)
		{
			AddAttribute("\udea4튿횠틚껇닗뛞닗뻈닓뛖", hostInfo.Virtualized.ToString()!.ToLowerInvariant());
		}
		AddAttribute("\udea1튤횱튃껞닗뛜닙", hostInfo.SourceLangName);
		AddAttribute("\udea1튤횱튃껞닗뛜닙뺟닀뛗닜", hostInfo.SourceLangVersion);
		base.InnerTags.Add(new OSTag(osInfo, omitPII));
	}
}
