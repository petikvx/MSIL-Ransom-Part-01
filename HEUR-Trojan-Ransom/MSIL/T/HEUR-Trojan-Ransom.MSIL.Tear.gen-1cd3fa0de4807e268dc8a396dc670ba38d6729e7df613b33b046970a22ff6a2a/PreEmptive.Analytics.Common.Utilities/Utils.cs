using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using PreEmptive.Analytics.Common.Tags;

namespace PreEmptive.Analytics.Common.Utilities;

public static class Utils
{
	[CompilerGenerated]
	private sealed class Class31
	{
		public string string_0;

		public bool method_0(Tag tag_0)
		{
			int num = -27994;
			int num2 = num;
			num = -27994;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return tag_0.TagName == string_0;
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class32
	{
		public ManualResetEvent manualResetEvent_0;

		public Action action_0;

		public void method_0(object object_0)
		{
			int num = -20131;
			int num2 = num;
			num = -20131;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			action_0();
			manualResetEvent_0.Set();
		}
	}

	[CompilerGenerated]
	private sealed class Class33
	{
		public Action action_0;

		public object method_0()
		{
			int num = 18720;
			int num2 = num;
			num = 18720;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				action_0();
				return null;
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class34<T>
	{
		public Action action_0;

		public Func<T> func_0;

		public Action<T> action_1;

		public void method_0()
		{
			try
			{
				while (true)
				{
					IL_0098:
					T obj = func_0();
					int num = 3;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 3:
							if (action_1 != null)
							{
								num = 0;
								num2 = num;
								continue;
							}
							goto case 1;
						case 1:
							num = 2;
							num2 = num;
							continue;
						case 0:
						{
							action_1(obj);
							num = 1533;
							int num3 = num;
							num = 1533;
							switch (num3 == num)
							{
							default:
								if (0 == 0)
								{
								}
								num = 1;
								num2 = num;
								continue;
							case false:
							case true:
								break;
							}
							break;
						}
						case 2:
							goto end_IL_0082;
						}
						goto IL_0098;
						continue;
						end_IL_0082:
						break;
					}
					break;
				}
			}
			catch (Exception)
			{
			}
			if (true)
			{
			}
		}

		public void method_1(object object_0)
		{
			int num = -18072;
			int num2 = num;
			num = -18072;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			action_0();
		}
	}

	public static string ToISOFormat(this DateTime dateTime)
	{
		int num = 6;
		int num2 = 15718;
		int num3 = num2;
		num2 = 15718;
		switch (num3 == num2)
		{
		default:
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			return dateTime.ToString("\udeab튯횫틗꺟닻뛿늓뻖닒뛦닦긚刊器刳帿刊器初渁爪癜爘縔爐瘹");
		}
	}

	public static string Sanitize(this string string_0)
	{
		while (!string.IsNullOrEmpty(string_0))
		{
			int num = -23479;
			int num2 = num;
			num = -23479;
			switch (num2 == num)
			{
			case false:
			case true:
				continue;
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			string_0 = string_0.Trim();
			return string_0;
		}
		return string_0;
	}

	internal static string smethod_0<T>(this T? nullable_0) where T : struct
	{
		while (!nullable_0.HasValue)
		{
			int num = 26816;
			int num2 = num;
			num = 26816;
			switch (num2 == num)
			{
			case false:
			case true:
				continue;
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			return null;
		}
		return nullable_0.Value.ToString();
	}

	internal static Guid smethod_1(this Guid? nullable_0, Guid guid_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!(nullable_0.Value == Guid.Empty))
				{
					return nullable_0.Value;
				}
				goto IL_002a;
			case 2:
			{
				num = 31976;
				int num3 = num;
				num = 31976;
				switch (num3 == num)
				{
				case false:
				case true:
					break;
				default:
					if (0 == 0)
					{
					}
					num = 3;
					num2 = num;
					goto end_IL_00ac;
				}
				goto IL_002a;
			}
			case 1:
				if (true)
				{
				}
				goto default;
			default:
				if (nullable_0.HasValue)
				{
					num = 2;
					num2 = num;
					break;
				}
				goto case 0;
			case 0:
				{
					return guid_0;
				}
				IL_002a:
				num = 0;
				num2 = num;
				break;
				end_IL_00ac:
				break;
			}
		}
	}

	public static IList<Tag> ByName(this IList<Tag> tags, string name)
	{
		int num = 32246;
		int num2 = num;
		num = 32246;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return tags.Where(delegate(Tag tag_0)
			{
				int num3 = -27994;
				int num4 = num3;
				num3 = -27994;
				switch (num4 == num3)
				{
				default:
					if (0 == 0)
					{
					}
					if (1 == 0)
					{
					}
					return tag_0.TagName == name;
				}
			}).ToList();
		}
	}

	public static string GetInstanceId(this IPlatform platform, Configuration config, ILogger logger)
	{
		int num = 12;
		int num2 = 1;
		int num3 = num2;
		string result = default(string);
		while (true)
		{
			switch (num3)
			{
			case 1:
				if (true)
				{
				}
				goto default;
			default:
				if (config.InstanceID != null)
				{
					num2 = 0;
					num3 = num2;
				}
				else
				{
					result = "";
					num2 = 2;
					num3 = num2;
				}
				break;
			case 0:
			{
				num2 = 3730;
				int num4 = num2;
				num2 = 3730;
				switch (num4 == num2)
				{
				case false:
				case true:
					break;
				default:
					if (0 == 0)
					{
					}
					return config.InstanceID;
				}
				goto case 1;
			}
			case 2:
				try
				{
					result = smethod_2(platform, logger, "틧껜닅뛆닟뻜닕뛗닧긖");
					return result;
				}
				catch
				{
					logger.LogWarning("틧껜닅뛆닟뻜닕뛗닧긖剶嘱刱帧刺嘶剎渜爙瘆牞縐爓癒爝渳删嘷刺干刹嘠劎껀닓뛆닌뻛닓뛄닋꺶틶횴튬\udebd튻훲튞\uee97\uf284\uf681\uf297ﺁ\uf282\uf697\uf280\ueea6틶횡튪\udebd튤횳틉껗늘뚒닫뻁닟뛜닉깲刷嘼剾帳刣嘦刁渕爓瘜爛縀爗瘆爋渶剶嘛到帡刢嘳勀껑닓뛻닺뺒닟뛜닝꺦튳횳튺\udefc");
					return result;
				}
			}
		}
	}

	public static string GetGeneratedUserName(this IPlatform platform, Configuration config, ILogger logger)
	{
		int num = 5;
		int num2 = 2;
		int num3 = num2;
		while (true)
		{
			switch (num3)
			{
			default:
			{
				if (config.GeneratedUserName != null)
				{
					num2 = 0;
					num3 = num2;
					break;
				}
				string text3 = "";
				goto IL_0035;
			}
			case 0:
			{
				num2 = -23287;
				int num4 = num2;
				num2 = -23287;
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
					return config.GeneratedUserName;
				}
				goto IL_0035;
			}
			case 1:
				{
					try
					{
						return config.GeneratedUserName = smethod_2(platform, logger, "\ude99튷횸튷껜닓뛂닗뻚닧뛅닗껜刜嘷刿帻");
					}
					catch
					{
						logger.LogWarning("\ude99튷횸튷껜닓뛂닗뻚닻뛘닁껚刳嘸刱帻创嘒割渍爝瘃爞縚牒瘘爝渚割嘴刷幾刡嘷判껋닖뚖닝뻌늒뛄닗껚튠횿튷\udea8튷횲틲\uee88\uf280\uf699\uf29fﻞ\uf282\uf693\uf280\uee9d튻횥튦\udebb튼횢틲껝닆뛙닀뻟닕뛓늜");
						return config.GeneratedUserName = Guid.NewGuid().ToString();
					}
				}
				IL_0035:
				num2 = 1;
				num3 = num2;
				break;
			}
		}
	}

	private static string smethod_2(IPlatform iplatform_0, ILogger ilogger_0, string string_0)
	{
		int num = 17;
		ISettingsStore settingsStore;
		string text;
		int num2;
		try
		{
			while (true)
			{
				switch (0)
				{
				}
				num2 = -923;
				int num3 = num2;
				num2 = -923;
				switch (num3 == num2)
				{
				case false:
				case true:
					continue;
				}
				if (0 == 0)
				{
				}
				settingsStore = iplatform_0.GetSettingsStore();
				text = settingsStore[string_0];
				break;
			}
		}
		catch (Exception exception_)
		{
			ilogger_0.LogExceptionWarning(exception_, "뛷닜뺞닇뛘닗껖刢嘳刱帪刷嘲割渀爝瘘牟縝爀瘟爆渇刱嘷刾幾刷嘮刱껋닂뛂닛뻑닜뚖닝껍튱횣튠\udebb튶");
			throw;
		}
		num2 = 0;
		int num4 = num2;
		while (true)
		{
			switch (num4)
			{
			case 1:
				if (true)
				{
				}
				goto default;
			default:
				text = Guid.NewGuid().ToString();
				num2 = 2;
				num4 = num2;
				break;
			case 0:
				if (text == null)
				{
					num2 = 1;
					num4 = num2;
					break;
				}
				return text;
			case 2:
				try
				{
					num2 = 3;
					num4 = num2;
					while (true)
					{
						switch (num4)
						{
						default:
							if (settingsStore != null)
							{
								num2 = 0;
								num4 = num2;
								break;
							}
							goto case 1;
						case 1:
							num2 = 2;
							num4 = num2;
							break;
						case 0:
							settingsStore[string_0] = text;
							settingsStore.Flush();
							num2 = 1;
							num4 = num2;
							break;
						case 2:
							return text;
						}
					}
				}
				catch (Exception exception_2)
				{
					ilogger_0.LogExceptionWarning(exception_2, "뛷닜뺞닇뛘닗껖刢嘳刱帪刷嘲割渀爝瘘牟縝爀瘟爆渇刱嘷刾幾刷嘮刱껋닂뛂닛뻑닜뚖닝껍튱횣튠\udebb튶");
					throw;
				}
			}
		}
	}

	internal static void smethod_3(this List<KeyValuePair<string, string>> list_0, string string_0, string string_1)
	{
		if (1 == 0)
		{
		}
		int num = -18226;
		int num2 = num;
		num = -18226;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		list_0.Add(new KeyValuePair<string, string>(string_0, string_1));
	}

	internal static bool smethod_4(this LoggingLevel loggingLevel_0, LoggingLevel loggingLevel_1)
	{
		int num = 26810;
		int num2 = num;
		num = 26810;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return (loggingLevel_0 & loggingLevel_1) == loggingLevel_1;
		}
	}

	public static bool WithTimeout(Action task, int duration)
	{
		int num = -19219;
		int num2 = num;
		num = -19219;
		switch (num2 == num)
		{
		default:
		{
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			ManualResetEvent manualResetEvent_0 = new ManualResetEvent(initialState: false);
			ThreadPool.QueueUserWorkItem(delegate
			{
				int num3 = -20131;
				int num4 = num3;
				num3 = -20131;
				switch (num4 == num3)
				{
				default:
					if (1 == 0)
					{
					}
					if (0 == 0)
					{
					}
					task();
					manualResetEvent_0.Set();
					break;
				}
			});
			return manualResetEvent_0.WaitOne(duration);
		}
		}
	}

	public static void ExecuteAsync(this IAsyncProvider platform, Action action, [Optional] bool highPriority)
	{
		int num = -17197;
		int num2 = num;
		num = -17197;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		platform.ExecuteAsync((Func<object>)delegate
		{
			int num3 = 18720;
			int num4 = num3;
			num3 = 18720;
			switch (num4 == num3)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				action();
				return null;
			}
		}, (Action<object>)null, highPriority);
	}

	public static void ExecuteAsync<T>(this IAsyncProvider platform, Func<T> action, [Optional] Action<T> completed, [Optional] bool highPriority)
	{
		if (1 == 0)
		{
		}
		WaitCallback waitCallback = null;
		Action action_0 = delegate
		{
			try
			{
				while (true)
				{
					IL_0098:
					T obj2 = action();
					int num5 = 3;
					int num6 = num5;
					while (true)
					{
						switch (num6)
						{
						case 3:
							if (completed != null)
							{
								num5 = 0;
								num6 = num5;
								continue;
							}
							goto case 1;
						case 1:
							num5 = 2;
							num6 = num5;
							continue;
						case 0:
						{
							completed(obj2);
							num5 = 1533;
							int num7 = num5;
							num5 = 1533;
							switch (num7 == num5)
							{
							default:
								if (0 == 0)
								{
								}
								num5 = 1;
								num6 = num5;
								continue;
							case false:
							case true:
								break;
							}
							break;
						}
						case 2:
							goto end_IL_0082;
						}
						goto IL_0098;
						continue;
						end_IL_0082:
						break;
					}
					break;
				}
			}
			catch (Exception)
			{
			}
			if (true)
			{
			}
		};
		try
		{
			platform.ExecuteAsyncIfSupported(action_0, highPriority);
		}
		catch
		{
			if (waitCallback == null)
			{
				int num = 18738;
				int num2 = num;
				num = 18738;
				switch (num2 == num)
				{
				default:
					if (0 == 0)
					{
					}
					waitCallback = delegate
					{
						int num3 = -18072;
						int num4 = num3;
						num3 = -18072;
						switch (num4 == num3)
						{
						default:
							if (1 == 0)
							{
							}
							if (0 == 0)
							{
							}
							action_0();
							break;
						}
					};
					break;
				case false:
				case true:
					break;
				}
			}
			ThreadPool.QueueUserWorkItem(waitCallback);
		}
	}

	public static void ExecuteSync<T>(Func<T> action, [Optional] Action<T> completed)
	{
		try
		{
			while (true)
			{
				IL_008e:
				T obj = action();
				int num = 3;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						if (completed != null)
						{
							num = 0;
							num2 = num;
							continue;
						}
						goto case 1;
					case 1:
						num = 2;
						num2 = num;
						continue;
					case 0:
					{
						completed(obj);
						num = 14596;
						int num3 = num;
						num = 14596;
						switch (num3 == num)
						{
						default:
							if (0 == 0)
							{
							}
							num = 1;
							num2 = num;
							continue;
						case false:
						case true:
							break;
						}
						break;
					}
					case 2:
						goto end_IL_0078;
					}
					goto IL_008e;
					continue;
					end_IL_0078:
					break;
				}
				break;
			}
		}
		catch (Exception)
		{
		}
		if (true)
		{
		}
	}

	public static MessageBatch[] Split(this MessageBatch batch)
	{
		if (batch.Messages.Count == 1)
		{
			int num = -24650;
			int num2 = num;
			num = -24650;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (false)
				{
				}
				break;
			case false:
			case true:
				break;
			}
			return new MessageBatch[1] { batch };
		}
		MessageBatch[] array = new MessageBatch[2];
		int count = batch.Messages.Count / 2;
		List<Message> messages = batch.Messages.Take(count).ToList();
		List<Message> messages2 = batch.Messages.Skip(count).ToList();
		array[0] = new MessageBatch(batch.AgentInfo, batch.Configuration, messages);
		array[1] = new MessageBatch(batch.AgentInfo, batch.Configuration, messages2);
		return array;
	}

	public static void LogException(this ILogger logger, Exception exception_0, [Optional] string prefix)
	{
		int num = 17;
		int num2 = -5228;
		int num3 = num2;
		num2 = -5228;
		switch (num3 == num2)
		{
		}
		if (0 == 0)
		{
		}
		if (1 == 0)
		{
		}
		logger.LogError(string.Format(prefix + "뚘늒뻻닊뛕닗껞刦嘿刽帰割嘂别渞爗癖爉繎爏癖爓渚割嘭剣帣割嘡刻껚닚뚖닟뻛닁뛅닓껉튷훶튩\udeec튯", new object[3]
		{
			((object)exception_0).GetType().ToString(),
			exception_0.StackTrace ?? "",
			exception_0.Message ?? ""
		}));
	}

	public static void LogExceptionWarning(this ILogger logger, Exception exception_0, [Optional] string prefix)
	{
		int num = 18;
		if (1 == 0)
		{
		}
		int num2 = 2365;
		int num3 = num2;
		num2 = 2365;
		switch (num3 == num2)
		{
		}
		if (0 == 0)
		{
		}
		logger.LogWarning(string.Format(prefix + "뚜늞뻷닎뛑닋긢刢嘻刱帼剶嘆列渂爓癒爅繂爋癒爏渦剶嘩副帯剶嘥勇껆닞뚒닓뻗닅뛁닏꺵튳훲튥\udee0튫", new object[3]
		{
			((object)exception_0).GetType().ToString(),
			exception_0.StackTrace ?? "",
			exception_0.Message ?? ""
		}));
	}

	public static void Attempt(Action action, [Optional] ILogger logger)
	{
		int num = 17;
		try
		{
			action();
		}
		catch (Exception exception_)
		{
			if (logger == null)
			{
				return;
			}
			if (1 == 0)
			{
			}
			int num2 = 27344;
			int num3 = num2;
			num2 = 27344;
			switch (num3 == num2)
			{
			case false:
			case true:
				return;
			}
			if (0 == 0)
			{
			}
			logger.LogExceptionWarning(exception_, "뛷닜뺞닇뛘닗껖刢嘳刱帪刷嘲割渀爝瘘牟縝爀瘟爆渇刱嘷刾幾刷嘮刱껋닂뛂닛뻑닜뚖닝껍튱횣튠\udebb튶");
		}
	}

	public static T Attempt<T>(Func<T> action, [Optional] ILogger logger)
	{
		int num = 8;
		try
		{
			return action();
		}
		catch (Exception exception_)
		{
			if (logger != null)
			{
				int num2 = 16572;
				int num3 = num2;
				num2 = 16572;
				switch (num3 == num2)
				{
				default:
					if (1 == 0)
					{
					}
					if (0 == 0)
					{
					}
					logger.LogExceptionWarning(exception_, "튗횼튎껇님뛗닆뻂닓뛑닚긷刲噲到帽券噿刍渀爟瘆爗縑爗瘞牎渷刮嘱刻帢刢嘻勁껜늖뛝닝뻑닃뛀닋꺶");
					break;
				case false:
				case true:
					break;
				}
			}
		}
		return default(T);
	}

	public static void MergeStopDefaults(this IPlatform platform, Configuration config)
	{
		while (true)
		{
			Configuration.ApplicationStopBehavior stopBehaviorDefaults = platform.GetStopBehaviorDefaults();
			if (true)
			{
			}
			int num = 11;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					if (!config.StopBehavior.DefaultsToSynchronousStop.HasValue)
					{
						num = 10;
						num2 = num;
						continue;
					}
					goto case 0;
				case 0:
					num = 5;
					num2 = num;
					continue;
				case 10:
					config.StopBehavior.DefaultsToSynchronousStop = stopBehaviorDefaults.DefaultsToSynchronousStop;
					num = 0;
					num2 = num;
					continue;
				case 9:
					config.StopBehavior.SessionExtensionWindow = stopBehaviorDefaults.SessionExtensionWindow;
					num = 1;
					num2 = num;
					continue;
				case 8:
					if (!config.StopBehavior.StopTimeout.HasValue)
					{
						num = 2;
						num2 = num;
						continue;
					}
					return;
				case 6:
					if (!config.StopBehavior.SessionExtensionWindow.HasValue)
					{
						num = 9;
						num2 = num;
						continue;
					}
					goto case 1;
				case 1:
				{
					num = 15898;
					int num3 = num;
					num = 15898;
					switch (num3 == num)
					{
					default:
						if (0 == 0)
						{
						}
						num = 8;
						num2 = num;
						continue;
					case false:
					case true:
						break;
					}
					goto case 2;
				}
				case 2:
					config.StopBehavior.StopTimeout = stopBehaviorDefaults.StopTimeout;
					num = 7;
					num2 = num;
					continue;
				case 5:
					if (!config.StopBehavior.NeededTimeForSavingAtStop.HasValue)
					{
						num = 4;
						num2 = num;
						continue;
					}
					goto case 3;
				case 3:
					num = 6;
					num2 = num;
					continue;
				case 4:
					config.StopBehavior.NeededTimeForSavingAtStop = stopBehaviorDefaults.NeededTimeForSavingAtStop;
					num = 3;
					num2 = num;
					continue;
				case 7:
					return;
				}
				break;
			}
		}
	}
}
