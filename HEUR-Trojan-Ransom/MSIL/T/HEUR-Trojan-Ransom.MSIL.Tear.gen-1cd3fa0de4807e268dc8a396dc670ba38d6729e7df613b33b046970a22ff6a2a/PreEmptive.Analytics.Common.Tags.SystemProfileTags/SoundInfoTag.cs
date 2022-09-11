using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common.SystemProfileInfo;

namespace PreEmptive.Analytics.Common.Tags.SystemProfileTags;

public class SoundInfoTag : Tag
{
	[CompilerGenerated]
	private SoundInfo soundInfo_0;

	public override string TagName
	{
		get
		{
			int num = 0;
			int num2 = -30543;
			int num3 = num2;
			num2 = -30543;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "튥횽튫\udebc튲";
			}
		}
	}

	public SoundInfo Sound
	{
		[CompilerGenerated]
		get
		{
			int num = 12459;
			int num2 = num;
			num = 12459;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return soundInfo_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = 10891;
			int num2 = num;
			num = 10891;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			soundInfo_0 = value;
		}
	}

	public SoundInfoTag(SoundInfo sound)
	{
		AddOptionalAttribute("튿\udeb1튶횳튾", sound.Model);
		AddOptionalAttribute("튿\udebf튼횣튴껏닑뛂닇뻌닗뛄", sound.Manufacturer);
		Sound = sound;
	}
}
