using System;
using PreEmptive.SoS.Client.Cache;
using PreEmptive.SoS.Client.Messages;

namespace PreEmptive.SoS.Runtime;

public sealed class Access
{
	public static ApplicationInformation ApplicationInfo;

	public static BusinessInformation BusinessInfo;

	private static CacheService cacheService_0;

	private static string string_0;

	private static FeatureCorrelator featureCorrelator_0;

	public static Guid FeatureGroup(string string_1, bool bool_0)
	{
		if (featureCorrelator_0 == null)
		{
			featureCorrelator_0 = new FeatureCorrelator();
		}
		return bool_0 ? featureCorrelator_0.Add(string_1) : featureCorrelator_0.Remove(string_1);
	}

	public static BusinessInformation CreateBusinessInformation(string string_1, string string_2)
	{
		return new BusinessInformation(new Guid(string_1), string_2);
	}

	public static ApplicationInformation CreateApplicationInformation(string string_1, string string_2, string string_3, string string_4)
	{
		return new ApplicationInformation(new Guid(string_1), string_2, string_3, string_4);
	}

	public static string GetCompanyName()
	{
		return (BusinessInfo == null) ? null : BusinessInfo.CompanyName;
	}

	public static string GetApplicationName()
	{
		return (ApplicationInfo == null) ? null : ApplicationInfo.Name;
	}

	public static void Setup(string string_1, BinaryInformation binaryInformation_0)
	{
		if (cacheService_0 == null)
		{
			string_0 = string_1;
			CacheServiceConfiguration cacheServiceConfiguration = new CacheServiceConfiguration(string_0);
			cacheServiceConfiguration.SetProperty("webservice.url", "so-s.info/Endpoint");
			cacheServiceConfiguration.UseSSL = false;
			cacheServiceConfiguration.OmitPersonalInformation = true;
			cacheServiceConfiguration.HashSensitiveData = true;
			SetupRuntime(cacheServiceConfiguration, binaryInformation_0);
			cacheService_0 = CacheServiceFactory.CreateCacheService(cacheServiceConfiguration);
		}
		if (featureCorrelator_0 == null)
		{
			featureCorrelator_0 = new FeatureCorrelator();
		}
	}

	public static void SetupRuntime(CacheServiceConfiguration cacheServiceConfiguration_0, BinaryInformation binaryInformation_0)
	{
		cacheServiceConfiguration_0.Binary = binaryInformation_0;
		cacheServiceConfiguration_0.Business = ((BusinessInfo == null) ? new BusinessInformation(new Guid("7d2b02e0-064d-49a0-bc1b-4be4381c62d3"), "") : BusinessInfo);
		cacheServiceConfiguration_0.Application = ((ApplicationInfo == null) ? new ApplicationInformation(new Guid("510b53a1-069e-4b67-9c03-31b3956c002c"), "Unknown Application", "", "") : ApplicationInfo);
	}

	public static void Teardown()
	{
		if (cacheService_0 != null)
		{
			cacheService_0.ShutDown();
			cacheService_0 = null;
		}
	}

	public static void Send(Message message_0, bool bool_0)
	{
		if (cacheService_0 != null)
		{
			cacheService_0.Send(message_0, bool_0);
		}
	}

	public static void Send(Message message_0)
	{
		Send(message_0, bool_0: false);
	}

	public static void SendQueuedMessages()
	{
		if (cacheService_0 != null)
		{
			cacheService_0.SendQueuedMessages();
		}
	}

	public static bool IsStarted()
	{
		return cacheService_0 != null;
	}

	public static bool TeardownIfNeeded(bool bool_0)
	{
		if (!bool_0)
		{
			return false;
		}
		Teardown();
		return true;
	}
}
