using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Management;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using PreEmptive.Analytics.Common;
using PreEmptive.Analytics.Common.Messages;
using PreEmptive.Analytics.Common.Utilities;
using PreEmptive.Analytics.NET.Common;

namespace PreEmptive.Analytics.NET;

public class Platform : CommonNetPlatform
{
	public Platform(Configuration config, [Optional] ILogger logger)
		: base(config, logger)
	{
	}

	public override AgentInfo GetAgentInfo()
	{
		int num = 12;
		while (true)
		{
			AgentInfo agentInfo = base.GetAgentInfo();
			agentInfo.Name = "튀껼닳뛦늞뻱닚뛓닝긡刿嘱";
			int num2 = 0;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 2:
					agentInfo.Name += "튎꺚닻뛝닐뻝늟";
					num2 = 1;
					num3 = num2;
					continue;
				case 0:
					if (NetUtilities.RunningInMono())
					{
						num2 = 25286;
						int num4 = num2;
						num2 = 25286;
						switch (num4 == num2)
						{
						default:
							if (1 == 0)
							{
							}
							if (0 == 0)
							{
							}
							num2 = 2;
							num3 = num2;
							continue;
						case false:
						case true:
							break;
						}
					}
					goto case 1;
				case 1:
					return agentInfo;
				}
				break;
			}
		}
	}

	public override OSInfo GetOSInfo()
	{
		int num = 2;
		OSInfo result = default(OSInfo);
		try
		{
			int num2 = 26482;
			int num3 = num2;
			num2 = 26482;
			switch (num3 == num2)
			{
			default:
			{
				if (0 == 0)
				{
				}
				IEnumerator<ManagementBaseObject> enumerator = "횁튛\ude9e튓횑틺꺒닿뛜닍뻆닗뛞닂긖刷嘦刻幾剶嘑刏渂爂瘛爑縜牚癒爽渷判嘻刿帾刘嘧勃껐닓뛀늒뺒닥뛗닜꺤튿횱튻\ude82튷횱튅\ueebf\uf297\uf698\uf291ﺀ\uf2a0\uf697\uf29c\ueea1튿횽튰\udefe틶횁틋껀닀뛛닝뻗닦뛓닍긹创嘻到帽判嘄刋渀爅瘛爑縜牖瘴爼渝创噲刉帻券噡劜껭당뛂닛뻀닗뛆닇꺼튱횁튧\udea1튢횷튃".smethod_0().GetEnumerator();
				try
				{
					num2 = 2;
					int num4 = num2;
					while (true)
					{
						switch (num4)
						{
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num2 = 3;
								num4 = num2;
								break;
							}
							ManagementBaseObject current = enumerator.Current;
							result.InstallDate = ManagementDateTimeConverter.ToDateTime(current.smethod_1("횛튰\udea1튢횳틂껞닲뛓닊뻗")).ToISOFormat();
							result.Language = CultureInfo.InstalledUICulture.Name;
							result.Name = current.smethod_1("횑튿\udea2튢횻틁껜");
							result.ProductCode = CommonNetPlatform.smethod_0(current.smethod_1("횁튻\udea0튿횳틂껼닃뛟닜뻗닄"));
							result.ServicePackVersionMajor = current.smethod_2<ushort>("횁튻\udea0튠횻틍껗닦뛓닝뻙닻뛓닄긽判嘄刻帠別嘻刁渜");
							result.ServicePackVersionMinor = current.smethod_2<ushort>("횁튻\udea0튠횻틍껗닦뛓닝뻙닻뛛닀긽判嘄刻帠別嘻刁渜");
							num2 = 1;
							num4 = num2;
							break;
						}
						case 3:
							num2 = 0;
							num4 = num2;
							break;
						default:
							num2 = 4;
							num4 = num2;
							break;
						case 0:
							return result;
						}
					}
				}
				finally
				{
					num2 = 0;
					int num4 = num2;
					while (true)
					{
						if (true)
						{
						}
						switch (num4)
						{
						default:
							if (enumerator != null)
							{
								num2 = 2;
								num4 = num2;
								continue;
							}
							break;
						case 2:
							enumerator.Dispose();
							num2 = 1;
							num4 = num2;
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
			case false:
			case true:
				return result;
			}
		}
		catch
		{
			return result;
		}
	}

	public override UserInfo GetUserInfo()
	{
		int num = 15;
		switch (0)
		{
		default:
		{
			UserInfo result = default(UserInfo);
			string text = "";
			try
			{
				if (1 == 0)
				{
				}
				text = Environment.UserDomainName + "닮" + Environment.UserName;
			}
			catch
			{
			}
			try
			{
				int num2 = -32658;
				int num3 = num2;
				num2 = -32658;
				switch (num3 == num2)
				{
				default:
				{
					if (0 == 0)
					{
					}
					IEnumerator<ManagementBaseObject> enumerator = ("닡뛳닾뻻닱뛢늒껻刡嘳删帐刳嘻刷湎爴瘤爽縳牒瘡爛渀剡噤刍帝刽嘻刢껛닆뛓닀뻭닋뛅닆껋튿훶튅\ude96튗횄튗\ueece\uf2bc\uf697\uf29fﺛ\uf2cf\uf6d1" + Environment.MachineName + "늕").smethod_0().GetEnumerator();
					try
					{
						num2 = 2;
						int num4 = num2;
						ManagementBaseObject current = default(ManagementBaseObject);
						while (true)
						{
							string text2;
							switch (num4)
							{
							case 6:
								if (!enumerator.MoveNext())
								{
									num2 = 5;
									num4 = num2;
								}
								else
								{
									current = enumerator.Current;
									num2 = 4;
									num4 = num2;
								}
								continue;
							case 5:
								num2 = 1;
								num4 = num2;
								continue;
							case 4:
								text2 = current.smethod_1("닧뛅닗뻌닼뛗닟껋");
								if (text2 == null)
								{
									num2 = 3;
									num4 = num2;
									continue;
								}
								goto IL_012e;
							case 3:
								text2 = text;
								goto IL_012e;
							default:
								num2 = 6;
								num4 = num2;
								continue;
							case 1:
								break;
								IL_012e:
								text = text2;
								num2 = 0;
								num4 = num2;
								continue;
							}
							break;
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
							case 2:
								enumerator.Dispose();
								num2 = 1;
								num4 = num2;
								continue;
							default:
								if (enumerator != null)
								{
									num2 = 2;
									num4 = num2;
									continue;
								}
								break;
							case 1:
								break;
							}
							break;
						}
					}
					break;
				}
				case false:
				case true:
					break;
				}
			}
			catch
			{
			}
			result.HashedName = (string.IsNullOrEmpty(text) ? "" : CommonNetPlatform.smethod_0(text));
			result.IsAdmin = new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
			return result;
		}
		}
	}

	public override SystemInfo GetSystemInfo(bool fulldata)
	{
		int num = 7615;
		int num2 = num;
		num = 7615;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			return SystemInfoPopulator.GetNewSystemInfo(fulldata);
		}
	}

	public override PerformanceInfo GetPerformanceInfo(bool fulldata)
	{
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fe: Expected O, but got Unknown
		int num = 16;
		if (1 == 0)
		{
		}
		int num2 = -7533;
		int num3 = num2;
		num2 = -7533;
		switch (num3 == num2)
		{
		default:
		{
			if (0 == 0)
			{
			}
			PerformanceInfo result = new PerformanceInfo();
			try
			{
				while (true)
				{
					PerformanceCounter val = new PerformanceCounter("닻뛗닓뻝닄뛋", "닷뛄닟뻛닚뛓닌긾刳噲刓帐刯嘦刋渁");
					result.UsedMemory = (int)(Process.GetCurrentProcess().WorkingSet64 / 1048576L);
					result.TotalMemory = (int)val.NextValue();
					num2 = 1;
					int num4 = num2;
					while (true)
					{
						switch (num4)
						{
						case 3:
							num2 = 2;
							num4 = num2;
							continue;
						case 1:
							if (fulldata)
							{
								num2 = 0;
								num4 = num2;
								continue;
							}
							goto case 3;
						case 0:
						{
							PerformanceCounter val2 = new PerformanceCounter("닦뛀닑뻑닓뛁닝", "늓뚒닮뻀닙뛑닋긡別嘽刬干刂嘻刃渗", Process.GetCurrentProcess().ProcessName, true);
							val2.NextValue();
							Thread.Sleep(100);
							result.CpuUtilization = Math.Min((int)val2.NextValue() / Environment.ProcessorCount, 100);
							num2 = 3;
							num4 = num2;
							continue;
						}
						case 2:
							return result;
						}
						break;
					}
				}
			}
			catch
			{
				return result;
			}
		}
		case false:
		case true:
		{
			PerformanceInfo result = default(PerformanceInfo);
			return result;
		}
		}
	}
}
