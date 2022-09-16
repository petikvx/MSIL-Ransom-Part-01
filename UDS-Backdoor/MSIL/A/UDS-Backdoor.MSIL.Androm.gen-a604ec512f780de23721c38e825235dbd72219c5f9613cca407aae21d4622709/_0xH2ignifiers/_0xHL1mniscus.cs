using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.Cct.Services;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Telemetry;
using Microsoft.VisualStudio.WindowsAzure;
using Microsoft.VisualStudio.WindowsAzure.Authentication;
using _0xHKha7;
using _0xHPre2iological;

namespace _0xH2ignifiers;

public static class _0xHL1mniscus
{
	public static void _0xHPh7t7meter(int _0xHAssume3)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0028: Expected O, but got Unknown
		OperationEvent val = new OperationEvent("vs/azuretools/onesdk/projects/close-solution", (TelemetryResult)1, (string)null);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.CctSolutionListener.ProjectCount"] = (object)new TelemetryMetricProperty((double)_0xHAssume3);
		_0xHOrc3estrating._0xH6niformness((TelemetryEvent)val);
	}

	public static void _0xHMet5nymical(object _0xHBelad5, uint _0xHDiscri5inated = 0u, uint _0xHChon4riosomes = 0u, string _0xHEdifi8r = null)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		UserTaskEvent val = new UserTaskEvent("vs/azuretools/onesdk/execute-command", (TelemetryResult)_0xHChon4riosomes, (string)null);
		if (!string.IsNullOrEmpty(_0xHEdifi8r))
		{
			((TelemetryEvent)val).get_Properties()["VS.AzureTools.OneSdk.ExecuteCommand.CommandName"] = _0xHEdifi8r;
			((TelemetryEvent)val).get_Properties()["VS.AzureTools.OneSdk.ExecuteCommand.CommandId"] = _0xHDiscri5inated;
			((TelemetryEvent)val).get_Properties()["VS.AzureTools.OneSdk.ExecuteCommand.CommandGroup"] = _0xHBelad5;
			((TelemetryEvent)val).get_Properties()["VS.AzureTools.OneSdk.ExecuteCommand.HowExecuted"] = _0xHChon4riosomes;
			_0xHOrc3estrating._0xH6niformness((TelemetryEvent)(object)val);
		}
	}

	public static void _0xHWhimsi2al()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002b: Expected O, but got Unknown
		FaultEvent val = new FaultEvent("vs/azuretools/onesdk/AzureToolsError", "OneSDK.CctPackage.AzureToolsError.Error", (Exception)null, (Func<IFaultUtility, int>)null);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.AzureToolsError.Error"] = "Undefined Error";
		_0xHOrc3estrating._0xH6niformness((TelemetryEvent)val);
	}

	public static void _0xHIndividualisin4(object _0xHTurnbuck8e)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		FaultEvent val = new FaultEvent("vs/azuretools/onesdk/AzureToolsError", "OneSDK.CctPackage.AzureToolsError.Error", (Exception)null, (Func<IFaultUtility, int>)null);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.AzureToolsError.Error"] = _0xHTurnbuck8e.ToString();
		_0xHOrc3estrating._0xH6niformness((TelemetryEvent)val);
	}

	public static Exception _0xHEx2viates(Exception _0xHA5uiver)
	{
		_0xHIndividualisin4(_0xHA5uiver.Message);
		return _0xHA5uiver;
	}

	public static Exception _0xHBiochemistr0(Exception _0xHLana4e, WatError _0xHE4tremely)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		_0xHIndividualisin4(_0xHE4tremely);
		return _0xHLana4e;
	}

	public static void _0xHComminute7(Exception _0xH5oyeur, string _0xHB3plane = null)
	{
		_0xHIndividualisin4(_0xHB3plane);
	}

	public static void _0xHDerai5ed(Version _0xHMi8iga8ing)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		OperationEvent val = new OperationEvent("vs/azuretools/onesdk/log-packageversion", (TelemetryResult)1, (string)null);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.ToolsVersion.Major"] = _0xHMi8iga8ing.Major;
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.PackageVersion.BuildDate"] = _0xHMi8iga8ing.Build;
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.PackageVersion.BuildNumber"] = _0xHMi8iga8ing.Revision;
		_0xHOrc3estrating._0xH6niformness((TelemetryEvent)val);
	}

	public static void _0xHTamp4ng(int _0xHR6bound6rs, int _0xHFr3t3llar3as, int _0xH3enignancies)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0056: Expected O, but got Unknown
		OperationEvent val = new OperationEvent("vs/azuretools/onesdk/log-projectroles", (TelemetryResult)1, (string)null);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.NumberOfTotalRoles"] = (object)new TelemetryMetricProperty((double)_0xHR6bound6rs);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.NumberOfWebRoles"] = (object)new TelemetryMetricProperty((double)_0xHFr3t3llar3as);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.NumberOfWorkerRoles"] = (object)new TelemetryMetricProperty((double)_0xH3enignancies);
		_0xHOrc3estrating._0xH6niformness((TelemetryEvent)val);
	}

	public static void _0xHLadyfi8h(int _0xHI4habita4cies, int _0xHSa8lefishes, int _0xHPostfir5, int _0xHEn0ambement, Version _0xHWatch4d)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_003a: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_006d: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		OperationEvent val = new OperationEvent("vs/azuretools/onesdk/close-project", (TelemetryResult)1, (string)null);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.NumberOfTotalRoles"] = (object)new TelemetryMetricProperty((double)_0xHI4habita4cies);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.NumberOfWebRoles"] = (object)new TelemetryMetricProperty((double)_0xHSa8lefishes);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.NumberOfWorkerRoles"] = (object)new TelemetryMetricProperty((double)_0xHPostfir5);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.ToolsVersion.Major"] = _0xHWatch4d.Major;
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.ToolsVersion.Minor"] = _0xHWatch4d.Minor;
		_0xHOrc3estrating._0xH6niformness((TelemetryEvent)val);
	}

	public static void _0xHAnap2yxes(WatProjectCreation _0xHAggiorn1mento, Version _0xHV3c3ng)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		UserTaskEvent val = new UserTaskEvent("vs/azuretools/onesdk/projects/create-project", (TelemetryResult)1, (string)null);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.ToolsVersion.Major"] = _0xHV3c3ng.Major;
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.ToolsVersion.Minor"] = _0xHV3c3ng.Minor;
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.ProjectCreation"] = ((object)(WatProjectCreation)(ref _0xHAggiorn1mento)).ToString();
		_0xHOrc3estrating._0xH6niformness((TelemetryEvent)val);
	}

	public static void _0xHSh6rb6t(string[] _0xHLucern0, string _0xHDipep3ide)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000d: Expected O, but got Unknown
		OperationEvent val = new OperationEvent("vs/azuretools/onesdk/projects/create-deploymentpackage", (TelemetryResult)1, (string)null);
		for (int i = 0; i < _0xHLucern0.Length; i++)
		{
			((TelemetryEvent)val).get_Properties()[_0xHJuxtapo1ition._0xHAn3iacademic[i]] = _0xHLucern0[i];
		}
		((TelemetryEvent)val).get_Properties()["VS.AzureTools.OneSdk.SubscriptionId"] = _0xHDipep3ide;
		_0xHOrc3estrating._0xH6niformness((TelemetryEvent)(object)val);
	}

	public static void _0xHGlo8e(string _0xHBackst3tch3ng, string _0xHA5erose, int _0xHSupe4gluing, int _0xHPr3tege, int _0xH4qualor, int _0xHArch1typ1, int _0xHSala0ility, int _0xHBlade3, int _0xHD0licat0ly, int _0xH5yxocyte)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Expected O, but got Unknown
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00f1: Expected O, but got Unknown
		OperationEvent val = new OperationEvent("vs/azuretools/onesdk/log-projectcache", (TelemetryResult)0, (string)null);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.ToolsVersion.Major"] = _0xHBackst3tch3ng;
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.ToolsVersion.Major"] = _0xHA5erose;
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.NumberOfRoles"] = (object)new TelemetryMetricProperty((double)_0xHSupe4gluing);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.NumberOfCacheWebRoles"] = (object)new TelemetryMetricProperty((double)_0xHPr3tege);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.NumberOfCacheWebRolesMemCacheEnabled"] = (object)new TelemetryMetricProperty((double)_0xH4qualor);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.NumberOfCacheWorkerRoles"] = (object)new TelemetryMetricProperty((double)_0xHArch1typ1);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.NumberOfCacheWorkerRolesMemCacheEnabled"] = (object)new TelemetryMetricProperty((double)_0xHSala0ility);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.NumberOfConfiguration"] = (object)new TelemetryMetricProperty((double)_0xHBlade3);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.NumberOfWebRoles"] = (object)new TelemetryMetricProperty((double)_0xHD0licat0ly);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.NumberOfWorkerRoles"] = (object)new TelemetryMetricProperty((double)_0xH5yxocyte);
		_0xHOrc3estrating._0xH6niformness((TelemetryEvent)val);
	}

	public static void _0xHO0tg0ns(string _0xHMisappl6, string _0xH3ary, bool _0xH1apped, bool _0xHS4s4rr4ses, int _0xHGumpt7on, int _0xHN1ti1ns, int _0xHDeli2ts)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_007b: Expected O, but got Unknown
		OperationEvent val = new OperationEvent("vs/azuretools/onesdk/log-rolecache", (TelemetryResult)0, (string)null);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.RoleType"] = _0xH3ary;
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.VMSize"] = _0xHMisappl6;
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.CacheSize"] = (object)new TelemetryMetricProperty((double)_0xHGumpt7on);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.NamedCacheCount"] = (object)new TelemetryMetricProperty((double)_0xHN1ti1ns);
		((TelemetryEvent)val).get_Properties()["OneSDK.CctPackage.MemCachePortCount"] = (object)new TelemetryMetricProperty((double)_0xHDeli2ts);
		_0xHOrc3estrating._0xH6niformness((TelemetryEvent)val);
	}

	public static async Task<string> _0xHTocolog7()
	{
		IEnumerable<IAzureRdfeSubscriptionContext> obj = await ServiceProviderExtensions.GetRequiredService<IAzureAuthenticationManager>((IServiceProvider)ServiceProvider.get_GlobalProvider()).GetSubscriptionsAsync().ConfigureAwait(continueOnCapturedContext: false);
		List<string> list = new List<string>();
		foreach (IAzureRdfeSubscriptionContext item in obj)
		{
			list.Add(((IAzureSubscriptionContext)item).get_Subscription().get_SubscriptionId());
		}
		return string.Join(",", list.ToArray());
	}
}
