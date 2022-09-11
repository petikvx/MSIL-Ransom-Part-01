using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace PreEmptive.Analytics.Common;

public abstract class PlatformClient : IPlatformClient
{
	private CoreClient coreClient_0;

	[CompilerGenerated]
	private Configuration configuration_0;

	[CompilerGenerated]
	private ILogger ilogger_0;

	public Configuration StartupConfiguration
	{
		[CompilerGenerated]
		get
		{
			if (1 == 0)
			{
			}
			int num = 21815;
			int num2 = num;
			num = 21815;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				return configuration_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -18368;
			int num2 = num;
			num = -18368;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			configuration_0 = value;
		}
	}

	public ILogger Logger
	{
		[CompilerGenerated]
		get
		{
			int num = 698;
			int num2 = num;
			num = 698;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return ilogger_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -31469;
			int num2 = num;
			num = -31469;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			ilogger_0 = value;
		}
	}

	public virtual CoreClient Core
	{
		get
		{
			int num = -11440;
			int num2 = num;
			num = -11440;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return coreClient_0 ?? (coreClient_0 = new CoreClient(GetNewPlatform(), Logger));
			}
		}
	}

	protected abstract IPlatform GetNewPlatform();

	public Guid GetActiveDefaultSession()
	{
		if (1 == 0)
		{
		}
		int num = -31352;
		int num2 = num;
		num = -31352;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			return Core.GetActiveDefaultSession();
		}
	}

	public PlatformClient(string companyID, string applicationID, ILogger logger)
	{
		int num = 7;
		base._002Ector();
		if (!Guid.TryParse(companyID, out var result) || !Guid.TryParse(applicationID, out var result2))
		{
			result = Guid.Empty;
			result2 = Guid.Empty;
			logger?.LogError("튑횹튿껞닓뛘닋뺞닝뛄늒껏刢嘦刾帷刱嘷刦渇爝瘘牒縷父癖爁渚删嘿刼帹割嘦刳껝닁뛓닖뺞닆뛙늒껚튺횳틲\udeae튾횷튦\uee88\uf29d\uf684\uf29fﻞ\uf291\uf69a\uf29b\uee8b튼횢틲\udebd튽횸튡껚닀뛃닑뻊닝뛄늒껇刡噶刻帰判嘷刾渇爖癘牒縻爟瘆爆渗割嘑刧帷制嘥割껆닓뛀닗뺞닐뛓닗껀틲횣튡\udebb튶훶튻\uee80\uf281\uf682\uf297ﺟ\uf296\uf6d8");
		}
		method_0(new Configuration(result, result2), logger);
	}

	public PlatformClient(Guid companyID, Guid applicationID, ILogger logger)
	{
		method_0(new Configuration(companyID, applicationID), logger);
	}

	public PlatformClient(Configuration config, ILogger logger)
	{
		method_0(config, logger);
	}

	private void method_0(Configuration configuration_1, ILogger ilogger_1)
	{
		int num = 9764;
		int num2 = num;
		num = 9764;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		StartupConfiguration = configuration_1;
		Logger = ilogger_1 ?? new BlankLogger();
	}

	public virtual bool ApplicationStart([Optional] ExtendedKeys keys, [Optional] BinaryInfo binary, [Optional] IFlowController flowController)
	{
		int num = -29880;
		int num2 = num;
		num = -29880;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			return Core.ApplicationStart(StartupConfiguration, keys, binary, flowController);
		}
	}

	public virtual void ApplicationStop([Optional] ExtendedKeys keys, [Optional] BinaryInfo binary, [Optional] bool immediate)
	{
		int num = 19;
		int num2 = 4;
		int num3 = num2;
		bool? defaultsToSynchronousStop = default(bool?);
		while (true)
		{
			num2 = -21968;
			int num4 = num2;
			num2 = -21968;
			switch (num4 == num2)
			{
			case false:
			case true:
				num2 = 5;
				num3 = num2;
				break;
			default:
				{
					if (1 == 0)
					{
					}
					if (0 == 0)
					{
					}
					switch (num3)
					{
					case 1:
						break;
					case 3:
						num2 = 0;
						num3 = num2;
						goto end_IL_016a;
					default:
						if (StartupConfiguration == null)
						{
							num2 = 9;
							num3 = num2;
						}
						else
						{
							defaultsToSynchronousStop = StartupConfiguration.StopBehavior.DefaultsToSynchronousStop;
							num2 = 1;
							num3 = num2;
						}
						goto end_IL_016a;
					case 5:
						if (!defaultsToSynchronousStop.GetValueOrDefault())
						{
							num2 = 7;
							num3 = num2;
							goto end_IL_016a;
						}
						goto case 0;
					case 7:
						num2 = 8;
						num3 = num2;
						goto end_IL_016a;
					case 8:
						if (immediate)
						{
							num2 = 2;
							num3 = num2;
							goto end_IL_016a;
						}
						ApplicationStopAsync(keys, binary, immediate);
						return;
					case 9:
						Logger.LogError("닳뻎닂뛚닛껍刳嘢刻帱刼嘅刦渁爂癖爑縟爞瘚爗渊割嘡刻帪刺嘹刧껚늒뛕닓뻒닞뛟닜껉틲횗튢\udeae튾횿튱\uee8f\uf286\uf69f\uf29dﺐ\uf2a1\uf682\uf293\uee9c튦훶튽\udeac틲횕튽껀닔뛟닕뻋닀뛗닆껇刽嘸割帷刡噶刼減爞瘚");
						num2 = 6;
						num3 = num2;
						goto end_IL_016a;
					case 0:
					case 2:
						ApplicationStopSync(keys, binary, immediate);
						return;
					case 6:
						return;
					}
					if (!defaultsToSynchronousStop.HasValue)
					{
						num2 = 3;
						num3 = num2;
						break;
					}
					goto case false;
				}
				end_IL_016a:
				break;
			}
		}
	}

	public virtual void ApplicationStopSync([Optional] ExtendedKeys keys, [Optional] BinaryInfo binary, [Optional] bool immediate)
	{
		int num = 21196;
		int num2 = num;
		num = 21196;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		if (1 == 0)
		{
		}
		Core.ApplicationStop(keys, binary, synchronous: true, immediate);
	}

	public virtual void ApplicationStopAsync([Optional] ExtendedKeys keys, [Optional] BinaryInfo binary, [Optional] bool immediate)
	{
		int num = 18146;
		int num2 = num;
		num = 18146;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		Core.ApplicationStop(keys, binary, synchronous: false, immediate);
	}

	public virtual void FeatureTick(string name, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary)
	{
		if (1 == 0)
		{
		}
		int num = -27066;
		int num2 = num;
		num = -27066;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		Core.FeatureTick(name, keys, session, binary);
	}

	public virtual void FeatureStart(string name, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary, [Optional] Guid? group)
	{
		int num = -10537;
		int num2 = num;
		num = -10537;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		Core.FeatureStart(name, keys, session, binary, group);
	}

	public virtual void FeatureStartWithGroup(string name, Guid group, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary)
	{
		int num = -21135;
		int num2 = num;
		num = -21135;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		if (1 == 0)
		{
		}
		Core.FeatureStart(name, keys, session, binary, group);
	}

	public virtual void FeatureStopWithGroup(string name, Guid group, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary)
	{
		int num = 5067;
		int num2 = num;
		num = 5067;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		Core.FeatureStop(name, keys, session, binary, group);
	}

	public virtual void FeatureStop(string name, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary, [Optional] Guid? group)
	{
		int num = -28051;
		int num2 = num;
		num = -28051;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		if (1 == 0)
		{
		}
		Core.FeatureStop(name, keys, session, binary, group);
	}

	public virtual void ReportTamper([Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary)
	{
		if (Core.Configuration == null)
		{
			int num = -32588;
			int num2 = num;
			num = -32588;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				Core.ReportTamper(keys, session, binary, StartupConfiguration);
				return;
			case false:
			case true:
				break;
			}
		}
		Core.ReportTamper(keys, session, binary);
	}

	public virtual void ReportDebugging([Optional] bool optinOverride, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary)
	{
		if (Core.Configuration == null)
		{
			int num = -30781;
			int num2 = num;
			num = -30781;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				Core.ReportDebugging(optinOverride, keys, session, binary, StartupConfiguration);
				return;
			case false:
			case true:
				break;
			}
		}
		Core.ReportDebugging(optinOverride, keys, session, binary);
	}

	public virtual void ReportExpiration(Guid slid, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary)
	{
		if (1 == 0)
		{
		}
		int num = 28871;
		int num2 = num;
		num = 28871;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		Core.ReportExpiration(slid, keys, session, binary);
	}

	public virtual void ReportExpirationWarning(Guid slid, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary)
	{
		int num = -20113;
		int num2 = num;
		num = -20113;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		Core.ReportExpirationWarning(slid, keys, session, binary);
	}

	public virtual void ReportException(ExceptionInfo exceptionInfo)
	{
		int num = 10917;
		int num2 = num;
		num = 10917;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		ReportException(exceptionInfo, optInOverride: false);
	}

	public virtual void ReportException(ExceptionInfo exceptionInfo, ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary)
	{
		int num = 30157;
		int num2 = num;
		num = 30157;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		ReportException(exceptionInfo, optInOverride: false, keys, session, binary);
	}

	public virtual void ReportException(ExceptionInfo exceptionInfo, bool optInOverride, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary)
	{
		if (1 == 0)
		{
		}
		int num = 2966;
		int num2 = num;
		num = 2966;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		Core.ReportException(exceptionInfo, optInOverride, keys, session, binary);
	}

	public virtual void SystemProfile([Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary)
	{
		int num = 32467;
		int num2 = num;
		num = 32467;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		Core.SystemProfile(keys, session, binary);
	}

	public virtual void PerformanceProbe(string name, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo info)
	{
		if (1 == 0)
		{
		}
		int num = 17260;
		int num2 = num;
		num = 17260;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		Core.PerformanceProbe(name, keys, session, info);
	}

	public virtual Guid NewFeatureGroup()
	{
		int num = 627;
		int num2 = num;
		num = 627;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return Guid.NewGuid();
		}
	}

	public virtual void SetSendDisabled(bool value)
	{
		if (1 == 0)
		{
		}
		int num = 1784;
		int num2 = num;
		num = 1784;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		Core.SetSendDisabled(value);
	}

	public virtual void SendMessages()
	{
		int num = 20973;
		int num2 = num;
		num = 20973;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		if (1 == 0)
		{
		}
		Core.SendMessages();
	}

	public virtual void SetSessionOptIn(bool value)
	{
		int num = 17;
		if (StartupConfiguration == null)
		{
			int num2 = 20318;
			int num3 = num2;
			num2 = 20318;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				Logger.LogError("뛵닝뻐닔뛟닕껛删嘷刦帷刽嘸割渇爁癖爜縋爞瘚牜湎刑嘷刼幾刼嘹刦꺎닁뛓닆뺞닡뛓닁껝튻횹튼\udefe튝횦튦\ueea7\uf29c\uf6d6\uf284ﺟ\uf29e\uf683\uf297");
				return;
			case false:
			case true:
				break;
			}
		}
		StartupConfiguration.OptIn = value;
		Core.SetSessionOptIn(value, StartupConfiguration);
	}

	public static Configuration.ApplicationStopBehavior CoreDefaultStopBehavior()
	{
		int num = 25139;
		int num2 = num;
		num = 25139;
		switch (num2 == num)
		{
		default:
		{
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			Configuration.ApplicationStopBehavior applicationStopBehavior = new Configuration.ApplicationStopBehavior();
			applicationStopBehavior.DefaultsToSynchronousStop = true;
			applicationStopBehavior.NeededTimeForSavingAtStop = 1500;
			applicationStopBehavior.SessionExtensionWindow = 0;
			applicationStopBehavior.StopTimeout = 2000;
			return applicationStopBehavior;
		}
		}
	}
}
