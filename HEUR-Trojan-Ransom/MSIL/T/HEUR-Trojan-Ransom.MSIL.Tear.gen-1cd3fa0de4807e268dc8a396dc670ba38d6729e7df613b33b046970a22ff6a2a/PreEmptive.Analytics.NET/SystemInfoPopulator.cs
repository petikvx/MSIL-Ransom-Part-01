using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common.Messages;
using PreEmptive.Analytics.Common.SystemProfileInfo;
using PreEmptive.Analytics.Common.Utilities;
using PreEmptive.Analytics.NET.Common;

namespace PreEmptive.Analytics.NET;

public static class SystemInfoPopulator
{
	[CompilerGenerated]
	private sealed class Class27
	{
		public SystemInfo systemInfo_0;

		public bool bool_0;

		public void method_0()
		{
			int num = 5686;
			int num2 = num;
			num = 5686;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			smethod_0(systemInfo_0);
		}

		public void method_1()
		{
			int num = -22725;
			int num2 = num;
			num = -22725;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			smethod_1(systemInfo_0);
		}

		public void method_2()
		{
			int num = -25749;
			int num2 = num;
			num = -25749;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			smethod_2(systemInfo_0);
		}

		public void method_3()
		{
			int num = -965;
			int num2 = num;
			num = -965;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			smethod_3(systemInfo_0, bool_0);
		}

		public void method_4()
		{
			int num = -24404;
			int num2 = num;
			num = -24404;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			smethod_4(systemInfo_0);
		}

		public void method_5()
		{
			int num = -24404;
			int num2 = num;
			num = -24404;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			smethod_5(systemInfo_0);
		}

		public void method_6()
		{
			if (1 == 0)
			{
			}
			int num = 6681;
			int num2 = num;
			num = 6681;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			smethod_6(systemInfo_0);
		}

		public void method_7()
		{
			int num = -29749;
			int num2 = num;
			num = -29749;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			smethod_7(systemInfo_0);
		}

		public void method_8()
		{
			int num = 27518;
			int num2 = num;
			num = 27518;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			smethod_8(systemInfo_0);
		}

		public void method_9()
		{
			int num = -27093;
			int num2 = num;
			num = -27093;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			smethod_9(systemInfo_0);
		}

		public void method_10()
		{
			int num = 4852;
			int num2 = num;
			num = 4852;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			smethod_10(systemInfo_0);
		}
	}

	[CompilerGenerated]
	private sealed class Class28
	{
		public PerformanceCounterCategory performanceCounterCategory_0;

		public string[] string_0;
	}

	[CompilerGenerated]
	private sealed class Class29
	{
		public Class28 class28_0;

		public NetworkInfo networkInfo_0;

		public void method_0()
		{
			//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f4: Expected O, but got Unknown
			int num = 6;
			switch (0)
			{
			}
			int num2 = 6430;
			int num3 = num2;
			num2 = 6430;
			int num4;
			ManagementBaseObject val = default(ManagementBaseObject);
			string text = default(string);
			switch (num3 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				goto IL_0154;
			case false:
			case true:
				{
					num2 = 3;
					num4 = num2;
					goto IL_0063;
				}
				IL_0154:
				val = ((IEnumerable<ManagementBaseObject>)"\ude81튓횞틫껱닢뚒닳뻳답뛳닊긶判嘷刭帡剺噲刪渗爅瘑爌縛爆瘆爇渽券噲刘帀则嘟劎껥닟뛜늍뺀닩뛼닋꺦튡횽튬\udeb9튗횶튏\uee82\uf282\uf697\uf28cﺱ\uf299\uf69c\uf288\ueebb튱횧튬\udeb3튢횻틁껜".smethod_0()).FirstOrDefault((Func<ManagementBaseObject, bool>)delegate(ManagementBaseObject managementBaseObject_0)
				{
					int num5 = 19;
					int num6 = -9102;
					int num7 = num6;
					num6 = -9102;
					switch (num7 == num6)
					{
					default:
						if (1 == 0)
						{
						}
						if (0 == 0)
						{
						}
						return managementBaseObject_0.smethod_1("닿뻿닱뛷닖껊删嘳刡席") == networkInfo_0.MacAddress;
					}
				});
				num2 = 0;
				num4 = num2;
				goto IL_0063;
				IL_0063:
				while (true)
				{
					switch (num4)
					{
					case 3:
					{
						string @object = val.smethod_1("\ude96튳횡틍껀닟뛂닊뻛닙뛜").smethod_4();
						text = class28_0.string_0.Where(@object.Contains).FirstOrDefault();
						num2 = 1;
						num4 = num2;
						continue;
					}
					case 2:
					{
						if (1 == 0)
						{
						}
						PerformanceCounter val2 = new PerformanceCounter(class28_0.performanceCounterCategory_0.get_CategoryName(), "\ude91튣횠틜껗님뛆늞뻰닗뛜닊긥刿嘶刪帺", text);
						val2.NextValue();
						networkInfo_0.Speed = (ulong)Math.Max(0f, val2.NextValue() / 1000000f);
						num2 = 4;
						num4 = num2;
						continue;
					}
					case 1:
						if (!string.IsNullOrEmpty(text))
						{
							num2 = 2;
							num4 = num2;
							continue;
						}
						return;
					case 0:
						goto IL_0182;
					case 4:
						return;
					}
					break;
				}
				goto IL_0154;
				IL_0182:
				if (val == null)
				{
					break;
				}
				goto case false;
			}
		}

		public bool method_1(ManagementBaseObject managementBaseObject_0)
		{
			int num = 19;
			int num2 = -9102;
			int num3 = num2;
			num2 = -9102;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return managementBaseObject_0.smethod_1("닿뻿닱뛷닖껊删嘳刡席") == networkInfo_0.MacAddress;
			}
		}
	}

	[CompilerGenerated]
	private static Func<UnicastIPAddressInformation, bool> func_0;

	[CompilerGenerated]
	private static Func<UnicastIPAddressInformation, bool> func_1;

	public static SystemInfo GetNewSystemInfo(bool fullData)
	{
		int num = 20986;
		int num2 = num;
		num = 20986;
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
			SystemInfo systemInfo_0 = new SystemInfo();
			Utils.Attempt(delegate
			{
				int num23 = 5686;
				int num24 = num23;
				num23 = 5686;
				switch (num24 == num23)
				{
				default:
					if (1 == 0)
					{
					}
					if (0 == 0)
					{
					}
					smethod_0(systemInfo_0);
					break;
				}
			});
			Utils.Attempt(delegate
			{
				int num21 = -22725;
				int num22 = num21;
				num21 = -22725;
				switch (num22 == num21)
				{
				default:
					if (0 == 0)
					{
					}
					if (1 == 0)
					{
					}
					smethod_1(systemInfo_0);
					break;
				}
			});
			Utils.Attempt(delegate
			{
				int num19 = -25749;
				int num20 = num19;
				num19 = -25749;
				switch (num20 == num19)
				{
				default:
					if (0 == 0)
					{
					}
					if (1 == 0)
					{
					}
					smethod_2(systemInfo_0);
					break;
				}
			});
			Utils.Attempt(delegate
			{
				int num17 = -965;
				int num18 = num17;
				num17 = -965;
				switch (num18 == num17)
				{
				default:
					if (1 == 0)
					{
					}
					if (0 == 0)
					{
					}
					smethod_3(systemInfo_0, fullData);
					break;
				}
			});
			Utils.Attempt(delegate
			{
				int num15 = -24404;
				int num16 = num15;
				num15 = -24404;
				switch (num16 == num15)
				{
				default:
					if (1 == 0)
					{
					}
					if (0 == 0)
					{
					}
					smethod_4(systemInfo_0);
					break;
				}
			});
			Utils.Attempt(delegate
			{
				int num13 = -24404;
				int num14 = num13;
				num13 = -24404;
				switch (num14 == num13)
				{
				default:
					if (1 == 0)
					{
					}
					if (0 == 0)
					{
					}
					smethod_5(systemInfo_0);
					break;
				}
			});
			Utils.Attempt(delegate
			{
				if (1 == 0)
				{
				}
				int num11 = 6681;
				int num12 = num11;
				num11 = 6681;
				switch (num12 == num11)
				{
				default:
					if (0 == 0)
					{
					}
					smethod_6(systemInfo_0);
					break;
				}
			});
			Utils.Attempt(delegate
			{
				int num9 = -29749;
				int num10 = num9;
				num9 = -29749;
				switch (num10 == num9)
				{
				default:
					if (1 == 0)
					{
					}
					if (0 == 0)
					{
					}
					smethod_7(systemInfo_0);
					break;
				}
			});
			Utils.Attempt(delegate
			{
				int num7 = 27518;
				int num8 = num7;
				num7 = 27518;
				switch (num8 == num7)
				{
				default:
					if (0 == 0)
					{
					}
					if (1 == 0)
					{
					}
					smethod_8(systemInfo_0);
					break;
				}
			});
			Utils.Attempt(delegate
			{
				int num5 = -27093;
				int num6 = num5;
				num5 = -27093;
				switch (num6 == num5)
				{
				default:
					if (1 == 0)
					{
					}
					if (0 == 0)
					{
					}
					smethod_9(systemInfo_0);
					break;
				}
			});
			Utils.Attempt(delegate
			{
				int num3 = 4852;
				int num4 = num3;
				num3 = 4852;
				switch (num4 == num3)
				{
				default:
					if (0 == 0)
					{
					}
					if (1 == 0)
					{
					}
					smethod_10(systemInfo_0);
					break;
				}
			});
			return systemInfo_0;
		}
		}
	}

	private static void smethod_0(SystemInfo systemInfo_0)
	{
		int num = 16;
		int num2 = -26533;
		int num3 = num2;
		num2 = -26533;
		switch (num3 == num2)
		{
		case false:
		case true:
			return;
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		switch (0)
		{
		default:
		{
			IEnumerator<ManagementBaseObject> enumerator = "닥뛗닒뻗닕뛆늎긖刳嘤刷帱刳嘛刊湞牖瘼爟縟爓癞牎渟刷嘼别帴刷嘱勚껇닄뛗닌뺞늖뛳닊꺶튤횷튭\udea1튁횻튊\uee86\uf29e\uf6de\uf2deﺱ\uf283\uf680\uf29c\ueeb7트횦튝\udebe특횱틅껡닆뛗닛뻖늚뚒닣긳刮嘑刲帽刵嘹刽渂爓瘗爚繒爰瘠爡渟剶嘅刷帼剥噠勱껢닄뛝닝뻗닅뛁닁꺠".smethod_0().GetEnumerator();
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
						CpuInfo cpuInfo = default(CpuInfo);
						cpuInfo.Name = current.smethod_1("닲뛗니뻛닕뛗닧긶").smethod_3(string.Format("닕뛂닋뻉늆뛏", systemInfo_0.Cpus.Count + 1));
						cpuInfo.Model = current.smethod_1("닸뛓닓뻗");
						cpuInfo.Manufacturer = current.smethod_1("닻뛓닐뻇닐뛓닍긦刣嘠刻帠").smethod_2("닱뛗닐뻇닟뛜닋");
						cpuInfo.AddressWidth = current.smethod_2<ushort>("닷뛖닚뻀닓뛁닝긅刿嘶刪帺");
						cpuInfo.Speed = (int)current.smethod_2<uint>("답뛇닌뻀닓뛜닚긑刺嘽刽帹刅嘢刋渗爒");
						cpuInfo.MaxSpeed = (int)current.smethod_2<uint>("닻뛓닆뻱닚뛝닍긹刅嘢刻帷刲");
						CpuInfo item = cpuInfo;
						systemInfo_0.Cpus.Add(item);
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
						return;
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
		}
		}
	}

	private static void smethod_1(SystemInfo systemInfo_0)
	{
		int num = 4;
		int num2 = 1032;
		int num3 = num2;
		num2 = 1032;
		switch (num3 == num2)
		{
		case false:
		case true:
			return;
		}
		if (0 == 0)
		{
		}
		switch (0)
		{
		default:
		{
			if (1 == 0)
			{
			}
			IEnumerator<ManagementBaseObject> enumerator = "튍\ude97튚횗틭껦늖뛴닗뻞닓뛡닗긡刢嘷刳幾剶嘔刜渗爓瘡爎縓爕瘗牂湲刅嘻判帷剺噲勸껝닚뛇닓뻗닥뛗닜꺻튷횾튐\udea7튻횰튋\uee80\uf2da\uf6d2\uf2b0ﺓ\uf29b\uf697\uf2ce\uee94튄횝튓\udef2튁횻틀꺁늄뛭닲뻝닑뛛닍긳刺嘖刷帡刽".smethod_0().GetEnumerator();
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
						DiskInfo diskInfo = default(DiskInfo);
						diskInfo.Filesystem = current.smethod_1("튘\udebb튺횷틽껋닅뛆닛뻟");
						diskInfo.Free = (int)(current.smethod_2<ulong>("튘\udea0튳횷틽껂닗뛑닛") >> 20);
						diskInfo.Size = (int)(current.smethod_2<ulong>("튍\udebb튬횷") >> 20);
						diskInfo.Serial = current.smethod_1("튈\udebd튺횧틃껗닥뛗닌뻛닗뛞닠긧刻嘰刻帠");
						diskInfo.Name = current.smethod_1("튐\udeb3튻횷");
						DiskInfo item = diskInfo;
						systemInfo_0.Disks.Add(item);
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
						return;
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
		}
		}
	}

	private static void smethod_2(SystemInfo systemInfo_0)
	{
		int num = 4;
		switch (0)
		{
		}
		MemoryInfo memoryInfo = default(MemoryInfo);
		memoryInfo.Capacity = 0;
		memoryInfo.Speed = int.MaxValue;
		memoryInfo.Total = 0;
		MemoryInfo memory = memoryInfo;
		IEnumerator<ManagementBaseObject> enumerator = "튍\ude97튚횗틭껦늖뛱닟뻂닗뛑닇긦刯噾剾币刦嘷刋渖牖瘴爬總爻癒爹渻券噡剬帍分嘺勗껁닟뛑닟뻞닻뛗닃꺽튤횫".smethod_0().GetEnumerator();
		try
		{
			int num2 = 2;
			int num3 = num2;
			ManagementBaseObject current = default(ManagementBaseObject);
			int num4 = default(int);
			while (true)
			{
				switch (num3)
				{
				case 6:
					if (!enumerator.MoveNext())
					{
						num2 = 5;
						num3 = num2;
					}
					else
					{
						current = enumerator.Current;
						num2 = 4;
						num3 = num2;
					}
					continue;
				case 5:
					num2 = 1;
					num3 = num2;
					continue;
				case 4:
					memory.Capacity = (memory.Capacity ?? 0) + (int)(current.smethod_2<ulong>("튝\udeb3튦횳틍껛닂뛋") >> 20);
					num4 = (int)current.smethod_2<uint>("튍\udea2튳횷틊");
					num2 = 3;
					num3 = num2;
					continue;
				case 3:
					memory.Speed = ((memory.Speed > num4) ? new int?(num4) : memory.Speed);
					num2 = 0;
					num3 = num2;
					continue;
				default:
					num2 = 6;
					num3 = num2;
					continue;
				case 1:
					break;
				}
				break;
			}
		}
		finally
		{
			int num2 = 0;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 2:
					enumerator.Dispose();
					num2 = 1;
					num3 = num2;
					continue;
				default:
				{
					if (enumerator == null)
					{
						break;
					}
					num2 = -14539;
					int num5 = num2;
					num2 = -14539;
					switch (num5 == num2)
					{
					default:
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
					break;
				}
				case 1:
					break;
				}
				break;
			}
		}
		if (1 == 0)
		{
		}
		IEnumerator<ManagementBaseObject> enumerator2 = "튍\ude97튚횗틭껦늖뛦닑뻆닗뛞닾긺刯嘡刷帱刷嘾刣渗爛瘝爌縋牖瘴爼渝创噲刉帻券噡劜껭답뛝닓뻂닃뛆닋꺠튅횫튭\udea6튳횿".smethod_0().GetEnumerator();
		try
		{
			int num2 = 2;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 4:
					num2 = 0;
					num3 = num2;
					continue;
				default:
					num2 = 1;
					num3 = num2;
					continue;
				case 1:
				{
					if (!enumerator2.MoveNext())
					{
						num2 = 4;
						num3 = num2;
						continue;
					}
					ManagementBaseObject current2 = enumerator2.Current;
					memory.Total = (int)(current2.smethod_2<ulong>("튊\udebd튢횳틂껢닞뛋닍뻛닕뛓닂긟刳嘿刱帠刯") >> 20);
					num2 = 3;
					num3 = num2;
					continue;
				}
				case 0:
					break;
				}
				break;
			}
		}
		finally
		{
			int num2 = 0;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 2:
					enumerator2.Dispose();
					num2 = 1;
					num3 = num2;
					continue;
				default:
					if (enumerator2 != null)
					{
						num2 = 2;
						num3 = num2;
						continue;
					}
					break;
				case 1:
					break;
				}
				break;
			}
		}
		systemInfo_0.Memory = memory;
	}

	private static void smethod_3(SystemInfo systemInfo_0, bool bool_0)
	{
		//IL_047c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected O, but got Unknown
		int num = 1;
		switch (0)
		{
		}
		List<UnicastIPAddressInformation> source = default(List<UnicastIPAddressInformation>);
		Class29 class2 = default(Class29);
		IPInterfaceProperties iPProperties = default(IPInterfaceProperties);
		Action action = default(Action);
		List<UnicastIPAddressInformation> source2 = default(List<UnicastIPAddressInformation>);
		NetworkInterface networkInterface = default(NetworkInterface);
		while (true)
		{
			Class28 @class = new Class28();
			@class.performanceCounterCategory_0 = new PerformanceCounterCategory("횘튷\udeaa튥횹튠껅늒뛿닜뻊닗뛄닔껏刱嘳");
			@class.string_0 = @class.performanceCounterCategory_0.GetInstanceNames();
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			int num2 = 0;
			int num3 = 10;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				case 23:
					if (source.Any())
					{
						num3 = 15;
						num4 = num3;
					}
					else
					{
						num3 = 13;
						num4 = num3;
					}
					continue;
				case 22:
					class2.networkInfo_0.UsesDhcp = iPProperties.GetIPv4Properties().IsDhcpEnabled;
					num3 = 17;
					num4 = num3;
					continue;
				case 21:
					if (action == null)
					{
						num3 = 0;
						num4 = num3;
						continue;
					}
					goto case 14;
				case 14:
					Utils.Attempt(action);
					num3 = 7;
					num4 = num3;
					continue;
				case 20:
					source2 = iPProperties.UnicastAddresses.Where(delegate(UnicastIPAddressInformation unicastIPAddressInformation_0)
					{
						int num6 = -26883;
						int num7 = num6;
						num6 = -26883;
						switch (num7 == num6)
						{
						default:
							if (0 == 0)
							{
							}
							if (1 == 0)
							{
							}
							return unicastIPAddressInformation_0.Address.AddressFamily == AddressFamily.InterNetworkV6;
						}
					}).ToList();
					num3 = 23;
					num4 = num3;
					continue;
				case 1:
				case 3:
				case 19:
					class2.networkInfo_0.MaxSpeed = (ulong)Math.Max(0L, networkInterface.Speed / 1000000L);
					class2.networkInfo_0.Name = networkInterface.Name;
					num3 = 9;
					num4 = num3;
					continue;
				case 18:
				{
					num3 = -333;
					int num5 = num3;
					num3 = -333;
					switch (num5 == num3)
					{
					case false:
					case true:
						break;
					default:
						if (0 == 0)
						{
						}
						num3 = 21;
						num4 = num3;
						continue;
					}
					goto case 1;
				}
				case 17:
					num3 = 6;
					num4 = num3;
					continue;
				case 16:
					if (iPProperties.GetIPv4Properties() != null)
					{
						num3 = 22;
						num4 = num3;
						continue;
					}
					goto case 17;
				case 15:
					class2.networkInfo_0.IpAddress = source.Last().Address.ToString();
					num3 = 1;
					num4 = num3;
					continue;
				case 13:
					if (source2.Any())
					{
						num3 = 11;
						num4 = num3;
					}
					else
					{
						class2.networkInfo_0.IpAddress = new IPAddress(0L).ToString();
						num3 = 3;
						num4 = num3;
					}
					continue;
				case 10:
				case 12:
					num3 = 4;
					num4 = num3;
					continue;
				case 11:
					class2.networkInfo_0.IpAddress = source2.Last().Address.ToString();
					num3 = 19;
					num4 = num3;
					continue;
				case 9:
					if (bool_0)
					{
						num3 = 18;
						num4 = num3;
						continue;
					}
					goto case 7;
				case 7:
					if (1 == 0)
					{
					}
					systemInfo_0.Networks.Add(class2.networkInfo_0);
					num2++;
					num3 = 12;
					num4 = num3;
					continue;
				case 8:
					num3 = 16;
					num4 = num3;
					continue;
				case 6:
					source = iPProperties.UnicastAddresses.Where(delegate(UnicastIPAddressInformation unicastIPAddressInformation_0)
					{
						int num8 = 25660;
						int num9 = num8;
						num8 = 25660;
						switch (num9 == num8)
						{
						default:
							if (1 == 0)
							{
							}
							if (0 == 0)
							{
							}
							return unicastIPAddressInformation_0.Address.AddressFamily == AddressFamily.InterNetwork;
						}
					}).ToList();
					num3 = 20;
					num4 = num3;
					continue;
				case 4:
					if (num2 >= allNetworkInterfaces.Length)
					{
						num3 = 5;
						num4 = num3;
						continue;
					}
					networkInterface = allNetworkInterfaces[num2];
					action = null;
					class2 = new Class29();
					class2.class28_0 = @class;
					class2.networkInfo_0 = new NetworkInfo
					{
						MacAddress = BitConverter.ToString(networkInterface.GetPhysicalAddress().GetAddressBytes()).Replace('-', ':')
					};
					iPProperties = networkInterface.GetIPProperties();
					num3 = 2;
					num4 = num3;
					continue;
				case 2:
					if (networkInterface.Supports(NetworkInterfaceComponent.IPv4))
					{
						num3 = 8;
						num4 = num3;
						continue;
					}
					goto case 17;
				case 0:
					action = class2.method_0;
					num3 = 14;
					num4 = num3;
					continue;
				case 5:
					return;
				}
				break;
			}
		}
	}

	private static void smethod_4(SystemInfo systemInfo_0)
	{
		int num = 1;
		if (1 == 0)
		{
		}
		switch (0)
		{
		}
		DomainInfo value = default(DomainInfo);
		while (true)
		{
			ManagementBaseObject val = "횅튗\ude92튗횕튆꺎닱뛃닀뻌닗뛘닆껺刻嘻刷帄刽嘸刷湂牒瘲爓縇爞瘟爕渆刦嘟刼帛刴嘰刷껍닆뚚늒뻳닓뛘닇껈튳횵튦\udeab튠횳튠\ueec2\uf2d2\uf6bb\uf29dﺚ\uf297\uf69a\uf2de\ueece튂횷튠\udeaa튝횰튖껁닟뛗닛뻐늞뚖닶껁刿嘷刻帰剾噶刖渁爟瘗爛縐爠瘙爞渋剾噶刂帱別嘳删껽닆뛗닆뻛늒뛰닠껡튟훶튅\udeb7튼훥틠\ueeb1\uf2b1\uf699\uf29fﺎ\uf287\uf682\uf297\uee9c튁횯튡\udeaa튷횻".smethod_0().LastOrDefault();
			while (true)
			{
				int num2 = 0;
				int num3 = num2;
				while (true)
				{
					num2 = -3443;
					int num4 = num2;
					num2 = -3443;
					switch (num4 == num2)
					{
					case false:
					case true:
						goto end_IL_019b;
					}
					if (0 == 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (val != null)
						{
							num2 = 4;
							num3 = num2;
							continue;
						}
						return;
					case 1:
						if (value.MemberOf)
						{
							num2 = 2;
							num3 = num2;
							continue;
						}
						goto case 3;
					case 2:
						value.Name = val.smethod_1("횒튽\udeb3튳횿튼");
						value.Role = smethod_12(val.smethod_2<ushort>("횒튽\udeb3튳횿튼껼닝뛚닗"));
						num2 = 3;
						num3 = num2;
						continue;
					case 3:
						systemInfo_0.Domain = value;
						systemInfo_0.PowerState = smethod_11(val.smethod_2<ushort>("횆튽\udea9튷횤튁껚닓뛂닗"));
						systemInfo_0.TimeZone = new TimeInfo
						{
							DaylightSavingsInEffect = val.smethod_2<bool>("횒튳\udea7튾횿튵껆닆뛿닜뻻닔뛐닗껍刦"),
							Zone = val.smethod_2<short>("횕튧\udeac튠횳튼껚닦뛟닟뻛단뛙닜껋")
						};
						num2 = 5;
						num3 = num2;
						continue;
					case 4:
					{
						systemInfo_0.Manufacturer = val.smethod_1("횛튳\udeb0튧횰튳껍닆뛃닀뻛닀");
						systemInfo_0.Model = val.smethod_1("횛튽\udeba튷횺");
						DomainInfo domainInfo = default(DomainInfo);
						domainInfo.MemberOf = val.smethod_2<bool>("횆튳\udeac튦횙튴껪닝뛛닓뻗닜");
						value = domainInfo;
						num2 = 1;
						num3 = num2;
						continue;
					}
					case 5:
						return;
					}
					goto end_IL_01cf;
					continue;
					end_IL_019b:
					break;
				}
				continue;
				end_IL_01cf:
				break;
			}
		}
	}

	private static void smethod_5(SystemInfo systemInfo_0)
	{
		int num = 19;
		switch (0)
		{
		}
		IEnumerator<ManagementBaseObject> enumerator = default(IEnumerator<ManagementBaseObject>);
		while (true)
		{
			ICollection<ManagementBaseObject> collection = "닡뻻닾뛳닱껺割嘟刼帷刦嘿刳渂爡瘟爈縛牞癖爿渏刪嘿刿師刿嘅刻껔닗뚚늒뻰닓뛛닗꺎튔횄튝\ude93틲횁튻\uee80\uf2c1\uf6c4\uf2adﺮ\uf293\uf691\uf297\ueea8튻횺튷\ude8d튷횢튦껇닜뛑".smethod_0();
			string string_ = "닻뻐닛뛂닛껏刾嘅刻帤刷";
			string string_2 = "닿뻟닊뛟닟껛刿嘅刻帤刷";
			string string_3 = "닼뻟닟뛓";
			int num2 = 0;
			int num3 = num2;
			while (true)
			{
				if (true)
				{
				}
				switch (num3)
				{
				case 0:
					if (!collection.Any())
					{
						num2 = 5;
						num3 = num2;
						continue;
					}
					goto case 4;
				case 1:
					collection = "닡뻻닾뛳닱껺割嘗刾帲刽嘵刳渚爗瘒爰縟爁瘓爡渇刨嘳剾幾刂嘳刳껅닧뛅닓뻙닗뚚늒껠튳횻튷\udefe튔횄튝\ueea3\uf2d2\uf6a1\uf29bﺐ\uf2c1\uf6c4\uf2ad\ueebe튳횱튷\ude98튻횺튷껻닁뛗닕뻛".smethod_0();
					string_ = "닳뻒닞뛙닑껏刦嘳制帜刳嘥刷渽爛瘌爗";
					string_2 = "닢뻛닓뛝닧껝刳嘱刷";
					string_3 = "닼뻟닟뛓";
					num2 = 6;
					num3 = num2;
					continue;
				case 2:
					if (!collection.Any())
					{
						num2 = 1;
						num3 = num2;
						continue;
					}
					goto case 6;
				case 4:
					num2 = 2;
					num3 = num2;
					continue;
				case 5:
					collection = "닡뻻닾뛳닱껺割嘟刼帷刦嘿刳渂爡瘟爈縛牞癖爿渏刪嘿刿師刿嘅刻껔닗뚚늒뻰닓뛛닗꺎튔횄튝\ude93틲횁튻\uee80\uf2c1\uf6c4\uf2adﺮ\uf293\uf691\uf297\ueea8튻횺튷".smethod_0();
					num2 = 4;
					num3 = num2;
					continue;
				case 6:
					enumerator = collection.GetEnumerator();
					num2 = 3;
					num3 = num2;
					continue;
				case 3:
					try
					{
						num2 = 0;
						num3 = num2;
						while (true)
						{
							switch (num3)
							{
							case 4:
								num2 = 2;
								num3 = num2;
								break;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num2 = 4;
									num3 = num2;
									break;
								}
								ManagementBaseObject current = enumerator.Current;
								PageFileInfo pageFileInfo = default(PageFileInfo);
								pageFileInfo.InitialSize = (int)current.smethod_2<uint>(string_);
								pageFileInfo.MaxSize = (int)current.smethod_2<uint>(string_2);
								pageFileInfo.Name = current.smethod_1(string_3);
								PageFileInfo item = pageFileInfo;
								systemInfo_0.PageFiles.Add(item);
								num2 = 1;
								num3 = num2;
								break;
							}
							default:
								num2 = 3;
								num3 = num2;
								break;
							case 2:
								return;
							}
						}
					}
					finally
					{
						num2 = -1030;
						int num4 = num2;
						num2 = -1030;
						switch (num4 == num2)
						{
						default:
							if (0 == 0)
							{
							}
							num2 = 1;
							num3 = num2;
							goto IL_0291;
						case false:
						case true:
							{
								if (enumerator != null)
								{
									num2 = 2;
									num3 = num2;
									goto IL_0291;
								}
								break;
							}
							IL_0291:
							while (true)
							{
								switch (num3)
								{
								case 2:
									goto IL_027e;
								case 0:
									goto end_IL_0291;
								}
								goto case false;
								IL_027e:
								enumerator.Dispose();
								num2 = 0;
								num3 = num2;
								continue;
								end_IL_0291:
								break;
							}
							break;
						}
					}
				}
				break;
			}
		}
	}

	private static void smethod_6(SystemInfo systemInfo_0)
	{
		int num = 19;
		switch (0)
		{
		}
		ICollection<ManagementBaseObject> collection = "닡뻻닾뛳닱껺割嘕刧帬删嘳刼渚爺瘙爀縗爈瘙爜渚刳嘺刀帻刡嘹刾껛닆뛟닝뻐늞뚖닱껛튠횤튷\udeb0튦횀튷\uee9c\uf286\uf69f\uf291ﺟ\uf29e\uf6a4\uf297\uee9d튽횺튧\udeaa튻횹튼꺂늒뛵닇뻌닀뛓닜껚刀嘳刴帬刷嘥刺渼爓瘂爗繒牒瘸爓渃刷噶刔希初嘛割껹닛뛘늁뺌닭뛠닛껊튷횹튑\udeb1튼횢튠\uee81\uf29e\uf69a\uf297ﺌ".smethod_0();
		ScreenInfo screen = default(ScreenInfo);
		IEnumerator<ManagementBaseObject> enumerator = collection.GetEnumerator();
		try
		{
			int num2 = 0;
			int num3 = num2;
			ManagementBaseObject current = default(ManagementBaseObject);
			while (true)
			{
				switch (num3)
				{
				case 6:
					screen.Width = (screen.Width ?? 0) + (int)current.smethod_2<uint>("닱뻋닀뛄닗껀刦嘞刽帬刻嘬刽渀爆瘗爞縬爗瘅爝渂刧嘢刻帱刼");
					screen.RefreshRate = (int)current.smethod_2<uint>("닱뻋닀뛄닗껀刦嘄刷常删嘳刡渆爠瘗爆縛");
					screen.Name = current.smethod_1("닼뻟닟뛓");
					num2 = 4;
					num3 = num2;
					continue;
				case 5:
					screen.Height = (screen.Height ?? 0) + (int)current.smethod_2<uint>("닱뻋닀뛄닗껀刦嘀刷帬刦嘿刱渏爞瘤爗縍爝瘚爇渚刻嘹刼");
					num2 = 6;
					num3 = num2;
					continue;
				default:
					num2 = 2;
					num3 = num2;
					continue;
				case 2:
					if (!enumerator.MoveNext())
					{
						if (1 == 0)
						{
						}
						num2 = 1;
						num3 = num2;
					}
					else
					{
						current = enumerator.Current;
						num2 = 5;
						num3 = num2;
					}
					continue;
				case 1:
					num2 = 3;
					num3 = num2;
					continue;
				case 3:
					break;
				}
				break;
			}
		}
		finally
		{
			int num2 = 31993;
			int num4 = num2;
			num2 = 31993;
			int num3;
			switch (num4 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				num2 = 1;
				num3 = num2;
				goto IL_0207;
			case false:
			case true:
				{
					if (enumerator != null)
					{
						num2 = 2;
						num3 = num2;
						goto IL_0207;
					}
					break;
				}
				IL_0207:
				while (true)
				{
					switch (num3)
					{
					case 2:
						goto IL_01f5;
					case 0:
						goto end_IL_0207;
					}
					goto case false;
					IL_01f5:
					enumerator.Dispose();
					num2 = 0;
					num3 = num2;
					continue;
					end_IL_0207:
					break;
				}
				break;
			}
		}
		systemInfo_0.Screen = screen;
	}

	private static void smethod_7(SystemInfo systemInfo_0)
	{
		int num = 10;
		while (true)
		{
			ManagementBaseObject val = "횁틫껾닳뛱닪뺒답뛇닜긠刳嘼刪帜刣嘿刌渗爄瘽爘縱爙瘞爁渠別噾剾帖判嘻勘껗닄뛤닛뻀닅뛛닁꺼틺훲튟\udeb6튷횢튚\uee97\uf284\uf6a0\uf2bfﺿ\uf2da\uf6d2\uf2a0\ueeb3튻횷틾\ude94튄횝틣꺒닡뛛닐뺁늄뛭닸긻刲嘷刱帑刹嘼刚渀爙瘞爒縗爄".smethod_0().LastOrDefault();
			VideoInfo video = default(VideoInfo);
			int num2 = 1;
			int num3 = num2;
			while (true)
			{
				num2 = -26426;
				int num4 = num2;
				num2 = -26426;
				switch (num4 == num2)
				{
				default:
					if (0 == 0)
					{
					}
					switch (num3)
					{
					case 1:
						if (val != null)
						{
							num2 = 2;
							num3 = num2;
							continue;
						}
						goto IL_0119;
					case 2:
						video.Colors = (long)val.smethod_2<ulong>("횑틛껀닄뛗닐뻆닸뛇닃기刳嘠刑帴刕嘽刂渝爄瘁");
						video.Driver = val.smethod_1("횖틜껛닀뛗닌뻤닓뛀닝긻刹嘼");
						video.Memory = (int)(val.smethod_2<uint>("횓틊껓닆뛆닛뻀다뛳닣") / 1048576u);
						video.Name = val.smethod_1("횜틏껟닓");
						num2 = 0;
						num3 = num2;
						continue;
					case 0:
						{
							if (true)
							{
							}
							goto IL_0119;
						}
						IL_0119:
						systemInfo_0.Video = video;
						return;
					}
					break;
				case false:
				case true:
					break;
				}
				break;
			}
		}
	}

	private static void smethod_8(SystemInfo systemInfo_0)
	{
		int num = 8;
		switch (0)
		{
		}
		TerminalServicesInfo terminalServices = default(TerminalServicesInfo);
		while (true)
		{
			string string_ = "튅횗틢껷답뛦늞뻳닚뛞닁긥刂嘁初帽券嘼刋渑爂瘛爑縜爅癞牎渞刿嘱刻帼別嘻勀껕닸뛓닓뻗늚뚒닺꺷튤횿튷\udebc튷횾튽\uee97\uf284\uf684\uf29bﺀ\uf2bb\uf69d\uf28a\ueeb7틶횔튌\ude9d튛훲틹껛님뚁늌뻭닢뛗닜긿刿嘼刿帾刅嘷刜渄爟瘑爛縡爓瘆爚渻券嘵";
			ManagementBaseObject val = string_.smethod_0().LastOrDefault();
			int num2 = 0;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 6:
					terminalServices = default(TerminalServicesInfo);
					goto IL_002d;
				case 5:
					val = string_.smethod_0("튤횽틁껆닪뛱닷뻿닠뚀닲긆刳嘠刳帻券嘳刂渡爓瘀爈縛爕瘗爝").LastOrDefault();
					num2 = 6;
					num3 = num2;
					continue;
				case 4:
					if (val != null)
					{
						if (1 == 0)
						{
						}
						num2 = 2;
						num3 = num2;
						continue;
					}
					goto case 3;
				case 2:
					terminalServices.ConnectionsAllowed = val.smethod_2<uint>("튗횾틂껝닁뛦닭뻱닙뛜닀긷刵嘦刷帽券嘡") == 1;
					terminalServices.Licensing = val.smethod_1("튚횻틍껗님뛁닗뻜닑뛼닏긿刳");
					num2 = 1;
					num3 = num2;
					continue;
				case 1:
				{
					terminalServices.Mode = (TerminalServicesMode?)val.smethod_2<uint?>("튂횷틜껟닟뛜닟뻞닥뛗닜긤刳嘠刓帽刲嘷");
					num2 = 19197;
					int num4 = num2;
					num2 = 19197;
					switch (num4 == num2)
					{
					case false:
					case true:
						break;
					default:
						if (0 == 0)
						{
						}
						num2 = 3;
						num3 = num2;
						continue;
					}
					goto IL_002d;
				}
				case 0:
					if (val == null)
					{
						num2 = 5;
						num3 = num2;
						continue;
					}
					goto case 6;
				case 3:
					{
						systemInfo_0.TerminalServices = terminalServices;
						return;
					}
					IL_002d:
					num2 = 4;
					num3 = num2;
					continue;
				}
				break;
			}
		}
	}

	private static void smethod_9(SystemInfo systemInfo_0)
	{
		int num = 0;
		while (true)
		{
			if (true)
			{
			}
			while (true)
			{
				IL_00a8:
				ManagementBaseObject val = "튅횗튒\ude97튕횆튎껿닗뛜닋뻔닗뛑닚긧判嘷刬幾剶嘂刜渝爒瘇爝縆爸瘓爃渷剶嘔刌帝创噲勹껛님뚁늌뻭닥뛝닛꺼튲횖튻\udea4튿횱튋".smethod_0().LastOrDefault();
				SoundInfo sound = default(SoundInfo);
				int num2 = 1;
				int num3 = num2;
				while (true)
				{
					num2 = 12213;
					int num4 = num2;
					num2 = 12213;
					switch (num4 == num2)
					{
					case false:
					case true:
						goto end_IL_0074;
					}
					if (0 == 0)
					{
					}
					switch (num3)
					{
					case 1:
						if (val != null)
						{
							num2 = 2;
							num3 = num2;
							continue;
						}
						goto case 0;
					case 2:
						sound.Manufacturer = val.smethod_1("튛횳튰\udea7튰횳틍껆닃뛀닛뻀");
						sound.Model = val.smethod_1("튆횠튱\udeb6튣횱틚껼닗뛟닛");
						num2 = 0;
						num3 = num2;
						continue;
					case 0:
						systemInfo_0.Sound = sound;
						return;
					}
					goto IL_00a8;
					continue;
					end_IL_0074:
					break;
				}
				break;
			}
		}
	}

	private static void smethod_10(SystemInfo systemInfo_0)
	{
		int num = 8;
		while (true)
		{
			ManagementBaseObject val = "튅횗틢껷답뛦늞뻿닙뛖닋긾剺噲刚帷删嘻刍渗爢瘋爎縗牖瘴爼渝创噲刉帻券噡劜껭닦뛽닪뻡닻뛝닊꺷튻".smethod_0().LastOrDefault();
			ModemInfo modem = default(ModemInfo);
			int num2 = 1;
			int num3 = num2;
			while (true)
			{
				num2 = -2472;
				int num4 = num2;
				num2 = -2472;
				switch (num4 == num2)
				{
				default:
					if (0 == 0)
					{
					}
					switch (num3)
					{
					case 1:
						if (1 == 0)
						{
						}
						if (val != null)
						{
							num2 = 2;
							num3 = num2;
							continue;
						}
						goto case 0;
					case 2:
						modem.Model = val.smethod_1("튛횽틊껗닚");
						modem.Type = val.smethod_1("튒횷틘껛닕뛗닪뻋닆뛗");
						num2 = 0;
						num3 = num2;
						continue;
					case 0:
						systemInfo_0.Modem = modem;
						return;
					}
					break;
				case false:
				case true:
					break;
				}
				break;
			}
		}
	}

	private static string smethod_11(int int_0)
	{
		int num = 0;
		while (true)
		{
			string result = "튃횼튵\udebc특횥틀";
			int num2 = 1;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 8:
					result = "튃횼튵\udebc특횥틀";
					num2 = 3;
					num3 = num2;
					continue;
				case 2:
					num2 = 8;
					num3 = num2;
					continue;
				case 1:
					switch (int_0)
					{
					default:
						num2 = 2;
						num3 = num2;
						break;
					case 0:
						result = "튃횼튵\udebc특횥틀";
						num2 = 6;
						num3 = num2;
						break;
					case 1:
						result = "튐횧튲\udebe틶횂틁껅닓뛀";
						num2 = 5;
						num3 = num2;
						break;
					case 2:
						result = "튆횽튩\udeb7튤훲틽껓닀뛗늞뺟늖뛾닁긥剶嘂刱帥刳嘠剎渿爙瘖爛";
						num2 = 7;
						num3 = num2;
						break;
					case 3:
						result = "튆횽튩\udeb7튤훲틽껓닀뛗늞뺟늖뛡닚긳券嘶刼師";
						num2 = 4;
						num3 = num2;
						break;
					case 4:
						result = "튆횽튩\udeb7튤훲틽껓닀뛗늞뺟늖뛧닀긹券嘽利帼";
						num2 = 10;
						num3 = num2;
						break;
					case 5:
						result = "튆횽튩\udeb7튤훲틭껋닕뛞닛";
						num2 = 9;
						num3 = num2;
						break;
					case 6:
						result = "튆횽튩\udeb7튤훲틡껔닐";
						num2 = 0;
						num3 = num2;
						break;
					case 7:
						if (1 == 0)
						{
						}
						result = "튆횽튩\udeb7튤훲틽껓닀뛗늞뺟늖뛥닏긠券嘻到帵";
						num2 = 11;
						num3 = num2;
						break;
					}
					continue;
				case 7:
				{
					num2 = -28945;
					int num4 = num2;
					num2 = -28945;
					switch (num4 == num2)
					{
					case false:
					case true:
						goto end_IL_013f;
					}
					if (false)
					{
					}
					goto case 0;
				}
				case 0:
				case 3:
				case 4:
				case 5:
				case 6:
				case 9:
				case 10:
				case 11:
					{
						return result;
					}
					end_IL_013f:
					break;
				}
				break;
			}
		}
	}

	private static string smethod_12(int int_0)
	{
		int num = 10;
		int num2 = 5754;
		int num3 = num2;
		num2 = 5754;
		string result;
		int num5;
		int num4 = default(int);
		switch (num3 == num2)
		{
		default:
			if (0 == 0)
			{
			}
			goto IL_016b;
		case false:
		case true:
			{
				result = "횂틜껛닛뛓닌뻋늖뛶닁긿刷嘻到干刕嘽刀渆爄瘝爒縞爓瘀";
				num2 = 2;
				num5 = num2;
				goto IL_004c;
			}
			IL_016b:
			result = "횇틀껙님뛝닉뻜";
			num4 = int_0;
			num2 = 0;
			num5 = num2;
			goto IL_004c;
			IL_004c:
			while (true)
			{
				switch (num5)
				{
				case 7:
					result = "횇틀껙님뛝닉뻜";
					num2 = 5;
					num5 = num2;
					continue;
				case 1:
					num2 = 7;
					num5 = num2;
					continue;
				case 0:
					break;
				default:
					goto end_IL_004c;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 8:
				case 9:
					return result;
				}
				if (1 == 0)
				{
				}
				switch (num4)
				{
				default:
					num2 = 1;
					num5 = num2;
					continue;
				case 0:
					result = "횁틚껓님뛖닟뻞닙뛜닋깲刁嘽刬帹別嘦刏渆爟瘝爐";
					num2 = 9;
					num5 = num2;
					continue;
				case 1:
					result = "횟틋껟닔뛗닌뺒닡뛝닜긹別嘦刿带刿嘽刀";
					num2 = 6;
					num5 = num2;
					continue;
				case 2:
					result = "횁틚껓님뛖닟뻞닙뛜닋깲刅嘷刬帤刳嘠";
					num2 = 3;
					num5 = num2;
					continue;
				case 3:
					result = "횟틋껟닔뛗닌뺒닥뛗닜긤刳嘠";
					num2 = 4;
					num5 = num2;
					continue;
				case 4:
					result = "횐틏껑닝뛇닎뺒닲뛝닃긳刿嘼剾帑刹嘼刚渀爙瘞爒縗爄";
					num2 = 8;
					num5 = num2;
					continue;
				case 5:
					break;
				}
				goto case false;
				continue;
				end_IL_004c:
				break;
			}
			goto IL_016b;
		}
	}

	[CompilerGenerated]
	private static bool smethod_13(UnicastIPAddressInformation unicastIPAddressInformation_0)
	{
		int num = 25660;
		int num2 = num;
		num = 25660;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return unicastIPAddressInformation_0.Address.AddressFamily == AddressFamily.InterNetwork;
		}
	}

	[CompilerGenerated]
	private static bool smethod_14(UnicastIPAddressInformation unicastIPAddressInformation_0)
	{
		int num = -26883;
		int num2 = num;
		num = -26883;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			return unicastIPAddressInformation_0.Address.AddressFamily == AddressFamily.InterNetworkV6;
		}
	}
}
