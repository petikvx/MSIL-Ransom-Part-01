using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using PreEmptive.Analytics.Common;
using PreEmptive.Analytics.Common.Messages;

namespace PreEmptive.Analytics.NET.Common;

public abstract class CommonNetPlatform : IPlatform, IAsyncProvider
{
	[CompilerGenerated]
	private sealed class Class5
	{
		public Action action_0;

		public void method_0()
		{
			int num = 8528;
			int num2 = num;
			num = 8528;
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

	public readonly Configuration Config;

	protected readonly ILogger Logger;

	[CompilerGenerated]
	private static Func<IPAddress, bool> func_0;

	public CommonNetPlatform(Configuration config, [Optional] ILogger logger)
	{
		Config = config;
		if (logger == null)
		{
			logger = new BlankLogger();
		}
		Logger = logger;
	}

	public virtual IXMLTransmitter CreateXMLTransmitter()
	{
		int num = -9750;
		int num2 = num;
		num = -9750;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			return new XMLTransmitter(Config, Logger);
		}
	}

	public virtual AgentInfo GetAgentInfo()
	{
		int num = 11;
		while (true)
		{
			AgentInfo agentInfo = new AgentInfo();
			try
			{
				Version version = Assembly.GetExecutingAssembly().GetName().Version;
				agentInfo.Version = version.Major + "틼" + version.Minor;
			}
			catch
			{
				agentInfo.Version = "틢꺀늂";
			}
			int num2 = 1354;
			int num3 = num2;
			num2 = 1354;
			switch (num3 == num2)
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
			return agentInfo;
		}
	}

	public virtual HostInfo GetHostInfo()
	{
		int num = 11;
		switch (0)
		{
		}
		TargetFrameworkAttribute targetFrameworkAttribute = default(TargetFrameworkAttribute);
		string[] array = default(string[]);
		string text2 = default(string);
		string text = default(string);
		string[] array3 = default(string[]);
		while (true)
		{
			HostInfo result = default(HostInfo);
			int num2 = 23;
			int num3 = num2;
			while (true)
			{
				string[] array2;
				string[] array4;
				object obj;
				switch (num3)
				{
				case 23:
					try
					{
						result.IPAddress = Dns.GetHostAddresses(Environment.MachineName).FirstOrDefault(delegate(IPAddress ipaddress_0)
						{
							int num5 = 27362;
							int num6 = num5;
							num5 = 27362;
							switch (num6 == num5)
							{
							default:
								if (1 == 0)
								{
								}
								if (0 == 0)
								{
								}
								return ipaddress_0.AddressFamily == AddressFamily.InterNetwork;
							}
						})!.ToString();
					}
					catch
					{
						result.IPAddress = "틢꺀늂뚘늂뺐늂";
					}
					num2 = 6;
					num3 = num2;
					continue;
				case 22:
					if (targetFrameworkAttribute == null)
					{
						num2 = 8;
						num3 = num2;
					}
					else
					{
						num2 = 4;
						num3 = num2;
					}
					continue;
				case 21:
					num2 = 16;
					num3 = num2;
					continue;
				case 20:
					num2 = 15;
					num3 = num2;
					continue;
				case 19:
				{
					if (array.Length != 2)
					{
						goto case 20;
					}
					num2 = 13732;
					int num4 = num2;
					num2 = 13732;
					switch (num4 == num2)
					{
					default:
						if (0 == 0)
						{
						}
						num2 = 13;
						num3 = num2;
						continue;
					case false:
					case true:
						break;
					}
					goto case 17;
				}
				case 17:
					if (targetFrameworkAttribute == null)
					{
						num2 = 2;
						num3 = num2;
					}
					else
					{
						num2 = 5;
						num3 = num2;
					}
					continue;
				case 18:
					if (targetFrameworkAttribute == null)
					{
						num2 = 21;
						num3 = num2;
					}
					else
					{
						num2 = 10;
						num3 = num2;
					}
					continue;
				case 16:
					array2 = new string[0];
					goto IL_01ef;
				case 15:
					result.SourceLangName = ((!string.IsNullOrEmpty(text2)) ? text2 : "틼껠닷뛢늒뻽닞뛗닁껝刻嘵");
					num2 = 0;
					num3 = num2;
					continue;
				case 14:
					num2 = 18;
					num3 = num2;
					continue;
				case 13:
					text = array[1];
					num2 = 20;
					num3 = num2;
					continue;
				case 12:
					array4 = new string[0];
					goto IL_0273;
				case 11:
					if (string.IsNullOrEmpty(text2))
					{
						num2 = 14;
						num3 = num2;
						continue;
					}
					goto case 9;
				case 9:
					text = "틢꺀늂";
					num2 = 17;
					num3 = num2;
					continue;
				case 10:
					array2 = targetFrameworkAttribute.FrameworkName.Split(new char[1] { ',' });
					goto IL_01ef;
				case 8:
					num2 = 1;
					num3 = num2;
					continue;
				case 7:
					if (text2.Length > 0)
					{
						num2 = 3;
						num3 = num2;
						continue;
					}
					goto case 9;
				case 6:
					result.Name = smethod_0(string.IsNullOrEmpty(Environment.UserDomainName) ? Environment.MachineName : string.Format("튩꺞닏뚘닉뺏닏", Environment.UserDomainName, Environment.MachineName));
					result.Locale = CultureInfo.CurrentCulture.Name;
					targetFrameworkAttribute = Attribute.GetCustomAttribute(GetType().Assembly, typeof(TargetFrameworkAttribute)) as TargetFrameworkAttribute;
					num2 = 22;
					num3 = num2;
					continue;
				case 5:
					array4 = targetFrameworkAttribute.FrameworkName.Split(new string[1] { "튄껋닀뛅닛뻑닜뚋닄" }, StringSplitOptions.None);
					goto IL_0273;
				case 4:
					obj = targetFrameworkAttribute.FrameworkDisplayName;
					goto IL_03b9;
				case 3:
					text2 = array3[0];
					num2 = 9;
					num3 = num2;
					continue;
				case 2:
					num2 = 12;
					num3 = num2;
					continue;
				case 1:
					obj = "";
					goto IL_03b9;
				case 0:
					{
						result.SourceLangVersion = ((!string.IsNullOrEmpty(text)) ? text : "틢꺀늂");
						result.Virtualized = false;
						return result;
					}
					IL_03b9:
					text2 = (string)obj;
					num2 = 11;
					num3 = num2;
					continue;
					IL_01ef:
					array3 = array2;
					if (1 == 0)
					{
					}
					num2 = 7;
					num3 = num2;
					continue;
					IL_0273:
					array = array4;
					num2 = 19;
					num3 = num2;
					continue;
				}
				break;
			}
		}
	}

	public virtual OSInfo GetOSInfo()
	{
		int num = -22958;
		int num2 = num;
		num = -22958;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return default(OSInfo);
		}
	}

	public virtual UserInfo GetUserInfo()
	{
		int num = 3692;
		int num2 = num;
		num = 3692;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return default(UserInfo);
		}
	}

	public virtual string GetDefaultEndpoint()
	{
		int num = 1;
		int num2 = -121;
		int num3 = num2;
		num2 = -121;
		switch (num3 == num2)
		{
		default:
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			return "횥튽\udef3튡훸튻껀닔뛙늝뻮닀뛓닷껃刢嘢刻帨刷噸刅渋爐癘爡縛爀瘀爛渍刷嘥剼帓刷嘥刡껏닕뛟닜뻙늝뛻닗껝튡횷튵\udeb7튼횱튁\uee8b\uf280\uf680\uf29bﺝ\uf297\uf6a0\uf2c1\ueec0튡횠튱\udef1튂횣튰껂닛뛅닚";
		}
	}

	public virtual IList<StackInfo> GetStackInfo(Exception exception)
	{
		int num = 17;
		switch (0)
		{
		}
		Type declaringType = default(Type);
		int num4 = default(int);
		StackFrame[] array2 = default(StackFrame[]);
		StackFrame stackFrame = default(StackFrame);
		MethodBase method = default(MethodBase);
		int count = default(int);
		bool? flag = default(bool?);
		StackTrace stackTrace = default(StackTrace);
		while (true)
		{
			List<StackInfo> list = new List<StackInfo>();
			int num2 = 4;
			int num3 = num2;
			while (true)
			{
				StackTrace stackTrace2;
				StackFrame[] array;
				switch (num3)
				{
				case 30:
					num2 = 13;
					num3 = num2;
					continue;
				case 29:
					stackTrace2 = new StackTrace(exception, fNeedFileInfo: true);
					goto IL_0041;
				case 28:
					if (declaringType != null)
					{
						num2 = 27;
						num3 = num2;
						continue;
					}
					goto case 5;
				case 5:
					num2 = 17;
					num3 = num2;
					continue;
				case 27:
					num2 = 10;
					num3 = num2;
					continue;
				case 26:
					num2 = 16;
					num3 = num2;
					continue;
				case 15:
				case 25:
					num2 = 22;
					num3 = num2;
					continue;
				case 24:
					num2 = 19;
					num3 = num2;
					continue;
				case 23:
					num2 = 8;
					num3 = num2;
					continue;
				case 22:
					if (num4 >= array2.Length)
					{
						num2 = 7;
						num3 = num2;
						continue;
					}
					stackFrame = array2[num4];
					method = stackFrame.GetMethod();
					count = list.Count;
					declaringType = method.DeclaringType;
					flag = exception.Data["뛿닜뻝닞뛃닖껋刂嘤刷帛刿嘦刦渇爄瘓爳縐爓瘚爋渚刻嘵刡帘删嘷刿껋닁"] as bool?;
					num2 = 3;
					num3 = num2;
					continue;
				case 21:
					num2 = 6;
					num3 = num2;
					continue;
				case 20:
					num4++;
					num2 = 25;
					num3 = num2;
					continue;
				case 19:
				{
					num2 = -9294;
					int num5 = num2;
					num2 = -9294;
					switch (num5 == num2)
					{
					case false:
					case true:
						goto IL_01f6;
					}
					if (0 == 0)
					{
					}
					if (method.smethod_0() == "뛥닋뻍닆뛓닟꺀刄嘹刻帺剺嘟刼渚爢瘂爀繞牞癖爻渀刦嘆刦帬割噺割껧닜뛂닢뻊닀뚖늛")
					{
						num2 = 2;
						num3 = num2;
						continue;
					}
					goto case 26;
				}
				case 18:
				{
					if (Guid.TryParse(method.Name, out var _))
					{
						goto case 20;
					}
					goto IL_01f6;
				}
				case 17:
					if (declaringType != null)
					{
						num2 = 9;
						num3 = num2;
						continue;
					}
					goto case 26;
				case 16:
					list.Add(new StackInfo(count, (declaringType != null) ? declaringType.FullName : "뛣닜뻕닜뛙닅껀", method.Name, method.smethod_0(), stackFrame.GetFileName(), stackFrame.GetFileLineNumber().ToString()));
					num2 = 20;
					num3 = num2;
					continue;
				case 14:
					array = new StackFrame[0];
					goto IL_02a2;
				case 13:
					stackTrace2 = new StackTrace(fNeedFileInfo: true);
					goto IL_0041;
				case 12:
					num2 = 11;
					num3 = num2;
					continue;
				case 11:
					if (flag.HasValue)
					{
						goto case 5;
					}
					goto case 21;
				case 10:
					if (!declaringType.FullName!.StartsWith("뛦닀뻛닷뛛닂껚刻嘠刷幰刓嘸刳渂爋瘂爛縝爁"))
					{
						num2 = 23;
						num3 = num2;
						continue;
					}
					goto case 20;
				case 9:
					num2 = 1;
					num3 = num2;
					continue;
				case 8:
					if (!declaringType.FullName!.StartsWith("뛦닀뻛닷뛛닂껚刻嘠刷幰刁嘹刁"))
					{
						num2 = 5;
						num3 = num2;
						continue;
					}
					goto case 20;
				case 6:
					num2 = 28;
					num3 = num2;
					continue;
				case 4:
					if (string.IsNullOrEmpty(exception.StackTrace))
					{
						num2 = 30;
						num3 = num2;
					}
					else
					{
						num2 = 29;
						num3 = num2;
					}
					continue;
				case 3:
					if (flag.GetValueOrDefault())
					{
						num2 = 12;
						num3 = num2;
					}
					else
					{
						num2 = 21;
						num3 = num2;
					}
					continue;
				case 2:
					num2 = 18;
					num3 = num2;
					continue;
				case 1:
					if (declaringType.FullName == "뛥닋뻍닆뛓닟꺀初嘴券帻刱嘢")
					{
						if (1 == 0)
						{
						}
						num2 = 24;
						num3 = num2;
						continue;
					}
					goto case 26;
				case 0:
					array = stackTrace.GetFrames();
					if (array == null)
					{
						num2 = 14;
						num3 = num2;
						continue;
					}
					goto IL_02a2;
				case 7:
					{
						return list;
					}
					IL_0041:
					stackTrace = stackTrace2;
					num2 = 0;
					num3 = num2;
					continue;
					IL_02a2:
					array2 = array;
					num4 = 0;
					num2 = 15;
					num3 = num2;
					continue;
					IL_01f6:
					num2 = 26;
					num3 = num2;
					continue;
				}
				break;
			}
		}
	}

	public virtual IList<ComponentInfo> GetComponentInfo()
	{
		switch (0)
		{
		}
		List<ComponentInfo> list = default(List<ComponentInfo>);
		Assembly[] assemblies = default(Assembly[]);
		int num3 = default(int);
		while (true)
		{
			if (true)
			{
			}
			int num = -7330;
			int num2 = num;
			num = -7330;
			int num4;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				list = new List<ComponentInfo>();
				assemblies = AppDomain.CurrentDomain.GetAssemblies();
				num3 = 0;
				num = 3;
				num4 = num;
				goto IL_00da;
			case false:
			case true:
				{
					num = 0;
					num4 = num;
					goto IL_00da;
				}
				IL_00da:
				while (true)
				{
					switch (num4)
					{
					case 0:
						break;
					case 2:
					case 3:
						goto end_IL_00da;
					default:
						goto end_IL_003a;
					case 1:
						return list;
					}
					if (num3 >= assemblies.Length)
					{
						num = 1;
						num4 = num;
						continue;
					}
					Assembly assembly = assemblies[num3];
					AssemblyName name = assembly.GetName();
					list.Add(new ComponentInfo(name.Name, name.Version!.ToString(), name.FullName));
					num3++;
					num = 2;
					num4 = num;
					continue;
					end_IL_00da:
					break;
				}
				goto case false;
				end_IL_003a:
				break;
			}
		}
	}

	public virtual ISettingsStore GetSettingsStore()
	{
		if (NetUtilities.RunningInMono())
		{
			int num = 25612;
			int num2 = num;
			num = 25612;
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
			return new MonoSettingsStore(Config.ApplicationID.ToString());
		}
		return new SettingsStore(Config.ApplicationID.ToString());
	}

	public virtual SystemInfo GetSystemInfo(bool fulldata)
	{
		int num = 25704;
		int num2 = num;
		num = 25704;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			return new SystemInfo();
		}
	}

	public virtual PerformanceInfo GetPerformanceInfo(bool fulldata)
	{
		int num = 11545;
		int num2 = num;
		num = 11545;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return new PerformanceInfo();
		}
	}

	public virtual IOfflineDataStore GetOfflineDataStore()
	{
		if (NetUtilities.RunningInMono())
		{
			int num = -10539;
			int num2 = num;
			num = -10539;
			switch (num2 == num)
			{
			default:
				if (false)
				{
				}
				break;
			case false:
			case true:
				break;
			}
			if (1 == 0)
			{
			}
			return new OfflineDataStore(new MonoOfflineStorageManager(Config.ApplicationID.ToString()), Logger);
		}
		return new OfflineDataStore(new OfflineStorageManager(Config.ApplicationID.ToString()), Logger);
	}

	public static BinaryInfo GetCurrentBinaryInfo()
	{
		switch (0)
		{
		}
		Assembly assembly = default(Assembly);
		while (true)
		{
			MethodBase method = new StackTrace().GetFrame(1)!.GetMethod();
			BinaryInfo binaryInfo = new BinaryInfo();
			binaryInfo.MethodName = method.Name;
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (1 == 0)
					{
					}
					if (method.DeclaringType != null)
					{
						num = 2;
						num2 = num;
						continue;
					}
					goto case 0;
				case 3:
					binaryInfo.LastModified = new FileInfo(assembly.Location).LastWriteTimeUtc;
					num = 0;
					num2 = num;
					continue;
				case 2:
				{
					num = -9903;
					int num3 = num;
					num = -9903;
					switch (num3 == num)
					{
					default:
						if (0 == 0)
						{
						}
						assembly = method.DeclaringType!.Module.Assembly;
						binaryInfo.LoadFromAssembly(assembly);
						binaryInfo.ClassName = method.DeclaringType!.FullName;
						num = 1;
						num2 = num;
						continue;
					case false:
					case true:
						break;
					}
					goto case 0;
				}
				case 1:
					if (File.Exists(assembly.Location))
					{
						num = 3;
						num2 = num;
						continue;
					}
					goto case 0;
				case 0:
					return binaryInfo;
				}
				break;
			}
		}
	}

	internal static string smethod_0(string string_0)
	{
		int num = 12;
		switch (0)
		{
		default:
		{
			if (1 == 0)
			{
			}
			MD5 mD = MD5.Create();
			try
			{
				string result = default(string);
				while (true)
				{
					byte[] array = mD.ComputeHash(Encoding.UTF8.GetBytes(string_0));
					StringBuilder stringBuilder = new StringBuilder();
					int num2 = 0;
					int num3 = 4;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 2:
						case 4:
							num3 = 0;
							num4 = num3;
							continue;
						case 1:
							result = stringBuilder.ToString();
							num3 = 3;
							num4 = num3;
							continue;
						case 0:
						{
							num3 = 16776;
							int num5 = num3;
							num3 = 16776;
							switch (num5 == num3)
							{
							case false:
							case true:
								break;
							default:
								if (0 == 0)
								{
								}
								if (num2 >= array.Length)
								{
									num3 = 1;
									num4 = num3;
									continue;
								}
								stringBuilder.Append(array[num2].ToString("틖꺀"));
								num2++;
								num3 = 2;
								num4 = num3;
								continue;
							}
							goto case 2;
						}
						case 3:
							return result;
						}
						break;
					}
				}
			}
			finally
			{
				int num3 = 2;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						if (mD != null)
						{
							num3 = 0;
							num4 = num3;
							continue;
						}
						break;
					case 0:
						((IDisposable)mD).Dispose();
						num3 = 1;
						num4 = num3;
						continue;
					case 1:
						break;
					}
					break;
				}
			}
		}
		}
	}

	public void ExecuteAsyncIfSupported(Action action, [Optional] bool highPriority)
	{
		if (1 == 0)
		{
		}
		int num = -4286;
		int num2 = num;
		num = -4286;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		Thread thread = new Thread((ThreadStart)delegate
		{
			int num3 = 8528;
			int num4 = num3;
			num3 = 8528;
			switch (num4 == num3)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				action();
				break;
			}
		});
		thread.Priority = ((!highPriority) ? ThreadPriority.BelowNormal : ThreadPriority.AboveNormal);
		thread.IsBackground = true;
		thread.Start();
	}

	public virtual Configuration.ApplicationStopBehavior GetStopBehaviorDefaults()
	{
		int num = -29783;
		int num2 = num;
		num = -29783;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return PlatformClient.CoreDefaultStopBehavior();
		}
	}

	[CompilerGenerated]
	private static bool smethod_1(IPAddress ipaddress_0)
	{
		int num = 27362;
		int num2 = num;
		num = 27362;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return ipaddress_0.AddressFamily == AddressFamily.InterNetwork;
		}
	}
}
