using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using PreEmptive.Analytics.Common.Messages;
using PreEmptive.Analytics.Common.Tags;
using PreEmptive.Analytics.Common.Utilities;

namespace PreEmptive.Analytics.Common;

public class CoreClient : IConfigurationProvider, ILoggerProvider, IPlatformProvider, IClientToolsProvider
{
	[CompilerGenerated]
	private sealed class Class18
	{
		public Func<object> func_0;

		public CoreClient coreClient_0;

		public ExtendedKeys extendedKeys_0;

		public BinaryInfo binaryInfo_0;

		public object method_0()
		{
			int num = 16;
			int num2 = 2;
			int num3 = num2;
			while (true)
			{
				if (true)
				{
				}
				switch (num3)
				{
				case 1:
					coreClient_0.MessageQueue.Queue(new SessionStop(coreClient_0.Configuration.DefaultSession, smethod_0(binaryInfo_0)));
					coreClient_0.MessageQueue.Queue(new ApplicationStop(coreClient_0.method_8(), coreClient_0.method_9(), coreClient_0.Configuration.DefaultSession, extendedKeys_0, smethod_0(binaryInfo_0)));
					num2 = 0;
					num3 = num2;
					continue;
				default:
					if (!coreClient_0.bool_0)
					{
						num2 = 1;
						num3 = num2;
						continue;
					}
					break;
				case 0:
					break;
				}
				break;
			}
			while (true)
			{
				num2 = -733;
				int num4 = num2;
				num2 = -733;
				switch (num4 == num2)
				{
				case false:
				case true:
					continue;
				}
				if (0 == 0)
				{
				}
				coreClient_0.MessageQueue.Stop();
				coreClient_0.Logger.LogInfo("닷뛂닎뻞닟뛑닏긦刿嘽到干刅嘦刁渂牖瘚爟縁牖瘑爁渿刦嘾刻带刳嘶");
				return null;
			}
		}

		public void method_1()
		{
			int num = -14530;
			int num2 = num;
			num = -14530;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			Utils.ExecuteSync(func_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class19
	{
		public CoreClient coreClient_0;

		public ExtendedKeys extendedKeys_0;

		public Guid? nullable_0;

		public BinaryInfo binaryInfo_0;

		public void method_0()
		{
			int num = -19985;
			int num2 = num;
			num = -19985;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			coreClient_0.MessageQueue.Queue(new SystemProfile(coreClient_0.Platform.GetSystemInfo(coreClient_0.Configuration.FullData), coreClient_0.Configuration.OmitPersonalInfo, nullable_0.smethod_1(coreClient_0.Configuration.DefaultSession), extendedKeys_0, smethod_0(binaryInfo_0)));
		}
	}

	[CompilerGenerated]
	private sealed class Class20
	{
		public CoreClient coreClient_0;

		public string string_0;

		public ExtendedKeys extendedKeys_0;

		public Guid? nullable_0;

		public BinaryInfo binaryInfo_0;

		public void method_0()
		{
			int num = 12689;
			int num2 = num;
			num = 12689;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			coreClient_0.MessageQueue.Queue(new PerformanceProbe(string_0, coreClient_0.Platform.GetPerformanceInfo(coreClient_0.Configuration.FullData), extendedKeys_0, nullable_0.smethod_1(coreClient_0.Configuration.DefaultSession), smethod_0(binaryInfo_0)));
		}
	}

	public const string InstanceIdKey = "InstanceID";

	public const string GeneratedUserNameKey = "GeneratedUserName";

	private bool bool_0;

	private Class1 class1_0;

	private DateTime dateTime_0 = DateTime.MinValue;

	private ExtendedKeys extendedKeys_0;

	private BinaryInfo binaryInfo_0;

	[CompilerGenerated]
	private IFlowController iflowController_0;

	[CompilerGenerated]
	private IPlatform iplatform_0;

	[CompilerGenerated]
	private ILogger ilogger_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private IMessageQueue imessageQueue_0;

	[CompilerGenerated]
	private Configuration configuration_0;

	[CompilerGenerated]
	private FeatureCorrelator featureCorrelator_0;

	[CompilerGenerated]
	private ISettingsStore isettingsStore_0;

	public IFlowController FlowController
	{
		[CompilerGenerated]
		get
		{
			int num = -14543;
			int num2 = num;
			num = -14543;
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
		private set
		{
			int num = 30582;
			int num2 = num;
			num = 30582;
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

	public IPlatform Platform
	{
		[CompilerGenerated]
		get
		{
			int num = 18427;
			int num2 = num;
			num = 18427;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return iplatform_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			if (1 == 0)
			{
			}
			int num = -25792;
			int num2 = num;
			num = -25792;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			iplatform_0 = value;
		}
	}

	public ILogger Logger
	{
		[CompilerGenerated]
		get
		{
			int num = -5022;
			int num2 = num;
			num = -5022;
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
			int num = 20212;
			int num2 = num;
			num = 20212;
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

	public bool AppStarted
	{
		[CompilerGenerated]
		get
		{
			int num = 11989;
			int num2 = num;
			num = 11989;
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
		private set
		{
			int num = -12417;
			int num2 = num;
			num = -12417;
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

	public IMessageQueue MessageQueue
	{
		[CompilerGenerated]
		get
		{
			int num = 7596;
			int num2 = num;
			num = 7596;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return imessageQueue_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 6889;
			int num2 = num;
			num = 6889;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			imessageQueue_0 = value;
		}
	}

	public Configuration Configuration
	{
		[CompilerGenerated]
		get
		{
			int num = 8038;
			int num2 = num;
			num = 8038;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return configuration_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			if (1 == 0)
			{
			}
			int num = 25607;
			int num2 = num;
			num = 25607;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			configuration_0 = value;
		}
	}

	public FeatureCorrelator Correlator
	{
		[CompilerGenerated]
		get
		{
			int num = -28264;
			int num2 = num;
			num = -28264;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return featureCorrelator_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -21296;
			int num2 = num;
			num = -21296;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			featureCorrelator_0 = value;
		}
	}

	internal ISettingsStore SettingsStore
	{
		[CompilerGenerated]
		get
		{
			int num = -32103;
			int num2 = num;
			num = -32103;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return isettingsStore_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -1503;
			int num2 = num;
			num = -1503;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			isettingsStore_0 = value;
		}
	}

	public CoreClient(IPlatform platform, [Optional] ILogger logger)
	{
		Platform = platform;
		AppStarted = false;
		Logger = logger ?? new BlankLogger();
		class1_0 = new Class1(platform, method_4, bool_3: false);
	}

	private void method_4(Class1 class1_1)
	{
		int num = 3;
		int num2 = -16896;
		int num3 = num2;
		num2 = -16896;
		switch (num3 == num2)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			switch (0)
			{
			}
			break;
		case false:
		case true:
			break;
		}
		bool lockTaken = false;
		CoreClient obj = default(CoreClient);
		try
		{
			int? sessionExtensionWindow2 = default(int?);
			while (true)
			{
				Monitor.Enter(obj = this, ref lockTaken);
				DateTime dateTime = class1_1.method_0();
				int? sessionExtensionWindow = Configuration.StopBehavior.SessionExtensionWindow;
				num2 = 0;
				int num4 = num2;
				while (true)
				{
					switch (num4)
					{
					case 18:
						Logger.LogInfo("튆\udeb6튷훶튓껾닻뚖닛뻍늒뛔닗껇刼嘱割席刦嘹刢渞爗瘒牒縜爗瘕爓減刡嘳割帪刺嘳割껝닗뛅닁뻗닝뛘늒껋튪횢튷\udeb0튡횿튽\uee80\uf2d2\uf682\uf29bﺓ\uf297\uf684\uf2d2\uee8b튪횦튻\udeac튷횲");
						method_11(extendedKeys_0, binaryInfo_0, bool_2: true, null, bool_3: true);
						num2 = 14;
						num4 = num2;
						continue;
					case 17:
						if (sessionExtensionWindow2.HasValue)
						{
							num2 = 7;
							num4 = num2;
							continue;
						}
						goto case 9;
					case 9:
						num2 = 11;
						num4 = num2;
						continue;
					case 16:
						sessionExtensionWindow2 = Configuration.StopBehavior.SessionExtensionWindow;
						num2 = 8;
						num4 = num2;
						continue;
					case 15:
						dateTime_0 = DateTime.MinValue;
						Logger.LogInfo("튆\udeb6튷훶튓껾닻뚖닅뻟닁뚖닓껂刿嘹刡帪割嘥刦渁爂瘆爗縚牞癖爐減刦噶別帿刡噶刹껋닂뛂늒뻘닀뛙닟꺎튡횢튽\udeae튢횿튼\uee89\uf2d2\uf694\uf28bﻞ\uf293\uf698\uf2d2\uee8b튳횤튾\udeb7튷횤틲껜닗뛒닇뻐닖뛗닜껚割嘗刢帮刾嘿刱渏爆瘟爝縐爡瘂爓渜刦");
						num2 = 6;
						num4 = num2;
						continue;
					case 6:
					case 14:
						num2 = 12;
						num4 = num2;
						continue;
					case 13:
						num2 = 17;
						num4 = num2;
						continue;
					case 11:
						if (AppStarted)
						{
							num2 = 15;
							num4 = num2;
							continue;
						}
						goto case 6;
					case 10:
						num2 = 2;
						num4 = num2;
						continue;
					case 8:
						if (sessionExtensionWindow2.GetValueOrDefault() > 0)
						{
							num2 = 13;
							num4 = num2;
						}
						else
						{
							num2 = 9;
							num4 = num2;
						}
						continue;
					case 7:
						num2 = 4;
						num4 = num2;
						continue;
					case 5:
						if (sessionExtensionWindow.HasValue)
						{
							goto case 10;
						}
						goto case 3;
					case 3:
						num2 = 16;
						num4 = num2;
						continue;
					case 4:
						if (dateTime_0 < dateTime)
						{
							num2 = 10;
							num4 = num2;
							continue;
						}
						goto case 9;
					case 2:
						if (AppStarted)
						{
							num2 = 18;
							num4 = num2;
							continue;
						}
						goto case 6;
					case 1:
						num2 = 5;
						num4 = num2;
						continue;
					case 0:
						if (sessionExtensionWindow.GetValueOrDefault() < 1)
						{
							num2 = 1;
							num4 = num2;
						}
						else
						{
							num2 = 3;
							num4 = num2;
						}
						continue;
					case 12:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			num2 = 0;
			int num4 = num2;
			while (true)
			{
				switch (num4)
				{
				case 1:
					Monitor.Exit(obj);
					num2 = 2;
					num4 = num2;
					continue;
				default:
					if (lockTaken)
					{
						num2 = 1;
						num4 = num2;
						continue;
					}
					break;
				case 2:
					break;
				}
				break;
			}
		}
	}

	public Guid GetActiveDefaultSession()
	{
		int num = 11178;
		int num2 = num;
		num = 11178;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			if (AppStarted)
			{
				return Configuration.DefaultSession;
			}
			break;
		case false:
		case true:
			break;
		}
		return Guid.Empty;
	}

	public bool ApplicationStart(Configuration configuration, [Optional] ExtendedKeys keys, [Optional] BinaryInfo binary, [Optional] IFlowController flowController)
	{
		int num = 7;
		switch (0)
		{
		default:
		{
			int num2 = 3329;
			int num3 = num2;
			num2 = 3329;
			switch (num3 == num2)
			{
			default:
			{
				if (0 == 0)
				{
				}
				num2 = 0;
				int num4 = num2;
				bool flag = default(bool);
				bool lockTaken = default(bool);
				CoreClient obj = default(CoreClient);
				while (true)
				{
					switch (num4)
					{
					case 11:
						if (!flag)
						{
							num2 = 5;
							num4 = num2;
							continue;
						}
						goto IL_0085;
					case 8:
						if (flag)
						{
							num2 = 1;
							num4 = num2;
							continue;
						}
						goto IL_00d3;
					case 7:
						if (Configuration.StopBehavior.SessionExtensionWindow.Value > 0)
						{
							num2 = 3;
							num4 = num2;
							continue;
						}
						goto IL_0085;
					case 5:
						num2 = 7;
						num4 = num2;
						continue;
					case 4:
						if (!AppStarted)
						{
							num2 = 12;
							num4 = num2;
							continue;
						}
						goto IL_00d3;
					case 3:
						Logger.LogInfo("튗횮튦껜닓뚖닳뻎닂뛚닛껍刳嘢刻帱刼嘅刦渏爀瘂牒縌爗瘕爗渇判嘳制幰割嘟刴꺎닓뛘늒뻿닂뛆닞껇튱횷튦\udeb7튽횸튁\uee9a\uf29d\uf686\uf2d2ﺗ\uf281\uf6d6\uf280\uee8b튱횳튻\udea8튷횲틲껙닛뛂닚뻗닜뚖닡껋刡嘥刻帱刼嘓刪渚爗瘘爁縗爝瘘爥渇刼嘲刽帩剾噶刻껚늒뛁닛뻒닞뚖닐껋틲횿튵\udeb0튽횤튷\uee8a\uf2dc\uf6d6");
						dateTime_0 = DateTime.UtcNow.AddMilliseconds(Configuration.StopBehavior.SessionExtensionWindow.Value);
						num2 = 9;
						num4 = num2;
						continue;
					case 2:
						lockTaken = false;
						num2 = 6;
						num4 = num2;
						continue;
					case 1:
						class1_0.method_3(-1);
						num2 = 4;
						num4 = num2;
						continue;
					default:
						if (!AppStarted)
						{
							num2 = 2;
							num4 = num2;
						}
						else
						{
							flag = class1_0.method_4();
							num2 = 8;
							num4 = num2;
						}
						continue;
					case 6:
						try
						{
							Monitor.Enter(obj = this, ref lockTaken);
							try
							{
								num2 = 0;
								num4 = num2;
								while (true)
								{
									switch (num4)
									{
									case 4:
									{
										method_5(Uri.TryCreate((Configuration.UseSSL ? "튺횢튦껞닁뚌늝뺑" : "튺횢튦껞늈뚙늝") + Configuration.Endpoint, UriKind.Absolute, out var _), "튆횾튷꺎닗뛘닖뻎닝뛟닜껚割嘃刀帒割嘿刡湎爛瘘爄縟爞瘟爖湂割嘸刧帲刾噺割껁닀뚖닗뻓닂뛂닋꺀");
										num2 = 1;
										num4 = num2;
										continue;
									}
									case 3:
										method_5(Configuration != null, "튑횹튼껈닛뛑닇뻌닓뛂닛껁刼噶刻席割嘸刧渂爞癘");
										num2 = 4;
										num4 = num2;
										continue;
									case 2:
										Platform.MergeStopDefaults(configuration);
										Configuration = configuration.Copy();
										num2 = 3;
										num4 = num2;
										continue;
									case 1:
										FlowController = flowController ?? new FlowController
										{
											SupportOfflineStorage = Configuration.SupportOfflineStorage,
											Offline = Configuration.Offline,
											MinimumFailureCount = Configuration.MinimumFailureCount,
											MinimumTimeToLive = Configuration.MinimumTimeToLive,
											MaximumBatchSize = Configuration.MaximumBatchSize
										};
										method_6(keys, binary);
										num2 = 5;
										num4 = num2;
										continue;
									default:
										if (configuration != null)
										{
											num2 = 2;
											num4 = num2;
											continue;
										}
										goto case 3;
									case 5:
										break;
									}
									break;
								}
							}
							catch (Exception0)
							{
							}
							catch (Exception exception_)
							{
								Logger.LogException(exception_, "튓횸틲껛닜뛓닊뻎닗뛕닆껋制噶刷带刱嘳刢渚爛瘙爜繞爝瘕爑減删嘳制");
							}
						}
						finally
						{
							num2 = 0;
							num4 = num2;
							while (true)
							{
								switch (num4)
								{
								case 1:
									Monitor.Exit(obj);
									num2 = 2;
									num4 = num2;
									continue;
								default:
									if (lockTaken)
									{
										num2 = 1;
										num4 = num2;
										continue;
									}
									break;
								case 2:
									break;
								}
								break;
							}
						}
						break;
					case 12:
						return ApplicationStart(configuration, keys, binary, flowController);
					case 9:
					case 10:
						break;
						IL_0085:
						Logger.LogWarning("튓횆튛꺎닚뛗닁뺞닓뛚닀껋刳嘲别幾到嘳刷渀牒瘅爆縟爀瘂爗渊剼");
						if (1 == 0)
						{
						}
						num2 = 10;
						num4 = num2;
						continue;
						IL_00d3:
						num2 = 11;
						num4 = num2;
						continue;
					}
					break;
				}
				break;
			}
			case false:
			case true:
				break;
			}
			return AppStarted;
		}
		}
	}

	private void method_5(bool bool_2, string string_0)
	{
		int num = 6;
		int num2 = -8003;
		int num3 = num2;
		num2 = -8003;
		switch (num3 == num2)
		{
		default:
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			if (bool_2)
			{
				break;
			}
			goto case false;
		case false:
		case true:
			Logger.LogError(string_0 + "\udef2튂횺틋꺒닷뛢닷뺒닁뛛닂긾剶嘼刱带剶嘰刋湒爅瘆爟縀爂瘗爊湼");
			throw new Exception0();
		}
	}

	private void method_6(ExtendedKeys extendedKeys_1, BinaryInfo binaryInfo_1)
	{
		int num = 18;
		int num2 = -564;
		int num3 = num2;
		num2 = -564;
		switch (num3 == num2)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			break;
		case false:
		case true:
			break;
		}
		while (true)
		{
			method_5(Configuration.OptIn, "뛽닎뻆닿뛜늎긻別噲刭帷刢噲刚渝牖瘔爟縞爅瘗牀");
			method_5(Configuration.CompanyID != Guid.Empty, "뛱닑뻟닆뛓닀긫剶嘛刚干刑嘧切渖牖瘛爍繒爟瘜爘渳刺嘻刺幼");
			method_5(Configuration.ApplicationID != Guid.Empty, "뛳닎뻂닚뛛닍긳刢嘻刱帼剶嘛刪湒爱瘇爗縖牖瘛爝湲刿嘼刨帳刺嘻勊꺜");
			method_5(FlowController.CanStartClient(), "뛦닖뻗늖뛑닛긠判嘷到带剶嘓刾渻牖瘑爑縜爐瘛爉渧判嘳刪帻刹嘼劎껖닙뛗닍뺒님뛝닚껲튷횾튲\udebd튡훲튃\uee97\uf285\uf681\uf29fﺕ\uf293\uf681\uf2ce\ueea6특훲튼\udeb7틶횡틋껜닂뚒닑뻀늖뛑닏긱刾嘷刺幼");
			method_5(Configuration.StopBehavior.StopTimeout.Value >= 0, "뛡닊뻝닆뛦닇긿刳嘽别带剶嘿创渁爂癒爜縗牖瘗爟渧刷嘾剾带刹噲勁껀늖뛕닌뻗닗뛆닋꺠틶횦튶\udeb3트훲틞\ueedc");
			num2 = 0;
			int num4 = num2;
			while (true)
			{
				switch (num4)
				{
				case 1:
					Logger.LogWarning("뛼닛뻗닒뛗닊긆刿嘿刻帔刹嘠刽渓爀瘛爐縕爷瘆爽渦刹嘢剾帻別噲勉껀닓뛓닊뻗닄뚒닚꺺튷횼틾\ude81튢횽튞\ueea6\uf29f\uf69f\uf29bﺝ\uf283\uf686\uf2c2\ueef2튡횺튷\udeb1튾훲틊껝닓뛁닐뺕닂뚒닃긳刽嘷剾帳券嘫剎渁爓瘜爍縗牘癒爨渻刮嘻到帵剶嘰勗꺒닅뛗닊뻆닟뛜닉껲튘횷튻\udeb6튳횶튺\uee9b\uf29b\uf697\uf2b8ﺝ\uf284\uf6a1\uf28f\ueea4튿횼특\ude93튢횁틚껝닆뚒닊뻝늖뛡닚긽刦嘆刷帿刳嘽创渆牑瘁牞縄爗瘞爛渷");
					Configuration.StopBehavior.NeededTimeForSavingAtStop = Configuration.StopBehavior.StopTimeout.Value;
					num2 = 2;
					num4 = num2;
					continue;
				case 0:
					if (Configuration.StopBehavior.NeededTimeForSavingAtStop.Value > Configuration.StopBehavior.StopTimeout.Value)
					{
						num2 = 1;
						num4 = num2;
						continue;
					}
					goto case 2;
				case 2:
					method_5(Configuration.StopBehavior.NeededTimeForSavingAtStop.Value >= 0, "뛼닛뻗닒뛗닊긆刿嘿刻帔刹嘠刽渓爀瘛爐縕爷瘆爽渦刹嘢剾帿刣嘡勚꺒닔뛗늞뻕닄뛗닏꺦튳횠틾\udebd튤훲튋\uee83\uf283\uf693\uf292ﻒ\uf282\uf69d\uf2ce\ueee2틸");
					method_7(extendedKeys_1, binaryInfo_1);
					return;
				}
				break;
			}
		}
	}

	private void method_7(ExtendedKeys extendedKeys_1, BinaryInfo binaryInfo_1)
	{
		int num = -19186;
		int num2 = num;
		num = -19186;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			break;
		case false:
		case true:
			break;
		}
		while (true)
		{
			method_10();
			MessageQueue.Start();
			num = 0;
			int num3 = num;
			while (true)
			{
				switch (num3)
				{
				case 1:
					MessageQueue.Queue(new ApplicationStart(method_8(), method_9(), Configuration.DefaultSession, extendedKeys_1, smethod_0(binaryInfo_1)));
					MessageQueue.Queue(new SessionStart(Configuration.DefaultSession, smethod_0(binaryInfo_1)));
					num = 2;
					num3 = num;
					continue;
				case 0:
					if (!bool_0)
					{
						num = 1;
						num3 = num;
						continue;
					}
					goto case 2;
				case 2:
					if (1 == 0)
					{
					}
					AppStarted = true;
					return;
				}
				break;
			}
		}
	}

	private HostTag method_8()
	{
		int num = 19;
		int num2 = 12784;
		int num3 = num2;
		num2 = 12784;
		HostInfo hostInfo2 = default(HostInfo);
		switch (num3 == num2)
		{
		default:
		{
			if (0 == 0)
			{
			}
			HostInfo hostInfo = default(HostInfo);
			hostInfo.IPAddress = "늃뺌늅뚘늂꺀剢噸剣";
			hostInfo.SourceLangName = "닇뻐닙뛘닝껙刼噶剼帐列嘂";
			hostInfo.SourceLangVersion = "늂뺐늂";
			hostInfo2 = hostInfo;
			try
			{
				hostInfo2 = Platform.GetHostInfo();
			}
			catch
			{
			}
			break;
		}
		case false:
		case true:
			break;
		}
		if (1 == 0)
		{
		}
		OSInfo oSInfo = default(OSInfo);
		oSInfo.Name = "닇뻐닙뛘닝껙刼";
		OSInfo osInfo = oSInfo;
		try
		{
			osInfo = Platform.GetOSInfo();
		}
		catch
		{
		}
		return new HostTag(hostInfo2, osInfo, Configuration.OmitPersonalInfo);
	}

	private UserTag method_9()
	{
		UserInfo userInfo;
		try
		{
			userInfo = Platform.GetUserInfo();
		}
		catch
		{
			UserInfo userInfo2 = default(UserInfo);
			userInfo2.HashedName = "";
			userInfo = userInfo2;
		}
		userInfo.InstanceID = Configuration.InstanceID;
		int num = 2;
		int num2 = num;
		string text;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!Configuration.InstanceIdUserSet)
				{
					num = 1;
					num2 = num;
				}
				else
				{
					num = 3;
					num2 = num;
				}
				continue;
			case 1:
			{
				num = 17512;
				int num3 = num;
				num = 17512;
				switch (num3 == num)
				{
				case false:
				case true:
					continue;
				}
				if (0 == 0)
				{
				}
				num = 0;
				num2 = num;
				continue;
			}
			default:
				if (1 == 0)
				{
				}
				text = Configuration.InstanceID;
				break;
			case 3:
				text = Platform.GetGeneratedUserName(Configuration, Logger);
				break;
			}
			break;
		}
		string fallbackName = text;
		return new UserTag(userInfo, Configuration.OmitPersonalInfo, fallbackName);
	}

	private void method_10()
	{
		int num = 7;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 25:
				num = 16;
				num2 = num;
				break;
			case 18:
			case 24:
				num = 21;
				num2 = num;
				break;
			case 23:
				num = 10;
				num2 = num;
				break;
			case 6:
			case 22:
				num = 8;
				num2 = num;
				break;
			case 21:
				if (Configuration.InstanceID == null)
				{
					num = 13;
					num2 = num;
				}
				else
				{
					Configuration.InstanceIdUserSet = true;
					num = 6;
					num2 = num;
				}
				break;
			case 20:
				num = 5;
				num2 = num;
				break;
			case 19:
				MessageQueue = new MessageQueue(this, FlowController);
				num = 20;
				num2 = num;
				break;
			case 17:
				if (Configuration.MessageGroup == Guid.Empty)
				{
					num = 1;
					num2 = num;
					break;
				}
				goto case 3;
			case 3:
				bool_0 = false;
				num = 24;
				num2 = num;
				break;
			case 16:
				if (MessageQueue.Stopped)
				{
					num = 19;
					num2 = num;
					break;
				}
				goto case 20;
			case 15:
				if (Configuration.MessageGroup == Guid.Empty)
				{
					num = 14;
					num2 = num;
					break;
				}
				goto case 11;
			case 11:
				bool_0 = true;
				num = 18;
				num2 = num;
				break;
			case 14:
				Configuration.MessageGroup = Guid.NewGuid();
				num = 11;
				num2 = num;
				break;
			case 13:
			{
				num = -12077;
				int num3 = num;
				num = -12077;
				switch (num3 == num)
				{
				case false:
				case true:
					break;
				default:
					if (0 == 0)
					{
					}
					Configuration.InstanceID = Platform.GetInstanceId(Configuration, Logger);
					num = 2;
					num2 = num;
					goto end_IL_03b6;
				}
				goto case 19;
			}
			case 12:
				Configuration.DefaultSession = Guid.NewGuid();
				num = 17;
				num2 = num;
				break;
			case 10:
				if (Configuration.DefaultSession == Guid.Empty)
				{
					num = 12;
					num2 = num;
				}
				else
				{
					num = 15;
					num2 = num;
				}
				break;
			case 9:
				if (true)
				{
				}
				goto IL_0297;
			case 8:
				if (MessageQueue != null)
				{
					num = 25;
					num2 = num;
					break;
				}
				goto case 19;
			default:
				if (string.IsNullOrEmpty(Configuration.Endpoint))
				{
					num = 4;
					num2 = num;
					break;
				}
				goto case 23;
			case 4:
				Configuration.Endpoint = Platform.GetDefaultEndpoint();
				num = 23;
				num2 = num;
				break;
			case 2:
				if (string.IsNullOrEmpty(Configuration.InstanceID))
				{
					num = 0;
					num2 = num;
					break;
				}
				goto IL_0297;
			case 1:
				Configuration.MessageGroup = Configuration.DefaultSession;
				num = 3;
				num2 = num;
				break;
			case 0:
				Configuration.InstanceID = Guid.NewGuid().ToString();
				Configuration.GeneratedUserName = Configuration.InstanceID;
				num = 9;
				num2 = num;
				break;
			case 5:
				{
					Correlator = Correlator ?? new FeatureCorrelator();
					return;
				}
				IL_0297:
				Configuration.InstanceIdUserSet = false;
				num = 22;
				num2 = num;
				break;
				end_IL_03b6:
				break;
			}
		}
	}

	public void ApplicationStop([Optional] ExtendedKeys keys, [Optional] BinaryInfo binary, [Optional] bool synchronous, [Optional] bool immediate)
	{
		int num = 18;
		switch (0)
		{
		default:
		{
			int num2 = 2;
			int num3 = num2;
			bool lockTaken = default(bool);
			CoreClient obj = default(CoreClient);
			int? sessionExtensionWindow = default(int?);
			while (true)
			{
				switch (num3)
				{
				case 3:
					lockTaken = false;
					num2 = 0;
					num3 = num2;
					continue;
				case 0:
					try
					{
						while (true)
						{
							Monitor.Enter(obj = this, ref lockTaken);
							num2 = 3;
							num3 = num2;
							while (true)
							{
								num2 = 675;
								int num4 = num2;
								num2 = 675;
								switch (num4 == num2)
								{
								case false:
								case true:
									num2 = 9;
									num3 = num2;
									continue;
								default:
									{
										if (0 == 0)
										{
										}
										switch (num3)
										{
										case 0:
											break;
										case 1:
											goto IL_012c;
										case 3:
											goto IL_014e;
										case 4:
											goto IL_016a;
										case 6:
											goto IL_0190;
										case 7:
											goto IL_01b2;
										case 8:
											goto IL_01d7;
										case 10:
											goto IL_01ec;
										case 11:
											goto IL_0202;
										case 5:
										case 9:
											goto IL_021d;
										case 12:
											goto IL_0243;
										case 13:
											goto IL_0251;
										default:
											goto end_IL_027f;
										case 2:
											return;
										}
										if (synchronous)
										{
											num2 = 4;
											num3 = num2;
											continue;
										}
										goto IL_021d;
									}
									IL_0251:
									num2 = 11;
									num3 = num2;
									continue;
									IL_0202:
									if (sessionExtensionWindow.HasValue)
									{
										num2 = 8;
										num3 = num2;
										continue;
									}
									goto IL_021d;
									IL_0243:
									num2 = 0;
									num3 = num2;
									continue;
									IL_01ec:
									if (!immediate)
									{
										num2 = 7;
										num3 = num2;
										continue;
									}
									goto IL_021d;
									IL_012c:
									class1_0.method_3(10);
									num2 = 12;
									num3 = num2;
									continue;
									IL_01d7:
									num2 = 10;
									num3 = num2;
									continue;
									IL_01b2:
									Logger.LogWarning("뛳늞뻁닏뛜닍긺判嘽到帽刣嘡剎渳爆瘂爒縛爕瘓爚渻刹嘼剾币刢嘽勞꺒닁뛓닍뺒닄뛗닍꺷튿횤튻\udeb6틺훲튌\uee87\uf282\uf6d2\uf29aﺇ\uf293\uf6d2\uf29a\ueebd틶횁튻\udea1튥횻틁껜닳뛊닊뻗님뛁닇긽券嘅刷帼刲嘽则湒爔瘗爗縜爑癒爏渱刢嘻刨帳刢嘷勊꺞늖뛛닊뺒닁뛛닂꺾틶횷트\udeb4튳횱튚\uee9b\uf280\uf697\uf292ﺋ\uf2d6\uf690\uf28b\ueef2튷횡튧\udebc튵횺틜껝님뛝닋뻁늖뛓닀긶剶嘼刱帼剻嘰刂渝爕瘙爗縜爑");
									num2 = 5;
									num3 = num2;
									continue;
									IL_0190:
									if (sessionExtensionWindow.GetValueOrDefault() > 0)
									{
										num2 = 13;
										num3 = num2;
										continue;
									}
									goto case false;
									IL_021d:
									method_11(keys, binary, synchronous, null, immediate);
									num2 = 2;
									num3 = num2;
									continue;
									IL_016a:
									sessionExtensionWindow = Configuration.StopBehavior.SessionExtensionWindow;
									num2 = 6;
									num3 = num2;
									continue;
									IL_014e:
									if (immediate)
									{
										num2 = 1;
										num3 = num2;
										continue;
									}
									goto IL_0243;
									end_IL_027f:
									break;
								}
								break;
							}
						}
					}
					finally
					{
						num2 = 2;
						num3 = num2;
						while (true)
						{
							switch (num3)
							{
							default:
								if (lockTaken)
								{
									num2 = 0;
									num3 = num2;
									continue;
								}
								break;
							case 0:
								Monitor.Exit(obj);
								num2 = 1;
								num3 = num2;
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				case 1:
					return;
				}
				if (AppStarted)
				{
					if (1 == 0)
					{
					}
					num2 = 3;
					num3 = num2;
				}
				else
				{
					Logger.LogWarning("뛳닮뻻늖뛛닝깲券嘽刪干判嘧刀渜爟瘜爙繜牖瘳爞渢刺嘻刽帳刢嘻勁껜늖뛁닊뻝닆뚒닙꺻튺횾틾\udebc특횦틎\uee90\uf293\uf6d2\uf29bﺊ\uf293\uf691\uf29b\ueea6튳횶티");
					num2 = 1;
					num3 = num2;
				}
			}
		}
		}
	}

	private void method_11(ExtendedKeys extendedKeys_1, BinaryInfo binaryInfo_1, [Optional] bool bool_2, [Optional] int? nullable_0, [Optional] bool bool_3)
	{
		int num = 0;
		switch (0)
		{
		}
		CancellationToken token = default(CancellationToken);
		Task task = default(Task);
		while (true)
		{
			if (true)
			{
			}
			int num2 = 2;
			int num3 = num2;
			Func<object> func_0 = default(Func<object>);
			while (true)
			{
				switch (num3)
				{
				case 15:
					if (!nullable_0.HasValue)
					{
						num2 = 6;
						num3 = num2;
						continue;
					}
					goto case 11;
				case 11:
					AppStarted = false;
					func_0 = delegate
					{
						int num5 = 16;
						int num6 = 2;
						int num7 = num6;
						while (true)
						{
							if (true)
							{
							}
							switch (num7)
							{
							case 1:
								MessageQueue.Queue(new SessionStop(Configuration.DefaultSession, smethod_0(binaryInfo_1)));
								MessageQueue.Queue(new ApplicationStop(method_8(), method_9(), Configuration.DefaultSession, extendedKeys_1, smethod_0(binaryInfo_1)));
								num6 = 0;
								num7 = num6;
								continue;
							default:
								if (!bool_0)
								{
									num6 = 1;
									num7 = num6;
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
						while (true)
						{
							num6 = -733;
							int num8 = num6;
							num6 = -733;
							switch (num8 == num6)
							{
							case false:
							case true:
								break;
							default:
								if (0 == 0)
								{
								}
								MessageQueue.Stop();
								Logger.LogInfo("닷뛂닎뻞닟뛑닏긦刿嘽到干刅嘦刁渂牖瘚爟縁牖瘑爁渿刦嘾刻带刳嘶");
								return null;
							}
						}
					};
					num2 = 9;
					num3 = num2;
					continue;
				case 13:
					if (Configuration.StopBehavior.SessionExtensionWindow.Value >= 1)
					{
						num2 = 7;
						num3 = num2;
						continue;
					}
					goto IL_00b5;
				case 12:
				{
					CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
					token = cancellationTokenSource.Token;
					num2 = 4;
					num3 = num2;
					continue;
				}
				case 10:
					if (!task.Wait(nullable_0.Value, token))
					{
						num2 = 8;
						num3 = num2;
						continue;
					}
					return;
				case 9:
					if (bool_2)
					{
						num2 = 12;
						num3 = num2;
					}
					else
					{
						Platform.ExecuteAsync(func_0, null, highPriority: true);
						num2 = 0;
						num3 = num2;
					}
					continue;
				case 7:
					num2 = 1;
					num3 = num2;
					continue;
				case 6:
					nullable_0 = Configuration.StopBehavior.StopTimeout;
					num2 = 11;
					num3 = num2;
					continue;
				case 5:
					num2 = 3;
					num3 = num2;
					continue;
				case 4:
					task = Task.Factory.StartNew(delegate
					{
						int num9 = -14530;
						int num10 = num9;
						num9 = -14530;
						switch (num10 == num9)
						{
						default:
							if (0 == 0)
							{
							}
							if (1 == 0)
							{
							}
							Utils.ExecuteSync(func_0);
							break;
						}
					}, token);
					num2 = 10;
					num3 = num2;
					continue;
				case 2:
				{
					num2 = 24190;
					int num4 = num2;
					num2 = 24190;
					switch (num4 == num2)
					{
					case false:
					case true:
						continue;
					}
					if (0 == 0)
					{
					}
					if (!AppStarted)
					{
						num2 = 5;
						num3 = num2;
						continue;
					}
					extendedKeys_0 = extendedKeys_1;
					binaryInfo_0 = binaryInfo_1;
					num2 = 13;
					num3 = num2;
					continue;
				}
				case 1:
					if (!bool_3)
					{
						num2 = 14;
						num3 = num2;
						continue;
					}
					goto IL_00b5;
				case 3:
					return;
				case 8:
					Logger.LogWarning("튗횢튮\udebe튿횱틏껆닟뛝닐뺒닥뛆닁긢剶嘺刿帡剶嘦切渟爓瘖牞縝爃瘆牀湲刄嘷刪帧判嘼勇껜닑뚒닚뻗닅뛂닇꺦튳훲튰\udebd튢훲튌\uee97\uf29f\uf69c\uf299ﻒ\uf295\uf69d\uf283\ueea2튺횷튪\udeb7튲");
					return;
				case 0:
					return;
				case 14:
					{
						Logger.LogInfo("튗횢튮\udebe튿횱틏껆닟뛝닐뻡닂뛝닞깲刵嘳刲帾刳嘶剀湒爥瘗爍縁爟瘝爀湲刳嘪刪帷券嘡勇껝님뚒닊뻛닛뛗닜껲튷횱튪\udebb튠횳튚\uee97\uf292");
						class1_0.method_2(Configuration.StopBehavior.SessionExtensionWindow.Value);
						return;
					}
					IL_00b5:
					num2 = 15;
					num3 = num2;
					continue;
				}
				break;
			}
		}
	}

	public void FeatureTick(string name, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary)
	{
		int num = 2;
		int num2 = 2;
		int num3 = num2;
		while (true)
		{
			switch (num3)
			{
			case 2:
			{
				num2 = -19664;
				int num4 = num2;
				num2 = -19664;
				switch (num4 == num2)
				{
				case false:
				case true:
					goto end_IL_00a6;
				}
				if (1 == 0)
				{
				}
				if (false)
				{
				}
				goto default;
			}
			default:
				if (!AppStarted)
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
			case 0:
				if (!string.IsNullOrEmpty(name))
				{
					num2 = 1;
					num3 = num2;
					continue;
				}
				Logger.LogError("횔튻\udeb3튢횧틜껗늖뛆닗뻑닝뚒닀긳刻嘷剾帻別噲刋減爂瘚爛縀牖瘜爛渾刺噲刱帠剶嘷勃껂닂뛋느뺒닰뛗닏꺦튣횠튻\udef2튢횻튍\uee99\uf2d6\uf685\uf297ﺞ\uf29a\uf6d2\uf280\ueebd튢훲튼\udeb7틶횡틋껜닂뚜");
				return;
			case 1:
				MessageQueue.Queue(new FeatureTick(name, session.smethod_1(Configuration.DefaultSession), keys, smethod_0(binary)));
				return;
			case 3:
				break;
				end_IL_00a6:
				break;
			}
			break;
		}
		Logger.LogError("횓튎\ude9b틶횺틏껁늖뛜닑뻆늖뛐닋긷券噲刭带刷嘠刚渗爒癜牞縴爓瘓爚渧判嘷剾带刿嘱勅꺒닁뛛닒뻞늖뛜닁꺦틶횰튻\udef2튥횷튀\uee86\uf2d8");
	}

	public void FeatureTick(string name, Guid? session, [Optional] BinaryInfo binary)
	{
		int num = 1;
		int num2 = 2;
		int num3 = num2;
		while (true)
		{
			switch (num3)
			{
			case 2:
			{
				num2 = 24681;
				int num4 = num2;
				num2 = 24681;
				switch (num4 == num2)
				{
				case false:
				case true:
					goto end_IL_00a6;
				}
				if (false)
				{
				}
				goto default;
			}
			default:
				if (!AppStarted)
				{
					num2 = 3;
					num3 = num2;
					continue;
				}
				if (1 == 0)
				{
				}
				num2 = 0;
				num3 = num2;
				continue;
			case 0:
				if (!string.IsNullOrEmpty(name))
				{
					num2 = 1;
					num3 = num2;
					continue;
				}
				Logger.LogError("횐튷\udebf튦횣튠껋늒뛂닛뻝닙뚖닜껏刿嘳割帷刡噶刷渇爆瘞爗縌牒瘘爇渂刾噶刽帬割嘳刿껞닆뛏늜뺞담뛓닓껚튧횤튷\udefe튦횿튱\uee85\uf2d2\uf681\uf29bﺒ\uf29e\uf6d6\uf29c\uee81튦훶튰\udebb틲횥튷껀닆뚘");
				return;
			case 1:
				MessageQueue.Queue(new FeatureTick(name, session.smethod_1(Configuration.DefaultSession), null, smethod_0(binary)));
				return;
			case 3:
				break;
				end_IL_00a6:
				break;
			}
			break;
		}
		Logger.LogError("횗튂\ude97틲횾튳껝늒뛘닝뻊늒뛔닗껋刼噶刡帪刳嘤刦渋爖癘牒縸爗瘗爆減删嘳割帪刻嘵刹꺎닅뛟닞뻒늒뛘닝껚틲횴튷\udefe튡횳튼\uee9a\uf2dc");
	}

	public void FeatureStart(string name, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary, [Optional] Guid? group)
	{
		int num = 9;
		int num2 = 2;
		int num3 = num2;
		while (true)
		{
			switch (num3)
			{
			case 2:
			{
				num2 = -14481;
				int num4 = num2;
				num2 = -14481;
				switch (num4 == num2)
				{
				case false:
				case true:
					goto end_IL_00a6;
				}
				if (0 == 0)
				{
				}
				if (true)
				{
				}
				goto default;
			}
			default:
				if (!AppStarted)
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
			case 0:
				if (string.IsNullOrEmpty(name))
				{
					num2 = 1;
					num3 = num2;
					continue;
				}
				MessageQueue.Queue(new Class10(name, session.smethod_1(Configuration.DefaultSession), group.smethod_1(Correlator.Start(name).UniqueId), keys, smethod_0(binary)));
				return;
			case 1:
				Logger.LogError("횐튷껏닆뛃닀뻛늒뛅닆껏删嘢割帰刳嘻刷湎爛瘅牒縛爛瘂爚渋删噶刼師刾嘺割껁닀뚖닗뻓닂뛂닋꺀틲횐튷\udebf튦횣튠\uee8b\uf2d2\uf685\uf286ﺟ\uf280\uf682\uf2d2\uee99튻횺튾\udefe튼횹튦꺎닐뛓늒뻍닗뛘닆꺀");
				return;
			case 3:
				break;
				end_IL_00a6:
				break;
			}
			break;
		}
		Logger.LogError("횗튂껧늒뛞닓뻍늒뛘닝껚割嘴刷帻刼噶刡渚爓瘄爆縛爖癘牒渨刷嘷刦師删嘳割껝닆뛗닀뻊늒뛁닛껂튾훶튼\udeb1튦훶튰\uee8b\uf2d2\uf685\uf297ﺐ\uf286\uf6d8");
	}

	public void FeatureStop(string name, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary, [Optional] Guid? group)
	{
		int num = 4;
		int num2 = 2;
		int num3 = num2;
		while (true)
		{
			switch (num3)
			{
			case 2:
			{
				num2 = 7310;
				int num4 = num2;
				num2 = 7310;
				switch (num4 == num2)
				{
				case false:
				case true:
					goto end_IL_00a6;
				}
				if (false)
				{
				}
				goto default;
			}
			default:
				if (!AppStarted)
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
			case 0:
				if (string.IsNullOrEmpty(name))
				{
					if (1 == 0)
					{
					}
					num2 = 1;
					num3 = num2;
					continue;
				}
				MessageQueue.Queue(new Class11(name, session.smethod_1(Configuration.DefaultSession), group.smethod_1(Correlator.Stop(name).UniqueId), keys, smethod_0(binary)));
				return;
			case 1:
				Logger.LogError("튘\udeb7튷횦틛껀닓뚒닍뻆닙뛂늎긼刷嘿刻干刿嘡剎渗爟瘆爖縗爄癒爀渧刺嘾剾帽判噲勋껟닆뛆닇뺜늖뛴닋꺳튢횧튬\udeb7틶횡튚\uee9d\uf286\uf6d2\uf289ﺛ\uf29a\uf69e\uf2ce\ueebc특횦틾\udeb0튳훲틝껗님뛆느");
				return;
			case 3:
				break;
				end_IL_00a6:
				break;
			}
			break;
		}
		Logger.LogError("튟\ude82튟훲틆껓닅뚒닐뻝닂뚒닌긷刳嘼剾帡刢嘳刜渆爓瘖牐繒爰瘗爏渦刣嘠刻干別嘦勁껂늖뛅닗뻞닚뚒닀꺽튢훲튼\udeb7틶횡튋\uee9c\uf282\uf6dc");
	}

	public void ReportException(ExceptionInfo exceptionInfo, [Optional] bool optinOverride, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary)
	{
		int num = 2;
		int num2 = 7;
		int num3 = num2;
		bool flag = default(bool);
		while (true)
		{
			int num4;
			switch (num3)
			{
			case 20:
				num2 = 16;
				num3 = num2;
				break;
			case 19:
				if (Configuration == null)
				{
					num2 = 1;
					num3 = num2;
				}
				else
				{
					num2 = 2;
					num3 = num2;
				}
				break;
			case 17:
				if (AppStarted)
				{
					num2 = 5;
					num3 = num2;
					break;
				}
				goto case 20;
			case 16:
				if (flag)
				{
					num2 = 14;
					num3 = num2;
					break;
				}
				return;
			case 14:
				ApplicationStop(null, null, synchronous: true, immediate: false);
				Configuration.OptIn = false;
				num2 = 4;
				num3 = num2;
				break;
			case 13:
				if (flag)
				{
					num2 = 11;
					num3 = num2;
					break;
				}
				goto case 10;
			case 10:
				num2 = 17;
				num3 = num2;
				break;
			case 12:
				num4 = ((!AppStarted) ? 1 : 0);
				goto IL_00f5;
			case 11:
				Logger.LogInfo("횓튪\udea6튳횿틞껆닟뛜닙뺒닗뛜늎긳刣嘦刱帿刷嘦切渑牖瘳爎縂爥瘆爏渠刢噲刪帽剶嘠勋껂닙뛀닊뺒닗뛜늎꺷튮횱튻\udea2튢횻튁\uee9c\uf2d8");
				Configuration.OptIn = true;
				ApplicationStart(Configuration);
				num2 = 10;
				num3 = num2;
				break;
			case 9:
				if (optinOverride)
				{
					num2 = 8;
					num3 = num2;
				}
				else
				{
					num2 = 3;
					num3 = num2;
				}
				break;
			case 8:
				num2 = 12;
				num3 = num2;
				break;
			default:
				if (!AppStarted)
				{
					num2 = 11916;
					int num5 = num2;
					num2 = 11916;
					switch (num5 == num2)
					{
					default:
						if (0 == 0)
						{
						}
						num2 = 6;
						num3 = num2;
						goto end_IL_0294;
					case false:
					case true:
						break;
					}
					goto IL_01e3;
				}
				goto IL_0226;
			case 6:
				num2 = 0;
				num3 = num2;
				break;
			case 5:
				if (1 == 0)
				{
				}
				goto IL_01e3;
			case 3:
				num4 = 0;
				goto IL_00f5;
			case 2:
				if (exceptionInfo == null)
				{
					num2 = 18;
					num3 = num2;
				}
				else
				{
					num2 = 9;
					num3 = num2;
				}
				break;
			case 0:
				if (!optinOverride)
				{
					num2 = 15;
					num3 = num2;
					break;
				}
				goto IL_0226;
			case 1:
				Logger.LogError("횆튶\udeb7틶횓틾껻늖뛚닟뻁늖뛜닁긦剶嘰刻帷券噲刍渝爘瘔爗縕爃瘀爋渶剶嘦刱干別嘷勀껖늖뛟닛뻁닅뛓닉꺷튥훼틾\ude86튾횷틎\uee97\uf28e\uf691\uf29bﺂ\uf282\uf69b\uf281\ueebc틶횿튻\udea1튥횳틉껗늖뛅닗뻞닚뚒닀긽刢噲刼帷剶嘡刋渜爂癜");
				return;
			case 15:
				Logger.LogError("횓튎\ude9b틶횺틏껁늖뛜닑뻆늖뛐닋긷券噲刭带刷嘠刚渗爒癜牞縷爎瘑爋渢刢嘻刱帼剶嘥勇껞닚뚒닐뻝닂뚒닌꺷틶횠튻\udea2특횠튚\uee97\uf292\uf6dc");
				return;
			case 4:
				return;
			case 18:
				{
					Logger.LogError("횜튱\udef2튠횳틂껛닒뚒닛뻊닕뛗닞긦刿嘽到干刿嘼刈渝爄瘟爟縆爟瘝爀湲刾嘳刭干刴嘷勋껜늖뛂닌뻝닀뛛닊꺷튲훼틾\ude86튾횷틎\uee97\uf28e\uf691\uf29bﺂ\uf282\uf69b\uf281\ueebc틶횿튻\udea1튥횳틉껗늖뛅닗뻞닚뚒닀긽刢噲刼帷剶嘡刋渜爂癜");
					return;
				}
				IL_01e3:
				MessageQueue.Queue(new Fault(Platform, exceptionInfo, session.smethod_1(Configuration.DefaultSession), keys, smethod_0(binary), includeAppComponents: true));
				num2 = 20;
				num3 = num2;
				break;
				IL_0226:
				num2 = 19;
				num3 = num2;
				break;
				IL_00f5:
				flag = (byte)num4 != 0;
				num2 = 13;
				num3 = num2;
				break;
				end_IL_0294:
				break;
			}
		}
	}

	public void ReportTamper([Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary, [Optional] Configuration config)
	{
		int num = 6;
		int num2 = 2;
		int num3 = num2;
		bool optIn = default(bool);
		bool flag = default(bool);
		while (true)
		{
			if (true)
			{
			}
			num2 = -28127;
			int num4 = num2;
			num2 = -28127;
			switch (num4 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				switch (num3)
				{
				default:
					if (Configuration == null)
					{
						num2 = 5;
						num3 = num2;
						goto end_IL_003b;
					}
					goto IL_00d2;
				case 4:
					if (config == null)
					{
						num2 = 3;
						num3 = num2;
						goto end_IL_003b;
					}
					goto IL_00d2;
				case 5:
					num2 = 4;
					num3 = num2;
					goto end_IL_003b;
				case 6:
					ApplicationStop(null, null, synchronous: true, immediate: false);
					config.OptIn = optIn;
					num2 = 12;
					num3 = num2;
					goto end_IL_003b;
				case 7:
					config = Configuration;
					num2 = 0;
					num3 = num2;
					goto end_IL_003b;
				case 8:
					Logger.LogInfo("\ude93튢횦틋껟닆뛆닗뻜닑뚒닏긼剶嘳别带刹嘿刏渆爟瘑牞縳爆瘂爽渦刷嘠刪干刢嘽劎껀닓뛂닑뻀닂뚒닏껲튢횳튳\udea2튳횠틀");
					optIn = config.OptIn;
					config.OptIn = true;
					ApplicationStart(config);
					num2 = 14;
					num3 = num2;
					goto end_IL_003b;
				case 9:
					MessageQueue.Queue(new Tamper(session.smethod_1(Configuration.DefaultSession), keys, smethod_0(binary)));
					num2 = 1;
					num3 = num2;
					goto end_IL_003b;
				case 10:
					if (flag)
					{
						num2 = 8;
						num3 = num2;
						goto end_IL_003b;
					}
					goto case 14;
				case 11:
					if (AppStarted)
					{
						num2 = 9;
						num3 = num2;
						goto end_IL_003b;
					}
					goto case 1;
				case 1:
					num2 = 15;
					num3 = num2;
					goto end_IL_003b;
				case 13:
					if (config != null)
					{
						break;
					}
					num2 = 7;
					num3 = num2;
					goto end_IL_003b;
				case 14:
					num2 = 11;
					num3 = num2;
					goto end_IL_003b;
				case 15:
					if (flag)
					{
						num2 = 6;
						num3 = num2;
						goto end_IL_003b;
					}
					return;
				case 0:
					break;
				case 3:
					Logger.LogError("\ude86튾횷튎껳닦뛻늞뻚닗뛁늎긼刹嘦剾帰刳嘷刀湒爕瘝爐縔爟瘕爛渠刳嘶剾带刹噲勝껗님뛖늞뻟닓뛁닝꺳튱횷튭\udefc틶횆튆\uee97\uf2d6\uf686\uf29fﺟ\uf286\uf697\uf29c\ueef2튻횷튭\udea1튷횵틋꺒닁뛛닒뻞늖뛜닁긦剶嘰刻干別嘷刀渆牘");
					return;
				case 12:
					return;
					IL_00d2:
					num2 = 13;
					num3 = num2;
					goto end_IL_003b;
				}
				goto case false;
			case false:
			case true:
				{
					flag = !AppStarted;
					optIn = false;
					num2 = 10;
					num3 = num2;
					break;
				}
				end_IL_003b:
				break;
			}
		}
	}

	public void ReportDebugging([Optional] bool optinOverride, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary, [Optional] Configuration config)
	{
		int num = 2;
		int num2 = 16;
		int num3 = num2;
		bool flag = default(bool);
		bool optIn = default(bool);
		while (true)
		{
			int num4;
			switch (num3)
			{
			case 29:
				num2 = 19;
				num3 = num2;
				break;
			case 28:
				num2 = 0;
				num3 = num2;
				break;
			case 27:
				if (!config.OptIn)
				{
					num2 = 23;
					num3 = num2;
					break;
				}
				goto case 10;
			case 10:
				num2 = 1;
				num3 = num2;
				break;
			case 26:
				if (!config.OptIn)
				{
					num2 = 10;
					num3 = num2;
					break;
				}
				goto IL_008f;
			case 25:
				num2 = 26;
				num3 = num2;
				break;
			case 24:
				if (!AppStarted)
				{
					num2 = 29;
					num3 = num2;
					break;
				}
				goto IL_00d3;
			case 23:
				if (1 == 0)
				{
				}
				num2 = 7;
				num3 = num2;
				break;
			case 22:
				if (config == null)
				{
					num2 = 6;
					num3 = num2;
					break;
				}
				goto case 18;
			case 18:
				num2 = 24;
				num3 = num2;
				break;
			case 19:
				if (!config.OptIn)
				{
					num2 = 4;
					num3 = num2;
					break;
				}
				goto IL_00d3;
			case 17:
				if (flag)
				{
					num2 = 3;
					num3 = num2;
					break;
				}
				goto case 13;
			case 13:
				num2 = 2;
				num3 = num2;
				break;
			default:
				if (Configuration == null)
				{
					num2 = 9;
					num3 = num2;
					break;
				}
				goto IL_019b;
			case 15:
				num4 = 0;
				goto IL_01b0;
			case 14:
				ApplicationStop(null, null, synchronous: true, immediate: false);
				config.OptIn = optIn;
				num2 = 5;
				num3 = num2;
				break;
			case 12:
				if (config == null)
				{
					num2 = 20;
					num3 = num2;
					break;
				}
				goto IL_019b;
			case 11:
			{
				ExceptionInfo exceptionInfo = ExceptionInfo.Caught("횱튱\udebf틸횢틜껗닓뛟닎뻆닟뛄닋깼划嘷刼帧刱嘵切渜爑瘱爖縗爕瘙", "횖튻\udeb0튣횵틉껛님뛕늞뻅닗뛁늎긶刳嘦刻帱刢嘷刊湜", "횇튰\udeb9트횽틙껜늖뛧닐뻙님뛝닙긼", "훺티\udef8틿훲튆꺜늜뚛");
				MessageQueue.Queue(new Fault(Platform, exceptionInfo, session.smethod_1(Configuration.DefaultSession), keys, smethod_0(binary), includeAppComponents: false));
				num2 = 28;
				num3 = num2;
				break;
			}
			case 9:
				num2 = 12;
				num3 = num2;
				break;
			case 8:
				if (optinOverride)
				{
					goto IL_00d3;
				}
				goto IL_0280;
			case 7:
				if (optinOverride)
				{
					num2 = 25;
					num3 = num2;
					break;
				}
				goto IL_008f;
			case 6:
				config = Configuration;
				num2 = 18;
				num3 = num2;
				break;
			case 4:
			{
				num2 = 19783;
				int num5 = num2;
				num2 = 19783;
				switch (num5 == num2)
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
					goto end_IL_0393;
				}
				goto IL_0280;
			}
			case 3:
				Logger.LogInfo("횓튪\udea6튳횿틞껆닟뛜닙뺒닗뛜늎긳刣嘦刱帿刷嘦切渑牖瘳爎縂爥瘆爏渠刢噲刪帽剶嘠勋껂닙뛀닊뺒닒뛗닌꺧튱횵튷\udebc튱훼");
				optIn = config.OptIn;
				config.OptIn = true;
				ApplicationStart(config);
				num2 = 13;
				num3 = num2;
				break;
			case 2:
				if (AppStarted)
				{
					num2 = 11;
					num3 = num2;
					break;
				}
				goto case 28;
			case 1:
				num4 = ((!AppStarted) ? 1 : 0);
				goto IL_01b0;
			case 0:
				if (flag)
				{
					num2 = 14;
					num3 = num2;
					break;
				}
				return;
			case 5:
				return;
			case 20:
				Logger.LogError("횆튶\udeb7틶횓틾껻늖뛚닟뻁늖뛜닁긦剶嘰刻帷券噲刍渝爘瘔爗縕爃瘀爋渶剶嘦刱干別嘷勀껖늖뛟닛뻁닅뛓닉꺷튥훼틾\ude86튾횷틎\uee96\uf293\uf690\uf28bﺕ\uf291\uf69b\uf280\ueeb5틶횿튻\udea1튥횳틉껗늖뛅닗뻞닚뚒닀긽刢噲刼帷剶嘡刋渜爂癜");
				return;
			case 21:
				{
					Logger.LogError("횓튎\ude9b틶횺틏껁늖뛜닑뻆늖뛐닋긷券噲刭带刷嘠刚渗爒癜牞縶爓瘐爛渵刱嘻到帵剶嘥勇껞닚뚒닐뻝닂뚒닌꺷틶횠튻\udea2특횠튚\uee97\uf292\uf6dc");
					return;
				}
				IL_00d3:
				num2 = 27;
				num3 = num2;
				break;
				IL_0280:
				num2 = 21;
				num3 = num2;
				break;
				IL_01b0:
				flag = (byte)num4 != 0;
				optIn = false;
				num2 = 17;
				num3 = num2;
				break;
				IL_019b:
				num2 = 22;
				num3 = num2;
				break;
				IL_008f:
				num2 = 15;
				num3 = num2;
				break;
				end_IL_0393:
				break;
			}
		}
	}

	public virtual void ReportExpiration(Guid slid, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary)
	{
		int num = 5;
		int num2 = 3;
		int num3 = num2;
		while (true)
		{
			if (true)
			{
			}
			num2 = 6944;
			int num4 = num2;
			num2 = 6944;
			switch (num4 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				switch (num3)
				{
				case 0:
					if (Guid.Empty == slid)
					{
						num2 = 1;
						num3 = num2;
						continue;
					}
					MessageQueue.Queue(new Class8(slid, session.smethod_1(Configuration.DefaultSession), keys, smethod_0(binary)));
					return;
				default:
					if (!AppStarted)
					{
						num2 = 2;
						num3 = num2;
					}
					else
					{
						num2 = 0;
						num3 = num2;
					}
					continue;
				case 1:
					Logger.LogError("\ude8d튺횳튾껈닞뛟닔뻛늒뛿닶꺎刻嘥割帻刿嘦刦渗牒瘱爧縷父癘牒港刢嘦刾帷刱嘷刦껇닝뛘늒뻻닊뛆닛껜튳횢튻\udeb1튼훶튥\uee87\uf29e\uf69a\uf2d2ﺐ\uf29d\uf682\uf2d2\uee8c튷훶튡\udebb튼횢틼");
					return;
				case 2:
					break;
				}
				break;
			case false:
			case true:
				break;
			}
			break;
		}
		Logger.LogError("\ude9f튂횟틲껆닓뛅늒뻐닝뛂늒껌刷嘳刼幾刡嘢刳渜爆瘓爖繐牒瘷爂渞刾嘿刱帿刦嘿刽껀늒뛳닊뻎닛뛄닓껚튻횹튼\udefe튥횿튾\uee82\uf2d2\uf698\uf29dﺊ\uf2d2\uf694\uf297\ueece튡횳튼\udeaa틼");
	}

	public virtual void ReportExpirationWarning(Guid slid, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary)
	{
		int num = 10;
		int num2 = 3;
		int num3 = num2;
		while (true)
		{
			num2 = 19386;
			int num4 = num2;
			num2 = 19386;
			switch (num4 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				switch (num3)
				{
				case 0:
					if (Guid.Empty == slid)
					{
						num2 = 1;
						num3 = num2;
						continue;
					}
					MessageQueue.Queue(new Class9(slid, session.smethod_1(Configuration.DefaultSession), keys, smethod_0(binary)));
					return;
				default:
					if (!AppStarted)
					{
						num2 = 2;
						num3 = num2;
					}
					else
					{
						num2 = 0;
						num3 = num2;
					}
					continue;
				case 1:
					Logger.LogError("횁틆껗닚뛔닒뻛닐뛗늎긛划噲刷帡剶嘷刃渂爂瘋牞縵爣瘻爪湼剶嘓刮帢刺嘻勍껓닂뛛닑뻜늖뛷닖꺢튿횠튿\udea6튿횽튀\ueed2\uf2a1\uf693\uf28cﺜ\uf29f\uf69c\uf289\ueef2튡횻튲\udebe틶횼틁껆늖뛐닛뺒닅뛗닀긦剸");
					return;
				case 2:
					break;
				}
				if (true)
				{
				}
				break;
			case false:
			case true:
				break;
			}
			break;
		}
		Logger.LogError("횓틾껻늖뛚닟뻁늖뛜닁긦剶嘰刻帷券噲初渆爗瘀爊縗爒癜牎渓刦嘢刲帻刵嘳勚껛닙뛜늞뻷닎뛂닇꺠튷횦튷\udebd트훲특\uee93\uf284\uf69c\uf297ﺜ\uf291\uf6d2\uf299\ueebb튺횾틾\udebc특횦튎껐닓뚒닍뻗님뛆늀");
	}

	public void SystemProfile([Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary)
	{
		int num = 18;
		if (!AppStarted)
		{
			int num2 = 27028;
			int num3 = num2;
			num2 = 27028;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				Logger.LogError("뛳닮뻻늖뛚닏긡剶嘼刱带剶嘰刋渗爘癒爍縆爗瘀爚渷刲噼剾币刯嘡勚껗닛뚒닎뻀닙뛔닇꺾튳훲튩\udebb튺횾틎\uee9c\uf299\uf686\uf2deﺐ\uf293\uf6d2\uf29d\ueeb7트횦티");
				return;
			case false:
			case true:
				break;
			}
		}
		Platform.ExecuteAsync(delegate
		{
			int num4 = -19985;
			int num5 = num4;
			num4 = -19985;
			switch (num5 == num4)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				MessageQueue.Queue(new SystemProfile(Platform.GetSystemInfo(Configuration.FullData), Configuration.OmitPersonalInfo, session.smethod_1(Configuration.DefaultSession), keys, smethod_0(binary)));
				break;
			}
		}, highPriority: false);
	}

	public void PerformanceProbe(string name, [Optional] ExtendedKeys keys, [Optional] Guid? session, [Optional] BinaryInfo binary)
	{
		int num = 14;
		while (true)
		{
			int num2 = 3;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 3:
					if (!AppStarted)
					{
						num2 = 2;
						num3 = num2;
					}
					else
					{
						num2 = 0;
						num3 = num2;
					}
					continue;
				case 0:
					if (string.IsNullOrEmpty(name))
					{
						num2 = 1;
						num3 = num2;
						continue;
					}
					Platform.ExecuteAsync(delegate
					{
						int num5 = 12689;
						int num6 = num5;
						num5 = 12689;
						switch (num6 == num5)
						{
						default:
							if (1 == 0)
							{
							}
							if (0 == 0)
							{
							}
							MessageQueue.Queue(new PerformanceProbe(name, Platform.GetPerformanceInfo(Configuration.FullData), keys, session.smethod_1(Configuration.DefaultSession), smethod_0(binary)));
							break;
						}
					}, highPriority: false);
					return;
				case 1:
				{
					num2 = 18405;
					int num4 = num2;
					num2 = 18405;
					switch (num4 == num2)
					{
					default:
						if (0 == 0)
						{
						}
						if (1 == 0)
						{
						}
						Logger.LogError("껢닓뛀님뻝닄뛟닏긼刵嘷剾帢判嘽刌渗牖瘜爟縟爓癒爇渡剶嘼别帾刺噲勁껀늖뛗닓뻂닂뛋늀껲튆횷튬\udeb4특횠튃\uee93\uf298\uf691\uf29bﻒ\uf286\uf680\uf281\ueeb0튳훲튩\udebb튺횾튎껜닙뛆늞뻐닓뚒닝긷券嘦剰");
						return;
					case false:
					case true:
						break;
					}
					goto case 2;
				}
				case 2:
					Logger.LogError("껳닦뛻늞뻚닗뛁늎긼刹嘦剾帰刳嘷刀湒爅瘆爟縀爂瘗爊湼剶嘂刻帠到嘽勜껟닗뛜닝뻗늖뛂닜꺽튴횷틾\udea5튿횾튂\ueed2\uf298\uf69d\uf28aﻒ\uf294\uf697\uf2ce\ueea1튳횼튪\udefc");
					return;
				}
				break;
			}
		}
	}

	private static BinaryInfoTag smethod_0(BinaryInfo binaryInfo_1)
	{
		if (binaryInfo_1 != null)
		{
			int num = 6843;
			int num2 = num;
			num = 6843;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				return binaryInfo_1.ToTag();
			case false:
			case true:
				break;
			}
		}
		if (1 == 0)
		{
		}
		return null;
	}

	public void SendMessages()
	{
		int num = 15;
		int num2 = 6;
		int num3 = num2;
		while (true)
		{
			switch (num3)
			{
			default:
				if (!AppStarted)
				{
					num2 = 2;
					num3 = num2;
				}
				else
				{
					num2 = 1;
					num3 = num2;
				}
				break;
			case 4:
				if (1 == 0)
				{
				}
				if (FlowController.SendDisabled)
				{
					num2 = -19737;
					int num4 = num2;
					num2 = -19737;
					switch (num4 == num2)
					{
					default:
						if (0 == 0)
						{
						}
						num2 = 5;
						num3 = num2;
						goto end_IL_00fb;
					case false:
					case true:
						break;
					}
					goto IL_00b6;
				}
				MessageQueue.SendMessages();
				num2 = 0;
				num3 = num2;
				break;
			case 3:
				num2 = 4;
				num3 = num2;
				break;
			case 1:
				if (MessageQueue != null)
				{
					goto IL_00b6;
				}
				return;
			case 0:
				return;
			case 2:
				Logger.LogWarning("닳뛦닻뺞닚뛗닁꺎刼嘹刦幾到嘳刷渀牒瘅爆縟爀瘂爗渊剼噶刁帻刼嘲刟껋닁뛅닓뻙닗뛅늒껙튻횺튾\udefe튶횹틲\uee80\uf29d\uf682\uf29aﺗ\uf29c\uf691\uf2d3");
				return;
			case 5:
				{
					Logger.LogError("닡뛓닜뻚닛뛘닕꺎刻嘥割帺刻嘥刳渌爞瘓爖繞爐瘏牒済刾嘹別幾刱嘹刼껚닀뛙닞뻒닗뛄늜꺎튁횳튼\udeba튟횳튡\uee9d\uf293\uf691\uf297ﺍ\uf2d2\uf681\uf29b\uee82튾훶튶\udeb1틲횸튽껚닚뛟닜뻙늓");
					return;
				}
				IL_00b6:
				num2 = 3;
				num3 = num2;
				break;
				end_IL_00fb:
				break;
			}
		}
	}

	public void SetSendDisabled(bool value)
	{
		int num = 8;
		int num2 = 6;
		int num3 = num2;
		while (true)
		{
			switch (num3)
			{
			default:
				if (!AppStarted)
				{
					num2 = 2;
					num3 = num2;
				}
				else
				{
					num2 = 0;
					num3 = num2;
				}
				break;
			case 5:
				MessageQueue.SendDisabledChanged(value);
				goto IL_0055;
			case 4:
			{
				if (MessageQueue == null)
				{
					return;
				}
				num2 = 5026;
				int num4 = num2;
				num2 = 5026;
				switch (num4 == num2)
				{
				case false:
				case true:
					break;
				default:
					if (1 == 0)
					{
					}
					if (0 == 0)
					{
					}
					num2 = 5;
					num3 = num2;
					goto end_IL_010b;
				}
				goto IL_0055;
			}
			case 1:
				FlowController.SendDisabled = value;
				num2 = 4;
				num3 = num2;
				break;
			case 0:
				if (value != FlowController.SendDisabled)
				{
					num2 = 1;
					num3 = num2;
					break;
				}
				return;
			case 2:
				Logger.LogWarning("튗횂틧꺒닞뛓닍뺒님뛝닚깲刴嘷刻帼剶嘡刚渓爄瘆爛縖牘癒爽渷刢嘁刻帼刲嘖勇껁닗뛐닒뻗닒뚒닙꺻튺횾틾\udeb6특훲튀\uee9d\uf282\uf69a\uf297ﺜ\uf291\uf6d3");
				return;
			case 3:
				return;
				IL_0055:
				num2 = 3;
				num3 = num2;
				break;
				end_IL_010b:
				break;
			}
		}
	}

	public void SetSessionOptIn(bool value, [Optional] Configuration config)
	{
		int num = 14;
		int num2 = 7;
		int num3 = num2;
		while (true)
		{
			switch (num3)
			{
			case 10:
				config.OptIn = value;
				num2 = 0;
				num3 = num2;
				break;
			case 8:
			{
				Logger.LogInfo("껡닓뛁닍뻛닙뛜닡긢刢嘛到干刾嘳初湒爔瘗爛縜牖瘁爋渦剶嘦刱干刢嘠勛껗늖뛓닐뻖늖뛆닆꺷틶횓튎\ude9b틶횥튏\uee81\uf2d6\uf69c\uf291ﺆ\uf2d6\uf682\uf29c\ueeb7튠횻튱\udea7튥횾틗꺒닅뛆닟뻀닂뛗닊깼剶嘑刿帾刺嘻刀渕牖瘳爎縂爚瘛爍渳刢嘻刱帼刅嘦勏껀닂뚜느뺜");
				ApplicationStart(config, null, null, FlowController);
				num2 = -13022;
				int num4 = num2;
				num2 = -13022;
				switch (num4 == num2)
				{
				default:
					if (0 == 0)
					{
					}
					if (1 == 0)
					{
					}
					num2 = 9;
					num3 = num2;
					break;
				case false:
				case true:
					break;
				}
				break;
			}
			default:
				if (config != null)
				{
					num2 = 10;
					num3 = num2;
					break;
				}
				goto case 0;
			case 0:
				num2 = 3;
				num3 = num2;
				break;
			case 6:
				Configuration.OptIn = value;
				Logger.LogInfo(string.Format("껦닞뛗늞뻁닓뛁닝긻刹嘼剾帝刦嘦刧渜牖瘚爟縁牖瘐爋渷券噲刭帷刢噲勚껝늖뛉늎뻏", new object[1] { value }));
				num2 = 1;
				num3 = num2;
				break;
			case 5:
				if (value)
				{
					num2 = 8;
					num3 = num2;
					break;
				}
				return;
			case 4:
				if (!AppStarted)
				{
					num2 = 2;
					num3 = num2;
					break;
				}
				return;
			case 3:
				if (Configuration != null)
				{
					num2 = 6;
					num3 = num2;
					break;
				}
				goto case 1;
			case 1:
				num2 = 4;
				num3 = num2;
				break;
			case 2:
				num2 = 5;
				num3 = num2;
				break;
			case 9:
				return;
			}
		}
	}
}
