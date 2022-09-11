using System;
using PreEmptive.Analytics.Common;

namespace PreEmptive.SoS.Client.Cache;

public static class CacheServiceFactory
{
	public static CacheService CreateCacheService(CacheServiceConfiguration configuration)
	{
		int num = 11;
		switch (0)
		{
		}
		bool flag = default(bool);
		PlatformClient platformClient = default(PlatformClient);
		CacheService cacheService = default(CacheService);
		while (true)
		{
			Configuration configuration2 = new Configuration(configuration.Business.CompanyId, configuration.Application.Id);
			configuration2.CompanyName = configuration.Business.CompanyName;
			configuration2.ApplicationName = configuration.Application.Name;
			configuration2.ApplicationType = configuration.Application.ApplicationType;
			configuration2.ApplicationVersion = configuration.Application.Version;
			configuration2.Endpoint = configuration.GetProperty("튥껋닐뛅닗뻌닄뛟닑껋剼嘣删帲") as string;
			configuration2.UseSSL = configuration.UseSSL;
			configuration2.FullData = true;
			configuration2.InstanceID = configuration.InstanceId;
			configuration2.OmitPersonalInfo = configuration.OmitPersonalInformation;
			configuration2.SupportOfflineStorage = (bool)configuration.GetProperty("튽껈닔뛚닛뻐닗뚘닁껛刢嘦刽帬刦", false);
			int num2 = 2;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 11:
					if (!flag)
					{
						num2 = 10;
						num3 = num2;
						continue;
					}
					goto case 0;
				case 10:
					platformClient.ApplicationStart();
					num2 = 0;
					num3 = num2;
					continue;
				case 9:
					num2 = 4;
					num3 = num2;
					continue;
				case 8:
					configuration2.Offline = (bool)configuration.GetProperty("튽껈닔뛚닛뻐닗뚘닁껚刳嘢刷", false);
					num2 = 7;
					num3 = num2;
					continue;
				case 7:
					flag = (bool)configuration.GetProperty("튴껇닀뛓늜뻒닛뛐닗껍别嘵刾帻剼嘳判渋爜瘂爁", true);
					num2 = 3;
					num3 = num2;
					continue;
				case 6:
				{
					if (1 == 0)
					{
					}
					Configuration.ApplicationStopBehavior stopBehavior = configuration2.StopBehavior;
					stopBehavior.SessionExtensionWindow = 0;
					stopBehavior.DefaultsToSynchronousStop = true;
					stopBehavior.NeededTimeForSavingAtStop = 50;
					stopBehavior.StopTimeout = 50;
					num2 = -24442;
					int num4 = num2;
					num2 = -24442;
					switch (num4 == num2)
					{
					case false:
					case true:
						break;
					default:
						if (0 == 0)
						{
						}
						num2 = 1;
						num3 = num2;
						continue;
					}
					goto case 10;
				}
				case 5:
					configuration2.DefaultSession = Guid.NewGuid();
					num2 = 9;
					num3 = num2;
					continue;
				case 4:
					if (configuration.FlowController is ImmediateFlowController)
					{
						num2 = 6;
						num3 = num2;
						continue;
					}
					goto case 1;
				case 1:
					platformClient = PlatformFactory.GetPlatformClient(configuration2, (bool)configuration.GetProperty("튾껁닕뚘닟뻛닁뛅닓껉刷嘥", false));
					cacheService = new CacheService();
					cacheService.Client = platformClient;
					cacheService.SendLifeCycleMessages = flag;
					num2 = 11;
					num3 = num2;
					continue;
				case 3:
					if (!flag)
					{
						num2 = 5;
						num3 = num2;
						continue;
					}
					goto case 9;
				case 2:
					if (configuration2.SupportOfflineStorage)
					{
						num2 = 8;
						num3 = num2;
						continue;
					}
					goto case 7;
				case 0:
					return cacheService;
				}
				break;
			}
		}
	}
}
