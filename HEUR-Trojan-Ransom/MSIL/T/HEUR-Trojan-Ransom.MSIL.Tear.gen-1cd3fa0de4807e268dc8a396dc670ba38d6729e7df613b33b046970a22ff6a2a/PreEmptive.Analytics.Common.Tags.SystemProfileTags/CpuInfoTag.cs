using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common.SystemProfileInfo;

namespace PreEmptive.Analytics.Common.Tags.SystemProfileTags;

public class CpuInfoTag : Tag
{
	[CompilerGenerated]
	private CpuInfo cpuInfo_0;

	public override string TagName
	{
		get
		{
			int num = 16;
			int num2 = -16107;
			int num3 = num2;
			num2 = -16107;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "닕뛂닋";
			}
		}
	}

	public CpuInfo Cpu
	{
		[CompilerGenerated]
		get
		{
			int num = 24492;
			int num2 = num;
			num = 24492;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return cpuInfo_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = 13324;
			int num2 = num;
			num = 13324;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			cpuInfo_0 = value;
		}
	}

	public CpuInfoTag(CpuInfo cpuInfo_1)
	{
		AddOptionalAttribute("뛅닂뻛닗뛒", cpuInfo_1.Speed);
		AddOptionalAttribute("뛛닓뻆늟뛅닂껋刷嘲", cpuInfo_1.MaxSpeed);
		AddOptionalAttribute("뛗닖뻚닀뛓닁껝剿嘡刻帺刦嘾", cpuInfo_1.AddressWidth);
		AddOptionalAttribute("뛛닓뻐닇뛐닓껍刦嘣删帻删", cpuInfo_1.Manufacturer);
		AddOptionalAttribute("뛛닝뻚닗뛚", cpuInfo_1.Model);
		AddOptionalAttribute("뛘닓뻓닗", cpuInfo_1.Name);
		Cpu = cpuInfo_1;
	}
}
