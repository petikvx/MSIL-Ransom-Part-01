using System;
using System.Runtime.CompilerServices;

namespace PreEmptive.SoS.Client.Messages;

public class BusinessInformation
{
	[CompilerGenerated]
	private Guid guid_0;

	[CompilerGenerated]
	private string string_0;

	public Guid CompanyId
	{
		[CompilerGenerated]
		get
		{
			int num = 30612;
			int num2 = num;
			num = 30612;
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
			int num = -1656;
			int num2 = num;
			num = -1656;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			guid_0 = value;
		}
	}

	public string CompanyName
	{
		[CompilerGenerated]
		get
		{
			int num = -19344;
			int num2 = num;
			num = -19344;
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
			int num = -22085;
			int num2 = num;
			num = -22085;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			string_0 = value;
		}
	}

	public BusinessInformation(Guid companyId)
	{
		int num = 16;
		base._002Ector();
		if (companyId == Guid.Empty)
		{
			throw new ArgumentException("닷뛀닙뻇닛뛗닀긦剶嘱刿帼券嘽刚湒爔瘗牞縜爃瘞爂湲刹嘠剾帷刻嘢勚껋", "닕뛝닓뻂닗뛜닗긛刲");
		}
		CompanyId = companyId;
	}

	public BusinessInformation(Guid companyId, string companyName)
		: this(companyId)
	{
		CompanyName = companyName;
	}
}
