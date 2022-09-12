using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace xbot.Trader;

public class TradeManager
{
	private readonly string ApiKey;

	private readonly SteamWeb steamWeb_0;

	private DateTime dateTime_0;

	private DateTime dateTime_1;

	private DateTime dateTime_2;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private bool sHcUnhZyTw;

	public EventHandler OnTimeout;

	public int MaxTradeTimeSec
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		private set
		{
			int_0 = value;
		}
	}

	public int MaxActionGapSec
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		private set
		{
			int_1 = value;
		}
	}

	public int TradePollingInterval
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		private set
		{
			int_2 = value;
		}
	}

	public bool IsTradeThreadRunning
	{
		[CompilerGenerated]
		get
		{
			return sHcUnhZyTw;
		}
		[CompilerGenerated]
		internal set
		{
			sHcUnhZyTw = value;
		}
	}

	public TradeManager(string apiKey, SteamWeb steamWeb)
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		if (apiKey == null)
		{
			throw new ArgumentNullException("apiKey");
		}
		if (steamWeb == null)
		{
			throw new ArgumentNullException("steamWeb");
		}
		SetTradeTimeLimits(180, 15, 800);
		ApiKey = apiKey;
		steamWeb_0 = steamWeb;
	}

	public void SetTradeTimeLimits(int maxTradeTime, int maxActionGap, int pollingInterval)
	{
		MaxTradeTimeSec = maxTradeTime;
		MaxActionGapSec = maxActionGap;
		TradePollingInterval = pollingInterval;
	}

	public void StartTradeThread(Trade trade)
	{
		_003C_003Ec__DisplayClass27_0 _003C_003Ec__DisplayClass27_ = new _003C_003Ec__DisplayClass27_0();
		_003C_003Ec__DisplayClass27_._003C_003E4__this = this;
		_003C_003Ec__DisplayClass27_.trade = trade;
		dateTime_0 = DateTime.Now;
		dateTime_1 = DateTime.Now;
		dateTime_2 = DateTime.Now.AddSeconds(-1000.0);
		new Thread((ThreadStart)delegate
		{
			_003C_003Ec__DisplayClass27_._003C_003E4__this.IsTradeThreadRunning = true;
			try
			{
				while (true)
				{
					if (!_003C_003Ec__DisplayClass27_._003C_003E4__this.IsTradeThreadRunning)
					{
						return;
					}
					if (_003C_003Ec__DisplayClass27_.trade.Poll())
					{
						_003C_003Ec__DisplayClass27_._003C_003E4__this.dateTime_1 = DateTime.Now;
					}
					if (_003C_003Ec__DisplayClass27_.trade.HasTradeEnded || _003C_003Ec__DisplayClass27_._003C_003E4__this.method_0(_003C_003Ec__DisplayClass27_.trade))
					{
						break;
					}
					Thread.Sleep(_003C_003Ec__DisplayClass27_._003C_003E4__this.TradePollingInterval);
				}
				_003C_003Ec__DisplayClass27_._003C_003E4__this.IsTradeThreadRunning = false;
			}
			catch (Exception ex)
			{
				_003C_003Ec__DisplayClass27_._003C_003E4__this.IsTradeThreadRunning = false;
				_003C_003Ec__DisplayClass27_.trade.method_3("Unknown error occurred: " + ex.ToString());
			}
			finally
			{
				try
				{
					if (_003C_003Ec__DisplayClass27_.trade.IsTradeAwaitingConfirmation)
					{
						_003C_003Ec__DisplayClass27_.trade.method_1();
					}
				}
				catch (Exception ex2)
				{
					_003C_003Ec__DisplayClass27_.trade.method_3("Unknown error occurred during OnTradeAwaitingConfirmation: " + ex2.ToString());
				}
				finally
				{
					try
					{
						_003C_003Ec__DisplayClass27_.trade.method_2();
					}
					catch (Exception ex3)
					{
						smethod_0("Error occurred during trade.OnClose()! " + ex3);
						throw;
					}
				}
			}
		}).Start();
	}

	private bool method_0(Trade trade_0)
	{
		if (trade_0.OtherUserAccepted)
		{
			return false;
		}
		DateTime now = DateTime.Now;
		int num = (int)Math.Round((dateTime_1.AddSeconds(MaxActionGapSec) - now).TotalSeconds);
		int num2 = (int)Math.Round((dateTime_0.AddSeconds(MaxTradeTimeSec) - now).TotalSeconds);
		double totalSeconds = (now - dateTime_2).TotalSeconds;
		if (num > 0 && num2 > 0)
		{
			if (num <= 20 && totalSeconds >= 10.0)
			{
				try
				{
					trade_0.SendMessage("Are You AFK? The trade will be canceled in " + num + " seconds if you don't do something.");
				}
				catch
				{
				}
				dateTime_2 = now;
			}
			return false;
		}
		if (OnTimeout != null)
		{
			OnTimeout(this, null);
		}
		trade_0.CancelTrade();
		return true;
	}

	private static void smethod_0(string string_0)
	{
		Console.WriteLine(string_0);
	}
}
