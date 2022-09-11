using PreEmptive.Analytics.Common;
using PreEmptive.SoS.Client.Cache;

namespace PreEmptive.SoS.Client.Messages;

public class SessionLifeCycleMessage : Message
{
	public override void Send(CacheService cache, PlatformClient paclient)
	{
		int num = 7;
		while (true)
		{
			BinaryInfo binaryInfo = Message.ConvertBinaryInfo(base.Binary);
			ExtendedKeys extendedKeys = Message.ConvertExtendedKeys(GetExtendedKeys());
			int num2 = 1;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 4:
					if (!base.Event.Code.Equals("튁횳튡껝닛뛙닜뺐닡뛂닝껞"))
					{
						return;
					}
					goto IL_0028;
				case 2:
				{
					num2 = -10990;
					int num4 = num2;
					num2 = -10990;
					switch (num4 == num2)
					{
					case false:
					case true:
						break;
					default:
						if (0 == 0)
						{
						}
						if (1 == 0)
						{
						}
						cache.ShutdownBinary = binaryInfo;
						cache.ShutdownKeys = extendedKeys;
						num2 = 0;
						num3 = num2;
						continue;
					}
					goto IL_0028;
				}
				case 1:
					if (base.Event.Code.Equals("튁횳튡껝닛뛙닜뺐닡뛂닓껜刦"))
					{
						num2 = 3;
						num3 = num2;
					}
					else
					{
						num2 = 4;
						num3 = num2;
					}
					continue;
				case 3:
					paclient.ApplicationStart(extendedKeys, binaryInfo);
					return;
				case 0:
					return;
					IL_0028:
					num2 = 2;
					num3 = num2;
					continue;
				}
				break;
			}
		}
	}
}
