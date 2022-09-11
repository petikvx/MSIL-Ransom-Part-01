using System;
using System.Runtime.InteropServices;
using PreEmptive.Analytics.Common.Tags;

namespace PreEmptive.Analytics.Common.Messages;

public class SessionStop : Message
{
	public override string TagName
	{
		get
		{
			int num = 19;
			int num2 = -26651;
			int num3 = num2;
			num2 = -26651;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "닁뻛닁뛅닛껁刼噻刡帪刽嘦";
			}
		}
	}

	public override string TagDescription
	{
		get
		{
			int num = 1;
			int num2 = -16921;
			int num3 = num2;
			num2 = -16921;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "횥튷\udead튡횿튽껀늒뛅닆뻑닂";
			}
		}
	}

	public SessionStop(Guid session, [Optional] BinaryInfoTag binary)
		: base(session, null, binary)
	{
	}
}
