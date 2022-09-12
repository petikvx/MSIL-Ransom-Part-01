using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Text;
using ns12;

namespace ns0;

internal class Class157 : Interface7
{
	internal readonly Queue<string> queue_0;

	private readonly object object_0;

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

	public Class157()
	{
		LevelFilter = TraceLevel.Verbose;
		queue_0 = new Queue<string>();
		object_0 = new object();
	}

	public void imethod_0(TraceLevel traceLevel_1, string string_0, Exception? exception_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append(DateTime.Now.ToString("yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fff", CultureInfo.InvariantCulture));
		stringBuilder.Append(" ");
		stringBuilder.Append(traceLevel_1.ToString("g"));
		stringBuilder.Append(" ");
		stringBuilder.Append(string_0);
		string item = stringBuilder.ToString();
		lock (object_0)
		{
			if (queue_0.Count >= 1000)
			{
				queue_0.Dequeue();
			}
			queue_0.Enqueue(item);
		}
	}

	string object.ToString()
	{
		lock (object_0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (string item in queue_0)
			{
				if (stringBuilder.Length > 0)
				{
					stringBuilder.AppendLine();
				}
				stringBuilder.Append(item);
			}
			return stringBuilder.ToString();
		}
	}
}
