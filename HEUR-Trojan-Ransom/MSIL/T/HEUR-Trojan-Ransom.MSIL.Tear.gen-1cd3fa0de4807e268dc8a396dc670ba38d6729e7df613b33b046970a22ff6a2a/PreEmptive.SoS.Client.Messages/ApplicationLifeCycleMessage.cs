using System;
using PreEmptive.Analytics.Common;
using PreEmptive.SoS.Client.Cache;
using PreEmptive.SoS.Client.MessageProxies;

namespace PreEmptive.SoS.Client.Messages;

public class ApplicationLifeCycleMessage : Message
{
	public override void Send(CacheService cache, PlatformClient paclient)
	{
		int num = 16;
		switch (0)
		{
		}
		string code = default(string);
		while (true)
		{
			BinaryInfo binary = Message.ConvertBinaryInfo(base.Binary);
			ExtendedKeys extendedKeys = Message.ConvertExtendedKeys(GetExtendedKeys());
			bool flag = false;
			if (true)
			{
			}
			int num2 = 2;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 20:
					if (!(code == "닥뛚닛뻞닐뛾닇긴刳噼刍帻刱嘼刡渔爺瘛爘縗"))
					{
						num2 = 12;
						num3 = num2;
					}
					else
					{
						paclient.FeatureTick("닥뛚닛뻞닐뛾닇긴刳噼刍帻刱嘼刡渔爺瘛爘縗", extendedKeys, null, binary);
						num2 = 7;
						num3 = num2;
					}
					continue;
				case 19:
					paclient.ApplicationStop(null, null, immediate: false);
					num2 = 1;
					num3 = num2;
					continue;
				case 18:
					num2 = 13;
					num3 = num2;
					continue;
				case 17:
					num2 = 20;
					num3 = num2;
					continue;
				case 5:
				case 7:
				case 11:
				case 16:
					num2 = 4;
					num3 = num2;
					continue;
				case 15:
					if (!(code == "닥뛚닛뻞닐뛾닇긴刳噼创帪刦嘻刜渓爂瘛爑縜"))
					{
						num2 = 0;
						num3 = num2;
					}
					else
					{
						paclient.ReportExpiration(Guid.Parse(extendedKeys.Map["닿뛶"].Value), extendedKeys, null, binary);
						num2 = 5;
						num3 = num2;
					}
					continue;
				case 14:
					flag = paclient.ApplicationStart();
					num2 = 18;
					num3 = num2;
					continue;
				case 13:
					if ((code = base.Event.Code) != null)
					{
						num2 = 17;
						num3 = num2;
						continue;
					}
					goto case 3;
				case 3:
					paclient.FeatureTick(base.Event.Code, extendedKeys, null, binary);
					num2 = 16;
					num3 = num2;
					continue;
				case 12:
					num2 = 9;
					num3 = num2;
					continue;
				case 10:
					num2 = 6;
					num3 = num2;
					continue;
				case 9:
					if (!(code == "닥뛚닛뻞닐뛾닇긴刳噼刉帳判嘼切渜爑"))
					{
						num2 = 20696;
						int num4 = num2;
						num2 = 20696;
						switch (num4 == num2)
						{
						case false:
						case true:
							break;
						default:
							if (0 == 0)
							{
							}
							num2 = 8;
							num3 = num2;
							continue;
						}
						goto case 5;
					}
					paclient.ReportExpirationWarning(Guid.Parse(extendedKeys.Map["닿뛶"].Value), extendedKeys, null, binary);
					num2 = 11;
					num3 = num2;
					continue;
				case 8:
					num2 = 15;
					num3 = num2;
					continue;
				case 6:
					if (!paclient.Core.AppStarted)
					{
						num2 = 14;
						num3 = num2;
						continue;
					}
					goto case 18;
				case 4:
					if (flag)
					{
						num2 = 19;
						num3 = num2;
						continue;
					}
					return;
				case 2:
					if (base.Event.PrivacySetting == PrivacySettings.AlwaysSend)
					{
						num2 = 10;
						num3 = num2;
						continue;
					}
					goto case 18;
				case 0:
					num2 = 3;
					num3 = num2;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}
}
