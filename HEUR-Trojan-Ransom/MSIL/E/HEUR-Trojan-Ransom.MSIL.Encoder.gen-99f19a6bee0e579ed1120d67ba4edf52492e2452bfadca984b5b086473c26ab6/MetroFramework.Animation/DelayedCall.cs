using System;
using System.Collections.Generic;
using System.Threading;
using System.Timers;

namespace MetroFramework.Animation;

internal class DelayedCall : IDisposable
{
	public delegate void Callback();

	protected static List<DelayedCall> dcList;

	protected System.Timers.Timer timer;

	protected object timerLock;

	private Callback callback;

	protected bool cancelled;

	protected SynchronizationContext context;

	private DelayedCall<object>.Callback oldCallback;

	private object oldData;

	public static int RegisteredCount
	{
		get
		{
			lock (dcList)
			{
				return dcList.Count;
			}
		}
	}

	public static bool IsAnyWaiting
	{
		get
		{
			lock (dcList)
			{
				foreach (DelayedCall dc in dcList)
				{
					if (dc.IsWaiting)
					{
						return true;
					}
				}
			}
			return false;
		}
	}

	public bool IsWaiting
	{
		get
		{
			lock (timerLock)
			{
				return timer.Enabled && !cancelled;
			}
		}
	}

	public int Milliseconds
	{
		get
		{
			lock (timerLock)
			{
				return (int)timer.Interval;
			}
		}
		set
		{
			lock (timerLock)
			{
				if (value < 0)
				{
					throw new ArgumentOutOfRangeException("Milliseconds", "The new timeout must be 0 or greater.");
				}
				if (value == 0)
				{
					Cancel();
					FireNow();
					Unregister(this);
				}
				else
				{
					timer.Interval = value;
				}
			}
		}
	}

	static DelayedCall()
	{
		dcList = new List<DelayedCall>();
	}

	protected DelayedCall()
	{
		timerLock = new object();
	}

	[Obsolete("Use the static method DelayedCall.Create instead.")]
	public DelayedCall(Callback cb)
		: this()
	{
		PrepareDCObject(this, 0, async: false);
		callback = cb;
	}

	[Obsolete("Use the static method DelayedCall.Create instead.")]
	public DelayedCall(DelayedCall<object>.Callback cb, object data)
		: this()
	{
		PrepareDCObject(this, 0, async: false);
		oldCallback = cb;
		oldData = data;
	}

	[Obsolete("Use the static method DelayedCall.Start instead.")]
	public DelayedCall(Callback cb, int milliseconds)
		: this()
	{
		PrepareDCObject(this, milliseconds, async: false);
		callback = cb;
		if (milliseconds > 0)
		{
			Start();
		}
	}

	[Obsolete("Use the static method DelayedCall.Start instead.")]
	public DelayedCall(DelayedCall<object>.Callback cb, int milliseconds, object data)
		: this()
	{
		PrepareDCObject(this, milliseconds, async: false);
		oldCallback = cb;
		oldData = data;
		if (milliseconds > 0)
		{
			Start();
		}
	}

	[Obsolete("Use the method Restart of the generic class instead.")]
	public void Reset(object data)
	{
		Cancel();
		oldData = data;
		Start();
	}

	[Obsolete("Use the method Restart of the generic class instead.")]
	public void Reset(int milliseconds, object data)
	{
		Cancel();
		oldData = data;
		Reset(milliseconds);
	}

	[Obsolete("Use the method Restart instead.")]
	public void SetTimeout(int milliseconds)
	{
		Reset(milliseconds);
	}

	public static DelayedCall Create(Callback cb, int milliseconds)
	{
		DelayedCall delayedCall = new DelayedCall();
		PrepareDCObject(delayedCall, milliseconds, async: false);
		delayedCall.callback = cb;
		return delayedCall;
	}

	public static DelayedCall CreateAsync(Callback cb, int milliseconds)
	{
		DelayedCall delayedCall = new DelayedCall();
		PrepareDCObject(delayedCall, milliseconds, async: true);
		delayedCall.callback = cb;
		return delayedCall;
	}

	public static DelayedCall Start(Callback cb, int milliseconds)
	{
		DelayedCall delayedCall = Create(cb, milliseconds);
		if (milliseconds > 0)
		{
			delayedCall.Start();
		}
		else if (milliseconds == 0)
		{
			delayedCall.FireNow();
		}
		return delayedCall;
	}

	public static DelayedCall StartAsync(Callback cb, int milliseconds)
	{
		DelayedCall delayedCall = CreateAsync(cb, milliseconds);
		if (milliseconds > 0)
		{
			delayedCall.Start();
		}
		else if (milliseconds == 0)
		{
			delayedCall.FireNow();
		}
		return delayedCall;
	}

	protected static void PrepareDCObject(DelayedCall dc, int milliseconds, bool async)
	{
		if (milliseconds < 0)
		{
			throw new ArgumentOutOfRangeException("milliseconds", "The new timeout must be 0 or greater.");
		}
		dc.context = null;
		if (!async)
		{
			dc.context = SynchronizationContext.Current;
			if (dc.context == null)
			{
				throw new InvalidOperationException("Cannot delay calls synchronously on a non-UI thread. Use the *Async methods instead.");
			}
		}
		if (dc.context == null)
		{
			dc.context = new SynchronizationContext();
		}
		dc.timer = new System.Timers.Timer();
		if (milliseconds > 0)
		{
			dc.timer.Interval = milliseconds;
		}
		dc.timer.AutoReset = false;
		dc.timer.Elapsed += dc.Timer_Elapsed;
		Register(dc);
	}

	protected static void Register(DelayedCall dc)
	{
		lock (dcList)
		{
			if (!dcList.Contains(dc))
			{
				dcList.Add(dc);
			}
		}
	}

	protected static void Unregister(DelayedCall dc)
	{
		lock (dcList)
		{
			dcList.Remove(dc);
		}
	}

	public static void CancelAll()
	{
		lock (dcList)
		{
			foreach (DelayedCall dc in dcList)
			{
				dc.Cancel();
			}
		}
	}

	public static void FireAll()
	{
		lock (dcList)
		{
			foreach (DelayedCall dc in dcList)
			{
				dc.Fire();
			}
		}
	}

	public static void DisposeAll()
	{
		lock (dcList)
		{
			while (dcList.Count > 0)
			{
				dcList[0].Dispose();
			}
		}
	}

	protected virtual void Timer_Elapsed(object sender, ElapsedEventArgs e)
	{
		FireNow();
		Unregister(this);
	}

	public void Dispose()
	{
		Unregister(this);
		timer.Dispose();
	}

	public void Start()
	{
		lock (timerLock)
		{
			cancelled = false;
			timer.Start();
			Register(this);
		}
	}

	public void Cancel()
	{
		lock (timerLock)
		{
			cancelled = true;
			Unregister(this);
			timer.Stop();
		}
	}

	public void Fire()
	{
		lock (timerLock)
		{
			if (!IsWaiting)
			{
				return;
			}
			timer.Stop();
		}
		FireNow();
	}

	public void FireNow()
	{
		OnFire();
		Unregister(this);
	}

	protected virtual void OnFire()
	{
		context.Post(delegate
		{
			lock (timerLock)
			{
				if (cancelled)
				{
					return;
				}
			}
			if (callback != null)
			{
				callback();
			}
			if (oldCallback != null)
			{
				oldCallback(oldData);
			}
		}, null);
	}

	public void Reset()
	{
		lock (timerLock)
		{
			Cancel();
			Start();
		}
	}

	public void Reset(int milliseconds)
	{
		lock (timerLock)
		{
			Cancel();
			Milliseconds = milliseconds;
			Start();
		}
	}
}
internal class DelayedCall<T> : DelayedCall
{
	public new delegate void Callback(T data);

	private Callback callback;

	private T data;

	public static DelayedCall<T> Create(Callback cb, T data, int milliseconds)
	{
		DelayedCall<T> delayedCall = new DelayedCall<T>();
		DelayedCall.PrepareDCObject(delayedCall, milliseconds, async: false);
		delayedCall.callback = cb;
		delayedCall.data = data;
		return delayedCall;
	}

	public static DelayedCall<T> CreateAsync(Callback cb, T data, int milliseconds)
	{
		DelayedCall<T> delayedCall = new DelayedCall<T>();
		DelayedCall.PrepareDCObject(delayedCall, milliseconds, async: true);
		delayedCall.callback = cb;
		delayedCall.data = data;
		return delayedCall;
	}

	public static DelayedCall<T> Start(Callback cb, T data, int milliseconds)
	{
		DelayedCall<T> delayedCall = Create(cb, data, milliseconds);
		delayedCall.Start();
		return delayedCall;
	}

	public static DelayedCall<T> StartAsync(Callback cb, T data, int milliseconds)
	{
		DelayedCall<T> delayedCall = CreateAsync(cb, data, milliseconds);
		delayedCall.Start();
		return delayedCall;
	}

	protected override void OnFire()
	{
		context.Post(delegate
		{
			lock (timerLock)
			{
				if (cancelled)
				{
					return;
				}
			}
			if (callback != null)
			{
				callback(data);
			}
		}, null);
	}

	public void Reset(T data, int milliseconds)
	{
		lock (timerLock)
		{
			Cancel();
			this.data = data;
			base.Milliseconds = milliseconds;
			Start();
		}
	}
}
internal class DelayedCall<T1, T2> : DelayedCall
{
	public new delegate void Callback(T1 data1, T2 data2);

	private Callback callback;

	private T1 data1;

	private T2 data2;

	public static DelayedCall<T1, T2> Create(Callback cb, T1 data1, T2 data2, int milliseconds)
	{
		DelayedCall<T1, T2> delayedCall = new DelayedCall<T1, T2>();
		DelayedCall.PrepareDCObject(delayedCall, milliseconds, async: false);
		delayedCall.callback = cb;
		delayedCall.data1 = data1;
		delayedCall.data2 = data2;
		return delayedCall;
	}

	public static DelayedCall<T1, T2> CreateAsync(Callback cb, T1 data1, T2 data2, int milliseconds)
	{
		DelayedCall<T1, T2> delayedCall = new DelayedCall<T1, T2>();
		DelayedCall.PrepareDCObject(delayedCall, milliseconds, async: true);
		delayedCall.callback = cb;
		delayedCall.data1 = data1;
		delayedCall.data2 = data2;
		return delayedCall;
	}

	public static DelayedCall<T1, T2> Start(Callback cb, T1 data1, T2 data2, int milliseconds)
	{
		DelayedCall<T1, T2> delayedCall = Create(cb, data1, data2, milliseconds);
		delayedCall.Start();
		return delayedCall;
	}

	public static DelayedCall<T1, T2> StartAsync(Callback cb, T1 data1, T2 data2, int milliseconds)
	{
		DelayedCall<T1, T2> delayedCall = CreateAsync(cb, data1, data2, milliseconds);
		delayedCall.Start();
		return delayedCall;
	}

	protected override void OnFire()
	{
		context.Post(delegate
		{
			lock (timerLock)
			{
				if (cancelled)
				{
					return;
				}
			}
			if (callback != null)
			{
				callback(data1, data2);
			}
		}, null);
	}

	public void Reset(T1 data1, T2 data2, int milliseconds)
	{
		lock (timerLock)
		{
			Cancel();
			this.data1 = data1;
			this.data2 = data2;
			base.Milliseconds = milliseconds;
			Start();
		}
	}
}
internal class DelayedCall<T1, T2, T3> : DelayedCall
{
	public new delegate void Callback(T1 data1, T2 data2, T3 data3);

	private Callback callback;

	private T1 data1;

	private T2 data2;

	private T3 data3;

	public static DelayedCall<T1, T2, T3> Create(Callback cb, T1 data1, T2 data2, T3 data3, int milliseconds)
	{
		DelayedCall<T1, T2, T3> delayedCall = new DelayedCall<T1, T2, T3>();
		DelayedCall.PrepareDCObject(delayedCall, milliseconds, async: false);
		delayedCall.callback = cb;
		delayedCall.data1 = data1;
		delayedCall.data2 = data2;
		delayedCall.data3 = data3;
		return delayedCall;
	}

	public static DelayedCall<T1, T2, T3> CreateAsync(Callback cb, T1 data1, T2 data2, T3 data3, int milliseconds)
	{
		DelayedCall<T1, T2, T3> delayedCall = new DelayedCall<T1, T2, T3>();
		DelayedCall.PrepareDCObject(delayedCall, milliseconds, async: true);
		delayedCall.callback = cb;
		delayedCall.data1 = data1;
		delayedCall.data2 = data2;
		delayedCall.data3 = data3;
		return delayedCall;
	}

	public static DelayedCall<T1, T2, T3> Start(Callback cb, T1 data1, T2 data2, T3 data3, int milliseconds)
	{
		DelayedCall<T1, T2, T3> delayedCall = Create(cb, data1, data2, data3, milliseconds);
		delayedCall.Start();
		return delayedCall;
	}

	public static DelayedCall<T1, T2, T3> StartAsync(Callback cb, T1 data1, T2 data2, T3 data3, int milliseconds)
	{
		DelayedCall<T1, T2, T3> delayedCall = CreateAsync(cb, data1, data2, data3, milliseconds);
		delayedCall.Start();
		return delayedCall;
	}

	protected override void OnFire()
	{
		context.Post(delegate
		{
			lock (timerLock)
			{
				if (cancelled)
				{
					return;
				}
			}
			if (callback != null)
			{
				callback(data1, data2, data3);
			}
		}, null);
	}

	public void Reset(T1 data1, T2 data2, T3 data3, int milliseconds)
	{
		lock (timerLock)
		{
			Cancel();
			this.data1 = data1;
			this.data2 = data2;
			this.data3 = data3;
			base.Milliseconds = milliseconds;
			Start();
		}
	}
}
