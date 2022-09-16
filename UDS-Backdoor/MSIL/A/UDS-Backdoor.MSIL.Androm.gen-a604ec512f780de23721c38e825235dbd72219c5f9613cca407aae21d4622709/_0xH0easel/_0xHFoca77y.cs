using System;
using System.Threading;
using System.Threading.Tasks;

namespace _0xH0easel;

internal static class _0xHFoca77y
{
	public static Task<T> _0xHShinnie3<T>(this TaskFactory<T> _0xHThr4ldoms, Func<T> _0xHNethe0wo0lds)
	{
		return _0xHThr4ldoms.StartNew(_0xHNethe0wo0lds, CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default);
	}

	public static Task _0xHScatterat6ons(this TaskFactory _0xHFootli7g, Action _0xHLen0ths)
	{
		return _0xHFootli7g.StartNew(_0xHLen0ths, CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default);
	}

	public static Task<Task> _0xHO3sperms(this TaskFactory _0xHDri1less, Func<Task> _0xHGo5ernment)
	{
		return _0xHDri1less.StartNew(_0xHGo5ernment, CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default);
	}
}
