using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PreEmptive.Analytics.Common.Tags;

public abstract class Feature : Message
{
	[CompilerGenerated]
	private string string_3;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			int num = -25400;
			int num2 = num;
			num = -25400;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return string_3;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -28894;
			int num2 = num;
			num = -28894;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			string_3 = value;
		}
	}

	public override string TagName
	{
		get
		{
			int num = 4;
			int num2 = 17867;
			int num3 = num2;
			num2 = 17867;
			switch (num3 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return "트\udeb7튷횦틛껀닓";
			}
		}
	}

	protected Feature(string name, Guid session, string eventtype, [Optional] ExtendedKeys keys, [Optional] BinaryInfoTag binary, [Optional] Guid? group)
		: base(session, keys, binary)
	{
		Name = name;
		AddAttribute("닜뻟닟뛓", Name);
		AddAttribute("닗뻈닗뛘닆", eventtype);
		AddAttribute("닕뻌닝뛃닂", (group ?? Guid.NewGuid()).ToString());
	}
}
