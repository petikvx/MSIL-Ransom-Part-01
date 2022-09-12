using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using std;

namespace JARVIS;

internal class Thread : IDisposable
{
	private delegate void EntryPoint(List<object> args);

	private System.Threading.Thread thread;

	private EntryPoint entryPoint;

	private List<object> arguments;

	private static Thread[] threadsList;

	private Thread(EntryPoint start, [MarshalAs(UnmanagedType.U1)] bool IsBackground)
	{
		entryPoint = start;
		arguments = new List<object>();
		(thread = new System.Threading.Thread(startFunc)).IsBackground = IsBackground;
	}

	private void startFunc(object args)
	{
		entryPoint((List<object>)args);
	}

	private void _007EThread()
	{
	}

	public unsafe static Thread create(delegate*<List<object>, void> callback, [MarshalAs(UnmanagedType.U1)] bool IsBackground)
	{
		if (threadsList == null)
		{
			threadsList = new Thread[1000];
		}
		int num = 0;
		if (0 >= (nint)threadsList.LongLength)
		{
			goto IL_004a;
		}
		while (threadsList[num] != null && threadsList[num].thread.IsAlive)
		{
			num++;
			if (num < (nint)threadsList.LongLength)
			{
				continue;
			}
			goto IL_004a;
		}
		goto IL_0099;
		IL_0099:
		threadsList[num] = new Thread(new EntryPoint(null, (nint)callback), IsBackground);
		return threadsList[num];
		IL_004a:
		RuntimeException* ptr = (RuntimeException*)_003CModule_003E.@new(16u);
		RuntimeException* ptr2;
		try
		{
			if (ptr != null)
			{
				_003CModule_003E.std_002Eexception_002E_007Bctor_007D((exception*)ptr);
				try
				{
					*(int*)ptr = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_7RuntimeException_0040JARVIS_0040_00406B_0040);
					*(int*)((byte*)ptr + 12) = (int)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._003F_003F_C_0040_0CD_0040BPKKHFJE_0040atingiu_003F5o_003F5limite_003F5de_003F5threads_003F5ativ_0040);
				}
				catch
				{
					//try-fault
					_003CModule_003E.___CxxCallUnwindDtor((delegate*<void*, void>)(delegate*<exception*, void>)(&_003CModule_003E.std_002Eexception_002E_007Bdtor_007D), ptr);
					throw;
				}
				ptr2 = ptr;
			}
			else
			{
				ptr2 = null;
			}
		}
		catch
		{
			//try-fault
			_003CModule_003E.delete(ptr);
			throw;
		}
		RuntimeException* ptr3 = ptr2;
		_003CModule_003E._CxxThrowException(&ptr3, (_s__ThrowInfo*)System.Runtime.CompilerServices.Unsafe.AsPointer(ref _003CModule_003E._TI3PAVRuntimeException_0040JARVIS_0040_0040));
		goto IL_0099;
	}

	public static double getThreadInterval()
	{
		double num = Math.Round((double)length() * 0.5);
		if (num >= 10.0)
		{
			return num;
		}
		return 10.0;
	}

	public static int length()
	{
		int num = 0;
		int num2 = 0;
		if (0 < (nint)threadsList.LongLength)
		{
			do
			{
				if (threadsList[num2] != null && threadsList[num2].thread.IsAlive)
				{
					num++;
				}
				num2++;
			}
			while (num2 < (nint)threadsList.LongLength);
		}
		return num;
	}

	public static int abortAll()
	{
		if (threadsList == null)
		{
			return 0;
		}
		int num = length();
		int num2 = 0;
		if (0 < num)
		{
			do
			{
				if (threadsList[num2] != null)
				{
					Thread thread = threadsList[num2];
					if (thread.thread.IsAlive)
					{
						thread.thread.Abort();
					}
					((IDisposable)thread)?.Dispose();
				}
				num2++;
			}
			while (num2 < num);
		}
		return 1;
	}

	public Thread addArgument(object obj)
	{
		arguments.Add(obj);
		return this;
	}

	public Thread start()
	{
		thread.Start(arguments);
		return this;
	}

	[return: MarshalAs(UnmanagedType.U1)]
	public bool isAlive()
	{
		return thread.IsAlive;
	}

	public void abort()
	{
		if (thread.IsAlive)
		{
			thread.Abort();
		}
		((IDisposable)this)?.Dispose();
	}

	protected virtual void Dispose([MarshalAs(UnmanagedType.U1)] bool P_0)
	{
		if (!P_0)
		{
			base.Finalize();
		}
	}

	public sealed override void Dispose()
	{
		Dispose(true);
		GC.SuppressFinalize(this);
	}
}
