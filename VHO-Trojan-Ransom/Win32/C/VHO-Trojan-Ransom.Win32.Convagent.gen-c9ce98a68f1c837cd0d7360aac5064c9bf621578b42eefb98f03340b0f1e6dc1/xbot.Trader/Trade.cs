using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using xbot.Trader.Exceptions;
using xbot.Trader.TradeWebAPI;

namespace xbot.Trader;

public class Trade
{
	public enum TradeStatusType
	{
		OnGoing,
		CompletedSuccessfully,
		Empty,
		TradeCancelled,
		SessionExpired,
		TradeFailed,
		PendingConfirmation
	}

	public delegate void CloseHandler();

	public delegate void CompleteHandler();

	public delegate void WaitingForEmailHandler(long tradeOfferID);

	public delegate void ErrorHandler(string errorMessage);

	public delegate void StatusErrorHandler(TradeStatusType statusType);

	public delegate void TimeoutHandler();

	public delegate void SuccessfulInit();

	public delegate void MessageHandler(string msg);

	public delegate void UserSetReadyStateHandler(bool ready);

	public delegate void UserAcceptHandler();

	private readonly List<TradeEvent> list_0;

	private readonly Dictionary<int, TradeUserAssets> dictionary_0;

	private readonly TradeSession tradeSession_0;

	private List<TradeUserAssets> list_1;

	private List<TradeUserAssets> list_2;

	private bool bool_0;

	private bool bool_1;

	private int int_0;

	private long long_0;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private bool bool_4;

	[CompilerGenerated]
	private bool bool_5;

	[CompilerGenerated]
	private bool bool_6;

	[CompilerGenerated]
	private bool bool_7;

	[CompilerGenerated]
	private bool bool_8;

	[CompilerGenerated]
	private CloseHandler closeHandler_0;

	[CompilerGenerated]
	private WaitingForEmailHandler waitingForEmailHandler_0;

	[CompilerGenerated]
	private ErrorHandler errorHandler_0;

	[CompilerGenerated]
	private StatusErrorHandler statusErrorHandler_0;

	[CompilerGenerated]
	private SuccessfulInit successfulInit_0;

	[CompilerGenerated]
	private MessageHandler messageHandler_0;

	[CompilerGenerated]
	private UserSetReadyStateHandler userSetReadyStateHandler_0;

	[CompilerGenerated]
	private UserAcceptHandler userAcceptHandler_0;

	public IEnumerable<TradeUserAssets> OtherOfferedItems => list_2;

	public IEnumerable<TradeUserAssets> MyOfferedItems => list_1;

	public bool OtherIsReady
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		private set
		{
			bool_2 = value;
		}
	}

	public bool MeIsReady
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
		[CompilerGenerated]
		private set
		{
			bool_3 = value;
		}
	}

	public bool TradeStarted
	{
		[CompilerGenerated]
		get
		{
			return bool_4;
		}
		[CompilerGenerated]
		private set
		{
			bool_4 = value;
		}
	}

	public bool OtherUserCancelled
	{
		[CompilerGenerated]
		get
		{
			return bool_5;
		}
		[CompilerGenerated]
		private set
		{
			bool_5 = value;
		}
	}

	public bool HasTradeCompletedOk
	{
		[CompilerGenerated]
		get
		{
			return bool_6;
		}
		[CompilerGenerated]
		private set
		{
			bool_6 = value;
		}
	}

	public bool IsTradeAwaitingConfirmation
	{
		[CompilerGenerated]
		get
		{
			return bool_7;
		}
		[CompilerGenerated]
		private set
		{
			bool_7 = value;
		}
	}

	public bool HasTradeEnded
	{
		get
		{
			if (!OtherUserCancelled && !HasTradeCompletedOk && !IsTradeAwaitingConfirmation)
			{
				return bool_1;
			}
			return true;
		}
	}

	public bool OtherUserAccepted
	{
		[CompilerGenerated]
		get
		{
			return bool_8;
		}
		[CompilerGenerated]
		private set
		{
			bool_8 = value;
		}
	}

	public event CloseHandler OnClose
	{
		[CompilerGenerated]
		add
		{
			CloseHandler closeHandler = closeHandler_0;
			CloseHandler closeHandler2;
			do
			{
				closeHandler2 = closeHandler;
				CloseHandler value2 = (CloseHandler)Delegate.Combine(closeHandler2, value);
				closeHandler = Interlocked.CompareExchange(ref closeHandler_0, value2, closeHandler2);
			}
			while ((object)closeHandler != closeHandler2);
		}
		[CompilerGenerated]
		remove
		{
			CloseHandler closeHandler = closeHandler_0;
			CloseHandler closeHandler2;
			do
			{
				closeHandler2 = closeHandler;
				CloseHandler value2 = (CloseHandler)Delegate.Remove(closeHandler2, value);
				closeHandler = Interlocked.CompareExchange(ref closeHandler_0, value2, closeHandler2);
			}
			while ((object)closeHandler != closeHandler2);
		}
	}

	public event WaitingForEmailHandler OnAwaitingConfirmation
	{
		[CompilerGenerated]
		add
		{
			WaitingForEmailHandler waitingForEmailHandler = waitingForEmailHandler_0;
			WaitingForEmailHandler waitingForEmailHandler2;
			do
			{
				waitingForEmailHandler2 = waitingForEmailHandler;
				WaitingForEmailHandler value2 = (WaitingForEmailHandler)Delegate.Combine(waitingForEmailHandler2, value);
				waitingForEmailHandler = Interlocked.CompareExchange(ref waitingForEmailHandler_0, value2, waitingForEmailHandler2);
			}
			while ((object)waitingForEmailHandler != waitingForEmailHandler2);
		}
		[CompilerGenerated]
		remove
		{
			WaitingForEmailHandler waitingForEmailHandler = waitingForEmailHandler_0;
			WaitingForEmailHandler waitingForEmailHandler2;
			do
			{
				waitingForEmailHandler2 = waitingForEmailHandler;
				WaitingForEmailHandler value2 = (WaitingForEmailHandler)Delegate.Remove(waitingForEmailHandler2, value);
				waitingForEmailHandler = Interlocked.CompareExchange(ref waitingForEmailHandler_0, value2, waitingForEmailHandler2);
			}
			while ((object)waitingForEmailHandler != waitingForEmailHandler2);
		}
	}

	public event ErrorHandler OnError
	{
		[CompilerGenerated]
		add
		{
			ErrorHandler errorHandler = errorHandler_0;
			ErrorHandler errorHandler2;
			do
			{
				errorHandler2 = errorHandler;
				ErrorHandler value2 = (ErrorHandler)Delegate.Combine(errorHandler2, value);
				errorHandler = Interlocked.CompareExchange(ref errorHandler_0, value2, errorHandler2);
			}
			while ((object)errorHandler != errorHandler2);
		}
		[CompilerGenerated]
		remove
		{
			ErrorHandler errorHandler = errorHandler_0;
			ErrorHandler errorHandler2;
			do
			{
				errorHandler2 = errorHandler;
				ErrorHandler value2 = (ErrorHandler)Delegate.Remove(errorHandler2, value);
				errorHandler = Interlocked.CompareExchange(ref errorHandler_0, value2, errorHandler2);
			}
			while ((object)errorHandler != errorHandler2);
		}
	}

	public event StatusErrorHandler OnStatusError
	{
		[CompilerGenerated]
		add
		{
			StatusErrorHandler statusErrorHandler = statusErrorHandler_0;
			StatusErrorHandler statusErrorHandler2;
			do
			{
				statusErrorHandler2 = statusErrorHandler;
				StatusErrorHandler value2 = (StatusErrorHandler)Delegate.Combine(statusErrorHandler2, value);
				statusErrorHandler = Interlocked.CompareExchange(ref statusErrorHandler_0, value2, statusErrorHandler2);
			}
			while ((object)statusErrorHandler != statusErrorHandler2);
		}
		[CompilerGenerated]
		remove
		{
			StatusErrorHandler statusErrorHandler = statusErrorHandler_0;
			StatusErrorHandler statusErrorHandler2;
			do
			{
				statusErrorHandler2 = statusErrorHandler;
				StatusErrorHandler value2 = (StatusErrorHandler)Delegate.Remove(statusErrorHandler2, value);
				statusErrorHandler = Interlocked.CompareExchange(ref statusErrorHandler_0, value2, statusErrorHandler2);
			}
			while ((object)statusErrorHandler != statusErrorHandler2);
		}
	}

	public event SuccessfulInit OnAfterInit
	{
		[CompilerGenerated]
		add
		{
			SuccessfulInit successfulInit = successfulInit_0;
			SuccessfulInit successfulInit2;
			do
			{
				successfulInit2 = successfulInit;
				SuccessfulInit value2 = (SuccessfulInit)Delegate.Combine(successfulInit2, value);
				successfulInit = Interlocked.CompareExchange(ref successfulInit_0, value2, successfulInit2);
			}
			while ((object)successfulInit != successfulInit2);
		}
		[CompilerGenerated]
		remove
		{
			SuccessfulInit successfulInit = successfulInit_0;
			SuccessfulInit successfulInit2;
			do
			{
				successfulInit2 = successfulInit;
				SuccessfulInit value2 = (SuccessfulInit)Delegate.Remove(successfulInit2, value);
				successfulInit = Interlocked.CompareExchange(ref successfulInit_0, value2, successfulInit2);
			}
			while ((object)successfulInit != successfulInit2);
		}
	}

	public event MessageHandler OnMessage
	{
		[CompilerGenerated]
		add
		{
			MessageHandler messageHandler = messageHandler_0;
			MessageHandler messageHandler2;
			do
			{
				messageHandler2 = messageHandler;
				MessageHandler value2 = (MessageHandler)Delegate.Combine(messageHandler2, value);
				messageHandler = Interlocked.CompareExchange(ref messageHandler_0, value2, messageHandler2);
			}
			while ((object)messageHandler != messageHandler2);
		}
		[CompilerGenerated]
		remove
		{
			MessageHandler messageHandler = messageHandler_0;
			MessageHandler messageHandler2;
			do
			{
				messageHandler2 = messageHandler;
				MessageHandler value2 = (MessageHandler)Delegate.Remove(messageHandler2, value);
				messageHandler = Interlocked.CompareExchange(ref messageHandler_0, value2, messageHandler2);
			}
			while ((object)messageHandler != messageHandler2);
		}
	}

	public event UserSetReadyStateHandler OnUserSetReady
	{
		[CompilerGenerated]
		add
		{
			UserSetReadyStateHandler userSetReadyStateHandler = userSetReadyStateHandler_0;
			UserSetReadyStateHandler userSetReadyStateHandler2;
			do
			{
				userSetReadyStateHandler2 = userSetReadyStateHandler;
				UserSetReadyStateHandler value2 = (UserSetReadyStateHandler)Delegate.Combine(userSetReadyStateHandler2, value);
				userSetReadyStateHandler = Interlocked.CompareExchange(ref userSetReadyStateHandler_0, value2, userSetReadyStateHandler2);
			}
			while ((object)userSetReadyStateHandler != userSetReadyStateHandler2);
		}
		[CompilerGenerated]
		remove
		{
			UserSetReadyStateHandler userSetReadyStateHandler = userSetReadyStateHandler_0;
			UserSetReadyStateHandler userSetReadyStateHandler2;
			do
			{
				userSetReadyStateHandler2 = userSetReadyStateHandler;
				UserSetReadyStateHandler value2 = (UserSetReadyStateHandler)Delegate.Remove(userSetReadyStateHandler2, value);
				userSetReadyStateHandler = Interlocked.CompareExchange(ref userSetReadyStateHandler_0, value2, userSetReadyStateHandler2);
			}
			while ((object)userSetReadyStateHandler != userSetReadyStateHandler2);
		}
	}

	public event UserAcceptHandler OnUserAccept
	{
		[CompilerGenerated]
		add
		{
			UserAcceptHandler userAcceptHandler = userAcceptHandler_0;
			UserAcceptHandler userAcceptHandler2;
			do
			{
				userAcceptHandler2 = userAcceptHandler;
				UserAcceptHandler value2 = (UserAcceptHandler)Delegate.Combine(userAcceptHandler2, value);
				userAcceptHandler = Interlocked.CompareExchange(ref userAcceptHandler_0, value2, userAcceptHandler2);
			}
			while ((object)userAcceptHandler != userAcceptHandler2);
		}
		[CompilerGenerated]
		remove
		{
			UserAcceptHandler userAcceptHandler = userAcceptHandler_0;
			UserAcceptHandler userAcceptHandler2;
			do
			{
				userAcceptHandler2 = userAcceptHandler;
				UserAcceptHandler value2 = (UserAcceptHandler)Delegate.Remove(userAcceptHandler2, value);
				userAcceptHandler = Interlocked.CompareExchange(ref userAcceptHandler_0, value2, userAcceptHandler2);
			}
			while ((object)userAcceptHandler != userAcceptHandler2);
		}
	}

	public string GetTradeStatusErrorString(TradeStatusType tradeStatusType)
	{
		return tradeStatusType switch
		{
			TradeStatusType.OnGoing => "is still going on", 
			TradeStatusType.CompletedSuccessfully => "completed successfully", 
			TradeStatusType.Empty => "completed empty - no items were exchanged", 
			TradeStatusType.TradeCancelled => "was cancelled " + (bool_1 ? "by bot" : "by other user"), 
			TradeStatusType.SessionExpired => string.Format("expired because {0} timed out", bool_0 ? "other user" : "bot"), 
			TradeStatusType.TradeFailed => "failed unexpectedly", 
			TradeStatusType.PendingConfirmation => "completed - pending confirmation", 
			_ => "STATUS IS UNKNOWN - THIS SHOULD NEVER HAPPEN!", 
		};
	}

	internal Trade(SteamWeb steamWeb)
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		TradeStarted = false;
		OtherIsReady = false;
		MeIsReady = false;
		tradeSession_0 = new TradeSession(steamWeb);
		list_0 = new List<TradeEvent>();
		dictionary_0 = new Dictionary<int, TradeUserAssets>();
		list_2 = new List<TradeUserAssets>();
		list_1 = new List<TradeUserAssets>();
	}

	public bool CancelTrade()
	{
		bool_1 = true;
		return method_0(tradeSession_0.method_10);
	}

	public bool AddItem(ulong itemid, int appid, long contextid)
	{
		return AddItem(new TradeUserAssets(appid, contextid, itemid));
	}

	public bool AddItem(TradeUserAssets item)
	{
		_003C_003Ec__DisplayClass84_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass84_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.item = item;
		CS_0024_003C_003E8__locals0.slot = method_5();
		bool num = method_0(() => CS_0024_003C_003E8__locals0._003C_003E4__this.tradeSession_0.method_6(CS_0024_003C_003E8__locals0.item.assetid, CS_0024_003C_003E8__locals0.slot, CS_0024_003C_003E8__locals0.item.appid, CS_0024_003C_003E8__locals0.item.contextid));
		if (num)
		{
			dictionary_0[CS_0024_003C_003E8__locals0.slot] = CS_0024_003C_003E8__locals0.item;
		}
		return num;
	}

	public bool RemoveItem(TradeUserAssets item)
	{
		return RemoveItem(item.assetid, item.appid, item.contextid);
	}

	public bool RemoveItem(ulong itemid, int appid = 440, long contextid = 2L)
	{
		_003C_003Ec__DisplayClass86_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass86_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.itemid = itemid;
		CS_0024_003C_003E8__locals0.appid = appid;
		CS_0024_003C_003E8__locals0.contextid = contextid;
		CS_0024_003C_003E8__locals0.slot = method_6(CS_0024_003C_003E8__locals0.itemid);
		if (!CS_0024_003C_003E8__locals0.slot.HasValue)
		{
			return false;
		}
		bool num = method_0(() => CS_0024_003C_003E8__locals0._003C_003E4__this.tradeSession_0.method_7(CS_0024_003C_003E8__locals0.itemid, CS_0024_003C_003E8__locals0.slot.Value, CS_0024_003C_003E8__locals0.appid, CS_0024_003C_003E8__locals0.contextid));
		if (num)
		{
			dictionary_0.Remove(CS_0024_003C_003E8__locals0.slot.Value);
		}
		return num;
	}

	public bool SendMessage(string msg)
	{
		_003C_003Ec__DisplayClass87_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass87_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.msg = msg;
		return method_0(() => CS_0024_003C_003E8__locals0._003C_003E4__this.tradeSession_0.method_5(CS_0024_003C_003E8__locals0.msg));
	}

	public bool SetReady(bool ready)
	{
		_003C_003Ec__DisplayClass88_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass88_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.ready = ready;
		if (!CS_0024_003C_003E8__locals0.ready)
		{
			MeIsReady = false;
		}
		method_7();
		return method_0(() => CS_0024_003C_003E8__locals0._003C_003E4__this.tradeSession_0.method_8(CS_0024_003C_003E8__locals0.ready));
	}

	public bool AcceptTrade()
	{
		if (!MeIsReady)
		{
			return false;
		}
		method_7();
		return method_0(tradeSession_0.method_9);
	}

	private T method_0<T>(Func<T> webEvent)
	{
		int num = 0;
		while (true)
		{
			if (num < 3)
			{
				if (HasTradeEnded)
				{
					break;
				}
				try
				{
					T val = webEvent();
					if (!EqualityComparer<T>.Default.Equals(val, default(T)))
					{
						return val;
					}
				}
				catch (Exception value)
				{
					Console.WriteLine(value);
				}
				if (num != 3)
				{
					Thread.Sleep(600);
				}
				num++;
				continue;
			}
			return default(T);
		}
		return default(T);
	}

	public bool Poll()
	{
		if (!TradeStarted)
		{
			TradeStarted = true;
			if (successfulInit_0 != null)
			{
				successfulInit_0();
			}
		}
		TradeStatus tradeStatus = method_0(tradeSession_0.method_4);
		if (tradeStatus == null)
		{
			return false;
		}
		TradeStatusType tradeStatusType = (TradeStatusType)tradeStatus.trade_status;
		switch (tradeStatusType)
		{
		case TradeStatusType.OnGoing:
		case TradeStatusType.CompletedSuccessfully:
			HasTradeCompletedOk = true;
			return false;
		case TradeStatusType.Empty:
			int_0++;
			if (int_0 < 3)
			{
				return false;
			}
			goto default;
		default:
			method_4(tradeStatusType);
			OtherUserCancelled = true;
			return false;
		case TradeStatusType.PendingConfirmation:
			IsTradeAwaitingConfirmation = true;
			long_0 = long.Parse(tradeStatus.tradeid);
			return false;
		}
	}

	internal void method_1()
	{
		waitingForEmailHandler_0?.Invoke(long_0);
	}

	internal void method_2()
	{
		closeHandler_0?.Invoke();
	}

	internal void method_3(string string_0)
	{
		errorHandler_0?.Invoke(string_0);
	}

	internal void method_4(TradeStatusType tradeStatusType_0)
	{
		statusErrorHandler_0?.Invoke(tradeStatusType_0);
	}

	private int method_5()
	{
		int i;
		for (i = 0; dictionary_0.ContainsKey(i); i++)
		{
		}
		return i;
	}

	private int? method_6(ulong ulong_0)
	{
		foreach (int key in dictionary_0.Keys)
		{
			if (dictionary_0[key].assetid == ulong_0)
			{
				return key;
			}
		}
		return null;
	}

	private void method_7()
	{
		if (!dictionary_0.Values.OrderBy((TradeUserAssets o) => o).SequenceEqual(MyOfferedItems.OrderBy((TradeUserAssets o) => o)))
		{
			throw new TradeException("Error validating local copy of offered items in the trade");
		}
	}
}
