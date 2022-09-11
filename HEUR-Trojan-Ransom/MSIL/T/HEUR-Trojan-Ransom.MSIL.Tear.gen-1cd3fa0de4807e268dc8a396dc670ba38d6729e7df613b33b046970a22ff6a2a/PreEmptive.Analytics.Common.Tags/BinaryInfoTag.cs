using System;
using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common.Utilities;

namespace PreEmptive.Analytics.Common.Tags;

public class BinaryInfoTag : Tag
{
	[CompilerGenerated]
	private Guid? nullable_0;

	[CompilerGenerated]
	private DateTime? nullable_1;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private string string_3;

	[CompilerGenerated]
	private string string_4;

	[CompilerGenerated]
	private string string_5;

	public override string TagName
	{
		get
		{
			int num = 16;
			int num2 = -7599;
			int num3 = num2;
			num2 = -7599;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return "닔뛛닐뻓닄뛋";
			}
		}
	}

	public Guid? ID
	{
		[CompilerGenerated]
		get
		{
			int num = -15567;
			int num2 = num;
			num = -15567;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return nullable_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -20081;
			int num2 = num;
			num = -20081;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			nullable_0 = value;
		}
	}

	public DateTime? LastModified
	{
		[CompilerGenerated]
		get
		{
			int num = -7386;
			int num2 = num;
			num = -7386;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return nullable_1;
			}
		}
		[CompilerGenerated]
		set
		{
			if (1 == 0)
			{
			}
			int num = 1821;
			int num2 = num;
			num = 1821;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			nullable_1 = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			int num = 476;
			int num2 = num;
			num = 476;
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
		set
		{
			if (1 == 0)
			{
			}
			int num = 17016;
			int num2 = num;
			num = 17016;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			string_2 = value;
		}
	}

	public string Version
	{
		[CompilerGenerated]
		get
		{
			int num = -25439;
			int num2 = num;
			num = -25439;
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
		set
		{
			int num = 6863;
			int num2 = num;
			num = 6863;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			string_3 = value;
		}
	}

	public string ClassName
	{
		[CompilerGenerated]
		get
		{
			int num = -7641;
			int num2 = num;
			num = -7641;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return string_4;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -11947;
			int num2 = num;
			num = -11947;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			string_4 = value;
		}
	}

	public string MethodName
	{
		[CompilerGenerated]
		get
		{
			int num = -27239;
			int num2 = num;
			num = -27239;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return string_5;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 2549;
			int num2 = num;
			num = 2549;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			string_5 = value;
		}
	}

	public BinaryInfoTag(Guid? nullable_2, DateTime? modified, string name, string version, string classname, string methodname)
	{
		int num = 6;
		base._002Ector();
		ID = nullable_2;
		LastModified = modified;
		Name = name;
		Version = version;
		ClassName = classname;
		MethodName = methodname;
		AddOptionalAttribute("\udebb튲", ID.smethod_0());
		string value = null;
		if (LastModified.HasValue)
		{
			value = LastModified.Value.ToISOFormat();
		}
		AddOptionalAttribute("\udebf특횶틇껔닟뛗닚", value);
		AddOptionalAttribute("\udebc튷횿틋", Name);
		AddOptionalAttribute("\udea4튳횠틝껛닙뛜", Version);
		AddOptionalAttribute("\udea6튯횢틋", ClassName);
		AddOptionalAttribute("\udebf튳횦틆껝닒", MethodName);
	}

	public BinaryInfoTag(BinaryInfo info)
		: this(info.ID, info.LastModified, info.Name, info.Version, info.ClassName, info.MethodName)
	{
	}
}
