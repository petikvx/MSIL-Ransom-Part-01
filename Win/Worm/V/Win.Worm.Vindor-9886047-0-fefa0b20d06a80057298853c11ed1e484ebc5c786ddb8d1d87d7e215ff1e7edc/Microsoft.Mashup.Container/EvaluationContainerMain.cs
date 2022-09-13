#define TRACE
using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.Mashup.Engine.Interface;
using Microsoft.Mashup.Engine.Interface.Tracing;
using Microsoft.Mashup.Evaluator;
using Microsoft.Mashup.Evaluator.Interface;
using Microsoft.Mashup.Tracing;

namespace Microsoft.Mashup.Container;

internal class EvaluationContainerMain
{
	private enum ErrorMode : uint
	{
		Default = 0u,
		SEM_FAILCRITICALERRORS = 1u,
		SEM_NOALIGNMENTFAULTEXCEPT = 4u,
		SEM_NOGPFAULTERRORBOX = 2u,
		SEM_NOOPENFILEERRORBOX = 32768u,
		All = 32773u
	}

	private sealed class ExceptionHandler : IExceptionHandler2
	{
		private readonly EvaluationContainerMain containerMain;

		public ExceptionHandler(EvaluationContainerMain containerMain)
		{
			this.containerMain = containerMain;
		}

		public bool TryHandleException(Exception exception)
		{
			int exitCode = -2147467259;
			try
			{
				if (exception is OutOfMemoryException)
				{
					exitCode = -2147024882;
				}
				else
				{
					exitCode = new ErrorWrapper(exception).ErrorCode;
					IHostTrace val = EvaluatorTracing.CreateTrace("EvaluationContainerMain/ExceptionHandler/HandleException", (IEngineHost)null, TraceEventType.Information);
					try
					{
						if (containerMain.containerID.HasValue)
						{
							val.Add("containerID", (object)containerMain.containerID.Value);
						}
						val.Add(exception);
					}
					finally
					{
						((IDisposable)val)?.Dispose();
					}
				}
				EvaluatorTracing.Service.Flush();
				EvaluatorTracing.Service.Close();
				Trace.Flush();
				Trace.Close();
			}
			finally
			{
				Environment.Exit(exitCode);
			}
			return false;
		}
	}

	private const int MBInBytes = 1048576;

	private const uint QUOTA_LIMITS_HARDWS_MIN_DISABLE = 2u;

	private const uint QUOTA_LIMITS_HARDWS_MIN_ENABLE = 1u;

	private const uint QUOTA_LIMITS_HARDWS_MAX_DISABLE = 8u;

	private const uint QUOTA_LIMITS_HARDWS_MAX_ENABLE = 4u;

	private const uint PROCESS_MODE_BACKGROUND_BEGIN = 1048576u;

	private int? containerID;

	[STAThread]
	private static int Main(string[] args)
	{
		return new EvaluationContainerMain().SafeRun(args);
	}

	private int SafeRun(string[] args)
	{
		SafeThread2.AddExceptionHandler((IExceptionHandler2)(object)new ExceptionHandler(this));
		ParameterizedThreadStart parameterizedThreadStart = SafeThread2.CreateThreadStart((ParameterizedThreadStart)Run);
		parameterizedThreadStart(args);
		return 0;
	}

	private void Run(object args)
	{
		//IL_0138: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		WindowsErrorReporting.DisableCrashDialog();
		EvaluatorTracing.Service = (ITracingService)(object)TracingService.Instance;
		string text = null;
		string text2 = null;
		string text3 = null;
		int? num = null;
		string[] array = (string[])args;
		int num2 = 0;
		while (true)
		{
			if (num2 < array.Length)
			{
				string text4 = array[num2];
				if (string.CompareOrdinal(text4, "/debug") == 0)
				{
					Debugger.Launch();
				}
				else if (text == null)
				{
					text = text4;
				}
				else if (text2 == null)
				{
					text2 = text4;
				}
				else if (text3 == null)
				{
					text3 = text4;
				}
				else if (!containerID.HasValue)
				{
					containerID = int.Parse(text4, CultureInfo.InvariantCulture);
				}
				else
				{
					if (num.HasValue)
					{
						throw new InvalidOperationException();
					}
					num = int.Parse(text4, CultureInfo.InvariantCulture);
				}
				num2++;
				continue;
			}
			if (text != null && text2 != null && text3 != null && containerID.HasValue && num.HasValue)
			{
				break;
			}
			throw new InvalidOperationException();
		}
		SetProcessWorkingSetSize(num.Value);
		AnonymousPipeClientStream anonymousPipeClientStream = new AnonymousPipeClientStream(PipeDirection.In, text);
		AnonymousPipeClientStream anonymousPipeClientStream2 = new AnonymousPipeClientStream(PipeDirection.Out, text2);
		ClientPipesAttachedEvent.Set(text);
		Thread thread = new Thread(SafeThread2.CreateThreadStart((ParameterizedThreadStart)WaitForParentExitThread));
		thread.IsBackground = true;
		thread.Start(text3);
		EvaluationHost val = new EvaluationHost(containerID.Value, (Stream)anonymousPipeClientStream, (Stream)anonymousPipeClientStream2);
		val.Run();
	}

	private void SetProcessWorkingSetSize(int maxWorkingSetInMB)
	{
		IntPtr currentProcess = GetCurrentProcess();
		if (!GetProcessWorkingSetSizeEx(currentProcess, out var lpMinimumWorkingSetSize, out var lpMaximumWorkingSetSize, out var flags))
		{
			throw new Exception(string.Format(CultureInfo.InvariantCulture, "Unable to get process working set size ({0})", new object[1] { Marshal.GetLastWin32Error() }));
		}
		lpMaximumWorkingSetSize = (UIntPtr)(uint)(1048576 * maxWorkingSetInMB);
		flags = (flags & 0xFFFFFFF7u) | 4u;
		if (!SetProcessWorkingSetSizeEx(currentProcess, lpMinimumWorkingSetSize, lpMaximumWorkingSetSize, flags))
		{
			throw new Exception(string.Format(CultureInfo.InvariantCulture, "Unable to set process working set size ({0})", new object[1] { Marshal.GetLastWin32Error() }));
		}
	}

	private void WaitForParentExitThread(object state)
	{
		string name = (string)state;
		Mutex mutex = Mutex.OpenExisting(name);
		while (!mutex.WaitOne(1000))
		{
			Trace.Flush();
			EvaluatorTracing.Service.Flush();
		}
		mutex.ReleaseMutex();
		mutex.Close();
		Environment.Exit(-467599359);
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern bool SetPriorityClass(IntPtr handle, uint priorityClass);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr GetCurrentProcess();

	[DllImport("kernel32.dll")]
	private static extern bool GetProcessWorkingSetSizeEx(IntPtr hProcess, out UIntPtr lpMinimumWorkingSetSize, out UIntPtr lpMaximumWorkingSetSize, out uint flags);

	[DllImport("kernel32.dll")]
	private static extern bool SetProcessWorkingSetSizeEx(IntPtr hProcess, UIntPtr dwMinimumWorkingSetSize, UIntPtr dwMaximumWorkingSetSize, uint flags);
}
