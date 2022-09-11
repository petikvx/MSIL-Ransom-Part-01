using System;
using System.Runtime.CompilerServices;
using System.Threading;
using PreEmptive.Analytics.Common;
using PreEmptive.SoS.Client.Messages;

namespace PreEmptive.SoS.Client.Cache;

public class CacheService
{
	private bool bool_0;

	private EventHandler eventHandler_0;

	[CompilerGenerated]
	private PlatformClient platformClient_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private ExtendedKeys extendedKeys_0;

	[CompilerGenerated]
	private BinaryInfo binaryInfo_0;

	internal PlatformClient Client
	{
		[CompilerGenerated]
		get
		{
			int num = 26422;
			int num2 = num;
			num = 26422;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return platformClient_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 4367;
			int num2 = num;
			num = 4367;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			platformClient_0 = value;
		}
	}

	internal bool SendLifeCycleMessages
	{
		[CompilerGenerated]
		get
		{
			int num = -3097;
			int num2 = num;
			num = -3097;
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
		set
		{
			int num = -2768;
			int num2 = num;
			num = -2768;
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

	public ExtendedKeys ShutdownKeys
	{
		[CompilerGenerated]
		get
		{
			int num = -21047;
			int num2 = num;
			num = -21047;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return extendedKeys_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -12755;
			int num2 = num;
			num = -12755;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			extendedKeys_0 = value;
		}
	}

	public BinaryInfo ShutdownBinary
	{
		[CompilerGenerated]
		get
		{
			int num = -1074;
			int num2 = num;
			num = -1074;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return binaryInfo_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 13191;
			int num2 = num;
			num = 13191;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			binaryInfo_0 = value;
		}
	}

	public event EventHandler OfflineStorageComplete
	{
		add
		{
			EventHandler eventHandler2 = default(EventHandler);
			while (true)
			{
				EventHandler eventHandler = eventHandler_0;
				int num = 1;
				int num2 = num;
				while (true)
				{
					num = -9115;
					int num3 = num;
					num = -9115;
					switch (num3 == num)
					{
					default:
						if (1 == 0)
						{
						}
						if (0 == 0)
						{
						}
						switch (num2)
						{
						case 2:
							if ((object)eventHandler == eventHandler2)
							{
								num = 0;
								num2 = num;
								continue;
							}
							goto case 1;
						case 1:
						{
							eventHandler2 = eventHandler;
							EventHandler value2 = (EventHandler)Delegate.Combine(eventHandler2, value);
							eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
							num = 2;
							num2 = num;
							continue;
						}
						case 0:
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
		remove
		{
			EventHandler eventHandler2 = default(EventHandler);
			while (true)
			{
				EventHandler eventHandler = eventHandler_0;
				int num = 1;
				int num2 = num;
				while (true)
				{
					num = 21750;
					int num3 = num;
					num = 21750;
					switch (num3 == num)
					{
					default:
						if (0 == 0)
						{
						}
						switch (num2)
						{
						case 2:
							if ((object)eventHandler == eventHandler2)
							{
								if (1 == 0)
								{
								}
								num = 0;
								num2 = num;
								continue;
							}
							goto case 1;
						case 1:
						{
							eventHandler2 = eventHandler;
							EventHandler value2 = (EventHandler)Delegate.Remove(eventHandler2, value);
							eventHandler = Interlocked.CompareExchange(ref eventHandler_0, value2, eventHandler2);
							num = 2;
							num2 = num;
							continue;
						}
						case 0:
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
	}

	public void Send(PreEmptive.SoS.Client.Messages.Message message_0)
	{
		int num = -543;
		int num2 = num;
		num = -543;
		switch (num2 == num)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		message_0.Send(this, Client);
	}

	public void Send(PreEmptive.SoS.Client.Messages.Message message_0, bool silverlightShutDown)
	{
		int num = -4707;
		int num2 = num;
		num = -4707;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		if (1 == 0)
		{
		}
		bool_0 = silverlightShutDown;
		message_0.Send(this, Client);
	}

	public void ShutDown()
	{
		if (1 == 0)
		{
		}
		int num = 22317;
		int num2 = num;
		num = 22317;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		Client.ApplicationStop(ShutdownKeys, ShutdownBinary, bool_0);
		bool_0 = false;
	}

	public void SendQueuedMessages()
	{
		if (true)
		{
		}
		TransmitterThread transmitterThread = default(TransmitterThread);
		while (true)
		{
			MessageQueue messageQueue = Client.Core.MessageQueue as MessageQueue;
			while (true)
			{
				IL_00cf:
				int num = 0;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 3:
						transmitterThread = messageQueue.TransmitterThread as TransmitterThread;
						num = 1;
						num2 = num;
						continue;
					case 2:
						transmitterThread.ProcessQueueBatches();
						num = 4;
						num2 = num;
						continue;
					case 1:
						if (transmitterThread != null)
						{
							num = 2;
							num2 = num;
							continue;
						}
						return;
					case 0:
						break;
					default:
						goto end_IL_00b3;
					case 4:
						return;
					}
					if (messageQueue == null)
					{
						return;
					}
					num = -9397;
					int num3 = num;
					num = -9397;
					switch (num3 == num)
					{
					default:
						if (0 == 0)
						{
						}
						num = 3;
						num2 = num;
						continue;
					case false:
					case true:
						break;
					}
					goto IL_00cf;
					continue;
					end_IL_00b3:
					break;
				}
				break;
			}
		}
	}
}
