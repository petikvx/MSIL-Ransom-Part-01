using System;
using System.Threading;

namespace ns0;

internal sealed class Class0 : IDisposable
{
	private Action action_0;

	public static IDisposable IDisposable_0 => new Class0(delegate
	{
	});

	public Class0(Action action_1)
	{
		action_0 = action_1;
	}

	public void vmethod_0()
	{
		Interlocked.Exchange(ref action_0, delegate
		{
		})();
	}
}
