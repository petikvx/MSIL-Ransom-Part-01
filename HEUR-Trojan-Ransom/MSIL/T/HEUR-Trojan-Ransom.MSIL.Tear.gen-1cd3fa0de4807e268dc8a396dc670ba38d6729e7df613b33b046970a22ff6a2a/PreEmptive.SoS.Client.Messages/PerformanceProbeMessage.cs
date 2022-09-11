using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common;
using PreEmptive.SoS.Client.Cache;

namespace PreEmptive.SoS.Client.Messages;

public class PerformanceProbeMessage : Message
{
	[CompilerGenerated]
	private string string_0;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			int num = 5865;
			int num2 = num;
			num = 5865;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return string_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -5866;
			int num2 = num;
			num = -5866;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			string_0 = value;
		}
	}

	public PerformanceProbeMessage(string name)
	{
		Name = name;
	}

	public override void Send(CacheService cache, PlatformClient paclient)
	{
		int num = 11497;
		int num2 = num;
		num = 11497;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		BinaryInfo info = Message.ConvertBinaryInfo(base.Binary);
		ExtendedKeys keys = Message.ConvertExtendedKeys(GetExtendedKeys());
		paclient.PerformanceProbe(Name, keys, null, info);
	}
}
