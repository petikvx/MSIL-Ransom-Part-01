using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common.SystemProfileInfo;

namespace PreEmptive.Analytics.Common.Tags.SystemProfileTags;

public class ModemInfoTag : Tag
{
	[CompilerGenerated]
	private ModemInfo modemInfo_0;

	public override string TagName
	{
		get
		{
			int num = 6;
			int num2 = -9516;
			int num3 = num2;
			num2 = -9516;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "\udebf특횶틋껟";
			}
		}
	}

	public ModemInfo Modem
	{
		[CompilerGenerated]
		get
		{
			int num = 28954;
			int num2 = num;
			num = 28954;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return modemInfo_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = 11050;
			int num2 = num;
			num = 11050;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			modemInfo_0 = value;
		}
	}

	public ModemInfoTag(ModemInfo modem)
	{
		AddOptionalAttribute("횿틁껖닓뛞", modem.Model);
		AddOptionalAttribute("횦틗껂닓", modem.Type);
		Modem = modem;
	}
}
