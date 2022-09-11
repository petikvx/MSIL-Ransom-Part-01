using System;
using System.Runtime.InteropServices;
using PreEmptive.Analytics.Common.Tags;

namespace PreEmptive.Analytics.Common.Messages;

public class ApplicationStop : Message
{
	public override string TagName
	{
		get
		{
			int num = 11;
			int num2 = -19086;
			int num3 = num2;
			num2 = -19086;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "튳껞닂뚛닁뻊닝뛆";
			}
		}
	}

	public override string TagDescription
	{
		get
		{
			int num = 4;
			int num2 = -29171;
			int num3 = num2;
			num2 = -29171;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "튿\udea2튦횾틇껑닗뛆닗뻝님뚒닝긦刹嘢";
			}
		}
	}

	public ApplicationStop(HostTag host, UserTag user, Guid session, [Optional] ExtendedKeys keys, [Optional] BinaryInfoTag binary)
		: base(session, keys, binary)
	{
		base.InnerTags.Add(host);
		base.InnerTags.Add(user);
	}
}
