using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PreEmptive.Analytics.Common.Tags;

public class ExtendedKeyTag : Tag
{
	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private string string_3;

	public override string TagName
	{
		get
		{
			int num = 13;
			int num2 = -13029;
			int num3 = num2;
			num2 = -13029;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "껞닀뛙닂뻛닀뛂닋";
			}
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			int num = 12458;
			int num2 = num;
			num = 12458;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return string_2;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -18453;
			int num2 = num;
			num = -18453;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			string_2 = value;
		}
	}

	public string Value
	{
		[CompilerGenerated]
		get
		{
			int num = 27314;
			int num2 = num;
			num = 27314;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return string_3;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -28040;
			int num2 = num;
			num = -28040;
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

	public ExtendedKeyTag(string name, string value, [Optional] bool isNumeric)
	{
		int num = 9;
		base._002Ector();
		Name = name;
		Value = value;
		AddAttribute("횸튳껃닗", Name);
		AddAttribute("횠튳껂닇뛓", Value);
		if (isNumeric)
		{
			AddAttribute("횢튫껞닗", "횲튷껍닛뛛닓뻒");
		}
	}
}
