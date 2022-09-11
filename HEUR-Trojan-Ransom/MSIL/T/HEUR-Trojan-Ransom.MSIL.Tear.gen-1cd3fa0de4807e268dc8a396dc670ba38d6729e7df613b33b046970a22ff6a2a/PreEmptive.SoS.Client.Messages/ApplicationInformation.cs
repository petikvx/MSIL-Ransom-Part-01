using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PreEmptive.SoS.Client.Messages;

public class ApplicationInformation
{
	[CompilerGenerated]
	private Guid guid_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private string string_2;

	public Guid Id
	{
		[CompilerGenerated]
		get
		{
			int num = 12688;
			int num2 = num;
			num = 12688;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return guid_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			if (1 == 0)
			{
			}
			int num = 14830;
			int num2 = num;
			num = 14830;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			guid_0 = value;
		}
	}

	public string Name
	{
		[CompilerGenerated]
		get
		{
			int num = 15309;
			int num2 = num;
			num = 15309;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return string_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = 295;
			int num2 = num;
			num = 295;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			string_0 = value;
		}
	}

	public string Version
	{
		[CompilerGenerated]
		get
		{
			if (1 == 0)
			{
			}
			int num = -28403;
			int num2 = num;
			num = -28403;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				return string_1;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = 10460;
			int num2 = num;
			num = 10460;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			string_1 = value;
		}
	}

	public string ApplicationType
	{
		[CompilerGenerated]
		get
		{
			int num = -18830;
			int num2 = num;
			num = -18830;
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
			int num = -14129;
			int num2 = num;
			num = -14129;
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

	public ApplicationInformation(Guid guid_1, [Optional] string name, [Optional] string version, [Optional] string applicationType)
	{
		int num = 17;
		base._002Ector();
		if (guid_1 == Guid.Empty)
		{
			throw new ArgumentException("뛷닀뻙닇뛛닗껀刦噶刱帿刼嘸刽渚牒瘔爗繞爜瘃爞渂割嘹删幾刷嘻刢껚닋", "뛟닖");
		}
		Id = guid_1;
		Name = name;
		Version = version;
		ApplicationType = applicationType;
	}
}
