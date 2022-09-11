using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using PreEmptive.Analytics.Common.Utilities;

namespace PreEmptive.Analytics.Common;

public class OfflineStorageThread : MessageQueueProcessor, IQueueProcessor, IQueuePersister
{
	[CompilerGenerated]
	private sealed class Class17
	{
		public MessageBatch messageBatch_0;

		public bool method_0(MessageBatch messageBatch_1)
		{
			int num = 10758;
			int num2 = num;
			num = 10758;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return messageBatch_1.ID != messageBatch_0.ID;
			}
		}
	}

	private IQueueTransmitter iqueueTransmitter_0;

	private IOfflineDataStore iofflineDataStore_0;

	private IAttributeLimiter iattributeLimiter_0;

	public OfflineStorageThread(IOfflineDataStore offlineDataStore, IFlowController flowController, IQueueTransmitter transmitterThread, IAttributeLimiter attributeLimiter, ILogger logger, IAsyncProvider asyncprovider)
		: base(flowController, logger, asyncprovider)
	{
		iofflineDataStore_0 = offlineDataStore;
		iqueueTransmitter_0 = transmitterThread;
		iattributeLimiter_0 = attributeLimiter;
	}

	public override void ProcessBatch(MessageBatch batch)
	{
		int num = 10;
		switch (0)
		{
		}
		bool flag = default(bool);
		List<MessageBatch> list = default(List<MessageBatch>);
		List<MessageBatch>.Enumerator enumerator = default(List<MessageBatch>.Enumerator);
		while (true)
		{
			int num2 = 1;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 11:
					if (flag)
					{
						num2 = 0;
						num3 = num2;
					}
					else
					{
						batch.FailureCount++;
						num2 = 8;
						num3 = num2;
					}
					continue;
				case 10:
					if (list.All(delegate(MessageBatch messageBatch_1)
					{
						int num5 = 10758;
						int num6 = num5;
						num5 = 10758;
						switch (num6 == num5)
						{
						default:
							if (1 == 0)
							{
							}
							if (0 == 0)
							{
							}
							return messageBatch_1.ID != batch.ID;
						}
					}))
					{
						num2 = 9;
						num3 = num2;
						continue;
					}
					goto case 5;
				case 5:
					enumerator = list.GetEnumerator();
					num2 = 12;
					num3 = num2;
					continue;
				case 9:
					iofflineDataStore_0.ClearBatch(batch);
					num2 = 5;
					num3 = num2;
					continue;
				case 8:
					if (flowController.SupportOfflineStorage)
					{
						num2 = 3;
						num3 = num2;
						continue;
					}
					if (1 == 0)
					{
					}
					base.Running = false;
					return;
				case 6:
					if (flowController.BatchHasExpired(batch))
					{
						num2 = 4;
						num3 = num2;
					}
					else
					{
						list = method_2(batch);
						num2 = 10;
						num3 = num2;
					}
					continue;
				case 4:
				{
					num2 = -17748;
					int num4 = num2;
					num2 = -17748;
					switch (num4 == num2)
					{
					case false:
					case true:
						break;
					default:
						if (0 == 0)
						{
						}
						logger.LogWarning("횆틜껓님뛁닓뻛닅뛁닇긽券噲刱帴剶嘦分渗牖瘐爟縆爕瘚牎渺刷嘡剾帴刷嘻勂껗닒뚒" + batch.FailureCount + "훲틚껛닛뛗닍뺒닗뛜닊깲刻嘷刻带別噲刚渚爓癒爝縀爟瘆爋渠刿嘳剾帴刹嘠劎껖닓뛞닛뻆닟뛝닀껼틶횆튶\udeb7틶횿튋\uee81\uf285\uf693\uf299ﺗ\uf2d6\uf685\uf287\ueebe튺훲튼\udeb7틶횶틋껞닓뛆닛뻖늘");
						iofflineDataStore_0.ClearBatch(batch);
						return;
					}
					goto case 5;
				}
				case 3:
					num2 = 6;
					num3 = num2;
					continue;
				case 2:
					flag = iqueueTransmitter_0.Transmit(batch);
					flowController.OnSend(flag);
					num2 = 11;
					num3 = num2;
					continue;
				case 1:
					if (flowController.OkToTransmit())
					{
						num2 = 2;
						num3 = num2;
						continue;
					}
					logger.LogInfo("횑틁껜닐뛛닙뻇닄뛓닚긻刹嘼剾帶刹嘷初湒爘瘝爊繒爆瘗爜渿刿嘦剾带刾嘷劎껁닓뛜닚뻛님뛕늎꺽튰훲튳\udeb7튥횡튏\uee95\uf293\uf681\uf2d0ﻒ\uf2b7\uf686\uf29a\ueeb7튻횢튪\udebb트횵튎껆닙뚒닝뻓닕뛚닋깲刻嘷刭帡刷嘵刋渁牘");
					SaveDataOffline(batch);
					num2 = 7;
					num3 = num2;
					continue;
				case 0:
					iofflineDataStore_0.ClearBatch(batch);
					return;
				case 12:
					try
					{
						num2 = 0;
						num3 = num2;
						while (true)
						{
							switch (num3)
							{
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num2 = 3;
									num3 = num2;
									break;
								}
								MessageBatch current = enumerator.Current;
								SaveDataOffline(current);
								num2 = 2;
								num3 = num2;
								break;
							}
							case 3:
								num2 = 1;
								num3 = num2;
								break;
							default:
								num2 = 4;
								num3 = num2;
								break;
							case 1:
								return;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
					}
				case 7:
					return;
				}
				break;
			}
		}
	}

	private List<MessageBatch> method_2(MessageBatch messageBatch_0, [Optional] List<MessageBatch> list_0)
	{
		int num = 7;
		switch (0)
		{
		default:
		{
			int num2 = 1;
			int num3 = num2;
			bool flag = default(bool);
			while (true)
			{
				List<MessageBatch> list;
				switch (num3)
				{
				case 8:
					list = new List<MessageBatch>();
					goto IL_0065;
				case 7:
				{
					if (messageBatch_0.Messages.Count <= 1)
					{
						num2 = 2;
						num3 = num2;
						break;
					}
					int count = messageBatch_0.Messages.Count / 2;
					List<Message> messages = messageBatch_0.Messages.Take(count).ToList();
					List<Message> messages2 = messageBatch_0.Messages.Skip(count).ToList();
					method_2(new MessageBatch(messageBatch_0.AgentInfo, messageBatch_0.Configuration, messages), list_0);
					method_2(new MessageBatch(messageBatch_0.AgentInfo, messageBatch_0.Configuration, messages2), list_0);
					num2 = 3;
					num3 = num2;
					break;
				}
				case 6:
					try
					{
						flag = messageBatch_0.ToString(iattributeLimiter_0).Length > flowController.MaximumBatchSize;
					}
					catch (OutOfMemoryException)
					{
						flag = true;
					}
					num2 = 4;
					num3 = num2;
					break;
				case 4:
					if (flag)
					{
						num2 = 0;
						num3 = num2;
					}
					else
					{
						list_0.Add(messageBatch_0);
						num2 = 5;
						num3 = num2;
					}
					break;
				default:
					list = list_0;
					if (list == null)
					{
						num2 = 8;
						num3 = num2;
						break;
					}
					goto IL_0065;
				case 0:
				{
					logger.LogInfo("튁횢튽껜닗뛒늒뻓닗뛅닁껏刵嘳割帼刳嘢刱渆牒瘁爛縊爚癖" + messageBatch_0.Messages.Count + "틲횻튷껝닁뛗닕뻛늚뛅늛꺎刻嘥割帪刽嘹割渂爓瘄爕縛牜癖爳渚刦嘳刿帮刦嘿刼껉늒뛂닝뺞닁뛆닞껇튦훶튦\udeb6튷훶튿\uee8b\uf281\uf685\uf293ﺙ\uf297\uf6d6\uf290\uee8f튦횵튺\udef0");
					if (1 == 0)
					{
					}
					num2 = -3951;
					int num4 = num2;
					num2 = -3951;
					switch (num4 == num2)
					{
					case false:
					case true:
						break;
					default:
						if (0 == 0)
						{
						}
						num2 = 7;
						num3 = num2;
						break;
					}
					break;
				}
				case 2:
					logger.LogWarning("튁횿튼껉닞뛓늒뻓닗뛅닁껏刵嘳割帷刡噶刦渁爝癖爞縟爀瘑爗湎刦嘹割帼刷噶刡껋닜뛂늜뺞닿뛓닁껝튳횱튷\udefe튥횿튾\uee82\uf2d2\uf694\uf297ﻞ\uf296\uf693\uf29e\uee8b튦횳튶\udef0");
					return list_0;
				case 3:
				case 5:
					{
						return list_0;
					}
					IL_0065:
					list_0 = list;
					flag = false;
					num2 = 6;
					num3 = num2;
					break;
				}
			}
		}
		}
	}

	public override MessageBatch GetMessageBatch()
	{
		int num = 11;
		int num2 = -3608;
		int num3 = num2;
		num2 = -3608;
		switch (num3 == num2)
		{
		default:
		{
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			logger.LogInfo("튀껋닆뛄닛뻛닄뛟닜껉割嘵刳帽刺嘳制湎爟瘓爁縍爓瘑爗湎到嘷刦帽刺噸");
			MessageBatch savedBatch = iofflineDataStore_0.GetSavedBatch();
			savedBatch.AgentInfo.AdditionalInfo = savedBatch.AgentInfo.AdditionalInfo + "틲껁닔뛐닞뻗닜뛓";
			return savedBatch;
		}
		}
	}

	public void SaveDataOffline(MessageBatch batch)
	{
		int num = 0;
		try
		{
			logger.LogInfo("튅횳튨\udebb트횵튎껟닓뛁닍뻓닑뛗늎기刷嘦刽帺剶嘥切渆爞癒" + batch.Messages.Count + "틶횿튻\udea1튥횳틉껗늞뛁늗뺒닂뛝늎긽到嘴刲帻券嘷剎渁爂瘝爌縓爑瘗牀");
			iofflineDataStore_0.SaveBatch(batch);
		}
		catch (OutOfMemoryException)
		{
			logger.LogWarning("튄횳튰\udef2특횧틚꺒닙뛔늞뻟닓뛟닁긠刯噲刭帳删嘻刀渕牖瘟爛縁爅瘓爉渷剶嘰刿带刵嘺劎껅닟뛆닖뺒" + batch.Messages.Count + "틶횿튻\udea1튥횳틉껗늞뛁늗뺓늖뛳닚긦刳嘿刮带刿嘼刉湒爂瘝牞縁爆瘞爇渦剶嘰刿带刵嘺劎껐닓뛔닑뻀닓뚒닝꺳튠횻튰\udeb5");
			MessageBatch[] array = batch.Split();
			if (array.Count() == 1)
			{
				int num2 = -27124;
				int num3 = num2;
				num2 = -27124;
				switch (num3 == num2)
				{
				default:
					if (0 == 0)
					{
					}
					logger.LogError("튔횳튪\udeb1튾훲틍껝님뛆닟뻛님뛗닊깲刷噲刳帷別嘡刏渕爓癒爊縝爙癒爂渳判嘵刻干刢嘽劎껁닓뛀닗뻓닚뛛닔꺷틸훲튚\udea0특횢튞\uee9b\uf298\uf695\uf2deﺟ\uf293\uf681\uf29d\ueeb3튱횷");
					goto end_IL_0044;
				case false:
				case true:
					break;
				}
			}
			SaveDataOffline(array[0]);
			SaveDataOffline(array[1]);
			end_IL_0044:;
		}
		catch (Exception ex2)
		{
			logger.LogError("튙횴트\udebe튿횼틋꺒닅뛆닑뻀닗뛕닋깲刢嘺刬帷刡噲刏渜牖瘇爐縗爎瘂爋渱刢嘷刺干刳嘠勜껝닄뚒닊뻀닏뛛닀꺵틶횦튱\udef2튥횳튘\uee97\uf2d6\uf693\uf2deﺟ\uf293\uf681\uf29d\ueeb3튱횷틾\udeb0튷횦틍껚늌뚒늙" + ex2.Message + "틱");
		}
		if (true)
		{
		}
	}
}
