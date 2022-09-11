using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.Caching.Hosting;
using System.Security;
using System.Security.Permissions;
using System.Text;
using System.Threading;

namespace System.Runtime.Caching;

internal sealed class PerfCounters : IDisposable
{
	private const string PERF_COUNTER_CATEGORY = ".NET Memory Cache 4.0";

	private const string CACHE_ENTRIES = "Cache Entries";

	private const string CACHE_HITS = "Cache Hits";

	private const string CACHE_HIT_RATIO = "Cache Hit Ratio";

	private const string CACHE_HIT_RATIO_BASE = "Cache Hit Ratio Base";

	private const string CACHE_MISSES = "Cache Misses";

	private const string CACHE_TRIMS = "Cache Trims";

	private const string CACHE_TURNOVER = "Cache Turnover Rate";

	private const int NUM_COUNTERS = 7;

	private static string s_appId;

	private PerformanceCounter[] _counters;

	private long[] _counterValues;

	[SecuritySafeCritical]
	[PermissionSet(SecurityAction.Assert, Unrestricted = true)]
	private static void EnsureAppIdInited()
	{
		if (s_appId != null)
		{
			return;
		}
		IApplicationIdentifier applicationIdentifier = null;
		IServiceProvider host = ObjectCache.Host;
		if (host != null)
		{
			applicationIdentifier = host.GetService(typeof(IApplicationIdentifier)) as IApplicationIdentifier;
		}
		string value = applicationIdentifier?.GetApplicationId();
		if (string.IsNullOrEmpty(value))
		{
			StringBuilder stringBuilder = new StringBuilder(512);
			if (UnsafeNativeMethods.GetModuleFileName(IntPtr.Zero, stringBuilder, 512) != 0)
			{
				value = Path.GetFileNameWithoutExtension(stringBuilder.ToString());
			}
		}
		if (string.IsNullOrEmpty(value))
		{
			value = AppDomain.CurrentDomain.FriendlyName;
		}
		Interlocked.CompareExchange(ref s_appId, value, null);
	}

	private void InitDisposableMembers(string cacheName)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0124: Expected O, but got Unknown
		//IL_0137: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		bool flag = true;
		try
		{
			StringBuilder stringBuilder = ((s_appId != null) ? new StringBuilder(s_appId + ":" + cacheName) : new StringBuilder(cacheName));
			for (int i = 0; i < stringBuilder.Length; i++)
			{
				switch (stringBuilder[i])
				{
				case '(':
					stringBuilder[i] = '[';
					break;
				case '#':
				case '/':
				case '\\':
					stringBuilder[i] = '_';
					break;
				case ')':
					stringBuilder[i] = ']';
					break;
				}
			}
			string text = stringBuilder.ToString();
			_counters = (PerformanceCounter[])(object)new PerformanceCounter[7];
			_counterValues = new long[7];
			_counters[0] = new PerformanceCounter(".NET Memory Cache 4.0", "Cache Entries", text, false);
			_counters[1] = new PerformanceCounter(".NET Memory Cache 4.0", "Cache Hits", text, false);
			_counters[2] = new PerformanceCounter(".NET Memory Cache 4.0", "Cache Hit Ratio", text, false);
			_counters[3] = new PerformanceCounter(".NET Memory Cache 4.0", "Cache Hit Ratio Base", text, false);
			_counters[4] = new PerformanceCounter(".NET Memory Cache 4.0", "Cache Misses", text, false);
			_counters[5] = new PerformanceCounter(".NET Memory Cache 4.0", "Cache Trims", text, false);
			_counters[6] = new PerformanceCounter(".NET Memory Cache 4.0", "Cache Turnover Rate", text, false);
			flag = false;
		}
		finally
		{
			if (flag)
			{
				Dispose();
			}
		}
	}

	private PerfCounters()
	{
	}

	internal PerfCounters(string cacheName)
	{
		if (cacheName == null)
		{
			throw new ArgumentNullException("cacheName");
		}
		EnsureAppIdInited();
		InitDisposableMembers(cacheName);
	}

	internal void Decrement(PerfCounterName name)
	{
		PerformanceCounter val = _counters[(int)name];
		val.Decrement();
		Interlocked.Decrement(ref _counterValues[(int)name]);
	}

	internal void Increment(PerfCounterName name)
	{
		PerformanceCounter val = _counters[(int)name];
		val.Increment();
		Interlocked.Increment(ref _counterValues[(int)name]);
	}

	internal void IncrementBy(PerfCounterName name, long value)
	{
		PerformanceCounter val = _counters[(int)name];
		val.IncrementBy(value);
		Interlocked.Add(ref _counterValues[(int)name], value);
	}

	public void Dispose()
	{
		PerformanceCounter[] counters = _counters;
		if (counters == null || Interlocked.CompareExchange(ref _counters, null, counters) != counters)
		{
			return;
		}
		for (int i = 0; i < 7; i++)
		{
			PerformanceCounter val = counters[i];
			if (val != null)
			{
				long num = Interlocked.Exchange(ref _counterValues[i], 0L);
				if (num != 0L)
				{
					val.IncrementBy(-num);
				}
				((Component)(object)val).Dispose();
			}
		}
	}
}
