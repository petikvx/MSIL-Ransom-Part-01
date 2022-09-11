using System;
using PreEmptive.Analytics.Common.Tags;
using PreEmptive.Analytics.Common.Tags.PerformanceProbeTags;

namespace PreEmptive.Analytics.Common.Messages;

public class PerformanceProbe : Message
{
	public override string TagName
	{
		get
		{
			int num = 10;
			int num2 = 5565;
			int num3 = num2;
			num2 = 5565;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "횢틋껀닐뛝닌뻟닗뛜닍긷剻嘢刬帽刴嘷";
			}
		}
	}

	public override string TagDescription
	{
		get
		{
			int num = 13;
			int num2 = 26220;
			int num3 = num2;
			num2 = 26220;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "껞닗뛄닔뻑닀뛛닓껀刱嘳割帮删嘹到渋";
			}
		}
	}

	public PerformanceProbe(string name, PerformanceInfo performance, ExtendedKeys keys, Guid session, BinaryInfoTag binaryInfo)
	{
		int num = 18;
		base._002Ector(session, keys, binaryInfo);
		if (performance == null)
		{
			performance = new PerformanceInfo
			{
				CpuUtilization = null,
				TotalMemory = null,
				UsedMemory = null
			};
		}
		AddAttribute("뛜닟뻟닓", name);
		base.InnerTags.Add(new MemoryUseTag(performance.TotalMemory, performance.UsedMemory));
		if (performance.CpuUtilization.HasValue)
		{
			base.InnerTags.Add(new CpuUseTag(performance.CpuUtilization));
		}
	}
}
