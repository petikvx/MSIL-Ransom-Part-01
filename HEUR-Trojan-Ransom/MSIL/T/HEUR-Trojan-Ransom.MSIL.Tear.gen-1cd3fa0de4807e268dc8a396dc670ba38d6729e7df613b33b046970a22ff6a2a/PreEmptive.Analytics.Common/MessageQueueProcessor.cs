using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using PreEmptive.Analytics.Common.Utilities;

namespace PreEmptive.Analytics.Common;

public abstract class MessageQueueProcessor : IQueueProcessor
{
	private object object_0;

	private volatile bool bool_0;

	private object object_1;

	private int int_0;

	protected IFlowController flowController;

	protected ILogger logger;

	protected IAsyncProvider AsyncProvider;

	private AutoResetEvent autoResetEvent_0 = new AutoResetEvent(initialState: false);

	private volatile bool bool_1;

	public bool Running
	{
		get
		{
			int num = 30302;
			int num2 = num;
			num = 30302;
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
				bool lockTaken = false;
				object obj = default(object);
				try
				{
					Monitor.Enter(obj = object_0, ref lockTaken);
					return bool_0;
				}
				finally
				{
					num = 1;
					int num3 = num;
					while (true)
					{
						switch (num3)
						{
						default:
							if (lockTaken)
							{
								num = 0;
								num3 = num;
								continue;
							}
							break;
						case 0:
							Monitor.Exit(obj);
							num = 2;
							num3 = num;
							continue;
						case 2:
							break;
						}
						break;
					}
				}
			}
			case false:
			case true:
			{
				bool result = default(bool);
				return result;
			}
			}
		}
		set
		{
			int num = -17638;
			int num2 = num;
			num = -17638;
			switch (num2 == num)
			{
			case false:
			case true:
				return;
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			bool lockTaken = false;
			object obj = default(object);
			try
			{
				Monitor.Enter(obj = object_0, ref lockTaken);
				bool_0 = value;
			}
			finally
			{
				num = 1;
				int num3 = num;
				while (true)
				{
					switch (num3)
					{
					default:
						if (lockTaken)
						{
							num = 0;
							num3 = num;
							continue;
						}
						break;
					case 0:
						Monitor.Exit(obj);
						num = 2;
						num3 = num;
						continue;
					case 2:
						break;
					}
					break;
				}
			}
		}
	}

	protected MessageQueueProcessor(IFlowController flowController, ILogger logger, IAsyncProvider asyncprovider)
	{
		object_0 = new object();
		object_1 = new object();
		this.flowController = flowController;
		this.logger = logger;
		AsyncProvider = asyncprovider;
		Running = false;
	}

	private void method_0()
	{
		int num = 18;
		if (1 == 0)
		{
		}
		switch (0)
		{
		}
		bool lockTaken = default(bool);
		object obj = default(object);
		while (true)
		{
			int_0 = flowController.GetInterval(0);
			bool flag = true;
			bool flag2 = true;
			int num2 = 3;
			int num3 = num2;
			while (true)
			{
				switch (num3)
				{
				case 5:
					num2 = 1;
					num3 = num2;
					continue;
				case 4:
					ProcessQueueBatches();
					num2 = 2;
					num3 = num2;
					continue;
				case 1:
					if (!flowController.SendDisabled)
					{
						num2 = 4;
						num3 = num2;
						continue;
					}
					return;
				case 0:
					if (!flag)
					{
						num2 = 5;
						num3 = num2;
						continue;
					}
					try
					{
						num2 = 12;
						num3 = num2;
						while (true)
						{
							switch (num3)
							{
							case 10:
							case 14:
								num2 = 5;
								num3 = num2;
								continue;
							case 6:
							case 13:
								num2 = 4;
								num3 = num2;
								continue;
							case 12:
							{
								num2 = 22613;
								int num4 = num2;
								num2 = 22613;
								switch (num4 == num2)
								{
								case false:
								case true:
									goto IL_0194;
								}
								if (false)
								{
								}
								goto default;
							}
							default:
								if (flag2)
								{
									num2 = 2;
									num3 = num2;
								}
								else
								{
									autoResetEvent_0.WaitOne(int_0);
									num2 = 10;
									num3 = num2;
								}
								continue;
							case 3:
								goto IL_0194;
							case 9:
								if (flag)
								{
									num2 = 1;
									num3 = num2;
									continue;
								}
								goto IL_022b;
							case 8:
								if (flowController.SendDisabled)
								{
									num2 = 7;
									num3 = num2;
									continue;
								}
								goto IL_022b;
							case 7:
								int_0 = flowController.GetInterval(0);
								num2 = 13;
								num3 = num2;
								continue;
							case 5:
								if (bool_1)
								{
									num2 = 0;
									num3 = num2;
								}
								else
								{
									lockTaken = false;
									num2 = 3;
									num3 = num2;
								}
								continue;
							case 2:
								flag2 = false;
								num2 = 14;
								num3 = num2;
								continue;
							case 1:
								num2 = 8;
								num3 = num2;
								continue;
							case 0:
								num2 = 11;
								num3 = num2;
								continue;
							case 4:
								break;
							case 11:
								break;
								IL_0194:
								try
								{
									Monitor.Enter(obj = object_0, ref lockTaken);
									flag = Running;
								}
								finally
								{
									num2 = 1;
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
											num2 = 2;
											num3 = num2;
											continue;
										case 2:
											break;
										}
										break;
									}
								}
								num2 = 9;
								num3 = num2;
								continue;
								IL_022b:
								ProcessQueueBatches();
								num2 = 6;
								num3 = num2;
								continue;
							}
							break;
						}
					}
					catch (Exception ex)
					{
						logger.LogError("뛦닖뻗늖뛒닼긧券嘲剾带刾嘠刋渓爒癒爑縔牖癕" + GetType().Name + "뚕늞뻆닞뛀닋긥剶嘳到干刳嘪刍渗爆瘆爗縝爘癈牎湵" + ex.Message + "뚕느뺒답뛝닀긦刿嘼别帻券嘵剎渆爙癒爌縇爘癒爞渠刹嘱刻帡別嘽勜꺜늘뚜늞");
					}
					goto case 3;
				case 3:
					num2 = 0;
					num3 = num2;
					continue;
				case 2:
					return;
				}
				break;
			}
		}
	}

	public void ProcessQueue()
	{
		while (true)
		{
			if (1 == 0)
			{
			}
			if (Running)
			{
				break;
			}
			int num = -26865;
			int num2 = num;
			num = -26865;
			switch (num2 == num)
			{
			case false:
			case true:
				continue;
			}
			if (0 == 0)
			{
			}
			ProcessQueueBatches();
			return;
		}
		autoResetEvent_0.Set();
	}

	public void ProcessQueueBatches()
	{
		int num = 8;
		int count2 = default(int);
		MessageBatch messageBatch = default(MessageBatch);
		object obj = default(object);
		int count = default(int);
		while (true)
		{
			switch (0)
			{
			}
			while (true)
			{
				bool lockTaken = false;
				int num2 = 3;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					case 5:
						break;
					case 4:
						if (1 == 0)
						{
						}
						logger.LogInfo(string.Format("튭훢틓꺒닛뛗닍뻁닗뛕닋긡剶嘳刬帷剶嘰刋減爘瘕牞縂爄瘝爍渷別嘡刻帶剸", new object[1] { count2 }));
						ProcessBatch(messageBatch);
						num2 = 2;
						num3 = num2;
						continue;
					case 3:
						try
						{
							Monitor.Enter(obj = object_1, ref lockTaken);
							messageBatch = GetMessageBatch();
						}
						finally
						{
							num2 = 1;
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
									num2 = 2;
									num3 = num2;
									continue;
								case 2:
									break;
								}
								break;
							}
						}
						count = messageBatch.Messages.Count;
						num2 = 0;
						num3 = num2;
						continue;
					case 1:
						if (count2 > 0)
						{
							num2 = 4;
							num3 = num2;
							continue;
						}
						goto case 2;
					case 0:
						if (count > 0)
						{
							num2 = 5;
							num3 = num2;
							continue;
						}
						goto case 2;
					default:
						goto end_IL_016d;
					case 2:
						int_0 = flowController.GetInterval(count);
						return;
					}
					count2 = messageBatch.Messages.Count;
					num2 = -29809;
					int num4 = num2;
					num2 = -29809;
					switch (num4 == num2)
					{
					default:
						if (0 == 0)
						{
						}
						num2 = 1;
						num3 = num2;
						continue;
					case false:
					case true:
						break;
					}
					goto end_IL_018c;
					continue;
					end_IL_016d:
					break;
				}
				continue;
				end_IL_018c:
				break;
			}
		}
	}

	public virtual void Start()
	{
		if (1 == 0)
		{
		}
		switch (0)
		{
		}
		object obj = default(object);
		while (true)
		{
			bool flag = true;
			bool lockTaken = false;
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					AsyncProvider.ExecuteAsync((Func<object>)delegate
					{
						if (1 == 0)
						{
						}
						int num4 = -30164;
						int num5 = num4;
						num4 = -30164;
						switch (num5 == num4)
						{
						default:
							if (0 == 0)
							{
							}
							method_0();
							return null;
						}
					}, (Action<object>)null, highPriority: false);
					num = 1;
					num2 = num;
					continue;
				case 3:
					if (!flag)
					{
						num = 0;
						num2 = num;
						continue;
					}
					return;
				case 2:
					try
					{
						while (true)
						{
							Monitor.Enter(obj = object_0, ref lockTaken);
							while (true)
							{
								IL_0112:
								num = 1;
								num2 = num;
								while (true)
								{
									switch (num2)
									{
									case 3:
										break;
									case 2:
										Running = true;
										flag = false;
										num = 3;
										num2 = num;
										continue;
									case 1:
										goto IL_00e1;
									default:
										goto end_IL_00f9;
									case 0:
										goto end_IL_0124;
									}
									num = 23993;
									int num3 = num;
									num = 23993;
									switch (num3 == num)
									{
									case false:
									case true:
										goto IL_0112;
									}
									if (false)
									{
									}
									goto IL_00b8;
									IL_00e1:
									if (!Running)
									{
										num = 2;
										num2 = num;
										continue;
									}
									goto IL_00b8;
									IL_00b8:
									num = 0;
									num2 = num;
									continue;
									end_IL_00f9:
									break;
								}
								break;
							}
							continue;
							end_IL_0124:
							break;
						}
					}
					finally
					{
						num = 1;
						num2 = num;
						while (true)
						{
							switch (num2)
							{
							default:
								if (lockTaken)
								{
									num = 0;
									num2 = num;
									continue;
								}
								break;
							case 0:
								Monitor.Exit(obj);
								num = 2;
								num2 = num;
								continue;
							case 2:
								break;
							}
							break;
						}
					}
					num = 3;
					num2 = num;
					continue;
				case 0:
					num = 4;
					num2 = num;
					continue;
				case 1:
					return;
				}
				break;
			}
		}
	}

	public void Stop()
	{
		bool lockTaken = false;
		object obj = default(object);
		try
		{
			while (true)
			{
				Monitor.Enter(obj = object_0, ref lockTaken);
				while (true)
				{
					IL_00ad:
					int num = 1;
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						case 3:
							break;
						case 2:
							Running = false;
							ProcessQueueBatches();
							num = 3;
							num2 = num;
							continue;
						case 1:
							goto IL_006e;
						default:
							goto end_IL_0095;
						case 0:
							return;
						}
						num = 428;
						int num3 = num;
						num = 428;
						switch (num3 == num)
						{
						case false:
						case true:
							goto IL_00ad;
						}
						if (false)
						{
						}
						goto IL_0043;
						IL_006e:
						if (1 == 0)
						{
						}
						if (Running)
						{
							num = 2;
							num2 = num;
							continue;
						}
						goto IL_0043;
						IL_0043:
						num = 0;
						num2 = num;
						continue;
						end_IL_0095:
						break;
					}
					break;
				}
			}
		}
		finally
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (lockTaken)
					{
						num = 0;
						num2 = num;
						continue;
					}
					break;
				case 0:
					Monitor.Exit(obj);
					num = 2;
					num2 = num;
					continue;
				case 2:
					break;
				}
				break;
			}
		}
	}

	public void ProcessQueueNow()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				num = -1797;
				int num3 = num;
				num = -1797;
				switch (num3 == num)
				{
				case false:
				case true:
					break;
				default:
					if (0 == 0)
					{
					}
					if (true)
					{
					}
					return;
				}
				goto IL_0042;
			}
			default:
				if (!Running)
				{
					goto case 2;
				}
				goto IL_0042;
			case 0:
				{
					ProcessQueue();
					num = 2;
					num2 = num;
					break;
				}
				IL_0042:
				num = 0;
				num2 = num;
				break;
			}
		}
	}

	public virtual void ProcessBatch(MessageBatch batch)
	{
		int num = -3428;
		int num2 = num;
		num = -3428;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (false)
		{
		}
	}

	public virtual MessageBatch GetMessageBatch()
	{
		int num = -9539;
		int num2 = num;
		num = -9539;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return new MessageBatch(new AgentInfo(), new Configuration(), new List<Message>());
		}
	}

	[CompilerGenerated]
	private object method_1()
	{
		if (1 == 0)
		{
		}
		int num = -30164;
		int num2 = num;
		num = -30164;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			method_0();
			return null;
		}
	}
}
