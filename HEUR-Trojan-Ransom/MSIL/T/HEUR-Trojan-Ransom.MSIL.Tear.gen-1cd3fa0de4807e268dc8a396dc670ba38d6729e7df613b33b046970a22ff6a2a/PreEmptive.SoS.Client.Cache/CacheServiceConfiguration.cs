using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using PreEmptive.SoS.Client.Messages;

namespace PreEmptive.SoS.Client.Cache;

public class CacheServiceConfiguration
{
	private Dictionary<string, object> dictionary_0 = new Dictionary<string, object>();

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private IFlowController iflowController_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private ApplicationInformation applicationInformation_0;

	[CompilerGenerated]
	private BinaryInformation binaryInformation_0;

	[CompilerGenerated]
	private BusinessInformation businessInformation_0;

	public string InstanceId
	{
		[CompilerGenerated]
		get
		{
			int num = -13612;
			int num2 = num;
			num = -13612;
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
		set
		{
			int num = 28103;
			int num2 = num;
			num = 28103;
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

	public IFlowController FlowController
	{
		[CompilerGenerated]
		get
		{
			int num = 4787;
			int num2 = num;
			num = 4787;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return iflowController_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 27328;
			int num2 = num;
			num = 27328;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			iflowController_0 = value;
		}
	}

	public bool HashSensitiveData
	{
		[CompilerGenerated]
		get
		{
			if (1 == 0)
			{
			}
			int num = 19599;
			int num2 = num;
			num = 19599;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				return bool_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -16329;
			int num2 = num;
			num = -16329;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			bool_0 = value;
		}
	}

	public bool OmitPersonalInformation
	{
		[CompilerGenerated]
		get
		{
			int num = -6909;
			int num2 = num;
			num = -6909;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return bool_1;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 8579;
			int num2 = num;
			num = 8579;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			bool_1 = value;
		}
	}

	public bool UseSSL
	{
		[CompilerGenerated]
		get
		{
			int num = 16870;
			int num2 = num;
			num = 16870;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return bool_2;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -20147;
			int num2 = num;
			num = -20147;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			bool_2 = value;
		}
	}

	public ApplicationInformation Application
	{
		[CompilerGenerated]
		get
		{
			int num = 32321;
			int num2 = num;
			num = 32321;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return applicationInformation_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 30780;
			int num2 = num;
			num = 30780;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			applicationInformation_0 = value;
		}
	}

	public BinaryInformation Binary
	{
		[CompilerGenerated]
		get
		{
			int num = 23479;
			int num2 = num;
			num = 23479;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return binaryInformation_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 26759;
			int num2 = num;
			num = 26759;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			binaryInformation_0 = value;
		}
	}

	public BusinessInformation Business
	{
		[CompilerGenerated]
		get
		{
			int num = -8296;
			int num2 = num;
			num = -8296;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return businessInformation_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -7460;
			int num2 = num;
			num = -7460;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			businessInformation_0 = value;
		}
	}

	public CacheServiceConfiguration()
	{
	}

	public CacheServiceConfiguration(string instanceId)
		: this()
	{
		InstanceId = instanceId;
	}

	public void SetProperty(string propertyName, object propertyValue)
	{
		int num = 19;
		int num2 = 0;
		int num3 = num2;
		while (true)
		{
			switch (num3)
			{
			case 5:
				if (propertyValue == null)
				{
					num2 = 3;
					num3 = num2;
					break;
				}
				dictionary_0.Add(propertyName, propertyValue);
				return;
			case 4:
				if (1 == 0)
				{
				}
				num2 = 1;
				num3 = num2;
				break;
			case 1:
				if (propertyName.Trim().Length == 0)
				{
					num2 = 2;
					num3 = num2;
					break;
				}
				goto IL_0072;
			case 0:
			{
				num2 = -4190;
				int num4 = num2;
				num2 = -4190;
				switch (num4 == num2)
				{
				case false:
				case true:
					break;
				default:
					goto IL_00b2;
				}
				goto IL_0072;
			}
			default:
				if (propertyName != null)
				{
					num2 = 4;
					num3 = num2;
					break;
				}
				goto case 2;
			case 2:
				throw new ArgumentException("닳뻌닕뛃닟껋刼嘢割帽刳嘸刼渁爆癖爐縛牒瘘爇渂刾噶刽帬割嘳刿껞닆뛏", "닂뻌닝뛆닗껜刦嘯刜帿刿嘳");
			case 3:
				{
					throw new ArgumentException("닳뻌닕뛃닟껋刼嘢割帽刳嘸刼渁爆癖爐縛牒瘘爇渂刾", "닂뻌닝뛆닗껜刦嘯刄帿刾嘣刷");
				}
				IL_00b2:
				if (false)
				{
				}
				goto default;
				IL_0072:
				num2 = 5;
				num3 = num2;
				break;
			}
		}
	}

	public object GetProperty(string name)
	{
		if (1 == 0)
		{
		}
		if (dictionary_0.ContainsKey(name))
		{
			int num = -29354;
			int num2 = num;
			num = -29354;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				return dictionary_0[name];
			case false:
			case true:
				break;
			}
		}
		return null;
	}

	public object GetProperty(string name, object defaultValue)
	{
		int num = 6;
		int num2 = 2;
		int num3 = num2;
		while (true)
		{
			num2 = -427;
			int num4 = num2;
			num2 = -427;
			switch (num4 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				switch (num3)
				{
				case 0:
					if (dictionary_0.ContainsKey(name))
					{
						num2 = 1;
						num3 = num2;
						continue;
					}
					return defaultValue;
				case 2:
					if (true)
					{
					}
					goto default;
				default:
					if (name == null)
					{
						num2 = 3;
						num3 = num2;
					}
					else
					{
						num2 = 0;
						num3 = num2;
					}
					continue;
				case 3:
					break;
				case 1:
					return dictionary_0[name];
				}
				break;
			case false:
			case true:
				break;
			}
			break;
		}
		throw new ArgumentException("\ude93튤횵틛껟닓뛜닊뺒닕뛓닀긼刹嘦剾帰刳噲刀渇爚瘞", "\udebc튷횿틋");
	}
}
