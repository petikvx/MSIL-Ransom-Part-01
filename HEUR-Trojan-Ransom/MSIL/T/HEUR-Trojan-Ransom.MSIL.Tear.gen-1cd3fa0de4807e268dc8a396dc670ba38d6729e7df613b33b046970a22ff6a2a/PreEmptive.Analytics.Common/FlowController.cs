using System;
using System.Runtime.CompilerServices;

namespace PreEmptive.Analytics.Common;

public class FlowController : IFlowController
{
	private int int_0;

	private int int_1;

	private int int_2;

	private int int_3;

	private int int_4;

	private int int_5;

	private int int_6;

	[CompilerGenerated]
	private int int_7;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private int int_8;

	[CompilerGenerated]
	private long long_0;

	[CompilerGenerated]
	private int int_9;

	[CompilerGenerated]
	private int int_10;

	[CompilerGenerated]
	private long long_1;

	[CompilerGenerated]
	private int int_11;

	[CompilerGenerated]
	private int int_12;

	public int QueueSize
	{
		get
		{
			int num = -8863;
			int num2 = num;
			num = -8863;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return int_0;
			}
		}
		set
		{
			int num = 2439;
			int num2 = num;
			num = 2439;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			int_0 = Math.Max(3, value);
			HighWater = int_0 * 2 / 3;
		}
	}

	public int HighWater
	{
		get
		{
			int num = 28819;
			int num2 = num;
			num = 28819;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return int_1;
			}
		}
		set
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (value < 1)
					{
						num = 1;
						num2 = num;
					}
					else
					{
						num = 0;
						num2 = num;
					}
					break;
				case 0:
				{
					num = -21397;
					int num3 = num;
					num = -21397;
					switch (num3 == num)
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
						if (value >= int_0)
						{
							num = 2;
							num2 = num;
							goto end_IL_009a;
						}
						int_1 = value;
						return;
					}
					goto default;
				}
				case 1:
					int_1 = 1;
					return;
				case 2:
					{
						int_1 = int_0 - 1;
						return;
					}
					end_IL_009a:
					break;
				}
			}
		}
	}

	public int MaximumBatchSize
	{
		[CompilerGenerated]
		get
		{
			int num = 24327;
			int num2 = num;
			num = 24327;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return int_7;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -7588;
			int num2 = num;
			num = -7588;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			int_7 = value;
		}
	}

	public int MaximumInterval
	{
		get
		{
			int num = 29081;
			int num2 = num;
			num = 29081;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return int_2;
			}
		}
		set
		{
			while (true)
			{
				int_2 = Math.Max(1, value);
				int num = 0;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						MinimumInterval = int_2;
						num = 1;
						num2 = num;
						continue;
					case 0:
					{
						if (int_2 >= MinimumInterval)
						{
							return;
						}
						num = -3546;
						int num3 = num;
						num = -3546;
						switch (num3 == num)
						{
						default:
							if (1 == 0)
							{
							}
							if (0 == 0)
							{
							}
							num = 2;
							num2 = num;
							continue;
						case false:
						case true:
							break;
						}
						break;
					}
					case 1:
						return;
					}
					break;
				}
			}
		}
	}

	public int MinimumInterval
	{
		get
		{
			int num = -2603;
			int num2 = num;
			num = -2603;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return int_3;
			}
		}
		set
		{
			int num = 18597;
			int num2 = num;
			num = 18597;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			int_3 = Math.Max(1, value);
			int_3 = Math.Min(int_3, MaximumInterval);
		}
	}

	public int Gain
	{
		get
		{
			int num = -26922;
			int num2 = num;
			num = -26922;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return int_4;
			}
		}
		set
		{
			int num = -22773;
			int num2 = num;
			num = -22773;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			int_4 = Math.Max(1, value);
		}
	}

	public int QuietGain
	{
		get
		{
			int num = -9011;
			int num2 = num;
			num = -9011;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return int_5;
			}
		}
		set
		{
			int num = -11506;
			int num2 = num;
			num = -11506;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			int_5 = ((value < 1) ? 1 : ((value > 100) ? 100 : value));
		}
	}

	public bool Offline
	{
		[CompilerGenerated]
		get
		{
			if (1 == 0)
			{
			}
			int num = -16148;
			int num2 = num;
			num = -16148;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				return bool_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 20546;
			int num2 = num;
			num = 20546;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			bool_0 = value;
		}
	}

	public bool SupportOfflineStorage
	{
		[CompilerGenerated]
		get
		{
			if (1 == 0)
			{
			}
			int num = 15107;
			int num2 = num;
			num = 15107;
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
		set
		{
			int num = 31157;
			int num2 = num;
			num = 31157;
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

	public bool SendDisabled
	{
		[CompilerGenerated]
		get
		{
			if (1 == 0)
			{
			}
			int num = -1146;
			int num2 = num;
			num = -1146;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				return bool_2;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 6545;
			int num2 = num;
			num = 6545;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			bool_2 = value;
		}
	}

	public int MaximumSequentialFailureCount
	{
		[CompilerGenerated]
		get
		{
			int num = -28678;
			int num2 = num;
			num = -28678;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return int_8;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -29023;
			int num2 = num;
			num = -29023;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			int_8 = value;
		}
	}

	public int RetryTimeout
	{
		get
		{
			int num = -1474;
			int num2 = num;
			num = -1474;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return int_6;
			}
		}
		set
		{
			int num = -29760;
			int num2 = num;
			num = -29760;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			int_6 = Math.Max(0, value);
		}
	}

	public long LastSendTime
	{
		[CompilerGenerated]
		get
		{
			int num = -21422;
			int num2 = num;
			num = -21422;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return long_0;
			}
		}
		[CompilerGenerated]
		set
		{
			if (1 == 0)
			{
			}
			int num = 27278;
			int num2 = num;
			num = 27278;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			long_0 = value;
		}
	}

	public int Interval
	{
		[CompilerGenerated]
		get
		{
			int num = -15065;
			int num2 = num;
			num = -15065;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return int_9;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 19148;
			int num2 = num;
			num = 19148;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			int_9 = value;
		}
	}

	public int SequentialFailureCount
	{
		[CompilerGenerated]
		get
		{
			if (1 == 0)
			{
			}
			int num = -14056;
			int num2 = num;
			num = -14056;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				return int_10;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 1755;
			int num2 = num;
			num = 1755;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			int_10 = value;
		}
	}

	public long RetryTime
	{
		[CompilerGenerated]
		get
		{
			int num = -15907;
			int num2 = num;
			num = -15907;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return long_1;
			}
		}
		[CompilerGenerated]
		set
		{
			if (1 == 0)
			{
			}
			int num = 29487;
			int num2 = num;
			num = 29487;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			long_1 = value;
		}
	}

	public int MinimumFailureCount
	{
		[CompilerGenerated]
		get
		{
			int num = 77;
			int num2 = num;
			num = 77;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return int_11;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 2178;
			int num2 = num;
			num = 2178;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			int_11 = value;
		}
	}

	public int MinimumTimeToLive
	{
		[CompilerGenerated]
		get
		{
			int num = -27509;
			int num2 = num;
			num = -27509;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return int_12;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -17672;
			int num2 = num;
			num = -17672;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			int_12 = value;
		}
	}

	public FlowController()
	{
		method_0();
	}

	private void method_0()
	{
		if (1 == 0)
		{
		}
		int num = -31239;
		int num2 = num;
		num = -31239;
		switch (num2 == num)
		{
		}
		if (0 == 0)
		{
		}
		QueueSize = 30;
		HighWater = 20;
		MaximumInterval = 30000;
		MinimumInterval = 1;
		Gain = 66;
		QuietGain = 33;
		Offline = false;
		SupportOfflineStorage = true;
		SendDisabled = false;
		MaximumSequentialFailureCount = 3;
		RetryTimeout = 60000;
		LastSendTime = 0L;
		Interval = 0;
		SequentialFailureCount = 0;
		RetryTime = 0L;
		MinimumFailureCount = 150;
		MinimumTimeToLive = 259200;
		MaximumBatchSize = 4190208;
	}

	public bool CanStartClient()
	{
		if (1 == 0)
		{
		}
		int num = 13025;
		int num2 = num;
		num = 13025;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			if (Offline)
			{
				return SupportOfflineStorage;
			}
			break;
		case false:
		case true:
			break;
		}
		return true;
	}

	public bool BatchHasExpired(MessageBatch batch)
	{
		int num = 854;
		int num2 = num;
		num = 854;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			if (batch.FailureCount >= MinimumFailureCount)
			{
				return method_1(batch);
			}
			break;
		case false:
		case true:
			break;
		}
		return false;
	}

	private bool method_1(MessageBatch messageBatch_0)
	{
		int num = 16491;
		int num2 = num;
		num = 16491;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return messageBatch_0.DateCreated.AddSeconds(MinimumTimeToLive) < DateTime.UtcNow;
		}
	}

	public int GetInterval(int numberOfMessages)
	{
		switch (0)
		{
		default:
		{
			int num = 2;
			int num2 = num;
			long ticks = default(long);
			long num5 = default(long);
			int num4 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 13:
					Interval = MaximumInterval;
					num = 11;
					num2 = num;
					break;
				case 4:
				case 11:
				{
					LastSendTime = ticks;
					num = -16069;
					int num6 = num;
					num = -16069;
					switch (num6 == num)
					{
					default:
						if (0 == 0)
						{
						}
						num = 5;
						num2 = num;
						goto end_IL_0272;
					case false:
					case true:
						break;
					}
					goto IL_00a4;
				}
				case 10:
					if (Interval > MaximumInterval)
					{
						num = 13;
						num2 = num;
					}
					else
					{
						num = 9;
						num2 = num;
					}
					break;
				case 9:
					if (Interval < MinimumInterval)
					{
						num = 3;
						num2 = num;
						break;
					}
					goto case 4;
				case 7:
				case 8:
				{
					int num7 = (int)(num5 * (num4 - Interval) / 100L);
					Interval += num7;
					num = 10;
					num2 = num;
					break;
				}
				case 6:
					if (numberOfMessages > 0)
					{
						num = 0;
						num2 = num;
						break;
					}
					num4 = MaximumInterval;
					num5 = QuietGain;
					num = 8;
					num2 = num;
					break;
				case 3:
					Interval = MinimumInterval;
					num = 4;
					num2 = num;
					break;
				default:
					if (1 == 0)
					{
					}
					if (LastSendTime == 0L)
					{
						goto IL_00a4;
					}
					ticks = DateTime.Now.Ticks;
					num4 = 0;
					num5 = 0L;
					num = 6;
					num2 = num;
					break;
				case 1:
					LastSendTime = DateTime.Now.Ticks;
					Interval = int_2;
					num = 12;
					num2 = num;
					break;
				case 0:
				{
					long num3 = Math.Abs(ticks - LastSendTime) / 10000L;
					num4 = (int)(num3 / numberOfMessages * HighWater);
					num5 = Gain;
					num = 7;
					num2 = num;
					break;
				}
				case 5:
				case 12:
					{
						return Interval;
					}
					IL_00a4:
					num = 1;
					num2 = num;
					break;
					end_IL_0272:
					break;
				}
			}
		}
		}
	}

	public int MessagesToDrop(int currentMessageCount)
	{
		int num = -1813;
		int num2 = num;
		num = -1813;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return Math.Max(currentMessageCount - QueueSize, 0);
		}
	}

	public bool ShouldSendNow(int messageCount)
	{
		int num = 785;
		int num2 = num;
		num = 785;
		int num3;
		switch (num2 == num)
		{
		default:
			if (0 == 0)
			{
			}
			num = 0;
			num3 = num;
			goto IL_0071;
		case false:
		case true:
			{
				num = 1;
				num3 = num;
				goto IL_0071;
			}
			IL_0071:
			while (true)
			{
				switch (num3)
				{
				case 3:
					num = 2;
					num3 = num;
					continue;
				default:
					if (messageCount >= HighWater)
					{
						num = 3;
						num3 = num;
						continue;
					}
					goto IL_00bc;
				case 2:
					if (!SendDisabled)
					{
						break;
					}
					goto IL_00bc;
				case 1:
					{
						if (1 == 0)
						{
						}
						return !Offline;
					}
					IL_00bc:
					return false;
				}
				break;
			}
			goto case false;
		}
	}

	public virtual bool OkToTransmit()
	{
		int num = 0;
		int num2 = num;
		DateTime now = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (1 == 0)
				{
				}
				if (SendDisabled)
				{
					num = 7;
					num2 = num;
				}
				else
				{
					num = 1;
					num2 = num;
				}
				continue;
			case 6:
				if (now.Ticks < RetryTime)
				{
					num = 9;
					num2 = num;
					continue;
				}
				goto IL_0131;
			case 5:
				num = 8;
				num2 = num;
				continue;
			case 4:
				num = 3;
				num2 = num;
				continue;
			case 3:
				if (int_6 != 0)
				{
					num = 2;
					num2 = num;
					continue;
				}
				break;
			case 2:
				now = DateTime.Now;
				num = 6;
				num2 = num;
				continue;
			case 1:
				if (SequentialFailureCount >= MaximumSequentialFailureCount)
				{
					num = 4;
					num2 = num;
					continue;
				}
				goto IL_0131;
			default:
				if (!Offline)
				{
					num = 5;
					num2 = num;
					continue;
				}
				goto case 7;
			case 7:
			{
				num = -25467;
				int num3 = num;
				num = -25467;
				switch (num3 == num)
				{
				default:
					if (0 == 0)
					{
					}
					return false;
				case false:
				case true:
					break;
				}
				break;
			}
			case 9:
				break;
				IL_0131:
				return true;
			}
			break;
		}
		return false;
	}

	public virtual void OnSend(bool sendSucceeded)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 8:
			{
				RetryTime = DateTime.Now.Ticks + RetryTimeout * 10000;
				num = -30189;
				int num3 = num;
				num = -30189;
				switch (num3 == num)
				{
				default:
					if (1 == 0)
					{
					}
					if (0 == 0)
					{
					}
					num = 6;
					num2 = num;
					break;
				case false:
				case true:
					return;
				}
				break;
			}
			case 7:
				num = 5;
				num2 = num;
				break;
			case 5:
				if (RetryTimeout > 0)
				{
					num = 8;
					num2 = num;
					break;
				}
				return;
			default:
				if (sendSucceeded)
				{
					num = 4;
					num2 = num;
				}
				else
				{
					num = 2;
					num2 = num;
				}
				break;
			case 2:
				if (MaximumSequentialFailureCount > 0)
				{
					num = 0;
					num2 = num;
					break;
				}
				return;
			case 1:
				if (SequentialFailureCount >= MaximumSequentialFailureCount)
				{
					num = 7;
					num2 = num;
					break;
				}
				return;
			case 0:
				SequentialFailureCount++;
				num = 1;
				num2 = num;
				break;
			case 4:
				SequentialFailureCount = 0;
				RetryTime = 0L;
				return;
			case 6:
				return;
			}
		}
	}

	public virtual IFlowController Copy()
	{
		int num = -19626;
		int num2 = num;
		num = -19626;
		switch (num2 == num)
		{
		default:
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			return (FlowController)MemberwiseClone();
		}
	}
}
