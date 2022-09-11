using PreEmptive.Analytics.Common;
using PreEmptive.SoS.Client.Cache;
using PreEmptive.SoS.Client.MessageProxies;

namespace PreEmptive.SoS.Client.Messages;

public class SecurityMessage : Message
{
	public override void Send(CacheService cache, PlatformClient paclient)
	{
		int num = 11;
		switch (0)
		{
		}
		string code = default(string);
		while (true)
		{
			BinaryInfo binary = Message.ConvertBinaryInfo(base.Binary);
			ExtendedKeys keys = Message.ConvertExtendedKeys(GetExtendedKeys());
			while (true)
			{
				IL_0173:
				int num2 = 1;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 8:
						num2 = 6;
						num3 = num2;
						continue;
					case 6:
						break;
					case 4:
						if ((code = base.Event.Code) != null)
						{
							num2 = 8;
							num3 = num2;
							continue;
						}
						return;
					case 3:
						goto IL_0086;
					case 2:
						goto IL_00c9;
					case 1:
						goto IL_0116;
					default:
						goto end_IL_0146;
					case 0:
						return;
					case 5:
						return;
					case 7:
						if (true)
						{
						}
						return;
					}
					if (!(code == "튁껋닑뛃닀뻗닆뛏늜껧刼嘢刷帹删嘿刦渗牜瘢爓縓爂瘓爀渇刼嘱"))
					{
						num2 = 2;
						num3 = num2;
						continue;
					}
					paclient.ReportTamper(keys, null, binary);
					return;
					IL_0116:
					if (base.Event.PrivacySetting != PrivacySettings.AlwaysSend)
					{
						num2 = 5;
						num3 = num2;
					}
					else
					{
						num2 = 4;
						num3 = num2;
					}
					continue;
					IL_0086:
					if (!(code == "튁껋닑뛃닀뻗닆뛏늜껧刼嘢刷帹删嘿刦渗牜瘲爗縜爇瘑爕渇刼嘱"))
					{
						num2 = 7;
						num3 = num2;
					}
					else
					{
						paclient.ReportDebugging(optinOverride: true, keys, null, binary);
						num2 = 0;
						num3 = num2;
					}
					continue;
					IL_00c9:
					num2 = 11642;
					int num4 = num2;
					num2 = 11642;
					switch (num4 == num2)
					{
					default:
						if (0 == 0)
						{
						}
						num2 = 3;
						num3 = num2;
						continue;
					case false:
					case true:
						break;
					}
					goto IL_0173;
					continue;
					end_IL_0146:
					break;
				}
				break;
			}
		}
	}
}
