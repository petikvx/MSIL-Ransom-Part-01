using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common.SystemProfileInfo;

namespace PreEmptive.Analytics.Common.Tags.SystemProfileTags;

public class NetworkInfoTag : Tag
{
	[CompilerGenerated]
	private NetworkInfo networkInfo_0;

	public override string TagName
	{
		get
		{
			int num = 16;
			int num2 = 24439;
			int num3 = num2;
			num2 = 24439;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "님뛗닊뻅닙뛀닅";
			}
		}
	}

	public NetworkInfo Network
	{
		[CompilerGenerated]
		get
		{
			if (1 == 0)
			{
			}
			int num = 10831;
			int num2 = num;
			num = 10831;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				return networkInfo_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = 16017;
			int num2 = num;
			num = 16017;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			networkInfo_0 = value;
		}
	}

	public NetworkInfoTag(NetworkInfo network, bool omitpii)
	{
		int num = 2;
		base._002Ector();
		if (omitpii)
		{
			network.MacAddress = null;
			network.IpAddress = null;
			network.Name = null;
		}
		AddOptionalAttribute("횡튮\udeb7튳횶", network.Speed);
		AddOptionalAttribute("횿튿\udeaa틻횡틞껗닓뛖", network.MaxSpeed);
		AddOptionalAttribute("횶튶\udeb1튦", network.UsesDhcp);
		AddOptionalAttribute("횻튮", network.IpAddress);
		AddOptionalAttribute("횿튿\udeb1", network.MacAddress);
		AddOptionalAttribute("횱튱\udebc트훿틇껖", network.Name);
		Network = network;
	}
}
