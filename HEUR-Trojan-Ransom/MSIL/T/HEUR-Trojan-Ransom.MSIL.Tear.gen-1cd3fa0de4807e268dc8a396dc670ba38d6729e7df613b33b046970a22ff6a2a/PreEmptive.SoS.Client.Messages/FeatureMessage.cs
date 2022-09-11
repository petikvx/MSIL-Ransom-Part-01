using System;
using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common;
using PreEmptive.SoS.Client.Cache;

namespace PreEmptive.SoS.Client.Messages;

public class FeatureMessage : Message
{
	[CompilerGenerated]
	private string string_0;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			int num = 24498;
			int num2 = num;
			num = 24498;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return string_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -13575;
			int num2 = num;
			num = -13575;
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

	public FeatureMessage(string name)
	{
		int num = 0;
		base._002Ector();
		if (name == null || name == string.Empty)
		{
			throw new ArgumentException("튗횠특\udea7튻횷틀껆늖뛑닟뻜님뛝닚깲刴嘷剾帼刣嘾刂湒爙瘀牞縗爛瘂爚渫", "트횳튳\udeb7");
		}
		Name = name;
	}

	public void AddToGroup(Guid guid_0)
	{
		if (1 == 0)
		{
		}
		int num = -9103;
		int num2 = num;
		num = -9103;
		switch (num2 == num)
		{
		}
		if (false)
		{
		}
	}

	public override void Send(CacheService cache, PlatformClient paclient)
	{
		int num = 0;
		switch (0)
		{
		}
		while (true)
		{
			BinaryInfo binary = Message.ConvertBinaryInfo(base.Binary);
			ExtendedKeys keys = Message.ConvertExtendedKeys(GetExtendedKeys());
			int num2 = 0;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 5:
					if (base.Event.Code.Equals("튐횷튿\udea6튣횠틋꺜닥뛆닑뻂"))
					{
						num2 = 1;
						num3 = num2;
						continue;
					}
					return;
				case 4:
					if (base.Event.Code.Equals("튐횷튿\udea6튣횠틋꺜닥뛆닟뻀닂"))
					{
						num2 = 2;
						num3 = num2;
					}
					else
					{
						num2 = 5;
						num3 = num2;
					}
					continue;
				case 3:
				{
					num2 = 11988;
					int num4 = num2;
					num2 = 11988;
					switch (num4 == num2)
					{
					case false:
					case true:
						break;
					default:
						if (0 == 0)
						{
						}
						paclient.FeatureTick(Name, keys, null, binary);
						return;
					}
					goto case 1;
				}
				case 1:
					paclient.FeatureStop(Name, keys, null, binary);
					num2 = 6;
					num3 = num2;
					continue;
				case 0:
					if (base.Event.Code.Equals("튐횷튿\udea6튣횠틋꺜닢뛛닝뻙"))
					{
						num2 = 3;
						num3 = num2;
						continue;
					}
					if (1 == 0)
					{
					}
					num2 = 4;
					num3 = num2;
					continue;
				case 2:
					paclient.FeatureStart(Name, keys, null, binary);
					return;
				case 6:
					return;
				}
				break;
			}
		}
	}
}
