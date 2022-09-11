using System;
using System.Runtime.InteropServices;
using PreEmptive.Analytics.Common.Tags;

namespace PreEmptive.Analytics.Common.Messages;

public class ApplicationStart : Message
{
	public override string TagName
	{
		get
		{
			int num = 7;
			int num2 = 3646;
			int num3 = num2;
			num2 = 3646;
			switch (num3 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return "튳횦튢꺃닁뛂닓뻌닆";
			}
		}
	}

	public override string TagDescription
	{
		get
		{
			int num = 16;
			int num2 = 3281;
			int num3 = num2;
			num2 = 3281;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "닗뛂닎뻞닟뛑닏긦刿嘽到干別嘦刏渀爂";
			}
		}
	}

	public ApplicationStart(HostTag hostTag, UserTag userTag, Guid session, [Optional] ExtendedKeys keys, [Optional] BinaryInfoTag binary)
		: base(session, keys, binary)
	{
		base.InnerTags.Add(hostTag);
		base.InnerTags.Add(userTag);
	}
}
