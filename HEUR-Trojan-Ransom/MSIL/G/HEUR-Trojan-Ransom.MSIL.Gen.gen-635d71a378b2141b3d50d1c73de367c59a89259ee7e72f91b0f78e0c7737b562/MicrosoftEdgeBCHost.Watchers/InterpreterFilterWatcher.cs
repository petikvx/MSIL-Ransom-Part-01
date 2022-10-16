using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InterpreterFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PrintProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintProc()
	{
	}
}
