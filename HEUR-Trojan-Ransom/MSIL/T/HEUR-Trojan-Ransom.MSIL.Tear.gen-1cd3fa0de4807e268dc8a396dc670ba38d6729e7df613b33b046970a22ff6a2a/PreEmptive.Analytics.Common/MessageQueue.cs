using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using PreEmptive.Analytics.Common.Messages;
using PreEmptive.Analytics.Common.Utilities;

namespace PreEmptive.Analytics.Common;

public class MessageQueue : IMessageDequeuer, IMessageQueue
{
	private IQueueTransmitter iqueueTransmitter_0;

	private IQueuePersister iqueuePersister_0;

	private bool bool_0;

	internal IFlowController iflowController_0;

	private IClientToolsProvider iclientToolsProvider_0;

	private IFlowController iflowController_1;

	private object object_0;

	[CompilerGenerated]
	private IList<Message> ilist_0;

	[CompilerGenerated]
	private bool bool_1;

	protected IList<Message> Messages
	{
		[CompilerGenerated]
		get
		{
			int num = 17798;
			int num2 = num;
			num = 17798;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return ilist_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 915;
			int num2 = num;
			num = 915;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			ilist_0 = value;
		}
	}

	public bool Stopped
	{
		[CompilerGenerated]
		get
		{
			if (1 == 0)
			{
			}
			int num = -13716;
			int num2 = num;
			num = -13716;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				return bool_1;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -5698;
			int num2 = num;
			num = -5698;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			bool_1 = value;
		}
	}

	public virtual IQueueTransmitter TransmitterThread
	{
		get
		{
			int num = 11;
			int num2 = 5;
			int num3 = num2;
			AgentInfo agentInfo = default(AgentInfo);
			AgentInfo agentInfo2 = default(AgentInfo);
			while (true)
			{
				AgentInfo agentInfo3;
				switch (num3)
				{
				default:
				{
					if (1 == 0)
					{
					}
					num2 = -3978;
					int num4 = num2;
					num2 = -3978;
					switch (num4 == num2)
					{
					case false:
					case true:
						goto IL_00a0;
					}
					if (0 == 0)
					{
					}
					if (iqueueTransmitter_0 == null)
					{
						num2 = 3;
						num3 = num2;
						continue;
					}
					break;
				}
				case 4:
					agentInfo3 = agentInfo;
					if (agentInfo3 == null)
					{
						agentInfo2 = new AgentInfo();
						agentInfo2.Name = "튂껯닱뛚닛뻛닜뛂";
						agentInfo2.Version = "틢꺀늂";
						agentInfo2.AdditionalInfo = "튗껜닀뛙닀";
						goto IL_00a0;
					}
					goto IL_00e2;
				case 3:
					agentInfo = null;
					num2 = 0;
					num3 = num2;
					continue;
				case 2:
					agentInfo3 = agentInfo2;
					goto IL_00e2;
				case 0:
					try
					{
						agentInfo = iclientToolsProvider_0.Platform.GetAgentInfo();
					}
					catch
					{
					}
					num2 = 4;
					num3 = num2;
					continue;
				case 1:
					break;
					IL_00a0:
					num2 = 2;
					num3 = num2;
					continue;
					IL_00e2:
					agentInfo = agentInfo3;
					iqueueTransmitter_0 = new TransmitterThread(agentInfo, this, iflowController_1, iclientToolsProvider_0);
					num2 = 1;
					num3 = num2;
					continue;
				}
				break;
			}
			return iqueueTransmitter_0;
		}
	}

	public virtual IQueuePersister OfflineStorageThread
	{
		get
		{
			int num = 5;
			int num2 = 5;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				default:
					if (iclientToolsProvider_0.Configuration.SupportOfflineStorage)
					{
						num2 = 3;
						num3 = num2;
						continue;
					}
					break;
				case 3:
					num2 = 1;
					num3 = num2;
					continue;
				case 2:
					num2 = 0;
					num3 = num2;
					continue;
				case 1:
					if (iqueuePersister_0 == null)
					{
						num2 = 2;
						num3 = num2;
						continue;
					}
					break;
				case 0:
					if (1 == 0)
					{
					}
					if (!bool_0)
					{
						num2 = 4;
						num3 = num2;
						continue;
					}
					break;
				case 4:
					try
					{
						while (true)
						{
							IL_01bf:
							iflowController_0 = iflowController_1.Copy();
							IOfflineDataStore offlineDataStore = iclientToolsProvider_0.Platform.GetOfflineDataStore();
							num2 = 3;
							num3 = num2;
							while (true)
							{
								switch (num3)
								{
								case 3:
									if (offlineDataStore != null)
									{
										num2 = 31653;
										int num4 = num2;
										num2 = 31653;
										switch (num4 == num2)
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
									}
									goto case 0;
								case 0:
									num2 = 1;
									num3 = num2;
									continue;
								case 2:
									iqueuePersister_0 = new OfflineStorageThread(iclientToolsProvider_0.Platform.GetOfflineDataStore(), iflowController_0, TransmitterThread, iclientToolsProvider_0.Configuration.AttributeLimiter, iclientToolsProvider_0.Logger, iclientToolsProvider_0.Platform);
									TransmitterThread.TransmissionFailed += OfflineStorageThread.SaveDataOffline;
									num2 = 0;
									num3 = num2;
									continue;
								case 1:
									goto end_IL_01a9;
								}
								goto IL_01bf;
								continue;
								end_IL_01a9:
								break;
							}
							break;
						}
					}
					catch (Exception exception_)
					{
						iclientToolsProvider_0.Logger.LogException(exception_, "\ude9f튼훶튧껀닗뛎닂뻛닑뛂닗껊割嘳刪帽刷嘦刦渇爝瘘牒縑爑瘕爇渜刷嘲");
						iclientToolsProvider_0.Logger.LogError("\ude91튴횰튾껇닜뛓닡뻊닝뛄닓껉刷噶刱帱刧嘺制湎爜瘙爆繞爐瘓牒渇刼嘿刦帷刳嘺刻껔닗뛒늜");
						bool_0 = true;
					}
					break;
				}
				break;
			}
			return iqueuePersister_0;
		}
	}

	public MessageQueue(IClientToolsProvider client, IFlowController flowController)
	{
		iclientToolsProvider_0 = client;
		iflowController_1 = flowController;
		Stopped = false;
		Messages = new List<Message>();
		object_0 = new object();
	}

	public virtual void Start()
	{
		int num = 9;
		bool lockTaken = false;
		object obj = default(object);
		try
		{
			while (true)
			{
				IL_0159:
				Monitor.Enter(obj = object_0, ref lockTaken);
				int num2 = 3;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 10:
						TransmitterThread.Start();
						iclientToolsProvider_0.Logger.LogInfo("횂튺껋늒뛂닀뻟닜뛅닟껇刦嘢刷帬割嘢刺渜爗瘗爖繞爚瘗爁湎到嘳刷帰割嘥刦껏닀뛂닗뻚늜");
						num2 = 5;
						num3 = num2;
						continue;
					case 9:
						num2 = 8;
						num3 = num2;
						continue;
					case 7:
						num2 = 1;
						num3 = num2;
						continue;
					case 6:
						if (!Stopped)
						{
							num2 = 7;
							num3 = num2;
							continue;
						}
						goto case 9;
					case 5:
						num2 = 6;
						num3 = num2;
						continue;
					case 4:
						if (TransmitterThread != null)
						{
							num2 = 10;
							num3 = num2;
							continue;
						}
						goto case 5;
					case 3:
						if (!Stopped)
						{
							num2 = 0;
							num3 = num2;
							continue;
						}
						goto case 5;
					case 2:
						OfflineStorageThread.Start();
						iclientToolsProvider_0.Logger.LogInfo("횂튺껋늒뛙닔뻘닞뛟닜껋割嘥刦帱删嘷刵渋牒瘂爚縌爗瘗爖湎刺嘷刡幾到嘳刷껀늒뛅닆뻟닀뛂닗껊틼");
						num2 = 9;
						num3 = num2;
						continue;
					case 1:
						if (OfflineStorageThread != null)
						{
							num2 = 2;
							num3 = num2;
							continue;
						}
						goto case 9;
					case 0:
						num2 = 4;
						num3 = num2;
						continue;
					case 8:
						goto end_IL_0127;
					}
					goto IL_0159;
					continue;
					end_IL_0127:
					break;
				}
				break;
			}
		}
		finally
		{
			int num2 = 1;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 2:
				{
					num2 = 28437;
					int num4 = num2;
					num2 = 28437;
					switch (num4 == num2)
					{
					default:
						if (0 == 0)
						{
						}
						Monitor.Exit(obj);
						num2 = 0;
						num3 = num2;
						continue;
					case false:
					case true:
						break;
					}
					break;
				}
				default:
					if (lockTaken)
					{
						num2 = 2;
						num3 = num2;
						continue;
					}
					break;
				case 0:
					break;
				}
				break;
			}
		}
		if (true)
		{
		}
	}

	public virtual void Stop()
	{
		int num = 0;
		bool flag = default(bool);
		object obj = default(object);
		while (true)
		{
			bool lockTaken = false;
			int num2 = 2;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 3:
					if (flag)
					{
						num2 = 0;
						num3 = num2;
						continue;
					}
					goto case 1;
				case 2:
					try
					{
						Monitor.Enter(obj = object_0, ref lockTaken);
						flag = !Stopped;
					}
					finally
					{
						num2 = 1;
						num3 = num2;
						while (true)
						{
							switch (num3)
							{
							case 2:
							{
								num2 = 22076;
								int num4 = num2;
								num2 = 22076;
								switch (num4 == num2)
								{
								default:
									if (0 == 0)
									{
									}
									Monitor.Exit(obj);
									num2 = 0;
									num3 = num2;
									continue;
								case false:
								case true:
									break;
								}
								break;
							}
							default:
								if (lockTaken)
								{
									num2 = 2;
									num3 = num2;
									continue;
								}
								break;
							case 0:
								break;
							}
							break;
						}
					}
					num2 = 3;
					num3 = num2;
					continue;
				case 0:
					iclientToolsProvider_0.Logger.LogInfo("튅횦튱\udea2튦횻틀껕늖뛽님뻔닚뛛닀긷剶嘁刪帽判嘳刉渗牖瘓爐縖牙瘝爜湲刂嘠刿帼別嘿勇껆닂뛗닌뺒닂뛚닜꺷튷횶튭");
					method_1();
					Stopped = true;
					if (1 == 0)
					{
					}
					num2 = 1;
					num3 = num2;
					continue;
				case 1:
					iclientToolsProvider_0.Logger.LogInfo("튂횺튻\udef2튻횷틝껁닗뛕닛뺒닇뛇닋긧刳噲制帳別噲刌渗爓瘜牞縁爂瘝爞渢刳嘶剰");
					return;
				}
				break;
			}
		}
	}

	private void method_1()
	{
		int num = 12;
		switch (0)
		{
		}
		Timer timer = default(Timer);
		int num5 = default(int);
		int num8 = default(int);
		int? neededTimeForSavingAtStop = default(int?);
		while (true)
		{
			TimerCallback timerCallback = null;
			int? stopTimeout = iclientToolsProvider_0.Configuration.StopBehavior.StopTimeout;
			int num2 = 4;
			int num3 = num2;
			while (true)
			{
				int num7;
				int num6;
				switch (num3)
				{
				case 11:
					num2 = 8;
					num3 = num2;
					continue;
				case 10:
					num7 = 1;
					goto IL_003b;
				case 9:
					timer = new Timer(timerCallback, null, num5 - num8, -1);
					num2 = 7;
					num3 = num2;
					continue;
				case 8:
					num6 = num5;
					goto IL_008a;
				case 6:
					num6 = neededTimeForSavingAtStop.GetValueOrDefault();
					goto IL_008a;
				case 5:
					if (!neededTimeForSavingAtStop.HasValue)
					{
						num2 = 11;
						num3 = num2;
					}
					else
					{
						num2 = 6;
						num3 = num2;
					}
					continue;
				case 4:
					if (!stopTimeout.HasValue)
					{
						num2 = 3;
						num3 = num2;
					}
					else
					{
						num2 = 1;
						num3 = num2;
					}
					continue;
				case 3:
					num2 = 10;
					num3 = num2;
					continue;
				case 2:
					if (timerCallback == null)
					{
						num2 = 0;
						num3 = num2;
						continue;
					}
					goto case 9;
				case 1:
					num7 = stopTimeout.GetValueOrDefault();
					goto IL_003b;
				case 0:
					timerCallback = delegate
					{
						int num9 = 2;
						int num10 = num9;
						while (true)
						{
							num9 = -28532;
							int num11 = num9;
							num9 = -28532;
							switch (num11 == num9)
							{
							case false:
							case true:
								TransmitterThread.FailTransmissionsNow();
								num9 = 3;
								num10 = num9;
								break;
							default:
								{
									if (0 == 0)
									{
									}
									switch (num10)
									{
									case 1:
										break;
									case 0:
										if (OfflineStorageThread == null)
										{
											return;
										}
										num9 = 1;
										num10 = num9;
										goto end_IL_00d3;
									case 2:
										if (true)
										{
										}
										goto default;
									default:
										if (!iclientToolsProvider_0.Configuration.SupportOfflineStorage)
										{
											return;
										}
										num9 = 4;
										num10 = num9;
										goto end_IL_00d3;
									case 4:
										num9 = 0;
										num10 = num9;
										goto end_IL_00d3;
									case 3:
										return;
									}
									goto case false;
								}
								end_IL_00d3:
								break;
							}
						}
					};
					if (1 == 0)
					{
					}
					num2 = 9;
					num3 = num2;
					continue;
				case 7:
					{
						try
						{
							num2 = 1;
							num3 = num2;
							while (true)
							{
								switch (num3)
								{
								case 6:
									OfflineStorageThread.Stop();
									iclientToolsProvider_0.Logger.LogInfo("틺껚닓뚒닑뻔닐뛞닇긼刳噲刭带刹嘠刏渕爓癒爊縚爄瘗爏渶剶嘺刿帡剶嘰勋껗님뚒닍뻆닙뛂닞꺷튲");
									num2 = 3;
									num3 = num2;
									break;
								case 5:
									TransmitterThread.Stop();
									iclientToolsProvider_0.Logger.LogInfo("틺껚닓뚒닊뻀닗뛜닝긿刿嘦刪帷判噲刚渚爄瘗爟縖牖瘚爏渡剶嘰刻帷券噲勝껆닙뛂닎뻗닒");
									num2 = 2;
									num3 = num2;
									break;
								case 4:
									if (OfflineStorageThread != null)
									{
										num2 = 6;
										num3 = num2;
										break;
									}
									goto case 3;
								case 3:
									num2 = 0;
									num3 = num2;
									break;
								case 2:
									num2 = 4;
									num3 = num2;
									break;
								default:
									if (TransmitterThread != null)
									{
										num2 = 5;
										num3 = num2;
										break;
									}
									goto case 2;
								case 0:
									return;
								}
							}
						}
						finally
						{
							num2 = 1;
							num3 = num2;
							while (true)
							{
								switch (num3)
								{
								case 2:
								{
									num2 = -421;
									int num4 = num2;
									num2 = -421;
									switch (num4 == num2)
									{
									default:
										if (0 == 0)
										{
										}
										((IDisposable)timer).Dispose();
										num2 = 0;
										num3 = num2;
										continue;
									case false:
									case true:
										break;
									}
									break;
								}
								default:
									if (timer != null)
									{
										num2 = 2;
										num3 = num2;
										continue;
									}
									break;
								case 0:
									break;
								}
								break;
							}
						}
					}
					IL_008a:
					num8 = num6;
					num2 = 2;
					num3 = num2;
					continue;
					IL_003b:
					num5 = num7;
					neededTimeForSavingAtStop = iclientToolsProvider_0.Configuration.StopBehavior.NeededTimeForSavingAtStop;
					num2 = 5;
					num3 = num2;
					continue;
				}
				break;
			}
		}
	}

	public virtual void Queue(Message message)
	{
		int num = 17;
		switch (0)
		{
		default:
		{
			if (1 == 0)
			{
			}
			bool lockTaken = false;
			object obj = default(object);
			try
			{
				int num4 = default(int);
				int num5 = default(int);
				while (true)
				{
					Monitor.Enter(obj = object_0, ref lockTaken);
					int num2 = 11;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 18:
							iclientToolsProvider_0.Logger.LogWarning(string.Format("뛧닇뻛닇뛓늒껆刳嘥割帱判嘳删済爞瘙爅縛爖癘牒渕剢嘫割帳刷嘥刡껏닕뛓늚뻍늛뚖닚껏튤횳틲\udebc튷횳튼\ueece\uf296\uf684\uf29dﺎ\uf282\uf693\uf296\ueec0", new object[1] { num4 }));
							num2 = 12;
							num3 = num2;
							continue;
						case 17:
							TransmitterThread.ProcessQueueNow();
							num2 = 16;
							num3 = num2;
							continue;
						case 16:
							num2 = 6;
							num3 = num2;
							continue;
						case 15:
							num2 = 0;
							num3 = num2;
							continue;
						case 14:
							num2 = 5;
							num3 = num2;
							continue;
						case 8:
						case 13:
							num2 = 1;
							num3 = num2;
							continue;
						case 12:
							num2 = 4;
							num3 = num2;
							continue;
						case 11:
							if (!Stopped)
							{
								num2 = 9;
								num3 = num2;
								continue;
							}
							goto case 16;
						case 10:
							Messages.Add(message);
							iclientToolsProvider_0.Logger.LogInfo(string.Format("뛷늚뻐늛뚖닉꺞刯噶刿帻刡嘥刳渉爗癖爚縟爁癖爐渋刷嘸割帿制嘲刷껊늒뛂닝뺞닆뛞닗꺎튿횳튡\udead튳횱튷\ueece\uf283\uf683\uf297ﺋ\uf297\uf6d8", new object[1] { message.TagDescription }));
							num4 = iflowController_1.MessagesToDrop(Messages.Count);
							num5 = 0;
							num2 = 13;
							num3 = num2;
							continue;
						case 9:
							num2 = 7;
							num3 = num2;
							continue;
						case 7:
							if (iclientToolsProvider_0.Configuration != null)
							{
								num2 = 3;
								num3 = num2;
								continue;
							}
							goto case 15;
						case 5:
							if (num4 > 0)
							{
								num2 = 18;
								num3 = num2;
								continue;
							}
							goto case 12;
						case 4:
							if (iflowController_1.ShouldSendNow(Messages.Count))
							{
								num2 = 17;
								num3 = num2;
								continue;
							}
							goto case 16;
						case 3:
							num2 = 2;
							num3 = num2;
							continue;
						case 2:
							if (!iclientToolsProvider_0.Configuration.OptIn)
							{
								num2 = 15;
								num3 = num2;
								continue;
							}
							goto case 10;
						case 1:
							if (num5 >= num4)
							{
								num2 = 14;
								num3 = num2;
								continue;
							}
							Messages.RemoveAt(0);
							num5++;
							num2 = 8;
							num3 = num2;
							continue;
						case 0:
							if (message is ApplicationStop)
							{
								num2 = 10;
								num3 = num2;
								continue;
							}
							goto case 16;
						case 6:
							return;
						}
						break;
					}
				}
			}
			finally
			{
				int num2 = 1;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 2:
					{
						num2 = -3879;
						int num6 = num2;
						num2 = -3879;
						switch (num6 == num2)
						{
						default:
							if (0 == 0)
							{
							}
							Monitor.Exit(obj);
							num2 = 0;
							num3 = num2;
							continue;
						case false:
						case true:
							break;
						}
						break;
					}
					default:
						if (lockTaken)
						{
							num2 = 2;
							num3 = num2;
							continue;
						}
						break;
					case 0:
						break;
					}
					break;
				}
			}
		}
		}
	}

	public virtual void SendDisabledChanged(bool stop)
	{
		int num = 3;
		bool lockTaken = false;
		object obj = default(object);
		try
		{
			while (true)
			{
				IL_0197:
				Monitor.Enter(obj = object_0, ref lockTaken);
				int num2 = 5;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 12:
						num2 = 1;
						num3 = num2;
						continue;
					case 11:
						iclientToolsProvider_0.Logger.LogInfo("튁\udebb튼횲튻껀닕뚖닟뻛닁뛅닓껉刷嘥割帶刳嘥割渌爗瘓爜繞爗瘘爓渌刾嘳制幾刳嘸制꺎닑뛙닜뻚닛뛂닛껁튼횥틲\udeb8튽횤틲\uee9d\uf297\uf698\uf296ﺗ\uf29c\uf691\uf2d2\uee83튷횥튡\udebf튵횳튡꺎닚뛗닄뻛늒뛔닗껋刼噶刿帻刦噸割港爆瘂爗縓爂瘂爛渀刵噶刦帱割嘥刷껀닖뚖닟뻛닁뛅닓껉튷횥틼");
						TransmitterThread.ProcessQueueNow();
						num2 = 7;
						num3 = num2;
						continue;
					case 9:
						num2 = 10;
						num3 = num2;
						continue;
					case 8:
						num2 = 2;
						num3 = num2;
						continue;
					case 7:
						num2 = 0;
						num3 = num2;
						continue;
					case 6:
						if (!stop)
						{
							num2 = 12;
							num3 = num2;
							continue;
						}
						goto case 7;
					case 5:
						if (!Stopped)
						{
							num2 = 4;
							num3 = num2;
							continue;
						}
						goto case 7;
					case 4:
						num2 = 6;
						num3 = num2;
						continue;
					case 3:
						iflowController_0.SendDisabled = stop;
						num2 = 9;
						num3 = num2;
						continue;
					case 2:
						if (stop != iflowController_0.SendDisabled)
						{
							num2 = 3;
							num3 = num2;
							continue;
						}
						goto case 9;
					case 1:
						if (iflowController_1.ShouldSendNow(Messages.Count))
						{
							num2 = 11;
							num3 = num2;
							continue;
						}
						goto case 7;
					case 0:
						if (iflowController_0 != null)
						{
							num2 = 8;
							num3 = num2;
							continue;
						}
						goto case 9;
					case 10:
						goto end_IL_015d;
					}
					goto IL_0197;
					continue;
					end_IL_015d:
					break;
				}
				break;
			}
		}
		finally
		{
			int num2 = 1;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 2:
				{
					num2 = -11803;
					int num4 = num2;
					num2 = -11803;
					switch (num4 == num2)
					{
					default:
						if (0 == 0)
						{
						}
						Monitor.Exit(obj);
						num2 = 0;
						num3 = num2;
						continue;
					case false:
					case true:
						break;
					}
					break;
				}
				default:
					if (lockTaken)
					{
						num2 = 2;
						num3 = num2;
						continue;
					}
					break;
				case 0:
					break;
				}
				break;
			}
		}
		if (true)
		{
		}
	}

	public virtual void SendMessages()
	{
		int num = 16;
		if (1 == 0)
		{
		}
		bool lockTaken = false;
		object obj = default(object);
		try
		{
			while (true)
			{
				Monitor.Enter(obj = object_0, ref lockTaken);
				int num2 = 2;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 3:
						iclientToolsProvider_0.Logger.LogInfo("닢뛚닛뺒닥뛗닀긶创嘷刭帡刷嘵刋渁牞癛牞縟爓瘆爆渽刲噲制帳別噲勌껗닓뛜늞뻑닗뛞닂꺷튲훼틾\ude93튢횦튋\uee9f\uf286\uf686\uf297ﺜ\uf291\uf6d2\uf29a\ueebd틶횡튻\udebc튲훲틃껗닅뛁닟뻕닓뛁늀");
						TransmitterThread.ProcessQueueNow();
						num2 = 0;
						num3 = num2;
						continue;
					case 2:
						if (!Stopped)
						{
							num2 = 3;
							num3 = num2;
							continue;
						}
						goto case 0;
					case 0:
						num2 = 1;
						num3 = num2;
						continue;
					case 1:
						return;
					}
					break;
				}
			}
		}
		finally
		{
			int num2 = 1;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 2:
				{
					num2 = 17488;
					int num4 = num2;
					num2 = 17488;
					switch (num4 == num2)
					{
					default:
						if (0 == 0)
						{
						}
						Monitor.Exit(obj);
						num2 = 0;
						num3 = num2;
						continue;
					case false:
					case true:
						break;
					}
					break;
				}
				default:
					if (lockTaken)
					{
						num2 = 2;
						num3 = num2;
						continue;
					}
					break;
				case 0:
					break;
				}
				break;
			}
		}
	}

	public virtual IList<Message> DequeueMessages()
	{
		if (1 == 0)
		{
		}
		switch (0)
		{
		default:
		{
			bool lockTaken = false;
			object obj = default(object);
			try
			{
				Monitor.Enter(obj = object_0, ref lockTaken);
				IList<Message> messages = Messages;
				Messages = new List<Message>();
				return messages;
			}
			finally
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
					{
						num = -28240;
						int num3 = num;
						num = -28240;
						switch (num3 == num)
						{
						default:
							if (0 == 0)
							{
							}
							Monitor.Exit(obj);
							num = 0;
							num2 = num;
							continue;
						case false:
						case true:
							break;
						}
						break;
					}
					default:
						if (lockTaken)
						{
							num = 2;
							num2 = num;
							continue;
						}
						break;
					case 0:
						break;
					}
					break;
				}
			}
		}
		}
	}

	public virtual IList<Message> PeekMessages()
	{
		if (1 == 0)
		{
		}
		bool lockTaken = false;
		object obj = default(object);
		try
		{
			Monitor.Enter(obj = object_0, ref lockTaken);
			return new List<Message>(Messages);
		}
		finally
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
				{
					num = 14047;
					int num3 = num;
					num = 14047;
					switch (num3 == num)
					{
					default:
						if (0 == 0)
						{
						}
						Monitor.Exit(obj);
						break;
					case false:
					case true:
						break;
					}
					num = 0;
					num2 = num;
					continue;
				}
				default:
					if (lockTaken)
					{
						num = 2;
						num2 = num;
						continue;
					}
					break;
				case 0:
					break;
				}
				break;
			}
		}
	}

	[CompilerGenerated]
	private void method_2(object object_1)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			num = -28532;
			int num3 = num;
			num = -28532;
			switch (num3 == num)
			{
			case false:
			case true:
				TransmitterThread.FailTransmissionsNow();
				num = 3;
				num2 = num;
				break;
			default:
				{
					if (0 == 0)
					{
					}
					switch (num2)
					{
					case 1:
						break;
					case 0:
						if (OfflineStorageThread != null)
						{
							num = 1;
							num2 = num;
							goto end_IL_00d3;
						}
						return;
					case 2:
						if (true)
						{
						}
						goto default;
					default:
						if (iclientToolsProvider_0.Configuration.SupportOfflineStorage)
						{
							num = 4;
							num2 = num;
							goto end_IL_00d3;
						}
						return;
					case 4:
						num = 0;
						num2 = num;
						goto end_IL_00d3;
					case 3:
						return;
					}
					goto case false;
				}
				end_IL_00d3:
				break;
			}
		}
	}
}
