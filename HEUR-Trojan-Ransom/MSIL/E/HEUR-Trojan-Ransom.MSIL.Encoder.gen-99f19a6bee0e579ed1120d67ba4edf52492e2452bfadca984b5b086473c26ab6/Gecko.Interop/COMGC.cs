using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace Gecko.Interop;

internal sealed class COMGC : IDisposable, nsITimerCallback
{
	private sealed class GCData
	{
		private object obj;

		private bool final;

		public bool CanFree => obj != null;

		public GCData(object obj, bool final)
		{
			this.obj = obj;
			this.final = final;
		}

		public void Free()
		{
			object o = Interlocked.Exchange(ref obj, null);
			if (final)
			{
				Marshal.FinalReleaseComObject(o);
			}
			else
			{
				Marshal.ReleaseComObject(o);
			}
		}
	}

	private nsITimer _timer;

	private object _syncRoot = new object();

	private Queue<GCData> _queue = new Queue<GCData>();

	public COMGC()
	{
		_timer = Xpcom.CreateInstance<nsITimer>("@mozilla.org/timer;1");
		_timer.InitWithCallback(this, 5000u, 1u);
	}

	public void SetDelay(uint delay)
	{
		if (_timer == null)
		{
			throw new ObjectDisposedException(GetType().Name);
		}
		_timer.SetDelayAttribute(delay);
	}

	public void Free<T>(ref T obj) where T : class
	{
		Free(ref obj, finalize: false);
	}

	public void FinalFree<T>(ref T obj) where T : class
	{
		Free(ref obj, finalize: true);
	}

	private void Free<T>(ref T obj, bool finalize) where T : class
	{
		if (_timer == null)
		{
			return;
		}
		GCData gCData = new GCData(Interlocked.Exchange(ref obj, null), finalize);
		if (gCData.CanFree)
		{
			Monitor.Enter(_syncRoot);
			try
			{
				_queue.Enqueue(gCData);
			}
			finally
			{
				Monitor.Exit(_syncRoot);
			}
		}
	}

	public void Notify(nsITimer timer)
	{
		if (!Monitor.TryEnter(_syncRoot))
		{
			return;
		}
		try
		{
			for (int num = _queue.Count; num > 0; num--)
			{
				_queue.Dequeue().Free();
			}
		}
		finally
		{
			Monitor.Exit(_syncRoot);
		}
	}

	public void Dispose()
	{
		if (_timer != null)
		{
			_timer.Cancel();
			nsITimer nsITimer = Interlocked.Exchange(ref _timer, null);
			if (nsITimer != null)
			{
				Marshal.ReleaseComObject(nsITimer);
			}
			_timer = null;
		}
		GC.SuppressFinalize(this);
	}
}
