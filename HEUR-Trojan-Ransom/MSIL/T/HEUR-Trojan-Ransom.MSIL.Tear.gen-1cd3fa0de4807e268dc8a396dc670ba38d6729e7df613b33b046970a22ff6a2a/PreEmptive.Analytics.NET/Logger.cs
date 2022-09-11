using System;
using System.Collections.Concurrent;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using PreEmptive.Analytics.Common;

namespace PreEmptive.Analytics.NET;

public class Logger : LoggerBase, ILogger
{
	[CompilerGenerated]
	private sealed class Class26
	{
		public Logger logger_0;

		public string string_0;

		public void method_0()
		{
			int num = -6662;
			int num2 = num;
			num = -6662;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			logger_0.method_0(string_0);
		}
	}

	private Thread thread_0;

	private ConcurrentQueue<string> concurrentQueue_0;

	private AutoResetEvent autoResetEvent_0;

	public Logger(LoggingLevel logging, [Optional] string filename)
	{
		int num = 8;
		base._002Ector(logging);
		Logger logger_0 = this;
		try
		{
			filename = filename ?? Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "튆횓틢껝닑뛴닗뻞닓뚜닚긪刢");
		}
		catch
		{
			filename = filename ?? "튆횓틢껝닑뛴닗뻞닓뚜닚긪刢";
		}
		autoResetEvent_0 = new AutoResetEvent(initialState: false);
		concurrentQueue_0 = new ConcurrentQueue<string>();
		thread_0 = new Thread((ThreadStart)delegate
		{
			int num2 = -6662;
			int num3 = num2;
			num2 = -6662;
			switch (num3 == num2)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				logger_0.method_0(filename);
				break;
			}
		})
		{
			Priority = ThreadPriority.Lowest,
			IsBackground = true
		};
		thread_0.Start();
	}

	public void LogError(string message)
	{
		int num = 2;
		int num2 = 2;
		int num3 = num2;
		while (true)
		{
			switch (num3)
			{
			case 0:
				concurrentQueue_0.Enqueue(string.Format("횗튌\ude80튙횀튔꺒닍뚂닃", message));
				autoResetEvent_0.Set();
				num2 = 1;
				num3 = num2;
				continue;
			case 1:
				return;
			}
			if (!base.MessageLoggingLevel.HasFlag(LoggingLevel.Error))
			{
				return;
			}
			num2 = -11792;
			int num4 = num2;
			num2 = -11792;
			switch (num4 == num2)
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
			num2 = 0;
			num3 = num2;
		}
	}

	public void LogWarning(string message)
	{
		int num = 18;
		int num2 = 2;
		int num3 = num2;
		while (true)
		{
			switch (num3)
			{
			case 0:
				if (1 == 0)
				{
				}
				concurrentQueue_0.Enqueue(string.Format("뛥닿뻠닸뛻닠긕剬噲別幢别", message));
				autoResetEvent_0.Set();
				num2 = 1;
				num3 = num2;
				continue;
			case 1:
				return;
			}
			if (!base.MessageLoggingLevel.HasFlag(LoggingLevel.Warning))
			{
				return;
			}
			num2 = 29714;
			int num4 = num2;
			num2 = 29714;
			switch (num4 == num2)
			{
			case false:
			case true:
				return;
			}
			if (0 == 0)
			{
			}
			num2 = 0;
			num3 = num2;
		}
	}

	public void LogInfo(string message)
	{
		int num = 7;
		int num2 = 2;
		int num3 = num2;
		while (true)
		{
			switch (num3)
			{
			case 0:
				concurrentQueue_0.Enqueue(string.Format("튛횘튔껡늈뚖닉뺎닏", message));
				autoResetEvent_0.Set();
				num2 = 1;
				num3 = num2;
				continue;
			case 1:
				return;
			}
			if (!base.MessageLoggingLevel.HasFlag(LoggingLevel.Info))
			{
				return;
			}
			num2 = 5586;
			int num4 = num2;
			num2 = 5586;
			switch (num4 == num2)
			{
			case false:
			case true:
				return;
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			num2 = 0;
			num3 = num2;
		}
	}

	private void method_0(string string_0)
	{
		int num = 14;
		string result = default(string);
		while (true)
		{
			if (true)
			{
			}
			autoResetEvent_0.WaitOne();
			try
			{
				StreamWriter streamWriter = new StreamWriter(string_0, append: true);
				try
				{
					int num2 = -25220;
					int num3 = num2;
					num2 = -25220;
					int num4;
					switch (num3 == num2)
					{
					default:
						if (0 == 0)
						{
						}
						num2 = 4;
						num4 = num2;
						goto IL_00f8;
					case false:
					case true:
						{
							num2 = 5;
							num4 = num2;
							goto IL_00f8;
						}
						IL_00f8:
						while (true)
						{
							switch (num4)
							{
							case 6:
								if (concurrentQueue_0.TryDequeue(out result))
								{
									num2 = 2;
									num4 = num2;
									continue;
								}
								goto default;
							default:
								num2 = 0;
								num4 = num2;
								continue;
							case 2:
								streamWriter.WriteLine(string.Concat(DateTime.Now, "꺒", result));
								num2 = 1;
								num4 = num2;
								continue;
							case 0:
								if (concurrentQueue_0.Count <= 0)
								{
									num2 = 3;
									num4 = num2;
								}
								else
								{
									num2 = 6;
									num4 = num2;
								}
								continue;
							case 3:
								break;
							case 5:
								goto end_IL_00f8;
							}
							goto case false;
							continue;
							end_IL_00f8:
							break;
						}
						break;
					}
				}
				finally
				{
					int num2 = 2;
					int num4 = num2;
					while (true)
					{
						switch (num4)
						{
						default:
							if (streamWriter != null)
							{
								num2 = 0;
								num4 = num2;
								continue;
							}
							break;
						case 0:
							((IDisposable)streamWriter).Dispose();
							num2 = 1;
							num4 = num2;
							continue;
						case 1:
							break;
						}
						break;
					}
				}
			}
			catch
			{
			}
		}
	}
}
