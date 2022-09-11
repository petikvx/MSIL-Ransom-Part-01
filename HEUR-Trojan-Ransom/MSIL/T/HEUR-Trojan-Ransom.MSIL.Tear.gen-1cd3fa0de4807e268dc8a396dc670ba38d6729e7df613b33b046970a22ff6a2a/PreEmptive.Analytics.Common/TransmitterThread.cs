using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using PreEmptive.Analytics.Common.Tags;
using PreEmptive.Analytics.Common.Utilities;

namespace PreEmptive.Analytics.Common;

public class TransmitterThread : MessageQueueProcessor, IQueueProcessor, IQueueTransmitter
{
	private class Class21 : IXMLTransmitter
	{
		public bool Post(IEnumerable<KeyValuePair<string, string>> headers, string data)
		{
			int num = -4289;
			int num2 = num;
			num = -4289;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return false;
			}
		}
	}

	[CompilerGenerated]
	private sealed class Class22
	{
		public List<KeyValuePair<string, string>> list_0;

		public string string_0;

		public TransmitterThread transmitterThread_0;
	}

	[CompilerGenerated]
	private sealed class Class23
	{
		public Class22 class22_0;

		public bool bool_0;

		public object method_0()
		{
			int num = 5;
			if (1 == 0)
			{
			}
			int num2 = -21256;
			int num3 = num2;
			num2 = -21256;
			switch (num3 == num2)
			{
			default:
				if (0 == 0)
				{
				}
				class22_0.transmitterThread_0.logger.LogInfo("\ude9f튦횢튷껃닂뛂닛뻐닕뚖닆껁割嘢删帿刼嘥刿渇爆癖爟縛爁瘅爓渉刷噶到帿刦嘵刺꺀");
				bool_0 = class22_0.transmitterThread_0.ixmltransmitter_0.Post(class22_0.list_0, class22_0.string_0);
				class22_0.transmitterThread_0.manualResetEvent_0.Set();
				return null;
			}
		}
	}

	private IXMLTransmitter ixmltransmitter_0;

	private AgentInfo agentInfo_0;

	private IConfigurationProvider iconfigurationProvider_0;

	private IMessageDequeuer imessageDequeuer_0;

	private IPlatform iplatform_0;

	private Action<MessageBatch> action_0;

	private AutoResetEvent autoResetEvent_1;

	private object object_2;

	private volatile bool bool_2;

	private ManualResetEvent manualResetEvent_0;

	[CompilerGenerated]
	private static Func<string, string> func_0;

	public event Action<MessageBatch> TransmissionFailed
	{
		add
		{
			Action<MessageBatch> action2 = default(Action<MessageBatch>);
			while (true)
			{
				if (true)
				{
				}
				Action<MessageBatch> action = action_0;
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
					{
						num = -9698;
						int num3 = num;
						num = -9698;
						switch (num3 == num)
						{
						case false:
						case true:
							continue;
						}
						if (false)
						{
						}
						return;
					}
					case 1:
					{
						action2 = action;
						Action<MessageBatch> value2 = (Action<MessageBatch>)Delegate.Combine(action2, value);
						action = Interlocked.CompareExchange(ref action_0, value2, action2);
						num = 0;
						num2 = num;
						continue;
					}
					case 0:
						if ((object)action == action2)
						{
							num = 2;
							num2 = num;
							continue;
						}
						goto case 1;
					}
					break;
				}
			}
		}
		remove
		{
			Action<MessageBatch> action2 = default(Action<MessageBatch>);
			while (true)
			{
				Action<MessageBatch> action = action_0;
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
					{
						num = -11350;
						int num3 = num;
						num = -11350;
						switch (num3 == num)
						{
						case false:
						case true:
							continue;
						}
						if (1 == 0)
						{
						}
						if (false)
						{
						}
						return;
					}
					case 1:
					{
						action2 = action;
						Action<MessageBatch> value2 = (Action<MessageBatch>)Delegate.Remove(action2, value);
						action = Interlocked.CompareExchange(ref action_0, value2, action2);
						num = 0;
						num2 = num;
						continue;
					}
					case 0:
						if ((object)action == action2)
						{
							num = 2;
							num2 = num;
							continue;
						}
						goto case 1;
					}
					break;
				}
			}
		}
	}

	public TransmitterThread(AgentInfo info, IMessageDequeuer dequeuer, IFlowController flowController, IClientToolsProvider tools)
	{
		int num = 8;
		autoResetEvent_1 = new AutoResetEvent(initialState: true);
		object_2 = new object();
		manualResetEvent_0 = new ManualResetEvent(initialState: false);
		base._002Ector(flowController, tools.Logger, tools.Platform);
		try
		{
			ixmltransmitter_0 = tools.Platform.CreateXMLTransmitter();
		}
		catch (Exception exception_)
		{
			tools.Logger.LogException(exception_, "튗횼튎껇님뛗닆뻂닓뛑닚긷刲噲刻帪刵嘷刞渆爟瘝爐繒爙瘑爍渧判嘷刺");
			tools.Logger.LogError("튓횠틜껝닄뚒닗뻜닟뛆닇긳刺嘻判帻券嘵剎渪爻瘾牞縦爄瘓爀渡刻嘻刪带刳嘠劀꺒닻뛗닍뻁닗뛕닋꺡틶횱튿\udebc틶횼튁\uee86\uf2d6\uf690\uf29bﻒ\uf282\uf680\uf28f\ueebc튥횿튷\udea6튢횷틊꺓");
		}
		ixmltransmitter_0 = ixmltransmitter_0 ?? new Class21();
		iconfigurationProvider_0 = tools;
		agentInfo_0 = info;
		imessageDequeuer_0 = dequeuer;
		iplatform_0 = tools.Platform;
	}

	public override void Start()
	{
		if (1 == 0)
		{
		}
		int num = -3858;
		int num2 = num;
		num = -3858;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		base.Start();
		bool_2 = false;
		autoResetEvent_1 = new AutoResetEvent(initialState: true);
	}

	public override void ProcessBatch(MessageBatch batch)
	{
		int num = 19;
		int num2 = 5;
		int num3 = num2;
		bool flag = default(bool);
		while (true)
		{
			switch (num3)
			{
			case 7:
			{
				num2 = -581;
				int num4 = num2;
				num2 = -581;
				switch (num4 == num2)
				{
				default:
					if (0 == 0)
					{
					}
					method_2(batch);
					num2 = 8;
					num3 = num2;
					goto end_IL_0171;
				case false:
				case true:
					break;
				}
				goto IL_0073;
			}
			case 6:
				flag = Transmit(batch);
				flowController.OnSend(flag);
				num2 = 1;
				num3 = num2;
				break;
			default:
				if (flowController.OkToTransmit())
				{
					num2 = 6;
					num3 = num2;
				}
				else
				{
					logger.LogWarning("닱뻑닜뛐닛껉刧嘤刳帪刻嘹刼湎爖瘙爗縍牒瘘爝渚割嘦刷帬刿嘿刦꺎닆뛞닗뺞닁뛓닜껊튻횸튵\udefe튽횰틲\uee83\uf297\uf685\uf281ﺟ\uf295\uf693\uf281\ueec0틲횛튷\udead튡횷튵껋닁뚖닅뻗닞뛚늒껀刽嘢割帼刷噶刡渋爜瘂牜");
					num2 = 2;
					num3 = num2;
				}
				break;
			case 4:
				if (flowController.SupportOfflineStorage)
				{
					goto IL_0073;
				}
				return;
			case 2:
				if (flowController.SupportOfflineStorage)
				{
					num2 = 7;
					num3 = num2;
					break;
				}
				return;
			case 1:
				if (!flag)
				{
					num2 = 0;
					num3 = num2;
					break;
				}
				logger.LogInfo("닦뻌닓뛘닁껃刻嘥刡帷刽嘸割渁爔癖爟縛爁瘅爓渉刷噶到帿刦嘵刺꺎닅뛟닆뻖늒" + batch.Messages.Count + "늒뻓닗뛅닁껏刵嘳剺席剻噶刺渏爁癖爁縋爑瘕爗渋制嘳制幰");
				return;
			case 0:
				logger.LogWarning("닦뻌닓뛘닁껃刻嘥刡帷刽嘸割渁爔癖爟縛爁瘅爓渉刷噶到帿刦嘵刺꺎닅뛟닆뻖늒" + batch.Messages.Count + "늒뻓닗뛅닁껏刵嘳剺席剻噶刺渏爁癖爔縟爛瘚爗渊剼");
				num2 = 4;
				num3 = num2;
				break;
			case 3:
				method_2(batch);
				return;
			case 8:
				{
					if (true)
					{
					}
					return;
				}
				IL_0073:
				num2 = 3;
				num3 = num2;
				break;
				end_IL_0171:
				break;
			}
		}
	}

	private void method_2(MessageBatch messageBatch_0)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				if (action_0 != null)
				{
					num = 0;
					num2 = num;
					break;
				}
				return;
			case 0:
				action_0(messageBatch_0);
				num = 2;
				num2 = num;
				break;
			case 2:
			{
				num = -20793;
				int num3 = num;
				num = -20793;
				switch (num3 == num)
				{
				case false:
				case true:
					return;
				}
				if (1 == 0)
				{
				}
				if (false)
				{
				}
				return;
			}
			}
		}
	}

	public void FailTransmissionsNow()
	{
		int num = 15;
		int num2 = 11104;
		int num3 = num2;
		num2 = 11104;
		switch (num3 == num2)
		{
		}
		if (0 == 0)
		{
		}
		if (1 == 0)
		{
		}
		logger.LogInfo("닳뛚닞뺞닆뛄닓껀刡嘻刻席刡嘿刽渀爁癖爓縌爗癖爐渋刻嘸刵幾刻嘸刦껋닀뛄닇뻎닆뛓닖꺎튳횸튶\udefe튳횥튡\uee9b\uf29f\uf693\uf296ﻞ\uf286\uf699\uf2d2\uee86튳횠튷\udefe튴횷튻껂닗뛒");
		bool_2 = true;
		manualResetEvent_0.Set();
		autoResetEvent_1.Set();
	}

	public bool Transmit(MessageBatch batch)
	{
		int num = 1;
		switch (0)
		{
		}
		MessagesTag messagesTag = default(MessagesTag);
		List<KeyValuePair<string, string>> list_0 = default(List<KeyValuePair<string, string>>);
		string string_0 = default(string);
		bool result = default(bool);
		while (true)
		{
			int num2 = 1;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 1:
					if (bool_2)
					{
						num2 = 2;
						num3 = num2;
						continue;
					}
					messagesTag = new MessagesTag(batch.Configuration, batch.AgentInfo, batch.Messages);
					list_0 = ConstructHeaders(batch);
					string_0 = null;
					num2 = 0;
					num3 = num2;
					continue;
				case 0:
					try
					{
						string_0 = messagesTag.ToString(iconfigurationProvider_0.Configuration.AttributeLimiter);
					}
					catch (OutOfMemoryException)
					{
						logger.LogWarning("횄튳\udeb0틲횹튧껚늒뛙닔뺞닟뛓닟껁删嘯割席刷嘤刻渏爞瘟爈縗爜瘑牒渃刷嘥刡帿刵嘳割껌닓뛂닑뻖늒뛕닝껀튦횷튻\udeb0튻횸튵\ueece" + batch.Messages.Count + "훶튿\udebb튡횥튳껉닗뚞닁뺗늓뚖닳껚刦嘳刿帮刦嘿刼渉牒瘂爝繞爁瘆爞渇刦噶到帿刦嘵刺꺎닓뛘닖뺞닀뛓닆껜튫");
						MessageBatch[] array = batch.Split();
						if (array.Count() == 1)
						{
							logger.LogError("횔튳\udeaa튱횾틲껍닝뛘닆뻟닛뛘닗껊割嘷割帳刷嘥刡渏爕瘓牒縊爝瘙牒渂刳嘤刵帻割嘢刽꺎닁뛓닀뻗닓뛚닛껔튷훸틲\ude9a튠횹튢\uee9e\uf29b\uf698\uf295ﻞ\uf29f\uf693\uf281\uee9d튳횱튷");
							return true;
						}
						ProcessBatch(array[0]);
						ProcessBatch(array[1]);
						return true;
					}
					autoResetEvent_1.WaitOne();
					if (1 == 0)
					{
					}
					num2 = 3;
					num3 = num2;
					continue;
				case 2:
					return false;
				case 3:
					try
					{
						while (true)
						{
							num2 = 8;
							num3 = num2;
							bool bool_0 = default(bool);
							while (true)
							{
								switch (num3)
								{
								case 11:
									logger.LogInfo("횞튳\udeb2튦횅튷껀닖뛟닜뻙늒뛅닛껉刼嘷刾幾删嘳刱渋爛瘀爗縚牒瘁爚渇刾嘳割帩刳嘿刦껇닜뛑늒뻘닝뛄늒껚튧횤튼\udefe튦횹틲\uee9a\uf280\uf697\uf29cﺍ\uf29f\uf69f\uf286\ueece튿횳튡\udead튳횱튷껝늜뚖닿뻟닀뛝닛껀刵噶刦帶刻嘥割渚爀瘗爜縍爟瘟爁渝刻嘹刼幾刳嘥割껈닓뛟닞뻛닖뚘");
									result = false;
									num2 = 6;
									num3 = num2;
									continue;
								case 10:
									result = bool_0;
									num2 = 3;
									num3 = num2;
									continue;
								case 8:
									if (bool_2)
									{
										num2 = 2;
										num3 = num2;
										continue;
									}
									goto IL_01dc;
								case 7:
									if (!manualResetEvent_0.WaitOne(300000))
									{
										num2 = 4;
										num3 = num2;
										continue;
									}
									goto case 10;
								case 5:
									logger.LogInfo("횞튳\udeb2튦횅튷껀닖뛟닜뻙늒뛅닛껉刼嘷刾幾删嘳刱渋爛瘀爗縚牒瘁爚渇刾嘳割帩刳嘿刦껇닜뛑늒뻘닝뛄늒껚튧횤튼\udefe튦횹틲\uee9a\uf280\uf697\uf29cﺍ\uf29f\uf69f\uf286\ueece튿횳튡\udead튳횱튷껝늜뚖닳뻒닀뛓닓껊别噶刳帪刦嘳刿渞爆瘓爖繞爆瘙牒渚删嘷刼席刿嘿刦꺂늒뛔닇뻊늒뛗닁껝튧횻튻\udeb0튵훶튴\uee8f\uf29b\uf69a\uf287ﺌ\uf297\uf6d8");
									result = false;
									num2 = 9;
									num3 = num2;
									continue;
								case 4:
									logger.LogInfo("횟튡\ude9d튽횻튢껂닗뛂닗뺞닁뛟닕껀刳嘺割帪刻嘻刷渊牒瘙爇縊牒瘁爚渇刾嘳割帩刳嘿刦껇닜뛑늒뻘닝뛄늒껚튠횷튼\udead튿횿튡\uee9d\uf29b\uf699\uf29cﻞ\uf286\uf699\uf2d2\uee8d튽횻튢\udeb2튷횢튷");
									num2 = 10;
									num3 = num2;
									continue;
								case 2:
									num2 = 0;
									num3 = num2;
									continue;
								case 1:
									if (bool_2)
									{
										num2 = 5;
										num3 = num2;
									}
									else
									{
										num2 = 7;
										num3 = num2;
									}
									continue;
								case 0:
								{
									if (!flowController.SupportOfflineStorage)
									{
										goto IL_01dc;
									}
									num2 = -2842;
									int num4 = num2;
									num2 = -2842;
									switch (num4 == num2)
									{
									case false:
									case true:
										break;
									default:
										if (0 == 0)
										{
										}
										num2 = 11;
										num3 = num2;
										continue;
									}
									goto case 7;
								}
								case 3:
									return result;
								case 6:
									return result;
								case 9:
									{
										return result;
									}
									IL_01dc:
									manualResetEvent_0.Reset();
									bool_0 = false;
									((IAsyncProvider)iplatform_0).ExecuteAsync((Func<object>)delegate
									{
										int num5 = 5;
										if (1 == 0)
										{
										}
										int num6 = -21256;
										int num7 = num6;
										num6 = -21256;
										switch (num7 == num6)
										{
										default:
											if (0 == 0)
											{
											}
											logger.LogInfo("\ude9f튦횢튷껃닂뛂닛뻐닕뚖닆껁割嘢删帿刼嘥刿渇爆癖爟縛爁瘅爓渉刷噶到帿刦嘵刺꺀");
											bool_0 = ixmltransmitter_0.Post(list_0, string_0);
											manualResetEvent_0.Set();
											return null;
										}
									}, (Action<object>)null, highPriority: false);
									num2 = 1;
									num3 = num2;
									continue;
								}
								break;
							}
						}
					}
					finally
					{
						autoResetEvent_1.Set();
					}
				}
				break;
			}
		}
	}

	public List<KeyValuePair<string, string>> ConstructHeaders(MessageBatch batch)
	{
		int num = 9;
		int num2 = 21070;
		int num3 = num2;
		num2 = 21070;
		switch (num3 == num2)
		{
		default:
		{
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			List<KeyValuePair<string, string>> list = new List<KeyValuePair<string, string>>();
			list.smethod_3("횎틿껼닻뚛닱뻷닶", batch.Configuration.CompanyID.ToString().ToUpperInvariant());
			list.smethod_3("횎틿껼닻뚛닳뻷닶", batch.Configuration.ApplicationID.ToString().ToUpperInvariant());
			list.smethod_3("횎틿껼닻뚛답뻷닶", batch.Configuration.MessageGroup.ToString().ToUpperInvariant());
			list.smethod_3("횎틿껼닻뚛닳뻮닻", GetUserAgent(batch.AgentInfo));
			list.smethod_3("횎틿껼닻뚛닱뻟닂뛗닐껇刾嘿刦帷刷嘥", string.Join("훺틲", iconfigurationProvider_0.Configuration.ilist_0.OrderBy(delegate(string string_0)
			{
				int num4 = 22891;
				int num5 = num4;
				num4 = 22891;
				switch (num5 == num4)
				{
				default:
					if (1 == 0)
					{
					}
					if (0 == 0)
					{
					}
					return string_0;
				}
			}).ToArray()));
			return list;
		}
		}
	}

	public string GetUserAgent(AgentInfo agentInfo)
	{
		int num = 1;
		int num2 = -11899;
		int num3 = num2;
		num2 = -11899;
		switch (num3 == num2)
		{
		default:
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			return string.Format("횭틢\udea3틽횭틣껓닉뚄닏", new object[3]
			{
				agentInfo.Name,
				agentInfo.Version,
				string.IsNullOrEmpty(agentInfo.AdditionalInfo) ? "" : ("훶" + agentInfo.AdditionalInfo)
			});
		}
	}

	public override MessageBatch GetMessageBatch()
	{
		int num = -26591;
		int num2 = num;
		num = -26591;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			return new MessageBatch(agentInfo_0, iconfigurationProvider_0.Configuration.Copy(), imessageDequeuer_0.DequeueMessages());
		}
	}

	[CompilerGenerated]
	private static string smethod_0(string string_0)
	{
		int num = 22891;
		int num2 = num;
		num = 22891;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return string_0;
		}
	}
}
