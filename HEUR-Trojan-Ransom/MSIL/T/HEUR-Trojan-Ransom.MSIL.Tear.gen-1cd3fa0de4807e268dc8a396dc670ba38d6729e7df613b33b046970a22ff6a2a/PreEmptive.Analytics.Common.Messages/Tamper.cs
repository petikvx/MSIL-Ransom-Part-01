using System;
using System.Runtime.InteropServices;
using PreEmptive.Analytics.Common.Tags;

namespace PreEmptive.Analytics.Common.Messages;

public class Tamper : Message
{
	public override string TagName
	{
		get
		{
			int num = 19;
			if (1 == 0)
			{
			}
			int num2 = -5617;
			int num3 = num2;
			num2 = -5617;
			switch (num3 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				return "닆뻟닟뛆닗껜";
			}
		}
	}

	public override string TagDescription
	{
		get
		{
			int num = 10;
			int num2 = 4418;
			int num3 = num2;
			num2 = 4418;
			switch (num3 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return "횦틏껟닆뛗닌뺒님뛝닚긻到嘻刽帳刢嘻刁渜";
			}
		}
	}

	public Tamper(Guid session, [Optional] ExtendedKeys keys, [Optional] BinaryInfoTag binary)
		: base(session, keys, binary)
	{
	}
}
