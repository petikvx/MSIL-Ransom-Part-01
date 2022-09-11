using PreEmptive.Analytics.Common;
using PreEmptive.SoS.Client.Cache;

namespace PreEmptive.SoS.Client.Messages;

public class SystemProfileMessage : Message
{
	public override void Send(CacheService cache, PlatformClient paclient)
	{
		int num = -4979;
		int num2 = num;
		num = -4979;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		BinaryInfo binary = Message.ConvertBinaryInfo(base.Binary);
		ExtendedKeys keys = Message.ConvertExtendedKeys(GetExtendedKeys());
		paclient.SystemProfile(keys, null, binary);
	}
}
