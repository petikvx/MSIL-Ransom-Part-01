using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using ns0;
using ns10;

namespace ns11;

internal class Class133 : Interface7
{
	[CompilerGenerated]
	private TraceLevel traceLevel_0;

	public TraceLevel LevelFilter
	{
		[CompilerGenerated]
		get
		{
			return traceLevel_0;
		}
		[CompilerGenerated]
		set
		{
			traceLevel_0 = value;
		}
	}

	public void imethod_0(TraceLevel traceLevel_1, string string_0, Exception? exception_0)
	{
		if (traceLevel_1 == TraceLevel.Off)
		{
			return;
		}
		TraceEventCache eventCache = new TraceEventCache();
		TraceEventType eventType = Class4.smethod_736(this, traceLevel_1);
		foreach (TraceListener listener in Trace.Listeners)
		{
			if (!listener.IsThreadSafe)
			{
				lock (listener)
				{
					listener.TraceEvent(eventCache, "Newtonsoft.Json", eventType, 0, string_0);
				}
			}
			else
			{
				listener.TraceEvent(eventCache, "Newtonsoft.Json", eventType, 0, string_0);
			}
			if (Trace.AutoFlush)
			{
				listener.Flush();
			}
		}
	}
}
