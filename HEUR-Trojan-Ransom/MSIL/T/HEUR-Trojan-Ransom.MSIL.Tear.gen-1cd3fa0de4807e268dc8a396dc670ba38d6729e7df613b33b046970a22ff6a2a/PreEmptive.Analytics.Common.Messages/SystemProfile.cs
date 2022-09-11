using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PreEmptive.Analytics.Common.SystemProfileInfo;
using PreEmptive.Analytics.Common.Tags;
using PreEmptive.Analytics.Common.Tags.SystemProfileTags;

namespace PreEmptive.Analytics.Common.Messages;

public class SystemProfile : Message
{
	[CompilerGenerated]
	private static Func<Tag, bool> func_0;

	public override string TagName
	{
		get
		{
			int num = 18;
			int num2 = 3225;
			int num3 = num2;
			num2 = 3225;
			switch (num3 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return "뛁닇뻁닂뛗닃깿刦嘠刱帴刿嘾刋";
			}
		}
	}

	public override string TagDescription
	{
		get
		{
			int num = 2;
			int num2 = -23641;
			int num3 = num2;
			num2 = -23641;
			switch (num3 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return "횡튧\udea1튢횷틃꺒닆뛀닑뻔닟뛞닋";
			}
		}
	}

	public SystemProfile(SystemInfo info, bool omitpii, Guid session, [Optional] ExtendedKeys keys, [Optional] BinaryInfoTag binary)
	{
		int num = 0;
		base._002Ector(session, keys, binary);
		List<Tag> list = new List<Tag>();
		foreach (CpuInfo cpu in info.Cpus)
		{
			list.Add(new CpuInfoTag(cpu));
		}
		foreach (DiskInfo disk in info.Disks)
		{
			list.Add(new DiskInfoTag(disk));
		}
		foreach (NetworkInfo network in info.Networks)
		{
			list.Add(new NetworkInfoTag(network, omitpii));
		}
		foreach (PageFileInfo pageFile in info.PageFiles)
		{
			list.Add(new PageFileInfoTag(pageFile));
		}
		list.Add(new MemoryInfoTag(info.Memory));
		if (info.Domain.HasValue)
		{
			list.Add(new DomainInfoTag(info.Domain.Value, omitpii));
		}
		list.Add(new TimeInfoTag(info.TimeZone));
		list.Add(new ScreenInfoTag(info.Screen));
		list.Add(new VideoInfoTag(info.Video));
		list.Add(new SoundInfoTag(info.Sound));
		list.Add(new ModemInfoTag(info.Modem));
		list.Add(new TerminalServicesInfoTag(info.TerminalServices));
		foreach (Tag item in list.Where(delegate(Tag tag_0)
		{
			int num2 = -21529;
			int num3 = num2;
			num2 = -21529;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return tag_0.Attributes.Count > 0;
			}
		}))
		{
			base.InnerTags.Add(item);
		}
		AddOptionalAttribute("튦횽튩\udeb7튤훿틝껆닗뛆닛", info.PowerState);
		AddOptionalAttribute("튻횽튺\udeb7튺", info.Model);
		AddOptionalAttribute("튻횳튰\udea7튰횳틍껆닃뛀닛뻀", info.Manufacturer);
	}

	[CompilerGenerated]
	private static bool smethod_2(Tag tag_0)
	{
		int num = -21529;
		int num2 = num;
		num = -21529;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return tag_0.Attributes.Count > 0;
		}
	}
}
