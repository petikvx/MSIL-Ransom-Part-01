using System;
using System.Threading;

namespace ns0;

internal sealed class Class0 : IDisposable
{
	private Action action_0;

	public static IDisposable IDisposable_0 => new Class0(delegate
	{
	});

	public Class0(Action vViCU6Ip0ne3xkDJowmkBcuB4PZfGRg4oY7qiNAeFISzCjo2LhjAc2IeumWjbgToJbSBRGa86ZYUU2yZ8mypTx2d17Px7Mxhr8kbE9VaAZWpkpZVp8lRmav6)
	{
		action_0 = vViCU6Ip0ne3xkDJowmkBcuB4PZfGRg4oY7qiNAeFISzCjo2LhjAc2IeumWjbgToJbSBRGa86ZYUU2yZ8mypTx2d17Px7Mxhr8kbE9VaAZWpkpZVp8lRmav6;
	}

	public void vmethod_0()
	{
		Interlocked.Exchange(ref action_0, delegate
		{
		})();
	}
}
