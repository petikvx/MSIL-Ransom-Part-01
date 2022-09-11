using System;
using System.Runtime.InteropServices;
using PreEmptive.Analytics.Common.Tags;

namespace PreEmptive.Analytics.Common.Messages;

public class SessionStart : Message
{
	public override string TagName
	{
		get
		{
			int num = 6;
			if (1 == 0)
			{
			}
			int num2 = -10919;
			int num3 = num2;
			num2 = -10919;
			switch (num3 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				return "\udea1튳횡틝껛닙뛜늓뻁닂뛓닜긦";
			}
		}
	}

	public override string TagDescription
	{
		get
		{
			int num = 14;
			int num2 = 26496;
			int num3 = num2;
			num2 = 26496;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "껁닓뛁닍뻛닙뛜늎긡刢嘳刬带";
			}
		}
	}

	public SessionStart(Guid session, [Optional] BinaryInfoTag binary)
		: base(session, null, binary)
	{
	}
}
